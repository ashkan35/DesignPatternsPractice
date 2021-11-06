using System;
using System.Linq;
using FactoryMethod.FactoryMethod;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new FactoryMethodDbContext();
            EmployeeMaker.MakeSomeEmployee();
            var employees = context.Employees.ToList();
            foreach (var item in employees)
            {
                var employeeFactory = new EmployeeManagerFactory().CreateFactory(item).ApplySalary();
               
            }

            context.SaveChanges();
            foreach (var item in employees)
            {
                Console.WriteLine(
                    $"Name:{item.Name}" +
                    $"--Hourly:{item.HourlyPay}" +
                    $"--Bonus:{item.Bonus}" +
                    $"--HouseAllowance:{item.HouseAllowance}" +
                    $"--MedicalAllowance:{item.MedicalAllowance}"+
                    $"--Employee Type:{item.EmployeeType}"
                    );
                    
            }

            Console.WriteLine("Hello World!");
        }
    }
}
