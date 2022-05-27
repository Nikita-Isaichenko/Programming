using Programming.Model.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;
using Color = Programming.Model.Enums.Color;


namespace Programming.View.Controls
{
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="EnumerationsControl"/>
        /// </summary>
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

        /// <summary>
        /// Загружает картинку.
        /// </summary>
        /// <param name="image">Картинка.</param>
        public void PictureBox_UploadImage(Image image)
        {
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.Image = image;
        }
    }
}
