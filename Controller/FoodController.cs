using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
public static partial class Database
{
    public static class MyFoods
    {
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
            Food? food = GetFoodIfExist(foodName);
            if (food == null)
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
            else
            {
                return true;
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
        public static List<Food>? GetSomeFood(string namePattern)
        {
            try
            {
                DbContextOptionsBuilder<AppDbContext> optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                using (AppDbContext dbContext = new AppDbContext(optionsBuilder.Options))
                {
                    List<NutriNyan.Models.Food> result = dbContext.Foods.Where(f => EF.Functions.ILike(f.Name, $"%{namePattern}%")).ToList();
                    return result;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Tidak bisa mengakses Database untuk tabel Gender\n{e}", "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        public static List<Food>? GetLatestAddedFoods()
        {
            try
            {
                DbContextOptionsBuilder<AppDbContext> optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                using (AppDbContext dbContext = new AppDbContext(optionsBuilder.Options))
                {
                    List<NutriNyan.Models.Food> latestFoods = dbContext.Foods
                                    .OrderByDescending(f => f.Id)
                                    .Take(4)
                                    .ToList();
                    return latestFoods;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Tidak bisa mengakses Database untuk tabel Gender\n{e}", "Error", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}