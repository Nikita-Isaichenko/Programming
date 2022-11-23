using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// id заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>        
        private readonly string _orderCreationDate;

        /// <summary>
        /// Адрес доставки заказа.
        /// </summary>
        private string _deliveryAddress;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Общая стоимость заказа.
        /// </summary>
        private double _totalCost;

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Возвращает и задает адрес доставки заказа.
        /// </summary>
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// Возвращает Id заказа.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public string OrderCreationDate { get; set; }

        /// <summary>
        /// Возвращает и задает список товаров заказа.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает общую стоимость заказа.
        /// </summary>
        public double TotalCost
        {
            get
            {
                double sum = 10.0;

                if (Items.Count == 0)
                {
                    return sum;
                }

                foreach (var item in Items)
                {
                    sum += item.Cost;
                }

                return sum;
            }
        }

        public Order()
        {
            Id = IdGenerator.GetIdNext();
            Items = new List<Item>();
            OrderStatus = OrderStatus.New;
        }
    }
}
