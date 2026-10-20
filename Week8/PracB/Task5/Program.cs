
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

        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Use: dotnet run -- list");
                Console.WriteLine("Or: dotnet run -- linkedlist");
                return;
            }

            if (args[0] == "list")
            {
                List<Player> players = new List<Player>();

                for (int i = 0; i < 10000; i++)
                {
                    players.Add(new Player("Player" + i, 100, 20, 5));
                }

                string path = "./ListPlayers.json";
                FileWriter(path, players);

                List<Player> loadedPlayers =
                    FileReader<List<Player>>(path);

                GC.Collect();

                long heapSize = GC.GetGCMemoryInfo().HeapSizeBytes;
                long peakMemory = Process.GetCurrentProcess().PeakWorkingSet64;

                Console.WriteLine($"List Count: {loadedPlayers.Count}");
                Console.WriteLine($"HeapSizeBytes: {heapSize} bytes");
                Console.WriteLine($"PeakWorkingSet64: {peakMemory} bytes");

                GC.KeepAlive(loadedPlayers);
            }
            else if (args[0] == "linkedlist")
            {
                LinkedList<Player> players = new LinkedList<Player>();

                for (int i = 0; i < 10000; i++)
                {
                    players.AddLast(new Player("Player" + i, 100, 20, 5));
                }

                string path = "./LinkedListPlayers.json";
                FileWriter(path, players);

                LinkedList<Player> loadedPlayers =
                    FileReader<LinkedList<Player>>(path);

                GC.Collect();

                long heapSize = GC.GetGCMemoryInfo().HeapSizeBytes;
                long peakMemory = Process.GetCurrentProcess().PeakWorkingSet64;

                Console.WriteLine($"LinkedList Count: {loadedPlayers.Count}");
                Console.WriteLine($"HeapSizeBytes: {heapSize} bytes");
                Console.WriteLine($"PeakWorkingSet64: {peakMemory} bytes");

                GC.KeepAlive(loadedPlayers);
            }
        }
    }
}
