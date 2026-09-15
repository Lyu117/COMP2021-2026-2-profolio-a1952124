namespace Sort
{
    class SortPrac
    {
        public static void DisplayScores(SortedSet<int> scores)
        {
            System.Console.WriteLine("SortedSet is ");
            foreach(int score in scores)
            {
                System.Console.WriteLine(score);
            }
            
            Console.WriteLine($"Lowest score: {scores.Min}");
            Console.WriteLine($"Highest score: {scores.Max}");
        }
    }


    class Progress
    {
        static void Main()
        {
            SortedSet<int>scores=new SortedSet<int>();
            scores.Add(50);
            scores.Add(20);
            scores.Add(80);
            scores.Add(30);
            scores.Add(5);
            scores.Add(45);
            scores.Add(99);
            scores.Add(100);
            scores.Add(10);
            scores.Add(120);
            
            SortPrac.DisplayScores(scores);

            scores.Add(150);
            
            SortPrac.DisplayScores(scores);

            scores.Add(120);
            SortPrac.DisplayScores(scores);



        }
    }
}