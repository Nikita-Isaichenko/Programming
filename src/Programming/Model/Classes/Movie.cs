using System;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private string _title;

        private int _durationInMinutes;

        private int _yearOfIssue;

        private string _genre;

        private double _rating;

        public Movie()
        {
        }

        public Movie(string title, int durationInMinutes, int yearOfIssue,
                     string genre, double rating)
        {
            _title = title;
            _durationInMinutes = durationInMinutes;
            _yearOfIssue = yearOfIssue;
            _genre = genre;
            _rating = rating;
        }

        public string Title { get; set; }
        public int DurationInMinutes { get; set; }

        public int YearOfIssue
        {
            get { return _yearOfIssue; }
            set
            {
                if (value < 1900 & value > 2022)
                {
                    throw new ArgumentException("Indicate the actual year of manufacture");
                }
                _yearOfIssue = value;
            }
        }

        public string Genre { get; set; }

        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value < 0 & value > 10)
                {
                    throw new ArgumentException("The rating is indicated outside" +
                                                " the established values (from 0 to 10)");
                }
                _rating = value;
            }
        }
    }
}
