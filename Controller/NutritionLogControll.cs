using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
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
                DateTime queryDate = date.ToUniversalTime();//.ToUniversalTime();
                if (queryDate.Date != date.Date)
                {
                    queryDate = queryDate.AddDays(1).Date;
                }
                else
                {
                    queryDate = queryDate.Date;
                }
                NutritionLog? result = dbContext.NutritionLogs.SingleOrDefault(nl => nl.Date.Date == queryDate && nl.UserId == userId);
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
}