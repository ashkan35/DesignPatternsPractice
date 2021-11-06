using System.Runtime.InteropServices.ComTypes;

namespace FactoryMethod.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            return employee.EmployeeType switch
            {
                EmployeeType.ContractEmployee => new ContractEmployeeFactory(employee),
                EmployeeType.HourlyEmployee => new HourlyEmployeeFactory(employee),
                EmployeeType.PermanentEmployee => new PermanentEmployeeFactory(employee),
                _ => null
            };
        }
    }
}