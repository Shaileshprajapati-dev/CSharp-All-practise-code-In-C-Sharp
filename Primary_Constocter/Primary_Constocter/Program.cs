
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student(1, "Shailesh Prajapati", 20);
              student.Display();
    }
    }

    class Student(int Id, string Name, int Age)
   {
    
     public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
    }
 
  }
