﻿using System.Collections.ObjectModel;
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

        private ContactVMFactory _contactVMFactory = new ContactVMFactory();

        private ContactVM _currentContact;

        private bool _isReadOnly = true;

        private bool _isVisible = false;

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
                    IsVisible = false;
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

        public ICommand EditCommand { get; }
         
        public ICommand RemoveCommand { get; }

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

        public bool IsVisible
        {
            get 
            {
                return _isVisible;
            }
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
            SaveCommand = new RelayCommand(SaveContact);
            LoadCommand = new RelayCommand(LoadContact);
            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact);
            ApplyCommand = new RelayCommand(ApplyContact);
            RemoveCommand = new RelayCommand(RemoveContact, CanExecuteRemove);

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
            if (!Contacts.Contains(CurrentContact))
            {
                Contacts.Add(CurrentContact);
            }
            else
            {

            }

            IsVisible = false;
            IsReadOnly = true;
        }

        private void AddContact(object parameter)
        {
            CurrentContact = new ContactVM(new Contact());
            IsReadOnly = false;
            IsVisible = true;
        }

        private void EditContact(object parameter)
        { 
            IsReadOnly = false;
            IsVisible = true;
        }

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

        private bool CanExecuteRemove(object parameter)
        {
            return Contacts.Count > 0;
        }

        /// <summary>
        /// Событие изменения свойтства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
