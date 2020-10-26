using System;

namespace Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks & Queues Problem Assignment");
            Console.WriteLine("=============================================");
            Stack stackObj = new Stack(new[] { 7, 8, 9 });
            stackObj.Push(9);
            stackObj.Push(0);
            stackObj.Push(-8);
            stackObj.Push(67);
            stackObj.Display();
        }
    }
}
