using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using NutriNyan.Models.Enums;

public static class Database
{
    public static int UserId { get; private set; }
    public static string[] MealTypes = ["Makan Pagi", "Makan Siang", "Makan Malam", "Jajan"];
    public static void SetUserId(int userId)
    {
        UserId = userId;
    }
    /// <summary>
    /// Adding a User into the database and save the changes. Return true if success and false if there is an error.
    /// </summary>
    /// <returns>bool</returns>
    public static bool AddUser(string username, string password, int genderId, int genderIndex, DateTime dateBirth, float tb, float bb, ActivityLevel aktivitasLev, int purposeId)
    {
        try
        {
            int TargetWater = (int)Calculation.AKG.CalAKG(Logic.GetAge(dateBirth), genderIndex).Last();
            string activLevel = Logic.GetTAktifitasValue(aktivitasLev);
            string pwdHashed = Logic.Get_PWDHash(password);
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                dbContext.Add(new User
                {
                    Username = username,
                    Password = pwdHashed,
                    GenderId = genderId,
                    DateBirth = dateBirth.ToUniversalTime(),
                    Tb = tb,
                    Bb = bb,
                    DefaultTargetWater = TargetWater,
                    TingkatAktivitas = activLevel,
                    PurposeId = purposeId,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
                dbContext.SaveChanges();
            }
            MessageBox.Show("Success saving", "Information", MessageBoxButtons.OK);
            return true;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK);
            return false;
        }
    }
    /// <summary>
    /// Get a food nutrition data if exist in the current database using foodName. If doesn't exist return null
    /// <para>
    /// Use Id to overload query using Id food
    /// </para>
    /// </summary>
    /// <returns></returns>
    public static Food? GetFoodIfExist(string foodName)
    {
        foodName = Logic.FoodNameTitleCase(foodName);
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        using (var dbContext = new AppDbContext(optionsBuilder.Options))
        {
            var result = dbContext.Foods.SingleOrDefault(b => b.Name == foodName);
            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
    /// <summary>
    /// Get a food nutrition data if exist in the current database using foodId. If doesn't exist return null
    /// </summary>
    /// <param name="foodId"></param>
    /// <returns></returns>
    public static Food? GetFoodIfExist(int foodId)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        using (var dbContext = new AppDbContext(optionsBuilder.Options))
        {
            var result = dbContext.Foods.SingleOrDefault(b => b.Id == foodId);
            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
    /// <summary>
    /// Get user by username if exist. If username with name is not exist or if error, return null
    /// </summary>
    /// <param name="Username"></param>
    /// <param name="db"></param>
    /// <returns></returns>
    public static User? GetUserIfExist(string username)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var dbContext = new AppDbContext(optionsBuilder.Options);
            var result = dbContext.Users.SingleOrDefault(b => b.Username == username);
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
    /// Get Unit by unitType/unitName if exist. If Unit with UnitType/Name is not exist or if error, return null.
    /// </summary>
    /// <para>
    /// Use Id to overload query using Id
    /// </para>
    /// <param name="unitName"></param>
    /// <returns></returns>
    public static Unit? GetUnitIfExist(string unitType)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var dbContext = new AppDbContext(optionsBuilder.Options);
            var result = dbContext.Units.SingleOrDefault(b => b.UnitType == unitType);
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
    /// Try to get unit data with unitId. Return null if error or didn't exist
    /// </summary>
    /// <param name="unitId"></param>
    /// <returns></returns>
    public static Unit? GetUnitIfExist(int unitId)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var dbContext = new AppDbContext(optionsBuilder.Options);
            var result = dbContext.Units.SingleOrDefault(b => b.Id == unitId);
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
    /// <summary>
    /// Saving the food data in the data base. True if success and false if error/unsuccess. Use title case for the name of the food
    /// </summary>
    /// <param name="user"></param>
    /// <param name="foodName"></param>
    /// <param name="karbohidrat"></param>
    /// <param name="protein"></param>
    /// <param name="lemak"></param>
    /// <param name="serat"></param>
    /// <param name="gula"></param>
    /// <returns></returns>
    public static bool AddFood(int userId, string foodName, float karbohidrat, float protein, float lemak, float serat, float gula, string summary)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                dbContext.Add(new Food
                {
                    Name = foodName,
                    Karbohidrat = karbohidrat,
                    Protein = protein,
                    Lemak = lemak,
                    Serat = serat,
                    Gula = gula,
                    Summary = summary,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
                );
                dbContext.SaveChanges();
            }
            return true;
        }
        catch (Exception e)
        {
            MessageBox.Show($"There is an error when saving Food\n{e}", "Information", MessageBoxButtons.OK);
            return false;
        }
    }
    public static bool AddUnit(string unitType, float weight)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                dbContext.Add(new Unit
                {
                    UnitType = unitType,
                    Weight = weight
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
                        Date = date,
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
                NutritionLog? result = dbContext.NutritionLogs.SingleOrDefault(b => b.Date.Date == date.Date && b.UserId == UserId);
                MessageBox.Show($"Come to DbContext\n{result}", "Information", MessageBoxButtons.OK);
                if (result == null)
                {
                    NutritionLog nutritionLog = new NutritionLog
                    {
                        UserId = UserId,
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
