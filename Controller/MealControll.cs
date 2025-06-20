using NutriNyan.Models;
using NutriNyan.Models.Enums;
using Microsoft.EntityFrameworkCore;
public static partial class Database
{
    public static string[] MealTypes = ["Makan Pagi", "Makan Siang", "Makan Malam", "Jajan"];
    public class MakanPagi : NutritionLogOfDay
    {
        public MakanPagi()
        {
            mealType = "Makan Pagi";
        }
    }
    public class MakanSiang : NutritionLogOfDay
    {
        public MakanSiang()
        {
            mealType = "Makan Siang";
        }
    }
    public class MakanMalam : NutritionLogOfDay
    {
        public MakanMalam()
        {
            mealType = "Makan Malam";
        }
    }
    public class Jajan : NutritionLogOfDay
    {
        public Jajan()
        {
            mealType = "Jajan";
        }
    }
    /// <summary>
    /// Get Meal fron database using  mealtype name and datetime
    /// </summary>
    /// <param name="mealType"></param>
    /// <param name="date"></param>
    /// <returns></returns>
    public static Meal? GetMealIfExist(string mealType, DateTime date)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var dbContext = new AppDbContext(optionsBuilder.Options);
            User user = userLogged.Get();

            DateTime startUtc = date.Date.ToUniversalTime();
            DateTime endUtc = startUtc.AddDays(1);

            var result = dbContext.Meals.Include(l => l.Log).SingleOrDefault(b => b.Log.UserId == user.Id && b.MealType == mealType && b.Date >= startUtc && b.Date < endUtc); //Error
            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"Error GetMealIfExist\n{e}", "Information", MessageBoxButtons.OK);
            return null;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static bool AddMeal(int logId, MealType mealType, DateTime date)
    {
        try
        {
            string? mealTypeText = Logic.GetMealTypeValue(mealType);
            if (mealTypeText != null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                using (var dbContext = new AppDbContext(optionsBuilder.Options))
                {
                    dbContext.Add(new Meal
                    {
                        LogId = logId,
                        MealType = mealTypeText,
                        Date = date.ToUniversalTime(),
                        UpdatedAt = DateTime.UtcNow,
                    }
                    );
                    dbContext.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        catch
        {
            return false;
        }
    }
}