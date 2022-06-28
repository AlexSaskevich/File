using System;

namespace Weapon
{
    internal class Weapon
    {
        private readonly int _damage;

        public Weapon(int damage = 10, int bullets = 1)
        {
            if (damage <= 0 || bullets <= 0)
                throw new ArgumentOutOfRangeException();

            _damage = damage;
            Bullets = bullets;
        }

        public int Bullets { get; private set; }

        public void TryFire(Player player)
        {
            if (player == null)
                throw new NullReferenceException();

            if (Bullets <= 0)
                throw new ArgumentOutOfRangeException();

            Bullets -= 1;

            player.ApplyDamage(_damage);
        }
    }
}