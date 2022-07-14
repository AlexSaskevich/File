using System;

namespace Polymorphism
{
    internal class PaymentHandler
    {
        public void ShowPaymentResult(IPaymentSystem paymentSystem)
        {
            if (paymentSystem == null)
                throw new NullReferenceException();

            Console.WriteLine($"Вы оплатили с помощью {paymentSystem.Name}");
            Console.WriteLine($"Проверка платежа через {paymentSystem.Name}...");

            paymentSystem.ShowPaymentResult();
        }
    }
}