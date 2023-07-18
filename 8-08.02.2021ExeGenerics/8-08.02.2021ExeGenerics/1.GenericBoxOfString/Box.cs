using System;
using System.Collections.Generic;
using System.Text;

namespace _1.GenericBoxOfString
{
    public class Box<T>
    {
        private T storage;

        public Box(T value)
        {
            this.storage = value;
        }

        public override string ToString()
        {
            return $"{storage.GetType()}: {storage}";
        }
    }
}
