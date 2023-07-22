using System;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Book[] books = new Book[]
            {
            new Book("Animal Farm", 2003, "George Orwell"),
            new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace"),
            new Book("The Documents in the Case", 1930)
            };
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);


            Library libraryOne = new Library();
            Library libraryOneTwo = new Library (bookOne, bookTwo, bookThree);
            Library libraryTwo = new Library(books);
            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book.Titel);
            }
        }
    }
}
