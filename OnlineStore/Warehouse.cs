using System;
using System.Collections.Generic;

namespace OnlineStore
{
    internal class Warehouse
    {
        private readonly Dictionary<Good, int> _goods;

        public Warehouse()
        {
            _goods = new Dictionary<Good, int>();
        }

        public IReadOnlyDictionary<Good, int> Goods => _goods;

        public void Delive(Good good, int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            _goods.Add(good, count);
        }

        public void ShowGoods()
        {
            Console.WriteLine("На складе:");

            foreach (var good in _goods)
                Console.WriteLine($"{good.Key.Name} - {good.Value}");
        }

        public void TryRemoveGood(Good good, int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (_goods.TryGetValue(good, out int value) == false)
                return;

            if (value < count)
                throw new ArgumentOutOfRangeException(nameof(count));

            _goods[good] -= count;
        }
    }
}