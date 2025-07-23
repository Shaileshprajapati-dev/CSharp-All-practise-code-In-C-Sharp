using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE_CSHARP
{
    class visitingEmployee : Employee
    {
        public int visitingSalary;
        public int visitingHours;
    }
    

    class permanentEmployee : Employee
    {
        public int permanentSalary;
        public int permanentHours;
    }
    

    class Employee
    {
        public int Empid;
        public string EmpName;
        public string EmpAge;
        public string EmpContactNo;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            permanentEmployee pEmp = new permanentEmployee();
            pEmp.Empid = 1;
            pEmp.EmpName = "John Doe";
            pEmp.EmpAge = "30";
            pEmp.EmpContactNo = "123-456-7890";
            pEmp.permanentSalary = 50000;
            pEmp.permanentHours = 40;
            Console.WriteLine($"Permanent Employee: {pEmp.EmpName}, ID: {pEmp.Empid}, Age: {pEmp.EmpAge}, Contact: {pEmp.EmpContactNo}, Salary: {pEmp.permanentSalary}, Hours: {pEmp.permanentHours}");
            visitingEmployee vEmp = new visitingEmployee();
            vEmp.Empid = 2;
            vEmp.EmpName = "Jane Smith";
            vEmp.EmpAge = "28";
            vEmp.EmpContactNo = "987-654-3210";
            vEmp.visitingSalary = 30000;
            vEmp.visitingHours = 20;
            Console.WriteLine($"Visiting Employee: {vEmp.EmpName}, ID: {vEmp.Empid}, Age: {vEmp.EmpAge}, Contact: {vEmp.EmpContactNo}, Salary: {vEmp.visitingSalary}, Hours: {vEmp.visitingHours}");
            Console.ReadLine();

        }
    }
}
