using System;

namespace Game
{
    public class Town
    {
        public void runtown(Hero hero, Battle bat, Random rnd)
        {
            Console.WriteLine("=== Town ===");
            Console.WriteLine("[1] Go to the dark ally");
            Console.WriteLine("[2] Go to the market");
            Console.WriteLine("[3] Go to the mine");
            Console.WriteLine("[4] Go to the bank");
            Console.WriteLine("[5] Go to the bar");
            Console.WriteLine("[6] Sit on a bench");
            Console.WriteLine("[7]");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("1 - 10");
                Thread.Sleep(2500);
            }
            else
            {
                switch (choice)
                {
                    case 1:
                    if (!hero.passes.Contains("wizq"))
                        {
                            Console.WriteLine("nothing to look for there");
                            Thread.Sleep(2500);
                            break;
                        }
                    if (hero.inv.Contains("za"))
                        {
                            Console.WriteLine("you got the za, give it to the wizard");
                            Thread.Sleep(2500);
                            break;
                        }
                    if  (hero.passes.Contains("wizqc"))
                        {
                            Console.WriteLine("you completed the quest!");
                            Thread.Sleep(2500);
                            break;
                        }
                            
                    else
                    {     
                    Console.WriteLine("You went inside.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Some weird guy came to you");
                    Thread.Sleep(2500);
                    Console.WriteLine("Weird Guy: do you want some za?");
                    Thread.Sleep(2500);
                    Console.WriteLine("you: of course, what other fucking reason would i have to come into this weird ahh dark ally of yours. its not like i woke up in the morning and said to myself: OH I CANT WAIT TO GET RAPED TODAY! fuck you just give me the za already so that weird wizard will stop annoying me");
                    Thread.Sleep(2500);
                    Console.WriteLine("Weird Guy: k. thats 5000000$");
                    Console.ReadLine();
                    bat.runbattle(rnd, hero);
                    Console.WriteLine("you beated the living shit out of him");
                    Thread.Sleep(2500);
                    Console.WriteLine("za added to inventory");
                    Console.ReadLine();
                    hero.inv.Add("za");
                    hero.inv.Add("zaqc");
                    break;
                    }
                }
            }
        }
    }
}