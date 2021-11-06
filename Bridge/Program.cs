using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment order = new NetBankingPayment();
            order.PaymentSystem = new MellatPaymentSystem();
            order.MakePayment();
        }
    }
}
