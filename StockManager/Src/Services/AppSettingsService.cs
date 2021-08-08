﻿using System.Threading.Tasks;

using StockManager.Src.Data.Entities;
using StockManager.Src.Data.Repositories;
using StockManager.Src.Models;
using StockManager.Src.Translations;

namespace StockManager.Src.Services.Services
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
                appSettings.DocumentsFolder = data.DocumentsFolder;
                appSettings.Language = data.Language;
                appSettings.DefaultGlobalMinStock = data.DefaultGlobalMinStock;

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
