using System;

namespace Polymorphism
{
    internal class Program
    {
        private static void Main()
        {
            var orderForm = new OrderForm();
            var paymentHandler = new PaymentHandler();
            var systemId = orderForm.ShowForm();

            PaymentSystemFactory factory = GetFactory(systemId);

            IPaymentSystem paymentSystem = factory.CreatePaymentSystem();

            paymentHandler.ShowPaymentResult(paymentSystem);
        }

        private static PaymentSystemFactory GetFactory(string systemId)
        {
            if (systemId == "qiwi")
                return new QiwiPaymentSystemFactory("Перевод на страницу QIWI...");
            if (systemId == "webmoney")
                return new WebMoneyPaymentSystemFactory("Вызов API WebMoney...");
            if (systemId == "card")
                return new CardPaymentSystemFactory("Вызов API банка эмитента карты Card...");
            else
                throw new NullReferenceException();
        }
    }
}