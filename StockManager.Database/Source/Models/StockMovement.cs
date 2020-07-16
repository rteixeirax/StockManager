using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Database.Source.Models
{
    public class StockMovement : BaseEntity
    {
        public Location FromLocation { get; set; }

        [ForeignKey("FromLocation")]
        public int? FromLocationId { get; set; }

        public string FromLocationName { get; set; }

        public Product Product { get; set; }

        [Required(ErrorMessage = "ProductId is required")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Qty is required")]
        public float Qty { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        public float Stock { get; set; }

        [Key]
        public int StockMovementId { get; set; }

        public Location ToLocation { get; set; }

        [ForeignKey("ToLocation")]
        public int? ToLocationId { get; set; }

        public string ToLocationName { get; set; }
        public User User { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
    }
}
