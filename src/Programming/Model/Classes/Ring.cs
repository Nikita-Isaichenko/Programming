using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private Point2D _center;

        private double _innerRadius;

        private double _outerRadius;

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                if (value >= OuterRadius)
                {
                    throw new ArgumentException("Внутренний радиус больше или" +
                                                "равен внешнему радиусу!");
                }
                _innerRadius = value;
            }
        }

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                if (value <= _innerRadius)
                {
                    throw new ArgumentException("Внешний радиус меньше или " +
                                                "равен внутреннему радиусу!");
                }
                _outerRadius = value;
            }
        }

        public Point2D Center { get; set; }
        
        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
            }
        }

        public Ring(double outerRadius, double innerRadius, int x, int y)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            _center = new Point2D(x, y);
        }
    }
}

