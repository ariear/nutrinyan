using NutriNyan.Models;
using Microsoft.EntityFrameworkCore;
using NutriNyan.Models.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic;
using System.CodeDom;

public static partial class Database
{
    // Start Region of Global Attribute
    public static List<Genders> genders = [new LakiLaki(), new Perempuan()];
    public static List<NutritionLogOfDay> MealsOfADay = [new MakanPagi(), new MakanSiang(), new MakanMalam(), new Jajan()];
    public static List<Tujuan> purposes = [new HidupSehat(), new Pemulihan(), new DietRingan()];
    // Start Region of Global Attribute

    public interface IEntity<T>
    {
        public T? Get();
        public bool Update(T entity);
    }

    public static UserLogged userLogged { get; private set; }
    public static void SetUserLogged(UserLogged userValid)
    {
        userLogged = userValid;
    }
    public static Units units { get; private set; }
    public static void SetUnits()
    {
        units = new Units("100 gram");
    }
}
