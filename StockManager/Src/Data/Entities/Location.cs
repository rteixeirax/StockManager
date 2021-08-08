using System.Collections.Generic;

namespace StockManager.Src.Data.Entities
{
    public class Location : BaseEntity
    {
        public bool IsMain { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }

        public ICollection<ProductLocation> ProductLocations { get; set; }

        public ICollection<StockMovement> StockMovementsFrom { get; set; }

        public ICollection<StockMovement> StockMovementsTo { get; set; }
    }
}
