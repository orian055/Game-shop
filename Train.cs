using System;

namespace Game
{
    public class Train
    {
        public void runtrain(Hero hero)
        {
            if (hero.passes.Exists(p => p.Name == "pushups"))
            {
            Console.WriteLine("you can go to warriors path now! dont ask why");
            Thread.Sleep(2500);
            }

            else
            {
            
            bool training = true;
            while (training)
            {
                Console.Clear();
                Console.WriteLine("[1] do a push up");
                Console.WriteLine("[2] flex infront of a miror");
                Console.WriteLine("[3] chug an energy drink");
                Console.WriteLine("[4] give up");
                Console.WriteLine($"pushups done:{hero.pushups}/100");
                Console.WriteLine($"stamina:{hero.stamina}");
                Console.WriteLine($"motivation:{hero.motivation}");
                int choice = ConsoleUtils.ReadInt("Choose: ");
                if (hero.pushups == 100)
                {
                    Console.WriteLine("you feel stronger");
                    hero.dmg += 10;
                    hero.passes.Add(new Pass("pushups"));
                    Console.WriteLine("added 10 dmg!");
                    Console.WriteLine();
                    Thread.Sleep(2500);
                    training = false;
                }
                switch (choice)
                {
                    case 1:
                    if (hero.stamina == 0 || hero.motivation == 0)
                        {
                            Console.WriteLine("you dont feel like doing it");
                            Thread.Sleep(2500);
                            break;
                        }
                    hero.pushups++;
                    hero.stamina--;
                    hero.motivation--;
                    break;

                    case 2:
                    hero.motivation++;
                    Console.WriteLine("Let's go!");
                    Thread.Sleep(500);
                    break;

                    case 3:
                    hero.stamina++;
                    Console.WriteLine("You feel energized.");
                    Thread.Sleep(500);
                    break;

                    case 4:
                    training = false;
                    break;

                    default:
                    break;
                }
            }
            }
        }
    }
}