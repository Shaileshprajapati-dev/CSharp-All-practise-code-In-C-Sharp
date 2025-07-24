using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACES
{
    interface IEmployee
    { 
       void showDetails();

    }

    class Employee : IEmployee
    {
        public void showDetails()
        {
            Console.WriteLine("Employee details are displayed.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = new Employee();
            employee.showDetails();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
