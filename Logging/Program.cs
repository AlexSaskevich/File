namespace Logging
{
    internal class Program
    {
        private static void Main()
        {
            Pathfinder pathfinder1 = new Pathfinder(new FileLogWritter());
            pathfinder1.Find();

            Pathfinder pathfinder2 = new Pathfinder(new ConsoleLogWritter());
            pathfinder2.Find();

            Pathfinder pathfinder3 = new Pathfinder(new SecureFileLogWritter());
            pathfinder3.Find();

            Pathfinder pathfinder4 = new Pathfinder(new SecureConsoleLogWritter());
            pathfinder4.Find();

            Pathfinder pathfinder5 = new Pathfinder(new ConsoleLogWritter(new SecureFileLogWritter()));
            pathfinder5.Find();
        }
    }
}