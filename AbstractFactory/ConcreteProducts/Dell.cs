using AbstractFactory.Enums;
using AbstractFactory.FactoryMethod.AbstractFactory;

namespace AbstractFactory.ConcreteProducts
{
    public class Dell:IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.Dell.ToString();
        }
    }
}