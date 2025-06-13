using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Calculation;
public static partial class Database
{
    
    /// <summary>
    /// Ensure that nutrition log exist, if not exist will create immediately and return it. Null if error.
    /// Note that this method also create Meals of the four types.
    /// </summary>
    /// <para>
    /// Use DateTime.UtcNow.
    /// </para>
    /// <param name="date"></param>
    /// <returns></returns>
    public static NutritionLog? EnsureNutritionLog(DateTime date, string note)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                int userId;
                User? user = userLogged.Get();
                if (user != null)
                {
                    userId = user.Id;
                }
                else
                {
                    return null;
                }
                DateTime startUtc = date.Date.ToUniversalTime();
                DateTime endUtc = startUtc.AddDays(1);

                NutritionLog? result = dbContext.NutritionLogs.SingleOrDefault(nl => nl.Date >= startUtc && nl.Date < endUtc && nl.UserId == userId);
                if (result == null)
                {
                    NutritionLog nutritionLog = new NutritionLog
                    {
                        UserId = userId,
                        Note = note,
                        Date = date.ToUniversalTime(),
                        UpdatedAt = DateTime.UtcNow
                    };
                    dbContext.Add(nutritionLog);
                    dbContext.SaveChanges();
                    foreach (string item in MealTypes)
                    {
                        dbContext.Add(new Meal
                        {
                            LogId = nutritionLog.Id,
                            MealType = item,
                            Date = date.ToUniversalTime(),
                            UpdatedAt = DateTime.UtcNow
                        }
                        );
                        dbContext.SaveChanges();
                    }
                    return nutritionLog;
                }
                else
                {
                    return result;
                }
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"Ensure NutLog Result: {e}", "Information", MessageBoxButtons.OK);
            return null;
        }
    }

    public static Dictionary<string, double> GetWeeklyCalories()
    {
        var dailyCalories = new Dictionary<string, double>();
        DateTime day = DateTime.Now;
        for (int i = 0; i < 7; i++)
        {
            Database.EnsureNutritionLog(day.AddDays(-i), "Unknown");
        }
        DateTime startUtc = DateTime.Today.ToUniversalTime();
        var startDate = startUtc.AddDays(-6);
        DateTime endUtc = startUtc.AddDays(1);

        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using var dbContext = new AppDbContext(optionsBuilder.Options);

            var caloriesData = dbContext.NutritionLogs
                .Where(n => n.UserId == userLogged.Get().Id &&
                        n.Date >= startDate &&
                        n.Date <= endUtc)
                        // n.Date >= startUtc && n.Date < endUtc)
                .Include(n => n.Meals)
                    .ThenInclude(m => m.MealItems)
                .AsEnumerable()
                .GroupBy(n => n.Date.Date)
                .Select(g => new {
                    Date = g.Key,
                    TotalCalories = g.SelectMany(n => n.Meals)
                                   .SelectMany(m => m.MealItems)
                                   .Sum(mi => Calori.CaloriCal(mi.Protein, mi.Karbohidrat, mi.Lemak, mi.Gula, mi.Serat))
                })
                .ToList();

            DateTime dateEnd = endUtc.AddDays(-1);
            for (DateTime date = startDate; date <= dateEnd; date = date.AddDays(1))
            {
                var dataForDate = caloriesData.FirstOrDefault(d => d.Date >= date && d.Date < date.AddDays(1));
                string dateKey = date.ToString("dddd", new CultureInfo("id-ID"));

                dailyCalories.Add(dateKey, dataForDate?.TotalCalories ?? 0);
            }

            return dailyCalories;
        }
        catch (Exception ex)
        {
            DateTime dateEnd = endUtc.AddDays(-1);
            for (var date = startDate; date <= dateEnd; date = date.AddDays(1))
            {
                string dateKey = date.ToString("dd/MM", CultureInfo.InvariantCulture);
                dailyCalories.Add(dateKey, 0);
            }
            return dailyCalories;
        }
    }
}