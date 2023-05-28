using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using View.ViewModel;

namespace View.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Регистрирует свойство зависимости для SelectedContact.
        /// </summary>
        public static readonly DependencyProperty SelectedContactProperty =
            DependencyProperty.Register("SelectedContact", typeof(ContactVM),
            typeof(ContactControl), new UIPropertyMetadata(null));

        /// <summary>
        /// Возвращает и задаёт выбранный контакт.
        /// </summary>
        public ContactVM SelectedContact
        {
            get => (ContactVM)GetValue(SelectedContactProperty);
            set => SetValue(SelectedContactProperty, value);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactControl"/>.
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Проводит валидацию данных, которые вводятся в textbox.
        /// </summary>
        /// <param name="sender">Объект.</param>
        /// <param name="e">Аргументы.</param>
        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var pattern = @"[\+\-\(\)\d]";
            if (!Regex.IsMatch(e.Text, pattern))
                e.Handled = true;
        }

        /// <summary>
        /// Запрещает копирование в textbox символов, не прошедших проверку.
        /// </summary>
        /// <param name="sender">Объект.</param>
        /// <param name="e">Аргументы.</param>
        private void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                var input = (string)e.DataObject.GetData(typeof(string));
                var pattern = @"[\+\-\(\)\d]";

                if (!Regex.IsMatch(input, pattern))
                    e.CancelCommand();
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}
