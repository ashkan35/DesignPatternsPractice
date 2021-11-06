using Builder.Enums;
using Builder.FactoryMethod.AbstractFactory;

namespace Builder.ConcreteProducts
{
    public class Apple : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.Apple.ToString();
        }
    }
}