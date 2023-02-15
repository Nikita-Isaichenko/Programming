using System;


namespace TestAppEvent
{
    public class Contact
    {
        private string _fullName;

        private string _phoneNumber;

        private string _address;

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (value != null)
                {
                    if (value != _fullName)
                    {
                        var args = new ContactEventsArgs();

                        args.FullName = value;
                        
                        _fullName = value;
                        FullNameChange?.Invoke(this, args);
                    }
                }
                
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value != null)
                {
                    if (value != _phoneNumber)
                    {
                        var args = new ContactEventsArgs()
                        {
                            PhoneNumber = value
                        };
                        _phoneNumber = value;
                        PhoneNumberChange?.Invoke(this, args);
                    }
                }
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value != null)
                {


                    if (value != _address)
                    {
                        var args = new ContactEventsArgs()
                        {
                            Address = value
                        };
                        _address = value;
                        AddressChange?.Invoke(this, args);
                    }
                }
            }
        }

        public event EventHandler<ContactEventsArgs> FullNameChange;

        public event EventHandler<ContactEventsArgs> PhoneNumberChange;

        public event EventHandler<ContactEventsArgs> AddressChange;
    }
}
