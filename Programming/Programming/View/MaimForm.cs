using System;

using System.Windows.Forms;
using Programming.Model;


namespace Programming.View
{
    public partial class MaimForm : Form
    {
        public Array value;
        
        public MaimForm()
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
    }
}
