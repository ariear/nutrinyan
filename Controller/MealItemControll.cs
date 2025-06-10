using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using NutriNyan.Models.Enums;
public static partial class Database
{
    public abstract class NutritionLogOfDay
    {
        public string mealType { get; set; }
        public List<MealItem>? GetRowOfMealItems(DateTime dateOfDay)
        {
            Meal? meal = GetMealIfExist(this.mealType, dateOfDay);
            try
            {
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
        public bool AddMealItem(DateTime dateOfDay, int foodId, float qty, float karbohidrat,
                                    float protein, float lemak, float serat, float gula, int unitId)
        {
            Meal? meal = GetMealIfExist(this.mealType, dateOfDay);
            try
            {
                if (meal != null)
                {
                    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                    using (var dbContext = new AppDbContext(optionsBuilder.Options))
                    {
                        dbContext.Add(new MealItem
                        {
                            MealId = meal.Id,
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
        public static void UpdateMealItem(MealItem mealItem)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                using (var dbContext = new AppDbContext(optionsBuilder.Options))
                {
                    MealItem? qmealItem = dbContext.MealItems.SingleOrDefault(mi => mi.Id == mealItem.Id);
                    if (qmealItem != null)
                    {
                        qmealItem.Gula = mealItem.Gula;
                        qmealItem.Karbohidrat = mealItem.Karbohidrat;
                        qmealItem.Lemak = mealItem.Lemak;
                        qmealItem.Protein = mealItem.Protein;
                        qmealItem.Serat = mealItem.Serat;
                        qmealItem.Qty = mealItem.Qty;
                        qmealItem.UnitId = mealItem.UnitId;
                        qmealItem.UpdatedAt = DateTime.UtcNow;

                        dbContext.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Cannot save meal item", "Error", MessageBoxButtons.OK);;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cannot save meal item\nError on access database", "Error", MessageBoxButtons.OK);;
            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <summary>
    /// 
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    // public static List<MealItem>? GetRowOfMealItems(DateTime date, string mealType)
    // {
    //     try
    //     {
    //         Meal? meal = GetMealIfExist(mealType, date);
    //         if (meal != null)
    //         {
    //             var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
    //             var dbContext = new AppDbContext(optionsBuilder.Options);
    //             var result = dbContext.MealItems.Where(b => b.MealId == meal.Id);
    //             if (result != null)
    //             {
    //                 return result.ToList();
    //             }
    //             else
    //             {
    //                 return null;
    //             }
    //         }
    //         else
    //         {
    //             return null;
    //         }
    //     }
    //     catch
    //     {
    //         return null;
    //     }
    // }
}