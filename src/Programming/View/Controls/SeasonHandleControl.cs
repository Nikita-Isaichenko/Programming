using Programming.Model.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Programming.View.Controls
{
    public partial class SeasonHandleControl : UserControl
    {     
        public delegate void SeasonChanged(Image image);

        public event SeasonChanged SeasonChange;

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
            switch (SeasonComboBox.SelectedItem.ToString())
            {
                case "Winter":
                    SeasonChange?.Invoke(Properties.Resources.Winter);
                    break;
                case "Spring":
                    SeasonChange?.Invoke(Properties.Resources.Spring);
                    break;
                case "Autumn":
                    SeasonChange?.Invoke(Properties.Resources.Autumn);
                    break;
                case "Summer":
                    SeasonChange?.Invoke(Properties.Resources.Summer);
                    break;
            }
        }                        
    }
}
