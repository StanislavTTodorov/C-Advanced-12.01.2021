using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _3.Stack
{
    class MyStack<T> : IEnumerable<T>
    {
        //private Stack<T> stack;
        public MyStack()
        {
            Stacks = new Stack<T>();    
        }
     
        public void Push(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Stacks.Push(item);
            }
        }
        public void Pop()
        {
            if (Stacks.Count > 0)
            {
                Stacks.Pop();
            }
            else
            {
                Console.WriteLine("No elements");
            }           
        }
         public  Stack<T> Stacks { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Stacks)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
