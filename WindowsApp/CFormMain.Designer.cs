﻿namespace WindowsApp
{
    partial class CFormMain
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
            mnuMain = new MenuStrip();
            mnuMasterDetail = new ToolStripMenuItem();
            mnuItemOrder = new ToolStripMenuItem();
            tablesToolStripMenuItem = new ToolStripMenuItem();
            mnuCustomers = new ToolStripMenuItem();
            mnuStores = new ToolStripMenuItem();
            mnuSuppliers = new ToolStripMenuItem();
            mnuItems = new ToolStripMenuItem();
            mnuRecordStatus = new ToolStripMenuItem();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuMasterDetail, tablesToolStripMenuItem });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(800, 24);
            mnuMain.TabIndex = 3;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuMasterDetail
            // 
            mnuMasterDetail.DropDownItems.AddRange(new ToolStripItem[] { mnuItemOrder });
            mnuMasterDetail.Name = "mnuMasterDetail";
            mnuMasterDetail.Size = new Size(55, 20);
            mnuMasterDetail.Text = "Master";
            // 
            // mnuItemOrder
            // 
            mnuItemOrder.Name = "mnuItemOrder";
            mnuItemOrder.Size = new Size(230, 22);
            mnuItemOrder.Text = "Application Items and Orders";
            mnuItemOrder.Click += DoOnAnyCommand;
            // 
            // tablesToolStripMenuItem
            // 
            tablesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuCustomers, mnuStores, mnuSuppliers, mnuItems, mnuRecordStatus });
            tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            tablesToolStripMenuItem.Size = new Size(51, 20);
            tablesToolStripMenuItem.Text = "Tables";
            // 
            // mnuCustomers
            // 
            mnuCustomers.Name = "mnuCustomers";
            mnuCustomers.Size = new Size(171, 22);
            mnuCustomers.Text = "Customers";
            mnuCustomers.Click += DoOnAnyCommand;
            // 
            // mnuItems
            // 
            mnuItems.Name = "mnuitems";
            mnuItems.Size = new Size(171, 22);
            mnuItems.Text = "Items";
            mnuItems.Click += DoOnAnyCommand;
            // 
            // mnuStores
            // 
            mnuStores.Name = "mnuStores";
            mnuStores.Size = new Size(171, 22);
            mnuStores.Text = "Stores";
            mnuStores.Click += DoOnAnyCommand;
            // 
            // mnuSuppliers
            // 
            mnuSuppliers.Name = "mnuSuppliers";
            mnuSuppliers.Size = new Size(230, 22);
            mnuSuppliers.Text = "Suppliers";
            mnuSuppliers.Click += DoOnAnyCommand;
            // 
            // mnuRecordStatus
            // 
            mnuRecordStatus.Name = "mnuRecordStatus";
            mnuRecordStatus.Size = new Size(230, 22);
            mnuRecordStatus.Text = "RecordStatus";
            mnuRecordStatus.Click += DoOnAnyCommand;
            // 
            // CFormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuMain);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Name = "CFormMain";
            Text = "Company Orders Manager Application";
            WindowState = FormWindowState.Maximized;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuMasterDetail;
        private ToolStripMenuItem mnuItemOrder;
        private ToolStripMenuItem tablesToolStripMenuItem;
        private ToolStripMenuItem mnuCustomers;
        private ToolStripMenuItem mnuStores;
        private ToolStripMenuItem mnuSuppliers;
        private ToolStripMenuItem mnuItems;
        private ToolStripMenuItem mnuRecordStatus;
    }
}