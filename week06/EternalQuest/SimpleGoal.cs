using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _isComplete = false;
        }

        // I decided to create this other constructor so that, when I load a file with goals, if there is a SimpleGoal which value for the
        // attribute _isComplete is true, this constructor can manage an assign that value to the attribute. This is why because to me this made
        // more sense than creating another CrateGoal() constructor in the GoalManager class.
        public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
        {
            _isComplete = isComplete;
        }

        public override void RecordEvent()
        {
            if (_isComplete == false)
            {
                _isComplete = true;
                Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
            }
            else
            {
                Console.WriteLine("This goal has already been achieved.");
            }
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
        }
    }
}