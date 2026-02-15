using System;

namespace Game
{
    public class Item
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public int HealValue { get; set; }
        public string Description { get; set; }

        public Item(string name, ItemType type, int healValue = 0, string description = "")
        {
            Name = name;
            Type = type;
            HealValue = healValue;
            Description = description;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Item other)
                return Name.Equals(other.Name);
            if (obj is string str)
                return Name.Equals(str);
            return false;
        }

        public override int GetHashCode() => Name.GetHashCode();

        public override string ToString() => Name;
    }

    public enum ItemType
    {
        Consumable,    // Healing items, food, potions
        Quest,         // Quest-related items (za, papers, iron, sauce)
        Miscellaneous  // Other items
    }
}
