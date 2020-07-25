using System;
using System.Collections.Generic;

namespace StockManager.Core.Source.Types
{
    public class ServiceErrorException : ArgumentException
    {
        public List<ErrorType> Errors { get; private set; }

        public ServiceErrorException(OperationErrorsList operationErrors)
        {
            Errors = operationErrors.ErrorsList;
        }
    }
}
