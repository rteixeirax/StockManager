namespace StockManager.Core.Source.Types
{
    public class ExportData<TData, TOptions>
    {
        public TData Data { get; private set; }
        public TOptions Options { get; private set; }

        public ExportData(TData data, TOptions options)
        {
            Data = data;
            Options = options;
        }
    }
}
