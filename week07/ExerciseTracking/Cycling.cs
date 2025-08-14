using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private float _speed;

        public Cycling(float lenght, float speed) : base(lenght)
        {
            _speed = speed;
        }

        public override float GetDistance()
        {
            return _speed * GetLength() / 60f;
        }

        public override float GetSpeed()
        {
            return _speed;
        }

        public override float GetPace()
        {
            return 60 / _speed;
        }

        public override string GetActivityType()
        {
            return "Cycling";
        }
    }
}