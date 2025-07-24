using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACTION
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TaxDeduction = 0.1;
        double NetPay;

        public Employee(int empId, string empName, double grossPay)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.GrossPay = grossPay;
        }

        void CalculateNetPay()
        {
            if (GrossPay >= 30000)
            {
                NetPay = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Net Pay: {0}", NetPay);
            }
            else
            {
                Console.WriteLine("Net Pay: {0}", GrossPay);
            }
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("EmpId: {0}", EmpId);
            Console.WriteLine("EmpName: {0}", EmpName);
            Console.WriteLine("GrossPay: {0}", GrossPay);
            this.CalculateNetPay();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "Shailesh Prajapati ", 35000);
            emp1.DisplayEmployeeDetails();
            Employee emp2 = new Employee(102, "Koaml Prajapati ", 25000);
            emp2.DisplayEmployeeDetails();
            Employee emp3 = new Employee(103, "Ravi Prajapati ", 15000);
            emp3.DisplayEmployeeDetails();
            Employee emp4 = new Employee(104, "Rohit Prajapati ", 40000);
            emp4.DisplayEmployeeDetails();
            Employee emp5 = new Employee(105, "Ramesh Prajapati ", 20000);
            emp5.DisplayEmployeeDetails();
            Employee emp6 = new Employee(106, "Suresh Prajapati ", 30000);
            emp6.DisplayEmployeeDetails();
            Employee emp7 = new Employee(107, "Mahesh Prajapati ", 45000);
            emp7.DisplayEmployeeDetails();
            Employee emp8 = new Employee(108, "Rajesh Prajapati ", 50000);
            emp8.DisplayEmployeeDetails();
            Employee emp9 = new Employee(109, "Ajay Prajapati ", 60000);
            emp9.DisplayEmployeeDetails();
            Employee emp10 = new Employee(110, "Vijay Prajapati ", 70000);
            emp10.DisplayEmployeeDetails();
            Console.ReadLine();
        }
    }
}
