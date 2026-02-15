using System;

namespace Game
{
    class AdminTools
    {
        public void Run()
        {
            Console.WriteLine("Enter admin password:");
            string password = Console.ReadLine() ?? string.Empty;
            if (password != "yasmin")
            {
                Console.WriteLine("Incorrect password.");
                return;
            }

            Console.WriteLine("Admin tools enabled.");
            Console.WriteLine("This tool can be used to toggle testing features.");
        }
    }
}