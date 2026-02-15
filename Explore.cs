using System;
using System.Net;
using System.Threading;

namespace Game
{
    class Explore
    {
        Random rnd;

        Shop shop;
        

        
    

        public Explore(Random random, Hero hero, Town town)
        {
            rnd = random;
            shop = new Shop(rnd);
            
        }
        public void RunExplore( Mountains marea, Village vill, Warriorspath war, Hero hero, Town town, Battle bat, Save save, Finals final)
        {
            
            bool Explore = true;
            while (Explore)
            {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║          EXPLORE THE WORLD            ║");
            Console.WriteLine("╚═══════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("[1] Forest        - Mystical and uncertain");
            Console.WriteLine("[2] Town          - Bustling with life");
            Console.WriteLine("[3] Mountains     - Towering and dangerous");
            Console.WriteLine();
            Console.WriteLine("[4] Exit");

            int choice = ConsoleUtils.ReadInt("Where will you go? ");
            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("You venture into the deep forest...");
                    Console.WriteLine("The trees grow denser, the air grows colder.");
                    Thread.Sleep(1500);
                    shop.RunShop(hero);
                    break;
                

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("You approach the familiar town gates...");
                    Console.WriteLine("The smell of food and the sounds of life fill the air.");
                    Thread.Sleep(1500);
                    town.runtown(hero, bat, rnd, save);
                    break;
                    
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("You gaze up at the towering mountains ahead...");
                    Console.WriteLine("The peaks seem to touch the sky itself.");
                    Thread.Sleep(1500);
                    marea.runMountains(vill, war, rnd, hero, bat, final);
                    break;

                case 4:
                    Explore = false;
                    break;

                default:
                    Console.WriteLine("That's not a valid destination.");
                    Thread.Sleep(1000);
                    break;                 
            }
            }

        }
    }
}