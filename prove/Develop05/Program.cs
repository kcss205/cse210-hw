using System;
using System.IO;

namespace GoalTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = LoadUserData();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Goal Tracking Application");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Create a New Goal");
                Console.WriteLine("2. Record a Goal Event");
                Console.WriteLine("3. Display Goals");
                Console.WriteLine("4. Show Score");
                Console.WriteLine("5. Save and Exit");
                Console.WriteLine("6. Exit Without Saving");
                Console.Write("Select an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        GoalManager.CreateNewGoal(user);
                        break;
                    case "2":
                        GoalManager.RecordGoalEvent(user);
                        break;
                    case "3":
                        GoalManager.DisplayGoals(user);
                        break;
                    case "4":
                        GoalManager.DisplayScore(user);
                        break;
                    case "5":
                        SaveUserData(user);
                        Console.WriteLine("Data saved. Exiting...");
                        return;
                    case "6":
                        Console.WriteLine("Exiting without saving...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }

        static User LoadUserData()
        {
            string filename = "goals.txt";
            if (File.Exists(filename))
            {
                return User.LoadData(filename);
            }
            else
            {
                return new User();
            }
        }

        static void SaveUserData(User user)
        {
            string filename = "goals.txt";
            user.SaveData(filename);
        }
    }
}
