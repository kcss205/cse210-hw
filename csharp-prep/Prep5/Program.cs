using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();

       string userName = PromptName();
       int userNumber = PromptNumber();

       int squaredNumber = SquaredNumber(userNumber);

       DisplayResult(userName, squaredNumber);
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

    static int SquaredNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
}