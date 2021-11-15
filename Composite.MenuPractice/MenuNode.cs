using System.Collections.Generic;

namespace Composite.MenuPractice
{
    public interface IMenuNode
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public bool IsNode { get; set; }
        public void Print();

    }
}