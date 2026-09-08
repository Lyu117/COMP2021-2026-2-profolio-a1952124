using System.Runtime.CompilerServices;

namespace Task2
{
    class Progress{
    static void Main()
    {
        Queue<string> jobs=new Queue<string>();
        Console.WriteLine("Initial queue is empty");
         foreach(string job in jobs)
            {
                System.Console.WriteLine(job);
            }
        jobs.Enqueue("Job 1");
        jobs.Enqueue("Job 2");
        jobs.Enqueue("Job 3");

        System.Console.WriteLine("After Enqueue, the queue is");


        foreach(string job in jobs)
            {
                System.Console.WriteLine(job);
            }

        System.Console.WriteLine($"Peek(): {jobs.Peek()}");
        System.Console.WriteLine();

        jobs.Dequeue();
        System.Console.WriteLine("After Dequeue(), the queue is ");
        foreach (string job in jobs)
            {
                System.Console.WriteLine(job);
            }

        
        
    }
}
}