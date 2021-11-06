using Builder.Builder.IBuilder;
using Builder.Builder.Product;

namespace Builder.ConcreteBuilder
{
    public class LaptopBuilder:ISystemBuilder
    {
        private readonly ComputerSystem _laptop = new ComputerSystem();
        public void AddMemory(string memorySize)
        {
            _laptop.Ram = memorySize;
        }

        public void AddHddSize(string hddSize)
        {
            _laptop.HddSize = hddSize;
        }

        public void AddKeyBoard(string type)
        {
            
        }

        public void AddMouse(string type)
        {
            
        }

        public void AddTouchscreen(string type)
        {
            _laptop.TouchScreen = type;
        }

        public ComputerSystem GetSystem()
        {
            return _laptop;
        }

        
    }
}