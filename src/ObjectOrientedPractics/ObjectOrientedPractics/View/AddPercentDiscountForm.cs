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

namespace ObjectOrientedPractics.View
{
    public partial class AddPercentDiscountForm : Form
    {
        internal PercentDiscount PercentDiscount { get;set; }

        public AddPercentDiscountForm()
        {
            InitializeComponent();

            foreach(var category in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == -1)
            {
                return;
            }

            PercentDiscount = new PercentDiscount((Category)CategoryComboBox.SelectedIndex);

            Close();            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
