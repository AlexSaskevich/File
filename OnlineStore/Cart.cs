using System;
using System.Collections.Generic;

namespace OnlineStore
{
    internal class Cart
    {
        private readonly Dictionary<Good, int> _goods;
        private readonly IReadOnlyDictionary<Good, int> _warehouse;

        public Cart(IReadOnlyDictionary<Good, int> warehouse)
        {
            _goods = new Dictionary<Good, int>();
            _warehouse = warehouse;
        }

        public event Action<Good, int> GoodChanged;

        public void Add(Good good, int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (_warehouse.TryGetValue(good, out int countInWarehouse) == false)
                return;

            if (countInWarehouse < count)
            {
                Console.WriteLine($"Нет нужного товара {good.Name} в количестве {count}");
                return;
            }

            if (countInWarehouse > 0 && countInWarehouse >= count)
            {
                _goods.Add(good, count);
                GoodChanged?.Invoke(good, count);

                Console.WriteLine($"\nТовар {good.Name} добавлен в корзину в количестве {count}");
            }
        }

        public void ShowGoods()
        {
            Console.WriteLine("\nКорзина:");

            foreach (var good in _goods)
                Console.WriteLine($"{good.Key.Name} - {good.Value}");
        }

        public string Order()
        {
            string payLink = "...PayLink...";
            return payLink;
        }
    }
}