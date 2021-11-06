namespace Bridge
{
    public abstract class Payment
    {
        public IPaymentSystem PaymentSystem;
        public abstract void MakePayment();
    }
}