using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Point2D
    {
        private int _x;

        private int _y;

        public int X
        {
            get 
            { 
                return _x;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                Validator.AssertValueInRange(value, 0, 670.0, nameof(X));
                _x = value;
            }
        }

        public int Y
        {
            get 
            {
                return _y;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                Validator.AssertValueInRange(value, 0, 450.0, nameof(Y));
                _y = value;
            }
        }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
