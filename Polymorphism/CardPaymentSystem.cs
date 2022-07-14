using System;

namespace Polymorphism
{
    internal class CardPaymentSystem : IPaymentSystem
    {
        public CardPaymentSystem()
        {
            Name = "Card";
        }

        public string Name { get; }

        public void ShowPaymentResult()
        {
            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}