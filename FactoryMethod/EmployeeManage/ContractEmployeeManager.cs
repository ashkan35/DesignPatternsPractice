namespace FactoryMethod.EmployeeManage
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public int SetPay()
        {
            return 30;
        }

        public int SetBonus()
        {
            return 10;
        }

    }
}