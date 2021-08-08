using System.Collections.Generic;

namespace StockManager.Src.Data.Entities
{
    public class Role : BaseEntity
    {
        public string Code { get; set; }
        public int RoleId { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
