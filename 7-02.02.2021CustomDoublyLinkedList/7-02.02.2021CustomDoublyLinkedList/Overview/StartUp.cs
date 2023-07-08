using System;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //LinkedListBonus list = new LinkedListBonus();
            //for (int i = 0; i < 5; i++)
            //{
            //    list.AddLast(new Node(i + 1));
            //}
            //list.Reverse();
            //list.Reverse();

            //list.ForEach((node) =>
            //{
            //    Console.WriteLine(node.Value);
            //});

            //return;
            LinkedList linkedList = new LinkedList();
            for (int i = 0; i <= 5; i++)
            {
                linkedList.AddHead(new Node(i));
            }
            for (int i = 1; i <= 5; i++)
            {
                linkedList.AddLast(new Node(i));
            }

            Console.WriteLine("Remuve Tail " + linkedList.RemoveTail().Value);
            Console.WriteLine("Remuve Head " + linkedList.RemoveHead().Value);
            linkedList.ForEachHead((node) =>
            {
                Console.WriteLine(node.Value);
            });
            int[] linkedListAsArray = linkedList.ToArray();
        }
    }
}
