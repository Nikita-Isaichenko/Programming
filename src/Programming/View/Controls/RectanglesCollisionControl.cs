using Programming.Model.Geometry;
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
        private List<Rectangle> _rectangles = new List<Rectangle>();

        private List<Panel> _rectanglePanels = new List<Panel>();

        private Rectangle _currentRectangle;

        private int _currentIndexRectangle;

        

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void AddRectangleButton_Click(object sender, System.EventArgs e)
        {

            var newRectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            var newPanel = new Panel
            {
                Height = newRectangle.Width,
                Width = newRectangle.Length,
                Location = new Point(newRectangle.Center.X, newRectangle.Center.Y),
                BackColor = AppColor.Unintersection
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

        private void RemoveRectangleButton_Click(object sender, System.EventArgs e)
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                _currentIndexRectangle = RectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[_currentIndexRectangle];

                UpdateRectangleInfo(_currentRectangle);

            }                      
        }

        private void UpdateListBox()
        {
            int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
            RectanglesListBox.Items[index] = _currentRectangle.GetRectangleInfo();
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {           
                IdTextBox.Text = rectangle.Id.ToString();
                XTextBox.Text = rectangle.Center.X.ToString();
                YTextBox.Text = rectangle.Center.Y.ToString();
                WidthTextBox.Text = rectangle.Width.ToString();
                LenghtTextBox.Text = rectangle.Length.ToString();            
        }

        public void ClearRectangleInfo()
        {
                IdTextBox.Clear();
                XTextBox.Clear();
                YTextBox.Clear();
                WidthTextBox.Clear();
                LenghtTextBox.Clear();
        }

        public void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = AppColor.Unintersection;
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

                        CanvasPanel.Controls[i].BackColor = AppColor.Intersection;
                        CanvasPanel.Controls[j].BackColor = AppColor.Intersection;
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
    }
}
