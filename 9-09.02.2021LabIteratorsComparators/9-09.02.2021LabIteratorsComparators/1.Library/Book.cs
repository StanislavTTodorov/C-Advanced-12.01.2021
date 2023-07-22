using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book :IComparable<Book>
    {
        public Book(string titel,int year,params string[] authors)
        {
            Titel = titel;
            Year = year;
            Authors = authors;
        }
        public string Titel { get; private set; }

        public int Year { get; private set; }

        public IReadOnlyList<string> Authors { get; private set; }

        public int CompareTo(Book other)
        {
            if (Year != other.Year)
            {
                return Year - other.Year;
            }
            return Titel.CompareTo(other.Titel);
        }
        public override string ToString()
        {
            return $"{Titel} - {Year}";
        }



    }
}
