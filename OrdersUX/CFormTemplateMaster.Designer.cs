﻿namespace Orders.UX
{
    partial class CFormTemplateMaster
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
            tabPages = new TabControl();
            tabViewBrowser = new TabPage();
            pnlBrowserCommands = new Panel();
            btnDelete = new Button();
            btnNew = new Button();
            btnOpen = new Button();
            btnRefreshBrowser = new Button();
            pnlBrowser = new Panel();
            dgvBrowser = new DataGridView();
            tabViewEntity = new TabPage();
            pnlEntityView = new Panel();
            pnlEntityCommands = new Panel();
            btnBackToBrowser = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnEntityDelete = new Button();
            btnEntityNew = new Button();
            btnEdit = new Button();
            tabPages.SuspendLayout();
            tabViewBrowser.SuspendLayout();
            pnlBrowserCommands.SuspendLayout();
            pnlBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrowser).BeginInit();
            tabViewEntity.SuspendLayout();
            pnlEntityCommands.SuspendLayout();
            SuspendLayout();
            // 
            // tabPages
            // 
            tabPages.Controls.Add(tabViewBrowser);
            tabPages.Controls.Add(tabViewEntity);
            tabPages.Dock = DockStyle.Fill;
            tabPages.Location = new Point(0, 0);
            tabPages.Name = "tabPages";
            tabPages.SelectedIndex = 0;
            tabPages.Size = new Size(922, 624);
            tabPages.TabIndex = 0;
            tabPages.SelectedIndexChanged += DoOnAnyCommand;
            // 
            // tabViewBrowser
            // 
            tabViewBrowser.Controls.Add(pnlBrowserCommands);
            tabViewBrowser.Controls.Add(pnlBrowser);
            tabViewBrowser.Location = new Point(4, 24);
            tabViewBrowser.Name = "tabViewBrowser";
            tabViewBrowser.Padding = new Padding(3);
            tabViewBrowser.Size = new Size(914, 596);
            tabViewBrowser.TabIndex = 0;
            tabViewBrowser.Text = "Browser";
            tabViewBrowser.UseVisualStyleBackColor = true;
            // 
            // pnlBrowserCommands
            // 
            pnlBrowserCommands.BackColor = Color.LightGray;
            pnlBrowserCommands.Controls.Add(btnDelete);
            pnlBrowserCommands.Controls.Add(btnNew);
            pnlBrowserCommands.Controls.Add(btnOpen);
            pnlBrowserCommands.Controls.Add(btnRefreshBrowser);
            pnlBrowserCommands.Location = new Point(3, 3);
            pnlBrowserCommands.Name = "pnlBrowserCommands";
            pnlBrowserCommands.Size = new Size(200, 590);
            pnlBrowserCommands.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(18, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 44);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += DoOnAnyCommand;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(18, 142);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(164, 44);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += DoOnAnyCommand;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(18, 13);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(164, 44);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += DoOnAnyCommand;
            // 
            // btnRefreshBrowser
            // 
            btnRefreshBrowser.Location = new Point(18, 367);
            btnRefreshBrowser.Name = "btnRefreshBrowser";
            btnRefreshBrowser.Size = new Size(164, 44);
            btnRefreshBrowser.TabIndex = 0;
            btnRefreshBrowser.Text = "Refresh\r\nBrowser";
            btnRefreshBrowser.UseVisualStyleBackColor = true;
            btnRefreshBrowser.Click += DoOnAnyCommand;
            // 
            // pnlBrowser
            // 
            pnlBrowser.Controls.Add(dgvBrowser);
            pnlBrowser.Dock = DockStyle.Right;
            pnlBrowser.Location = new Point(209, 3);
            pnlBrowser.Name = "pnlBrowser";
            pnlBrowser.Size = new Size(702, 590);
            pnlBrowser.TabIndex = 0;
            // 
            // dgvBrowser
            // 
            dgvBrowser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrowser.Dock = DockStyle.Fill;
            dgvBrowser.Location = new Point(0, 0);
            dgvBrowser.Name = "dgvBrowser";
            dgvBrowser.RowTemplate.Height = 25;
            dgvBrowser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBrowser.Size = new Size(702, 590);
            dgvBrowser.TabIndex = 0;
            dgvBrowser.DoubleClick += DoOnAnyCommand;
            // 
            // tabViewEntity
            // 
            tabViewEntity.Controls.Add(pnlEntityView);
            tabViewEntity.Controls.Add(pnlEntityCommands);
            tabViewEntity.Location = new Point(4, 24);
            tabViewEntity.Name = "tabViewEntity";
            tabViewEntity.Padding = new Padding(3);
            tabViewEntity.Size = new Size(914, 596);
            tabViewEntity.TabIndex = 1;
            tabViewEntity.Text = "Entity";
            tabViewEntity.UseVisualStyleBackColor = true;
            // 
            // pnlEntityView
            // 
            pnlEntityView.Dock = DockStyle.Fill;
            pnlEntityView.Location = new Point(203, 3);
            pnlEntityView.Name = "pnlEntityView";
            pnlEntityView.Size = new Size(708, 590);
            pnlEntityView.TabIndex = 11;
            // 
            // pnlEntityCommands
            // 
            pnlEntityCommands.BackColor = Color.LightGray;
            pnlEntityCommands.Controls.Add(btnBackToBrowser);
            pnlEntityCommands.Controls.Add(btnCancel);
            pnlEntityCommands.Controls.Add(btnSave);
            pnlEntityCommands.Controls.Add(btnEntityDelete);
            pnlEntityCommands.Controls.Add(btnEntityNew);
            pnlEntityCommands.Controls.Add(btnEdit);
            pnlEntityCommands.Dock = DockStyle.Left;
            pnlEntityCommands.Location = new Point(3, 3);
            pnlEntityCommands.Name = "pnlEntityCommands";
            pnlEntityCommands.Size = new Size(200, 590);
            pnlEntityCommands.TabIndex = 10;
            // 
            // btnBackToBrowser
            // 
            btnBackToBrowser.Location = new Point(19, 16);
            btnBackToBrowser.Name = "btnBackToBrowser";
            btnBackToBrowser.Size = new Size(80, 44);
            btnBackToBrowser.TabIndex = 8;
            btnBackToBrowser.Text = "<--";
            btnBackToBrowser.UseVisualStyleBackColor = true;
            btnBackToBrowser.Click += DoOnAnyCommand;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(19, 236);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(164, 44);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += DoOnAnyCommand;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(18, 186);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 44);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += DoOnAnyCommand;
            // 
            // btnEntityDelete
            // 
            btnEntityDelete.Location = new Point(19, 367);
            btnEntityDelete.Name = "btnEntityDelete";
            btnEntityDelete.Size = new Size(164, 44);
            btnEntityDelete.TabIndex = 5;
            btnEntityDelete.Text = "Delete";
            btnEntityDelete.UseVisualStyleBackColor = true;
            btnEntityDelete.Click += DoOnAnyCommand;
            // 
            // btnEntityNew
            // 
            btnEntityNew.Location = new Point(19, 317);
            btnEntityNew.Name = "btnEntityNew";
            btnEntityNew.Size = new Size(164, 44);
            btnEntityNew.TabIndex = 4;
            btnEntityNew.Text = "New";
            btnEntityNew.UseVisualStyleBackColor = true;
            btnEntityNew.Click += DoOnAnyCommand;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(102, 16);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 44);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += DoOnAnyCommand;
            // 
            // CFormTemplateMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 624);
            Controls.Add(tabPages);
            Name = "CFormTemplateMaster";
            Text = "Master Form";
            FormClosed += DoOnFormClosed;
            tabPages.ResumeLayout(false);
            tabViewBrowser.ResumeLayout(false);
            pnlBrowserCommands.ResumeLayout(false);
            pnlBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBrowser).EndInit();
            tabViewEntity.ResumeLayout(false);
            pnlEntityCommands.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPages;
        private TabPage tabViewBrowser;
        private DataGridView dgvBrowser;
        private TabPage tabViewEntity;
        private Panel pnlBrowserCommands;
        private Panel pnlBrowser;
        private Button btnDelete;
        private Button btnNew;
        private Button btnOpen;
        private Button btnRefreshBrowser;
        private Panel pnlEntityCommands;
        private Button btnEntityDelete;
        private Button btnEntityNew;
        private Button btnEdit;
        private Button btnSave;
        private Button btnCancel;
        private Button btnBackToBrowser;
        private Panel pnlEntityView;
    }
}