using System;
using System.Threading;
namespace Game
{
    class Tut
    {
        public void runTut(Hero hero)
        {
            Console.WriteLine("Skip intro? [1] Yes | [2] No");
            int tutorial = ConsoleUtils.ReadInt("Choose: ");
            if (tutorial != 1 && tutorial != 2)
            {
                tutorial = 2; // default to full intro
            }

            
            if (tutorial == 2)  
            {
        Console.WriteLine("YO");
        Thread.Sleep(3000);
        Console.WriteLine("WELCOME TRAVELER!");
        Thread.Sleep(3000);
        Console.WriteLine("ILL SHOW YOU AROUND");
        Thread.Sleep(3000);
        Console.WriteLine("look there is a big bad dragon");
        Thread.Sleep(3000);
        Console.WriteLine("he wants to kill everyone");
        Thread.Sleep(3000);
        Console.WriteLine("nobody can stop him so why dont you try?");
        Thread.Sleep(3000);
        Console.WriteLine("at most you will die");
        Thread.Sleep(3000);
        Console.WriteLine("look there are a few things you can do");
        Thread.Sleep(3000);
        Console.WriteLine("you can train, work, gamble, and do all sorts of stuff");
        Thread.Sleep(3000);
        Console.WriteLine("when you get some money you can buy stuff at the store in the forest");
        Thread.Sleep(3000);
        Console.WriteLine("during your journey to the dragon you will get increases to your health, dmg, and SWAG");
        Thread.Sleep(3000);
        Console.WriteLine("(i was too lazy to add swag meter so just think about how cool you look and shut up)");
        Thread.Sleep(3000);
        Console.WriteLine("when you gamble you cant lose, this game was made to promote gambling");
        Thread.Sleep(3000);
        Console.WriteLine("you can go to places and explore!");
        Thread.Sleep(3000);
        Console.WriteLine("you will find all sorts of people, stores, opps, AND SECRETS!");
        Thread.Sleep(3000);
        Console.WriteLine("when youre ready to face the dragon, go to the mountain top. ");
        Thread.Sleep(3000);
        Console.WriteLine("and thats it");
        Thread.Sleep(3000);
        Console.WriteLine("take care traveler");
        if (!hero.passes.Exists(p => p.Name == "tutpassed"))
        { 
        hero.passes.Add(new Pass("tutpassed"));
        }
        }
    }
}
}