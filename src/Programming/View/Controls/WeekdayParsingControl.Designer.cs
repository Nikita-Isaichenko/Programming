namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayOutputLabel = new System.Windows.Forms.Label();
            this.WeekdayTitleLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Location = new System.Drawing.Point(3, 23);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(224, 20);
            this.ParsingTextBox.TabIndex = 0;
            // 
            // WeekdayOutputLabel
            // 
            this.WeekdayOutputLabel.AutoSize = true;
            this.WeekdayOutputLabel.Location = new System.Drawing.Point(3, 46);
            this.WeekdayOutputLabel.Name = "WeekdayOutputLabel";
            this.WeekdayOutputLabel.Size = new System.Drawing.Size(7, 13);
            this.WeekdayOutputLabel.TabIndex = 6;
            this.WeekdayOutputLabel.Text = "\r\n";
            // 
            // WeekdayTitleLabel
            // 
            this.WeekdayTitleLabel.AutoSize = true;
            this.WeekdayTitleLabel.Location = new System.Drawing.Point(0, 7);
            this.WeekdayTitleLabel.Name = "WeekdayTitleLabel";
            this.WeekdayTitleLabel.Size = new System.Drawing.Size(115, 13);
            this.WeekdayTitleLabel.TabIndex = 5;
            this.WeekdayTitleLabel.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(233, 21);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 4;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParsingTextBox);
            this.Controls.Add(this.WeekdayOutputLabel);
            this.Controls.Add(this.WeekdayTitleLabel);
            this.Controls.Add(this.ParseButton);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(322, 151);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ParsingTextBox;
        private System.Windows.Forms.Label WeekdayOutputLabel;
        private System.Windows.Forms.Label WeekdayTitleLabel;
        private System.Windows.Forms.Button ParseButton;
    }
}
