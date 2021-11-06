using System;
using System.Linq;
using AbstractFactory.EmployeeManage;
using AbstractFactory.FactoryMethod;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new AbstractFactoryDbContext();
            EmployeeMaker.MakeSomeEmployee();
            var employees = context.Employees.ToList();
            foreach (var item in employees)
            {
                var employeeFactory = new EmployeeManagerFactory().CreateFactory(item);
                var employeeComputerFactory = new EmployeeSystemManager();
                item.ComputerType = employeeComputerFactory.CreateComputerFactory(item).ComputerName;
                employeeFactory.ApplySalary();
            }

            context.SaveChanges();
            foreach (var item in employees)
            {
                Console.WriteLine(
                    $"Name:{item.Name}" +
                    $"--Hourly:{item.HourlyPay}" +
                    $"--Bonus:{item.Bonus}" +
                    $"--HouseAllowance:{item.HouseAllowance}" +
                    $"--MedicalAllowance:{item.MedicalAllowance}" +
                    $"--Employee Type:{item.EmployeeType}" +
                    $"--ComputerType:{item.ComputerType}"
                );

            }
            Console.WriteLine("Hello World!");
        }
    }
}
