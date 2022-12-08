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
            MainCustomersTab.Customers = _store.Customers;
            MainCartsTab.Items = _store.Items;
            MainCartsTab.Customers = _store.Customers;
            MainOrdersTab.Customers = _store.Customers;
            PointerDiscountControl.Customers = _store.Customers;
            PercentDiscountControl.Customers = _store.Customers;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializer.SaveToFile("Store", _store);
        }

        private void MainTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (MainTabControl.SelectedTab == CartsTabPage)
            {
                MainCartsTab.RefreshData();
            }

            if (MainTabControl.SelectedTab == OrdersTabPage)
            {
                MainOrdersTab.RefreshData();
            }

            if (MainTabControl.SelectedTab == MainDiscountTabPage)
            {
                PointerDiscountControl.RefreshData();
                PercentDiscountControl.RefreshData();
            }
        }
    }
}
