using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
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

        private ContactVMFactory _contactVMFactory = new ContactVMFactory();

        private ContactVM _currentContact;

        private bool _isReadOnly = true;

        /// <summary>
        /// Возвращает и задает контакт.
        /// </summary>
        public ContactVM CurrentContact
        {
            get => _currentContact;
            set
            {
                _currentContact = value;

                if (_currentContact != null)
                {
                    IsReadOnly = true;
                }

                OnPropertyChanged(nameof(CurrentContact));
            }
        }

        public ContactVM TempContact { get; set; }

        public ObservableCollection<ContactVM> Contacts { get; private set; }
            = new ObservableCollection<ContactVM>();

        /// <summary>
        /// Возвращает команду для загрузки данных из файла.
        /// </summary>
        public ICommand LoadCommand { get; }


        /// <summary>
        /// Возвращает команду для сохранения данных в файл.
        /// </summary>
        public ICommand SaveCommand { get; }

        public ICommand AddCommand { get; }

        public ICommand ApplyCommand { get; }

        public bool IsReadOnly
        {
            get => _isReadOnly;
            private set
            {
                _isReadOnly = value;
                OnPropertyChanged(nameof(IsReadOnly));
            }
        }

        public bool IsVisible { get; set; }

        public VisibleConverter VisibleConverter { get; private set; }


        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            SaveCommand = new RelayCommand(SaveContact);
            LoadCommand = new RelayCommand(LoadContact);
            AddCommand = new RelayCommand(AddContact);
            ApplyCommand = new RelayCommand(ApplyContact);

            VisibleConverter = new VisibleConverter();

            Contacts.Add(_contactVMFactory.MakeContactVM());
            Contacts.Add(_contactVMFactory.MakeContactVM());
            Contacts.Add(_contactVMFactory.MakeContactVM());
            Contacts.Add(_contactVMFactory.MakeContactVM());
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
        /// Загружает данные о контакте из файла.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void LoadContact(object parameter)
        {

        }

        /// <summary>
        /// Сохраняет данные о контакте в файл.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void SaveContact(object parameter)
        {

        }

        private void ApplyContact(object parameter)
        {

        }

        private void AddContact(object parameter)
        {
            CurrentContact = null;
            IsReadOnly = false;

            
        }

        /// <summary>
        /// Событие изменения свойтства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
