﻿using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using System.Drawing;
using Programming.Model.Classes;


namespace Programming.View.Controls
{
    public partial class RectanglesCollisionControl : UserControl
    {        
        /// <summary>
        /// Список объектов класса <see cref="Rectangle"./>
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();

        /// <summary>
        /// Список объектов класса <see cref="Panel"./>
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Объект класса <see cref="Rectangle"/>. Хранит выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Индекс выбранного прямоугольника.
        /// </summary>
        private int _currentIndexRectangle;

        /// <summary>
        /// Создает экземпляр класса <see cref="RectanglesCollisionControl"/>
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }          

        private void RectanglesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                _currentIndexRectangle = RectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[_currentIndexRectangle];

                UpdateRectangleInfo(_currentRectangle);
            }                      
        }

        /// <summary>
        /// Обновляет информацию о выбранном прямоугольнике в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
            RectanglesListBox.Items[index] = _currentRectangle.GetRectangleInfo();
        }

        /// <summary>
        /// Обновляет информацию о переданном прямоугольнике в TextBoxes.
        /// </summary>
        /// <param name="rectangle">Объект класса <see cref="Rectangle"./></param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {           
                IdTextBox.Text = rectangle.Id.ToString();
                XTextBox.Text = rectangle.Center.X.ToString();
                YTextBox.Text = rectangle.Center.Y.ToString();
                WidthTextBox.Text = rectangle.Width.ToString();
                LenghtTextBox.Text = rectangle.Length.ToString();            
        }
        
        /// <summary>
        /// Очищает TextBoxes.
        /// </summary>
        public void ClearRectangleInfo()
        {
                IdTextBox.Clear();
                XTextBox.Clear();
                YTextBox.Clear();
                WidthTextBox.Clear();
                LenghtTextBox.Clear();
        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и перекращивает их.
        /// </summary>
        public void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = AppColor.NotCollision;
                _rectangles[i].Color = "Green";
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectangles[i].Color = "Red";
                        _rectangles[j].Color = "Red";

                        CanvasPanel.Controls[i].BackColor = AppColor.Collision;                        
                        CanvasPanel.Controls[j].BackColor = AppColor.Collision;
                    }
                }
            }
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.X = int.Parse(XTextBox.Text);
                XTextBox.BackColor = AppColor.NormalBackColor;
                CanvasPanel.Controls[_currentIndexRectangle].Location = new Point(_currentRectangle.Center.X,
                                                                              _currentRectangle.Center.Y);

                FindCollisions();
                UpdateListBox();
            }
            catch 
            {
                if (RectanglesListBox.Items.Count != 0) 
                {
                    XTextBox.BackColor = AppColor.ErrorBackColor;
                }                
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.Y = int.Parse(YTextBox.Text);
                YTextBox.BackColor = AppColor.NormalBackColor;
                CanvasPanel.Controls[_currentIndexRectangle].Location = new Point(_currentRectangle.Center.X,
                                                                              _currentRectangle.Center.Y);

                FindCollisions();
                UpdateListBox();
            }
            catch 
            {
                if (RectanglesListBox.Items.Count != 0)
                {
                    YTextBox.BackColor = AppColor.ErrorBackColor;
                }
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = AppColor.NormalBackColor;
                CanvasPanel.Controls[_currentIndexRectangle].Height = _currentRectangle.Width;

                FindCollisions();
                UpdateListBox();
            }
            catch 
            {
                if (RectanglesListBox.Items.Count != 0)
                {
                    WidthTextBox.BackColor = AppColor.ErrorBackColor;
                }
            }
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(LenghtTextBox.Text);
                LenghtTextBox.BackColor = AppColor.NormalBackColor;
                CanvasPanel.Controls[_currentIndexRectangle].Width = _currentRectangle.Length;

                FindCollisions();
                UpdateListBox();
            }
            catch 
            {
                if (RectanglesListBox.Items.Count != 0)
                {
                    LenghtTextBox.BackColor = AppColor.ErrorBackColor;
                }
            }
        }      

        private void AddButtonPictureBox_Click(object sender, EventArgs e)
        {
            var newRectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);

            var newPanel = new Panel
            {
                Height = newRectangle.Width,
                Width = newRectangle.Length,
                Location = new Point(newRectangle.Center.X, newRectangle.Center.Y),
                BackColor = AppColor.NotCollision
            };

            _rectangles.Add(newRectangle);
            _rectanglePanels.Add(newPanel);
            RectanglesListBox.Items.Clear();

            for (int i = 0; i < _rectangles.Count; i++)
            {
                RectanglesListBox.Items.Add(_rectangles[i].GetRectangleInfo());
                CanvasPanel.Controls.Add(newPanel);
            }

            RectanglesListBox.SelectedIndex = _rectangles.Count - 1;

            FindCollisions();
        }

        

        private void RemoveButtonPictureBox_Click(object sender, EventArgs e)
        {
            if (_rectangles.Count > 0)
            {
                RectanglesListBox.Items.RemoveAt(_currentIndexRectangle);
                _rectangles.RemoveAt(_currentIndexRectangle);
                CanvasPanel.Controls.RemoveAt(_currentIndexRectangle);
                _rectanglePanels.RemoveAt(_currentIndexRectangle);
                RectanglesListBox.SelectedIndex = _rectangles.Count > 0 ? 0 : -1;

                UpdateRectangleInfo(_currentRectangle);
            }

            if (_rectangles.Count == 0)
            {
                ClearRectangleInfo();
            }

            FindCollisions();
        }

        private void RemoveButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemoveButtonPictureBox.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RemoveButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            RemoveButtonPictureBox.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void AddButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddButtonPictureBox.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddButtonPictureBox.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }
    }
}
