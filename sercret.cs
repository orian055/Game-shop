using System;
using System.Threading;

namespace Game
{
    class Secret
    {
        public void runSecret(Hero hero)
        {
            if (hero.inv.Contains("WW3"))
            {
                Console.WriteLine("You are NOT nuking russia again");
                hero.inv.Remove("nuclear submarine");
            }
            else
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
            Console.WriteLine("a nuclear war almost started");
            Thread.Sleep(2500);
            Console.WriteLine("The goverment took you submarine");
            Console.ReadLine();
            hero.inv.Remove("nuclear submarine");
            hero.passes.Add("WW3");
            }
        }
    }
}