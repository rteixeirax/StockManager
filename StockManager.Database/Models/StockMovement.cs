using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Database.Models
{
  public class StockMovement :BaseEntity
  {
    [Key]
    public int StockMovementId { get; set; }

    [Required(ErrorMessage = "Qty is required")]
    public float Qty { get; set; }

    [Required(ErrorMessage = "Stock is required")]
    public float Stock { get; set; }

    [Required(ErrorMessage = "UserId is required")]
    [ForeignKey("User")]
    public int UserId { get; set; }

    [Required(ErrorMessage = "ProductId is required")]
    [ForeignKey("Product")]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "FromLocationId is required")]
    [ForeignKey("LocationId")]
    public int FromLocationId { get; set; }

    [Required(ErrorMessage = "ToLocationId is required")]
    [ForeignKey("LocationId")]
    public int ToLocationId { get; set; }


    public virtual User User { get; set; }
    public virtual Product Product { get; set; }
    public virtual Location Location { get; set; }
  }
}
