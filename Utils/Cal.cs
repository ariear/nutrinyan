using Microsoft.EntityFrameworkCore;
using NutriNyan.Models;

namespace Calculation
{
    // Class of AKG (Angka Kecukupan Gizi)
    public static class AKG
    {
        private static List<string> AKG_header = ["UsiaKurangDari", "BB(Kg)", "TB (cm)", "Energi (kkal)", "Protein", "Total", "Omega3", "Omega6", "Karbohidrat", "Serat", "Air"];
        private static List<List<float>> AKGT_Child = [// [UsiaKurangDari, BB, TB, Energi (kkal), Protein, Total, Omega3, Omega6, Karbohidrat, Serat, Air]
                                                        [0.42F, 6F, 60F, 550F, 9F, 31F, 0.5F, 4.4F, 59F, 0F, 700F],
                                                    [0.99F, 9F, 72F, 800F, 15F, 35F, 0.5F, 4.4F, 105F, 11F, 900F],
                                                    [3F, 13F, 92F, 1350F, 20F, 45F, 0.7F, 7F, 215F, 19F, 1150F],
                                                    [6F, 19F, 113F, 1400F, 25F, 50F, 0.9F, 10F, 220F, 20F, 1450F],
                                                    [9F, 27F, 130F, 1650F, 40F, 55F, 0.9F, 10F, 250F, 23F, 1650F],
                                                    ];
        private static List<List<float>> AKGT_Man = [
                                                        [12F, 36F, 145F, 2000F, 50F, 65F, 1.2F, 12F, 300F, 28F, 1850F],
                                                    [15F, 50F, 163F, 2400F, 70F, 80F, 1.6F, 16F, 350F, 34F, 2100F],
                                                    [18F, 60F, 168F, 2650F, 75F, 85F, 1.6F, 16F, 400F, 37F, 2300F],
                                                    [29F, 60F, 168F, 2650F, 65F, 75F, 1.6F, 17F, 430F, 37F, 2500F],
                                                    [49F, 60F, 166F, 2550F, 65F, 70F, 1.6F, 17F, 415F, 36F, 2500F],
                                                    [64F, 60F, 166F, 2150F, 65F, 60F, 1.6F, 14F, 340F, 30F, 2500F],
                                                    [80F, 58F, 164F, 1800F, 64F, 50F, 1.6F, 14F, 275F, 25F, 1800F],
                                                    [0F, 58F, 164F, 1600F, 64F, 45F, 1.6F, 14F, 235F, 22F, 1600F]
                                                        ];
        private static List<List<float>> AKGT_Woman = [
                                                        [12F, 38F, 147F, 1900F, 55F, 65F, 1.0F, 10F, 280F, 27F, 1850F],
                                                    [15F, 48F, 156F, 2050F, 65F, 70F, 1.1F, 11F, 300F, 29F, 2100F],
                                                    [18F, 52F, 159F, 2100F, 65F, 70F, 1.1F, 11F, 300F, 29F, 2150F],
                                                    [29F, 55F, 159F, 2250F, 60F, 65F, 1.1F, 12F, 360F, 32F, 2350F],
                                                    [49F, 56F, 158F, 2150F, 60F, 60F, 1.1F, 12F, 340F, 30F, 2350F],
                                                    [64F, 56F, 158F, 1800F, 60F, 50F, 1.1F, 11F, 280F, 25F, 2350F],
                                                    [80F, 53F, 157F, 1550F, 58F, 45F, 1.1F, 11F, 230F, 22F, 1550F],
                                                    [0F, 53F, 157F, 1400F, 58F, 40F, 1.1F, 11F, 200F, 20F, 1400F]
                                                        ];
        /// <summary>
        /// Calculate the AKG value of a person then return it
        /// </summary>
        /// <param name="age">Umur</param>
        /// <returns>List<float></returns>
        public static List<float> CalAKG(float age, int gender)
        {
            if (age <= 0)
            {
                Console.WriteLine("Cant have negative number");
                return [-1];
            }
            else
            {
                if (age <= AKGT_Child.Last()[0])
                {
                    int startIndex = 0;
                    while (startIndex < AKGT_Child.Count - 1)
                    {
                        if (age <= AKGT_Child[startIndex][0])
                        {
                            break;
                        }
                        else
                        {
                            startIndex++;
                        }
                    }
                    return AKGT_Child[startIndex];
                }
                else
                {
                    while (true)
                    {
                        int startIndex = 0;
                        switch (gender)
                        {
                            case 0:
                                while (startIndex < AKGT_Man.Count - 1)
                                {
                                    if (age <= AKGT_Man[startIndex][0])
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        startIndex++;
                                    }
                                }
                                return AKGT_Man[startIndex];
                            case 1:
                                while (startIndex < AKGT_Woman.Count - 1)
                                {
                                    if (age <= AKGT_Woman[startIndex][0])
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        startIndex++;
                                    }
                                }
                                return AKGT_Woman[startIndex];
                            default:
                                return [-1];
                        }
                    }
                }
            }
        }
    }

    // Class of IMT (Indeks Massa Tubuh)
    public static class IMT
    {
        public enum IMT_Categories
        {
            BbKurang,
            BbIdeal,
            BbLebih,

            BbGemuk,
            BbSangatGemuk
        }
        static List<string> IMT_Condition = ["Berat Badan Kurang", "Berat Badan Ideal", "Berat Badan Lebih", "Gemuk", "Sangat Gemuk"];
        static List<float> IMT_Table = [18.49F, 24.9F, 29.9F, 34.9F, 39.9F, 0F];
        /// <summary>
        /// Calculate IMT value of a person and return its value with the category
        /// </summary>
        /// <param name="BB">Berat Badan (Kg)</param>
        /// <param name="TB">Tinggi Badan (cm)</param>
        /// <returns>(IMT_Value, IMT_Condition): (float, string)</returns>
        public static (float, string) GetIMT(float BB, float TB)
        {
            float TbM = TB / 100;
            float IMT = BB / (TbM * TbM);
            int index = 0;
            while (index < IMT_Table.Count - 1)
            {
                if (IMT <= IMT_Table[index])
                {
                    break;
                }
                else
                {
                    index++;
                }
            }
            return (IMT_Table[index], IMT_Condition[index]);
        }
    }
    public static class Nutrition
    {
        public static Dictionary<string, float> CaloriValue = new Dictionary<string, float>{
            {"Protein", 4F },
            {"Karbohidrat", 4F},
            {"Lemak", 9F},
            {"Gula", 3.85F},
            {"Serat", 1F}
        };
        public static float CaloriCal(float protein, float karbo, float lemak, float gula, float serat)
        {
            return protein * CaloriValue["Protein"] + karbo * CaloriValue["Karbohidrat"]
                + lemak * CaloriValue["Lemak"] + gula * CaloriValue["Gula"] + serat * CaloriValue["Serat"]; 
        }
    }
}
