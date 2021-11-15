using System;

namespace Composite.MenuPractice
{
    public class MenuItem:IMenuNode
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public bool IsNode { get; set; }
        public void Print()
        {
            Console.WriteLine(IsNode ? $"\t-----{Name}" : $"\t-----{Name}----{Link}");
        }
    }
}