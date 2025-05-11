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
        public string? UnitType { get; set; }
        public ICollection<Food>? Foods { get; set; }
    }
}
