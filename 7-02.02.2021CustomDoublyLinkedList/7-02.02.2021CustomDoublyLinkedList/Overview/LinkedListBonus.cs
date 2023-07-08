using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    class LinkedListBonus
    {
        private bool reversed = false;

        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void Reverse()
        {
            Node temp = Head;
            Head = Tail;
            Tail = temp;
            reversed = !reversed;
        }
        public void ForEach(Action<Node> action)
        {
            Node currentNode = Head; 
            while (currentNode!= null)
            {              
                action(currentNode);
                if (reversed)
                {
                    currentNode = currentNode.Previous; 

                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
        }
       
        public void AddLast(Node node)
        {
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
    }
}
