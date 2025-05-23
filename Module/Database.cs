using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using NutriNyan.Models.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
