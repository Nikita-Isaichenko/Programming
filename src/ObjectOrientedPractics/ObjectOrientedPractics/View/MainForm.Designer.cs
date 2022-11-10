﻿using ObjectOrientedPractics.Properties;
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
            this.ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.CustomerTabPage = new System.Windows.Forms.TabPage();
            this.CustomerTab = new ObjectOrientedPractics.View.Tabs.CustomerTab();
            this.CartTabPage = new System.Windows.Forms.TabPage();
            this.cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.MainTabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomerTabPage.SuspendLayout();
            this.CartTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ItemsTabPage);
            this.MainTabControl.Controls.Add(this.CustomerTabPage);
            this.MainTabControl.Controls.Add(this.CartTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(674, 440);
            this.MainTabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(666, 414);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Location = new System.Drawing.Point(3, 3);
            this.ItemsTab.MinimumSize = new System.Drawing.Size(602, 405);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(660, 408);
            this.ItemsTab.TabIndex = 0;
            // 
            // CustomerTabPage
            // 
            this.CustomerTabPage.Controls.Add(this.CustomerTab);
            this.CustomerTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomerTabPage.Name = "CustomerTabPage";
            this.CustomerTabPage.Size = new System.Drawing.Size(666, 414);
            this.CustomerTabPage.TabIndex = 1;
            this.CustomerTabPage.Text = "Customers";
            this.CustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerTab
            // 
            this.CustomerTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerTab.Location = new System.Drawing.Point(0, 0);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.Size = new System.Drawing.Size(666, 414);
            this.CustomerTab.TabIndex = 0;
            // 
            // CartTabPage
            // 
            this.CartTabPage.Controls.Add(this.cartsTab1);
            this.CartTabPage.Location = new System.Drawing.Point(4, 22);
            this.CartTabPage.Name = "CartTabPage";
            this.CartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartTabPage.Size = new System.Drawing.Size(666, 414);
            this.CartTabPage.TabIndex = 2;
            this.CartTabPage.Text = "Carts";
            this.CartTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            this.cartsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTab1.Location = new System.Drawing.Point(3, 3);
            this.cartsTab1.Name = "cartsTab1";
            this.cartsTab1.Size = new System.Drawing.Size(660, 408);
            this.cartsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 440);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainTabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomerTabPage.ResumeLayout(false);
            this.CartTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private System.Windows.Forms.TabPage CustomerTabPage;
        private View.Tabs.CustomerTab CustomerTab;
        private TabPage CartTabPage;
        private View.Tabs.CartsTab cartsTab1;
    }
}

