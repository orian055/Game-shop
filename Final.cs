using System;
using System.Collections.Generic; // Required for List
using System.Threading;           // Required for Thread.Sleep

namespace Game
{
    class Finals
    {
        private static MusicPlayer music = new MusicPlayer();
        public void finals(Hero hero, Random rnd)
        {
            if (hero.health < 100 || hero.dmg < 50)
            {
                Console.WriteLine("The dragon will COOK you fam, go do some quests");
                Thread.Sleep(2500); 
                return;
            }
             
            List<char> path = new List<char> { '<', '<', '^', '<', '>', '^', '<', '>', '^', '^' };
            int pos = path.Count - 1;

            while (true)
            {
                DrawMountain(path, pos);

                if (pos < 0)
                {
                    Console.WriteLine("that was hard");
                    Thread.Sleep(2500);
                    facingdragon(hero, rnd);
                    return; // CRITICAL: Stop the mountain loop once the dragon fight ends
                }

                Console.WriteLine("hint: left is a. up is w, right is d");
                char input = char.ToLower(Console.ReadKey(true).KeyChar);
                char expectedKey = ArrowToKey(path[pos]);

                if (input == expectedKey)
                {
                    pos--;
                }
                else
                {
                    // FIX: Prevent IndexOutOfRangeException if player fails at the bottom
                    if (pos < path.Count - 1)
                    {
                        pos++;
                    }
                    Console.WriteLine("\nWRONG STEP!");
                    Thread.Sleep(500);
                }
            } 
        }

        static char ArrowToKey(char arrow)
        {
            return arrow switch
            {
                '^' => 'w',
                '<' => 'a',
                '>' => 'd',
                _ => '?'
            };
        }

        static void DrawMountain(List<char> path, int playerPos)
        {
            Console.Clear();
            Console.WriteLine("  ___-> Mountains top");
            for (int i = 0; i < path.Count; i++)
            {
                bool isPlayerHere = (i == playerPos);
                string line = $"{path[i]} ]";
                if (isPlayerHere) line += "   <==== you are here";
                Console.WriteLine(line);
            }
        }

        static void facingdragon(Hero hero, Random rnd)
        {
            Console.Clear();
            Console.WriteLine("dragon: rawr");
            Console.WriteLine("you: ...");


            int dragonhp = 500;
            int round = 1; 
            bool fight = true;

            while (fight)
            {
                Console.Clear();
                Console.WriteLine(round == 1 ? "ATTACK!" : "DEFEND");
                Console.WriteLine("[1] [2] [3]");
                Console.WriteLine($"DRAGONS HEALTH: {dragonhp}");
                Console.WriteLine($"your health: {hero.health}");

                string input = Console.ReadLine() ?? "";

                // Check for second phase trigger first
                if (hero.health <= 20)
                {
                    // start boss loop (expects Finale.mp3 in output)
                    try { music.PlayLoop("Finale.mp3"); } catch { }
                    fight = false;
                    secondphase(hero);
                    break; // Exit the loop entirely
                }

                if (round == 1) // Forced Miss Phase
                {
                    Console.WriteLine("miss");
                    round = 0; // Toggle to Defend
                    Console.ReadLine();
                }
                else // Forced Damage Phase
                {
                    Console.WriteLine("you got hit");
                    hero.health -= 20;
                    round = 1; // Toggle to Attack
                    Console.ReadLine();
                }
            }
        }
        
        
        // ... Keep your secondphase(), ending(), etc. exactly as they were!
         static void secondphase(Hero hero)

{

Console.Clear();

Console.WriteLine("dragon: Is that all you got?");

Thread.Sleep(2500);

Console.WriteLine("you: FUCK YOU");

Thread.Sleep(2500);

Console.WriteLine("dragon: you were blessed with drive, the most precious thing a human being can have");

Thread.Sleep(2500);

Console.WriteLine("dragon: you push trough the pain, i respect that about you");

Thread.Sleep(2500);

Console.WriteLine("you: i will kill you!");

Thread.Sleep(2500);

Console.WriteLine("dragon: id love to see you try!");

Console.WriteLine("[1] [2] [3] [4] [5] [6] [7] [8] [9] [10] [11] [12] [13] [14] [15] [16]");

Console.ReadLine();

Console.WriteLine("missed");

Console.WriteLine("[1] [2] [3] [4] [5] [6] [7] [8] [9] [10]");

Console.ReadLine();

Console.WriteLine("missed");

Console.WriteLine("[y] [o] [u] [] [c] [a] [n] [t]");

Console.ReadLine();

Console.WriteLine("missed");

for (int i = 0; i < 30; i++)

{

Console.WriteLine("missed");

Thread.Sleep(50);

}

Console.Clear();

Thread.Sleep(5000);

string cool = "ive had enough";

foreach (char c in cool)

{

Console.Write(c);

Thread.Sleep(150);

}

Thread.Sleep(2500);

Console.WriteLine("\ndragon: foolish of you to keep trying");

Thread.Sleep(2500);

Console.WriteLine("you: i figured it out");

Thread.Sleep(2500);

Console.WriteLine("you: you are predictable");

bool kill = true;

while (kill)

{

Console.WriteLine("[x] [x] [3]");

string input = Console.ReadLine() ?? "";

if (!int.TryParse(input, out int three) || three != 3)

{ Console.WriteLine("what the fuck are you going man");
Thread.Sleep(1000); }


else

{

Console.WriteLine("hit");

Thread.Sleep(2500);

Console.WriteLine("dragon: WHAT");

Thread.Sleep(2500);

for (int i =0; i < 30; i ++)

{

Console.WriteLine("hit");

Thread.Sleep(50);

}
                Thread.Sleep(3000);
Console.WriteLine("\nyou: predictable");
Thread.Sleep(2500);
// play Finale track (expects Finale.mp3 in output)
try { music.PlayOnce("Finale.mp3"); } catch { }
ending(hero);

}

}

}




