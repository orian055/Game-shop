using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 

namespace Game
{
    public class Hero
    {
        
        public List<string> passes { get; set; } = new List<string>();
        public List<string> inv { get; set; } = new List<string>();
        public List<string> moves { get; set;} = new List<string>();
        public int Money { get; set; } = 0;
        public int health { get; set; } = 10;

        

    }
}
