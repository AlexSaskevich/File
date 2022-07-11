namespace PaymentSystem
{
    internal interface IPaymentSystem
    {
        string GetPayingLink(Order order);
    }
}