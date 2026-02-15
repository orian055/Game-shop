using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace Game
{
    class Inventory
    {
        public void runInv(Hero hero)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════════╗");
                Console.WriteLine("║           YOUR INVENTORY              ║");
                Console.WriteLine("╚═══════════════════════════════════════╝");

                if (hero?.inv == null || hero.inv.Count == 0)
                {
                    Console.WriteLine("Your inventory is empty.");
                    Thread.Sleep(1500);
                    return;
                }

                // Group items by name and count for better display
                var groupedItems = hero.inv
                    .GroupBy(item => item.Name)
                    .OrderBy(group => group.Key)
                    .ToList();

                Console.WriteLine("Items you carry:");
                foreach (var group in groupedItems)
                {
                    int count = group.Count();
                    int itemValue = hero.itemstat(group.Key);
                    
                    if (itemValue > 0)
                    {
                        Console.WriteLine($"  • {group.Key,-25} x{count,-3} (heal: {itemValue})");
                    }
                    else
                    {
                        Console.WriteLine($"  • {group.Key,-25} x{count,-3}");
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Total items: {hero.inv.Count} ({groupedItems.Count} unique types)");
                Console.WriteLine();

                // consumables with heal values in desired order
                var consumables = new List<KeyValuePair<string, int>>
                {
                    new KeyValuePair<string,int>("bandage", 2),
                    new KeyValuePair<string,int>("nice sandwich", 5),
                    new KeyValuePair<string,int>("op healing potion", 20),
                    new KeyValuePair<string,int>("pizza", 15),
                };

                var options = new Dictionary<int, KeyValuePair<string,int>>();
                int opt = 1;
                foreach (var kv in consumables)
                {
                    if (hero.inv.Exists(i => i.Name == kv.Key))
                    {
                        options[opt] = kv;
                        Console.WriteLine($"[{opt}] use {kv.Key}");
                        opt++;
                    }
                }

                Console.WriteLine("[0] exit");

                if (options.Count == 0)
                {
                    Console.WriteLine("No consumable items available. Press Enter to continue...");
                    ConsoleUtils.Pause();
                    return;
                }

                string input = Console.ReadLine() ?? "";
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Please enter a number.");
                    Thread.Sleep(1000);
                    continue;
                }

                if (choice == 0) return;

                if (!options.TryGetValue(choice, out var selected))
                {
                    Console.WriteLine("Not a valid option.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.WriteLine($"Used {selected.Key}.");
                hero.health += selected.Value;
                hero.inv.RemoveAll(i => i.Name == selected.Key);
                Thread.Sleep(1000);
            }
        }
    }
}
