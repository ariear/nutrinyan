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
                if (userLogged.user != null) {
                    userId = userLogged.user.Id;
                } else {
                    return null;
                }
                NutritionLog? result = dbContext.NutritionLogs.SingleOrDefault(nl => nl.Date.Date == date.Date && nl.UserId == userId);
                MessageBox.Show($"Come to DbContext\n{result}", "Information", MessageBoxButtons.OK);
                if (result == null)
                {
                    NutritionLog nutritionLog = new NutritionLog
                    {
                        UserId = userId,
                        Note = note,
                        Date = date,
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
                            Date = date,
                            UpdatedAt = DateTime.UtcNow
                        }
                        );
                        dbContext.SaveChanges();
                    }
                    MessageBox.Show("Success saving to the database", "Information", MessageBoxButtons.OK);
                    return nutritionLog;
                }
                else
                {
                    return result;
                }
            }
        }
        catch
        {
            return null;
        }
    }
}