using StockManager.Storage.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts {
  public interface ISettingsService {
    Task<Settings> GetSettingsAsync();

    Task<string> GetAppLanguageAsync();
  }
}
