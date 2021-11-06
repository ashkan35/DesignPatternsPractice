using Builder.EmployeeManage;

namespace Builder.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected  Employee Emp;

        protected BaseEmployeeFactory(Employee emp)
        {
            Emp = emp;
        }

        public Employee ApplySalary()
        {
            var employeeManager = this.Create();
            Emp.HourlyPay = employeeManager.SetPay();
            Emp.Bonus = employeeManager.SetBonus();
            Emp.HouseAllowance = employeeManager.SetHowsAllowance();
            Emp.MedicalAllowance = employeeManager.SetMedicalAllowance();
            return Emp;

        }

        public abstract IEmployeeManager Create();
    }
}