namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTab
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
            this.SelectedICustomersPanel = new System.Windows.Forms.Panel();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SelectedCustomersLabel = new System.Windows.Forms.Label();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.TableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.FullNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddressToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SelectedICustomersPanel.SuspendLayout();
            this.CustomersPanel.SuspendLayout();
            this.TableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedICustomersPanel
            // 
            this.SelectedICustomersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedICustomersPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectedICustomersPanel.Controls.Add(this.AddressControl);
            this.SelectedICustomersPanel.Controls.Add(this.FullNameTextBox);
            this.SelectedICustomersPanel.Controls.Add(this.IDTextBox);
            this.SelectedICustomersPanel.Controls.Add(this.FullNameLabel);
            this.SelectedICustomersPanel.Controls.Add(this.IDLabel);
            this.SelectedICustomersPanel.Controls.Add(this.SelectedCustomersLabel);
            this.SelectedICustomersPanel.Location = new System.Drawing.Point(239, 3);
            this.SelectedICustomersPanel.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.SelectedICustomersPanel.Name = "SelectedICustomersPanel";
            this.SelectedICustomersPanel.Size = new System.Drawing.Size(360, 399);
            this.SelectedICustomersPanel.TabIndex = 3;
            // 
            // AddressControl
            // 
            this.AddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressControl.AutoSize = true;
            this.AddressControl.Location = new System.Drawing.Point(3, 92);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(353, 123);
            this.AddressControl.TabIndex = 5;
            //
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(62, 55);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(294, 20);
            this.FullNameTextBox.TabIndex = 4;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextBox.Location = new System.Drawing.Point(62, 29);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(97, 20);
            this.IDTextBox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(3, 58);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "FullName:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(3, 32);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(3);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID:";
            // 
            // SelectedCustomersLabel
            // 
            this.SelectedCustomersLabel.AutoSize = true;
            this.SelectedCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomersLabel.Location = new System.Drawing.Point(3, 3);
            this.SelectedCustomersLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SelectedCustomersLabel.Name = "SelectedCustomersLabel";
            this.SelectedCustomersLabel.Size = new System.Drawing.Size(113, 13);
            this.SelectedCustomersLabel.TabIndex = 0;
            this.SelectedCustomersLabel.Text = "Selected Customer";
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersPanel.Controls.Add(this.TableLayoutPanelButtons);
            this.CustomersPanel.Controls.Add(this.CustomersListBox);
            this.CustomersPanel.Controls.Add(this.CustomersLabel);
            this.CustomersPanel.Location = new System.Drawing.Point(3, 3);
            this.CustomersPanel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(234, 399);
            this.CustomersPanel.TabIndex = 2;
            // 
            // TableLayoutPanelButtons
            // 
            this.TableLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TableLayoutPanelButtons.ColumnCount = 3;
            this.TableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelButtons.Controls.Add(this.AddButton, 0, 0);
            this.TableLayoutPanelButtons.Controls.Add(this.GenerateButton, 2, 0);
            this.TableLayoutPanelButtons.Controls.Add(this.RemoveButton, 1, 0);
            this.TableLayoutPanelButtons.Location = new System.Drawing.Point(3, 338);
            this.TableLayoutPanelButtons.Name = "TableLayoutPanelButtons";
            this.TableLayoutPanelButtons.RowCount = 1;
            this.TableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelButtons.Size = new System.Drawing.Size(228, 57);
            this.TableLayoutPanelButtons.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(69, 51);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Enabled = false;
            this.GenerateButton.Location = new System.Drawing.Point(155, 3);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(70, 51);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(79, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(70, 51);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 22);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(0);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(229, 316);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 3);
            this.CustomersLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedICustomersPanel);
            this.Controls.Add(this.CustomersPanel);
            this.Name = "CustomerTab";
            this.Size = new System.Drawing.Size(602, 405);
            this.SelectedICustomersPanel.ResumeLayout(false);
            this.SelectedICustomersPanel.PerformLayout();
            this.CustomersPanel.ResumeLayout(false);
            this.CustomersPanel.PerformLayout();
            this.TableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SelectedICustomersPanel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label SelectedCustomersLabel;
        private System.Windows.Forms.Panel CustomersPanel;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelButtons;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ToolTip FullNameToolTip;
        private System.Windows.Forms.ToolTip AddressToolTip;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button RemoveButton;
        private Controls.AddressControl AddressControl;
    }
}
