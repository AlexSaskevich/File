using System;

namespace PaymentSystem
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter the payment system you would like to use:");

            Console.WriteLine("V - Visa");
            Console.WriteLine("M - Mastercard");
            Console.WriteLine("W - World");

            string paymentSystemType = Console.ReadLine().ToLower();

            PaymentSystemFactory factory = GetFactory(paymentSystemType);

            IPaymentSystem paymentSystem = factory.CreatePaymentSystem();

            string payingLink = paymentSystem.GetPayingLink(new Order(1, 12000));

            Console.WriteLine(payingLink);
        }

        private static PaymentSystemFactory GetFactory(string paymentSystemType)
        {
            if (paymentSystemType == "v")
                return new VisaPaymentSystemFactory();
            if (paymentSystemType == "m")
                return new MastercardPaymentSystemFactory();
            if (paymentSystemType == "w")
                return new WorldPaymentSystemFactory();
            else
                throw new NullReferenceException();
        }
    }
}