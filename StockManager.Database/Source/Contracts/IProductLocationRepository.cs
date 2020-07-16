﻿using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts
{
    public interface IProductLocationRepository
    {
        /// <summary>
        /// Find a product location for the given id's
        /// </summary>
        Task<ProductLocation> FindProductLocationAsync(int productId, int locationId);

        /// <summary>
        /// Find the product location by id
        /// </summary>
        Task<ProductLocation> FindProductLocationByIdAsync(int productLocationId);

        /// <summary>
        /// Insert a new product location association
        /// </summary>
        Task InsertProductLocationAsync(ProductLocation data);

        /// <summary>
        /// Remove the product location
        /// </summary>
        void RemoveProductLocation(ProductLocation productLocation);

        /// <summary>
        /// Save DB changes
        /// </summary>
        Task SaveDbChangesAsync();
    }
}
