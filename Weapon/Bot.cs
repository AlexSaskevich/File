namespace Weapon
{
    internal class Bot
    {
        public Bot()
        {
            Weapon = new Weapon();
        }

        public Weapon Weapon { get; private set; }

        public void OnSeePlayer(Player player)
        {
            Weapon.TryFire(player);
        }
    }
}