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
        public delegate void MethodContainer(Image image);

        public event MethodContainer PictureSelected;

        public SeasonHandleControl()
        {
            InitializeComponent();

            //OnGoButtonClick += A;


            foreach (Enum valueSeason in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(valueSeason);
            }
        }
               
        private void GoButton_Click(object sender, EventArgs e)
        {

            switch (SeasonComboBox.SelectedItem.ToString())
            {
                case "Winter":
                    PictureSelected?.Invoke(Properties.Resources.Winter);
                    break;
                case "Spring":
                    PictureSelected?.Invoke(Properties.Resources.Spring);
                    break;
                case "Autumn":
                    PictureSelected?.Invoke(Properties.Resources.Autumn);
                    break;
                case "Summer":
                    PictureSelected?.Invoke(Properties.Resources.Summer);
                    break;
            }
        }      
    }
}
