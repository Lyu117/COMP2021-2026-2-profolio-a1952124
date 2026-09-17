using SortedDictionaryPrac2;
namespace PriorityQueuePrac
{
    class Program1
    {
        public static void Task3()
        {

            Player tom = new Player("Tom");
            Player bob = new Player("Bob");
            Player jack = new Player("Jack");
            Player lucy = new Player("Lucy");

            var EventQueue = new PriorityQueue<Player, int>();

            EventQueue.Enqueue(tom, 3);
            EventQueue.Enqueue(bob, 1);
            EventQueue.Enqueue(jack, 4);
            EventQueue.Enqueue(lucy, 2);
            Console.WriteLine("Players processed in priority order:");

            while (EventQueue.Count != 0)
            {
                Console.WriteLine(EventQueue.Dequeue());
            }
            System.Console.WriteLine();




            System.Console.WriteLine("Players with the same priority:");

            Player david = new Player("David");
            Player kris = new Player("Kris");

            EventQueue.Enqueue(david, 1);
            EventQueue.Enqueue(kris, 1);

            while (EventQueue.Count != 0)
            {
                System.Console.WriteLine(EventQueue.Dequeue());
            }
        }
    }
}