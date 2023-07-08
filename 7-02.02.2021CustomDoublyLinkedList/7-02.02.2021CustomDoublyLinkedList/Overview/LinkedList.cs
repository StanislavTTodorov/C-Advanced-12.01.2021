using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    class LinkedList
    {
        private int count = 0;
        public Node Head { get; set; }

        public Node Tail { get; set; }
         
        public int[] ToArray()
        {
            int intex = 0;
            int[] array = new int[count];
            ForEachHead(( Node node) =>
            { 
                array[intex] = node.Value;
                intex++;
            });
            return array;
        }
        public void ForEachTail(Action<Node> action)
        {
            Node currentNode = Tail; 
            while (currentNode!= null)
            {              
                action(currentNode);
                currentNode= currentNode.Previous;
            }
        }
        public void ForEachHead(Action<Node> action)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {               
                action(currentNode);
                currentNode = currentNode.Next;
            }
        }
        public void AddHead(Node node)
        {
            count++;
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }
            node.Next = Head;
            Head.Previous = node;
            Head = node;
        }
        public void AddLast(Node node)
        {
            count++;
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }
            node.Previous = Tail;
            Tail.Next = node;
            Tail = node;
        }
        public Node RemoveHead()
        {
           
            if (Head == null)
            {
                return null;
            }
            count--;
            Node nodeToReturn = Head;
            if (Head.Next != null)
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            else
            {
                Head = null;
                Tail = null;
            }
            return nodeToReturn;
        }
        public Node RemoveTail()
        {
            if (Tail == null)
            {
                return null;
            }
            count--;
            Node nodeToReturn = Tail;
            if (Tail.Previous != null)
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            else
            {
                Tail = null;
                Head = null;
            }
            return nodeToReturn;
        }
    }
}
