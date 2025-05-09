using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriNyan.Models
{
    public class WaterEntry
    {
        public int Id { get; set; }
        public int WaterId { get; set; }
        public int Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Water Water { get; set; } = null!;
    }
}
