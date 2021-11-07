using System.IO;
using Newtonsoft.Json;

namespace Adapter
{
    public class EmployeeManagerJson:EmployeeManagerXml,IEmployeeAdapter
    {
        public override void GetEmployees()
        {
            var result = JsonConvert.SerializeObject(_employees, Formatting.Indented);
            File.AppendAllText("D:\\xmlText.txt",result);
        }
    }
}