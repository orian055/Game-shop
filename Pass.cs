using System;

namespace Game
{
    public class Pass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Acquired { get; set; }

        public Pass(string name, string description = "")
        {
            Name = name;
            Description = description;
            Acquired = false;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Pass other)
                return Name.Equals(other.Name);
            if (obj is string str)
                return Name.Equals(str);
            return false;
        }

        public override int GetHashCode() => Name.GetHashCode();

        public override string ToString() => Name;
    }
}
