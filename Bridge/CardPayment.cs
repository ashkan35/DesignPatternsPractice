namespace Bridge
{
    public class CardPayment:Payment
    {
        public override void MakePayment()
        {
            PaymentSystem.ProcessPayment("Card Payment");
        }
    }
}