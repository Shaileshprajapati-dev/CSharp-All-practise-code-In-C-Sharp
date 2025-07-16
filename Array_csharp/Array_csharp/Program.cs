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

            for (int i = 0; i < my_array.Length; i++)
            {
                Console.WriteLine(my_array[i]);
            }

            string[] my_string_array = new string[5];
            my_string_array[0] = "Hello";
            my_string_array[1] = "Shailesh";
            my_string_array[2] = "prajapati";
            my_string_array[3] = "Komal Prajapati";
            
            foreach (string str in my_string_array)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
