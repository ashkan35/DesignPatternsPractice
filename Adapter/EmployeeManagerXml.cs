using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Adapter
{
    public class EmployeeManagerXml
    {
        protected   readonly List<Employee> _employees;
        public EmployeeManagerXml()
        {
            _employees = new List<Employee>
            {
                new Employee {Id = 100, Name = "Ashkan"},
                new Employee {Id = 101, Name = "Nioosha"},
                new Employee {Id = 102, Name = "Shayan"}
            };

        }

        public virtual void GetEmployees()
        {
            XmlSerializer ser = new XmlSerializer(_employees.GetType());
            TextWriter writer = new StreamWriter("D:\\xmlText.txt",true);
            ser.Serialize(writer,_employees);
        }
    }
}