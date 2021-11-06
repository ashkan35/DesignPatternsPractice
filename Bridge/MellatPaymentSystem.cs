using System;

namespace Bridge
{
    public class MellatPaymentSystem:IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Mellat Payment with" +paymentSystem);
        }
    }
}