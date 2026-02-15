using System;

namespace Game
{
    public class Gamble
    {
        public void letsgogambling(Hero hero, Random rnd)
        {
         bool gambel = true;
         while (gambel)
            {
                int bettingyay = rnd.Next(1,3);
                Console.Clear();
                Console.WriteLine("=== Gamble ===");
                Console.WriteLine("Enter a betting amount:");
                int amount = ConsoleUtils.ReadInt("Amount: ");
                if (amount <= 0)
                {
                    Console.WriteLine("Invalid amount.");
                    Thread.Sleep(1200);
                    break;
                }

                if (hero.Money < amount)
                {
                    Console.WriteLine("You don't have enough money.");
                    Thread.Sleep(1200);
                    break;
                }

                hero.Money -= amount;
                Console.Write("Gambling");
                for (int i = 0; i < 3; i++) { Console.Write('.'); Thread.Sleep(300); }
                Console.WriteLine();

                int won = amount * bettingyay;
                Console.WriteLine($"You won: {won:C0}");
                Thread.Sleep(1200);
                hero.Money += won;
                gambel = false;
            }   
        }
    }
}