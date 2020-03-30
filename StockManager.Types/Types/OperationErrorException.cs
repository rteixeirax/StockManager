using StockManager.Types.Types;
using System;
using System.Collections.Generic;

namespace StockManager.Types.Types {
  public class OperationErrorException : ArgumentException {
    public List<ErrorType> Errors { get; private set; }

    public OperationErrorException(OperationErrorsList operationErrors) {
      this.Errors = operationErrors.ErrorsList;
    }
  }
}
