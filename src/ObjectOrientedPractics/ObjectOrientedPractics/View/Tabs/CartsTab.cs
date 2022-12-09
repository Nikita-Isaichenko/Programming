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
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Хранит список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Хранит список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возращате и задает заказ.
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;

                if (_items != null)
                {
                    foreach (var item in Items)
                    {
                        ItemsListBox.Items.Add(item.Name);
                    }

                    ItemsListBox.SelectedIndex = -1;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;

                if (_customers != null)
                {
                    foreach (var customer in _customers)
                    {
                        CustomersComboBox.Items.Add(customer.FullName);
                    }                  

                    CustomersComboBox.SelectedIndex = -1;
                } 
            }
        }

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item CurrentItem { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();  
            
            
        }

        public void ClearItemsCart()
        {
            CurrentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            SumCostLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Обновляет лист бокс с корзиной.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateCartListBox(int index)
        {
            CartListBox.Items.Clear();
            DiscountsCheckedBox.Items.Clear();

            foreach (var item in CurrentCustomer.Cart.Items)
            {
                CartListBox.Items.Add(item.Name);
            }

            foreach (var discount in CurrentCustomer.Discounts)
            {
                DiscountsCheckedBox.Items.Add(discount.Info);
                DiscountsCheckedBox.SetItemChecked(DiscountsCheckedBox.Items.IndexOf(discount.Info), true);
            }

            CalculatedDiscount();

            CartListBox.SelectedIndex = index;
            SumCostLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Подсчитывает скидку и обновляет стоимость в Label.
        /// </summary>
        private void CalculatedDiscount()
        {
            double value = 0;

            foreach (var discount in CurrentCustomer.Discounts)
            {
                int index = DiscountsCheckedBox.Items.IndexOf(discount.Info);

                if (DiscountsCheckedBox.GetItemChecked(index))
                {
                    value += discount.Calculate(CurrentCustomer.Cart.Items);
                }
            }

            DiscountNumberLabel.Text = value.ToString();
            TotalPriceLabel.Text = (CurrentCustomer.Cart.Amount - value).ToString();
        }

        /// <summary>
        /// Применяет скидку к заказу.
        /// </summary>
        /// <returns>возвращает </returns>
        private double ApplyDiscount()
        {
            double value = 0;

            foreach (var discount in CurrentCustomer.Discounts)
            {
                int index = DiscountsCheckedBox.Items.IndexOf(discount.Info);

                if (DiscountsCheckedBox.GetItemChecked(index))
                {
                    value += discount.Calculate(CurrentCustomer.Cart.Items);
                }

                discount.Update(CurrentCustomer.Cart.Items);
            }

            return value;
        }

        /// <summary>
        /// Обвновляет данные при переходе на эту вкладку.
        /// </summary>
        public void RefreshData()
        {
            if (Items != null)
            {
                ItemsListBox.Items.Clear();

                foreach (var item in Items)
                {
                    ItemsListBox.Items.Add(item.Name);
                }

                ItemsListBox.SelectedIndex = -1;
            }

            if (Customers != null)
            {
                CustomersComboBox.Items.Clear();
                CustomersComboBox.Text = "";
                CartListBox.Items.Clear();
                SumCostLabel.Text = "0";

                foreach (var customer in _customers)
                {
                    CustomersComboBox.Items.Add(customer.FullName);
                }

                CustomersComboBox.SelectedIndex = -1;
            }

            CurrentCustomer = null;
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex == -1)
                return;

            CurrentCustomer = Customers[CustomersComboBox.SelectedIndex];

            UpdateCartListBox(-1);
        }

        private void AddCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1
                || CurrentCustomer == null)
                return;

            CurrentItem = Items[ItemsListBox.SelectedIndex];
            CurrentCustomer.Cart.Items.Add(CurrentItem);
            CartListBox.Items.Add(CurrentItem.Name);
            SumCostLabel.Text = CurrentCustomer.Cart.Amount.ToString();

            UpdateCartListBox(-1);
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1)
                return;

            CurrentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
            CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
            SumCostLabel.Text = CurrentCustomer.Cart.Amount.ToString();

            CartListBox.SelectedIndex = CartListBox.Items.Count > 0 ? 0 : -1;

            UpdateCartListBox(-1);
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearItemsCart();
            UpdateCartListBox(-1);
        }

        private void CreatOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null)
                return;

            if (CurrentCustomer.Cart.Items.Count == 0)
                return;

            if (CurrentCustomer.IsPriority)
            {
                Order = new PriorityOrder(DateTime.Now);
            }
            else
            {
                Order = new Order();
            }
           
            Order.Items.AddRange(CurrentCustomer.Cart.Items);
            Order.DeliveryAddress = CurrentCustomer.Address;
            this.Order.DiscountAmount = ApplyDiscount();
            CurrentCustomer.Orders.Add(Order);

            ClearItemsCart();
            UpdateCartListBox(-1);
        }

        private void DiscountsCheckedBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DiscountsCheckedBox.Items.Count == 0) return;

            CalculatedDiscount();
        }
    }
}
