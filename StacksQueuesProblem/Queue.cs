using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueuesProblem
{
    class Queue
    {
        private Node top;
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
            if (top == null)
                top = newNode;
            else
            {
                Node tempNode = top;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = newNode;
            }
            Console.WriteLine($"ENQUEUE {data}");
        }
    }
}
