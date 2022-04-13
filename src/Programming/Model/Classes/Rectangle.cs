using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _count = 0;

        private int _id;

        private int _length;

        private int _width;

        private string _color;

        public Rectangle()
        {
            _count++;
        }

        public Rectangle(int length, int width, string color)
        {
            _count++;
            _id = _count;
            Length = length;
            Color = color;
            Width = width;
        }

        public int Id 
        { 
            get { return _id; }           
        }

        public int Length
        {
            get { return _length; }
            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));          
                _length = value;
            }
        }

        public int Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
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
            return $"Rectangle {_id}";
        }
    }
}
