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
            this._title = title;
            this._singer = singer;
            this._minutes = minutes;
            this._seconds = seconds;

        }

        public string Title { get; set; }

        public string Singer { get; set; }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0 & value > 60)
                {
                    throw new ArgumentException("the number is out of bounds of the set [0;60]");
                }
                _minutes = value;
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0 & value > 60)
                {
                    throw new ArgumentException("the number is out of bounds of the set [0;60]");
                }
                _seconds = value;
            }
        }
    }
}
