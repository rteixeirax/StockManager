using System.Collections.Generic;
using System.Linq;

namespace StockManager.Core.Source.Types
{
    public class OperationErrorsList
    {
        public List<ErrorType> ErrorsList { get; private set; }

        public OperationErrorsList()
        {
            ErrorsList = new List<ErrorType>();
        }

        public void AddError(string field, string errorMessage)
        {
            ErrorsList.Add(new ErrorType
            {
                Field = field,
                Error = errorMessage,
            });
        }

        public bool HasErrors()
        {
            return (ErrorsList.Any());
        }
    }
}
