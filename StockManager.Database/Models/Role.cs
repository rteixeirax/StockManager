using System.ComponentModel.DataAnnotations;

namespace StockManager.Database.Models
{
  public class Role : BaseEntity
  {
    [Key]
    public int RoleId { get; set; }

    [Required(ErrorMessage = "Code is required")]
    public string Code { get; set; }
  }
}
