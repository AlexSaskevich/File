using System;

namespace Polymorphism
{
    internal class WebMoneyPaymentSystem : IPaymentSystem
    {
        public WebMoneyPaymentSystem()
        {
            Name = "WebMoney";
        }

        public string Name { get; }

        public void ShowPaymentResult()
        {
            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}