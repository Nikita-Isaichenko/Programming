using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Contact
    {
        public string? Name { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public Contact() 
        { 

        }

    }
}
