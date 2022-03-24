using System;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();

        private string[] _titleMovies = {"Титаник", "Матрица", "Шерлок Хоумс", "Интерстеллар", "Гладиатор"};
                                        
        private string[] _colors;

        private string[] _genres;

        private Rectangle[] _rectangles;

        private Movie[] _movies;

        private Rectangle _currentRectangle;

        private Movie _currentMovie;

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
            
            // Иницилизируем массив из пяти объектов типа Rectangle.
            _rectangles = new Rectangle[5];

            // Добавляем в массив цвета, которые содержатся в перечислении Color.
            _colors = Enum.GetNames(typeof(Color));

            // Иницилизируем каждый объект в массиве рандомными значениями полей
            // и добавляем в RectanglesListBox название объектов.
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(rnd.Next(0, 1000), rnd.Next(0, 1000),
                                               _colors[rnd.Next(_colors.Length)]);
                RectanglesListBox.Items.Add(_rectangles[i].ToString());
            }

            // Иницилизируем массив из пяти объектов типа Movie.
            _movies = new Movie[5];

            // Добавляем в массив жанры, которые содержатся в перечислении Genre.
            _genres = Enum.GetNames(typeof(Genre));

            // Иницилизируем каждый объект в массиве рандомными значениями полей
            // и добавляем в MoviesListBox название объектов.
            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(_titleMovies[i], rnd.Next(90, 210), rnd.Next(1900, 2022),
                                       _genres[rnd.Next(0, _genres.Length)], Math.Round(rnd.NextDouble()*10));
                MoviesListBox.Items.Add(_movies[i].ToString());
            }
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

        private void FindMaxWidthButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(LenghtTextBox.Text);
                LenghtTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {
                LenghtTextBox.BackColor = System.Drawing.Color.LightPink;
                LengthToolTip.SetToolTip(LenghtTextBox, ex.Message);
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                WidthToolTip.SetToolTip(WidthTextBox, ex.Message);
            }
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[indexMovie];
            TitleTextBox.Text = _currentMovie.Title;
            DurationInMinutesTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            YearOfIssueTextBox.Text = _currentMovie.YearOfIssue.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            RatingTextBox.Text = (_currentMovie.Rating.ToString());
        }
    }
}
