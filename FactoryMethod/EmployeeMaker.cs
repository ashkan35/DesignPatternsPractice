namespace FactoryMethod
{
    public class EmployeeMaker
    {

        public static void MakeSomeEmployee()
        {
            var context = new FactoryMethodDbContext();
            var emp1 = new Employee { Id = 100, Name = "Ashkan", EmployeeType = EmployeeType.ContractEmployee };
            var emp2 = new Employee { Id = 101, Name = "Shayan", EmployeeType = EmployeeType.HourlyEmployee };
            var emp3 = new Employee {Id = 103, Name = "Nioosha", EmployeeType = EmployeeType.PermanentEmployee};
            context.Add(emp1);
            context.Add(emp2);
            context.Add(emp3);
            context.SaveChanges();
        }

    }
}