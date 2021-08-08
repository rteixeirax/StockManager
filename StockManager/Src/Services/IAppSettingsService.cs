using System.Threading.Tasks;

using StockManager.Src.Data.Entities;

namespace StockManager.Src.Services
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

        /// <summary>
        /// Update the app settings
        /// </summary>
        Task UpdateAppSettingsAsync(AppSettings data);
    }
}
