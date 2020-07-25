using System;
using System.Collections.Generic;

namespace StockManager.Core.Source.Types
{
    public class OperationErrorException : ArgumentException
    {
        public List<ErrorType> Errors { get; private set; }

        public OperationErrorException(OperationErrorsList operationErrors)
        {
            Errors = operationErrors.ErrorsList;
        }
    }
}
