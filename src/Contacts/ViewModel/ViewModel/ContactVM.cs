using CommunityToolkit.Mvvm.ComponentModel;
using Model.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace ViewModel.ViewModel
{
    /// <summary>
    /// ViewModel, агрегирующий в себе класс <see cref="Model.Model.Contact"/>.
    /// </summary>
    public class ContactVM : ObservableValidator, ICloneable
    {
        /// <summary>
        /// Возвращает объект класса <see cref="Model.Contact"/>.
        /// </summary>
        public Contact Contact { get; }

        /// <summary>
        /// Возвращает и получает имя контакта.
        /// </summary>
        [Required(ErrorMessage = "User name not specified")]
        [MaxLength(
            100,
            ErrorMessage = "The length exceeds 100 characters"
            )]
        public string FirstName
        {
            get => Contact.FirstName;
            set => SetProperty(Contact.FirstName,
                               value,
                               Contact,
                               (contact, firstName) => Contact.FirstName = firstName,
                               true);
        }

        /// <summary>
        /// Возвращает и получает телефон контакта.
        /// </summary>
        [Required(ErrorMessage = "Phone not specified")]
        [RegularExpression(
            @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$",
            ErrorMessage = "Invalid phone format"
            )]
        [MaxLength(
            100,
            ErrorMessage = "The length exceeds 100 characters"
            )]
        public string Phone
        {
            get => Contact.Phone;
            set => SetProperty(Contact.Phone,
                               value,
                               Contact,
                               (contact, phone) => Contact.Phone = phone,
                               true); 
        }

        /// <summary>
        /// Возвращает и получает электронную почту контакта.
        /// </summary>
        [Required(ErrorMessage = "Email not specified")]
        [MaxLength(
            100,
            ErrorMessage = "The length exceeds 100 characters"
            )]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email
        {
            get => Contact.Email;
            set => SetProperty(Contact.Email,
                               value,
                               Contact,
                               (contact, email) => Contact.Email = email,
                               true);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact">Объект класса <see cref="Model.Contact"/>.</param>
        public ContactVM(Contact contact)
        {
            Contact = contact;
            ValidateAllProperties();
        }

        /// <summary>
        /// Создает клон объекта.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactVM"/>.</returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }
    }
}
