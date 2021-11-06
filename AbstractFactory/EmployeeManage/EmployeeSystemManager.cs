using AbstractFactory.ConcreteProducts;
using AbstractFactory.FactoryMethod;
using AbstractFactory.FactoryMethod.AbstractFactory;

namespace AbstractFactory.EmployeeManage
{
    public class EmployeeSystemManager
    {
        public ComputerFactory CreateComputerFactory(Employee employee)
        {
            return employee.EmployeeType switch
            {
                EmployeeType.PermanentEmployee when employee.ManagementLevel == ManagementLevel.Manager =>
                    new MacLaptopFactory(),
                EmployeeType.PermanentEmployee => new MacFactory(),
                EmployeeType.HourlyEmployee when employee.ManagementLevel == ManagementLevel.Manager =>
                    new DellLaptopFactory(),
                EmployeeType.HourlyEmployee => new DellFactory(),
                _ => new DellFactory()
            };
        }
    }
}