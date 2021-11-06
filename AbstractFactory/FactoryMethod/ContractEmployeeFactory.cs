using AbstractFactory.EmployeeManage;

namespace AbstractFactory.FactoryMethod
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