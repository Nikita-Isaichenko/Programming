using Programming.Model.Classes;
using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количество.
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private int _id;

        /// <summary>
        /// Длина.
        /// </summary>
        private int _length;

        /// <summary>
        /// Ширина.
        /// </summary>
        private int _width;

        /// <summary>
        /// Цвет.
        /// </summary>
        private string _color;      

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>
        /// </summary>
        /// <param name="length">Длина. Положительное число.</param>
        /// <param name="width">Ширина. Положительное число.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="xCenter">х координата.</param>
        /// <param name="yCenter">y координата.</param>
        public Rectangle(int length, int width, string color, int xCenter, int yCenter)
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
            Length = length;
            Color = color;
            Width = width;
            Center = new Point2D(xCenter, yCenter);
        }

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id 
        { 
            get { return _id; }           
        }

        /// <summary>
        /// Возвращает и задает длину прямоугольника. Положительное число.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Положительное число.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает цвет.
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// Возвращает и задает начальную точку построения.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает кол-во прямоугольников.
        /// </summary>
        /// <returns>Общее число прямоугольников.</returns>
        public static int AllRectanglesCount()
        {
            return _allRectanglesCount;
        }

        /// <summary>
        /// Возвращает строку по заданному шаблону.
        /// </summary>
        /// <returns> Строка "Rectangle {Id}"</returns>
        public override string ToString()
        {
            return $"Rectangle {Id}";
        }

        /// <summary>
        /// Возвращает строку по заданному шаблону
        /// </summary>
        /// <returns>Строка "{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Length})"</returns>
        public string GetRectangleInfo()
        {
            return $"{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Length})";
        }
    }
}
