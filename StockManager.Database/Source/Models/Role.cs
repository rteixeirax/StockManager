using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockManager.Database.Source.Models
{
    public class Role : BaseEntity
    {
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }

        [Key]
        public int RoleId { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
