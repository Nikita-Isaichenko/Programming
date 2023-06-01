using System;

namespace Model.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Электронная почта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="phone">Номер телефона.</param>
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

        /// <summary>
        /// Создает клон объекта.
        /// </summary>
        /// <returns>Возвращает новый объект.</returns>
        public object Clone()
        {
            return new Contact(FirstName, Phone, Email);
        }
    }
}
