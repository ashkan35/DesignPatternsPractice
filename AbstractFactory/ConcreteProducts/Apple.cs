using AbstractFactory.Enums;
using AbstractFactory.FactoryMethod.AbstractFactory;

namespace AbstractFactory.ConcreteProducts
{
    public class Apple : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.Apple.ToString();
        }
    }
}