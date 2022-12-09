using ObjectOrientedPractics.Model.Intefaces;
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
    public partial class DIscountsControl : UserControl
    {
        private List<IDiscount> _discounts = new List<IDiscount>();

        /// <summary>
        /// Возвращает и задает список скидок.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<IDiscount> Discounts
        {
            get { return _discounts; }
            set
            {
                _discounts = value;

                UpdateDiscountsList();            
            }
        }

        public DIscountsControl()
        {
            InitializeComponent();

            
        }

        /// <summary>
        /// Обновляет списки скидок в ListBox.
        /// </summary>
        private void UpdateDiscountsList()
        {
            DiscountsListBox.Items.Clear();

            if (Discounts != null)
            {
                foreach (var discount in Discounts)
                {
                    DiscountsListBox.Items.Add(discount.Info);
                }
            }
            else
            {
                DiscountsListBox.Items.Clear();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPercentDiscountForm addForm = new AddPercentDiscountForm();
            
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                if (addForm.PercentDiscount != null)
                {
                    Discounts.Add(addForm.PercentDiscount);
                    UpdateDiscountsList();
                }
             
                addForm.Dispose();
            }         
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (DiscountsListBox.SelectedIndex == -1 || DiscountsListBox.SelectedIndex == 0) return;

            Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
            UpdateDiscountsList();
            DiscountsListBox.SelectedIndex = DiscountsListBox.Items.Count > 0 ? 0 : -1;
        }
    }
}
