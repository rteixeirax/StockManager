using System.Collections.Generic;

namespace StockManager.Core.Source.Models
{
    public class Location : BaseEntity
    {
        public int LocationId { get; set; }

        public bool IsMain { get; set; }

        public string Name { get; set; }

        public ICollection<ProductLocation> ProductLocations { get; set; }

        public ICollection<StockMovement> StockMovementsFrom { get; set; }

        public ICollection<StockMovement> StockMovementsTo { get; set; }
    }
}
