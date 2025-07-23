using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers_01
{
    // This class is internal, meaning it is accessible only within the same assembly.
        
    internal class InternalClass
    {
        // This method is also internal, so it can be called from anywhere within the same assembly.
        internal void InternalMethod()
        {
            Console.WriteLine("This is an internal method.");
        }
    }

    // This class is public, meaning it can be accessed from other assemblies.

    public class PublicClass
    {
        // This method is public, so it can be called from anywhere, including other assemblies.
        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
        }
        // This method is private, so it can only be called within this class.
        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }
    }

    // The Program class is the entry point of the application.

    // It is also internal, so it can only be accessed within the same assembly.


    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the internal class and call its method.
            InternalClass internalObj = new InternalClass();
            internalObj.InternalMethod();
            // Create an instance of the public class and call its public method.
            PublicClass publicObj = new PublicClass();
            publicObj.PublicMethod();
            // The following line would cause a compile-time error because PrivateMethod is private.
            // publicObj.PrivateMethod(); 
            Console.ReadLine();
        }
    }
}
