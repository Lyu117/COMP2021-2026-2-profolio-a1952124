using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace program
{
    class program1
    {

    
    // Convert an object to JSON and save it to a file
    public static void FileWriter<T>(string path, T objectToWrite) where T : class
    {
        string jsonString = JsonSerializer.Serialize(objectToWrite);
        File.WriteAllText(path, jsonString);
    }

    
    // convert JSON from it back to an object
    public static T FileReader<T>(string path) where T : class
    {
        string jsonString = File.ReadAllText(path);
        T loadedObject = JsonSerializer.Deserialize<T>(jsonString)!;
        return loadedObject;
    }

        public static void Main()
    {
        
        List<Player> players = new List<Player>();
        players.Add(new Player("Tom", 100, 20, 5));
        players.Add(new Player("Jack", 90, 25, 8));
        players.Add(new Player("Lucy", 80, 30, 10));
        players.Add(new Player("Lucia", 70, 35, 12));
        players.Add(new Player("John", 60, 40, 15));

        string path = "./Players.json";
        FileWriter(path, players);
        
        // Read the player list from the file 
        List<Player> loadedPlayers = FileReader<List<Player>>(path);


        foreach (Player player in loadedPlayers)
        {
            Console.WriteLine(player);
        }
    }
    }
    
}