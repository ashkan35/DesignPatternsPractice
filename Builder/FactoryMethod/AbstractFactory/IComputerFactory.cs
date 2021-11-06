namespace Builder.FactoryMethod.AbstractFactory
{
    public abstract class ComputerFactory
    {
        public string ComputerName => $"{this.Brand.GetBrand().ToString()}--" +
                                      $"{this.SystemType.GetSystemType().ToString()}--{this.Cpu.GetCpu().ToString()}";

        public abstract ISystemType SystemType { get; }

        public abstract ICpu Cpu { get; }
        public abstract IBrand Brand { get; }

    }
}