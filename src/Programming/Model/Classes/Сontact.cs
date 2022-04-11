using System;

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
                try
                {
                    _name = AssertStringContainsOnlyLetters(value);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message + "Name.");
                }
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
                try
                {
                    _surname = AssertStringContainsOnlyLetters(value);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message + "Surname.");
                }
            }
        }
        

        private string AssertStringContainsOnlyLetters(string value)
        {
            string lowercaseWord = value.ToLower();

            for (int i = 0; i < lowercaseWord.Length; i++)
            {
                if (!((lowercaseWord[i] >= 'a') && (lowercaseWord[i] <= 'z')))
                {
                    throw new ArgumentException("Invalid value in the field: ");
                }
            }
            return value;
        }
    }
}
