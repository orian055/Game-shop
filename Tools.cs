using System;

namespace Game
{
    class AdminTools
    {
        public void Tools()
        {
            Console.WriteLine("Enter admin password:");
            string password = Console.ReadLine();
            if (password != "yasmin")
            {
                Console.WriteLine("fuckoff");
            }
            Console.WriteLine("this is a tool i made to skip all side quests");
            Console.WriteLine("mainly for testing");
        }
        
      
    }
}