using Programming.Model.Classes;
using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private readonly System.Drawing.Color ErrorBackColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color NormalBackColor = System.Drawing.Color.White;

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private Rectangle _currentRectangle;

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void AddRectangleButton_Click(object sender, System.EventArgs e)
        {

            var rectangle = RectangleFactory.Randomize();
            _rectangles.Add(rectangle);
            RectanglesListBox.Items.Clear();
            for (int i = 0; i < _rectangles.Count; i++)
            {
                RectanglesListBox.Items.Add(_rectangles[i].GetRectangleInfo());
            }
            RectanglesListBox.SelectedIndex = _rectangles.Count - 1;
        }

        private void RemoveRectangleButton_Click(object sender, System.EventArgs e)
        {
            if (_rectangles.Count > 0)
            {
                int indexRectangle = RectanglesListBox.SelectedIndex;
                RectanglesListBox.Items.RemoveAt(indexRectangle);
                _rectangles.RemoveAt(indexRectangle);
                RectanglesListBox.SelectedIndex = _rectangles.Count > 0 ? 0 : -1;
                UpdateRectangleInfo(_currentRectangle);
            }
            if (_rectangles.Count == 0)
            {
                ClearRectangleInfo();
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                int indexRectangle = RectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[indexRectangle];
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

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.X = int.Parse(XTextBox.Text);
                XTextBox.BackColor = NormalBackColor;
                UpdateListBox();
            }
            catch 
            {
                if (RectanglesListBox.Items.Count != 0) 
                {
                    XTextBox.BackColor = ErrorBackColor;
                }                
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.Y = int.Parse(YTextBox.Text);
                YTextBox.BackColor = NormalBackColor;
                UpdateListBox();
            }
            catch 
            {
                if (RectanglesListBox.Items.Count != 0)
                {
                    YTextBox.BackColor = ErrorBackColor;
                }
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = NormalBackColor;
                UpdateListBox();
            }
            catch 
            {
                if (RectanglesListBox.Items.Count != 0)
                {
                    WidthTextBox.BackColor = ErrorBackColor;
                }
            }
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(LenghtTextBox.Text);
                LenghtTextBox.BackColor = NormalBackColor;
                UpdateListBox();
            }
            catch 
            {
                if (RectanglesListBox.Items.Count != 0)
                {
                    LenghtTextBox.BackColor = ErrorBackColor;
                }
            }
        }
    }
}
