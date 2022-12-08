
namespace ObjectOrientedPractics.View.Controls
{
    partial class PointerDiscountControl
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
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProductAmountLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.DiscountNumberLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountLabel.Location = new System.Drawing.Point(38, 3);
            this.DiscountLabel.Margin = new System.Windows.Forms.Padding(1, 3, 3, 0);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(164, 13);
            this.DiscountLabel.TabIndex = 0;
            this.DiscountLabel.Text = "Накопительная - 0 баллов";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(3, 3);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(33, 13);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Info:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateButton.Location = new System.Drawing.Point(163, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 46);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculateButton.Location = new System.Drawing.Point(3, 3);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(74, 46);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyButton.Location = new System.Drawing.Point(83, 3);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(74, 46);
            this.ApplyButton.TabIndex = 4;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ApplyButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CalculateButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpdateButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 52);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ProductAmountLabel
            // 
            this.ProductAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductAmountLabel.AutoSize = true;
            this.ProductAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductAmountLabel.Location = new System.Drawing.Point(305, 3);
            this.ProductAmountLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 0);
            this.ProductAmountLabel.Name = "ProductAmountLabel";
            this.ProductAmountLabel.Size = new System.Drawing.Size(101, 13);
            this.ProductAmountLabel.TabIndex = 6;
            this.ProductAmountLabel.Text = "Product Amount:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(263, 22);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriceLabel.Size = new System.Drawing.Size(143, 37);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "0";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountLabel.Location = new System.Drawing.Point(299, 62);
            this.DiscountAmountLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 0);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(107, 13);
            this.DiscountAmountLabel.TabIndex = 8;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountNumberLabel
            // 
            this.DiscountNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountNumberLabel.Location = new System.Drawing.Point(269, 78);
            this.DiscountNumberLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 0);
            this.DiscountNumberLabel.Name = "DiscountNumberLabel";
            this.DiscountNumberLabel.Size = new System.Drawing.Size(137, 33);
            this.DiscountNumberLabel.TabIndex = 9;
            this.DiscountNumberLabel.Text = "0";
            this.DiscountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PointerDiscountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DiscountNumberLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductAmountLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.DiscountLabel);
            this.Name = "PointerDiscountControl";
            this.Size = new System.Drawing.Size(427, 121);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ProductAmountLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.Label DiscountNumberLabel;
    }
}
