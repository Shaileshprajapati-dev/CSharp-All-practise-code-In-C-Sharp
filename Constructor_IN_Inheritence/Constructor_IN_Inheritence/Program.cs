using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_IN_Inheritence
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("This is a BaseClass Constructor");
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("This is a DerivedClass Constructor");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc= new DerivedClass();
            Console.WriteLine("This is the Main Method");
            Console.ReadLine();
        }
    }
}
