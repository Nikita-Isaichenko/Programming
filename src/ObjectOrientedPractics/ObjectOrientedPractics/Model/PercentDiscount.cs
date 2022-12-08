using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит инфомацию о скидках на определенные категории.
    /// </summary>
    class PercentDiscount
    {
        private const double _maxDiscount = 0.1;

        private double _currentDiscount;

        private double _totalSpent;

        /// <summary>
        /// Возвращает и задает категорию товара, на который предоставляется скидка.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает текущую скидку на товар определенной категории.
        /// </summary>
        public double CurrentDiscount
        {
            get
            {
                return _currentDiscount;
            }
            private set
            {
                Validator.AssertValueInRange(value, 0, 0.1, nameof(CurrentDiscount));
                _currentDiscount = value;
            }
        }

        /// <summary>
        /// Возвращает и задает сумму денег потраченную на товары
        /// определенной категории.
        /// </summary>
        public double TotalSpent
        {
            get
            {
                return _totalSpent;
            }
            private set
            {
                _totalSpent = value;                
            }
        }

        /// <summary>
        /// Возвращает информацию о кол-ве скидочных баллов и название скидки.
        /// </summary>
        public string Info { get => $"Процентная {Category} - {CurrentDiscount * 100}%"; }

        /// <summary>
        /// Инициализирует экзепляр класса <see cref="PercentDiscount"/>
        /// </summary>
        public PercentDiscount(Category category)
        {
            Category = category;
        }

        /// <summary>
        /// Подсчитывает возможную скидку для товаров из списка заданной категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double sumCost = 0;

            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    sumCost += item.Cost;
                }
            }

            return sumCost * CurrentDiscount;
        }

        /// <summary>
        /// Применяет скидки к товарам заданной категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            double sumCost = 0;

            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    sumCost += item.Cost;
                }
            }

            return sumCost * CurrentDiscount;
        }

        /// <summary>
        /// Добавляет проценты на основе суммы покупки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double sumCost = 0;

            foreach (var item in items)
            {
                sumCost += item.Cost;
            }

            TotalSpent += sumCost;

            // TODO: Удалить магические числа.
            if (CurrentDiscount < _maxDiscount)
            {
                double discount = Math.Truncate(_totalSpent / 1000) / 100;

                if (_maxDiscount - CurrentDiscount >= discount)
                {
                    CurrentDiscount += discount;
                }
                else
                {
                    CurrentDiscount += _maxDiscount - CurrentDiscount;
                }
            }
        }

        
    }


}
