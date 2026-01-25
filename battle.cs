using System;

namespace Game
{
    public class Battle
    {
        public void runbattle(Random rnd, Hero hero)
        {
            string loading = "...";
            foreach (char c in loading)
            {
                Console.Write(c);
                Thread.Sleep(2500);
            }
            Console.WriteLine("im gonna kick your ass");
            Console.ReadLine();
            int dragonhp = 5;
            int round = 1;
            bool fight = true;
            while (fight)
            {
            if (round == 1)
            {
            
                Console.Clear(); 
            int atk = rnd.Next(1,3);
            Console.WriteLine("[1] [2] [3]");
            Console.WriteLine("ATTACK!");
            Console.WriteLine($"dudes health: {dragonhp}");
            Console.WriteLine($"your health: {hero.health}");
            if (hero.inv.Contains("basic sword"))
                        {
                            Console.WriteLine("[5] to use basic sword!");
                        }
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
                        hero.passes.Add ("warrior");
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
                    round--;
                    Console.ReadLine();
                }
                else if (hero.inv.Contains("basic sword") && choice == 5)
                            {
                                Console.WriteLine("used basic sword");
                                dragonhp -= 5;
                                hero.inv.Remove("basic sword");
                                Console.ReadLine();
                            }
                else
                {
                    Console.WriteLine("miss");
                    round--;
                    Console.ReadLine();
                }
            }
            }
            

            else
            {
               
                Console.Clear(); 
            int dfnc = rnd.Next(1,5);
            Console.WriteLine("[1] [2] [3] [4] [5]");
            Console.WriteLine("DEFEND");
            Console.WriteLine($"dudes health: {dragonhp}");
            Console.WriteLine($"your health: {hero.health}");
            
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            { Console.WriteLine("you will fucking die.");
            Console.ReadLine();
            }
            
            else
            {
                
                
                if (hero.health == 0)
                    {
                        Console.WriteLine("you lose");
                        Console.ReadLine();
                        fight = false;
                    }    

                else if (choice != dfnc)
                {
                    Console.WriteLine("doged");
                    round++;
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("you got hit");
                    hero.health--;
                    round++;
                    Console.ReadLine();
                
                }
            }
            }
            }
            
        }
    }
}        