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
        public int RecordBookId { get; }

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

        public Student()
        {
            FullName = "No Data";
            Faculty = Faculty.NoData;
            EducationForm = EducationForm.NoData;
            NumberGroup = "No Data";
            _recordBookId += 1;
        }
    }
}
