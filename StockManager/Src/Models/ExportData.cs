namespace StockManager.Src.Models
{
    public class ExportData<TData, TOptions>
    {
        public ExportData(TData data, TOptions options)
        {
            Data = data;
            Options = options;
        }

        public TData Data { get; private set; }
        public TOptions Options { get; private set; }
    }
}
