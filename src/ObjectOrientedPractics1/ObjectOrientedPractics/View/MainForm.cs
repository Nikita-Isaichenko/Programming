using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;


namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Предоставляет данные в списках.
        /// </summary>
        private Store _store;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {           
            if (Serializer.IsFile("Store"))
            {
                _store = Serializer.LoadFromFile("Store");
            }
            else
            {
                _store = new Store();
            }

            InitializeComponent();

            MainItemsTab.Items = _store.Items;
            MainCustomerTab.Customers = _store.Customers;
            //удали этот коммент, он для коммита
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializer.SaveToFile("Store", _store);
        }
    }
}
