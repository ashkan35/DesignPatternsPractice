using AbstractFactory.FactoryMethod;

namespace AbstractFactory
{
    public class Employee
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int HourlyPay { get; set; }
        public int Bonus { get; set; }
        public int HouseAllowance { get; set; }
        public int MedicalAllowance { get; set; }
        public string ComputerType { get; set; }
        public ManagementLevel ManagementLevel { get; set; }

        public EmployeeType EmployeeType { get; set; }
    }
}