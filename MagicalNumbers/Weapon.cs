namespace MagicalNumbers
{
    internal class Weapon
    {
        private const int MinBulletCount = 0;
        private const int BulletPerShootCount = 1;

        private int _bullets;

        public bool CanShoot() => _bullets > MinBulletCount;

        public void Shoot() => _bullets -= BulletPerShootCount;
    }
}