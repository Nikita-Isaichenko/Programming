using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о скидочных баллах.
    /// </summary>
    class PointsDiscount
    {
        /// <summary>
        /// Кол-во скидочных баллов.
        /// </summary>
        private int _countPoints;

        /// <summary>
        /// Возвращает и задает кол-во скидочных баллов.
        /// </summary>
        public int CountPoints
        {
            get
            {
                return _countPoints;
            }
            private set
            {
                Validator.AssertValueInRange(value, 0, 1000000, nameof(CountPoints));
                _countPoints = value;
            }
        }

        /// <summary>
        /// Возвращает информацию о кол-ве скидочных баллов и название скидки.
        /// </summary>
        public string Info { get => $"Накопительная - {CountPoints} баллов"; }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="PointsDiscount"/>
        /// </summary>
        public PointsDiscount()
        {
            CountPoints = 33200;
        }

        /// <summary>
        /// Подсчитывает возможную скидку для списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public int Calculate(List<Item> items)
        {
            if (CountPoints == 0)
            {
                return 0;
            }

            double sum = 0;

            foreach(var item in items)
            {
                sum += item.Cost;
            }

            int sizeMaxDiscount = (int)(sum / 100 * 30);

            return sizeMaxDiscount <= CountPoints ? sizeMaxDiscount : CountPoints;        
        }

        /// <summary>
        /// Применяет скидки к товарам и списывает накопленные баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public int Apply(List<Item> items)
        {
            if (CountPoints == 0)
            {
                return 0;
            }

            double sum = 0;

            foreach (var item in items)
            {
                sum += item.Cost;
            }

            int sizeMaxDiscount = (int)(sum / 100 * 30);


            if (sizeMaxDiscount <= CountPoints)
            {
                CountPoints -= sizeMaxDiscount;
                return sizeMaxDiscount;
            }
            else
            {
                /// TODO: подумать еще.
                int temp = CountPoints;
                CountPoints = 0;
                return temp;
            }            
        }

        /// <summary>
        /// Добавляет баллые на основе списка с товарами.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double sum = 0;

            foreach (var item in items)
            {
                sum += item.Cost;
            }

            CountPoints += (int)sum / 100 * 10;
        }
    }
}
