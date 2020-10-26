using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueuesProblem
{
    public class Queue
    {
        private Node first;
        public Queue()
        {
        }
        public Queue(int[] datas)
        {
            foreach(int data in datas)
            {
                Enqueue(data);
            }
        }
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (first == null)
                first = newNode;
            else
            {
                Node tempNode = first;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = newNode;
            }
            Console.WriteLine($"ENQUEUE {data}");
        }
        public void Display()
        {
            try
            {
                if (first == null)
                    throw new StacksAndQueuesException(StacksAndQueuesException.ExceptionType.NO_VALUE_IN_QUEUE, "No Value in Queue");
                else
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine($"At First : {first.data}");
                    Node tempNode = first;
                    int level = 1;
                    while (tempNode.next != null)
                    {
                        Console.WriteLine($"At {level} : {tempNode.next.data}");
                        tempNode = tempNode.next;
                        level++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception in {nameof(Display)} : {e.Message}");
            }
        }
    }
}
