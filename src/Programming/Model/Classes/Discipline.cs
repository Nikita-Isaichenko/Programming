using System;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private string _title;

        private int _numberHours;

        private int _grade;

        private string _lastNameTeacher;
 
        public Discipline()
        {
        }

        public Discipline(string title, int numberHours, int grade, string lastNameTeacher)
        {
            this._title = title;
            this._numberHours = numberHours;
            this._grade = grade;
            this._lastNameTeacher = lastNameTeacher;
        }

        public int NumberHours
        {
            get { return _numberHours; }
            set
            {
                if (_numberHours < 0)
                {
                    throw new ArgumentException("Number of hours less than zero");
                }
            }
        }
        public string Title { get; set; }

        public int Grade { get; set; }

        public string LastNameTeacher { get; set; }
    }
}
