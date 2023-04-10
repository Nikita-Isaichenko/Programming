    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Электронная почта.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Электронная почта.</param>
        public Contact(string firstName, string phone, string email)
        {
            FirstName = firstName;
            Phone = phone;
            Email = email;
        }

        /// <summary>
        /// Создает экзмемпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact() 
        { 

        }
    }
}
