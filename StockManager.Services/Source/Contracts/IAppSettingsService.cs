using System.Threading.Tasks;

using StockManager.Database.Source.Models;

namespace StockManager.Services.Source.Contracts
{
    public interface IAppSettingsService
    {
        /// <summary>
        /// Get the App language
        /// </summary>
        Task<string> GetAppLanguageAsync();

        /// <summary>
        /// Get all the App settings
        /// </summary>
        Task<AppSettings> GetAppSettingsAsync();
    }
}
