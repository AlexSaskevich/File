using System;

namespace Logging
{
    internal class SecureConsoleLogWritter : ILogger
    {
        public void WriteError(string message)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine(message);
            }
        }
    }
}