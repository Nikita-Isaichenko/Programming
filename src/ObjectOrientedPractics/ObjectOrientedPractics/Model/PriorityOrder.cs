using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о приоритетном заказе.
    /// </summary>
    class PriorityOrder : Order
    {
        /// <summary>
        /// Возвращает и задает желаемую дату доставки.
        /// </summary>
        public DateTime DesiredDeliveryDate { get; set; }

        /// <summary>
        /// Возвращает и задает желаемое время доставки.
        /// </summary>
        public DeliveryTime DesiredDeliveryTime { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder(DateTime dateTime, DeliveryTime deliveryTime) : base()
        {
            DesiredDeliveryDate = dateTime;
            DesiredDeliveryTime = deliveryTime;
            DeliveryAddress = new Address();
        }
    }
}
