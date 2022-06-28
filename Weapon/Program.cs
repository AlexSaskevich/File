namespace Weapon
{
    internal class Program
    {
        public static void Main()
        {
            Player player = new Player();
            Bot bot = new Bot();

            while (bot.Weapon.Bullets > 0 && player.IsAlive)
            {
                bot.OnSeePlayer(player);
            }
        }
    }
}