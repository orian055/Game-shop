using System;
using System.Threading;

namespace Game
{
    class Secret
    {
        public void runSecret()
        {
            Console.WriteLine("yo");
            Console.ReadLine();
            Console.WriteLine("you can kill the dragon easily now");
            Console.ReadLine();
            Console.WriteLine("but why stop there?");
            Console.ReadLine();
            Console.WriteLine("you can own the world");
            Console.ReadLine();
            Console.WriteLine("you declared war on russia...");
            Thread.Sleep(2500);
            Console.WriteLine("a nuclear war started");
            Thread.Sleep(2500);
            Console.WriteLine("the world has ended.");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}