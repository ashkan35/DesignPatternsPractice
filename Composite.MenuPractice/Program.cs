using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Composite.MenuPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new List<IMenuNode>
            {
                new Menu {Name = "first", IsNode = true,MenuItems = new List<IMenuNode>
                {
                    new MenuItem{Name = "first1",IsNode = false,Link = $"LinkToFirst1"},
                    new MenuItem{Name = "first2",IsNode = false,Link = $"LinkToFirst2"},
                    new MenuItem{Name = "first3",IsNode = false,Link = $"LinkToFirst3"},
                    new MenuItem{Name = "first4",IsNode = false,Link = $"LinkToFirst4"}
                }},
                new Menu {Name = "second", IsNode = true,MenuItems = new List<IMenuNode>
                {
                    new MenuItem{Name = "second1",IsNode = false,Link = $"LinkToSecond1"},
                    new MenuItem{Name = "second2",IsNode = false,Link = $"LinkToSecond"},
                    new MenuItem{Name = "second3",IsNode = false,Link = $"LinkToSecond"},
                    new MenuItem{Name = "second4",IsNode = false,Link = $"LinkToSecond"}
                }},
                new Menu {Name = "third", IsNode = true,MenuItems = new List<IMenuNode>
                {
                    new MenuItem{Name = "third1",IsNode = false,Link = $"LinkToThird1"},
                    new MenuItem{Name = "third2",IsNode = false,Link = $"LinkToThird2"},
                    new MenuItem{Name = "third3",IsNode = false,Link = $"LinkToThird3"},
                    new MenuItem{Name = "third4",IsNode = false,Link = $"LinkToThird4"}
                }},
                new Menu {Name = "forth", IsNode = true,MenuItems = new List<IMenuNode>
                {
                    new MenuItem{Name = "fourth1",IsNode = false,Link = $"LinkToFourth1"},
                    new MenuItem{Name = "fourth2",IsNode = false,Link = $"LinkToFourth2"},
                    new MenuItem{Name = "fourth3",IsNode = false,Link = $"LinkToFourth3"},
                    new Menu{Name = "fourth4",IsNode = true,MenuItems = new List<IMenuNode>
                    {
                        new MenuItem{Name = "forth4sub1",IsNode = false,Link = "LinkToForth4Sub1"},
                        new MenuItem{Name = "forth4sub2",IsNode = false,Link = "LinkToForth4Sub2"},
                        new MenuItem{Name = "forth4sub3",IsNode = false,Link = "LinkToForth4Sub3"},
                        new MenuItem{Name = "forth4sub4",IsNode = false,Link = "LinkToForth4Sub4"},
                    }}
                }}
            };
            foreach (var item in menu)
            {
                item.Print();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
