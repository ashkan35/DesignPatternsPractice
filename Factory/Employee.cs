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
}