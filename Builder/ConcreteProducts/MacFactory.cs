using Builder.FactoryMethod.AbstractFactory;

namespace Builder.ConcreteProducts
{
    public class MacFactory:ComputerFactory
    {


        public override ISystemType SystemType => new Desktop();
        public override ICpu Cpu => new I5();
        public override IBrand Brand => new Apple();
    }

    public class MacLaptopFactory:ComputerFactory
    {
        public override ISystemType SystemType => new Laptop();

        public override ICpu Cpu => new I7();

        public override IBrand Brand => new Apple();
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