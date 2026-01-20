using System;

namespace Game
{
    public class Warriorspath
    {
        public void runWarrior(Random rnd, Hero hero)
        {
            Console.WriteLine("yo");
            Console.ReadLine();
            Console.WriteLine("some fuckass dragon wants to fight");
            int dragonhp = 5;
            
            bool fight = true;
            while (fight)
            {
                Console.Clear();
            int atk = rnd.Next(1,5);
            Console.WriteLine("[1] [2] [3] [4] [5]");
            Console.WriteLine($"dragon health: {dragonhp}");
            Console.WriteLine($"your health: {hero.health}");
            
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            { Console.WriteLine("you will fucking die.");
            Console.ReadLine();
            }
            
            else
            {
                
                if (dragonhp == 0)
                    {
                        Console.WriteLine("You win");
                        Console.ReadLine();
                        fight = false;
                    }
                else if (hero.health == 0)
                    {
                        Console.WriteLine("you lose");
                        Console.ReadLine();
                        fight = false;
                    }    

                else if (choice == atk)
                {
                    Console.WriteLine("hit");
                    dragonhp--;
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("The dragon got a hit");
                    hero.health--;
                    Console.ReadLine();
                }
            }
            }
        }
    }
}