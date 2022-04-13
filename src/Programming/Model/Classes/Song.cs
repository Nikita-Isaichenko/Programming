using System;

namespace Programming.Model.Classes
{
    public class Song
    {

        private string _title;

        private string _singer;

        private int _minutes;

        private int _seconds;
        public Song()
        {
        }

        public Song(string title, string singer, int minutes, int seconds)
        {
            Title = title;
            Singer = singer;
            Minutes = minutes;
            Seconds = seconds;
        }

        public string Title { get; set; }

        public string Singer { get; set; }

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
    }
}
