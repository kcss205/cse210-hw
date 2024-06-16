using System;

class Listing : Activity
{
    private List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public Listing() 
            : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        public override void Run()
        {
            Start();
            Random random = new Random();
            Console.Clear();
            Console.WriteLine(prompts[random.Next(prompts.Count)]);
            PauseWithAnimation(3);
            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                Console.Clear();
                Console.Write("List an item: ");
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    items.Add(item);
                }
            }
            Console.WriteLine($"You listed {items.Count} items.");
            End();
        }
}