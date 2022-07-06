using System;
using System.IO;

namespace Logging
{
    internal class SecureFileLogWritter : ILogger
    {
        public void WriteError(string message)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                File.WriteAllText("log.txt", message);
            }
        }
    }
}