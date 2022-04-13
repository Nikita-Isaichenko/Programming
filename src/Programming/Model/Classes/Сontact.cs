﻿using System;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;

        private string _name;

        private string _surname;

        public Contact()
        {
        }

        public Contact(string phoneNumber, string name, string surname)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Surname = surname;
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
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
    }
}
