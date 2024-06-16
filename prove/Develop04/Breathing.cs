using System;

class Breathing : Activity
{
    public Breathing()
    : base("Breathing", "Thia activity will help you relax by walking you through breathing in and out slowly")
{    
}

    public override void Run()
    {
        Start();
        int timeRemaining = Duration;
        while (timeRemaining > 0)
        {
            Console.Clear();
            Console.WriteLine("Breath in ...");
            PauseWithAnimation(3);
            timeRemaining -= 3;
            if (timeRemaining <= 0)
            {
                break;
            }

            Console.Clear();
            Console.WriteLine("Breath out ...");
            PauseWithAnimation(3);
            timeRemaining -= 3;
        }
        End();
    }
}