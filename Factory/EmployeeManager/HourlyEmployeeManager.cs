namespace Factory.EmployeeManager
{
    public class HourlyEmployeeManager : IEmployeeManager
    {
        public int GetPay()
        {
            return 30;
        }
        public int GetBonus()
        {
            return 5;
        }
    }
}