using System;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;

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
                    throw new ArgumentException("Некорректная длина номера телефона");
                }
                if (!int.TryParse(value, out int result))
                {
                    throw new ArgumentException("некорректные символы в номере телефона");
                }
                _phoneNumber = value;
            }
        }

        public string Name { get; set; }

        public string LastName { get; set; }
        
    }
}
