using AbstractFactory.Enums;
using AbstractFactory.FactoryMethod.AbstractFactory;

namespace AbstractFactory.ConcreteProducts
{
    public class MacFactory:ComputerFactory
    {


        public override ISystemType SystemType => new Desktop();
        public override ICpu Cpu => new I5();
        public override IBrand Brand => new Apple();
    }

    public class MacLaptopFactory:MacFactory
    {
        public override ISystemType SystemType => new Laptop();

        public override ICpu Cpu => new I7();

    }

    public class DellFactory:ComputerFactory
    {
        public override ISystemType SystemType => new Desktop();
        public override ICpu Cpu => new I5();
        public override IBrand Brand => new Dell();
    }

    public class DellLaptopFactory:ComputerFactory
    {
        public override ISystemType SystemType => new Laptop();
        public override ICpu Cpu =>new I7();
        public override IBrand Brand => new Dell();
    }
}