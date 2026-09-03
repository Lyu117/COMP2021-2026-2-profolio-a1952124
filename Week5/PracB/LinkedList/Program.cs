using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace LinkedListPrac
{
    class Progress
    {
        static void Main1()
        {
            var numbers= new LinkedList<int>();
            numbers.AddFirst(70);
            numbers.AddLast(0);
            numbers.AddLast(10);
            numbers.AddLast(30);
            numbers.AddLast(101);
            numbers.AddLast(202);
            numbers.AddLast(15);
            numbers.AddLast(12);
            numbers.AddLast(300);
            numbers.AddLast(55);
            numbers.AddLast(67);
            numbers.AddLast(555);
            numbers.AddLast(895);

            LinkedListNode<int>?node= numbers.First;
            numbers.AddBefore(node!,155);
            numbers.AddBefore(node!.Next!,86);

            numbers.AddAfter(node,1);

            numbers.Remove(0);
            numbers.Remove(node);
            numbers.RemoveFirst();
            numbers.RemoveLast();

            foreach (int number in numbers)
            {
              Console.WriteLine(number);
            }

            LinkedListNode<int>? current= numbers.First;

            for(int i = 1; i < 5; i++)
            {
                current=current?.Next;
            }

            numbers.Remove(current!);




        }
    }
}