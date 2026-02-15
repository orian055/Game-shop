using System;
using System.Collections.Generic;

namespace Game
{
    public class ModMenu
    {
        public void Run(Hero hero)
        {
            Console.Clear();
            Console.WriteLine("=== Mod Menu ===");
            Console.WriteLine("Enter admin password:");
            string password = ConsoleUtils.ReadString("");

            if (password != "yasmin")
            {
                Console.WriteLine("Access denied.");
                ConsoleUtils.Pause();
                return;
            }

            Console.WriteLine("Admin access granted!");
            ConsoleUtils.Pause();

            bool inMenu = true;
            while (inMenu)
            {
                Console.Clear();
                Console.WriteLine("=== Admin Panel ===");
                Console.WriteLine("[1] Add items to inventory");
                Console.WriteLine("[2] Give game flags/passes");
                Console.WriteLine("[3] Modify stats");
                Console.WriteLine("[4] Save");
                Console.WriteLine("[5] Exit");

                int choice = ConsoleUtils.ReadInt("Choose: ");

                switch (choice)
                {
                    case 1:
                        AddItems(hero);
                        break;
                    case 2:
                        GiveFlags(hero);
                        break;
                    case 3:
                        ModifyStats(hero);
                        break;

                    case 4:
                        Save save = new Save();
                        save.SaveGame(hero);
                        Console.WriteLine("Game saved.");
                        ConsoleUtils.Pause();
                        break; 

                    case 5:
                        inMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        Thread.Sleep(800);
                        break;
                }
            }
        }

        private void AddItems(Hero hero)
        {
            Console.Clear();
            Console.WriteLine("=== Add Items ===");
            Console.WriteLine("[1] Bandage");
            Console.WriteLine("[2] Nice sandwich");
            Console.WriteLine("[3] Op healing potion");
            Console.WriteLine("[4] Pizza");
            Console.WriteLine("[5] Energy coffee");
            Console.WriteLine("[6] Supreme elixir");
            Console.WriteLine("[7] Nuclear submarine");
            Console.WriteLine("[8] Za");
            Console.WriteLine("[9] Sauce");
            Console.WriteLine("[10] Iron");
            Console.WriteLine("[11] Beers");
            Console.WriteLine("[12] Papers");
            Console.WriteLine("[13] Go back");

            int choice = ConsoleUtils.ReadInt("Choose: ");

            var items = new Dictionary<int, string>
            {
                { 1, "bandage" },
                { 2, "nice sandwich" },
                { 3, "op healing potion" },
                { 4, "pizza" },
                { 5, "energy coffee" },
                { 6, "supreme elixir" },
                { 7, "nuclear submarine" },
                { 8, "za" },
                { 9, "sauce" },
                { 10, "iron" },
                { 11, "beers" },
                { 12, "papers" }
            };

            if (choice >= 1 && choice <= 12)
            {
                hero.inv.Add(new Item(items[choice], ItemType.Consumable, hero.itemstat(items[choice])));
                Console.WriteLine($"Added {items[choice]}.");
                ConsoleUtils.Pause();
            }
        }

        private void GiveFlags(Hero hero)
        {
            Console.Clear();
            Console.WriteLine("=== Give Flags/Passes ===");
            Console.WriteLine("[1] tutpassed");
            Console.WriteLine("[2] pushups");
            Console.WriteLine("[3] wizard quest (wizq)");
            Console.WriteLine("[4] hero quest (hq)");
            Console.WriteLine("[5] baker quest (bakeq)");
            Console.WriteLine("[6] blacksmith quest (gfq)");
            Console.WriteLine("[7] priest quest (pq)");
            Console.WriteLine("[8] Go back");

            int choice = ConsoleUtils.ReadInt("Choose: ");

            var flags = new Dictionary<int, string>
            {
                { 1, "tutpassed" },
                { 2, "pushups" },
                { 3, "wizq" },
                { 4, "hq" },
                { 5, "bakeq" },
                { 6, "gfq" },
                { 7, "pq" }
            };

            if (choice >= 1 && choice <= 7)
            {
                if (!hero.passes.Exists(p => p.Name == flags[choice]))
                {
                    hero.passes.Add(new Pass(flags[choice]));
                    Console.WriteLine($"Added flag: {flags[choice]}");
                }
                else
                {
                    Console.WriteLine($"Flag already exists: {flags[choice]}");
                }
                ConsoleUtils.Pause();
            }
        }

        private void ModifyStats(Hero hero)
        {
            Console.Clear();
            Console.WriteLine("=== Modify Stats ===");
            Console.WriteLine("[1] Add money");
            Console.WriteLine("[2] Set health (max)");
            Console.WriteLine("[3] Increase health (current)");
            Console.WriteLine("[4] Add damage");
            Console.WriteLine("[5] Go back");

            int choice = ConsoleUtils.ReadInt("Choose: ");

            switch (choice)
            {
                case 1:
                    int money = ConsoleUtils.ReadInt("Amount: ");
                    hero.Money += money;
                    Console.WriteLine($"Added {money:C0}.");
                    ConsoleUtils.Pause();
                    break;
                case 2:
                    int hp = ConsoleUtils.ReadInt("Health amount: ");
                    hero.health = hp;
                    hero.maxhp = hp;
                    Console.WriteLine($"Set health to {hp}.");
                    ConsoleUtils.Pause();
                    break;
                case 3:
                    int heal = ConsoleUtils.ReadInt("Health amount: ");
                    hero.health += heal;
                    if (hero.health > hero.maxhp)
                    {
                        hero.health = hero.maxhp;
                    }
                    Console.WriteLine($"Added {heal} health. Current: {hero.health}/{hero.maxhp}");
                    ConsoleUtils.Pause();
                    break;
                case 4:
                    int dmg = ConsoleUtils.ReadInt("Damage: ");
                    hero.dmg += dmg;
                    Console.WriteLine($"Added {dmg} damage.");
                    ConsoleUtils.Pause();
                    break;
                default:
                    break;
            }
        }
    }
}
