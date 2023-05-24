using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel, агрегирующий в себе класс <see cref="Model.Contact"/>
    /// </summary>
    public class ContactVM : ObservableValidator, INotifyPropertyChanged, ICloneable
    {
        /// <summary>
        /// Хранит значение, которое показывает, может ли этот контакт изменяться.
        /// </summary>
        private bool _isReadOnly;

        /// <summary>
        /// Возвращает и получает объект класса <see cref="Model.Contact"/>
        /// </summary>
        public Contact Contact;

        /// <summary>
        /// Возвращает и получает имя контакта.
        /// </summary>
        [Required(ErrorMessage = "User name not specified")]
        [MaxLength(
            10,
            ErrorMessage = "The length exceeds 100 characters"
            )]
        public string FirstName
        {
            get => Contact.FirstName;
            set
            {
                ValidateProperty(value);
                Contact.FirstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        /// <summary>
        /// Возвращает и получает телефон контакта.
        /// </summary>
        [Required(ErrorMessage = "Phone not specified")]
        [RegularExpression(
            @"^\+[1-9]\(\d{3}\)\d{3}-\d{2}-\d{2}$",
            ErrorMessage = "Invalid phone format"
            )]
        [MaxLength(
            100,
            ErrorMessage = "The length exceeds 100 characters"
            )]
        public string Phone
        {
            get => Contact.Phone;
            set
            {
                ValidateProperty(value);
                Contact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
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
            set
            {
                ValidateProperty(value);
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Возвращает и получает значение, которое показывает,
        /// может ли этот контакт изменяться.
        /// </summary>
        public bool IsReadOnly
        {
            get => _isReadOnly;
            set
            {
                _isReadOnly = value;
                OnPropertyChanged(nameof(IsReadOnly));
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact">Объект класса <see cref="Model.Contact"/>.</param>
        public ContactVM(Contact contact)
        {
            Contact = contact;
            IsReadOnly = true;
            ValidateAllProperties();
        }

        /// <summary>
        /// Вызывает событие при изменении свойств объекта.
        /// </summary>
        /// <param name="prop">Свойство, вызвавшее событие.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Создает клон объекта.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactVM"/>.</returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }

        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
