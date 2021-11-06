namespace Bridge
{
    public class NetBankingPayment:Payment
    {
        public override void MakePayment()
        {
            PaymentSystem.ProcessPayment("Net Banking Payment");
        }
    }
}