using Programming.Model.Classes;
using Programming.Model.Geometry;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class RectanglesCollisionControl : UserControl
    {
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
                updateTextBox(_currentRectangle);
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                int indexRectangle = RectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[indexRectangle];
                updateTextBox(_currentRectangle);

            }
        }

        private void updateTextBox(Rectangle rectangle)
        {
            int indexRectangle = RectanglesListBox.SelectedIndex;
            if (indexRectangle != -1)
            {
                IdTextBox.Text = rectangle.Id.ToString();
                XTextBox.Text = rectangle.Center.X.ToString();
                YTextBox.Text = rectangle.Center.Y.ToString();
                WidthTextBox.Text = rectangle.Width.ToString();
                LenghtTextBox.Text = rectangle.Length.ToString();
            }
            else
            {
                IdTextBox.Clear();
                XTextBox.Clear();
                YTextBox.Clear();
                WidthTextBox.Clear();
                LenghtTextBox.Clear();
            }
        }

        
    }
}
