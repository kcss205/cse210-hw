using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> menu = ["Start Breathing Activity", "Start Reflecting Activity", "Start Listing Activity", "Quit"];

        Console.WriteLine("Welcome to the Mindfulness App!");

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
                Breathing breathing = new Breathing();
                breathing.Run();
            }
            else if (choice == "2")
            {
                Reflection reflecting = new Reflection();
                reflecting.Run();
            }
            else if (choice == "3")
            {
                Listing listing = new Listing();
                listing.Run();
            }
            else if (choice == "4")
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