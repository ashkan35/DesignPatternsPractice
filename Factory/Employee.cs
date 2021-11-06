namespace Factory
{
    public class Employee
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int HourlyPay { get; set; }
        public int Bonus { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }

    public interface IEmployeeManager
    {
        int GetPay();
        int GetBonus();
    }

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