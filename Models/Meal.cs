using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using NutriNyan.Models.Enums;

namespace NutriNyan.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public int LogId { get; set; }
        public MealType MealType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public NutritionLog Log { get; set; } = null!;
        public List<MealItem> Items { get; set; } = new();
    }
}
