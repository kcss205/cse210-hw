using System;

abstract class Activity
{
    public string Name { get; }
    public string Description { get; }
    public int Duration { get; private set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting Activity: {Name}");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);
    }

    public void End()
    {
        Console.Clear();
        Console.WriteLine($"Good job! You have completed the {Name} activity.");
        Console.WriteLine($"Total duration: {Duration} seconds.");
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"Starting in {i}...\r");
            Thread.Sleep(1000);
        }
        Console.WriteLine(new string(' ', 20));  // Clear the line
    }

    public abstract void Run();
}