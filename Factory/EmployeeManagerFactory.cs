using Factory.EmployeeManager;

namespace Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetManager(EmployeeType employeeType)
        {
            if (employeeType == EmployeeType.ContractEmployee)
                return new ContractEmployeeManager();
            else
                return new HourlyEmployeeManager();

        }
    }
}