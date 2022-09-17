using Programming.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о точке.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата х.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает и задает координату точки х.
        /// Координата должна быть от 0 до 1000 включительно.
        /// </summary>
        public int X
        {
            get 
            { 
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                Validator.AssertValueInRange(value, 0, 1000, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату y. 
        /// Координата должна быть от 0 до 1000 включительно.
        /// </summary>
        public int Y
        {
            get 
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                Validator.AssertValueInRange(value, 0, 1000, nameof(Y));
                _y = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>
        /// </summary>
        /// <param name="x">Координата х.</param>
        /// <param name="y">Координата y.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
