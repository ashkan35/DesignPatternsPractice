using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SepahPaymentSystem:IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Sepah Payment with" + paymentSystem);
        }
    }
}
