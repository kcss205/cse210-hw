using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();

       string userName = PromptName();
       int userNumber = PromptNumber();

       DisplayResult(userName, userNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, ")
    }
}