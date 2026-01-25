using System;
using System.Text.Json;
using System.IO;

namespace Game
{
    public class Save
{
    public void SaveGame(Hero hero,string filename = "save.json")
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(hero, options);
        File.WriteAllText(filename, jsonString);
        Console.WriteLine("Game Saved!");
        Thread.Sleep(2500);
    }

    public static Hero LoadGame(string filename = "save.json")
    {
        if (!File.Exists(filename)) return new Hero();
        string jsonString = File.ReadAllText(filename);
        return JsonSerializer.Deserialize<Hero>(jsonString) ?? new Hero();
    }

    public static bool SaveExists(string filename = "save.json")
        {
            return File.Exists(filename);
        }
}

    
}
  