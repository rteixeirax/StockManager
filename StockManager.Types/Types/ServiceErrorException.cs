using System;
using System.Collections.Generic;

namespace StockManager.Types.Types {
  public class ServiceErrorException : ArgumentException {
    public List<ErrorType> Errors { get; private set; }

    public ServiceErrorException(OperationErrorsList operationErrors) {
      this.Errors = operationErrors.ErrorsList;
    }
  }
}
