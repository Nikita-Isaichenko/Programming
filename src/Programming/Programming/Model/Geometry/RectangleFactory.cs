using Programming.Model.Enums;
using System;


namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит методы для создания прямоугольников.
    /// </summary>
    static class RectangleFactory
    {
        /// <summary>
        /// Отступ внутри элемента размещения прямоугольников.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Максимальная длина прямоугольника.
        /// </summary>
        private const int MaxSize = 200;

        /// <summary>
        /// Минимальная длина прямоугольника.
        /// </summary>
        private const int MinSize = 10;

        /// <summary>
        /// Объект класса <see cref="Random"/>
        /// </summary>
        static Random random = new Random();

        /// <summary>
        /// Создает прямоугольник со случайными значениями ширины, длины и координат.
        /// </summary>
        /// <param name="length">Длина элемента, в котором размещаются прямоугольники.</param>
        /// <param name="width">Ширина элемента, в котором размещаются прямоугольники.</param>
        /// <returns>Объект Rectangle.</returns>
        public static Rectangle Randomize(int length, int width)
        {
            var rectangleLength = random.Next(MinSize, MaxSize);
            var rectangleWidth = random.Next(MinSize, MaxSize);
            var rectangleX = random.Next(15, length - MaxSize - Margin);
            var rectangleY = random.Next(15, width - MaxSize + Margin);

            return new Rectangle(rectangleLength, rectangleWidth, "Green", rectangleX, rectangleY);
        }
    }
}
