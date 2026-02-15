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
            Train david = new Train();
            Gamble gamble = new Gamble();
            Finals final = new Finals();
            ModMenu modMenu = new ModMenu();
            QuestLog questLog = new QuestLog();

            bool MMenu = true;
            while (MMenu)
            {
              Console.Clear();
              bool canContinue = Save.SaveExists();
              menu.RunMainMenu(canContinue);

              int choice = ConsoleUtils.ReadInt("Select an option: ");

              switch (choice)
              {
                case 1: // START NEW GAME
                  hero = new Hero(); // Ensure we start fresh
                  RunGame(rnd, tut, work, exp, inv, shop, marea, vill, war, hero, end, town, bat, david, gamble, save, final, questLog, modMenu);
                  break;

                case 2: // LOAD
                  if (canContinue)
                  {
                    hero = Save.LoadGame();
                    Console.WriteLine("Welcome back!");
                    Thread.Sleep(1000);
                    RunGame(rnd, tut, work, exp, inv, shop, marea, vill, war, hero, end, town, bat, david, gamble, save, final, questLog, modMenu);
                  }
                  else
                  {
                    Console.WriteLine("\nNo save file. Start a new game");
                    Thread.Sleep(2500);
                  }
                  break;

                case 3: // SAVE
                  save.SaveGame(hero);
                  Console.WriteLine("Progress saved.");
                  ConsoleUtils.Pause();
                  break;

                case 4: // TUTORIAL
                  tut.runTut(hero);
                  break;

                case 5: // EXIT
                  Environment.Exit(0);
                  break;

                case 6: // MOD MENU (hidden, needs password)
                  modMenu.Run(hero);
                  break;

                default:
                  Console.WriteLine("Enter a number between 1 and 5.");
                  Thread.Sleep(1500);
                  break;
              }
            }

        
        static void RunGame(Random rnd, Tut tut, Work work, Explore exp, Inventory inv, Shop shop, Mountains marea, Village vill, Warriorspath war, Hero hero, Secret end, Town town, Battle bat, Train david, Gamble gamble, Save save, Finals final, QuestLog questLog, ModMenu modMenu)
        {
            if (!hero.passes.Exists(p => p.Name == "tutpassed"))
            {
            tut.runTut(hero);
            }
           bool playing = true;
           while (playing)
            {
              Console.Clear();
              Console.WriteLine("╔═══════════════════════════════════════╗");
              Console.WriteLine("║       What will you do?               ║");
              Console.WriteLine("╚═══════════════════════════════════════╝");
              Console.WriteLine("[1] Train      [2] Work      [3] Gamble");
              Console.WriteLine("[4] Explore    [5] ?         [6] Inventory");
              Console.WriteLine("[7] Quest Log  [8] ModMenu");
              Console.WriteLine();
              Console.WriteLine($"Money: ${hero.Money}  Health: {hero.health}/{hero.maxhp}  Damage: {hero.dmg}");
              Console.WriteLine("[0] Exit To Main Menu");

              int choice = ConsoleUtils.ReadInt("Choose an action: ");

              switch (choice)
                {
                  case 1:
                  david.runtrain(hero);  
                  break;
                  case 2: 
                  work.Runwork(hero, rnd);
                  break;
                  case 3:
                  gamble.letsgogambling(hero, rnd);
                  break;
                  case 4: 
                  exp.RunExplore(marea, vill, war, hero, town, bat, save, final);
                  break;
                  case 5: 
                  if (!hero.inv.Exists(i => i.Name == "nuclear submarine"))
                  {
                    Console.WriteLine("you need the nuclear submarine for this.");
                    Thread.Sleep(2500);
                  }
                  else
                        {
                            end.runSecret(hero);
                        }  
                     break;
                  case 6: 
                  inv.runInv(hero);
                     break;
                  case 7:
                  questLog.DisplayCompact(hero);
                     break;
                  case 8:
                  modMenu.Run(hero);
                     break;
                  case 0:
                  playing = false;
                     break;
                  default:
                    Console.WriteLine("Pick a valid option.");
                    Thread.Sleep(1000);
                    break; 
                }
                
            }
            
        }

        }
    }
}


        
       