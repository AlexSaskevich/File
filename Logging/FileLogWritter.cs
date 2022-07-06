using System.IO;

namespace Logging
{
    internal class FileLogWritter : ILogger
    {
        public void WriteError(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}