using System;
using System.Collections.Generic;

namespace Composite.MenuPractice
{
    public class Menu:IMenuNode
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public bool IsNode { get; set; }
        public void Print()
        {
            Console.WriteLine($"\t-----{Name}");
            foreach (var item in MenuItems)
            {
                Console.Write("\t");
                item.Print();

            }

        }

        public List<IMenuNode> MenuItems = new List<IMenuNode>();
    }
}