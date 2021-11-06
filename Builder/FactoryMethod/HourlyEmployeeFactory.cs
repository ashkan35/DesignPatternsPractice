using Builder.EmployeeManage;

namespace Builder.FactoryMethod
{
    public class HourlyEmployeeFactory:BaseEmployeeFactory
    {
        public HourlyEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            return new HourlyEmployeeManager();
        }
    }
}