using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _allRectanglesCount = 0;

        private int _id;

        private int _length;

        private int _width;

        private string _color;      

        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle(int length, int width, string color, int xCenter, int yCenter)
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
            Length = length;
            Color = color;
            Width = width;
            Center = new Point2D(xCenter, yCenter);
        }

        public int Id 
        { 
            get { return _id; }           
        }

        public int Length
        {
            get 
            { 
                return _length;
            }
            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        public int Width
        {
            get 
            { 
                return _width;
            }
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

        public Point2D Center { get; set; }

        public static int AllRectanglesCount()
        {
            return _allRectanglesCount;
        }

        public override string ToString()
        {
            return $"Rectangle {Id}";
        }   
        
        public string GetRectangleInfo()
        {
            return $"{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Length})";
        }
    }
}
