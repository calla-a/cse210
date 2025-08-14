using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int _numberOfLaps;

        public Swimming(float lenght, int laps) : base(lenght)
        {
            _numberOfLaps = laps;
        }

        public override float GetDistance()
        {
            return _numberOfLaps * 50f / 1000;
        }

        public override float GetSpeed()
        {
            return GetDistance() / GetLength() * 60;
        }

        public override float GetPace()
        {
            return GetLength() / GetDistance();
        }

        public override string GetActivityType()
        {
            return "Swimming";
        }
    }
}