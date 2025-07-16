namespace Static_And_Instance_Members
{

    class Student
    {
        public int rollNo;
        public string firstName;
        public string lastName;
        public int standard;

        public void printFullnName() {
            string fullname = this.firstName + " " + this.lastName;
            Console.WriteLine(fullname);
        
        }

    }


    internal class Program
    {
       
      
        static void Main(string[] args)
        {
           
            Student Shai = new Student();
            Shai.rollNo= 30;
            Shai.firstName = "shailesh";
            Shai.lastName = "prajapati";
            Shai.standard = 1;


            Student pra = new Student();
            pra.rollNo = 20;

            pra.firstName = "Komal";
            pra.lastName = "prajapati";
            pra.standard = 1;

            Console.WriteLine(Shai.rollNo);
            Console.WriteLine(Shai.firstName);
            Console.WriteLine(Shai.lastName);
            Console.WriteLine(Shai.standard);
            Shai.printFullnName();

            Console.WriteLine(pra.rollNo);
            Console.WriteLine(pra.firstName);
            Console.WriteLine(pra.lastName);
            Console.WriteLine(pra.standard);
            pra.printFullnName();


            Console.ReadLine();

        }
    }
}
