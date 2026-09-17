using System.Runtime.Intrinsics.X86;

namespace SortedDictionaryPrac
{
    class Progress
    {
       public  static void Main()
        {
            var SortedScores=new SortedDictionary<int,string>();
            SortedScores.Add(90,"Tom");
            SortedScores.Add(20,"Bob");
            SortedScores.Add(25,"Brian");
            SortedScores.Add(85,"Max");
            SortedScores.Add(15,"Han");
            SortedScores.Add(100,"Jack");
            SortedScores.Add(99,"Jacky");
            SortedScores.Add(35,"Lucy");
            SortedScores.Add(55,"Lucia");
            SortedScores.Add(88,"Kris");

            System.Console.WriteLine("The top three scores are: ");
            foreach (var pair in SortedScores.Reverse().Take(3))
                {
                    Console.WriteLine($"{pair.Value}: {pair.Key}");
                }

            System.Console.WriteLine("The bottom three scores are: ");
            foreach (var pair in SortedScores.Take(3))
                {
                    Console.WriteLine($"{pair.Value}: {pair.Key}");
                }
            System.Console.WriteLine("Lucia has left game");

            int? playerToRemove= null;
            foreach(var pair in SortedScores)
            {
                if (pair.Value == "Lucia")
                {
                    playerToRemove=pair.Key;

                    break;
                }
            }
            if (playerToRemove != null)
            {
                SortedScores.Remove(playerToRemove.Value);
            }
            System.Console.WriteLine("Remaining players: ");
            foreach(var pair in SortedScores)
            {
                System.Console.WriteLine($"{pair.Value}:{pair.Key}");
            }    
            SortedScores.Add(5,"Jack");   

            SortedScores.Add(90,"David");
                
          


            
        }
    }
}