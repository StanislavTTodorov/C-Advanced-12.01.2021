using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1.ListyIterator
{
    public class ListyIterator<T> : IEnumerator<T> , IEnumerable<T>
    {

        private List<T> list;
        private int currentIndex = 0;

        public ListyIterator(IEnumerable<T> list)
        {

            this.list = new List<T>(list);
        }
        public ListyIterator()
        {
            list = new List<T>();
        }

        public T Current => list[currentIndex];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            return ++currentIndex < list.Count;
        }
        public void Print()
        {
            if (this.list.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else if (currentIndex < list.Count)
            {
                Console.WriteLine(list[currentIndex]);
            }
        }

        public void Reset()
        {
            currentIndex = 0;
        }

        public void Dispose()
        {
        }

       public bool HasNext()
        {
            int index = currentIndex;
            return ++index < list.Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
               yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); ;
        }
    }
}
