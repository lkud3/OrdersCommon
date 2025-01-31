﻿using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Orders.UX
{
    partial class CFormTemplateTable
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
            btnLoadTable = new Button();
            btnSaveTable = new Button();
            gridRecords = new DataGridView();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)gridRecords).BeginInit();
            SuspendLayout();
            // 
            // btnLoadTable
            // 
            btnLoadTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoadTable.Location = new Point(12, 396);
            btnLoadTable.Name = "btnLoadTable";
            btnLoadTable.Size = new Size(128, 48);
            btnLoadTable.TabIndex = 5;
            btnLoadTable.Text = "Load";
            btnLoadTable.UseVisualStyleBackColor = true;
            btnLoadTable.Click += DoOnAnyCommand;
            // 
            // btnSaveTable
            // 
            btnSaveTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveTable.Location = new Point(224, 396);
            btnSaveTable.Name = "btnSaveTable";
            btnSaveTable.Size = new Size(128, 48);
            btnSaveTable.TabIndex = 4;
            btnSaveTable.Text = "Save";
            btnSaveTable.UseVisualStyleBackColor = true;
            btnSaveTable.Click += DoOnAnyCommand;
            // 
            // gridRecords
            // 
            gridRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRecords.Location = new Point(12, 12);
            gridRecords.Name = "gridRecords";
            gridRecords.RowTemplate.Height = 25;
            gridRecords.Size = new Size(651, 378);
            gridRecords.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Location = new Point(358, 396);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 48);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += DoOnAnyCommand;
            // 
            // CFormTemplateTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnLoadTable);
            Controls.Add(btnSaveTable);
            Controls.Add(gridRecords);
            Name = "CFormTemplateTable";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CFormTable";
            ((System.ComponentModel.ISupportInitialize)gridRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadTable;
        private Button btnSaveTable;
        protected DataGridView gridRecords;
        private Button btnCancel;
    }
}