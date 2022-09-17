using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товарах.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задает id товара.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает и задает название товара.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertEmptyValue(value, nameof(Name));
                Validator.AssertLengthString(value, 200, nameof(Name));
                //Validator.AssertValueInRange(value, 0, 100000, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о товаре.
        /// </summary>
        public string Info
        {
            get 
            { 
                return _info;
            }
            set
            {
                Validator.AssertLengthString(value, 1000, nameof(Info));
                _info = value;
            }
        }
        /// <summary>
        /// Возвращает и задает стоимость товара.
        /// </summary>
        public double Cost
        {
            get 
            { 
                return _cost;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        
        
        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Информация о товаре</param>
        /// <param name="cost">Стоимость товара.</param>
        public Item(string name, string info, double cost)
        {
            Id = IdGenerator.GetIdNext();
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
