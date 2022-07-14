using System;

namespace Polymorphism
{
    internal class OrderForm
    {
        public string ShowForm()
        {
            Console.WriteLine("Мы принимаем: QIWI, WebMoney, Card");
            Console.WriteLine("Какое системой вы хотите совершить оплату?");

            return Console.ReadLine().ToLower();
        }
    }
}