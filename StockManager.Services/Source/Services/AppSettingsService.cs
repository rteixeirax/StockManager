using System.Threading.Tasks;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;

namespace StockManager.Services.Source.Services
{
    public class AppSettingsService : IAppSettingsService
    {
        private readonly IAppSettingsRepository _settingsRepo;

        public AppSettingsService(IAppSettingsRepository settingsRepo)
        {
            _settingsRepo = settingsRepo;
        }

        public async Task<string> GetAppLanguageAsync()
        {
            AppSettings appSettings = await _settingsRepo.FindAppSettingsAsync();

            return appSettings.Language;
        }

        public async Task<AppSettings> GetAppSettingsAsync()
        {
            return await _settingsRepo.FindAppSettingsAsync();
        }
    }
}
