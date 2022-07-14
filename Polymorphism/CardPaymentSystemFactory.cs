using System;

namespace Polymorphism
{
    internal class CardPaymentSystemFactory : PaymentSystemFactory
    {
        public CardPaymentSystemFactory(string description)
        {
            Console.WriteLine(description);
        }

        public override IPaymentSystem CreatePaymentSystem()
        {
            return new CardPaymentSystem();
        }
    }
}