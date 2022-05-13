using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();           

            foreach (Enum valueSeason in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(valueSeason);
            }
        }
        
        

        private void GoButton_Click(object sender, EventArgs e)
        {
            string Season = SeasonComboBox.SelectedItem.ToString();
            OnGoButtonClick(Season);       
        }

        public delegate void MethodContainer(string season);
        public event MethodContainer OnGoButtonClick;
        
    }
}
