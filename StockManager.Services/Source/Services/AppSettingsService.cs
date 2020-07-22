using System.Threading.Tasks;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;

namespace StockManager.Services.Source.Services
{
    public class AppSettingsService : IAppSettingsService
    {
        private readonly IRepository _repository;

        public AppSettingsService(IRepository repository)
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
