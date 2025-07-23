using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_HIDING_INC_
{
    class parent
    { 
      public void Method()
        {
            Console.WriteLine("Parent class Method");
        }
    }

    class child : parent
    {
        public new void Method()
        {
            Console.WriteLine("Child class Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p.Method(); // Calls Parent Method
            child c = new child();
            c.Method(); // Calls Child Method
            parent pc = new child();
            pc.Method(); // Calls Parent Method due to method hiding
            Console.ReadLine(); 
        }
    }
}
