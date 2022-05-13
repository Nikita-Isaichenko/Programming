namespace Programming.View.Controls
{
    partial class RectanglesControl
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
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.IdRectangleLabel = new System.Windows.Forms.Label();
            this.YСoordinateTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.YСoordinateLabel = new System.Windows.Forms.Label();
            this.XСoordinateTextBox = new System.Windows.Forms.TextBox();
            this.FindMaxWidthButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.XСoordinateLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LenghtTextBox = new System.Windows.Forms.TextBox();
            this.LengthToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WidthToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Location = new System.Drawing.Point(165, 284);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.ReadOnly = true;
            this.IdRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdRectangleTextBox.TabIndex = 31;
            // 
            // IdRectangleLabel
            // 
            this.IdRectangleLabel.AutoSize = true;
            this.IdRectangleLabel.Location = new System.Drawing.Point(162, 268);
            this.IdRectangleLabel.Name = "IdRectangleLabel";
            this.IdRectangleLabel.Size = new System.Drawing.Size(19, 13);
            this.IdRectangleLabel.TabIndex = 30;
            this.IdRectangleLabel.Text = "Id:";
            // 
            // YСoordinateTextBox
            // 
            this.YСoordinateTextBox.Location = new System.Drawing.Point(165, 231);
            this.YСoordinateTextBox.Name = "YСoordinateTextBox";
            this.YСoordinateTextBox.ReadOnly = true;
            this.YСoordinateTextBox.Size = new System.Drawing.Size(100, 20);
            this.YСoordinateTextBox.TabIndex = 29;
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(153, 381);
            this.RectanglesListBox.TabIndex = 18;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // YСoordinateLabel
            // 
            this.YСoordinateLabel.AutoSize = true;
            this.YСoordinateLabel.Location = new System.Drawing.Point(162, 215);
            this.YСoordinateLabel.Name = "YСoordinateLabel";
            this.YСoordinateLabel.Size = new System.Drawing.Size(17, 13);
            this.YСoordinateLabel.TabIndex = 27;
            this.YСoordinateLabel.Text = "Y:";
            // 
            // XСoordinateTextBox
            // 
            this.XСoordinateTextBox.Location = new System.Drawing.Point(165, 178);
            this.XСoordinateTextBox.Name = "XСoordinateTextBox";
            this.XСoordinateTextBox.ReadOnly = true;
            this.XСoordinateTextBox.Size = new System.Drawing.Size(100, 20);
            this.XСoordinateTextBox.TabIndex = 28;
            // 
            // FindMaxWidthButton
            // 
            this.FindMaxWidthButton.Location = new System.Drawing.Point(165, 361);
            this.FindMaxWidthButton.Name = "FindMaxWidthButton";
            this.FindMaxWidthButton.Size = new System.Drawing.Size(100, 23);
            this.FindMaxWidthButton.TabIndex = 25;
            this.FindMaxWidthButton.Text = "Find";
            this.FindMaxWidthButton.UseVisualStyleBackColor = true;
            this.FindMaxWidthButton.Click += new System.EventHandler(this.FindMaxWidthButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(162, 109);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 24;
            this.ColorLabel.Text = "Color:";
            // 
            // XСoordinateLabel
            // 
            this.XСoordinateLabel.AutoSize = true;
            this.XСoordinateLabel.Location = new System.Drawing.Point(162, 162);
            this.XСoordinateLabel.Name = "XСoordinateLabel";
            this.XСoordinateLabel.Size = new System.Drawing.Size(17, 13);
            this.XСoordinateLabel.TabIndex = 26;
            this.XСoordinateLabel.Text = "X:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(162, 56);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 23;
            this.WidthLabel.Text = "Width:";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(162, 3);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(43, 13);
            this.LenghtLabel.TabIndex = 22;
            this.LenghtLabel.Text = "Length:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(165, 125);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox.TabIndex = 21;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(165, 72);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 20;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.Location = new System.Drawing.Point(165, 19);
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(100, 20);
            this.LenghtTextBox.TabIndex = 19;
            this.LenghtTextBox.TextChanged += new System.EventHandler(this.LenghtTextBox_TextChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdRectangleTextBox);
            this.Controls.Add(this.IdRectangleLabel);
            this.Controls.Add(this.YСoordinateTextBox);
            this.Controls.Add(this.RectanglesListBox);
            this.Controls.Add(this.YСoordinateLabel);
            this.Controls.Add(this.XСoordinateTextBox);
            this.Controls.Add(this.FindMaxWidthButton);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.XСoordinateLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.LenghtLabel);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.LenghtTextBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(322, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdRectangleTextBox;
        private System.Windows.Forms.Label IdRectangleLabel;
        private System.Windows.Forms.TextBox YСoordinateTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label YСoordinateLabel;
        private System.Windows.Forms.TextBox XСoordinateTextBox;
        private System.Windows.Forms.Button FindMaxWidthButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label XСoordinateLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LenghtTextBox;
        private System.Windows.Forms.ToolTip LengthToolTip;
        private System.Windows.Forms.ToolTip WidthToolTip;
    }
}
