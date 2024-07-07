using System;

namespace GoalTracking
{
    public class GoalManager
    {
        public static void CreateNewGoal(User user)
        {
            Console.Clear();
            Console.WriteLine("Create a New Goal");
            Console.WriteLine("-----------------");
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points for goal completion: ");
            int points = int.Parse(Console.ReadLine());

            Console.WriteLine("Select goal type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string type = Console.ReadLine();

            switch (type)
            {
                case "1":
                    user.AddGoal(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    user.AddGoal(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("Enter target count for checklist goal: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points for completing the checklist: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    user.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                    break;
                default:
                    Console.WriteLine("Invalid goal type, returning to main menu.");
                    break;
            }
        }

        public static void RecordGoalEvent(User user)
        {
            Console.Clear();
            Console.WriteLine("Record a Goal Event");
            Console.WriteLine("-------------------");
            Console.Write("Enter the name of the goal you completed: ");
            string goalName = Console.ReadLine();
            int pointsEarned = user.RecordGoalEvent(goalName);

            if (pointsEarned > 0)
            {
                Console.WriteLine($"You have earned {pointsEarned} points!");
            }
            else
            {
                Console.WriteLine("Goal not found or already completed.");
            }
        }

        public static void DisplayGoals(User user)
        {
            Console.Clear();
            Console.WriteLine("Your Goals");
            Console.WriteLine("----------");
            var goals = user.GetGoals();

            if (goals.Count == 0)
            {
                Console.WriteLine("No goals found.");
                return;
            }

            foreach (var goal in goals)
            {
                Console.WriteLine(goal);
            }
        }

        public static void DisplayScore(User user)
        {
            Console.Clear();
            Console.WriteLine("Your Score");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total Score: {user.GetScore()}");
        }
    }
}
