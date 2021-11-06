using Builder.Enums;
using Builder.FactoryMethod.AbstractFactory;

namespace Builder.ConcreteProducts
{
    public class I5:ICpu
    {
        public string GetCpu()
        {
            return Enumerations.Cpu.I5.ToString();
        }
    }

    public class I7:ICpu
    {
        public string GetCpu()
        {
            return Enumerations.Cpu.I7.ToString();
        }
    }
}