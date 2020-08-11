namespace StockManager.Core.Source.Models
{
    public class StockMovement : BaseEntity
    {
        public int StockMovementId { get; set; }

        public float Qty { get; set; }

        public float Stock { get; set; }

        public string ToLocationName { get; set; }

        public string FromLocationName { get; set; }

        public int ProductId { get; set; }

        public int? ToLocationId { get; set; }

        public int? FromLocationId { get; set; }

        public int? UserId { get; set; }

        public Product Product { get; set; }

        public Location ToLocation { get; set; }

        public Location FromLocation { get; set; }

        public User User { get; set; }
    }
}
