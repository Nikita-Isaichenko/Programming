using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Класс содержащий данные о контактах человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Телефонный номер.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и задает номер телефона человека. Должен состоять только из цифр.
        /// Должен состоять из одиннадцати цифр.
        /// </summary>
        public string PhoneNumber
        {
            get 
            { 
                return _phoneNumber;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("Некорректная длина номера телефона");
                }
                if (!long.TryParse(value, out long result))
                {
                    throw new ArgumentException("Некорректные символы в номере телефона");
                }
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает и задает имя человека.
        /// Должен состоять только из букв латинского алфавита.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLettersEnglish(value, nameof(Name));
                _name = value;
                
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию человека. 
        /// Должен состоять только из букв латинского алфавита.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {              
                Validator.AssertStringContainsOnlyLettersEnglish(value, nameof(Surname));
                _surname = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        /// <param name="phoneNumber">Номер телефона. Должен состоять только из одиннадцати цифр.</param>
        /// <param name="name">Имя. Должно состоять только из латинских символов.</param>
        /// <param name="surname">Фамилия. Должна состоять только из латинских символов.</param>
        public Contact(string phoneNumber, string name, string surname)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Surname = surname;
        }
    }
}
