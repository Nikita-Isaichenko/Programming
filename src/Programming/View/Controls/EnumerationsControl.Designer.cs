namespace Programming.View.Controls
{
    partial class EnumerationsControl
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
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.EnumerationLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.SeasonHandleControl = new SeasonHandleControl();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(339, 23);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.ReadOnly = true;
            this.IntValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntValueTextBox.TabIndex = 12;
            // 
            // EnumListBox
            // 
            this.EnumListBox.FormattingEnabled = true;
            this.EnumListBox.Location = new System.Drawing.Point(3, 23);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.Size = new System.Drawing.Size(142, 186);
            this.EnumListBox.TabIndex = 7;
            this.EnumListBox.SelectedIndexChanged += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(336, 7);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 11;
            this.IntValueLabel.Text = "Int value:";
            // 
            // EnumerationLabel
            // 
            this.EnumerationLabel.AutoSize = true;
            this.EnumerationLabel.Location = new System.Drawing.Point(0, 7);
            this.EnumerationLabel.Name = "EnumerationLabel";
            this.EnumerationLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumerationLabel.TabIndex = 9;
            this.EnumerationLabel.Text = "Choose enumeration:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(168, 7);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueLabel.TabIndex = 10;
            this.ValueLabel.Text = "Choose value:";
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(171, 23);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(142, 186);
            this.ValueListBox.TabIndex = 8;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(339, 49);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(307, 185);
            this.PictureBox.TabIndex = 13;
            this.PictureBox.TabStop = false;
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.IntValueTextBox);
            this.Controls.Add(this.EnumListBox);
            this.Controls.Add(this.IntValueLabel);
            this.Controls.Add(this.EnumerationLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.ValueListBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(649, 237);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // SeasonHandleControl
            //
            this.SeasonHandleControl.OnGoButtonClick += this.PictureBox_UploadImagel;
            


        }

        private void SeasonHandleControl_OnGoButtonClick(string season)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label EnumerationLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.PictureBox PictureBox;
        SeasonHandleControl SeasonHandleControl;
    }
}
