using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int userNumber;
        do
        {
            Console.Write("Enter number: ");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = numbers.Count > 0 ? ((float)sum) / numbers.Count : 0;

        int maxNumber = numbers.Count > 0 ? numbers[0] : 0;
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {maxNumber}");
    }
}