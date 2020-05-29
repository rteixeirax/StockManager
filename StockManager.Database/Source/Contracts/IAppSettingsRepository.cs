using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts
{
  public interface IAppSettingsRepository
  {
    /// <summary>
    /// Save DB changes
    /// </summary>
    Task SaveDbChangesAsync();

    /// <summary>
    /// Find and return all settings
    /// </summary>
    Task<AppSettings> FindAppSettingsAsync();
  }
}
