using StockManager.Services.Source.Contracts;
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Services {
  public class AppSettingsService : IAppSettingsService {
    private readonly IAppSettingsRepository _settingsRepo;

    public AppSettingsService(IAppSettingsRepository settingsRepo) {
      _settingsRepo = settingsRepo;
    }

    public async Task<AppSettings> GetAppSettingsAsync() {
      return await _settingsRepo.FindAppSettingsAsync();
    }

    public async Task<string> GetAppLanguageAsync() {
      AppSettings appSettings = await _settingsRepo.FindAppSettingsAsync();

      return appSettings.Language;
    }
  }
}
