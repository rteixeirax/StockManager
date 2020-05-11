using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Repositories {
  public class SettingsRepository : ISettingsRepository {
    private readonly StorageContext _db;

    public SettingsRepository (StorageContext db) {
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
    public async Task<Settings> FindSettingsAsync() {
      return await _db.Settings.FirstOrDefaultAsync();
    }   
  }
}
