using System;
using System.Runtime.CompilerServices;

namespace ShallowAndDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee {Id = 100, Name = "Ashkan", Zip = "22"};
            employee.Address = new Address {Street = "406"};
            var em2 = employee.DeepCopy();
            Console.WriteLine(employee.Address.Street);
            Console.WriteLine(em2.Address.Street);
            employee.Address.Street = "409";
            Console.WriteLine("After Change");
            Console.WriteLine(employee.Address.Street);
            Console.WriteLine(em2.Address.Street);
            //em2.Address = new Address {Street = employee.Address.Street};
            //em2.Name = "Shayan";
            //em2.Id = 103;
            //employee.Address.Street = "408";
            //Console.WriteLine(employee.Name);
            //Console.WriteLine(em2.Name);
            //Console.WriteLine(employee.Id);
            //Console.WriteLine(em2.Id);
            //Console.WriteLine(employee.Address.Street);
            //Console.WriteLine(em2.Address.Street);
        }



    }
}
