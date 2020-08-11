using System.Collections.Generic;

namespace StockManager.Core.Source.Models
{
    public class ProductLocation : BaseEntity
    {
        public int ProductLocationId { get; set; }

        public float Stock { get; set; }

        public float MinStock { get; set; }

        public int LocationId { get; set; }

        public int ProductId { get; set; }

        public Location Location { get; set; }

        public Product Product { get; set; }

        public ICollection<Notification> Notifications { get; set; }
    }
}
