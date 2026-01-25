using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Game
{
   class Inventory
    {
        public void runInv(Hero hero)
        {
            Console.Clear();

            Console.WriteLine("=== Inventory ===");
            if (hero.inv.Count == 0)
            {
                Console.WriteLine("you dont have shit man.");
                Thread.Sleep(3000);
                return;
            }
            else
            {
               foreach (var item in hero.inv)
                {
                    Console.WriteLine(item);
                }
            }
            
       
            Console.ReadLine();
        }
    } 
}