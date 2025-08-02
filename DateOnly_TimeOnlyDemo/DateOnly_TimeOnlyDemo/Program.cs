namespace DateOnly_TimeOnlyDemo
{
    class BirthdayReminder
    {
        static void Main(string[] args)
        {
            // 🔹 Sample list of birthdays
            var birthdays = new Dictionary<string, DateOnly>
        {
            { "Anjali", new DateOnly(1998, 08, 02) },
            { "Rahul",  new DateOnly(1995, 01, 15) },
            { "Shailesh", new DateOnly(2000, 08, 02) }
        };

            // 🔹 Get today's date
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);

            Console.WriteLine("📅 Today: " + today.ToString("MMMM dd"));

            // 🔹 Check whose birthday is today
            bool found = false;
            foreach (var entry in birthdays)
            {
                if (entry.Value.Month == today.Month && entry.Value.Day == today.Day)
                {
                    Console.WriteLine($"🎉 Happy Birthday, {entry.Key}! 🎂");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("😔 No birthdays today.");
            }

            // 🔹 Example: Alarm time (using TimeOnly)
            TimeOnly alarmTime = new TimeOnly(7, 0);
            Console.WriteLine($"🔔 Set alarm for birthday calls at: {alarmTime}");
        }
    }
}
