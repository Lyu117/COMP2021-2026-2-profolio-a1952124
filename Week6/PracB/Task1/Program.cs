namespace Task1
{
    class Progress
    {
        static void Main()
        {
            List<string> name = new List<string>();
            name.Add("Lewis Hamilton");
            name.Add("Michael Schumacher");
            name.Add("Max Verstappen");
            name.Add("Fernando Alonso");
            name.Add("Sebastian Vettel");
            name.Add("Ayrton Senna");
            name.Add("Alain Prost");
            name.Add("Charles Leclerc");
            name.Add("Lando Norris");
            name.Add("Kimi Räikkönen");
            var Sortedname=name.OrderBy(x=>x).ToList();
            System.Console.WriteLine("Print Sorted Name: ");
            foreach(string name1 in Sortedname)
            {
                System.Console.WriteLine(name1);
            }
            System.Console.WriteLine();


        }
    }
}