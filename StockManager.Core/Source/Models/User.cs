using System;
using System.Collections.Generic;

namespace StockManager.Core.Source.Models
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime? LastLogin { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public ICollection<StockMovement> StockMovements { get; set; }
    }
}
