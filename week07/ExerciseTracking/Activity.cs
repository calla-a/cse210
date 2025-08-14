using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime _date;
        private float _lenght;

        public Activity(float lenght)
        {
            _date = DateTime.Now;
            _lenght = lenght;
        }

        public abstract float GetDistance();
        public abstract float GetSpeed();
        public abstract float GetPace();
        public abstract string GetActivityType();

        public virtual string GetSummary(string activityName)
        {
            return $"{_date:dd MMM yyyy} {GetActivityType()} ({_lenght} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
        }

        public float GetLength()
        {
            return _lenght;
        }
    }
}