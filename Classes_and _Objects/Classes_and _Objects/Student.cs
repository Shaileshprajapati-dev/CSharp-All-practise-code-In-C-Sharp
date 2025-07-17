using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and__Objects
{
    internal class Student
    {
        int rollNo;
        string name;
        int age;
        int standard;

        public void SetStudent(int rollNo, string name, int age, int standard)
        {
            this.rollNo = rollNo;
            this.name = name; // You can set a default name or leave it empty
            this.age = age; // Default age
            this.standard = standard; // Default standard
        }

        public int GetStudent()
        {
          Console.WriteLine("Enter Student Roll No: {0}",this.rollNo);
          Console.WriteLine("Enter Student name No:  {0} ", this.name);
          Console.WriteLine("Enter Student Age No:  {0}", this.age);
          Console.WriteLine("Enter Student Standard No  {0}: ", this.standard);
        }


        static void Main(string[] args)
        {
          
            Student Shai = new Student();
             Shai.SetStudent(1, "Shai", 20, 3);
            Shai.GetStudent();

            Console.ReadLine();
        }

    }
}
