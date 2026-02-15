using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 


namespace Game
{
    public class Hero
    {
        public List<Pass> passes { get; set; } = new List<Pass>();
        public List<Item> inv { get; set; } = new List<Item>();
        
        public int Money { get; set; } = 0;
        public int maxhp { get; set;} = 10;
        private int hp = 10;
        public int health
         { 
            get => hp;
            set => hp = Math.Min(value, maxhp);
         }

         //training stats!
           public int pushups { get; set; } = 0;
           public int stamina { get; set; } = 10;
           public int motivation { get; set; } = 10;
           
        public int dmg { get; set;} = 5;
        
        public int itemstat(string itemName)
        {
            if (itemName == "energy coffee") return 5;
            if (itemName == "bandage") return 2;
            if (itemName == "nice sandwich") return 5;
            if (itemName == "op healing potion") return 20;
            if (itemName == "supreme elixir") return 50;
            if (itemName == "pizza") return 15;
            return 0;
        }

        // Helper methods for backward compatibility
        public bool HasItem(string itemName)
        {
            return inv.Exists(i => i.Name == itemName);
        }

        public bool HasPass(string passName)
        {
            return passes.Exists(p => p.Name == passName);
        }

        public void AddItem(string itemName)
        {
            inv.Add(new Item(itemName, ItemType.Consumable, itemstat(itemName)));
        }

        public void AddPass(string passName)
        {
            if (!HasPass(passName))
                passes.Add(new Pass(passName));
        }

        public void RemoveItem(string itemName)
        {
            inv.RemoveAll(i => i.Name == itemName);
        }

    }
    
}
