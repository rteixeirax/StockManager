using System.Collections.Generic;
using System.Linq;

namespace StockManager.Src.Models
{
    public class OperationErrorsList
    {
        public OperationErrorsList()
        {
            ErrorsList = new List<ErrorType>();
        }

        public List<ErrorType> ErrorsList { get; private set; }

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
