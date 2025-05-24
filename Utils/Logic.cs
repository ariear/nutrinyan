using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using NutriNyan.Models.Enums;

public static class Logic
{
    /// <summary>
    /// Decode a string using SHA256 Algorithm
    /// </summary>
    /// <param name="pwd">password string</param>
    /// <returns>pwd_hashed: string</returns>
    public static string Get_PWDHash(string pwd)
    {
        string result;
        var encoder = System.Security.Cryptography.SHA256.Create();
        byte[] myText = System.Text.Encoding.ASCII.GetBytes(pwd);
        byte[] hashValue = encoder.ComputeHash(myText);
        result = BitConverter.ToString(hashValue).Replace("-", "");
        return result;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="username"></param>
    /// <param name="pwd"></param>
    /// <returns></returns>
    public static bool AuthCheck(string username, string pwd)
    {
        string pwd_hashed = Get_PWDHash(pwd);
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        using (var dbContext = new AppDbContext(optionsBuilder.Options))
        {
            var result = dbContext.Users.SingleOrDefault(b => b.Username == username && b.Password == pwd_hashed);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    /// <summary>
    /// Used to determine does the string is a number or not. True if reay to float parse, false if not
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    public static bool IsDigits(string Text)
    {
        bool IsDotExist = false;
        foreach (char c in Text)
        {
            if (c == '.')
            {
                if (!IsDotExist)
                {
                    IsDotExist = true;
                }
                else
                {
                    return false; // There is two dot, whisch is not valid
                }
                ;
            }
            else if (c < '0' || c > '9')
            {
                return false;
            }
        }
        return true;
    }
    /// <summary>
    /// Determine does the password meet the requirement.
    /// <para>
    /// Requirement:
    /// </para>
    /// <para>
    /// 1. Lenght must 6 or greater and has no space (" ") character.
    /// </para>
    /// <para>
    /// 2. It must consist of at least one alphabet character, one number, and one symbol.
    /// </para>
    /// </summary>
    /// <param name="pwd"></param>
    /// <returns></returns>
    public static bool IsValidPwd(string pwd)
    {
        //Password mengandung angka, huruf, dan simbol dengan minimal 6 karakter
        if (pwd.Length < 6)
        {
            return false;
        }
        bool IsDigitExist = false;
        bool IsAlphaExist = false;
        bool IsSymbolExist = false;
        foreach (char c in pwd)
        {
            if ('0' <= c && c <= '9')
            {
                IsDigitExist = true;
            }
            else if (Char.IsLetter(c))
            {
                IsAlphaExist = true;
            }
            else if (c == ' ')
            {
                return false;
            }
            else
            {
                IsSymbolExist = true;
            }
        }
        return IsDigitExist && IsAlphaExist && IsSymbolExist;

    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="ActiveLevel"></param>
    /// <returns></returns>
    public static string GetTAktifitasValue(NutriNyan.Models.Enums.ActivityLevel ActiveLevel)
    {
        switch (ActiveLevel)
        {
            case NutriNyan.Models.Enums.ActivityLevel.Ringan:
                return "Ringan";
            case NutriNyan.Models.Enums.ActivityLevel.Sedang:
                return "Sedang";
            case NutriNyan.Models.Enums.ActivityLevel.Berat:
                return "Berat";
            default:
                return "Error";
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="BirthDate"></param>
    /// <returns></returns>
    public static float GetAge(DateTime BirthDate)
    {
        return (float)Math.Round((DateTime.Now - BirthDate).TotalDays / 365.2425, 2);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static bool IsNotTodayFuture(DateTime date)
    {
        return !(date.ToString("MM-dd-yyyy") == DateTime.Now.ToString("MM-dd-yyyy")) && !(DateTime.Now < date);
    }
    /// <summary>
    /// Get formated string food name. This method is used to formated a food name string, prepared for http request address. Return null if there is no single character
    /// </summary>
    /// <param name="foodNAme"></param>
    /// <returns></returns>
    public static string? GetFoodName(string foodNAme)
    {
        string placeHolder = "";
        string[] foodNameSplit = foodNAme.Split(" ");
        for (int i = 0; i < foodNameSplit.Length; i++)
        {
            if (foodNameSplit[i] != "")
            {
                placeHolder = placeHolder + foodNameSplit[i].ToLower() + "-";
            }
        }
        if (placeHolder == "")
        {
            return null;
        }
        else
        {
            return placeHolder.Substring(0, placeHolder.Length - 1);
        }
    }
    /// <summary>
    /// Get the food name with title case for database Name column, ex: soto-ayam -> Soto Ayam
    /// </summary>
    /// <param name="foodName"></param>
    /// <returns></returns>
    public static string FoodNameTitleCase(string foodName)
    {
        System.Globalization.TextInfo ti = System.Globalization.CultureInfo.CurrentCulture.TextInfo;
        string placeHolder = ti.ToTitleCase(String.Join(" ", foodName.Split("-")));
        return placeHolder;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="mealType"></param>
    /// <returns></returns>
    public static string? GetMealTypeValue(MealType mealType)
    {
        switch (mealType)
        {
            case MealType.Breakfast:
                return Database.MealTypes[0];
            case MealType.Lunch:
                return Database.MealTypes[1];
            case MealType.Dinner:
                return Database.MealTypes[2];
            case MealType.Snack:
                return Database.MealTypes[3];
            default:
                return null;
        }
    }
}