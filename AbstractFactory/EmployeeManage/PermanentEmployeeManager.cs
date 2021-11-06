namespace AbstractFactory.EmployeeManage
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public int SetPay()
        {
            return 10;
        }

        public int SetBonus()
        {
            return 50;
        }

        public int SetHowsAllowance()
        {
            return 3000;
        }

        public int SetMedicalAllowance()
        {
            return 2000;
        }
    }
}