using ObjectOrientedPractics.Services;
using System;

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

                if (value != _name)
                {
                    _name = value;
                    NameChanged?.Invoke(this, EventArgs.Empty);

                }
                
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

                if (value != _description)
                {
                    _description = value;
                    InfoChanged?.Invoke(this, EventArgs.Empty);
                }
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

                if (value != _cost)
                {
                    _cost = value;
                    CostChanged?.Invoke(this, EventArgs.Empty);
                }
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
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="description">Информация о товаре</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string description, double cost, Category category)
        {
            Id = IdGenerator.GetIdNext();
            Name = name;
            Description = description;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            Id = IdGenerator.GetIdNext();
            Name = "None";
            Description = "None";
            Cost = 0;
            Category = Category.None;
        }

        /// <summary>
        /// Событие изменения названия.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;

        /// <summary>
        /// Событие изменения стоимости.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Событие изменения информации.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;
    }
}
