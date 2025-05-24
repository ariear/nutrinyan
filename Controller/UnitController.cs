using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

public static partial class Database
{
    public class Units : IEntity<Unit>
    {
        List<Unit>? defaultUnits;
        string unitName;
        public Units(string unitName)
        {
            this.unitName = unitName;
            SetDefaultUnits();
        }
        public Unit? Get()
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                var dbContext = new AppDbContext(optionsBuilder.Options);
                var result = dbContext.Units.SingleOrDefault(u => u.UnitType == unitName);
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
        public bool Update(Unit unit)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                var dbContext = new AppDbContext(optionsBuilder.Options);
                var result = dbContext.Units.SingleOrDefault(u => u.Id == unit.Id);
                if (result != null)
                {
                    result = unit;
                    dbContext.SaveChanges();
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
        public List<Unit>? GetDefaultUnits()
        {
            return defaultUnits;
        }
        /// <summary>
        /// To get All default unit type
        /// </summary>
        /// <returns></returns>
        private void SetDefaultUnits()
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                var dbContext = new AppDbContext(optionsBuilder.Options);
                var result = dbContext.Units.Where(u => !u.UnitType.Contains("1 Porsi"));
                if (result != null)
                {
                    this.defaultUnits = result.ToList();
                }
                else
                {
                    return;
                }
            }
            catch
            {
                return;
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
        public Unit? GetUnitIfExist(string unitType)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                var dbContext = new AppDbContext(optionsBuilder.Options);
                var result = dbContext.Units.SingleOrDefault(u => u.UnitType == unitType);
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
        public Unit? GetUnitIfExist(int unitId)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                var dbContext = new AppDbContext(optionsBuilder.Options);
                var result = dbContext.Units.SingleOrDefault(u => u.Id == unitId);
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
        public bool AddUnit(string unitType, float weight)
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
    }
}