using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriNyan.Models
{
    public class NutritionLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Note { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public User User { get; set; } = null!;
        public List<Meal> Meals { get; set; } = new();
    }
}
