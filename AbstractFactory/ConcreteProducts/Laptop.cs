using AbstractFactory.Enums;
using AbstractFactory.FactoryMethod.AbstractFactory;

namespace AbstractFactory.ConcreteProducts
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