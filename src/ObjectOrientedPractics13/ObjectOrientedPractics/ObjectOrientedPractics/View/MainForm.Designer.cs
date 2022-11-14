namespace ObjectOrientedPractics
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
            this.itemspafd = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.SuspendLayout();
            // 
            // itemspafd
            // 
            this.itemspafd.Location = new System.Drawing.Point(95, 2);
            this.itemspafd.MinimumSize = new System.Drawing.Size(602, 405);
            this.itemspafd.Name = "itemspafd";
            this.itemspafd.Size = new System.Drawing.Size(602, 405);
            this.itemspafd.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemspafd);
            this.Name = "MainForm";
            this.Text = "ObjectOrientedPractics";
            this.ResumeLayout(false);

        }


        #endregion

        private View.Tabs.ItemsTab itemspafd;
    }
}

