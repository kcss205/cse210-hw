using System;

namespace BookTracker
{
    public class FileManager 
    {
        public static void SaveData(string filePath, User user)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in user.Books)
                {
                    writer.WriteLine($"{book.Title}|{book.Author}|{book.Genre}|{book.Progress.PagesRead}|{book.Progress.TotalPages}|{book.IsDone}");
                }
            }
        }

        public static List<Book> LoadData(string filePath)
        {
            List<Book> books = new List<Book>();

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 6)
                        {
                            string title = parts[0];
                            string author = parts[1];
                            string genre = parts[2];
                            int pagesRead = int.Parse(parts[3]);
                            int totalPages = int.Parse(parts[4]);
                            bool isDone = bool.Parse(parts[5]);

                            Book book = new Book(title, author, genre, totalPages)
                            {
                                Progress = { PagesRead = pagesRead },
                                IsDone = isDone
                            };
                            books.Add(book);
                        }
                    }
                }
            }

            return books;
        }
    }
}