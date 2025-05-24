using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
public static partial class Database
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static bool AddMealItem(int mealId, int foodId, float qty, float karbohidrat,
                            float protein, float lemak, float serat, float gula, int unitId)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                dbContext.Add(new MealItem
                {
                    MealId = mealId,
                    FoodId = foodId,
                    Qty = qty,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Karbohidrat = karbohidrat,
                    Protein = protein,
                    Lemak = lemak,
                    Serat = serat,
                    Gula = gula,
                    UnitId = unitId
                }
                );
                dbContext.SaveChanges();
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public static List<MealItem>? GetRowOfMealItems(DateTime date, string mealType)
    {
        try
        {
            Meal? meal = GetMealIfExist(mealType, date);
            if (meal != null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                var dbContext = new AppDbContext(optionsBuilder.Options);
                var result = dbContext.MealItems.Where(b => b.MealId == meal.Id);
                if (result != null)
                {
                    return result.ToList();
                }
                else
                {
                    return null;
                }
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
}