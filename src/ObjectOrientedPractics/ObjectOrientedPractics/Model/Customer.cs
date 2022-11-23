using ObjectOrientedPractics.Services;
using System.Collections.Generic;
using System.Windows.Documents;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _firstName = "";

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _lastName = "";

        /// <summary>
        /// Отчество.
        /// </summary>
        private string _fatherName = "";

        /// <summary>
        /// Полное имя покупателя
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес доставки до покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Возвращает и задает уникальный идентификатор покупателя.
        /// </summary>
        public int Id { get; private set; }      

        /// <summary>
        /// Возвращает и задает фамилию.
        /// Не больше 66 символов.
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                Validator.AssertLengthString(value, 66, nameof(LastName));
                _lastName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает имя.
        /// Не больше 66 символов.
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                Validator.AssertLengthString(value, 66, nameof(FirstName));
                _firstName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает отчество.
        /// Не больше 66 символов.
        /// </summary>
        public string FatherName
        {
            get
            {
                return _fatherName;
            }
            set
            {
                Validator.AssertLengthString(value, 66, nameof(FatherName));
                _fatherName = value;
            }
        }
        

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// Не больше 200 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                if (_firstName != "" || _lastName != "" || _fatherName != "")
                {
                    FullName = $"{FirstName} {LastName} {FatherName}";
                }
                return _fullName;
            }
            set
            {
                Validator.AssertEmptyValue(value, nameof(FullName));
                Validator.AssertLengthString(value, 200, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// Не больше 500 символов.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задает корзину покупателя.
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Возвращает и задает список заказов.
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Cоздает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">ФИО.</param>
        /// <param name="address">Адрес.</param>
        public Customer(string fullName, Address address)
        {
            Id = IdGenerator.GetIdNext();
            FullName = fullName;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// Cоздает экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            Id = IdGenerator.GetIdNext();
            FullName = "None";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
        }
    }
}
