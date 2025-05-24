using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriNyan.Models
{
    public class MealItem
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public float Qty { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public float Karbohidrat { get; set; }
        public float Protein { get; set; }
        public float Lemak { get; set; }
        public float Serat { get; set; }
        public float Gula { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; } = null!;

        public Meal Meal { get; set; } = null!;
        public Food Food { get; set; } = null!;
    }
}
