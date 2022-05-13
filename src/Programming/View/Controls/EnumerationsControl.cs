using Programming.Model.Classes;
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
using Color = Programming.Model.Enums.Color;

namespace Programming.View.Controls
{
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();

            


            foreach (Enum valueEnums in Enum.GetValues(typeof(Enums)))
            {
                EnumListBox.Items.Add(valueEnums);
            }

            EnumListBox.SelectedIndex = 0;
        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();
            Array values;
            switch (EnumListBox.SelectedItem)
            {
                case View.Enums.Color:
                    values = Enum.GetValues(typeof(Color));
                    break;
                case View.Enums.EducationalForm:
                    values = Enum.GetValues(typeof(EducationForm));
                    break;
                case View.Enums.Genre:
                    values = Enum.GetValues(typeof(Genre));
                    break;
                case View.Enums.Manufacturers:
                    values = Enum.GetValues(typeof(Manufacturers));
                    break;
                case View.Enums.Season:
                    values = Enum.GetValues(typeof(Season));
                    break;
                case View.Enums.Weekday:
                    values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var valueEnums in values)
            {
                ValueListBox.Items.Add(valueEnums);
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValueListBox.SelectedItem).ToString();
        }

        public void PictureBox_UploadImagel(string season)
        {           
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (season)
            {
                case "Winter":
                    PictureBox.Image = Properties.Resources.Winter;
                    break;
                case "Spring":
                    PictureBox.Image = Properties.Resources.Spring;
                    break;
                case "Autumn":
                    PictureBox.Image = Properties.Resources.Autumn;
                    break;
                case "Summer":
                    PictureBox.Image = Properties.Resources.Summer;
                    break;
            }
        }       
    }
}
