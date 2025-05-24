using NutriNyan.Models;
using NutriNyan.Models.Enums;
using Microsoft.EntityFrameworkCore;
public static partial class Database
{
    public class UserLogged : IEntity<User>
    {
        public User? user { get; private set; }

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
                MessageBox.Show("Success saving", "Information", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK);
            }
        }
        public UserLogged(User user)
        {
            this.user = user;
        }
        public User? Get()
        {
            return user;
        }
        public bool Update(User user) // Uji coba
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                using (var dbContext = new AppDbContext(optionsBuilder.Options))
                {
                    var result = dbContext.Users.SingleOrDefault(b => b.Id == user.Id);
                    if (result != null)
                    {
                        result = user;
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Cannot save", "Error", MessageBoxButtons.OK);
                        return false;
                    }
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
}