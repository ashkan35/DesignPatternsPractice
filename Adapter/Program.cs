using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeManager = new EmployeeManagerXml();
            employeeManager.GetEmployees();
            Console.WriteLine("finished");
        }
    }
}
