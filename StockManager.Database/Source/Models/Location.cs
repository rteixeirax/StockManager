using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockManager.Database.Source.Models
{
    public class Location : BaseEntity
    {
        public bool IsMain { get; set; }

        [Key]
        public int LocationId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public ICollection<ProductLocation> ProductLocations { get; set; }

        public ICollection<StockMovement> StockMovementsFrom { get; set; }

        public ICollection<StockMovement> StockMovementsTo { get; set; }
    }
}
