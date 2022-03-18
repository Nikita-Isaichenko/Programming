using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private int _length;

        private int _width;

        private string _color;

        public Rectangle()
        {
        }

        public Rectangle(int length, int width, string color)
        {
            _length = length;
            _color = color;
            _width = width;
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
        public string Color { get; set; }
    }
}
