using FactoryMethod.EmployeeManage;

namespace FactoryMethod.FactoryMethod
{
    public class PermanentEmployeeFactory:BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            var manager= new PermanentEmployeeManager();
            Emp.HouseAllowance=manager.SetHowsAllowance();
            Emp.MedicalAllowance=manager.SetMedicalAllowance();
            return manager;
        }
    }
}