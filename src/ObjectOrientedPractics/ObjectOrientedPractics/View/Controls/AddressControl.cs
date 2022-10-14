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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Экземпляр класса <see cref="Model.Address"/>
        /// </summary>
        private Address _address;

        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                UpdateTextBoxes();
            }
        }

        public AddressControl()
        {
            InitializeComponent();            
        }

        private void UpdateTextBoxes()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PostIndexTextBox.BackColor = AppColor.NormalBackColor;
                _address.Index = Convert.ToInt32(PostIndexTextBox.Text);
            }
            catch
            {
                PostIndexTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = AppColor.NormalBackColor;
                _address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = AppColor.NormalBackColor;
                _address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = AppColor.NormalBackColor;
                _address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = AppColor.NormalBackColor;
                _address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = AppColor.NormalBackColor;
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void UpdateTextBoxes()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PostIndexTextBox.BackColor = AppColor.NormalBackColor;
                _address.Index = Convert.ToInt32(PostIndexTextBox.Text);
            }
            catch
            {
                PostIndexTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = AppColor.NormalBackColor;
                _address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = AppColor.NormalBackColor;
                _address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = AppColor.NormalBackColor;
                _address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = AppColor.NormalBackColor;
                _address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = AppColor.NormalBackColor;
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }
    }
}
