using System;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _hoursCount;

        public int NumberHours
        {
            get 
            { 
                return _hoursCount; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(NumberHours));
                _hoursCount = value;
            }
        }

        public string Title { get; set; }

        public int Mark { get; set; }

        public string LastNameTeacher { get; set; }

        public Subject()
        {
        }

        public Subject(string title, int hoursCount, int mark, string lastNameTeacher)
        {
            Title = title;
            NumberHours = hoursCount;
            Mark = mark;
            LastNameTeacher = lastNameTeacher;
        }
    }
}
