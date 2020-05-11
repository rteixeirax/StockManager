using StockManager.Storage.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Contracts
{
  public interface ISettingsRepository {
    Task SaveDbChangesAsync();

    Task<Settings> FindSettingsAsync();
  }
}
