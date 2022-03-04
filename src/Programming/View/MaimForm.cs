using System;
using System.Windows.Forms;
using Programming.Model;



namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Array value;
        private Weekday days;
        
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
            switch (EnumListBox.SelectedItem)
            {
                case View.Enums.Color:
                    value = Enum.GetValues(typeof(Model.Color));
                    break;
                case View.Enums.EducationalForm:
                    value = Enum.GetValues(typeof(EducationalForm));
                    break;
                case View.Enums.Genre:
                    value = Enum.GetValues(typeof(Genre));
                    break;
                case View.Enums.Manufacturers:
                    value = Enum.GetValues(typeof(Manufacturers));
                    break;
                case View.Enums.Season:
                    value = Enum.GetValues(typeof(Season));
                    break;
                case View.Enums.Weekday:
                    value = Enum.GetValues(typeof(Weekday));
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
            IntValueTextBox.Clear();
            IntValueTextBox.Text = ((int) ValueListBox.SelectedItem).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string text = TextBoxParsing.Text;
            int a;
            if (int.TryParse(text, out a)){
                WeekdayOutputLabel.Text = "Введите день недели!";
            }
            else if (Enum.TryParse(text, out days))
            {
                WeekdayOutputLabel.Text = $"Это день недели ({text} = {(int)Enum.Parse(typeof(Weekday), text)})";
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
