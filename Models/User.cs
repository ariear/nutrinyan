using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutriNyan.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NutriNyan.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int GenderId { get; set; }
        public Gender? Gender { get; set; }
        public DateTime DateBirth { get; set; }
        public float Tb { get; set; }
        public float Bb { get; set; }
        public int DefaultTargetWater { get; set; }
        public string TingkatAktivitas { get; set; }
        public int PurposeId { get; set; }
        public Purpose? Purpose { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
