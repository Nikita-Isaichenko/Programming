using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            int dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            int dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            int dLength = Math.Abs(rectangle1.Length + rectangle2.Length)/2;
            int dWidth = Math.Abs(rectangle1.Width + rectangle2.Width)/2;

            return (dX < dLength && dY < dWidth);
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {          
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            return (c < (ring1.OuterRadius + ring2.OuterRadius));
        }
    }
}
