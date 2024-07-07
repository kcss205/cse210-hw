using System;

namespace GoalTracking
{
    public class ChecklistGoal : Goal
    {
        public int TargetCount { get; private set; }
        public int CurrentCount { get; set; }
        public int BonusPoints { get; private set; }

        public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
            : base(name, description, points)
        {
            TargetCount = targetCount;
            CurrentCount = 0;
            BonusPoints = bonusPoints;
        }

        public override int RecordEvent()
        {
            if (!IsCompleted)
            {
                CurrentCount++;
                if (CurrentCount >= TargetCount)
                {
                    IsCompleted = true;
                    return Points + BonusPoints;
                }
                return Points;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()},{TargetCount},{CurrentCount},{BonusPoints}";
        }
    }
}
