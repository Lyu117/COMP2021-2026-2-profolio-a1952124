namespace Task1;
class Progress
{
    static void Main()
    {
        Stack<string> history=new Stack<string>();
        Console.WriteLine("Initial stack is empty");
        foreach(string history1 in history)
        {
            
            System.Console.WriteLine(history1);
        }

        history.Push("Typed Text");
        history.Push("Inserted image");
        history.Push("Changed color");

        System.Console.WriteLine("After push, the stack is");

        foreach(string history1 in history)
        {
            
            System.Console.WriteLine(history1);
        }

        history.Peek();
        
         System.Console.WriteLine($"Peek: {history.Peek()} ");
        history.Pop();
        System.Console.WriteLine("After Pop(), the stack is ");
         foreach(string history1 in history)
        {
            
            System.Console.WriteLine(history1);
        }

    }
    
}