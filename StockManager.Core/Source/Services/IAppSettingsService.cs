using System.Threading.Tasks;

using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Services
{
    public interface IAppSettingsService
    {
        /// <summary>
        /// Get the App language
        /// </summary>
        Task<string> GetAppLanguageAsync();

        /// <summary>
        /// Get the App settings
        /// </summary>
        Task<AppSettings> GetAppSettingsAsync();
    }
}
