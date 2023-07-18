using System;
using System.Collections.Generic;
using System.Text;

namespace _3.GenericSwapMethodStrings
{
    class Box<T>
    {
        List<T> list;
        public Box()
        {
            list = new List<T>();
        }
        public void Add(T element)
        {
            list.Add(element);
        }
        public void Swaps(int first, int second)
        {
            T tem = list[first];
            list[first] = list[second];
            list[second] = tem;
        }
        public void Print()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
       
    }
}
