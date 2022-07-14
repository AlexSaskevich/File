namespace PaymentSystem
{
    internal class VisaPaymentSystemFactory : PaymentSystemFactory
    {
        public override IPaymentSystem CreatePaymentSystem()
        {
            return new VisaPaymentSystem();
        }
    }
}