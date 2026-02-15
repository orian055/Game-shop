using System;
using System.Threading;

namespace Game
{
    class Work
    {
        public void Runwork(Hero hero, Random rnd)
        {
            Console.Clear();
            Console.WriteLine("=== Work ===");
            Console.WriteLine("[1] Con someone      [2] Play guitar on the street");
            Console.WriteLine("[3] Create online content      [4] Exit");

            int choice = ConsoleUtils.ReadInt("Choose a job: ");

            switch (choice)
            {
                case 1:
                    {
                        DoJob(hero, rnd, "You conned someone successfully", 5, 100);
                        break;
                    }
                case 2:
                    {
                        DoJob(hero, rnd, "You played an awesome set, the crowd cheered", 5, 100);
                        break;
                    }
                case 3:
                    {
                        DoJob(hero, rnd, "You posted new content and gained attention", 5, 100);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Returning to menu...");
                        break;
                    }  
                default:
                    {
                        Console.WriteLine("Please pick a valid option (1-4).");
                        break;
                    }    

            }      
        }
        


    private void DoJob(Hero hero, Random rnd, string name, int minPay, int maxPay)
        {
            Console.WriteLine($"\n{name}.");
            Thread.Sleep(800);

            int earned = rnd.Next(minPay, maxPay + 1);
            hero.Money += earned;

            Console.WriteLine($"You earned: {earned:C0}");
            Console.WriteLine($"Wallet: {hero.Money:C0}");

            Thread.Sleep(900);
            ConsoleUtils.Pause();
        }
    }
}

