using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using View.Model;
using View.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главное окна.
    /// </summary>
    public partial class MainVM : ObservableObject
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
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditContactCommand), nameof(RemoveContactCommand))]
        private ContactVM _currentContact;

        /// <summary>
        /// Содержит логику, которая вызывается при изменении текущего контакта.
        /// </summary>
        /// <param name="value">Текущий контакт.</param>
        partial void OnCurrentContactChanged(ContactVM value)
        {
            if (!IsEdit && Contacts.Contains(value))
            {
                CurrentIndex = Contacts.IndexOf(value);
            }

            if (!IsApply)
            {
                IsApply = true;
            }
        }

        /// <summary>
        /// Поле, хранящее значение для свойства окна IsReadOnly.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Поле, хранящее значение для свойства окна Visibility.
        /// </summary>
        [ObservableProperty]
        private bool _isVisible = false;

        /// <summary>
        /// Поле, хранящее значение, которое говорит о том, была ли нажата кнопка Apply.
        /// </summary>
        private bool _isApply = false;

        /// <summary>
        /// Возвращает и задает индекс текущего контакты.
        /// </summary>
        public int CurrentIndex { get; set; }

        /// <summary>
        /// Возвращает список контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; private set; }
            = new ObservableCollection<ContactVM>();

        /// <summary>
        /// Возвращает и задает, включен ли редактор контактов.
        /// </summary>
        public bool IsEdit { get; set; }

        /// <summary>
        /// Возвращает и задает, подтверждены ли изменения.
        /// </summary>
        public bool IsApply
        {
            get => _isApply;
            set
            {
                _isApply = value;

                if (value)
                {
                    IsEdit = false;
                    IsVisible = false;
                    IsReadOnly = true;
                }
                else
                {
                    IsVisible = true;
                    IsReadOnly = false;
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = _serializer.Load();
        }

        /// <summary>
        /// Проверяет, есть ли соединение с интернетом.
        /// </summary>
        /// <returns></returns>
        public bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Принимает добавление/изменение контакта.
        /// </summary>
        [RelayCommand]
        private void ApplyContact()
        {
            if (!IsEdit)
            {
                Contacts.Add(CurrentContact);
                CurrentContact = null;
                CurrentContact = Contacts[Contacts.Count - 1];
            }
            else
            {
                Contacts[CurrentIndex] = CurrentContact;
                CurrentContact = Contacts[CurrentIndex];
            }

            IsApply = true;
        }

        /// <summary>
        /// Добавляет контакт.
        /// </summary>
        [RelayCommand]
        private void AddContact()
        {
            CurrentContact = new ContactVM(new Contact());

            IsApply = false;
        }

        /// <summary>
        /// Генерирует контакты.
        /// </summary>
        [RelayCommand]
        private void AutoGenerationContact()
        {
            if (CheckForInternetConnection())
            {
                var tempContact = _contactVMFactory.MakeContactVM();
                Contacts.Add(tempContact);
                CurrentContact = tempContact;
            }
            else
            {
                MessageBox.Show("Соединение с сервером потеряно",
                                "Ошибка",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Изменяет контакт.
        /// </summary> 
        [RelayCommand(CanExecute = nameof(CanExecuteEdit))]
        private void EditContact()
        {
            IsEdit = true;

            var tempContact = CurrentContact;

            CurrentContact = null;
            CurrentContact = (ContactVM?)tempContact.Clone();

            IsApply = false;
        }

        /// <summary>
        /// Определяет возможность выполнения команды <see cref="EditContact"/>.
        /// </summary>
        private bool CanExecuteEdit()
        {
            return Contacts.Count > 0 && CurrentContact != null;
        }

        /// <summary>
        /// Удаляет контакт.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanExecuteRemove))]
        private void RemoveContact()
        {            
            if (Contacts.Count == 1)
            {
                Contacts.Remove(CurrentContact);
            }
            else if (CurrentIndex < Contacts.Count - 1)
            {
                Contacts.Remove(CurrentContact);
                CurrentContact = Contacts[CurrentIndex];
            }
            else
            {
                Contacts.Remove(CurrentContact);
                CurrentContact = Contacts[CurrentIndex - 1];
            }
        }

        /// <summary>
        /// Определяет возможность выполнения команды <see cref="RemoveContact"/>.
        /// </summary>
        private bool CanExecuteRemove()
        {
            return Contacts.Count > 0 && CurrentContact != null;
        }

        /// <summary>
        /// Сохраняет список контактов.
        /// </summary>
        [RelayCommand]
        private void SaveContacts()
        {
            _serializer.Save(Contacts);
        }
    }
}
