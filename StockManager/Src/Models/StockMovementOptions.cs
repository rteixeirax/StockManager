using System;

namespace StockManager.Src.Models
{
    public class StockMovementOptions
    {
        public DateTime EndDate { get; set; }
        public int? LocationId { get; set; }
        public string SearchValue { get; set; }
        public DateTime StartDate { get; set; }
        public int? UserId { get; set; }
    }
}
