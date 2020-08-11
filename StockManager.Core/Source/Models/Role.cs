using System.Collections.Generic;

namespace StockManager.Core.Source.Models
{
    public class Role : BaseEntity
    {
        public int RoleId { get; set; }

        public string Code { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
