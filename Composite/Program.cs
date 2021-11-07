using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<INode>
            {
                new Person {Name = "Ashkan Semsar"},
                new Person {Name = "Shayan Semsar"},
                new Group
                {
                    Name = "Semsar",
                    Nodes = new List<INode>
                    {
                        new Person {Name = "Maman"},
                        new Person {Name = "Masoud"},
                        new Group
                        {
                            Name = "Naghmeh Family",
                            Nodes = new List<INode>
                            {
                                new Person {Name = "Naghmeh"},
                                new Person {Name = "Behrooz"},
                                new Person {Name = "Alma"},
                                new Person {Name = "Borna"}
                            }
                        }
                    }
                }
            };
            foreach (var item in list)
            {
                item.Score = 1000000 / list.Count;
            }
            Console.ReadLine();
        }
    }
}
