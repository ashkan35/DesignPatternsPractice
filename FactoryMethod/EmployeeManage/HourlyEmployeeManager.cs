namespace FactoryMethod.EmployeeManage
{
    public class HourlyEmployeeManager : IEmployeeManager
    {
        public int SetPay()
        {
            return 20;
        }

        public int SetBonus()
        {
            return 30;
        }



        public int SetMedicalAllowance()
        {
            return 1500;
        }
    }
}