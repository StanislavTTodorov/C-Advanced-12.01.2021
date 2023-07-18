using System;
using System.Collections.Generic;
using System.Text;

namespace _2.GenericBoxOfInteger
{
   public class Box<T>
    {
        private T store;
        public Box(T value)
        {
            this.store = value;    
        }

        public override string ToString()
        {
            return $"{store.GetType()}: {store}";
        }
    }
}
