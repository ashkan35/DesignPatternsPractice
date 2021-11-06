using FactoryMethod.EmployeeManage;

namespace FactoryMethod.FactoryMethod
{
    public class ContractEmployeeFactory:BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
     
            return new ContractEmployeeManager();
            
        }
    }
}