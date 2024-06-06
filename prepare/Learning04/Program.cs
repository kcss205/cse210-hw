using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment n1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(n1.GetSummary());

        MathAssignment n2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(n2.GetSummary());
        Console.WriteLine(n2.GetHomeworkList());

        WritingAssignment n3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(n3.GetSummary());
        Console.WriteLine(n3.GetWritingInformation());
    }
}