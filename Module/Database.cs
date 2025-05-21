using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using NutriNyan.Models.Enums;

public static class Database
{
    public static int UserId { get; private set; }
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
    /// Get a food nutrition data if exist in the current database. If doesn't exist return null
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
    /// Try to get unit data with id kay. Return null if error or didn't exist
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
    public static bool AddMealItem()
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                dbContext.Add(new MealItem
                {
                    
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
    /// 
    /// </summary>
    /// <returns></returns>
    public static bool AddNutritionLog(int userId, string note)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                dbContext.Add(new NutritionLog
                {
                    UserId = userId,
                    Note = note,
                    Date = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
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
}
