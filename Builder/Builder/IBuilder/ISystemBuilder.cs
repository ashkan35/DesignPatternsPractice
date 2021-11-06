using Builder.Builder.Product;

namespace Builder.Builder.IBuilder
{
    public interface ISystemBuilder
    {
        void AddMemory(string memorySize);
        void AddHddSize(string hddSize);
        void AddKeyBoard(string type);
        void AddMouse(string type);
        void AddTouchscreen(string type);
        ComputerSystem GetSystem();
    }
}