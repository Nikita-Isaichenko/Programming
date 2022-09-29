﻿using ObjectOrientedPractics.Model;
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
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создает экземпляр класса <see cref="CustomerTab"/>
        /// </summary>
        public CustomerTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверяет есть ли в списке товары.
        /// Если есть, то делает текстовые поля доступными.
        /// </summary>
        private void CheckingAvailabilityItems()
        {
            if (_customers.Count == 0)
            {
                FullNameTextBox.Enabled = false;
                AddressTextBox.Enabled = false;

                ClearTextBoxes();
            }
            else
            {
                FullNameTextBox.Enabled = true;
                AddressTextBox.Enabled = true;
            }
        }

        /// <summary>
        /// Очищает все текстовые поля.
        /// </summary>
        private void ClearTextBoxes()
        {          
            FullNameTextBox.Clear();
            AddressTextBox.Clear();
            IDTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию в 
        /// </summary>
        /// <param name="customer"></param>
        private void UpdateTextBoxes(Customer customer)
        {           
            FullNameTextBox.Text = customer.FullName;
            AddressTextBox.Text = customer.Address;
            IDTextBox.Text = customer.Id.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("None", "None");

            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.FullName);

            CustomersListBox.SelectedIndex = _customers.Count - 1;

            UpdateTextBoxes(_currentCustomer);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0) return;

            int index = CustomersListBox.SelectedIndex;

            CustomersListBox.Items.RemoveAt(index);
            _customers.RemoveAt(index);

            CustomersListBox.SelectedIndex = _customers.Count > 0 ? 0 : -1;

            UpdateTextBoxes(_currentCustomer);
            CheckingAvailabilityItems();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            _currentCustomer = _customers[index];

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
                    Items[_customers.IndexOf(_currentCustomer)] = _currentCustomer.FullName;
            }
            catch (Exception ex)
            {
                FullNameTextBox.BackColor = AppColor.ErrorBackColor;
                FullNameToolTip.SetToolTip(FullNameTextBox, ex.Message);

                if (_customers.Count == 0)
                    FullNameTextBox.BackColor = AppColor.NormalBackColor;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.BackColor = AppColor.NormalBackColor;
                _currentCustomer.Address = AddressTextBox.Text;
            }
            catch (Exception ex)
            {
                AddressTextBox.BackColor = AppColor.ErrorBackColor;
                AddressToolTip.SetToolTip(AddressTextBox, ex.Message);

                if (_customers.Count == 0)
                    AddressTextBox.BackColor = AppColor.NormalBackColor;
            }
        }
    }
}
