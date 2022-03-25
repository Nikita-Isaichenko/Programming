using System;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _hoursCount;
 
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

        public int NumberHours
        {
            get 
            { 
                return _hoursCount; 
            }
            set
            {
                if (_hoursCount < 0)
                {
                    throw new ArgumentException("Число часов не может быть меньше нуля");
                }
            }
        }

        public string Title { get; set; }

        public int Mark { get; set; }

        public string LastNameTeacher { get; set; }
    }
}
