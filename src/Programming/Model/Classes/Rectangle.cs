using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int count = 0;
        private int _length;

        private int _width;

        private string _color;

        public Rectangle()
        {
            count++;
        }

        public Rectangle(int length, int width, string color)
        {
            count++;
            this._length = length;
            this._color = color;
            this._width = width;
        }

        public int Length
        {
            get { return _length; }
            set 
            {
                if (value < 0) 
                {
                    throw new ArgumentException("Length must not be less than zero");
                }
                _length = value;

            }
        }

        public int Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width must not be less than zero");
                }
                _width = value;
            }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public override string ToString()
        {
            return $"Rectangle {count}";
        }
    }
}
