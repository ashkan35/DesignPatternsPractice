using System;
using System.Threading.Tasks;

namespace Singlton
{
    class Program
    {
        static void Main(string[] args)
        {
           Parallel.Invoke(PrintStudent,PrintEmployee);
            Console.WriteLine("Did you see?Fuck you");
        }

        private static void PrintStudent()
        {
         
            var s1 = Singleton.Singleton.GetInstance;
            s1.PrintDetails("from student");
        }

        private static void PrintEmployee()
        {
            var s2 = Singleton.Singleton.GetInstance;
            s2.PrintDetails("from employee");
        }
    }
}
