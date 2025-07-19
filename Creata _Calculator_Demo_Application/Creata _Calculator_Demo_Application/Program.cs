using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creata__Calculator_Demo_Application
{
    internal class Program
    {

        public static void Addition(int a, int b)
        {
           int result = a + b;
           Console.WriteLine("Addition Result: {0} " + result);
        }

        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction Result: {0} " + result);
        }

        public static void Multplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multplication Result: {0} " + result);
        }


        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division Result: {0} " + result);
        }

        static void Main(string[] args)
        {
            // how to use the Creata Calculator library
            //method 1: using the Creata Calculator library
            //decimal result = Creata_Calculator.Calculator.Add(5.5m, 2.2m);
            //conditional compilation to use the Creata Calculator library


            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Secound Number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operator (+, -, *, /)");
            string op = Console.ReadLine();

            if(op == "+")
            {
                Addition(num1, num2);
            }
            else if(op == "-")
            {
                Subtraction(num1, num2);
            }
            else if(op == "*")
            {
                Multplication(num1, num2);
            }
            else if(op == "/")
            {
                Division(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            Console.ReadLine();
        }
    }
}
