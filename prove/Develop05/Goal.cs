using System;

namespace GoalTracking
{
    public abstract class Goal
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Points { get; private set; }
        protected bool IsCompleted { get; set; }

        protected Goal(string name, string description, int points)
        {
            Name = name;
            Description = description;
            Points = points;
            IsCompleted = false;
        }

        public abstract int RecordEvent();

        public override string ToString()
        {
            return $"{GetType().Name}:{Name},{Description},{Points},{IsCompleted}";
        }
    }
}
