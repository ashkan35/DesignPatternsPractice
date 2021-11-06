using System;
using Builder.EmployeeManage;
using Builder.FactoryMethod;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = EmployeeMaker.GetEmployees();
            var employeeManagerFactory = new EmployeeManagerFactory();
            foreach (var employee in employees)
            {
                var employeeManager = employeeManagerFactory.CreateFactory(employee).ApplySalary();
                var employeeSystemManager = new EmployeeSystemManager().CreateComputerFactory(employee);
                employee.ComputerType = employeeSystemManager.ComputerName;
                Console.WriteLine(
                    $"Name:{employee.Name}" +
                    $"--Hourly:{employee.HourlyPay}" +
                    $"--Bonus:{employee.Bonus}" +
                    $"--HouseAllowance:{employee.HouseAllowance}" +
                    $"--MedicalAllowance:{employee.MedicalAllowance}" +
                    $"--Employee Type:{employee.EmployeeType}" +
                    $"--ComputerType:{employee.ComputerType}"
                );

            }
            Console.WriteLine("Hello World!");
        }
    }
}
