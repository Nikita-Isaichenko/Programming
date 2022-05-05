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
        static Random random = new Random();

        public static Rectangle Randomize()
        {
            
            return new Rectangle(random.Next(0, 1000), random.Next(0, 1000),
                                 _colors[random.Next(_colors.Length)],
                                 random.Next(0, 671), random.Next(0, 451));
        }
    }
}
