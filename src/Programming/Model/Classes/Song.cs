using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Секунды.
        /// </summary>
        private int _durationSeconds;

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает исполнителя песни.
        /// </summary>
        public string Singer { get; set; }

        /// <summary>
        /// Возвращает и задает длительность песни в секундах. Должна быть положительным числом.
        /// </summary>
        public int DurationSeconds
        {
            get 
            { 
                return _durationSeconds; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationSeconds));
                _durationSeconds = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>
        /// </summary>
        /// <param name="title">Название песни.</param>
        /// <param name="singer">Испольнитель песни.</param>
        /// <param name="durationSeconds">Продолжительность в секундах. Должно быть положительным числом</param>
        public Song(string title, string singer, int durationSeconds)
        {
            Title = title;
            Singer = singer;
            DurationSeconds = durationSeconds;
        }
    }
}
