using System;
using System.Security.Cryptography;
using System.Text;

namespace PaymentSystem
{
    internal class MastercardPaymentSystem : IPaymentSystem
    {
        public string GetPayingLink(Order order)
        {
            string payingLink = $"order.system2.ru/pay?hash={ComputeMD5Hash(order.Id.ToString())}+{ComputeMD5Hash(order.Amount.ToString())}";

            return payingLink;
        }

        private string ComputeMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}