using NutriNyan.Models;
using NutriNyan.Models.Enums;
using Microsoft.EntityFrameworkCore;
public static partial class Database
{
    public abstract class Genders
    {
        public string GenderName { get; set; }
        public Gender DbGender { get; set; }
        public int DbGenderId { get; set; }
        public abstract int GetGenderIndex();
        public Gender? EnsureCreated()
        {
            try
            {
                DbContextOptionsBuilder<AppDbContext> optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                using (AppDbContext dbContext = new AppDbContext(optionsBuilder.Options))
                {
                    NutriNyan.Models.Gender? result = dbContext.Genders.SingleOrDefault(g => g.Type == GenderName);
                    if (result != null)
                    {
                        return result;
                    }
                    else
                    {
                        Gender gender = new Gender
                        {
                            Type = GenderName
                        };
                        dbContext.Add(
                            gender
                        );
                        dbContext.SaveChanges();
                        return gender;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Tidak bisa mengakses Database untuk tabel Gender\n{e}", "Error", MessageBoxButtons.OK);
                return null;
            }
        }

    }
    public class LakiLaki : Genders
    {
        public GenderType genderType = GenderType.Laki_Laki;
        public LakiLaki()
        {
            GenderName = "Laki-Laki";
            DbGender = EnsureCreated();
            DbGenderId = DbGender.Id;
        }
        public override int GetGenderIndex()
        {
            return 0;
        }
    }
    public class Perempuan : Genders
    {
        public GenderType genderType = GenderType.Perempuan;
        public Perempuan()
        {
            GenderName = "Perempuan";
            DbGender = EnsureCreated();
        }
        public override int GetGenderIndex()
        {
            return 1;
        }
    }
}