using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts {
  public interface IAppSettingsService {
    Task<AppSettings> GetAppSettingsAsync();

    Task<string> GetAppLanguageAsync();
  }
}
