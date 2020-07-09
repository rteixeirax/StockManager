using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockManager.Database.Source.Models
{
    public class Role : BaseEntity
    {
        [Key]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
