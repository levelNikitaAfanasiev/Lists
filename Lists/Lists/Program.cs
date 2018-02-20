using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
         class LinkedList
        {
            private Node head;
            private Node current;
            public int Count;

            public LinkedList()
            {
                head = new Node();
                current = head;
            }

            public void AddAtLast(object data)
            {
                Node newNode = new Node();
                newNode.Value = data;
                current.Next = newNode;
                current = newNode;
                Count++;
            }
            public void AddAtStart(object data)
            {
                Node newNode = new Node() { Value = data };
                newNode.Next = head.Next;
                head.Next = newNode;
                Count++;
            }
            public void RemoveFromStart()
            {
                if (Count > 0)
                {
                    head.Next = head.Next.Next;
                    Count--;
                }
                else
                {
                    Console.WriteLine("No element exist in this linked list.");
                }
            }
            public void RemoveFromLast()
            {
                if (Count > 0)
                {
                    current.Value = head.Value;
                    Count--;
                }
                else
                {
                    Console.WriteLine("No element exist in this linked list.");
                }
            }
            public void PrintAllNodes()
            {

                Console.Write("Head ->");
                Node curr = head;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                    Console.Write(curr.Value);
                    Console.Write("->");
                }
                Console.Write("NULL");
            }

        }

        public class Node
        {
            public Node Next;
            public object Value;
        }


        class Program
        {
            static void Main(string[] args)
            {

                LinkedList lnklist = new LinkedList();
                lnklist.PrintAllNodes();
                Console.WriteLine();

                lnklist.AddAtLast(12);
                lnklist.AddAtLast(13);
                lnklist.AddAtLast(14);
                lnklist.AddAtLast(34);
                lnklist.PrintAllNodes();
                Console.WriteLine();

                lnklist.AddAtStart(55);
                lnklist.PrintAllNodes();
                Console.WriteLine();

                lnklist.RemoveFromStart();
                lnklist.PrintAllNodes();

                lnklist.RemoveFromLast();
                lnklist.PrintAllNodes();

                  Console.WriteLine();



            }
        }
    
}