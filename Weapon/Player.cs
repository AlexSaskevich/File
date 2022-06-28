using System;

namespace Weapon
{
    internal class Player
    {
        private readonly int _minHealth;
        private int _currentHealth;

        public Player(int minHealth = 0, int maxHealth = 100)
        {
            if (_minHealth < 0 || maxHealth <= 0)
                throw new ArgumentOutOfRangeException();

            _minHealth = minHealth;
            _currentHealth = maxHealth;
            IsAlive = true;
        }

        public bool IsAlive { get; private set; }

        public void ApplyDamage(int damage)
        {
            _currentHealth = Clamp(_currentHealth - damage, _minHealth);

            TryDie();
        }

        private int Clamp(int value, int min)
        {
            return (value <= min) ? min : value;
        }

        private void TryDie()
        {
            if (_currentHealth <= 0)
                IsAlive = false;
        }
    }
}