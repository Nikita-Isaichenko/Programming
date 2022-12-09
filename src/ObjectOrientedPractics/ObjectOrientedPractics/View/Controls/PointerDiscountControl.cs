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


namespace ObjectOrientedPractics.View.Controls
{
    public partial class PointerDiscountControl : UserControl
    {
        private PointsDiscount _pointsDiscount = new PointsDiscount();

        /// <summary>
        /// Возвращате и задает список товаров.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers { get; set; }

        private Customer _currentCustomer;

        public PointerDiscountControl()
        {
            InitializeComponent();

            DiscountLabel.Text = _pointsDiscount.Info;
            Customers = new List<Customer>();
        }

        private void UpdateFields()
        {
            if (Customers.Count == 0)
            {
                PriceLabel.Text = "0";
                return;
            }

            _currentCustomer = Customers[0];
            PriceLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        public void RefreshData()
        {
            UpdateFields();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            DiscountNumberLabel.Text = _pointsDiscount.Calculate(_currentCustomer.Cart.Items).ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            DiscountNumberLabel.Text = _pointsDiscount.Apply(_currentCustomer.Cart.Items).ToString();
            DiscountLabel.Text = _pointsDiscount.Info;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _pointsDiscount.Update(_currentCustomer.Cart.Items);
            DiscountLabel.Text = _pointsDiscount.Info;
        }
    }
}
