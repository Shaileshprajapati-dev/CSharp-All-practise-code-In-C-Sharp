using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAR_AND_DYNAMIC
{
    internal class Program


    {
        public static int show()
        {
            return 0;
        }

        static void Main(string[] args)
        {
            int number = 10;
            var variableNumber = 20; // Implicitly typed variable
             Console.WriteLine($"Number: {number}, Variable Number: {variableNumber}");

            dynamic dynamicVariable = "Hello, World!"; // Dynamic type
            Console.WriteLine($"Dynamic Variable: {dynamicVariable}");


            Console.ReadLine(); 
        }
    }
}
