using System;

namespace Game
{
    class Mountains
    {
        public void runMountains(Village vill, Warriorspath war, Random rnd, Hero hero, Battle bat, Finals final)
        {
            bool mountains = true;
            while (mountains)
            {
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════════════╗");
            Console.WriteLine("║         MOUNTAINS - WHERE LEGENDS       ║");
            Console.WriteLine("║             COME TO FIGHT               ║");
            Console.WriteLine("╚═════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("[1] Village         - Seek guidance from NPCs");
            Console.WriteLine("[2] Warrior's Path  - Prove your combat skill");
            Console.WriteLine("[3] Mountain Top    - Face the final challenge");
            Console.WriteLine();
            Console.WriteLine("[4] Turn back");

            int choice = ConsoleUtils.ReadInt("What calls to you? ");
            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("You spot a small village nestled in the mountains...");
                    Console.WriteLine("Smoke rises from chimneys, and you hear distant voices.");
                    Thread.Sleep(1500);
                    vill.runVillage(hero);
                    break;
                

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("You approach a narrow stone path lined with ancient runes...");
                    Console.WriteLine("The air crackles with power. A voice echoes: 'Welcome, warrior.'");
                    Thread.Sleep(1500);
                    war.runWarrior(rnd, hero, bat);
                    break;
                    
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("You climb higher and higher through the clouds...");
                    Console.WriteLine("At the peak, a shadow moves. Your destiny awaits.");
                    Thread.Sleep(1500);
                    final.finals(hero, rnd);
                    break;

                case 4:
                    Console.WriteLine("You carefully descend back down the mountain...");
                    Thread.Sleep(1000);
                    mountains = false;
                    break;

                default:
                    Console.WriteLine("The mountain wind howls, as if mocking your indecision.");
                    Thread.Sleep(1000);
                    break;                 
            }

            }
        }

        
        
    }
}