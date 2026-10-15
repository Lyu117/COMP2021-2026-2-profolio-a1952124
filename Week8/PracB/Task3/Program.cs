using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace program
{
    class program1
    {
        public static void Main()
    {
        
        List<Player> players = new List<Player>();
        players.Add(new Player("Tom", 100, 20, 5));
        players.Add(new Player("Jack", 90, 25, 8));
        players.Add(new Player("Lucy", 80, 30, 10));
        players.Add(new Player("Lucia", 70, 35, 12));
        players.Add(new Player("John", 60, 40, 15));

        string jsonString = JsonSerializer.Serialize(players); //convert to Json

        Console.WriteLine(jsonString);

        string path = "./Players.json";//write JSON string in to file
        File.WriteAllText(path, jsonString);

        string loadedJson = File.ReadAllText(path);

        List<Player> loadedPlayers =
            JsonSerializer.Deserialize<List<Player>>(loadedJson)!;//Convert from JSON back to List


        foreach (Player player in loadedPlayers)
        {
            Console.WriteLine(player);
        }
    }
    }
    
}