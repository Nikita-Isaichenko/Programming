using ListOfStudents.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfStudents.View
{
    public partial class MainForm : Form
    {
        private List<Student> _students = new List<Student>();

        private Student _currentStudent;

        public MainForm()
        {
            InitializeComponent();

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

           
            CheckEmptinessListBox();
        }

        private void CheckEmptinessListBox()
        {
            if (StudentsListBox.Items.Count == 0)
            {
                FullNameTextBox.Enabled = false;
                GroupNumberTextBox.Enabled = false;
                FacultyComboBox.Enabled = false;
                EducationFormComboBox.Enabled = false;
            }
            else
            {
                FullNameTextBox.Enabled = true;
                GroupNumberTextBox.Enabled = true;
                FacultyComboBox.Enabled = true;
                EducationFormComboBox.Enabled = true;
            }
        }

        private void AddStudentButtonClick_Click(object sender, EventArgs e)
        {
            _currentStudent = new Student();
            _students.Add(_currentStudent);
            StudentsListBox.Items.Add(_currentStudent.OutputInformation());
            StudentsListBox.SelectedIndex = _students.Count-1;

            CheckEmptinessListBox();
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentStudent = _students[StudentsListBox.SelectedIndex];
            FullNameTextBox.Text = _currentStudent.FullName;
            RecordBookIdTextBox.Text = _currentStudent.RecordBookId.ToString();
            GroupNumberTextBox.Text = _currentStudent.NumberGroup;
            FacultyComboBox.SelectedIndex = (int)_currentStudent.Faculty;
            EducationFormComboBox.SelectedIndex = (int)_currentStudent.EducationForm;
        }

        private void RemoveStudentButtonClick_Click(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1) return;
            _students.RemoveAt(StudentsListBox.SelectedIndex);
            StudentsListBox.SelectedIndex = _students.Count-1;
            StudentsListBox.Items.RemoveAt(_students.Count);

            CheckEmptinessListBox();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentStudent.FullName = FullNameTextBox.Text;

            UpdateListBoxInfo(_currentStudent);
        }

        public void UpdateListBoxInfo(Student student)
        {
            StudentsListBox.Items.Clear();

            _students[StudentsListBox.SelectedIndex+1] = student;
            foreach (var value in _students)
            {
                StudentsListBox.Items.Add(value.OutputInformation());
            }
        }
    }
}
