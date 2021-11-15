namespace Decorator
{
    public abstract class CarDecorator:ICar
    {
        private readonly ICar _car;
        protected CarDecorator(ICar car)
        {
            _car = car;
        }

        public string Make => _car.Make;
        public double GetPrice()
        {
           return _car.GetPrice();
        }

        public abstract double GetDiscountedPrice();
    }
}