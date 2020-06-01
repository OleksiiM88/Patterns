using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 43;
            ILoggerFactory loggerFactory = new LoggerFactory(
                new[] { new ConsoleLoggerProvider((_, __) => true, true) }
            );
            //or
            
            ILoggerFactory loggerFactory2 = new LoggerFactory().AddConsole(includeScopes: true);

            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("This is log message before Scope.");

            using (logger.BeginScope($"Order id {id}"))
            {
                logger.LogInformation("Log in scope!");
                logger.LogInformation("Log in scope!");
                logger.LogInformation("Log in scope!");
                logger.LogInformation("Log in scope!");
                logger.LogInformation("Log in scope!");
                logger.LogInformation("Log in scope!");
                IExceptionClass ex = new ExceptionClass(logger);
                logger.LogError(ex.ThrowException());
                logger.LogError("Error Log");
            }

            logger.LogInformation("Log after scope!"); 
            logger.LogError("Error Log");

            Console.ReadLine();
        }
    }
}
