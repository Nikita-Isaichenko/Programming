using ListOfStudents.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Environment;

namespace ListOfStudents.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список объектов класса <see cref="Student"/>, которые найдены через поиск.
        /// </summary>
        private List<Student> _studentsSearch = new List<Student>();

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
        /// Фильтр
        /// </summary>
        private string _filter = "(*.jpg;*.png;*.jpeg)|*.JPG;*.PNG;*.JPEG";

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            StudentImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
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
        private List<Student> SortFullName(List<Student> student)
        {
            var sortedStudents = from value in student
                                 orderby value.FullName
                                 select value;
            student = sortedStudents.ToList();

            return student;
        }        

        /// <summary>
        /// Обновляет StudentListBox.
        /// </summary>
        private void UpdateListBoxInfo()
        {   
            StudentsListBox.Items.Clear();
          
            if (SearchTextBox.Text != "")
            {
                _studentsSearch = SortFullName(_studentsSearch);

                foreach (var value in _studentsSearch)
                {
                    StudentsListBox.Items.Add(value.OutputInformation());
                }

                var index = _studentsSearch.IndexOf(_currentStudent);
                StudentsListBox.SelectedIndex = Convert.ToInt32(index);
            }

            if (SearchTextBox.Text == "")
            {
                _students = SortFullName(_students);

                foreach (var value in _students)
                {
                    StudentsListBox.Items.Add(value.OutputInformation());
                }

                var index = _students.IndexOf(_currentStudent);
                StudentsListBox.SelectedIndex = Convert.ToInt32(index);
            }
           
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
                AddImageButton.Enabled = true;
                RemoveImageButton.Enabled = true;
            }

            if (StudentsListBox.SelectedIndex == -1)
            {
                FullNameTextBox.Enabled = false;
                GroupNumberTextBox.Enabled = false;
                FacultyComboBox.Enabled = false;
                EducationFormComboBox.Enabled = false;
                AddImageButton.Enabled = false;
                RemoveImageButton.Enabled = false;

                ClearTextBoxes();
            }      
        }

        /// <summary>
        /// Организует поиск полей у объектов,
        /// удовлетворяющих введенному в строку значению.
        /// </summary>
        /// <param name="searchText">Строка по которой нужно искать.</param>
        /// <returns>Список объектов подходящих под введенную строку.</returns>
        private List<Student> Search(string searchText)
        {
            var result = from value in _students
                         where value.FullName.Contains(searchText) ||
                         value.NumberGroup.Contains(searchText) ||
                         value.Faculty.ToString().Contains(searchText) ||
                         value.EducationForm.ToString().Contains(searchText)
                         select value;

            return result.ToList();
        }

        /// <summary>
        /// Преобразует Base64 в Image.
        /// </summary>
        /// <param name="base64">Строка в виде Base64.</param>
        /// <returns>Объект класса <see cref="Image"/>.</returns>
        private Image ConvertFromBase64StringToImage(string base64)
        {          
            if (base64 == null) return null;

            var byteArrayImage = Convert.FromBase64String(base64);
            return Image.FromStream(new MemoryStream(byteArrayImage));
        }

        private void AddStudentButtonClick_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "") return;

            _currentStudent = new Student();
            _students.Add(_currentStudent);

            UpdateListBoxInfo();
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1) return;

            if (SearchTextBox.Text != "")
            {
                _currentStudentIndex = StudentsListBox.SelectedIndex;
                _currentStudent = _studentsSearch[_currentStudentIndex];
                StudentImagePictureBox.Image = 
                    ConvertFromBase64StringToImage(_currentStudent.StudentImage);
            }
            if (SearchTextBox.Text == "")
            {
                _currentStudentIndex = StudentsListBox.SelectedIndex;
                _currentStudent = _students[_currentStudentIndex];
                StudentImagePictureBox.Image =
                    ConvertFromBase64StringToImage(_currentStudent.StudentImage);
            }
                
            UpdateSelectedStudentInfo(_currentStudent);
        }

        private void RemoveStudentButtonClick_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "") return;

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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = SearchTextBox.Text;
            _studentsSearch = Search(searchText);

            UpdateListBoxInfo();           
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = _filter;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                _currentStudent.StudentImage = Convert.ToBase64String(imageArray);
                StudentImagePictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
            if (_currentStudent.StudentImage == null) return;

            _currentStudent.StudentImage = null;
            StudentImagePictureBox.Image = null;
        }
    }
}
