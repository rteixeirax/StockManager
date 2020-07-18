using System.Threading.Tasks;

using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Contracts
{
    public interface IAppSettingsRepository
    {
        /// <summary>
        /// Find and return all settings
        /// </summary>
        Task<AppSettings> FindAppSettingsAsync();

        /// <summary>
        /// Save DB changes
        /// </summary>
        Task SaveDbChangesAsync();
    }
}
