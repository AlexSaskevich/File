namespace Polymorphism
{
    internal interface IPaymentSystem
    {
        string Name { get; }

        void ShowPaymentResult();
    }
}