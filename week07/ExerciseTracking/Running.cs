using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public class Running : Activity
    {
        private float _distance;

        public Running(int lenght, float distance) : base(lenght)
        {
            _distance = distance;
        }

        public override float GetDistance()
        {
            return _distance;
        }

        public override float GetSpeed()
        {
            return _distance / GetLength() * 60;
        }

        public override float GetPace()
        {
            return GetLength() / _distance;
        }

        public override string GetActivityType()
        {
            return "Running";
        }
    }
}