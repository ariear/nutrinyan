using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public required string MealType { get; set; }
        public DateTime Date { get; set; }
        public DateTime UpdatedAt { get; set; }
        public NutritionLog Log { get; set; } = null!;
        public ICollection<MealItem> MealItems { get; set; }
    }
}
