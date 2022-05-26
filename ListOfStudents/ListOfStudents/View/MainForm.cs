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
        private List<Student> _students;

        private Student _currentStudent;

        public MainForm()
        {
            InitializeComponent();

            var faculties = Enum.GetValues(typeof(Facutly));
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
            StudentsListBox.Items.Add("hello");
            CheckEmptinessListBox();
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
