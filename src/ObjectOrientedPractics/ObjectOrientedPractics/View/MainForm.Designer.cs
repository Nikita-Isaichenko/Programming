using ObjectOrientedPractics.Properties;
using ObjectOrientedPractics.Services;
using System;
using System.Reflection;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.PriorityOrdersTabPage = new System.Windows.Forms.TabPage();
            this.MainItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.MainCustomersTab = new ObjectOrientedPractics.View.Tabs.CustomerTab();
            this.MainCartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.MainPriorityOrdersTab = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.MainOrdersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.MainTabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.PriorityOrdersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ItemsTabPage);
            this.MainTabControl.Controls.Add(this.CustomersTabPage);
            this.MainTabControl.Controls.Add(this.CartsTabPage);
            this.MainTabControl.Controls.Add(this.OrdersTabPage);
            this.MainTabControl.Controls.Add(this.PriorityOrdersTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(680, 461);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.MainItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(672, 435);
            this.ItemsTabPage.TabIndex = 2;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.MainCustomersTab);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(672, 435);
            this.CustomersTabPage.TabIndex = 3;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.MainCartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartsTabPage.Size = new System.Drawing.Size(672, 435);
            this.CartsTabPage.TabIndex = 4;
            this.CartsTabPage.Text = "Carts";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.MainOrdersTab);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(672, 435);
            this.OrdersTabPage.TabIndex = 5;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTabPage
            // 
            this.PriorityOrdersTabPage.Controls.Add(this.MainPriorityOrdersTab);
            this.PriorityOrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.PriorityOrdersTabPage.Name = "PriorityOrdersTabPage";
            this.PriorityOrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PriorityOrdersTabPage.Size = new System.Drawing.Size(672, 435);
            this.PriorityOrdersTabPage.TabIndex = 6;
            this.PriorityOrdersTabPage.Text = "PriorityOrder";
            this.PriorityOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // MainItemsTab
            // 
            this.MainItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainItemsTab.Location = new System.Drawing.Point(3, 3);
            this.MainItemsTab.MinimumSize = new System.Drawing.Size(602, 405);
            this.MainItemsTab.Name = "MainItemsTab";
            this.MainItemsTab.Size = new System.Drawing.Size(666, 429);
            this.MainItemsTab.TabIndex = 0;
            // 
            // MainCustomersTab
            // 
            this.MainCustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainCustomersTab.Location = new System.Drawing.Point(3, 3);
            this.MainCustomersTab.Name = "MainCustomersTab";
            this.MainCustomersTab.Size = new System.Drawing.Size(666, 429);
            this.MainCustomersTab.TabIndex = 0;
            // 
            // MainCartsTab
            // 
            this.MainCartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainCartsTab.Location = new System.Drawing.Point(3, 3);
            this.MainCartsTab.Name = "MainCartsTab";
            this.MainCartsTab.Order = null;
            this.MainCartsTab.Size = new System.Drawing.Size(666, 429);
            this.MainCartsTab.TabIndex = 0;
            // 
            // MainPriorityOrdersTab
            // 
            this.MainPriorityOrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPriorityOrdersTab.Location = new System.Drawing.Point(3, 3);
            this.MainPriorityOrdersTab.Name = "MainPriorityOrdersTab";
            this.MainPriorityOrdersTab.Size = new System.Drawing.Size(666, 429);
            this.MainPriorityOrdersTab.TabIndex = 0;
            // 
            // MainOrdersTab
            // 
            this.MainOrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainOrdersTab.Location = new System.Drawing.Point(3, 3);
            this.MainOrdersTab.Name = "MainOrdersTab";
            this.MainOrdersTab.Size = new System.Drawing.Size(666, 429);
            this.MainOrdersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 461);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainTabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.PriorityOrdersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private TabPage ItemsTabPage;
        private TabPage CustomersTabPage;
        private TabPage CartsTabPage;
        private TabPage OrdersTabPage;
        private TabPage PriorityOrdersTabPage;
        private View.Tabs.PriorityOrdersTab MainPriorityOrdersTab;
        private View.Tabs.ItemsTab MainItemsTab;
        private View.Tabs.CustomerTab MainCustomersTab;
        private View.Tabs.CartsTab MainCartsTab;
        private View.Tabs.OrdersTab MainOrdersTab;
    }
}

