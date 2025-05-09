using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriNyan.Models
{
    public class Water
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Target { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public User User { get; set; } = null!;
        public List<WaterEntry> Entries { get; set; } = new();
    }
}
