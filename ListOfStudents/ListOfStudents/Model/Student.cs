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
        /// Счетчик студентов.
        /// </summary>
        private static int _counterStudents;

        /// <summary>
        /// Фио.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Идентификатор зачетной книжки.
        /// </summary>
        private  int _recordBookId = 100000;

        /// <summary>
        /// Номер группы.
        /// </summary>
        private string _numberGroup;

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
                Validator.AssertLengthString(value, 10, nameof(NumberGroup));
                Validator.AssertEmptyValue(value, nameof(NumberGroup));
                _numberGroup = value;
            }
        }

        /// <summary>
        /// Возвращает и задает полное имя.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                Validator.AssertLengthString(value, 200, nameof(FullName));
                Validator.AssertEmptyValue(value, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает id зачетной книжки.
        /// </summary>
        public int RecordBookId
        {
            get
            {
                return _recordBookId;
            }
            set
            {
                _counterStudents = value - 100000;
                _recordBookId = value;
            }
        }

        /// <summary>
        /// Возвращает и задает изображение в кодировке Base64.
        /// </summary>
        public string StudentImage { get; set; }

        /// <summary>
        /// Возвращает и задает факультет.
        /// </summary>
        public Faculty Faculty { get; set; }

        /// <summary>
        /// Возвращает и задает форму обучения.
        /// </summary>
        public EducationForm EducationForm { get; set; }

        /// <summary>
        /// Выводит информацию о студенте в виде шаблона.
        /// </summary>
        /// <returns>Строка в виде "{FullName} - {NumberGroup}/{Faculty}"</returns>
        public string OutputInformation()
        {
            return $"{FullName} - {NumberGroup}/{Faculty}";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Student"/>.
        /// </summary>
        public Student()
        {            
            _counterStudents++;
            _recordBookId += _counterStudents;
            FullName = "None";
            Faculty = Faculty.None;
            EducationForm = EducationForm.None;
            NumberGroup = "None";           
        }
    }
}
