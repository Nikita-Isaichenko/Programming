using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _count = 0;
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
                    _length = 0;
                    throw new ArgumentException("Длина не может быть меньше нуля.");                    
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
                    _width = 0;
                    throw new ArgumentException("Ширина не может быть меньше нуля.");
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
            return $"Rectangle {_count}";
        }
    }
}
