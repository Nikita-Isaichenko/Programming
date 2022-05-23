namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает кол-во часов. Число от 0 до 24 включительно.
        /// </summary>
        public int Hours
        {
            get 
            { 
                return _hours; 
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 24, nameof(Hours));
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает кол-во минут. Число от 0 до 60 включительно.
        /// </summary>
        public int Minutes
        {
            get 
            { 
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minutes));
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает кол-во секунд. Число от 0 до 60 включительно.
        /// </summary>
        public int Seconds
        {
            get 
            { 
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Seconds));
                _seconds = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>
        /// </summary>
        public Time()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>
        /// </summary>
        /// <param name="hours">Часы. Число От 0 до 23 включительно.</param>
        /// <param name="minutes">Минуты. Число от 0 до 60 включительно</param>
        /// <param name="seconds">Секунды. Число от 0 до 60 включительно</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
