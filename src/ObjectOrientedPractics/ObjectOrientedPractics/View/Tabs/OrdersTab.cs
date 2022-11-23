using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {       
        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Возвращает и задает список заказов;
        /// </summary>
        private List<Order> Orders { get; set; }

        /// <summary>
        /// текущий выбранный заказ.
        /// </summary>
        private Order _currentOrder;

        /// <summary>
        /// Создает экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {           
            InitializeComponent();

            addressControl1.ReadOnly = true;
            Customers = new List<Customer>();
            Orders = new List<Order>();

            foreach (Enum orderStatus in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(orderStatus);
            }
        }

        /// <summary>
        /// Обновляет данные в таблице заказов.
        /// </summary>
        private void UpdateOrders()
        {
            dataGridView1.Rows.Clear();

            if (Customers.Count == 0)
            {
                return;
            }

            foreach (var customer in Customers)
            {
                foreach (var order in customer.Orders)
                {
                    Orders.Add(order);
                    dataGridView1.Rows.Add(order.Id, order.OrderCreationDate, order.OrderStatus,
                        customer.FullName, order.DeliveryAddress.AddressToString(), order.TotalCost);
                }
            }            
        }

        /// <summary>
        /// Очищает данные в текстбоксах выбранного заказа.
        /// </summary>
        private void ClearSelectedOrder()
        {
            IdTextBox.Clear();
            CreatedTextBox.Clear();
            addressControl1.Clear();
            StatusComboBox.SelectedIndex = -1;
            CostLabel.Text = "0 руб";
            ItemsListBox.Items.Clear();
            StatusComboBox.Enabled = false;
            _currentOrder = null;
        }

        /// <summary>
        /// Обновляет данные вкладки при переходе на нее.
        /// </summary>
        public void RefreshData()
        {
            ClearSelectedOrder();
            UpdateOrders();
        }

        /// <summary>
        /// Обновляет информацию о выбранном заказе.
        /// </summary>
        /// <param name="id"></param>
        private void UpdateSelectedOrders(int id)
        {
            ClearSelectedOrder();

            StatusComboBox.Enabled = true;
            double sum = 0.0;

            _currentOrder = Orders.Find(order => order.Id == id);

            IdTextBox.Text = _currentOrder.Id.ToString();
            CreatedTextBox.Text = _currentOrder.OrderCreationDate;
            StatusComboBox.SelectedItem = _currentOrder.OrderStatus;
            addressControl1.Address = _currentOrder.DeliveryAddress;
            
            foreach (var item in _currentOrder.Items)
            {
                ItemsListBox.Items.Add(item.Name);
                sum += item.Cost;
            }

            CostLabel.Text = $"{sum} руб";
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 ||
                dataGridView1.SelectedCells[0].FormattedValue.ToString() == "") 
                return;

            UpdateSelectedOrders(Convert.ToInt32(dataGridView1.SelectedCells[0].FormattedValue));
            
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex == -1) return;           

            int index = dataGridView1.CurrentCell.RowIndex;

            _currentOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedIndex;
            dataGridView1.Rows[index].Cells[2].Value = (OrderStatus)StatusComboBox.SelectedIndex;
        }
    }
}
