using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    static class RectangleFactory
    {
        private static string[] _colors = Enum.GetNames(typeof(Color));

        private const int Margin = 15;

        private const int MaxSize = 200;

        private const int MinSize = 10;


        static Random random = new Random();

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
