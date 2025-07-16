using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fractions
{
    public class HoldFraction
    {
        private int _topNumber;
        private int _bottomNumber;

        public HoldFraction()
        {
            _topNumber = 1;
            _bottomNumber = 1;
        }

        public HoldFraction(int topNumber)
        {
            _topNumber = topNumber;
            _bottomNumber = 1;
        }

        public HoldFraction(int topNumber, int bottomNumber)
        {
            _topNumber = topNumber;
            _bottomNumber = bottomNumber;
        }

        public string GetFractionString()
        {
            return $"{_topNumber}/{_bottomNumber}";
        }

        public double GetDecimalValue()
        {
            return (double)_topNumber / (double)_bottomNumber;
        }
    }
}