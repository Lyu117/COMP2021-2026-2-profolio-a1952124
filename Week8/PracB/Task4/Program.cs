using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Diagnostics;

namespace program
{
    class program1
    {
        public static void FileWriter<T>(string path, T objectToWrite) where T : class
        {
            string jsonString = JsonSerializer.Serialize(objectToWrite);
            File.WriteAllText(path, jsonString);
        }

        public static T FileReader<T>(string path) where T : class
        {
            string jsonString = File.ReadAllText(path);
            T loadedObject = JsonSerializer.Deserialize<T>(jsonString)!;
            return loadedObject;
        }

        public static void Main()
        {
            LinkedList<Player> players = new LinkedList<Player>();

            players.AddLast(new Player("Tom", 100, 20, 5));
            players.AddLast(new Player("Jack", 90, 25, 8));
            players.AddLast(new Player("Lucy", 80, 30, 10));
            players.AddLast(new Player("Lucia", 70, 35, 12));
            players.AddLast(new Player("John", 60, 40, 15));

            string path = "./Players.json";

            FileWriter(path, players);

            LinkedList<Player> loadedPlayers =
                FileReader<LinkedList<Player>>(path);

            foreach (Player player in loadedPlayers)
            {
                Console.WriteLine(player);
            }

            GC.Collect();

            long heapSize = GC.GetGCMemoryInfo().HeapSizeBytes;
            long peakMemory = Process.GetCurrentProcess().PeakWorkingSet64;

            Console.WriteLine($"HeapSizeBytes: {heapSize} bytes");
            Console.WriteLine($"PeakWorkingSet64: {peakMemory} bytes");
        }
    }
}