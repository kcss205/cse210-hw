using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> menu = ["New Entry", "Display Entry", "Save Entry", "Load Past Entry", "Quit"];

        Console.WriteLine("Welcome to the Journal App!");

        while (true)
        {
        
            Console.WriteLine("Choose an option:");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.WriteNewEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayJournal();
            }
            else if (choice == "3")
            {
                journal.SaveJournal();
            }
            else if (choice == "4")
            {
                journal.LoadJournal();
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}