using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Кол-во академических часов дисциплины.
        /// </summary>
        private int _hoursCount;

        /// <summary>
        /// Возвращает и задает кол-во академических часов дисциплины.
        /// Должно быть положительным числом.
        /// </summary>
        public int NumberHours
        {
            get 
            { 
                return _hoursCount; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(NumberHours));
                _hoursCount = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает оценку по дисциплине.
        /// </summary>
        public int Mark { get; set; }

        /// <summary>
        /// Возвращает и задает фамилию преподавателя по дисциплине.
        /// </summary>
        public string LastNameTeacher { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Subject"/>
        /// </summary>
        public Subject()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Subject"/>
        /// </summary>
        /// <param name="title">Название дисциплины.</param>
        /// <param name="hoursCount">Кол-во академических часов дисциплины.</param>
        /// <param name="mark">Оценка по дисциплине.</param>
        /// <param name="lastNameTeacher">Фамилия преподавателя по дисциплине.</param>
        public Subject(string title, int hoursCount, int mark, string lastNameTeacher)
        {
            Title = title;
            NumberHours = hoursCount;
            Mark = mark;
            LastNameTeacher = lastNameTeacher;
        }
    }
}
