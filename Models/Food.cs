using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NutriNyan.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public float Karbohidrat { get; set; }
        public float Protein { get; set; }
        public float Lemak { get; set; }
        public float Serat { get; set; }
        public float Gula { get; set; }
        public string Summary { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
