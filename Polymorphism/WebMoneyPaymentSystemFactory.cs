using System;

namespace Polymorphism
{
    internal class WebMoneyPaymentSystemFactory : PaymentSystemFactory
    {
        public WebMoneyPaymentSystemFactory(string description)
        {
            Console.WriteLine(description);
        }

        public override IPaymentSystem CreatePaymentSystem()
        {
            return new WebMoneyPaymentSystem();
        }
    }
}