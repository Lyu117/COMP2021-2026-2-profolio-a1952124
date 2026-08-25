namespace Topic4a;
public static class BrokenProgram
{
  static void Main(string[] args)
  {
    const string input = """
       23
       + 
       77
       + 
        3
       + 
      457
       * 
        2
         
      """;
    int total = 0;
    List<int> items = [];
    List<string> symbols = [];

    for (int i = 0; i < input.Split("\n").Length; i += 2)// input.Split（"\n") 把input按换行切开 
                                                         // 切开后一共有多少行就是input.Split("\n").Length
    {
      items.Add(int.Parse(input.Substring((i * 4) + 1, 3)));

      if (i != 0)
      {
        symbols.Add(input.Split("\n")[i - 1]);
      }
    }

    foreach (var (i, value) in items.Index())
    {
      if (i == 0) { total = value; }
      else if (symbols[i - 1] == "*")
      {
        total *= value;
      }
      else
      {
        total += value;
      }
    }
    Console.WriteLine("Total was: " + total);
    Console.WriteLine("Expected total was: 1120");
    Console.WriteLine(total == 1120 ? "Your answer was RIGHT!" : "Your answer was WRONG!\nGo and fix it.");
  }
}