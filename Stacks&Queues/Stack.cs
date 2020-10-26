using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Queues
{
    class Stack
    {
        public Node top;
        public Stack()
        {
        }
        public Stack(int[] datas)
        {
            foreach (int data in datas)
            {
                Push(data);
            }
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            Node tempNode = top;
            top = newNode;
            newNode.next = tempNode;
            Console.WriteLine($"PUSHED {newNode.data}");
        }
        public void Pop()
        {
            try
            {
                if (top == null)
                    throw new StackException(StackException.ExceptionType.NO_VALUE, "No Value in Stack");
                else
                {
                    Console.WriteLine($"POPED {top.data} from Top");
                    top = top.next;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception in {nameof(Pop)} : {e.Message}");
            }
        }
        public void Display()
        {
            try
            {
                if (top == null)
                    throw new StackException(StackException.ExceptionType.NO_VALUE, "No Value in Stack");
                else
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine($"At Top: {top.data}");
                    Node tempNode = top;
                    int level = 1;
                    while (tempNode.next != null)
                    {
                        Console.WriteLine($"At Level {level} : {tempNode.next.data}");
                        tempNode = tempNode.next;
                        level++;
                    }
                    Console.WriteLine("-----------------");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception in {nameof(Display)} : {e.Message}");
            }
        }
    }
}
