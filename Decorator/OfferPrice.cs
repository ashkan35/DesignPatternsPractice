namespace Decorator
{
    public class OfferPrice:CarDecorator
    {
        public OfferPrice(ICar car) : base(car)
        {
        }

        public override double GetDiscountedPrice()
        {
            return .8 * this.GetPrice();
        }
    }
}