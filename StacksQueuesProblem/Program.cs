using System;

namespace StacksQueuesProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks & Queues Problem Assignment");
            Console.WriteLine("=============================================");
            Console.WriteLine("Working on Stack");
            Stack stackObj = new Stack();
            stackObj.Push(80);
            stackObj.Push(9);
            stackObj.Push(0);
            stackObj.Push(60);
            stackObj.Pop();
            stackObj.Peek();
            stackObj.Display();
            Console.WriteLine("\n=============================================");
            Console.WriteLine("Working on Queue");
            Queue queueObj = new Queue(new[] { 91,80});
            queueObj.Enqueue(9);
            queueObj.Enqueue(0);
        }
    }
}
