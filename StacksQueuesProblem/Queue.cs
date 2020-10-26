using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueuesProblem
{
    public class Queue
    {
        private Node head;
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
            if (head == null)
                head = newNode;
            else
            {
                Node tempNode = head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = newNode;
            }
            Console.WriteLine($"ENQUEUE {data}");
        }
        public void Dequeue()
        {
            try
            {
                if (head == null)
                    throw new StacksAndQueuesException(StacksAndQueuesException.ExceptionType.NO_VALUE_IN_QUEUE, "No Value in Queue");
                else
                {
                    Console.WriteLine($"DEQUEUE {head.data} from Head");
                    head = head.next;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception in {nameof(Dequeue)} : {e.Message}");
            }
        }
        public void Display()
        {
            try
            {
                if (head == null)
                    throw new StacksAndQueuesException(StacksAndQueuesException.ExceptionType.NO_VALUE_IN_QUEUE, "No Value in Queue");
                else
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine($"At Head : {head.data}");
                    Node tempNode = head;
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
