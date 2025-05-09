using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriNyan.Models
{
    public class Purpose
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public float TdeeMin { get; set; }
        public float TdeeMax { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}
