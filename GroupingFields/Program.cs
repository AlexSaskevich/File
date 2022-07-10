using System;

namespace GroupingFields
{
    internal class Player
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public void Move()
        {
            //Do move
        }

        public void Attack()
        {
            //attack
        }

        public bool IsReloading()
        {
            throw new NotImplementedException();
        }
    }

    internal class Weapon
    {
        public float WeaponCooldown { get; private set; }
        public int WeaponDamage { get; private set; }

    }

    internal class Movement
    {
        public float DirectionX { get; private set; }
        public float DirectionY { get; private set; }
        public float MovementSpeed { get; private set; }
    }
}