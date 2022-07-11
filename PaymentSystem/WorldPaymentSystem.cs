using System;
using System.Security.Cryptography;
using System.Text;

namespace PaymentSystem
{
    internal class WorldPaymentSystem : IPaymentSystem
    {
        public string GetPayingLink(Order order)
        {
            string uniqueKey = Guid.NewGuid().ToString();

            string payingLink = $"system3.com/pay?amount=12000&curency=RUB&hash={ComputeSHA1Hash(order.Amount.ToString())}+{order.Id}+{uniqueKey}";

            return payingLink;
        }

        private string ComputeSHA1Hash(string input)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}