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
        date = date.ToUniversalTime() + DateTimeOffset.Now.Offset;
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var dbContext = new AppDbContext(optionsBuilder.Options);
            var result = dbContext.Meals.SingleOrDefault(b => b.MealType == mealType && b.Date.Date == date.Date);
            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        catch
        {
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