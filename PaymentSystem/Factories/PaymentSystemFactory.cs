namespace PaymentSystem
{
    internal abstract class PaymentSystemFactory
    {
        public abstract IPaymentSystem CreatePaymentSystem();
    }
}