using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
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
    public partial class PriorityOrdersTab : UserControl
    {

        /// <summary>
        /// 
        /// </summary>
        private ItemFactory _item;

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem = null;

        /// <summary>
        /// Возвращает и задает приоритетный заказ.
        /// </summary>
        private PriorityOrder PriorityOrder { get; set; }

        private List<string> _valueOfString 
            = new List<string> {
                "None", "9:00-11:00", "11:00-13:00", "13:00-15:00", 
                "15:00-17:00", "17:00-19:00", "19:00-21:00" 
            };

        public PriorityOrdersTab()
        {
            InitializeComponent();

            _item = new ItemFactory();

            PriorityOrder = new PriorityOrder(DateTime.Now);

            foreach(var status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }

            DeliveryTimeComboBox.Items.AddRange(_valueOfString.ToArray());

            ItemsListBox.Items.AddRange(PriorityOrder.Items.ToArray());
            UpdateInfo();
        }

        /// <summary>
        /// ОБновляет информацию в текстовых полях.
        /// </summary>
        private void UpdateInfo()
        {
            Clear();

            CostLabel.Text = "0.0";
            IdTextBox.Text = PriorityOrder.Id.ToString();
            CreatedTextBox.Text = PriorityOrder.OrderCreationDate;

            DeliveryTimeComboBox.SelectedItem = PriorityOrder.DesiredDeliveryTime;

            StatusComboBox.SelectedItem = PriorityOrder.OrderStatus;
            PriorityOrdersTabAddressControl.Address = PriorityOrder.DeliveryAddress;
            ItemsListBox.Items.AddRange(PriorityOrder.Items.ToArray());
            CostLabel.Text = PriorityOrder.TotalCost.ToString();
        }

        /// <summary>
        /// Очищает данные в текстбоксах выбранного заказа.
        /// </summary>
        private void Clear()
        {
            IdTextBox.Clear();
            CreatedTextBox.Clear();
            PriorityOrdersTabAddressControl.Clear();
            StatusComboBox.SelectedIndex = -1;
            CostLabel.Text = "0.0";
            ItemsListBox.Items.Clear();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex == -1) return;

            PriorityOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeComboBox.SelectedIndex == -1) return;

            PriorityOrder.DesiredDeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _currentItem = _item.CreatItem();

            
            PriorityOrder.Items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);

            ItemsListBox.SelectedIndex = PriorityOrder.Items.Count - 1;
            CostLabel.Text = PriorityOrder.TotalCost.ToString();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0) return;

            int index = ItemsListBox.SelectedIndex;

            ItemsListBox.Items.RemoveAt(index);
            PriorityOrder.Items.RemoveAt(index);

            ItemsListBox.SelectedIndex = PriorityOrder.Items.Count > 0 ? 0 : -1;
            CostLabel.Text = PriorityOrder.TotalCost.ToString();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            PriorityOrder = null;
            Clear();

            PriorityOrder = new PriorityOrder(DateTime.Now);
            UpdateInfo();
            
        }
    }
}
