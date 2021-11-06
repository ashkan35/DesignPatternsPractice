using AbstractFactory.FactoryMethod;

namespace AbstractFactory
{
    public class EmployeeMaker
    {

        public static void MakeSomeEmployee()
        {
            var context = new AbstractFactoryDbContext();
            var emp1 = new Employee { Id = 100, Name = "Ashkan", EmployeeType = EmployeeType.ContractEmployee ,ManagementLevel = ManagementLevel.Manager};
            var emp2 = new Employee { Id = 101, Name = "Shayan", EmployeeType = EmployeeType.HourlyEmployee,ManagementLevel = ManagementLevel.NoManager};
            var emp3 = new Employee {Id = 103, Name = "Nioosha", EmployeeType = EmployeeType.PermanentEmployee,ManagementLevel = ManagementLevel.Manager};
            context.Add(emp1);
            context.Add(emp2);
            context.Add(emp3);
            context.SaveChanges();
        }

    }
}