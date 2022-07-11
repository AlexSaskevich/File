namespace PaymentSystem
{
    internal class WorldPaymentSystemFactory : PaymentSystemFactory
    {
        public override IPaymentSystem CreatePaymentSystem()
        {
            return new WorldPaymentSystem();
        }
    }
}