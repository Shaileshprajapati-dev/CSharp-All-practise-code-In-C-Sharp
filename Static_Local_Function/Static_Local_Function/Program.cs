namespace Static_Local_Function
{
    class Program
    {
        static void Main()
        {
            int val = 10;

            // Regular Local Function
            void ShowRegular()
            {
                Console.WriteLine("Regular Function: " + val); // val को access कर सकता है
            }

            // Static Local Function
            static void ShowStatic(int v)
            {
                Console.WriteLine("Static Function: " + v); // val को parameter से लेना पड़ेगा
            }

            ShowRegular();
            ShowStatic(val);
        }
    }
}
