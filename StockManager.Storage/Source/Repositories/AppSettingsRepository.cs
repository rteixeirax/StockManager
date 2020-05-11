using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Repositories {
  public class AppSettingsRepository : IAppSettingsRepository {
    private readonly StorageContext _db;

    public AppSettingsRepository (StorageContext db) {
      _db = db;
    }

    /// <summary>
    /// Save DB changes async
    /// </summary>
    public async Task SaveDbChangesAsync() {
      await _db.SaveChangesAsync();
    }

    /// <summary>
    /// Find and return all settings
    /// </summary>
    public async Task<AppSettings> FindAppSettingsAsync() {
      return await _db.AppSettings.FirstOrDefaultAsync();
    }   
  }
}
