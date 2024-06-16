using System;

class Reflection : Activity
{
    private List<string> prompts = new List<string>
    {
    
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection() 
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. Recognize your inner power and how you can use it in other aspects of your life.")
    {
    }

    public override void Run()
    {
        Start();
        Random random = new Random();
        Console.Clear();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        PauseWithAnimation(3);
        int timeRemaining = Duration - 3;
        while (timeRemaining > 0)
        {
            Console.Clear();
            Console.WriteLine(questions[random.Next(questions.Count)]);                PauseWithAnimation(5);
            timeRemaining -= 5;
        }
        End();
    }
}
