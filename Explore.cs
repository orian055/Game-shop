using System;
using System.Net;

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
        public void RunExplore( Mountains marea, Village vill, Warriorspath war, Hero hero, Town town, Battle bat)
        {
            
            
            Console.Clear();
            Console.WriteLine("=== Explore ===");
            Console.WriteLine("[1] Forest");
            Console.WriteLine("[2] Town");
            Console.WriteLine("[3] Mountains");
            Console.WriteLine("[4] Exit");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {Console.WriteLine("number.");}
            switch (choice)
            {
                case 1:                 
                        Console.WriteLine("Be carefull!");
                        shop.RunShop(hero);
                        break;
                

                case 2:
                    
                        town.runtown(hero, bat, rnd);
                        break;
                    
                case 3:

                        Console.WriteLine("Its a scary place.");
                        marea.runMountains(vill, war, rnd, hero);
                        break;

                case 4:

                        break;

                default:

                         Console.WriteLine("1-4");
                         break;                 
            }

        }
    }
}