using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAppEvent
{
    public partial class EventForm : Form
    {
        private Contact _contact = new Contact();

        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;

                _contact.FullNameChange += FullName_Changed;
                _contact.PhoneNumberChange += PhoneNumber_Changed;
                _contact.AddressChange += Address_Changed;
            }
        }

        public EventForm()
        {
            InitializeComponent();
        }

        private void FullName_Changed(object obj, ContactEventsArgs e)
        {
            FullNameTextBox.Text = e.FullName;
        }

        private void PhoneNumber_Changed(object obj, ContactEventsArgs e)
        {
            PhoneNumberTextBox.Text = e.PhoneNumber;
        }

        private void Address_Changed(object obj, ContactEventsArgs e)
        {
            AddressTextBox.Text = e.Address;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.FullName = FullNameTextBox.Text;
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.PhoneNumber = PhoneNumberTextBox.Text;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.Address = AddressTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

            _contact.FullNameChange -= FullName_Changed;
            _contact.PhoneNumberChange -= PhoneNumber_Changed;
            _contact.AddressChange -= Address_Changed;

            Dispose();
        }
    }
}
