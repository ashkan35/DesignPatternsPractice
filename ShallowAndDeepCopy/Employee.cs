using System;
using System.Runtime.InteropServices.ComTypes;

namespace ShallowAndDeepCopy
{
    public class Employee:Copy<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Zip { get; set; }
        public Address Address { get; set; }


    }
}