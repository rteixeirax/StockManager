using System;
using System.Collections.Generic;

namespace StockManager.Src.Data.Entities
{
    public class User : BaseEntity
    {
        public DateTime? LastLogin { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public ICollection<StockMovement> StockMovements { get; set; }
        public int UserId { get; set; }

        public string Username { get; set; }
    }
}
