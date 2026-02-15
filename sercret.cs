using System;
using System.Threading;

namespace Game
{
    class Secret
    {
        public void runSecret(Hero hero)
        {
            if (hero.inv.Exists(i => i.Name == "WW3"))
            {
                Console.WriteLine("Govermnet: You are NOT declaring war on russia again");
                hero.inv.RemoveAll(i => i.Name == "nuclear submarine");
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
            hero.inv.RemoveAll(i => i.Name == "nuclear submarine");
            hero.passes.Add(new Pass("WW3"));
            }
        }
    }
}