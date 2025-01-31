namespace Orders.UX.WinForms
{
    partial class CViewEntityItemOrder
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
            btnDeleteDetail = new Button();
            btnNewDetail = new Button();
            lblId = new Label();
            txtId = new TextBox();
            lblCustomer = new Label();
            cboCustomer = new ComboBox();
            lblStore = new Label();
            cboStore = new ComboBox();
            lblOrderDatetime = new Label();
            dtOrderDatetime = new DateTimePicker();
            lblOrderLines = new Label();
            dgvDetails = new DataGridView();
            lblSupplier = new Label();
            cboSupplier = new ComboBox();
            lblFlag = new Label();
            chkFlag = new CheckBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteDetail
            // 
            btnDeleteDetail.Location = new Point(656, 109);
            btnDeleteDetail.Name = "btnDeleteDetail";
            btnDeleteDetail.Size = new Size(32, 32);
            btnDeleteDetail.TabIndex = 24;
            btnDeleteDetail.Text = "-";
            btnDeleteDetail.UseVisualStyleBackColor = true;
            btnDeleteDetail.Click += DoOnAnyCommand;
            // 
            // btnNewDetail
            // 
            btnNewDetail.Location = new Point(618, 109);
            btnNewDetail.Name = "btnNewDetail";
            btnNewDetail.Size = new Size(32, 32);
            btnNewDetail.TabIndex = 23;
            btnNewDetail.Text = "+";
            btnNewDetail.UseVisualStyleBackColor = true;
            btnNewDetail.Click += DoOnAnyCommand;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(48, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 17;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(326, 23);
            txtId.TabIndex = 13;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(10, 43);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(62, 15);
            lblCustomer.TabIndex = 18;
            lblCustomer.Text = "Customer:";
            // 
            // cboCustomer
            // 
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(118, 40);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(240, 23);
            cboCustomer.TabIndex = 16;
            // 
            // lblStore
            // 
            lblStore.AutoSize = true;
            lblStore.Location = new Point(386, 86);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(37, 15);
            lblStore.TabIndex = 25;
            lblStore.Text = "Store:";
            // 
            // cboStore
            // 
            cboStore.FormattingEnabled = true;
            cboStore.Location = new Point(450, 85);
            cboStore.Name = "cboStore";
            cboStore.Size = new Size(240, 23);
            cboStore.TabIndex = 26;
            // 
            // lblOrderDatetime
            // 
            lblOrderDatetime.AutoSize = true;
            lblOrderDatetime.Location = new Point(8, 101);
            lblOrderDatetime.Name = "lblOrderDatetime";
            lblOrderDatetime.Size = new Size(92, 15);
            lblOrderDatetime.TabIndex = 19;
            lblOrderDatetime.Text = "Order Made On:";
            // 
            // dtOrderDatetime
            // 
            dtOrderDatetime.Format = DateTimePickerFormat.Short;
            dtOrderDatetime.Location = new Point(118, 97);
            dtOrderDatetime.Name = "dtOrderDatetime";
            dtOrderDatetime.ShowCheckBox = true;
            dtOrderDatetime.Size = new Size(215, 23);
            dtOrderDatetime.TabIndex = 14;
            // 
            // lblOrderLines
            // 
            lblOrderLines.AutoSize = true;
            lblOrderLines.Location = new Point(118, 118);
            lblOrderLines.Name = "lblOrderLines";
            lblOrderLines.Size = new Size(154, 15);
            lblOrderLines.TabIndex = 22;
            lblOrderLines.Text = "Items Included in the Order:";
            // 
            // dgvDetails
            // 
            dgvDetails.ColumnHeadersHeight = 46;
            dgvDetails.Location = new Point(118, 147);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.RowHeadersWidth = 82;
            dgvDetails.RowTemplate.Height = 25;
            dgvDetails.Size = new Size(570, 344);
            dgvDetails.TabIndex = 21;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(10, 74);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(53, 15);
            lblSupplier.TabIndex = 27;
            lblSupplier.Text = "Supplier:";
            // 
            // cboSupplier
            // 
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(118, 70);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(240, 23);
            cboSupplier.TabIndex = 28;
            // 
            // lblFlag
            // 
            lblFlag.AutoSize = true;
            lblFlag.Location = new Point(386, 44);
            lblFlag.Name = "lblFlag";
            lblFlag.Size = new Size(87, 15);
            lblFlag.TabIndex = 29;
            lblFlag.Text = "Flag Customer:";
            // 
            // chkFlag
            // 
            chkFlag.AutoSize = true;
            chkFlag.Location = new Point(493, 44);
            chkFlag.Margin = new Padding(2, 1, 2, 1);
            chkFlag.Name = "chkFlag";
            chkFlag.Size = new Size(43, 19);
            chkFlag.TabIndex = 30;
            chkFlag.Text = "Yes";
            chkFlag.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(470, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 31;
            lblStatus.Text = "Status:";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(518, 17);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(170, 23);
            cboStatus.TabIndex = 32;
            // 
            // CViewEntityItemOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 497);
            Controls.Add(cboStatus);
            Controls.Add(lblStatus);
            Controls.Add(chkFlag);
            Controls.Add(lblFlag);
            Controls.Add(cboSupplier);
            Controls.Add(lblSupplier);
            Controls.Add(btnDeleteDetail);
            Controls.Add(btnNewDetail);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblCustomer);
            Controls.Add(cboCustomer);
            Controls.Add(lblStore);
            Controls.Add(cboStore);
            Controls.Add(lblOrderDatetime);
            Controls.Add(dtOrderDatetime);
            Controls.Add(lblOrderLines);
            Controls.Add(dgvDetails);
            Name = "CViewEntityItemOrder";
            Text = "CViewEntityOrderLines";
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteDetail;
        private Button btnNewDetail;
        private Label lblId;
        private TextBox txtId;
        private Label lblCustomer;
        private ComboBox cboCustomer;
        private Label lblStore;
        private ComboBox cboStore;
        private Label lblOrderDatetime;
        private DateTimePicker dtOrderDatetime;
        private Label lblOrderLines;
        private DataGridView dgvDetails;
        private Label lblSupplier;
        private ComboBox cboSupplier;
        private Label lblFlag;
        private CheckBox chkFlag;
        private Label lblStatus;
        private ComboBox cboStatus;
    }
}