using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts {
  public interface IAppSettingsService {
    /// <summary>
    /// Get all the App settings
    /// </summary>
    Task<AppSettings> GetAppSettingsAsync();

    /// <summary>
    /// Get the App language
    /// </summary>
    Task<string> GetAppLanguageAsync();
  }
}
