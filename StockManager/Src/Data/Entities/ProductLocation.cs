using System.Collections.Generic;

namespace StockManager.Src.Data.Entities
{
    public class ProductLocation : BaseEntity
    {
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public float MinStock { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int ProductLocationId { get; set; }

        public float Stock { get; set; }
    }
}
