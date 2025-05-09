using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutriNyan.Models.Enums;

namespace NutriNyan.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public SenderType Sender { get; set; }
        public string Message { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public User User { get; set; } = null!;
    }
}
