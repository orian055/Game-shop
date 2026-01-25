using System;
using System.Data.SqlTypes;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading;
using System.IO;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            Menus menu = new Menus();
            Hero hero = new Hero();
            Tut tut = new Tut();
            Work work = new Work();
            Inventory inv = new Inventory();
            Town town = new Town();
            Explore exp = new Explore(rnd, hero, town);
            Shop shop = new Shop(rnd);
            Mountains marea = new Mountains();
            Village vill = new Village();
            Warriorspath war = new Warriorspath();
            Secret end = new Secret();
            Save save = new Save();
            Battle bat = new Battle();
               
            bool MMenu = true;
            while (MMenu)
            {
              Console.Clear();
              bool canContinue = Save.SaveExists();
              menu.RunMainMenu(canContinue);

            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Enter a number.");
            }

            switch (choice)
            {  
             case 1: // START NEW GAME
             hero = new Hero(); // Ensure we start freshswitch (choice)
             RunGame(rnd, tut, work, exp, inv, shop, marea, vill, war, hero, end, town, bat);
             break;

             case 2:
             if (canContinue)
             {
             hero = Save.LoadGame(); 
             Console.WriteLine("Welcome back!");
             Thread.Sleep(1000);
             RunGame(rnd, tut, work, exp, inv, shop, marea, vill, war, hero, end, town,bat);
             }
             else
            {
              Console.WriteLine("\nNo save file. Start a new game");
              Thread.Sleep(2500);
            }
             break;

             case 3: // SAVE
             save.SaveGame(hero);
             Console.WriteLine("Progress saved. Press Enter...");
             Console.ReadLine();
             break;

             case 4:
             tut.runTut(hero);
             break;
    
              case 5:
              Environment.Exit(0);
              break;

              default:
              Console.WriteLine("\n1-5");
              Console.ReadLine();
              break;
            }
            }

        
        static void RunGame(Random rnd, Tut tut, Work work, Explore exp, Inventory inv, Shop shop, Mountains marea, Village vill, Warriorspath war, Hero hero, Secret end, Town town, Battle bat)
        {
            if (!hero.passes.Contains("tutpassed"))
            {
            tut.runTut(hero);
            }
           bool playing = true;
           while (playing)
            {
                Console.Clear();
                Console.WriteLine("[1] Train");
                Console.WriteLine("[2] Work");
                Console.WriteLine("[3] Gamble");
                Console.WriteLine("[4] Explore");
                Console.WriteLine("[5] ?");
                Console.WriteLine("[6] Inventory");
                Console.WriteLine("\nStats:");
                Console.WriteLine($"Money: {hero.Money}");
                Console.WriteLine($"Health: {hero.health}");
                Console.WriteLine("\n[0] Exit To Main Menu");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("1-6");
                    Console.ReadLine();
                    continue;
                }

                switch(choice)
                {
                  case 1:
                    Console.WriteLine("coming off strong");
                    Console.WriteLine();
                    break;
                  case 2: 
                  Console.WriteLine("You dont have a job, lets get creative!");
                    Console.ReadLine();
                  work.Runwork(hero, rnd);
                  break;
                  case 3:
                     Console.WriteLine("I Like you");
                     Console.WriteLine();
                     break;
                  case 4: 
                  Console.WriteLine("YAY! where we goin?");
                  Console.ReadLine();
                  exp.RunExplore(marea, vill, war, hero, town, bat);
                     break;
                  case 5: 
                  Console.WriteLine("Lets do something stupid");
                  if (!hero.inv.Contains("nuclear submarine"))
                  {
                    Console.WriteLine("you need the nuclear submarine for this.");
                    Console.WriteLine();
                  }
                  else
                        {
                            end.runSecret(hero);
                        }  
                     break;
                  case 6: 
                  Console.WriteLine("check yo pockets");
                  inv.runInv(hero);
                  Console.ReadLine();
                     break;
                  case 0:
                  Console.WriteLine("Ill be waiting for you");
                  playing = false;
                  Thread.Sleep(3000);
                     break;
                  default:
                  Console.WriteLine("pick 1-6");
                  Thread.Sleep(2500);
                  break; 
                }
                
            }
            
        }
    }
}
}


        
       