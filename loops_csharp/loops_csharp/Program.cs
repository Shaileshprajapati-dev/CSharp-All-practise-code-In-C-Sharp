namespace loops_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string confrim;
            do
            {
                Console.WriteLine("Enter first Number");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second Number");
                int secondNumber = int.Parse(Console.ReadLine());
                int add = firstNumber + secondNumber;
                Console.WriteLine("The sum of {0} and {1} is {2}", add);
                Console.WriteLine("do you want to continue? (yes/no)");
                confrim = Console.ReadLine();
            }
         while ((confrim == "yes");

            Console.WriteLine("Thank you for using the program!");
                Console.WriteLine("Press any key to exit...");

            Console.ReadLine();
        }
    }
}
