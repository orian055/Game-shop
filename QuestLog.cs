using System;
using System.Collections.Generic;

namespace Game
{
    public class QuestLog
    {
        private List<Quest> quests = new List<Quest>
        {
            new Quest("Wizard Quest (wizq)", "Talk to Wizard in Village", "Get Za from the Dark Alley and deliver it to the Wizard"),
            new Quest("Hero Quest (hq)", "Talk to Hero in Village", "Prove yourself worthy by completing challenges"),
            new Quest("Baker Quest (bakeq)", "Talk to Baker in Village", "Enjoy pizza and beers with the village baker"),
            new Quest("Blacksmith Quest (gfq)", "Talk to Blacksmith in Village", "Get Iron from the Mine for the blacksmith"),
            new Quest("Priest Quest (pq)", "Talk to Priest in Village", "Defeat the Russian Guard and get papers"),
            new Quest("Warrior Path (pushups)", "Train in Town", "Do 100 pushups to unlock the warrior path"),
            new Quest("Final Challenge", "Get nuclear submarine + high stats", "Health >= 100 AND Damage >= 50, then find the Final Challenge")
        };

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║          QUEST LOG & OBJECTIVES       ║");
            Console.WriteLine("╚═══════════════════════════════════════╝");
            Console.WriteLine();

            foreach (var quest in quests)
            {
                Console.WriteLine($"📜 {quest.Name}");
                Console.WriteLine($"   Goal: {quest.Goal}");
                Console.WriteLine($"   Details: {quest.Details}");
                Console.WriteLine();
            }

            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("Progress tracking added to the ModMenu admin panel!");
            ConsoleUtils.Pause();
        }

        public void DisplayCompact(Hero hero)
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║              QUEST STATUS             ║");
            Console.WriteLine("╚═══════════════════════════════════════╝");
            Console.WriteLine();

            var questFlags = new Dictionary<string, string>
            {
                { "wizqc", "✓ Wizard Quest - COMPLETED" },
                { "hqc", "✓ Hero Quest - COMPLETED" },
                { "bakeqc", "✓ Baker Quest - COMPLETED" },
                { "gfqc", "✓ Blacksmith Quest - COMPLETED" },
                { "pqc", "✓ Priest Quest - COMPLETED" },
                { "pushups", "✓ Warrior Path - UNLOCKED" },
            };

            int completedCount = 0;
            foreach (var pair in questFlags)
            {
                if (hero.passes.Exists(p => p.Name == pair.Key))
                {
                    Console.WriteLine(pair.Value);
                    completedCount++;
                }
            }

            if (completedCount == 0)
            {
                Console.WriteLine("No quests completed yet. Talk to NPCs to start!");
            }

            Console.WriteLine();
            Console.WriteLine($"Quests Completed: {completedCount}/6");
            Console.WriteLine();

            if (hero.health >= 100 && hero.dmg >= 50)
            {
                Console.WriteLine("🐉 FINAL CHALLENGE UNLOCKED! (Option [5] in main menu)");
            }
            else
            {
                Console.WriteLine($"Final Challenge Status:");
                Console.WriteLine($"  Health: {hero.health}/100 needed");
                Console.WriteLine($"  Damage: {hero.dmg}/50 needed");
            }

            Console.WriteLine();
            Console.WriteLine("═══════════════════════════════════════");
            ConsoleUtils.Pause();
        }
    }

    public class Quest
    {
        public string Name { get; set; }
        public string Goal { get; set; }
        public string Details { get; set; }

        public Quest(string name, string goal, string details)
        {
            Name = name;
            Goal = goal;
            Details = details;
        }
    }
}
