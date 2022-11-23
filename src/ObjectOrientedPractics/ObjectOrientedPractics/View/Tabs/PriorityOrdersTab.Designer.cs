
namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedLabel = new System.Windows.Forms.Label();
            this.PriorityOrdersTabAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.CostLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ButtonsTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4.SuspendLayout();
            this.ButtonsTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(56, 80);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(142, 21);
            this.StatusComboBox.TabIndex = 23;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(3, 83);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 22;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel.Location = new System.Drawing.Point(3, 57);
            this.CreatedLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 21;
            this.CreatedLabel.Text = "Created:";
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Location = new System.Drawing.Point(56, 54);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(142, 20);
            this.CreatedTextBox.TabIndex = 20;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(56, 28);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(142, 20);
            this.IdTextBox.TabIndex = 19;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(3, 31);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 18;
            this.IdLabel.Text = "ID:";
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.AutoSize = true;
            this.SelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedLabel.Location = new System.Drawing.Point(3, 3);
            this.SelectedLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(92, 13);
            this.SelectedLabel.TabIndex = 24;
            this.SelectedLabel.Text = "Selected Order";
            // 
            // PriorityOrdersTabAddressControl
            // 
            this.PriorityOrdersTabAddressControl.Address = null;
            this.PriorityOrdersTabAddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityOrdersTabAddressControl.Location = new System.Drawing.Point(3, 107);
            this.PriorityOrdersTabAddressControl.Name = "PriorityOrdersTabAddressControl";
            this.PriorityOrdersTabAddressControl.Size = new System.Drawing.Size(463, 123);
            this.PriorityOrdersTabAddressControl.TabIndex = 25;
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(247, 3);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(93, 13);
            this.PriorityOptionsLabel.TabIndex = 26;
            this.PriorityOptionsLabel.Text = "Priority Options";
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(247, 31);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.DeliveryTimeLabel.TabIndex = 27;
            this.DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(327, 28);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(139, 21);
            this.DeliveryTimeComboBox.TabIndex = 28;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 252);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(463, 95);
            this.ItemsListBox.TabIndex = 30;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(3, 236);
            this.OrderItemsLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(72, 13);
            this.OrderItemsLabel.TabIndex = 29;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.80851F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.19149F));
            this.tableLayoutPanel4.Controls.Add(this.CostLabel, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 366);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(466, 39);
            this.tableLayoutPanel4.TabIndex = 32;
            // 
            // CostLabel
            // 
            this.CostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(104, 5);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(359, 31);
            this.CostLabel.TabIndex = 16;
            this.CostLabel.Text = "0.0";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(413, 350);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(53, 13);
            this.AmountLabel.TabIndex = 31;
            this.AmountLabel.Text = "Amount:";
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveItemButton.Location = new System.Drawing.Point(103, 3);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(94, 37);
            this.RemoveItemButton.TabIndex = 33;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearOrderButton.Location = new System.Drawing.Point(371, 3);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(95, 37);
            this.ClearOrderButton.TabIndex = 34;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddItemButton.Location = new System.Drawing.Point(3, 3);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(94, 37);
            this.AddItemButton.TabIndex = 35;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            // 
            // ButtonsTableLayoutPanel1
            // 
            this.ButtonsTableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsTableLayoutPanel1.ColumnCount = 4;
            this.ButtonsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.36752F));
            this.ButtonsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.36752F));
            this.ButtonsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.89743F));
            this.ButtonsTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.36752F));
            this.ButtonsTableLayoutPanel1.Controls.Add(this.AddItemButton, 0, 0);
            this.ButtonsTableLayoutPanel1.Controls.Add(this.ClearOrderButton, 3, 0);
            this.ButtonsTableLayoutPanel1.Controls.Add(this.RemoveItemButton, 1, 0);
            this.ButtonsTableLayoutPanel1.Location = new System.Drawing.Point(0, 411);
            this.ButtonsTableLayoutPanel1.Name = "ButtonsTableLayoutPanel1";
            this.ButtonsTableLayoutPanel1.RowCount = 1;
            this.ButtonsTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel1.Size = new System.Drawing.Size(469, 43);
            this.ButtonsTableLayoutPanel1.TabIndex = 35;
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonsTableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.DeliveryTimeComboBox);
            this.Controls.Add(this.DeliveryTimeLabel);
            this.Controls.Add(this.PriorityOptionsLabel);
            this.Controls.Add(this.PriorityOrdersTabAddressControl);
            this.Controls.Add(this.SelectedLabel);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.CreatedTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(469, 457);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ButtonsTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedLabel;
        private Controls.AddressControl PriorityOrdersTabAddressControl;
        private System.Windows.Forms.Label PriorityOptionsLabel;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearOrderButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel1;
    }
}
