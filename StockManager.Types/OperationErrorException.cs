using System;
using System.Collections.Generic;
using System.Text;

namespace StockManager.Types
{
  public class OperationErrorException : ArgumentException
  {
    public List<ErrorType> Errors { get; private set; }

    public OperationErrorException(OperationErrorsList operationErrors)
    {
      this.Errors = operationErrors.ErrorsList;
    }
  }
}
