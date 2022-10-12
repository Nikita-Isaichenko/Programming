using ObjectOrientedPractics.Services;


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
            get { return _name; }
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
