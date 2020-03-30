using System.Collections.Generic;
using System.Linq;

namespace StockManager.Types.Types {
  public class OperationErrorsList {
    public List<ErrorType> ErrorsList { get; private set; }

    public OperationErrorsList() {
      this.ErrorsList = new List<ErrorType>();
    }

    public void AddError(string field, string errorMessage) {
      this.ErrorsList.Add(new ErrorType {
        Field = field,
        Error = errorMessage,
      });
    }

    public bool HasErrors() {
      return (this.ErrorsList.Count() > 0);
    }
  }
}
