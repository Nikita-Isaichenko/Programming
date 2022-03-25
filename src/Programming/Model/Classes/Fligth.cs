namespace Programming.Model.Classes
{
    public class Fligth
    {
        private string _departurePoint;

        private string _destination;

        private int _flightTimeInMinutes;

        public Fligth()
        {
        }

        public Fligth(string departurePoint, string destination, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public int FlightTimeInMinutes { get; set; }
    }
}
