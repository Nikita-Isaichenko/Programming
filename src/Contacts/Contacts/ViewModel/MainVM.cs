using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Media.Effects;
using View.Model;
using View.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главное окна.
    /// </summary>
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Сериализатор.
        /// </summary>
        private ContactSerializer _serializer = new ContactSerializer();

        /// <summary>
        /// Объект класса <see cref="ContactVMFactory"/>.
        /// </summary>
        private ContactVMFactory _contactVMFactory = new ContactVMFactory();

        /// <summary>
        /// Объект, хранящий текущий контакт.
        /// </summary>
        private ContactVM _currentContact;

        /// <summary>
        /// Переменная, хранящая значение для свойства окна IsReadOnly.
        /// </summary>
        private bool _isReadOnly = true;

        /// <summary>
        /// Переменная, хранящая значение для свойства окна Visibility.
        /// </summary>
        private bool _isVisible = false;

        /// <summary>
        /// Возвращает и задает текущий контакт.
        /// </summary>
        public ContactVM CurrentContact
        {
            get => _currentContact;
            set
            {
                if (_currentContact != null)
                {
                    IsReadOnly = true;
                    IsVisible = false;
                }

                if (TempContact != null)
                {
                    Contacts[Contacts.IndexOf(CurrentContact)] = TempContact;                   
                    TempContact = null;                                      
                }

                _currentContact = value;

                OnPropertyChanged(nameof(CurrentContact));
            }
        }

        /// <summary>
        /// Возвращает и задает временный контакт.
        /// </summary>
        public ContactVM TempContact { get; set; }

        /// <summary>
        /// Возвращает список контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; private set; }
            = new ObservableCollection<ContactVM>();

        /// <summary>
        /// Возвращает команду для сохранения данных в файл.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Возвращает команду для добавления контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Возвращает команду для изменения контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Возвращает команду для удаления контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Возвращает команду для принятия добавления/изменения контакта.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Возвращает свойство окна IsReadOnly.
        /// </summary>
        public bool IsReadOnly
        {
            get => _isReadOnly;
            private set
            {
                _isReadOnly = value;
                OnPropertyChanged(nameof(IsReadOnly));
            }
        }

        /// <summary>
        /// Возвращает свойство окна Visibility
        /// </summary>
        public bool IsVisible
        {
            get => _isVisible;
            private set
            {
                _isVisible = value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact, CanExecuteEdit);
            ApplyCommand = new RelayCommand(ApplyContact);
            RemoveCommand = new RelayCommand(RemoveContact, CanExecuteRemove);
            SaveCommand = new RelayCommand(SaveContacts);

            Contacts = _serializer.Load();
        }

        /// <summary>
        /// Вызывает событие при вызове.
        /// </summary>
        /// <param name="prop">Свойство, вызвавшее событие.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Принимает добавление/изменение контакта.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void ApplyContact(object parameter)
        {
            if (!Contacts.Contains(CurrentContact))
            {
                Contacts.Add(CurrentContact);
            }
            else
            {
                TempContact = null;
            }

            IsVisible = false;
            IsReadOnly = true;
        }

        /// <summary>
        /// Добавляет контакт.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void AddContact(object parameter)
        {
            CurrentContact = new ContactVM(new Contact());

            IsReadOnly = false;
            IsVisible = true;
        }

        /// <summary>
        /// Изменяет контакт.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void EditContact(object parameter)
        {
            TempContact = (ContactVM)CurrentContact.Clone();

            IsReadOnly = false;
            IsVisible = true;
        }

        /// <summary>
        /// Определяет возможность выполнения команды <see cref="EditCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private bool CanExecuteEdit(object parameter)
        {
            return Contacts.Count > 0 && CurrentContact != null;
        }

        /// <summary>
        /// Удаляет контакт.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void RemoveContact(object parameter)
        {
            var contactIndex = Contacts.IndexOf(CurrentContact);
            
            if (Contacts.Count == 1)
            {
                Contacts.RemoveAt(contactIndex);
            }
            else if (contactIndex < Contacts.Count - 1)
            {
                Contacts.RemoveAt(contactIndex);
                CurrentContact = Contacts[contactIndex];
            }
            else
            {
                Contacts.RemoveAt(contactIndex);
                CurrentContact = Contacts[contactIndex - 1];
            }                      
        }

        /// <summary>
        /// Определяет возможность выполнения команды <see cref="RemoveCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private bool CanExecuteRemove(object parameter)
        {
            return Contacts.Count > 0 && CurrentContact != null;
        }

        /// <summary>
        /// Сохраняет список контактов.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void SaveContacts(object parameter)
        {
            _serializer.Save((ObservableCollection<ContactVM>)parameter);
        }

        /// <summary>
        /// Событие изменения свойтства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
