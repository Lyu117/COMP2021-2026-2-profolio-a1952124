using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string path = "./MyTest.txt";
        
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
        }

        // Open the file to read from.
        string s = File.ReadAllText(path);
        Console.WriteLine(s);
    }
}