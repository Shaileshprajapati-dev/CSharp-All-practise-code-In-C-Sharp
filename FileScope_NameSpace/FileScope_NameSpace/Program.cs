namespace FileScope_NameSpace
{

    class Program
    {
        static void Main()
        {
            User user = new User
            {
                Id = 1,
                Name = "Shailesh",
                Email = "shailesh@example.com"
            };

            Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
        }
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }


}
