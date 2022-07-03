namespace OnlineStore
{
    internal class Shop
    {
        private readonly Warehouse _warehouse;
        private readonly Cart _cart;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
            _cart = new Cart(_warehouse.Goods);
            _cart.GoodChanged += OnGoodChanged;
        }

        public Cart Cart()
        {
            return _cart;
        }

        private void OnGoodChanged(Good good, int count)
        {
            _warehouse.TryRemoveGood(good, count);
        }
    }
}