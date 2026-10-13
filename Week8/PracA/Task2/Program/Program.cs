
using System;
using System.Diagnostics;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Stopwatch w1 = new Stopwatch();
        string aOutput = "";

        w1.Start();

        for (int i = 0; i < 100_000; i++)
        {
            aOutput += "z";
        }

        w1.Stop();

        Console.WriteLine($"Append: {w1.Elapsed.TotalSeconds} seconds");

        Stopwatch w2 = new Stopwatch();
        StringBuilder bOutput = new();

        w2.Start();

        for (int i = 0; i < 100_000; i++)
        {
            bOutput.Append("z");
        }

        w2.Stop();

        Console.WriteLine($"Build: {w2.Elapsed.TotalSeconds} seconds");
    }
}
