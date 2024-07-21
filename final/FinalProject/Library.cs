using System;

public class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void ListBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }
    }