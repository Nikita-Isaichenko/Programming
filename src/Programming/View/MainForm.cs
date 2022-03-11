using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            foreach (Enum valueEnums in Enum.GetValues(typeof(Enums)))
            {
                EnumListBox.Items.Add(valueEnums);
            }

            foreach (Enum valueSeason in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(valueSeason);
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

            foreach (var valueEnums in value)
            {
                ValueListBox.Items.Add(valueEnums);
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int) ValueListBox.SelectedItem).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string text = ParsingTextBox.Text;           
            if (Enum.TryParse(text, out Weekday weekday))
            {
                WeekdayOutputLabel.Text = $"Это день недели ({text} = {(int) weekday})";
            }
            else
            {
                WeekdayOutputLabel.Text = "Нет такого дня недели";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            SeasonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (SeasonComboBox.SelectedItem)
            {
                case Season.Winter:
                    SeasonPictureBox.Image = Properties.Resources.Winter;
                    break;
                case Season.Spring:
                    SeasonPictureBox.Image = Properties.Resources.Spring;
                    break;
                case Season.Autumn:
                    SeasonPictureBox.Image = Properties.Resources.Autumn;
                    break;
                case Season.Summer:
                    SeasonPictureBox.Image = Properties.Resources.Summer;
                    break;
            }
        }       
    }
}
