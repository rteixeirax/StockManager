using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts
{
  public interface IAppSettingsRepository {
    Task SaveDbChangesAsync();

    Task<AppSettings> FindAppSettingsAsync();
  }
}
