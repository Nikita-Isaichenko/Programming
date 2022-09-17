using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Класс, хранящий данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Кол-во фильмов.
        /// </summary>
        private static int _allMoviesCount = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Название фильма.
        /// </summary>
        private string _title;

        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Жанр фильма.
        /// </summary>
        private string _genre;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает идентификатор фильма.
        /// </summary>
        public int Id
        {
            get { return _id; }            
        }

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title 
        { 
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// Возвращает и задает продолжительность фильма в минутах.
        /// Должно быть положительным числом.
        /// </summary>
        public int DurationInMinutes 
        {
            get 
            { 
                return _durationInMinutes;
            }
            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            } 
        }

        /// <summary>
        /// Возвращает и задает год выпуска фильма.
        /// Должно быть положительным числом.
        /// </summary>
        public int ReleaseYear
        {
            get
            { 
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        /// <summary>
        /// Возвращает и задает рейтинг фильма.
        /// Должно быть больше или равно 0 или меньше или равно 10
        /// </summary>
        public double Rating
        {
            get 
            { 
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10.0, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>
        /// </summary>
        public Movie()
        {
            _allMoviesCount++;
            _id = _allMoviesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="durationInMinutes">Продолжительность фильма в минута.
        /// Должна быть положительным.</param>
        /// <param name="releaseYear">Год выпуска фильма. Должен быть положительным.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма.</param>
        public Movie(string title, int durationInMinutes, int releaseYear,
                     string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
            _allMoviesCount++;
            _id = _allMoviesCount;

        }

        /// <summary>
        /// Переопределенный метод, возвращающий строку по шаблону.
        /// </summary>
        /// <returns>Строка по шаблону "Movie {_id}"</returns>
        public override string ToString()
        {
            return $"Movie {_id}";
        }
    }
}
