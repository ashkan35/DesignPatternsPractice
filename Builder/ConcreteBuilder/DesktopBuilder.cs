using System.Runtime.InteropServices.ComTypes;
using Builder.Builder.IBuilder;
using Builder.Builder.Product;

namespace Builder.ConcreteBuilder
{
    public class DesktopBuilder:ISystemBuilder
    {
        private readonly ComputerSystem _desktop = new ComputerSystem();
        public void AddMemory(string memorySize)
        {
            _desktop.Ram = memorySize;
        }

        public void AddHddSize(string hddSize)
        {
            _desktop.HddSize = hddSize;
        }


        public void AddKeyBoard(string type)
        {
            _desktop.Keyboard = type;
        }

        public void AddMouse(string type)
        {
            _desktop.Mouse = type;
        }

        public void AddTouchscreen(string type)
        {
        }

        public ComputerSystem GetSystem()
        {
            return _desktop;
        }
    }
}