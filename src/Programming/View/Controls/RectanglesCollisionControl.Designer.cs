namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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
            this.LengthLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedRectanglesLabel = new System.Windows.Forms.Label();
            this.LenghtTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.Canva = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(11, 366);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(43, 13);
            this.LengthLabel.TabIndex = 31;
            this.LengthLabel.Text = "Lenght:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(16, 340);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 30;
            this.WidthLabel.Text = "Width:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(37, 314);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 29;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(37, 288);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 28;
            this.XLabel.Text = "X:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(35, 262);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 27;
            this.IdLabel.Text = "Id:";
            // 
            // SelectedRectanglesLabel
            // 
            this.SelectedRectanglesLabel.AutoSize = true;
            this.SelectedRectanglesLabel.Location = new System.Drawing.Point(7, 232);
            this.SelectedRectanglesLabel.Name = "SelectedRectanglesLabel";
            this.SelectedRectanglesLabel.Size = new System.Drawing.Size(109, 13);
            this.SelectedRectanglesLabel.TabIndex = 26;
            this.SelectedRectanglesLabel.Text = "Selected Rectangles:";
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.Location = new System.Drawing.Point(60, 363);
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(100, 20);
            this.LenghtTextBox.TabIndex = 25;
            this.LenghtTextBox.TextChanged += new System.EventHandler(this.LenghtTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(60, 337);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 24;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(60, 311);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 20);
            this.YTextBox.TabIndex = 23;
            this.YTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(60, 285);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 20);
            this.XTextBox.TabIndex = 22;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(60, 259);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 21;
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(145, 167);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveRectangleButton.TabIndex = 20;
            this.RemoveRectangleButton.Text = "Remove";
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Location = new System.Drawing.Point(50, 167);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(75, 23);
            this.AddRectangleButton.TabIndex = 19;
            this.AddRectangleButton.Text = "Add";
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(7, 11);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesLabel.TabIndex = 18;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(10, 27);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(250, 134);
            this.RectanglesListBox.TabIndex = 17;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // Canva
            // 
            this.Canva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canva.Location = new System.Drawing.Point(267, 11);
            this.Canva.Name = "Canva";
            this.Canva.Size = new System.Drawing.Size(389, 403);
            this.Canva.TabIndex = 16;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SelectedRectanglesLabel);
            this.Controls.Add(this.LenghtTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.RemoveRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.RectanglesListBox);
            this.Controls.Add(this.Canva);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(662, 424);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedRectanglesLabel;
        private System.Windows.Forms.TextBox LenghtTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Panel Canva;
    }
}
