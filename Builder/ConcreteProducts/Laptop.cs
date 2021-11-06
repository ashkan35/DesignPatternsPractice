using Builder.Enums;
using Builder.FactoryMethod.AbstractFactory;

namespace Builder.ConcreteProducts
{
    public class Laptop:ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.SystemTypes.Laptop.ToString();
        }
    }

    public class Desktop:ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.SystemTypes.Desktop.ToString();
        }
    }
}