using AbstractFactory.EmployeeManage;

namespace AbstractFactory.FactoryMethod
{
    public class HourlyEmployeeFactory:BaseEmployeeFactory
    {
        public HourlyEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            var employeeManager = new HourlyEmployeeManager();
            Emp.MedicalAllowance = employeeManager.SetMedicalAllowance();
            return employeeManager;
        }
    }
}