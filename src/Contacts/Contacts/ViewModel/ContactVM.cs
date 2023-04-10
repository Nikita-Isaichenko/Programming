using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;

namespace View.ViewModel
{
    class ContactVM : INotifyPropertyChanged
    {
        public Contact Contact { get; set; }

        public string FirstName
        {
            get => Contact.FirstName;
            set
            {
                Contact.FirstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string Phone
        {
            get => Contact.Phone;
            set
            {
                Contact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        public string Email
        {
            get => Contact.Email;
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public ContactVM(Contact contact)
        {
            Contact = contact;
        }

        /// <summary>
        /// Вызывает событие при вызове.
        /// </summary>
        /// <param name="prop">Свойство, вызвавшее событие.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
