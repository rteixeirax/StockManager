using System.Collections.Generic;
using System.Linq;

namespace StockManager.Types {
  public class OperationErrorsList {
    public List<ErrorType> ErrorsList { get; private set; }

    public OperationErrorsList() {
      this.ErrorsList = new List<ErrorType>();
    }

    public void AddError(ErrorType error) {
      this.ErrorsList.Add(error);
    }

    public bool HasErrors() {
      return (this.ErrorsList.Count() > 0);
    }
  }
}
