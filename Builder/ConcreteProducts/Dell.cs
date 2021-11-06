using Builder.Enums;
using Builder.FactoryMethod.AbstractFactory;

namespace Builder.ConcreteProducts
{
    public class Dell:IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.Dell.ToString();
        }
    }
}