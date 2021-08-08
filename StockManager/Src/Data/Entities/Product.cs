using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Src.Data.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public ICollection<ProductLocation> ProductLocations { get; set; }
        public string Reference { get; set; }

        // This field is used to save the product total stock that is caculated in the product
        // service. The product stock is the sum of the stocks in the ProductLocation associations.
        [NotMapped]
        public float? Stock { get; set; }

        public ICollection<StockMovement> StockMovements { get; set; }
    }
}
