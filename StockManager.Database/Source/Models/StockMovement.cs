using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Database.Source.Models
{
  public class StockMovement : BaseEntity
  {
    [Key]
    public int StockMovementId { get; set; }

    public string FromLocationName { get; set; }
    public string ToLocationName { get; set; }

    [Required(ErrorMessage = "Qty is required")]
    public float Qty { get; set; }

    [Required(ErrorMessage = "Stock is required")]
    public float Stock { get; set; }

    [Required(ErrorMessage = "ProductId is required")]
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }

    [ForeignKey("FromLocation")]
    public int? FromLocationId { get; set; }
    public Location FromLocation { get; set; }

    [ForeignKey("ToLocation")]
    public int? ToLocationId { get; set; }
    public Location ToLocation { get; set; }

    [ForeignKey("User")]
    public int? UserId { get; set; }
    public User User { get; set; }
  }
}
