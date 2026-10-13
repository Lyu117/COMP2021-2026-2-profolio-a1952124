
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        int iterations = 20;

        List<double> appendElapsedList = new();
        List<double> builderElapsedList = new();

        Stopwatch watch = new();

  
        for (int pass = 1; pass <= iterations; pass++)
        {
            string aOutput = "";

            watch.Restart();

            for (int i = 0; i < pass * 10_000; i++)
            {
                aOutput += "z";
            }

            watch.Stop();

            appendElapsedList.Add(watch.Elapsed.TotalSeconds);

            Console.WriteLine($"Append {pass}: {watch.Elapsed.TotalSeconds} seconds");
        }

        // StringBuilder method
        for (int pass = 1; pass <= iterations; pass++)
        {
            StringBuilder bOutput = new();

            watch.Restart();

            for (int i = 0; i < pass * 10_000; i++)
            {
                bOutput.Append("z");
            }

            watch.Stop();

            builderElapsedList.Add(watch.Elapsed.TotalMilliseconds);

            Console.WriteLine($"Build {pass}: {watch.Elapsed.TotalMilliseconds} ms");
        }

        ScottPlot.Plot appendPlot = new();

        appendPlot.Add.Bars(appendElapsedList.ToArray());

        appendPlot.Title("String Append Performance");
        appendPlot.XLabel("Pass");
        appendPlot.YLabel("Time (seconds)");

        appendPlot.SavePng("appendPlot.png", 800, 600);

        ScottPlot.Plot buildPlot = new();

        buildPlot.Add.Bars(builderElapsedList.ToArray());

        buildPlot.Title("StringBuilder Performance");
        buildPlot.XLabel("Pass");
        buildPlot.YLabel("Time (milliseconds)");

        buildPlot.SavePng("buildPlot.png", 800, 600);

        Console.WriteLine("Graphs saved!");
    }
}
