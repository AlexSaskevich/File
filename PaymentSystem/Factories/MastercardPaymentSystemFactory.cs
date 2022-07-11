namespace PaymentSystem
{
    internal class MastercardPaymentSystemFactory : PaymentSystemFactory
    {
        public override IPaymentSystem CreatePaymentSystem()
        {
            return new MastercardPaymentSystem();
        }
    }
}