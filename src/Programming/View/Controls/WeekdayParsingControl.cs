using Programming.Model.Enums;
using System;
using System.Windows.Forms;


namespace Programming.View.Controls
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string text = ParsingTextBox.Text;

            if (Enum.TryParse(text, out Weekday weekday))
            {
                WeekdayOutputLabel.Text = $"Это день недели ({text} = {(int)weekday})";
            }
            else
            {
                WeekdayOutputLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
