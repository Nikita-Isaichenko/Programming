﻿using ObjectOrientedPractics.Services;


namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товарах.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _description;

        /// <summary>
        /// Модель машины.
        /// </summary>
        private string _carModel = "";

        /// <summary>
        /// Год выпуска машины.
        /// </summary>
        private string _carYear = "";

        /// <summary>
        /// цвет машины.
        /// </summary>
        private string _carColor = "";

        /// <summary>
        /// Бренд машины.
        /// </summary>
        private string _carBrand = "";

        /// <summary>
        /// Стоимость товара
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задает id товара.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Возвращает и задает название товара.
        /// Не больше 200 символов.
        /// </summary>
        public string Name
        {
            get 
            {
                if (_carBrand != "") 
                    Name = CarBrand;

                return _name;
            }
            set
            {
                Validator.AssertEmptyValue(value, nameof(Name));
                Validator.AssertLengthString(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о товаре.
        /// Не больше 1000 символов.
        /// </summary>
        public string Description
        {
            get 
            {
                if (_carModel != "" || _carColor != "" || _carYear != "")
                {
                    Description = $"{_carModel} {_carColor} {_carYear}";
                }
                
                return _description;
            }
            set
            {
                Validator.AssertLengthString(value, 1000, nameof(Description));
                _description = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара.
        /// От 0 до 100000.
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
        /// Возвращает и задает модель машины.
        /// </summary>
        public string CarModel
        {
            get
            {
                return _carModel;
            }
            set
            {
                Validator.AssertLengthString(value, 333, nameof(CarModel));
                _carModel = value;
            }
        }
        
        /// <summary>
        /// Возвращает и задает год выпуска машины.
        /// </summary>
        public string CarYear
        {
            get
            {
                return _carYear;
            }
            set
            {
                Validator.AssertLengthString(value, 333, nameof(CarYear));
                _carYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цвет машины.
        /// </summary>
        public string CarColor
        {
            get
            {
                return _carColor;
            }
            set
            {
                Validator.AssertLengthString(value, 333, nameof(CarColor));
                _carColor = value;
            }
        }

        /// <summary>
        /// Возвращает и задает бренд машины.
        /// </summary>
        public string CarBrand
        {
            get
            {
                return _carBrand;
            }
            set
            {
                Validator.AssertLengthString(value, 200, nameof(CarBrand));
                _carBrand = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="description">Информация о товаре</param>
        /// <param name="cost">Стоимость товара.</param>
        public Item(string name, string description, double cost)
        {
            Id = IdGenerator.GetIdNext();
            Name = name;
            Description = description;
            Cost = cost;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            Id = IdGenerator.GetIdNext();
        }
    }
}
