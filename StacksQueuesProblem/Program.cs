using System;

namespace StacksQueuesProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks & Queues Problem Assignment");
            Console.WriteLine("=============================================");
            Stack stackObj = new Stack();
            stackObj.Push(80);
            stackObj.Push(9);
            stackObj.Push(0);
            stackObj.Push(60);
            stackObj.Pop();
            stackObj.Display();
        }
    }
}
