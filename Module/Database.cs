using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using NutriNyan.Models.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
    /// <para>
    /// Using int as param will overload class
    /// </para>
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
    public static User? GetUserIfExist(int userId)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var dbContext = new AppDbContext(optionsBuilder.Options);
            var result = dbContext.Users.SingleOrDefault(b => b.Id == userId);
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

    public static Water? getWaterDay(DateTime date)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var dbContext = new AppDbContext(optionsBuilder.Options);

            var startUtc = TimeZoneInfo.ConvertTimeToUtc(date.Date);
            var endUtc = TimeZoneInfo.ConvertTimeToUtc(date.Date.AddDays(1));
            var result = dbContext.Waters.Include(w => w.Entries).SingleOrDefault(b => b.CreatedAt >= startUtc && b.CreatedAt < endUtc);
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

    public static bool createWaterDay(DateTime date)
    {
        try
        {
            User? user = GetUserIfExist(UserId);
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                dbContext.Add(new Water
                {
                    UserId = user.Id,
                    Target = user.DefaultTargetWater,
                    CreatedAt = TimeZoneInfo.ConvertTimeToUtc(date.Date),
                    UpdatedAt = TimeZoneInfo.ConvertTimeToUtc(date.Date)
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

    public static void updateTargetWater(int id, int newTargetValue)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        using (var dbContext = new AppDbContext(optionsBuilder.Options))
        {
            var existingWater = dbContext.Waters.FirstOrDefault(w => w.Id == id);
            if (existingWater != null)
            {
                existingWater.Target = newTargetValue;
                existingWater.UpdatedAt = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);

                dbContext.SaveChanges();
            }
        }
    }

    public static bool addWaterEntry(int waterId, int value)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                dbContext.Add(new WaterEntry
                {
                    WaterId = waterId,
                    Value = value,
                    CreatedAt = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now),
                    UpdatedAt = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now)
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

    public static WaterEntry? GetWaterEntryById(int id)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                var entry = dbContext.WaterEntries.Find(id);
                if (entry != null)
                {
                    return entry;
                }
            }
        }
        catch
        {
            return null;
        }

        return null;
    }

    public static void updateWaterEntry(int id, int newValue, DateTime newTime)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        using (var dbContext = new AppDbContext(optionsBuilder.Options))
        {
            var existingWaterEntry = dbContext.WaterEntries.Find(id);
            if (existingWaterEntry != null)
            {
                existingWaterEntry.Value = newValue;
                existingWaterEntry.CreatedAt = TimeZoneInfo.ConvertTimeToUtc(newTime);
                existingWaterEntry.UpdatedAt = TimeZoneInfo.ConvertTimeToUtc(newTime);

                dbContext.SaveChanges();
            }
        }
    }

    public static bool DeleteWaterEntryById(int id)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                var entry = dbContext.WaterEntries.Find(id);
                if (entry != null)
                {
                    dbContext.WaterEntries.Remove(entry);
                    dbContext.SaveChanges();
                    return true;
                }
            }
        }
        catch
        {
            return false;
        }

        return false;
    }
}
