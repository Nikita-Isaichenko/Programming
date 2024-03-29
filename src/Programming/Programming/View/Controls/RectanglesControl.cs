﻿using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;


namespace Programming.View.Controls
{
    public partial class RectanglesControl : UserControl
    {
        
        /// <summary>
        /// Объект класса <see cref="Rectangle". Хранит выбранный прямоугольник./>
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Массив объектов класса <see cref="Rectangle"./>
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Массив цветов.
        /// </summary>
        private string[] _colors;

        /// <summary>
        /// Объект класса <see cref="Random"./>
        /// </summary>
        Random random = new Random();

        /// <summary>
        /// Создает экземпляр класса <see cref="RectanglesControl"/>
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = new Rectangle[5];
            _colors = Enum.GetNames(typeof(Color));

            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(random.Next(0, 1000), random.Next(0, 1000),
                                               _colors[random.Next(_colors.Length)],
                                               random.Next(0, 671), random.Next(0, 451));
                RectanglesListBox.Items.Add(_rectangles[i].ToString());
            }
        }

        /// <summary>
        /// Находит прямоугольник с самой большой шириной.
        /// </summary>
        /// <param name="rectangles">Объект класса <see cref="Rectangle"./></param>
        /// <returns>Индекс прямоугольника с самой большой шириной</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexMaxWidth = 0;
            int maxWidth = 0;

            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexMaxWidth = i;
                }
            }

            return indexMaxWidth;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexRectangle = RectanglesListBox.SelectedIndex;

            _currentRectangle = _rectangles[indexRectangle];
            LenghtTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(LenghtTextBox.Text);
                LenghtTextBox.BackColor = AppColor.NormalBackColor;
                LengthToolTip.SetToolTip(LenghtTextBox, null);
            }
            catch (Exception ex)
            {
                LenghtTextBox.BackColor = AppColor.ErrorBackColor;
                LengthToolTip.SetToolTip(LenghtTextBox, ex.Message);
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = AppColor.NormalBackColor;
                WidthToolTip.SetToolTip(WidthTextBox, null);
            }
            catch (Exception ex)
            {
                WidthTextBox.BackColor = AppColor.ErrorBackColor;
                WidthToolTip.SetToolTip(WidthTextBox, ex.Message);
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void FindMaxWidthButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
