using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит логику обработки событий окна.
    /// </summary>
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Создает автоматически сгенерированого покупателя.
        /// </summary>
        private CustomerFactory _customerFactory;

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;

                if (Customers.Count != 0)
                {
                    foreach (var customer in Customers)
                    {
                        CustomersListBox.Items.Add(customer.FullName);
                    }

                    CustomersListBox.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="CustomerTab"/>
        /// </summary>
        public CustomerTab()
        {
            InitializeComponent();

            _customerFactory = new CustomerFactory();
            
            CheckingAvailabilityItems();
        }

        /// <summary>
        /// Проверяет есть ли в списке товары.
        /// Если есть, то делает текстовые поля доступными.
        /// </summary>
        private void CheckingAvailabilityItems()
        {
            if (Customers.Count == 0)
            {
                FullNameTextBox.Enabled = false;

                ClearTextBoxes();
            }
            else
            {
                FullNameTextBox.Enabled = true;
            }
        }

        /// <summary>
        /// Очищает все текстовые поля.
        /// </summary>
        private void ClearTextBoxes()
        {          
            FullNameTextBox.Clear();
            IDTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию в текст боксах.
        /// </summary>
        /// <param name="customer"></param>
        private void UpdateTextBoxes(Customer customer)
        {           
            FullNameTextBox.Text = customer.FullName;
            IDTextBox.Text = customer.Id.ToString();
            AddressControl.Address = _currentCustomer.Address;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();

            Customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.FullName);

            CustomersListBox.SelectedIndex = Customers.Count - 1;

            UpdateTextBoxes(_currentCustomer);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0) return;

            int index = CustomersListBox.SelectedIndex;

            CustomersListBox.Items.RemoveAt(index);
            Customers.RemoveAt(index);

            CustomersListBox.SelectedIndex = Customers.Count > 0 ? 0 : -1;

            UpdateTextBoxes(_currentCustomer);
            CheckingAvailabilityItems();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = _customerFactory.CreatCustomer();

            Customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.FullName);

            CustomersListBox.SelectedIndex = Customers.Count - 1;

            UpdateTextBoxes(_currentCustomer);
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            _currentCustomer = Customers[index];           

            UpdateTextBoxes(_currentCustomer);
            CheckingAvailabilityItems();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullNameTextBox.BackColor = AppColor.NormalBackColor;
                _currentCustomer.FullName = FullNameTextBox.Text;
                CustomersListBox.
                    Items[Customers.IndexOf(_currentCustomer)] = _currentCustomer.FullName;
            }
            catch (Exception ex)
            {
                FullNameTextBox.BackColor = AppColor.ErrorBackColor;
                FullNameToolTip.SetToolTip(FullNameTextBox, ex.Message);

                if (Customers.Count == 0)
                    FullNameTextBox.BackColor = AppColor.NormalBackColor;
            }
        }
    }
}
