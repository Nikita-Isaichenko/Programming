using System;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private static int _count = 0;

        private string _title;

        private int _durationInMinutes;

        private int _yearOfIssue;

        private string _genre;

        private double _rating;

        public Movie()
        {
            _count++;
        }

        public Movie(string title, int durationInMinutes, int yearOfIssue,
                     string genre, double rating)
        {
            this._title = title;
            this._durationInMinutes = durationInMinutes;
            this._yearOfIssue = yearOfIssue;
            this._genre = genre;
            this._rating = rating;
            _count++;
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

        public override string ToString()
        {
            return $"Movie {_count}";
        }
    }
}
