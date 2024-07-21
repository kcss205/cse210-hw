using System;

  public class User : Entity
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public User(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Books: {Books.Count}";
        }
    }