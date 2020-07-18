using System;
using System.Collections.Generic;

namespace StockManager.Types.Source
{
    public class ServiceErrorException : ArgumentException
    {
        public ServiceErrorException(OperationErrorsList operationErrors)
        {
            Errors = operationErrors.ErrorsList;
        }

        public List<ErrorType> Errors { get; private set; }
    }
}
