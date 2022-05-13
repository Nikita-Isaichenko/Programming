namespace Programming.View.Controls
{
    partial class MoviesControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IdMovieLabel = new System.Windows.Forms.Label();
            this.IdMovieTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.FindMaxRatingButton = new System.Windows.Forms.Button();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.DurationInMinutesTextBox = new System.Windows.Forms.TextBox();
            this.YearOfIssueTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.DurationInMinutesLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.DurationInMinutesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.YearOfIssueToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RatingToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // IdMovieLabel
            // 
            this.IdMovieLabel.AutoSize = true;
            this.IdMovieLabel.Location = new System.Drawing.Point(165, 267);
            this.IdMovieLabel.Name = "IdMovieLabel";
            this.IdMovieLabel.Size = new System.Drawing.Size(19, 13);
            this.IdMovieLabel.TabIndex = 27;
            this.IdMovieLabel.Text = "Id:";
            // 
            // IdMovieTextBox
            // 
            this.IdMovieTextBox.Location = new System.Drawing.Point(165, 283);
            this.IdMovieTextBox.Name = "IdMovieTextBox";
            this.IdMovieTextBox.ReadOnly = true;
            this.IdMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdMovieTextBox.TabIndex = 26;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(162, 215);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 25;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(162, 162);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 24;
            this.GenreLabel.Text = "Genre:";
            // 
            // FindMaxRatingButton
            // 
            this.FindMaxRatingButton.Location = new System.Drawing.Point(165, 361);
            this.FindMaxRatingButton.Name = "FindMaxRatingButton";
            this.FindMaxRatingButton.Size = new System.Drawing.Size(100, 23);
            this.FindMaxRatingButton.TabIndex = 18;
            this.FindMaxRatingButton.Text = "Find";
            this.FindMaxRatingButton.UseVisualStyleBackColor = true;
            this.FindMaxRatingButton.Click += new System.EventHandler(this.FindMaxRatingButton_Click);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(165, 231);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingTextBox.TabIndex = 23;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(165, 178);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 22;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // DurationInMinutesTextBox
            // 
            this.DurationInMinutesTextBox.Location = new System.Drawing.Point(165, 72);
            this.DurationInMinutesTextBox.Name = "DurationInMinutesTextBox";
            this.DurationInMinutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.DurationInMinutesTextBox.TabIndex = 21;
            this.DurationInMinutesTextBox.TextChanged += new System.EventHandler(this.DurationInMinutesTextBox_TextChanged);
            // 
            // YearOfIssueTextBox
            // 
            this.YearOfIssueTextBox.Location = new System.Drawing.Point(165, 125);
            this.YearOfIssueTextBox.Name = "YearOfIssueTextBox";
            this.YearOfIssueTextBox.Size = new System.Drawing.Size(100, 20);
            this.YearOfIssueTextBox.TabIndex = 20;
            this.YearOfIssueTextBox.TextChanged += new System.EventHandler(this.YearOfIssueTextBox_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(165, 19);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 19;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(162, 109);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(71, 13);
            this.ReleaseYearLabel.TabIndex = 17;
            this.ReleaseYearLabel.Text = "ReleaseYear:";
            // 
            // DurationInMinutesLabel
            // 
            this.DurationInMinutesLabel.AutoSize = true;
            this.DurationInMinutesLabel.Location = new System.Drawing.Point(162, 56);
            this.DurationInMinutesLabel.Name = "DurationInMinutesLabel";
            this.DurationInMinutesLabel.Size = new System.Drawing.Size(96, 13);
            this.DurationInMinutesLabel.TabIndex = 16;
            this.DurationInMinutesLabel.Text = "DurationInMinutes:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(162, 3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "Title:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Location = new System.Drawing.Point(3, 3);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(153, 381);
            this.MoviesListBox.TabIndex = 14;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdMovieLabel);
            this.Controls.Add(this.IdMovieTextBox);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.FindMaxRatingButton);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.DurationInMinutesTextBox);
            this.Controls.Add(this.YearOfIssueTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.ReleaseYearLabel);
            this.Controls.Add(this.DurationInMinutesLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MoviesListBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(322, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdMovieLabel;
        private System.Windows.Forms.TextBox IdMovieTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Button FindMaxRatingButton;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox DurationInMinutesTextBox;
        private System.Windows.Forms.TextBox YearOfIssueTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.Label DurationInMinutesLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.ToolTip DurationInMinutesToolTip;
        private System.Windows.Forms.ToolTip YearOfIssueToolTip;
        private System.Windows.Forms.ToolTip RatingToolTip;
    }
}
