﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriNyan.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
