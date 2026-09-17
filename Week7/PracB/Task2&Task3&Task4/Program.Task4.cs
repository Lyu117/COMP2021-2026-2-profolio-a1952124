using  SortedDictionaryPrac2;
namespace PriorityQueuePrac
{
    public enum Priority
    {
        HighPriority,
        MediumPriority,
        LowPriority
    }

    class Program2
    {
        public static void Task4()
        {
            Player tom = new Player("Tom");
            Player bob = new Player("Bob");
            Player jack = new Player("Jack");
            Player lucy = new Player("Lucy");

            var EventQueue2 = new PriorityQueue<Player, Priority>();

            EventQueue2.Enqueue(tom, Priority.MediumPriority);
            EventQueue2.Enqueue(bob, Priority.HighPriority);
            EventQueue2.Enqueue(jack, Priority.LowPriority);

            EventQueue2.Enqueue(lucy, Priority.HighPriority);


            Console.WriteLine("Players processed in priority order:");

            while (EventQueue2.Count != 0)
            {
                Player player = EventQueue2.Dequeue();
                Console.WriteLine(player.Name);
            }

            Console.WriteLine();


            Console.WriteLine("Players with the same priority:");

            Player david = new Player("David");
            Player kris = new Player("Kris");

            EventQueue2.Enqueue(david, Priority.HighPriority);
            EventQueue2.Enqueue(kris, Priority.HighPriority);

            while (EventQueue2.Count != 0)
            {
                Player player = EventQueue2.Dequeue();
                Console.WriteLine(player.Name);
            }
        }
    }
}