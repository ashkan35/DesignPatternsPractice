using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Factory
{
    class Program
    {
        private readonly FactoryPatternDbContext _context;
        public Program(FactoryPatternDbContext context)
        {
            _context = context;
        }
        static void Main(string[] args)
        {
            EmployeeMaker.MakeSomeEmployee();
            var context = new FactoryPatternDbContext();
            var emp = context.Employees.SingleOrDefault(x => x.Name == "Ashkan");
            Console.WriteLine(emp.Id);
            var emps = context.Employees.ToList();
            var empfac = new EmployeeManagerFactory();
            foreach (var item in emps)
            {
                var empManager = empfac.GetManager(item.EmployeeType);
                item.HourlyPay = empManager.GetPay();
                item.Bonus = empManager.GetBonus();
            }

            context.SaveChanges();
            foreach (var item in emps)
            {
                Console.WriteLine($"{item.EmployeeType}:Hourly{item.HourlyPay}:Bonus{item.Bonus}");
            }
            Console.WriteLine(DateTime.Now.DayOfYear);
        }

        public class EmployeeMaker
        {
          
            public static void  MakeSomeEmployee()
            {
                var context = new FactoryPatternDbContext();
                var emp1 = new Employee {Id = 100, Name = "Ashkan", EmployeeType = EmployeeType.ContractEmployee};
                var emp2 = new Employee { Id = 101, Name = "Shayan", EmployeeType = EmployeeType.HourlyEmployee };
                context.Add(emp1);
                context.Add(emp2);
                context.SaveChanges();
            }

        }
    }
}
