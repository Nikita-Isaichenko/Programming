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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
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
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.RemoveButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.AddButtonPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButtonPictureBox)).BeginInit();
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
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(267, 11);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(412, 405);
            this.CanvasPanel.TabIndex = 16;
            // 
            // RemoveButtonPictureBox
            // 
            this.RemoveButtonPictureBox.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveButtonPictureBox.Location = new System.Drawing.Point(160, 167);
            this.RemoveButtonPictureBox.Name = "RemoveButtonPictureBox";
            this.RemoveButtonPictureBox.Size = new System.Drawing.Size(46, 23);
            this.RemoveButtonPictureBox.TabIndex = 33;
            this.RemoveButtonPictureBox.TabStop = false;
            this.RemoveButtonPictureBox.Click += new System.EventHandler(this.RemoveButtonPictureBox_Click);
            this.RemoveButtonPictureBox.MouseEnter += new System.EventHandler(this.RemoveButtonPictureBox_MouseEnter);
            this.RemoveButtonPictureBox.MouseLeave += new System.EventHandler(this.RemoveButtonPictureBox_MouseLeave);
            // 
            // AddButtonPictureBox
            // 
            this.AddButtonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AddButtonPictureBox.Image")));
            this.AddButtonPictureBox.Location = new System.Drawing.Point(60, 167);
            this.AddButtonPictureBox.Name = "AddButtonPictureBox";
            this.AddButtonPictureBox.Size = new System.Drawing.Size(46, 23);
            this.AddButtonPictureBox.TabIndex = 32;
            this.AddButtonPictureBox.TabStop = false;
            this.AddButtonPictureBox.Click += new System.EventHandler(this.AddButtonPictureBox_Click);
            this.AddButtonPictureBox.MouseEnter += new System.EventHandler(this.AddButtonPictureBox_MouseEnter);
            this.AddButtonPictureBox.MouseLeave += new System.EventHandler(this.AddButtonPictureBox_MouseLeave);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveButtonPictureBox);
            this.Controls.Add(this.AddButtonPictureBox);
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
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.RectanglesListBox);
            this.Controls.Add(this.CanvasPanel);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(685, 426);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButtonPictureBox)).EndInit();
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
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.PictureBox AddButtonPictureBox;
        private System.Windows.Forms.PictureBox RemoveButtonPictureBox;
    }
}
