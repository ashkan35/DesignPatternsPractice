namespace Factory.EmployeeManager
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public int GetPay()
        {
            return 20;
        }

        public int GetBonus()
        {
            return 10;
        }
    }
}