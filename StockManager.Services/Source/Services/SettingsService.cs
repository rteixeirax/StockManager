using StockManager.Services.Source.Contracts;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Services {
  public class SettingsService : ISettingsService {
    private readonly ISettingsRepository _settingsRepo;

    public SettingsService(ISettingsRepository settingsRepo) {
      _settingsRepo = settingsRepo;
    }

    public async Task<Settings> GetSettingsAsync() {
      return await _settingsRepo.FindSettingsAsync();
    }

    public async Task<string> GetAppLanguageAsync() {
      Settings appSettings = await _settingsRepo.FindSettingsAsync();

      return appSettings.Language;
    }
  }
}
