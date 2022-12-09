
namespace ObjectOrientedPractics.View
{
    partial class AddPercentDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PercentDiscountLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategotyLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PercentDiscountLabel
            // 
            this.PercentDiscountLabel.AutoSize = true;
            this.PercentDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentDiscountLabel.Location = new System.Drawing.Point(12, 9);
            this.PercentDiscountLabel.Name = "PercentDiscountLabel";
            this.PercentDiscountLabel.Size = new System.Drawing.Size(109, 13);
            this.PercentDiscountLabel.TabIndex = 0;
            this.PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(70, 38);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(178, 21);
            this.CategoryComboBox.TabIndex = 1;
            // 
            // CategotyLabel
            // 
            this.CategotyLabel.AutoSize = true;
            this.CategotyLabel.Location = new System.Drawing.Point(12, 41);
            this.CategotyLabel.Name = "CategotyLabel";
            this.CategotyLabel.Size = new System.Drawing.Size(52, 13);
            this.CategotyLabel.TabIndex = 2;
            this.CategotyLabel.Text = "Category:";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(159, 79);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 37);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(64, 79);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(89, 37);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AddPercentDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 128);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CategotyLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.PercentDiscountLabel);
            this.MaximumSize = new System.Drawing.Size(276, 167);
            this.MinimumSize = new System.Drawing.Size(276, 167);
            this.Name = "AddPercentDiscountForm";
            this.Text = "AddPercentDiscountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PercentDiscountLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategotyLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
    }
}