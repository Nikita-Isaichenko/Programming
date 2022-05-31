using ListOfStudents.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Environment;

namespace ListOfStudents.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список объектов класса <see cref="Student"/>.
        /// </summary>
        private List<Student> _students = new List<Student>();

        /// <summary>
        /// Выбранный объект класса <see cref="Student"/>.
        /// </summary>
        private Student _currentStudent;

        /// <summary>
        /// Индекс выбранного объекта класса <see cref="Student"/>.
        /// </summary>
        private int _currentStudentIndex;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            Serializer.Path = $@"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}"+
                               @"\data.json";

            _students = Serializer.LoadFromFile();
            var faculties = Enum.GetValues(typeof(Faculty));
            var educationForms = Enum.GetValues(typeof(EducationForm));

            foreach (var value in faculties)
            {
                FacultyComboBox.Items.Add(value);
            }

            foreach (var value in educationForms)
            {
                EducationFormComboBox.Items.Add(value);
            }
            
            UpdateListBoxInfo();
            UpdateSelectedStudentInfo(_currentStudent);       
        }

        /// <summary>
        /// Сортирует список объектов класса <see cref="Student"/>
        /// по возрастанию значения свойства <see cref="Student.FullName"/>.
        /// </summary>
        /// <returns>Отсортированный список.</returns>
        private List<Student> SortFullName()
        {
            var sortedStudents = from value in _students
                                 orderby value.FullName
                                 select value;
            _students = sortedStudents.ToList();

            return _students;
        }        

        /// <summary>
        /// Обновляет StudentListBox.
        /// </summary>
        private void UpdateListBoxInfo()
        {                        
            StudentsListBox.Items.Clear();
            var students = SortFullName();

            foreach (var value in students)
            {
                StudentsListBox.Items.Add(value.OutputInformation());
            }

            var index = students.IndexOf(_currentStudent);
            StudentsListBox.SelectedIndex = Convert.ToInt32(index);           
        }

        /// <summary>
        /// Очищает все поля с информацией о студенте.
        /// </summary>
        private void ClearTextBoxes()
        {            
            {
                FullNameTextBox.Clear();
                RecordBookIdTextBox.Clear();
                GroupNumberTextBox.Clear();
                FacultyComboBox.SelectedIndex = -1;
                EducationFormComboBox.SelectedIndex = -1;
            }           
        }

        /// <summary>
        /// Обновляет все поля с информацией о студенте.
        /// Если в ListBox нету объектов, то очищает все поля и делает их не доступными.
        /// </summary>
        /// <param name="student">Объект класса <see cref="Student"/></param>
        private void UpdateSelectedStudentInfo(Student student)
        {           
            if (StudentsListBox.Items.Count > 0 & StudentsListBox.SelectedIndex != -1)
            {
                FullNameTextBox.Text = student.FullName;
                RecordBookIdTextBox.Text = student.RecordBookId.ToString();
                GroupNumberTextBox.Text = student.NumberGroup;
                FacultyComboBox.SelectedIndex = (int)student.Faculty;
                EducationFormComboBox.SelectedIndex = (int)student.EducationForm;

                FullNameTextBox.Enabled = true;
                GroupNumberTextBox.Enabled = true;
                FacultyComboBox.Enabled = true;
                EducationFormComboBox.Enabled = true;
            }

            if (StudentsListBox.Items.Count == 0 & StudentsListBox.SelectedIndex == -1)
            {
                FullNameTextBox.Enabled = false;
                GroupNumberTextBox.Enabled = false;
                FacultyComboBox.Enabled = false;
                EducationFormComboBox.Enabled = false;

                ClearTextBoxes();
            }      
        }

        private void AddStudentButtonClick_Click(object sender, EventArgs e)
        {
            _currentStudent = new Student();
            _students.Add(_currentStudent);
            StudentsListBox.Items.Add(_currentStudent.OutputInformation());
            StudentsListBox.SelectedIndex = _students.Count - 1;
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1) return;

            _currentStudentIndex = StudentsListBox.SelectedIndex;
            _currentStudent = _students[_currentStudentIndex];

            UpdateSelectedStudentInfo(_currentStudent);
        }

        private void RemoveStudentButtonClick_Click(object sender, EventArgs e)
        {
            if (_students.Count > 0)
            {
                StudentsListBox.Items.RemoveAt(_currentStudentIndex);
                _students.RemoveAt(_currentStudentIndex);
                StudentsListBox.SelectedIndex = _students.Count > 0 ? 0 : -1;
            }

            UpdateSelectedStudentInfo(_currentStudent);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializer.SaveToFile(_students);
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {   
                if (_students.Count == 0)
                {
                    FullNameTextBox.BackColor = AppColor.NotEnabledWidget;
                    return;
                } 
                
                _currentStudent.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = AppColor.NormalBackColor;
              
                UpdateListBoxInfo();
            }
            catch
            {
                FullNameTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void GroupNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_students.Count == 0)
                {
                    GroupNumberTextBox.BackColor = AppColor.NotEnabledWidget;
                    return;
                }

                _currentStudent.NumberGroup = GroupNumberTextBox.Text;
                GroupNumberTextBox.BackColor = AppColor.NormalBackColor;

                UpdateListBoxInfo();
            }
            catch
            {
                GroupNumberTextBox.BackColor = AppColor.ErrorBackColor;
            }        
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FacultyComboBox.SelectedIndex == -1) return;

            _currentStudent.Faculty = (Faculty)FacultyComboBox.SelectedItem;

            UpdateListBoxInfo();
        }

        private void EducationFormComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EducationFormComboBox.SelectedIndex == -1) return;

            _currentStudent.EducationForm = (EducationForm)EducationFormComboBox.SelectedItem;
        }
    }
}
