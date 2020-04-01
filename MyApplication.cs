using Microsoft.Extensions.Logging;
using System;

namespace LeaverageDIOtherApps
{
    public class MyApplication
    {
        private readonly ILogger _logger;
        public MyApplication(ILogger<MyApplication> logger)
        {
            _logger = logger;
        }

        internal void Run()
        {
            _logger.LogInformation("Application {applicationEvent} at {dateTime}", "Started", DateTime.UtcNow);


            _logger.LogInformation("Application {applicationEvent} at {dateTime}", "Ended", DateTime.UtcNow);

            Console.WriteLine("PRESS <ENTER> TO EXIT");
            Console.ReadKey();
        }
    }
}