      static void ending(Hero hero)
    {
             
       Console.Clear();
       Console.WriteLine("dragon: ...");
       Thread.Sleep(2500);
       Console.WriteLine("you: do you regret your choices");
       Thread.Sleep(2500);
       Console.WriteLine("dragon: let me die in peace mortal");
       Thread.Sleep(2500);
       Console.WriteLine("you: fuck you");
       Console.ReadLine();
       if (hero.passes.Exists(p => p.Name == "gfqc"))
            {
                Console.WriteLine("blacksmith: you didnt wait for me");
                Thread.Sleep(2500);
                Console.WriteLine("you: i was too busy fighting the dragon");
                Thread.Sleep(2500);
                Console.WriteLine("blacksmith: its okay... honestly i didnt think you can pull this off");
                Thread.Sleep(2500);
                Console.WriteLine("blacksmith: you are my hero");
                Thread.Sleep(2500);
                Console.WriteLine("you: will you marry me?");
                Thread.Sleep(2500);
                Console.WriteLine("blacksmith: you dont even know my name..");
                Thread.Sleep(2500);
                Console.WriteLine("you: would you marry me gonnie?");
                Thread.Sleep(2500);
                Console.WriteLine("blacksmith: maybe in 10 years when you stop being weird");
                Thread.Sleep(2500);
                Console.WriteLine("you: fair. i will wait for you");
                Thread.Sleep(2500);
                Console.WriteLine("blacksmith: you really will?");
                Thread.Sleep(2500);
                Console.WriteLine("you: wait for me gonnie");
                Thread.Sleep(2500);
                Console.WriteLine("you: just wait for me");
                Console.ReadLine();
            }


       Thread.Sleep(2000);
       Console.Clear();
       Thread.Sleep(1500);

       // Credits Scene
       Console.WriteLine();
       Console.WriteLine("╔════════════════════════════════════════╗");
       Console.WriteLine("║                                        ║");
       Thread.Sleep(300);
       Console.WriteLine("║                  GAME                  ║");
       Thread.Sleep(500);
       Console.WriteLine("║                                        ║");
       Console.WriteLine("╚════════════════════════════════════════╝");
       Thread.Sleep(2000);

       Console.WriteLine();
       Console.WriteLine();
       Console.WriteLine("                  Created by");
       Thread.Sleep(800);
       Console.WriteLine("                    orian");
       Thread.Sleep(2000);

       Console.WriteLine();
       Console.WriteLine();
       Console.WriteLine("════════════════════════════════════════");
       Thread.Sleep(800);
       Console.WriteLine("          ~ Thank You For Playing ~");
       Thread.Sleep(800);
       Console.WriteLine("════════════════════════════════════════");
       Thread.Sleep(2000);

       Console.WriteLine();
       Console.WriteLine();
       string message = "A journey through mountains, battles, and choices...";
       foreach (char c in message)
       {
           Console.Write(c);
           Thread.Sleep(50);
       }
       Thread.Sleep(2000);

       Console.WriteLine();
       Console.WriteLine();
       Console.WriteLine("═══════════════════════════════════════════");
       Thread.Sleep(1000);            
       Console.WriteLine("            Chapter 2 coming soon...");
       Thread.Sleep(1000);
       Console.WriteLine("            Press any key to exit...");
       Console.WriteLine("═══════════════════════════════════════════");
       Console.ReadLine();
       try { music.Stop(); } catch { }
       Environment.Exit(0);
    }


}


    
}
    
