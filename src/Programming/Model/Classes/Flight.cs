namespace Programming.Model.Classes
{
    /// <summary>
    /// Класс, хранящий данные о рейсе.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Возвращает и задает место вылета.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает и задает место прилета.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает время полета в минутах. Должно быть положительным числом.
        /// </summary>
        public int FlightTimeInMinutes { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>
        /// </summary>
        public Flight()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>
        /// </summary>
        /// <param name="departure">Место вылета.</param>
        /// <param name="destination">Место прилета.</param>
        /// <param name="flightTimeInMinutes">Время полета в минутах. Должно быть положительным.</param>
        public Flight(string departure, string destination, int flightTimeInMinutes)
        {
            Departure = departure;
            Destination = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
        }
    }
}
