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

             int[,] my_multi_array = new int[2,0]
 {
     { 1, 2, 3, 4 },
     { 5, 6, 7, 8  },
     { 5, 6, 7, 8  }
 };

 foreach (int item in my_multi_array)
 {
     Console.WriteLine(item);
 }

 int[][] jagged_array = new int[2][];    
 jagged_array[0] = new int[] { 1, 2, 3 ,34,44,56};
 jagged_array[1] = new int[] { 4, 5, 6 , 78, 76};

 Console.Write(jagged_array[1][1]);

            Console.ReadLine();
        }
    }
}
