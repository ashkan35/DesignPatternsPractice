using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Hyundai();
            var price = car.GetPrice();
            var discountedPrice = new OfferPrice(car).GetDiscountedPrice();
            Console.WriteLine($"car price is:{price}");
            Console.WriteLine($"discounted  price is:{discountedPrice}");
        }
    }
}
