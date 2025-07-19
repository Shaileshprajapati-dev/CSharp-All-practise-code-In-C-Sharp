using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
   


    internal class Program
    {
        public Program()
        {
            // This is a constructor for the program class.
            // It initializes the program instance.
            Console.WriteLine("this is a first Constructor ");
        }


        public Program(int a, int b)
        {
            // This is a constructor for the program class.
            // It initializes the program instance.
            Console.WriteLine("This is a Secound Constructor {0}" , (a+b));
        }

        public Program(int a, int b, int c)
        {
            // This is a constructor for the program class.
            // It initializes the program instance.
            Console.WriteLine("This is a third Constructor {0}", (a + b +c));
        } 
        static void Main(string[] args)
        {
            Program p = new Program();
            Program p1 = new Program(10, 20);
            Program p2 = new Program(10, 20, 30);

            Console.ReadLine();

        }
    }
}
