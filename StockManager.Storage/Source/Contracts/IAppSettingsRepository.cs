using StockManager.Storage.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Contracts
{
  public interface IAppSettingsRepository {
    Task SaveDbChangesAsync();

    Task<AppSettings> FindAppSettingsAsync();
  }
}
