namespace Polymorphism
{
    internal abstract class PaymentSystemFactory
    {
        public abstract IPaymentSystem CreatePaymentSystem();
    }
}