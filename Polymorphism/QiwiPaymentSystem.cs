using System;

namespace Polymorphism
{
    internal class QiwiPaymentSystem : IPaymentSystem
    {
        public QiwiPaymentSystem()
        {
            Name = "Qiwi";
        }

        public string Name { get; }

        public void ShowPaymentResult()
        {
            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}