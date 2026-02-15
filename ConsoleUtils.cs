using System;

namespace Game
{
    public static class ConsoleUtils
    {
        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();
                if (int.TryParse(input, out var v)) return v;
                Console.WriteLine("Please enter a valid number.");
            }
        }

        public static void Pause(string message = "Press Enter to continue...")
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }

        public static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
