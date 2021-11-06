using AbstractFactory.EmployeeManage;

namespace AbstractFactory.FactoryMethod
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
        
            return Emp;

        }

        public abstract IEmployeeManager Create();
    }
}