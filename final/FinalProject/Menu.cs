using System;

namespace BookTracker
{
public class Menu
    {
        private Library library;
        private User user;
        private const string FilePath = "Booklist.txt";

        public Menu()
        {
            library = new Library();
            user = new User("Default User");

            user.Books = FileManager.LoadData(FilePath);
            library.Books.AddRange(user.Books);
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Record Progress");
                Console.WriteLine("3. View List");
                Console.WriteLine("4. View Thoughts");
                Console.WriteLine("5. Save Data");
                Console.WriteLine("6. Mark Book as Done");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewBook();
                        break;
                    case "2":
                        RecordProgress();
                        break;
                    case "3":
                        ViewList();
                        break;
                    case "4":
                        ViewThoughts();
                        break;
                    case "5":
                        SaveData();
                        break;
                    case "6":
                        MarkBookAsDone();
                        break;
                    case "7":
                        Exit();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void AddNewBook()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book author: ");
            string author = Console.ReadLine();
            Console.Write("Enter book genre: ");
            string genre = Console.ReadLine();
            Console.Write("Enter total number of pages: ");
            if (int.TryParse(Console.ReadLine(), out int totalPages))
            {
                Book book = new Book(title, author, genre, totalPages);
                library.AddBook(book);
                user.AddBook(book);
                Console.WriteLine("Book added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        private void RecordProgress()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Book book = user.Books.Find(b => b.Title == title);
            if (book != null)
            {
                Console.Write("Enter pages read: ");
                if (int.TryParse(Console.ReadLine(), out int pagesRead))
                {
                    book.Progress.PagesRead = pagesRead;
                    Console.WriteLine("Progress recorded successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        private void ViewList()
        {
            Console.WriteLine("1. View All Books");
            Console.WriteLine("2. View Books In Progress");
            Console.WriteLine("3. View Done Books");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    library.ListBooks();
                    break;
                case "2":
                    library.ListBooksInProgress();
                    break;
                case "3":
                    library.ListDoneBooks();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        private void ViewThoughts()
        {
            Console.WriteLine("Your thoughts:");
            foreach (var thought in user.Thoughts)
            {
                Console.WriteLine(thought);
            }
        }

        private void SaveData()
        {
            FileManager.SaveData(FilePath, user);
            Console.WriteLine("Data saved successfully.");
        }

        private void MarkBookAsDone()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Book book = user.Books.Find(b => b.Title == title);
            if (book != null)
            {
                book.IsDone = true;
                Console.WriteLine("Book marked as done.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        private void Exit()
        {
            Console.WriteLine("Exiting the application.");
        }
    }
}
