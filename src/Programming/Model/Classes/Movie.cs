using System;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private static int _count = 0;

        private int _id;

        private string _title;

        private int _durationInMinutes;

        private int _releaseYear;

        private string _genre;

        private double _rating;

        public Movie()
        {
            _count++;
        }

        public Movie(string title, int durationInMinutes, int releaseYear,
                     string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
            _count++;
            Id = _count;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title 
        { 
            get { return _title; }
            set { _title = value; }
        }

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

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

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

        public override string ToString()
        {
            return $"Movie {_id}";
        }
    }
}
