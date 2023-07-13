using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> stack;

        public Box()
        {
           this.stack = new Stack<T>();
        }

        public void Add(T element)
        {
            this.stack.Push(element);
        }

        public T Remove()
        {
           return this.stack.Pop();
        }

        public int Count()
        {
           return stack.Count();
        }
        
    }
}
