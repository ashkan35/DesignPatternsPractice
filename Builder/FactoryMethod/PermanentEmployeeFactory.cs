using Builder.EmployeeManage;

namespace Builder.FactoryMethod
{
    public class PermanentEmployeeFactory:BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            return new PermanentEmployeeManager();
        }
    }
}