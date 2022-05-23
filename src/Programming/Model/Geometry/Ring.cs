using System;


namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {        
        /// <summary>
        /// внутренний радиус.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Возвращает и задает внутренний радиус.
        /// Внутренний радиус должен быть меньше внешнего радиуса.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает внешний радиус.
        /// Внешний радиус должен быть больше внутреннего радиуса.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает начальную точку построения.
        /// </summary>
        public Point2D Center { get; set; }
        
        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"./>
        /// </summary>
        /// <param name="outerRadius">Внешний радиус.</param>
        /// <param name="innerRadius">Внутренний радиус.</param>
        /// <param name="x">Координата x.</param>
        /// <param name="y">Координата y.</param>
        public Ring(double outerRadius, double innerRadius, int x, int y)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = new Point2D(x, y);
        }
    }
}

