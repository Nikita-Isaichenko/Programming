using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Intefaces
{
    // TODO: Посмотреть как правильно комментить.
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Подсчитывает и выводит информацию о доступной скидке.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Скидку для товаров.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Подсчитывает и применяет скидку для списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Скидку для товаров.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет информацию о скидках для товаров.
        /// </summary>
        /// <param name="items"></param>
        void Update(List<Item> items);
    }
}
