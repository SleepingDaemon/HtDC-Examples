using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtDC_Examples
{
    public class Book
    {
        public Author author;
        public string title;
        public int year;
        public float price;

        public Book(Author author, string title, int year, float price)
        {
            this.author = author;
            this.title = title;
            this.year = year;
            this.price = price;
        }
    }

    public class Author
    {
        public string name;
        public int yearOfBirth;

        public Author(string name, int yearOfBirth)
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
        }
    }

    public class BookExamples
    {
        //public Book robinsonCrusoe = new Book("Daniel Defoe", "Robinson Crusoe", 1719, 15.50f);
        //public Book heartOfDarkness = new Book("Heart Of Darkness", "Joseph Conrad", 1902, 12.80f);
        //public Book beachMusic = new Book("Pat Conroy", "Beach Music", 1996, 9.50f);

        public BookExamples()
        {
            Author author = new Author("Daniel Defoe", 1659);
            Book book1 = new Book(author, "Robinson Crusoe", 1719, 15.50f);

            var authName = author.name;
            var authBirthYear = author.yearOfBirth;
            var bookName = book1.title;
            var bookYear = book1.year;
            var bookPrice = book1.price;

            Console.WriteLine($"Book: {bookName} | by {authName} | Published: {bookYear}" +
                $" | Price: ${bookPrice}");

            Console.ReadLine();
        }
    }
}
