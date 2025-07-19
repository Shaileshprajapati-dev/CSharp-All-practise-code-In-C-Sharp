using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cunstructor_Csharp_Console_appliction
{
    internal class Employees
    {

        //public Employees()
        //{
        //    Console.WriteLine("Constructor called");
        //}

        int EmpId;
        string EmpName;
        int EmpAge;

        public Employees (int EmpId, string EmpName, int EmpAge) { 
        
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
        }

        public int GetEmpId()
        {
            return this.EmpId;
        }

        public string GetEmpName()
        {
            return this.EmpName;
        }

        public int GetEmpAge() {

            return this.EmpAge;
        }

        static void Main(string[] args)

        {
            Employees Shai = new Employees(11, "Shailesh Prajapati", 25);
            Employees Kom = new Employees(11, "Komal Prajapati", 23);


            Console.WriteLine("Employees is Id : {0} ", Shai.GetEmpId());
            Console.WriteLine("Employees is IdName : {0} ", Shai.GetEmpName());
            Console.WriteLine("Employees is IdAge : {0} ", Shai.GetEmpAge());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Employees is Id : {0} ", Kom.GetEmpId());
            Console.WriteLine("Employees is IdName : {0} ", Kom.GetEmpName());
            Console.WriteLine("Employees is IdAge : {0} ", Kom.GetEmpAge());
            Console.ReadLine();
        }
    }
}
