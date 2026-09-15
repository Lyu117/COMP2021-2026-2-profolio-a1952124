namespace Sort
{
    class SortPrac
    {
        void DisplayScores(SortedSet<int> scores)
        {
            System.Console.WriteLine("SortedSet is ");
            foreach(int score in scores)
            {
                System.Console.WriteLine(score);
            }
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
            scores.Add(6);
            scores.Add(42);
        }
    }
}