using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Windows.Forms;


namespace Programming.View.Controls
{
    public partial class MoviesControl : UserControl
    {       
        /// <summary>
        /// Объект класса <see cref="Random"/>
        /// </summary>
        Random random = new Random();

        /// <summary>
        /// Массив названий фильмов.
        /// </summary>
        private string[] _titleMovies = { "Титаник", "Матрица", "Шерлок Хоумс", "Интерстеллар", "Гладиатор" };

        /// <summary>
        /// Массив жанров.
        /// </summary>
        private string[] _genres;

        /// <summary>
        /// Массив объектов класса <see cref="Movie"./>.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Объект класса <see cref="Movie", хранит выбранный фильм./>
        /// </summary>
        private Movie _currentMovie;

        public MoviesControl()
        {
            InitializeComponent();

            _movies = new Movie[5];
            _genres = Enum.GetNames(typeof(Genre));

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(_titleMovies[i], random.Next(90, 210), random.Next(1900, DateTime.Now.Year + 1),
                                       _genres[random.Next(0, _genres.Length)], Math.Round(random.NextDouble() * 10, 2));
                MoviesListBox.Items.Add(_movies[i].ToString());
            }
        }

        /// <summary>
        /// Находит фильм с самым большим рейтингом.
        /// </summary>
        /// <param name="movie">Объект класс <see cref="Movie"/></param>
        /// <returns>Индекс фильма с самым большим рейтингом.</returns>
        private int FindMovieWithMaxRating(Movie[] movie)
        {
            int indexMaxRating = 0;
            double maxRating = 0;

            for (int i = 0; i < movie.Length; i++)
            {
                if (movie[i].Rating > maxRating)
                {
                    maxRating = movie[i].Rating;
                    indexMaxRating = i;
                }
            }

            return indexMaxRating;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMovie = MoviesListBox.SelectedIndex;

            _currentMovie = _movies[indexMovie];
            TitleTextBox.Text = _currentMovie.Title;
            DurationInMinutesTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            YearOfIssueTextBox.Text = _currentMovie.ReleaseYear.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            IdTextBox.Text = _currentMovie.Id.ToString();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = TitleTextBox.Text;
        }

        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.DurationInMinutes = int.Parse(DurationInMinutesTextBox.Text);
                DurationInMinutesTextBox.BackColor = AppColor.NormalBackColor;
                DurationInMinutesToolTip.SetToolTip(DurationInMinutesTextBox, null);
            }
            catch (Exception ex)
            {
                DurationInMinutesTextBox.BackColor = AppColor.ErrorBackColor;
                DurationInMinutesToolTip.SetToolTip(DurationInMinutesTextBox, ex.Message);
            }
        }

        private void YearOfIssueTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleaseYear = int.Parse(YearOfIssueTextBox.Text);
                YearOfIssueTextBox.BackColor = AppColor.NormalBackColor;
                YearOfIssueToolTip.SetToolTip(YearOfIssueTextBox, null);
            }
            catch (Exception ex)
            {
                YearOfIssueTextBox.BackColor = AppColor.ErrorBackColor;
                YearOfIssueToolTip.SetToolTip(YearOfIssueTextBox, ex.Message);
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = double.Parse(RatingTextBox.Text);
                RatingTextBox.BackColor = AppColor.NormalBackColor;
                RatingToolTip.SetToolTip(RatingTextBox, null);
            }
            catch (Exception ex)
            {
                RatingTextBox.BackColor = AppColor.ErrorBackColor;
                RatingToolTip.SetToolTip(RatingTextBox, ex.Message);
            }
        }

        private void FindMaxRatingButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}
