using ObjectOrientedPractics.Services;
using System;

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
                if(value != _index)
                {
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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

                if (value != _country)
                {
                    _country = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (value != _city)
                {
                    _city = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (value != _street)
                {
                    _street = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает строение.
        /// Не более 10 символов.
        /// </summary>
        public string House
        {
            get
            {
                return _building;
            }
            set
            {
                Validator.AssertEmptyValue(value, nameof(House));
                Validator.AssertLengthString(value, 10, nameof(House));
                if (value != _building)
                {
                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (value != _apartment)
                {
                    _apartment = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
            House = "None";
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
            House = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Возвращает адрес в виде строки.
        /// </summary>
        /// <returns></returns>
        public string AddressToString()
        {
            return $"{Index} {Country}, {City}, {Street}, {House}, {Apartment}";
        }

        /// <summary>
        /// Событие изменение адреса.
        /// </summary>
        public event EventHandler<EventArgs> AddressChanged;
    }
}
