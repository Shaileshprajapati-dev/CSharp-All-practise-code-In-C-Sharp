using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] my_array = new int[5];
            my_array[0] = 11;
            my_array[1] = 14;
            my_array[2] = 15;
            my_array[3] = 30;
            my_array[4] = 20;

            Console.WriteLine(my_array[0]);

            Console.ReadLine();
        }
    }
}
