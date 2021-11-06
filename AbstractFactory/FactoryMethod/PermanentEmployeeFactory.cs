using AbstractFactory.EmployeeManage;

namespace AbstractFactory.FactoryMethod
{
    public class PermanentEmployeeFactory:BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            var employeeManager = new PermanentEmployeeManager();
            Emp.HouseAllowance = employeeManager.SetHowsAllowance();
            Emp.MedicalAllowance = employeeManager.SetMedicalAllowance();
            return employeeManager;
        }
    }
}