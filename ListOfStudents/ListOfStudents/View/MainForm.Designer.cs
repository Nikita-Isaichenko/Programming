namespace ListOfStudents.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.EducationFormComboBox = new System.Windows.Forms.ComboBox();
            this.EducationFormLabel = new System.Windows.Forms.Label();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.GroupNumberLabel = new System.Windows.Forms.Label();
            this.GroupNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RecordBookIdTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextLabel = new System.Windows.Forms.Label();
            this.AddStudentButtonClick = new System.Windows.Forms.Button();
            this.RemoveStudentButtonClick = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.HorizontalScrollbar = true;
            this.StudentsListBox.Location = new System.Drawing.Point(10, 10);
            this.StudentsListBox.Margin = new System.Windows.Forms.Padding(1);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(300, 394);
            this.StudentsListBox.TabIndex = 0;
            this.StudentsListBox.SelectedIndexChanged += new System.EventHandler(this.StudentsListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.EducationFormComboBox);
            this.groupBox1.Controls.Add(this.EducationFormLabel);
            this.groupBox1.Controls.Add(this.FacultyComboBox);
            this.groupBox1.Controls.Add(this.FacultyLabel);
            this.groupBox1.Controls.Add(this.GroupNumberLabel);
            this.groupBox1.Controls.Add(this.GroupNumberTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RecordBookIdTextBox);
            this.groupBox1.Controls.Add(this.FullNameTextBox);
            this.groupBox1.Controls.Add(this.FullNameTextLabel);
            this.groupBox1.Location = new System.Drawing.Point(316, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 235);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Student";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(634, 429);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(165, 20);
            this.SearchTextBox.TabIndex = 11;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // EducationFormComboBox
            // 
            this.EducationFormComboBox.FormattingEnabled = true;
            this.EducationFormComboBox.Location = new System.Drawing.Point(98, 126);
            this.EducationFormComboBox.Name = "EducationFormComboBox";
            this.EducationFormComboBox.Size = new System.Drawing.Size(165, 21);
            this.EducationFormComboBox.TabIndex = 9;
            this.EducationFormComboBox.SelectedIndexChanged += new System.EventHandler(this.EducationFormComboBox_SelectedIndexChanged);
            // 
            // EducationFormLabel
            // 
            this.EducationFormLabel.AutoSize = true;
            this.EducationFormLabel.Location = new System.Drawing.Point(6, 129);
            this.EducationFormLabel.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.EducationFormLabel.Name = "EducationFormLabel";
            this.EducationFormLabel.Size = new System.Drawing.Size(84, 13);
            this.EducationFormLabel.TabIndex = 8;
            this.EducationFormLabel.Text = "Education Form:";
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(98, 99);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(165, 21);
            this.FacultyComboBox.TabIndex = 7;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.FacultyComboBox_SelectedIndexChanged);
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(46, 102);
            this.FacultyLabel.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(44, 13);
            this.FacultyLabel.TabIndex = 6;
            this.FacultyLabel.Text = "Faculty:";
            // 
            // GroupNumberLabel
            // 
            this.GroupNumberLabel.AutoSize = true;
            this.GroupNumberLabel.Location = new System.Drawing.Point(11, 75);
            this.GroupNumberLabel.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.GroupNumberLabel.Name = "GroupNumberLabel";
            this.GroupNumberLabel.Size = new System.Drawing.Size(79, 13);
            this.GroupNumberLabel.TabIndex = 5;
            this.GroupNumberLabel.Text = "Group Number:";
            // 
            // GroupNumberTextBox
            // 
            this.GroupNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupNumberTextBox.Location = new System.Drawing.Point(98, 73);
            this.GroupNumberTextBox.Name = "GroupNumberTextBox";
            this.GroupNumberTextBox.Size = new System.Drawing.Size(165, 20);
            this.GroupNumberTextBox.TabIndex = 4;
            this.GroupNumberTextBox.TextChanged += new System.EventHandler(this.GroupNumberTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Record Book Id:";
            // 
            // RecordBookIdTextBox
            // 
            this.RecordBookIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecordBookIdTextBox.Enabled = false;
            this.RecordBookIdTextBox.Location = new System.Drawing.Point(98, 47);
            this.RecordBookIdTextBox.Name = "RecordBookIdTextBox";
            this.RecordBookIdTextBox.ReadOnly = true;
            this.RecordBookIdTextBox.Size = new System.Drawing.Size(165, 20);
            this.RecordBookIdTextBox.TabIndex = 2;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullNameTextBox.Location = new System.Drawing.Point(98, 21);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.FullNameTextBox.MaxLength = 201;
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(374, 20);
            this.FullNameTextBox.TabIndex = 1;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // FullNameTextLabel
            // 
            this.FullNameTextLabel.AutoSize = true;
            this.FullNameTextLabel.Location = new System.Drawing.Point(33, 24);
            this.FullNameTextLabel.Margin = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.FullNameTextLabel.Name = "FullNameTextLabel";
            this.FullNameTextLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameTextLabel.TabIndex = 0;
            this.FullNameTextLabel.Text = "Full Name:";
            // 
            // AddStudentButtonClick
            // 
            this.AddStudentButtonClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddStudentButtonClick.Location = new System.Drawing.Point(12, 408);
            this.AddStudentButtonClick.Name = "AddStudentButtonClick";
            this.AddStudentButtonClick.Size = new System.Drawing.Size(61, 41);
            this.AddStudentButtonClick.TabIndex = 5;
            this.AddStudentButtonClick.UseVisualStyleBackColor = true;
            this.AddStudentButtonClick.Click += new System.EventHandler(this.AddStudentButtonClick_Click);
            // 
            // RemoveStudentButtonClick
            // 
            this.RemoveStudentButtonClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveStudentButtonClick.Location = new System.Drawing.Point(79, 408);
            this.RemoveStudentButtonClick.Name = "RemoveStudentButtonClick";
            this.RemoveStudentButtonClick.Size = new System.Drawing.Size(61, 41);
            this.RemoveStudentButtonClick.TabIndex = 6;
            this.RemoveStudentButtonClick.UseVisualStyleBackColor = true;
            this.RemoveStudentButtonClick.Click += new System.EventHandler(this.RemoveStudentButtonClick_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(582, 432);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 12;
            this.SearchLabel.Text = "Search:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 461);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.RemoveStudentButtonClick);
            this.Controls.Add(this.AddStudentButtonClick);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StudentsListBox);
            this.Name = "MainForm";
            this.Text = "ListOfStudents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameTextLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RecordBookIdTextBox;
        private System.Windows.Forms.TextBox GroupNumberTextBox;
        private System.Windows.Forms.Label GroupNumberLabel;
        private System.Windows.Forms.ComboBox EducationFormComboBox;
        private System.Windows.Forms.Label EducationFormLabel;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.Button AddStudentButtonClick;
        private System.Windows.Forms.Button RemoveStudentButtonClick;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
    }
}

