using NutriNyan.Models;
using NutriNyan.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
public static partial class Database
{
    public class UserLogged : IEntity<User>
    {
        private User? user { get; set; }
        public Genders userGender { get; private set; }
        private Dictionary<float, List<float>> NutritionNeeded = new Dictionary<float, List<float>>();
        public UserLogged(string username, string pwd, int genderId, DateTime dateBirth,
                        float tb, float bb, int genderIndex, ActivityLevel tingkatAktivitas, int purposeId)
        {
            int TargetWater = (int)Calculation.AKG.CalAKG(Logic.GetAge(dateBirth), genderIndex).Last();
            string activLevel = Logic.GetTAktifitasValue(tingkatAktivitas);
            string pwdHashed = Logic.Get_PWDHash(pwd);
            user = new User
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
            };
            SetUserGender(genderId);
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                using (var dbContext = new AppDbContext(optionsBuilder.Options))
                {
                    dbContext.Add(
                        user
                    );
                    dbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK);
            }
        }
        public UserLogged(User user)
        {
            this.user = user;
            SetUserGender(user.GenderId);
        }
        public User? Get()
        {
            return user;
        }
        private void SetUserGender(int genderId)
        {
            if (genderId == genders[0].DbGender.Id)
            {
                userGender = genders[0];
            }
            else if (genderId == genders[1].DbGender.Id)
            {
                userGender = genders[1];
            }
            else
            {
                MessageBox.Show("Error saat set gender pada user", "Error", MessageBoxButtons.OK);
            }
        }
        public bool Update(User user)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                using (var dbContext = new AppDbContext(optionsBuilder.Options))
                {
                    var result = dbContext.Users.SingleOrDefault(b => b.Id == user.Id);
                    if (result != null)
                    {
                        result.Username = user.Username;
                        result.DateBirth = user.DateBirth.ToUniversalTime();
                        result.Tb = user.Tb;
                        result.Bb = user.Bb;
                        result.DefaultTargetWater = user.DefaultTargetWater;
                        result.GenderId = user.GenderId;
                        result.PurposeId = user.PurposeId;
                        result.TingkatAktivitas = user.TingkatAktivitas;

                        dbContext.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("Cannot save", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                }
                MessageBox.Show("Data pengguna berhasil diperbarui", "Information", MessageBoxButtons.OK);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public bool UpdatePassword(string newPassword)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                using (var dbContext = new AppDbContext(optionsBuilder.Options))
                {
                    var result = dbContext.Users.SingleOrDefault(b => b.Id == user.Id);
                    if (result != null)
                    {
                        result.Password = Logic.Get_PWDHash(newPassword);
                        dbContext.SaveChanges();

                        MessageBox.Show("Password berhasil diperbarui", "Information", MessageBoxButtons.OK);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("User tidak ditemukan", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK);
                return false;
            }
        }
        public List<float> GetNutritionNeeded(DateTime date)
        {
            float age = Logic.GetAge(user.DateBirth);
            if (NutritionNeeded.ContainsKey(age)) {
                return NutritionNeeded[age];
            } else {
                int genderIndex = userGender.GetGenderIndex();
                // if (user.GenderId)
                List<float> nutritionNeed = Calculation.AKG.CalAKG(
                    age: age,
                    genderIndex: genderIndex
                );
                NutritionNeeded.Add(age, nutritionNeed);
                return nutritionNeed;
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
            var result = dbContext.Users.Include(u => u.Gender).Include(u => u.Purpose).SingleOrDefault(b => b.Username == username);
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
}