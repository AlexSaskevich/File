using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Warehouse
    {
        private readonly Dictionary<Good, int> _goods;

        public Warehouse()
        {
            _goods = new Dictionary<Good, int>();
        }

        public void Delive(Good good, int count)
        {
            _goods.Add(good, count);
        }

        public void ShowGoods()
        {
            foreach (var good in _goods)
            {
                Console.WriteLine($"{good.Key.Name} - {good.Value}");
            }
        }
    }
}
