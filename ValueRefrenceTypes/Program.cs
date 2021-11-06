using System;
using System.Collections.Generic;

namespace ValueReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee {Name = "Ashkan", Id = 100};
            Console.WriteLine($"{employee.Id}:{employee.Name}");
            ChangeValue(employee);
            Console.WriteLine($"{employee.Id}:{employee.Name}");
            int x = 100;
            ChangeIntValue(x);
            Console.WriteLine(x);
            string s= "Shayan";
            ChangeStringValue(s);
            Console.WriteLine(s);
            var list = new List<string> {"1", "2", "3"};
            ChangeListStringValue(list);
            Console.WriteLine(list[1]);

        }

        public static void ChangeValue(Employee employee)
        {
            employee.Name = "John";
        }

        public static void ChangeIntValue(int x)
        {
            x = 150;
            Console.WriteLine(x);
        }

        public static void ChangeStringValue(string x)
        {
            x = "Changed";
            Console.WriteLine(x);
        }
        public static void ChangeListStringValue(List<string> x)
        {
            x[1] = "Changed";
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }
    }
}
