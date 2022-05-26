using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListOfStudents.Model
{
    /// <summary>
    /// Хранит данные о студенте.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Идентификатор зачетной книжки.
        /// </summary>
        private static int _recordBookId = 0;

        /// <summary>
        /// Номер группы.
        /// </summary>
        private string _numberGroup;

        /// <summary>
        /// Возвращает Id зачетной книжки. Состоит из 6 цифр.
        /// </summary>
        public static int RecordBookId
        {
            get
            {
                return _recordBookId;
            }
            private set
            {
                /// проверка на кол-во символов.
                _recordBookId = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер группы. Не более 10 символов.
        /// </summary>
        public string NumberGroup
        {
            get
            {
                return _numberGroup;
            }
            set
            {
                // проверка
                _numberGroup = value;
            }
        }

        /// <summary>
        /// Возвращает и задает полное имя.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Возвращает и задает факультет.
        /// </summary>
        public Facutly Facutly { get; set; }

        /// <summary>
        /// Возвращает и задает форму обучения.
        /// </summary>
        public EducationForm EducationForm { get; set; }


        public Student()
        {
            _recordBookId += 1;
        }
    }
}
