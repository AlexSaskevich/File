using System;

namespace Logging
{
    internal class Pathfinder
    {
        private readonly ILogger _logger;

        public Pathfinder(ILogger logger)
        {
            _logger = logger;
        }

        public void Find()
        {
            _logger.WriteError("Some string");
        }
    }
}