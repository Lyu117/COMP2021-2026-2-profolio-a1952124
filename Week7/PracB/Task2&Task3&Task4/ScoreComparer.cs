namespace SortedDictionaryPrac2
{
    public class ScoreComparer : IComparer<ScoreEntry>
    {
        public int Compare(ScoreEntry? x, ScoreEntry? y)
        {
            if (x == null || y == null)
                return 0;



            int scoreCompare = x.Score.CompareTo(y.Score);

            if (scoreCompare != 0)
            {
                return scoreCompare;
            }

            return x.StageReached.CompareTo(y.StageReached);
        }
    }
}