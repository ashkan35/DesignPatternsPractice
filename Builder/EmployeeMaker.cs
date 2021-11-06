using System.Collections.Generic;
using Builder.FactoryMethod;

namespace Builder
{
    public static  class EmployeeMaker
    {
        
        public static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = 100,
                    Name = "Ashkan",
                    EmployeeType = EmployeeType.ContractEmployee,
                    ManagementLevel = ManagementLevel.Manager
                },
                new Employee
                {
                    Id = 101,
                    Name = "Shayan",
                    EmployeeType = EmployeeType.HourlyEmployee,
                    ManagementLevel = ManagementLevel.NoManager
                },
                new Employee
                {
                    Id = 103,
                    Name = "Nioosha",
                    EmployeeType = EmployeeType.PermanentEmployee,
                    ManagementLevel = ManagementLevel.Manager
                }
            };
            return employees;
        }
    }
}