using Microsoft.EntityFrameworkCore;
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Repositories
{
  public class AppSettingsRepository : IAppSettingsRepository
  {
    private readonly DatabaseContext _db;

    public AppSettingsRepository(DatabaseContext db)
    {
      _db = db;
    }

    public async Task SaveDbChangesAsync()
    {
      await _db.SaveChangesAsync();
    }

    public async Task<AppSettings> FindAppSettingsAsync()
    {
      return await _db.AppSettings.FirstOrDefaultAsync();
    }
  }
}
