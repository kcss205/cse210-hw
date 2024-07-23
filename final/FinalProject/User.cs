using System;

namespace BookTracker
{
    public class User : Entity
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public List<Thought> Thoughts { get; set; }

        public User(string name)
        {
            Name = name;
            Books = new List<Book>();
            Thoughts = new List<Thought>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddThought(Thought thought)
        {
            Thoughts.Add(thought);
        }

        public List<Book> GetBooksInProgress()
        {
            return Books.FindAll(b => !b.IsDone);
        }

        public List<Book> GetDoneBooks()
        {
            return Books.FindAll(b => b.IsDone);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Books: {Books.Count}";
        }
    }
}