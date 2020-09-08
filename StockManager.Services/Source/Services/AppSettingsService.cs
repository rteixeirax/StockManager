using System.Threading.Tasks;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Services;
using StockManager.Core.Source.Types;
using StockManager.Translations.Source;

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

        public async Task UpdateAppSettingsAsync(AppSettings data)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            try
            {
                AppSettings appSettings = await _repository.AppSettings.GetByIdAsync(data.AppSettingsId);
                appSettings.Language = data.Language;

                await _repository.SaveChangesAsync();
            }
            catch
            {
                errorsList.AddError("update-settings-db-error", Phrases.GlobalErrorOperationDB);

                throw new ServiceErrorException(errorsList);
            }
        }
    }
}
