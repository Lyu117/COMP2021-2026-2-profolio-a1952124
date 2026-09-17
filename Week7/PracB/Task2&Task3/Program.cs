namespace SortedDictionaryPrac2
{
    class Program
    {
        public static void Main()
        {
         
            Player p1 = new Player("Tom");
            Player p2 = new Player("Bob");
            Player p3 = new Player("Brian");
            Player p4 = new Player("Max");
            Player p5 = new Player("Han");
            Player p6 = new Player("Jack");
            Player p7 = new Player("Jacky");
            Player p8 = new Player("Lucy");
            Player p9 = new Player("Lucia");
            Player p10 = new Player("Kris");


            
            ScoreEntry s1 = new ScoreEntry(90, 5);
            ScoreEntry s2 = new ScoreEntry(20, 2);
            ScoreEntry s3 = new ScoreEntry(25, 3);
            ScoreEntry s4 = new ScoreEntry(85, 5);
            ScoreEntry s5 = new ScoreEntry(15, 1);
            ScoreEntry s6 = new ScoreEntry(100, 8);
            ScoreEntry s7 = new ScoreEntry(99, 7);
            ScoreEntry s8 = new ScoreEntry(35, 3);
            ScoreEntry s9 = new ScoreEntry(55, 4);
            ScoreEntry s10 = new ScoreEntry(88, 6);


            


            ScoreComparer comparer = new ScoreComparer();

            var SortedScores2 = new SortedDictionary<ScoreEntry, Player>(comparer);


            SortedScores2.Add(s1, p1);
            SortedScores2.Add(s2, p2);
            SortedScores2.Add(s3, p3);
            SortedScores2.Add(s4, p4);
            SortedScores2.Add(s5, p5);
            SortedScores2.Add(s6, p6);
            SortedScores2.Add(s7, p7);
            SortedScores2.Add(s8, p8);
            SortedScores2.Add(s9, p9);
            SortedScores2.Add(s10, p10);



            Console.WriteLine("The top three scores are:");

            foreach (var pair in SortedScores2.Reverse().Take(3))
            {
                Console.WriteLine(
                    $"{pair.Value.Name}: Score={pair.Key.Score}, Stage={pair.Key.StageReached}"
                );
            }



            Console.WriteLine("\nThe bottom three scores are:");

            foreach (var pair in SortedScores2.Take(3))
            {
                Console.WriteLine(
                    $"{pair.Value.Name}: Score={pair.Key.Score}, Stage={pair.Key.StageReached}"
                );
            }


            Console.WriteLine("\nLucia has left the game.");

            ScoreEntry? playerToRemove = null;

            foreach (var pair in SortedScores2)
            {
                if (pair.Value.Name == "Lucia")
                {
                    playerToRemove = pair.Key;
                    break;
                }
            }

            if (playerToRemove != null)
            {
                SortedScores2.Remove(playerToRemove);
            }


            Console.WriteLine("\nRemaining players:");

            foreach (var pair in SortedScores2)
            {
                Console.WriteLine(
                    $"{pair.Value.Name}: Score={pair.Key.Score}, Stage={pair.Key.StageReached}"
                );
            }


            Player david = new Player("David");
            ScoreEntry davidScore = new ScoreEntry(90, 9);

            SortedScores2.Add(davidScore, david);

            Console.WriteLine(
                "\nDavid added with Score 90 and Stage 9."
            );
            System.Console.WriteLine();


            ScoreEntry newTomScore = new ScoreEntry(95, 7);

            SortedScores2.Add(newTomScore, p1);

            Console.WriteLine(
                "The same Tom Player object was added with a different score."
            );
        }
    }
}