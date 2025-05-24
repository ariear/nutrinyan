using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriNyan.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public required string UnitType { get; set; }
        public float Weight { get; set; }
        public ICollection<MealItem>? MealItems { get; set; }
    }
}
