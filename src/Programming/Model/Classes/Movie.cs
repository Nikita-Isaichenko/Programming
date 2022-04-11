﻿using System;

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
            get { 
                return _durationInMinutes;
            }
            set 
            {
                if (value < 0)
                {
                    _durationInMinutes = 0;
                    throw new ArgumentException("Длительность фильма не может быть меньше нуля");
                }
                _durationInMinutes = value;
            } 
        }

        public int ReleaseYear
        {
            get { 
                return _releaseYear;
            }
            set
            {
                if (value < 1900 | value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Введенная дата меньше 1900 года или больше настоящего года");
                }
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
            get { 
                return _rating;
            }
            set
            {
                if (value < 0 | value > 10)
                {
                    throw new ArgumentException("Число вышло за допустимые пределы" +
                                                "(от 0 до 10)");
                }
                _rating = value;
            }
        }

        public override string ToString()
        {
            return $"Movie {_id}";
        }
    }
}
