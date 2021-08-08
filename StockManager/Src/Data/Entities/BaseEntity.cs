using System;

namespace StockManager.Src.Data.Entities
{
    /*
     * Commom models fields
     *
     * In this abstract class, you should add the fields that every models
     * will have in common. "CreatedAt and UpdatedAt" for instance.
     */

    public abstract class BaseEntity
    {
        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
