using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureRepository scriptureRepository = new ScriptureRepository();
        Scripture selectedScripture = scriptureRepository.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture);
            Console.WriteLine("\nPress Enter to continue, or type 'quit' to end the program: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                selectedScripture.HideRandomWords(1);
            }

            if (selectedScripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden. Program will now end.");
                break;
            }

            else
            {
                Console.WriteLine("Invalid option, please try again. ");
            }
        }

        Console.WriteLine("Program ended.");
    }
}