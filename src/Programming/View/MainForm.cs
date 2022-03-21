using System;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();

        private string[] colors;

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

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
            _rectangles = new Rectangle[5];
            colors = Enum.GetNames(typeof(Color));

            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(rnd.Next(0, 1000), rnd.Next(0, 1000),
                                               colors[rnd.Next(colors.Length)]);               
            }

            RectanglesListBox.DataSource = _rectangles;
            

            

            
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[indexRectangle];
            LenghtTextBox.Text = _currentRectangle.Length.ToString();  
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString(); 
        }
    }
}
