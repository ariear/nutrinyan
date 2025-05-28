using NutriNyan.Models;
using NutriNyan.Models.Enums;
using Microsoft.EntityFrameworkCore;
public static partial class Database
{
    public static Water? getWaterDay(DateTime date)
    {
        try
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var dbContext = new AppDbContext(optionsBuilder.Options);

            var startUtc = TimeZoneInfo.ConvertTimeToUtc(date.Date);
            var endUtc = TimeZoneInfo.ConvertTimeToUtc(date.Date.AddDays(1));
            var result = dbContext.Waters.Include(w => w.Entries).SingleOrDefault(b => b.CreatedAt >= startUtc && b.CreatedAt < endUtc && b.UserId == userLogged.user.Id);
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
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                dbContext.Add(new Water
                {
                    UserId = userLogged.user.Id,
                    Target = userLogged.user.DefaultTargetWater,
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