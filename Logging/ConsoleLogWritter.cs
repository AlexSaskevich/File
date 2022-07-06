using System;

namespace Logging
{
    internal class ConsoleLogWritter : ILogger
    {
        private readonly ILogger _logger;

        public ConsoleLogWritter()
        {
        }

        public ConsoleLogWritter(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteError(string message)
        {
            if (_logger != null)
                _logger.WriteError(message);

            Console.WriteLine(message);
        }
    }
}