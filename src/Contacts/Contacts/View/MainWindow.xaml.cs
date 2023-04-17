using System.Windows;
using View.ViewModel;

namespace Contacts.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="MainWindow"/>.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            MainVM mainVM = new MainVM();
            DataContext = mainVM;
        }
    }
}
