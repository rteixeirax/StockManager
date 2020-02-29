using Microsoft.EntityFrameworkCore;
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

  public static class RoleModelBuilder
  {
    public static void Build(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Role>()
          .HasIndex(x => x.Code)
          .IsUnique()
          .HasName("UniqueCode");
    }
  }
}
