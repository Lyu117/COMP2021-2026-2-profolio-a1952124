using System;
using System.Collections;
using System.Linq;
namespace HashTablePrac
{
    class HashTable
    {
        public static void Main(string[]args)
        {
            
            Hashtable scoreHash=new Hashtable();

            Player p1 = new Player("Tom");
            Player p2 = new Player("Jack");
            Player p3 = new Player("Lucy");
            Player p4 = new Player("Lucia");
            Player p5 = new Player("Anna");


            scoreHash.Add(p1,80);
            scoreHash.Add(p2,90);
            scoreHash.Add(p3,95);
            scoreHash.Add(p4,75);
            scoreHash.Add(p5,55);
            scoreHash.Add("Test", 100);

            try
            {
                scoreHash.Add(p1, 100);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Duplicate key is not allowed.");
            }


        var sortedScores = scoreHash.Cast<DictionaryEntry>()
            .Where(entry => entry.Key is Player)
            .OrderByDescending(entry => (int?)entry.Value);

            foreach (DictionaryEntry entry in sortedScores)
            {
             Player player = (Player)entry.Key;
             int score = (int)entry.Value!;

             Console.WriteLine($"{player.Name}: {score}");
            }

        } 

    }
}