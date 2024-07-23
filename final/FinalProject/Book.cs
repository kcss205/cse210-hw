using System;

namespace BookTracker
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public Progress Progress { get; set; }
        public bool IsDone { get; set; }

        public Book(string title, string author, string genre, int totalPages)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Progress = new Progress { TotalPages = totalPages };
            IsDone = false;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Genre: {Genre}, Progress: {Progress}, Done: {IsDone}";
        }
    }
}