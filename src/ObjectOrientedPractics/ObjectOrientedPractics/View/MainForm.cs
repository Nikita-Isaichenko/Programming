using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;
using System;
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

            MainItemsTab.ItemsChanged += ItemsTab_ItemsChanged;

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

        /// <summary>
        /// Обработчик события изменения товара во вкладке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            MainCartsTab.RefreshData();
            MainOrdersTab.RefreshData();
            PointerDiscountControl.RefreshData();
            PercentDiscountControl.RefreshData();
        }
    }
}
