using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Game
{
    class Shop
    {
        public List<ShopItem> ShopItems { get; private set; }
        public Dictionary<int, (int Price, int Quantity)> Cart = new Dictionary<int, (int, int)>();
    
        private Random rnd;
    
        public Shop(Random random)
        {
            rnd = random;
    
            ShopItems = new List<ShopItem>()
            {
                new ShopItem(25, "energy coffee", rnd, 1, "hot and refreshing. heals 5 health points."),
                new ShopItem(25, "bandage", rnd, 2, "works. heals 2 health points"),
                new ShopItem(50, "nice sandwich", rnd, 3, "my mom made it, its nice. heals 5 health points"),
                new ShopItem(100, "op healing potion", rnd, 4, "can cure cancer. heals 20 health points"),
                new ShopItem(150, "supreme elixir", rnd, 5, "legendary potion. heals 50 health points."),
                new ShopItem(5000, "nuclear submarine", rnd, 6, "dont let the goverment catch you"),
                
    
            };
        }
    
        public void RunShop(Hero hero)
        {
            Console.Clear();
            
            if (hero.passes.Exists(p => p.Name == "shop"))
            Console.WriteLine("Store Owner: welcome back!");

            else  
            {
                Console.WriteLine("You are traveling in the forest");
                Thread.Sleep(3000);
                Console.WriteLine("suddenly you come across a strange store");
                Thread.Sleep(3000);
                Console.WriteLine("Will you go inside? [1] Yes | [2] No");
                int start = ConsoleUtils.ReadInt("Choose: ");
                if (start == 1)
                {
                    Console.WriteLine("Great!");
                    Thread.Sleep(1000);
                }
                else if (start == 2)
                {
                    Console.WriteLine("The owner brings you to the store.");
                    Thread.Sleep(1500);
                }
                else
                {
                    Console.WriteLine("You sense you should go inside.");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("You find yourself in the store—it's cozy and inviting.");
                Thread.Sleep(1500);
                Console.WriteLine("Store Owner: HELLO!");
                Thread.Sleep(3000);
                Console.WriteLine("Store Owner: Welcome to my store!");
                Thread.Sleep(3000);
                Console.WriteLine("Store Owner: Here you can buy all sorts of things!");
                Thread.Sleep(3000);
                Console.WriteLine("you: what do you sell here?");
                Thread.Sleep(3000);
                Console.WriteLine("Store Owner: are you a cop?");
                Thread.Sleep(3000);
                Console.WriteLine("you: what? no im not a cop");
                Thread.Sleep(3000);
                Console.WriteLine("Store Owner: ARE YOU SURE?");
                Thread.Sleep(3000);
                Console.WriteLine("you: im NOT a cop man");
                Thread.Sleep(3000);
                Console.WriteLine("Store Owner: then come take a look");
                Thread.Sleep(3000);
                hero.passes.Add(new Pass("shop"));
            }
            bool shopping = true;
            while (shopping)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║           WELCOME TO THE STORE         ║");
                Console.WriteLine("║      Where Dreams Come With a Price    ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine($"💰 Money: ${hero.Money}  │  ❤️  Health: {hero.health}/{hero.maxhp}");
                Console.WriteLine();
                
                foreach (ShopItem item in ShopItems)
                {
                    Console.WriteLine($"[{item.id}] {item.sname,-20} ${item.price,5} | {item.info,-45} | {item.stock} left");
                }

                int cartTotal = 0;
                if (Cart.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("📦 Items in Cart:");
                    foreach (var entry in Cart)
                    {
                        int id = entry.Key;
                        int qty = entry.Value.Quantity;
                        int price = entry.Value.Price;
                        int sum = price * qty;
                        cartTotal += sum;

                        ShopItem item = ShopItems.First(i => i.id == id);
                        Console.WriteLine($"   • {item.sname} x{qty} = ${sum}");
                    }
                    Console.WriteLine($"   Total: ${cartTotal}");
                }

                Console.WriteLine();
                Console.WriteLine("Store Owner: What catches your eye? [Item#] or [0] to Review Cart");
                string input = Console.ReadLine() ?? "";

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Store Owner: Use numbers, friend.");
                    Thread.Sleep(1500);
                    continue;
                }

                if (choice == 0)
                {
                    shopping = false;
                    break;
                }

                ShopItem selected = ShopItems.FirstOrDefault(i => i.id == choice);
                if (selected == null)
                {
                    Console.WriteLine("Store Owner: Don't see that item, try again.");
                    Thread.Sleep(1500);
                    continue;
                }

                if (selected.stock <= 0)
                {
                    Console.WriteLine("Store Owner: Ah, sold out of that one. Try something else.");
                    Thread.Sleep(1500);
                    continue;
                }

                if (Cart.ContainsKey(selected.id))
                {
                    Cart[selected.id] = (selected.price, Cart[selected.id].Quantity + 1);
                }
                else
                {
                    Cart.Add(selected.id, (selected.price, 1));
                }

                selected.stock--;

                Console.WriteLine($"Store Owner: Excellent choice! {selected.sname} added to your cart.");
                Thread.Sleep(1500);
            }

            // Review cart and checkout
            if (Cart.Count == 0)
            {
                Console.WriteLine("Store Owner: You didn't buy anything? Come back when you're ready.");
                Thread.Sleep(2000);
                return;
            }

            bool reviewing = true;
            while (reviewing)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║            YOUR CART                   ║");
                Console.WriteLine("║        Ready to Proceed?               ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine($"💰 Your Gold: ${hero.Money}");
                Console.WriteLine();

                int total = 0;
                foreach (var entry in Cart)
                {
                    int id = entry.Key;
                    int price = entry.Value.Price;
                    int qty = entry.Value.Quantity;
                    int sum = price * qty;
                    total += sum;
                    ShopItem item = ShopItems.First(i => i.id == id);
                    Console.WriteLine($"  • {item.sname} x{qty,-2} = ${sum}");
                }

                Console.WriteLine();
                Console.WriteLine($"Total Cost: ${total}");
                
                if (hero.Money < total)
                {
                    Console.WriteLine($"⚠️  You're a bit short... (need ${total - hero.Money} more)");
                }

                Console.WriteLine();
                Console.WriteLine("[1] Continue Shopping    [2] Modify Cart    [3] Complete Purchase");
                int action = ConsoleUtils.ReadInt("What would you like to do? ");

                switch (action)
                {
                    case 1:
                        reviewing = false;
                        shopping = true;
                        break;
                    case 2:
                        ModifyCart();
                        break;
                    case 3:
                        if (hero.Money >= total)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Store Owner: Perfect! Let's complete this transaction.");
                            Thread.Sleep(1500);
                            hero.Money -= total;
                            Console.WriteLine($"Store Owner: That's ${total}. You now have ${hero.Money} remaining.");
                            Thread.Sleep(1500);

                            foreach (var entry in Cart)
                            {
                                int id = entry.Key;
                                int qty = entry.Value.Quantity;

                                ShopItem item = ShopItems.First(i => i.id == id);

                                for (int i = 0; i < qty; i++)
                                {
                                    hero.inv.Add(new Item(item.sname, ItemType.Consumable, hero.itemstat(item.sname)));
                                }
                            }

                            Console.WriteLine("Store Owner: Much obliged! Come again soon.");
                            Thread.Sleep(2000);
                            Cart.Clear();
                            reviewing = false;
                            shopping = false;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Store Owner: You're short by ${total - hero.Money}. Would you like to remove some items?");
                            Thread.Sleep(2000);
                        }
                        break;
                    default:
                        Console.WriteLine("Store Owner: I didn't catch that...");
                        Thread.Sleep(1000);
                        break;
                }
            }

            void ModifyCart()
            {
                bool modifying = true;
                while (modifying)
                {
                    Console.Clear();
                    Console.WriteLine("╔════════════════════════════════════════╗");
                    Console.WriteLine("║        MODIFY YOUR CART                ║");
                    Console.WriteLine("╚════════════════════════════════════════╝");
                    Console.WriteLine();

                    if (Cart.Count == 0)
                    {
                        Console.WriteLine("Your cart is empty.");
                        Thread.Sleep(1500);
                        modifying = false;
                        break;
                    }

                    int totalPrice = 0;
                    foreach (var entry in Cart)
                    {
                        int id = entry.Key;
                        int price = entry.Value.Price;
                        int qty = entry.Value.Quantity;
                        int sum = price * qty;
                        totalPrice += sum;
                        ShopItem item = ShopItems.First(i => i.id == id);
                        Console.WriteLine($"[{id}] {item.sname} x{qty,-2} = ${sum}");
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Total: ${totalPrice}");
                    Console.WriteLine();
                    Console.WriteLine("Enter item number to remove, or [0] to go back:");
                    string input = Console.ReadLine() ?? "";

                    if (!int.TryParse(input, out int removeId))
                    {
                        Console.WriteLine("Store Owner: Use numbers, friend.");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (removeId == 0)
                    {
                        modifying = false;
                        break;
                    }

                    if (!Cart.ContainsKey(removeId))
                    {
                        Console.WriteLine("Store Owner: That item isn't in your cart.");
                        Thread.Sleep(1000);
                        continue;
                    }

                    Cart[removeId] = (Cart[removeId].Price, Cart[removeId].Quantity - 1);
                    if (Cart[removeId].Quantity <= 0)
                    {
                        Cart.Remove(removeId);
                        ShopItem removedItem = ShopItems.First(i => i.id == removeId);
                        Console.WriteLine($"Store Owner: Removed {removedItem.sname} from your cart.");
                    }
                    else
                    {
                        Console.WriteLine($"Store Owner: Quantity reduced.");
                    }

                    Thread.Sleep(1500);
                }
            }
        }
    }
}
