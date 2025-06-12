using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
public static partial class Database
{
    public abstract class Tujuan
    {
        public string purposeName { get; set; }
        public string deskripsi { get; set; }
        public int purposeId { get; private set; }
        public Purpose purpose { get; private set; }
        public abstract List<float> AdjustNutritionNeeded(List<float> nutritionNeeded);
        public Purpose? EnsureCreated(float CaloriMin, float CaloriMAx)
        {
            try
            {
                DbContextOptionsBuilder<AppDbContext> optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                using (AppDbContext dbContext = new AppDbContext(optionsBuilder.Options))
                {
                    NutriNyan.Models.Purpose? result = dbContext.Purposes.SingleOrDefault(g => g.Title == purposeName);
                    if (result != null)
                    {
                        return result;
                    }
                    else
                    {
                        Purpose gender = new Purpose
                        {
                            Title = purposeName,
                            TdeeMin = CaloriMin,
                            TdeeMax = CaloriMAx
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
        public void setPurpose(Purpose purpose)
        {
            this.purpose = purpose;
            this.purposeId = purpose.Id;
        }
    }
    public class HidupSehat : Tujuan
    {
        public HidupSehat()
        {
            this.purposeName = "Hidup Sehat";
            this.deskripsi = "Kecukupan gizi sesuai tabel AKG untuk hidup sehat seimbang.";
            Purpose? purpose = EnsureCreated(CaloriMin: 2_300F, CaloriMAx: 2_800F);
            if (purpose != null)
            {
                setPurpose(purpose);
            }
        }
        public override List<float> AdjustNutritionNeeded(List<float> nutritionNeeded)
        {
            return nutritionNeeded;
        }
    }
    public class Pemulihan : Tujuan
    {
        public Pemulihan()
        {
            this.purposeName = "Pemulihan";
            this.deskripsi = "Penambahan berat badan untuk memulihkan IMT dari kurus ke normal.";
            Purpose? purpose = EnsureCreated(CaloriMin: 2_500F, CaloriMAx: 3_000F);
            if (purpose != null)
            {
                setPurpose(purpose);
            }
        }
        public override List<float> AdjustNutritionNeeded(List<float> nutritionNeeded)
        {
            List<float> nutriNeedCopy =  nutritionNeeded.Select(b => b).ToList();
            nutriNeedCopy[3] = MathF.Round(nutriNeedCopy[3]*1.2F, 2);   // Kalori
            nutriNeedCopy[4] = MathF.Round(nutriNeedCopy[4]*1.15F, 2);  // Protein
            nutriNeedCopy[8] = MathF.Round(nutriNeedCopy[8]*1.2F, 2);   // Karbo
            nutriNeedCopy[9] = MathF.Round(nutriNeedCopy[9]*1.1F, 2);   // Serat
            nutriNeedCopy[5] = MathF.Round(nutriNeedCopy[5]*1.1F, 2);   // Lemak
            return nutriNeedCopy;
        }
    }
    public class DietRingan : Tujuan
    {
        public DietRingan()
        {
            this.purposeName = "Diet Ringan";
            this.deskripsi = "Diet ringan untuk menaikkan berat badan sekitar 0,25kg/minggu.";
            Purpose? purpose = EnsureCreated(CaloriMin: 1_800F, CaloriMAx: 2_500F);
            if (purpose != null)
            {
                setPurpose(purpose);
            }
        }
        public override List<float> AdjustNutritionNeeded(List<float> nutritionNeeded)
        {
            List<float> nutriNeedCopy =  nutritionNeeded.Select(b => b).ToList();
            nutriNeedCopy[3] = MathF.Round(nutriNeedCopy[3]*0.9F, 2);   // Kalori
            nutriNeedCopy[4] = MathF.Round(nutriNeedCopy[4]*0.9F, 2);   // Protein
            nutriNeedCopy[8] = MathF.Round(nutriNeedCopy[8]*0.85F, 2);  // Karbo
            nutriNeedCopy[5] = MathF.Round(nutriNeedCopy[5]*0.85F, 2);  // Lemak
            return nutriNeedCopy;
        }
    }
}