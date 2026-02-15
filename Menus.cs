using System;

namespace Game
{
    class Menus
    {
        public void RunMainMenu(bool hasSave)
        {
            
Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║        WHAT'S A NAME?        ║");
Console.WriteLine("╠══════════════════════════════╣");
Console.WriteLine("║             GAME             ║");
Console.WriteLine("║           by Orian           ║");
Console.WriteLine("╠══════════════════════════════╣");
Console.WriteLine("║                              ║");
Console.WriteLine("║   [1] START (New Save)       ║");
if (hasSave)
Console.WriteLine("║   [2] CONTINUE               ║");
else
Console.WriteLine("║   [2] CONTINUE (No Save)     ║");
Console.WriteLine("║   [3] SAVE                   ║");
Console.WriteLine("║   [4] TUTORIAL               ║");
Console.WriteLine("║   [5] EXIT                   ║");
Console.WriteLine("║                              ║");
Console.WriteLine("╚══════════════════════════════╝");

           
        }
    }
}

