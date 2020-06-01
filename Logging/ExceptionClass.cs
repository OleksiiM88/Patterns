using Microsoft.Extensions.Logging;
using System;

namespace Logging
{
    class ExceptionClass : IExceptionClass
    {
        ILogger _logger;
        public ExceptionClass(ILogger logger)
        {
            _logger = logger;
        }

        public string ThrowException()
        {
            throw new Exception("It's a my personal exception.");
        }
    }
}
