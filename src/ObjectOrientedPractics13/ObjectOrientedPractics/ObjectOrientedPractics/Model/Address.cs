using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о адресе.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Строение.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс.
        /// Должен состоять из 6 символов.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                Validator.AssertCountSymbols(value, 6, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну.
        /// Не более 50 символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                Validator.AssertEmptyValue(value, nameof(Country));
                Validator.AssertLengthString(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город.
        /// Не более 50 символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                Validator.AssertEmptyValue(value, nameof(City));
                Validator.AssertLengthString(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу.
        /// Не более 100 символов.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                Validator.AssertEmptyValue(value, nameof(Street));
                Validator.AssertLengthString(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает строение.
        /// Не более 10 символов.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                Validator.AssertEmptyValue(value, nameof(Building));
                Validator.AssertLengthString(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры.
        /// Не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                Validator.AssertEmptyValue(value, nameof(Apartment));
                Validator.AssertLengthString(value, 50, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "None";
            City = "None";
            Street = "None";
            Building = "None";
            Apartment = "None";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Строение.</param>
        /// <param name="apartment">Номер квартиры.</param>
        public Address(int index, string country, string city,
                       string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
