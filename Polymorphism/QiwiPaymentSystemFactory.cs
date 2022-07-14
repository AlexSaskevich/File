using System;

namespace Polymorphism
{
    internal class QiwiPaymentSystemFactory : PaymentSystemFactory
    {
        public QiwiPaymentSystemFactory(string description)
        {
            Console.WriteLine(description);
        }

        public override IPaymentSystem CreatePaymentSystem()
        {
            return new QiwiPaymentSystem();
        }
    }
}