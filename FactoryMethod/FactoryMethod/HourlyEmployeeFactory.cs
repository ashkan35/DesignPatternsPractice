using FactoryMethod.EmployeeManage;

namespace FactoryMethod.FactoryMethod
{
    public class HourlyEmployeeFactory:BaseEmployeeFactory
    {
        public HourlyEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            var manager= new HourlyEmployeeManager();
            Emp.MedicalAllowance=manager.SetMedicalAllowance();
            return manager;
        }
    }
}