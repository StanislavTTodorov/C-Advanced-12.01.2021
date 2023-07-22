using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;
        private int currentTndex; 

        public LibraryIterator(IEnumerable<Book> books)
        {
            Reset();
            this.books = new List<Book>(books);
        }

        public Book Current => books[currentTndex];

        object IEnumerator.Current => Current;
        public void Dispose() { }

        public bool MoveNext()
        {
            return ++currentTndex < books.Count;
        }

        public void Reset()
        {
            currentTndex = -1;
        }
    }
}