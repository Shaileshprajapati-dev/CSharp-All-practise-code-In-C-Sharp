using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_CLASS
{
     abstract class person
    {
        public string name;
        public int age;
        public string PhoneNumber;

        public abstract void display();
       
    }

    class student : person
    {
        public string rollNo;
        public string Fees;

        public override void display()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Age: " + age);
            Console.WriteLine("Student Phone Number: " + PhoneNumber);
            Console.WriteLine("Student Roll No: " + rollNo);
            Console.WriteLine("Student Fees: " + Fees);
        }
    }

    class teacher : person
    {
        public string qualification;
        public string salary;

        public override void display()
        {
            Console.WriteLine("Teacher Name: " + name);
            Console.WriteLine("Teacher Age: " + age);
            Console.WriteLine("Teacher Phone Number: " + PhoneNumber);
            Console.WriteLine("Teacher Qualification: " + qualification);
            Console.WriteLine("Teacher Salary: " + salary);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
             person p1 = new student();
            p1.name = "Shailesh Prajapati";
            p1.age = 20;
            p1.PhoneNumber = "123-456-7890";
            ((student)p1).rollNo = "S123";
            ((student)p1).Fees = "1000";
            p1.display();
            Console.WriteLine();


            person p2 = new teacher();
            p2.name = "Jane Smith";
            p2.age = 35;
            p2.PhoneNumber = "987-654-3210";
            ((teacher)p2).qualification = "PhD in Mathematics";
            ((teacher)p2).salary = "$5000";
            p2.display();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
