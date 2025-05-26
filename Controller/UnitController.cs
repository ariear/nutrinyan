using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Query;

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
            if (GetDefaultUnits()!.Count != 3)
            {
                bool result = DbAddDefaultUnits();
                if (!result)
                {
                    MessageBox.Show("Tidak bisa menambahakan default unit pada database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
        private bool DbAddDefaultUnits()
        {
            try
            {
                // 1 sendok makan -> 19 gram
                // 1 sendok teh ->  6,2 gram
                // 100 gram -> 100 gram
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                var dbContext = new AppDbContext(optionsBuilder.Options);
                bool result = false;
                Dictionary<string, float> nameValueUnit = new Dictionary<string, float>{
                                                        {"1 Sendok Makan", 19F },
                                                        {"1 Sendok Teh",  6.2F},
                                                        {"100 Gram", 100F }};
                foreach (KeyValuePair<string, float> kvValue in nameValueUnit)
                {
                    result = AddUnit(unitType: kvValue.Key, weight: kvValue.Value);
                    if (!result)
                    {
                        break;
                    }
                }
                return result;
            }
            catch
            {
                return false;
            }
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