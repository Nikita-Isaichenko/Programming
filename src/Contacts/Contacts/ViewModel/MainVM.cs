using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    internal class MainVM : INotifyPropertyChanged
    {
        private ContactSerializer _serializer = new ContactSerializer();

        public Contact Contact { get; private set; } = new Contact();

        public string? Name
        {
            get => Contact.Name;
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string? PhoneNumber
        {
            get => Contact.PhoneNumber;
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public string? Email
        {
            get => Contact.Email;
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public ICommand Load
        {
            get
            {               
                return new RelayCommand((obj) =>
                {
                    var contact = _serializer.Load();
                    Name = contact.Name;
                    PhoneNumber = contact.PhoneNumber;
                    Email = contact.Email;
                });
            }
        }

        public ICommand Save
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    _serializer.Save(Contact);
                });
               
            }
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler? PropertyChanged;     
    }
}
