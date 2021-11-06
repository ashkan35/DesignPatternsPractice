namespace Builder.EmployeeManage
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

        public int SetHowsAllowance()
        {
            return 0;
        }

        public int SetMedicalAllowance()
        {
            return 500;
        }
    }
}