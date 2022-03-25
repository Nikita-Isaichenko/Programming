﻿using System;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;

        private string _name;

        private string _lastName;

        public Contact()
        {
        }

        public Contact(string phoneNumber, string name, string lastName)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            LastName = lastName;
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber.Length != 11)
                {
                    throw new ArgumentException("Invalid phone number length");
                }
                if (!int.TryParse(value, out int result))
                {
                    throw new ArgumentException("Invalid characters in phone number");
                }
                _phoneNumber = value;
            }
        }

        public string Name { get; set; }

        public string LastName { get; set; }
        
    }
}
