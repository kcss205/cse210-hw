using System;

public class Menu
    {
        private Library library;
        private User user;

        public Menu()
        {
            library = new Library();
            user = new User("Default User");
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Record Progress");
                Console.WriteLine("3. View Books");
                Console.WriteLine("4. View Thoughts");
                Console.WriteLine("5. Save Data");
                Console.WriteLine("6. Exit");
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
                        ViewBooks();
                        break;
                    case "4":
                        ViewThoughts();
                        break;
                    case "5":
                        SaveData();
                        break;
                    case "6":
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
            Book book = new Book(title, author);
            library.AddBook(book);
            user.AddBook(book);
            Console.WriteLine("Book added successfully.");
        }

        private void RecordProgress()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Book book = user.Books.Find(b => b.Title == title);
            if (book != null)
            {
                Console.Write("Enter pages read: ");
                int pagesRead = int.Parse(Console.ReadLine());
                book.Progress.PagesRead = pagesRead;
                Console.WriteLine("Progress recorded successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        private void ViewBooks()
        {
            library.ListBooks();
        }

        private void ViewThoughts()
        {
            Console.WriteLine("Your thoughts:");
            foreach (var book in user.Books)
            {
                Console.WriteLine($"Book: {book.Title}, Thoughts: {book.Progress}");
            }
        }

        private void SaveData()
        {
            string data = "User: " + user + "\nBooks:\n";
            foreach (var book in user.Books)
            {
                data += book + "\n";
            }
            FileManager.SaveData("data.txt", data);
            Console.WriteLine("Data saved successfully.");
        }

        private void Exit()
        {
            Console.WriteLine("Exiting the application.");
        }
    }
