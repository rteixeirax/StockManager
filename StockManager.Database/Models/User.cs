using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Database.Models
{
  public class User
  {
    [Key]
    public int UserId { get; set; }

    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }

    public DateTime LastLogin { get; set; }

    [ForeignKey("Role")]
    public int RoleId { get; set; }
    public virtual Role Role { get; set; }
  }
}
