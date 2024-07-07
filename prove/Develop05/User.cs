using System;
using System.Collections.Generic;
using System.IO;

namespace GoalTracking
{
    public class User
    {
        private List<Goal> _goals;
        private int _score;

        public User()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public int RecordGoalEvent(string goalName)
        {
            foreach (var goal in _goals)
            {
                if (goal.Name == goalName)
                {
                    int pointsEarned = goal.RecordEvent();
                    _score += pointsEarned;
                    return pointsEarned;
                }
            }
            return 0; // No goal found with the given name
        }

        public int GetScore()
        {
            return _score;
        }

        public List<Goal> GetGoals()
        {
            return _goals;
        }

        public void SaveData(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.ToString());
                }
            }
        }

        public static User LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return new User();
            }

            User user = new User();
            using (StreamReader reader = new StreamReader(filename))
            {
                user._score = int.Parse(reader.ReadLine());
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(':');
                    string goalType = parts[0];
                    string[] goalData = parts[1].Split(',');

                    string name = goalData[0];
                    string description = goalData[1];
                    int points = int.Parse(goalData[2]);
                    bool isCompleted = bool.Parse(goalData[3]);

                    Goal goal = goalType switch
                    {
                        "SimpleGoal" => new SimpleGoal(name, description, points),
                        "EternalGoal" => new EternalGoal(name, description, points),
                        "ChecklistGoal" => new ChecklistGoal(
                            name,
                            description,
                            points,
                            int.Parse(goalData[4]),
                            int.Parse(goalData[5])
                        )
                        {
                            CurrentCount = int.Parse(goalData[6])
                        },
                        _ => throw new NotSupportedException($"Goal type {goalType} is not supported")
                    };

                    goal.GetType().GetProperty("IsCompleted", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(goal, isCompleted);

                    user.AddGoal(goal);
                }
            }
            return user;
        }
    }
}
