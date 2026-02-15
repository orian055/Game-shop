using System;
using System.Threading;

namespace Game
{
    public class Battle
    {
        public void runbattle(Random rnd, Hero hero, string name, int hp, int dmg, string menance)
        {
            string loading = "...";
            foreach (char c in loading)
            {
                Console.Write(c);
                Thread.Sleep(300);
            }
            Console.WriteLine($"\n{menance}");
            ConsoleUtils.Pause();

            int round = 1;
            int hitcounter = 0;
            bool fight = true;
            while (fight)
            {
                if (hitcounter == 3)
                {
                    bool stun = true;
                    while (stun)
                    {
                        Console.WriteLine($"=== {name} is stunned ===");
                        Thread.Sleep(600);
                        if (hero.inv.Count == 0)
                        {
                            stun = false;
                            break;
                        }
                        if (hero.inv.Exists(i => i.Name == "energy coffee")) Console.WriteLine("[1] use energy coffee");
                        if (hero.inv.Exists(i => i.Name == "bandage")) Console.WriteLine("[2] use bandage");
                        if (hero.inv.Exists(i => i.Name == "nice sandwich")) Console.WriteLine("[3] use nice sandwich");
                        if (hero.inv.Exists(i => i.Name == "op healing potion")) Console.WriteLine("[4] use op healing potion");
                        if (hero.inv.Exists(i => i.Name == "supreme elixir")) Console.WriteLine("[5] use supreme elixir");
                        Console.WriteLine("[0] do a silly dance");

                        int choice = ConsoleUtils.ReadInt("Choose: ");

                        switch (choice)
                        {
                            case 1:
                                if (!hero.inv.Exists(i => i.Name == "energy coffee"))
                                {
                                    Console.WriteLine("Not a valid option.");
                                    break;
                                }
                                Console.WriteLine("Used energy coffee");
                                hero.health += hero.itemstat("energy coffee");
                                    hero.inv.RemoveAll(i => i.Name == "energy coffee");
                                stun = false;
                                hitcounter = 0;
                                break;
                            case 2:
                                if (!hero.inv.Exists(i => i.Name == "bandage"))
                                {
                                    Console.WriteLine("Not a valid option.");
                                    break;
                                }
                                Console.WriteLine("Used bandage");
                                hero.health += hero.itemstat("bandage");
                                    hero.inv.RemoveAll(i => i.Name == "bandage");
                                stun = false;
                                hitcounter = 0;
                                break;
                            case 3:
                                if (!hero.inv.Exists(i => i.Name == "nice sandwich"))
                                {
                                    Console.WriteLine("Not a valid option.");
                                    break;
                                }
                                Console.WriteLine("Used nice sandwich");
                                hero.health += hero.itemstat("nice sandwich");
                                    hero.inv.RemoveAll(i => i.Name == "nice sandwich");
                                stun = false;
                                hitcounter = 0;
                                break;
                            case 4:
                                if (!hero.inv.Exists(i => i.Name == "op healing potion"))
                                {
                                    Console.WriteLine("Not a valid option.");
                                    break;
                                }
                                Console.WriteLine("Used op healing potion");
                                hero.health += hero.itemstat("op healing potion");
                                    hero.inv.RemoveAll(i => i.Name == "op healing potion");
                                stun = false;
                                hitcounter = 0;
                                break;
                            case 5:
                                if (!hero.inv.Exists(i => i.Name == "supreme elixir"))
                                {
                                    Console.WriteLine("Not a valid option.");
                                    break;
                                }
                                Console.WriteLine("Used supreme elixir");
                                hero.health += hero.itemstat("supreme elixir");
                                    hero.inv.RemoveAll(i => i.Name == "supreme elixir");
                                stun = false;
                                hitcounter = 0;
                                break;
                            case 0:
                                Console.WriteLine("You did a silly dance.");
                                stun = false;
                                hitcounter = 0;
                                break;
                            default:
                                Console.WriteLine("Not a valid option.");
                                break;
                        }
                    }
                }
                else if (round == 1)
                {
                    Console.Clear();
                    int atk = rnd.Next(1, 3);
                    Console.WriteLine("[1] [2] [3]");
                    Console.WriteLine("ATTACK!");
                    Console.WriteLine($"{name}'s health: {hp}");
                    Console.WriteLine($"Your health: {hero.health}");
                    if (hero.inv.Exists(i => i.Name == "energy coffee")) Console.WriteLine("[5] to use energy coffee!");

                    int choice = ConsoleUtils.ReadInt("Choose: ");
                    if (choice >= 4 || choice == 0)
                    {
                        Console.WriteLine("You will die.");
                        ConsoleUtils.Pause();
                    }
                    else
                    {
                        if (choice == atk)
                        {
                            Console.WriteLine("Hit!");
                            hp -= hero.dmg;
                            hitcounter++;
                            round--;
                            ConsoleUtils.Pause();
                        }
                        else
                        {
                            Console.WriteLine("Miss");
                            round--;
                            ConsoleUtils.Pause();
                        }

                        if (hp <= 0)
                        {
                            Console.WriteLine("You win!");
                            ConsoleUtils.Pause();
                            fight = false;
                        }
                        else if (hero.health <= 0)
                        {
                            Console.WriteLine("WASTED");
                            ConsoleUtils.Pause();
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    int dfnc = rnd.Next(1, 5);
                    Console.WriteLine("[1] [2] [3] [4] [5]");
                    Console.WriteLine("DEFEND");
                    Console.WriteLine($"{name}'s health: {hp}");
                    Console.WriteLine($"Your health: {hero.health}");

                    int choice = ConsoleUtils.ReadInt("Choose: ");
                    if (choice >= 6 || choice == 0)
                    {
                        Console.WriteLine("You will die.");
                        ConsoleUtils.Pause();
                    }
                    else
                    {
                        if (choice != dfnc)
                        {
                            Console.WriteLine("Dodged");
                            round++;
                            ConsoleUtils.Pause();
                        }
                        else
                        {
                            Console.WriteLine("You got hit.");
                            hero.health -= dmg;
                            round++;
                            ConsoleUtils.Pause();
                        }

                        if (hero.health <= 0)
                        {
                            Console.WriteLine("WASTED");
                            ConsoleUtils.Pause();
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}