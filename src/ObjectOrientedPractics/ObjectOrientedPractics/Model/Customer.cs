using ObjectOrientedPractics.Services;


namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки до покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задает уникальный идентификатор покупателя.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// Не больше 200 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                Validator.AssertEmptyValue(value, nameof(FullName));
                Validator.AssertLengthString(value, 200, nameof(FullName));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// Не больше 500 символов.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validator.AssertEmptyValue(value, nameof(Address));
                Validator.AssertLengthString(value, 500, nameof(Address));
                _address = value;
            }
        }

        public Customer(string fullName, string address)
        {
            Id = IdGenerator.GetIdNext();
            FullName = fullName;
            Address = address;
        }


    }
}
