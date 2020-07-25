using System.Threading.Tasks;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Services;

namespace StockManager.Services.Source.Services
{
    public class AppSettingsService : IAppSettingsService
    {
        private readonly IAppRepository _repository;

        public AppSettingsService(IAppRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> GetAppLanguageAsync()
        {
            AppSettings appSettings = await _repository.AppSettings.FindOneAsync();

            return appSettings.Language;
        }

        public async Task<AppSettings> GetAppSettingsAsync()
        {
            return await _repository.AppSettings.FindOneAsync();
        }
    }
}
