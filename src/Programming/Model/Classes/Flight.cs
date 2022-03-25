﻿namespace Programming.Model.Classes
{
    public class Flight
    {
        public Flight()
        {
        }

        public Flight(string departure, string destination, int flightTimeInMinutes)
        {
            Departure = departure;
            Destination = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public int FlightTimeInMinutes { get; set; }
    }
}
