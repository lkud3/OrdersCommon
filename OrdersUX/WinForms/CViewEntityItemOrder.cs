﻿using Lib.UX.DataForms;
using Lib.UX.DataGrid;
using Lib.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Orders.Logic.Entities;
using Orders.Logic.DataModules;

namespace Orders.UX.WinForms
{
    public partial class CViewEntityItemOrder : Form, IEntityViewForm
    {
        protected CDMItemOrder module { get; set; }
        protected CEditableGridDecorator detailsGrid;
        protected DataGridViewComboBoxColumn? cbcItem = null;
        // --------------------------------------------------------------------------------------
        public CViewEntityItemOrder()
        {
            InitializeComponent();
        }
        // --------------------------------------------------------------------------------------
        public void SetParent(Form p_oForm)
        {
            CFormTemplateMaster oMasterForm = (CFormTemplateMaster)p_oForm;

            this.detailsGrid = new CEditableGridDecorator(this.dgvDetails, oMasterForm.FormContext);
            oMasterForm.DetailGrids.Add(this.detailsGrid);

            this.module = (CDMItemOrder)oMasterForm.Module;
        }
        // --------------------------------------------------------------------------------------
        public void WriteMasterToUI()
        {
            CItemOrder oCurrentUser = this.module.ItemOrderModel.Master;

            this.txtId.Text = oCurrentUser.Id.ToString();

            this.chkFlag.Checked = oCurrentUser.CustomerFlag == 1;

            this.dtOrderDatetime.Checked = (oCurrentUser.OrderDatetime != null);
            this.dtOrderDatetime.Value = oCurrentUser.OrderDatetime ?? DateTime.Now;

            this.displayCustomerLookup(oCurrentUser);
            this.displaySupplierLookup(oCurrentUser);
            this.displayStoreLookup(oCurrentUser);
            this.displayStatusLookup(oCurrentUser);
        }
        // --------------------------------------------------------------------------------------
        public void ReadMasterFromUI()
        {
            CItemOrder oCurrentUser = this.module.ItemOrderModel.Master;

            if (int.TryParse(this.txtId.Text, out int parsedId))
            {
                oCurrentUser.Id = parsedId;
            }
            else
            {
                oCurrentUser.Id = 0;
            }

            if (this.chkFlag.Checked)
                oCurrentUser.CustomerFlag = 1;
            else
                oCurrentUser.CustomerFlag = 0;

            oCurrentUser.CustomerID = -1;
            oCurrentUser.SupplierID = -1;
            oCurrentUser.StoreCodeID = -1;
            oCurrentUser.StatusID = -1;
            if (this.cboCustomer.SelectedItem != null && this.chkFlag.Checked)
            {
                CCustomer oSelectedCustomer = (CCustomer)(this.cboCustomer.SelectedItem);
                oCurrentUser.CustomerID = oSelectedCustomer.CodeId;
            }
            if (this.cboSupplier.SelectedItem != null && !this.chkFlag.Checked)
            {
                CSupplier oSelectedSupplier = (CSupplier)(this.cboSupplier.SelectedItem);
                oCurrentUser.SupplierID = oSelectedSupplier.CodeId;
            }
            if (this.cboStore.SelectedItem != null)
            {
                CStore oSelectedStore = (CStore)(this.cboStore.SelectedItem);
                oCurrentUser.StoreCodeID = oSelectedStore.CodeId;
            }
            if (this.cboStatus.SelectedItem != null)
            {
                CRecordStatus oSelectedStatus = (CRecordStatus)(this.cboStatus.SelectedItem);
                oCurrentUser.StatusID = oSelectedStatus.CodeId;
            }

            if (this.dtOrderDatetime.Checked)
                oCurrentUser.OrderDatetime = this.dtOrderDatetime.Value.Date;
            else
                oCurrentUser.OrderDatetime = null;

            oCurrentUser.Change = EntityChangeType.UPDATED;
        }
        // --------------------------------------------------------------------------------------
        public void WriteDetailListToUI()
        {
            // [PATTERNS] Proxy
            this.detailsGrid.Populate<CItemOrderLine>(this.module.ItemOrderModel.Details);

            this.addLookupComboBoxOnDetailList();
        }
        // --------------------------------------------------------------------------------------

        #region (( Custom Code for Lookups ))
        // --------------------------------------------------------------------------------------
        private void displayCustomerLookup(CItemOrder p_oCurrentAppUser)
        {
            // Loads all the options
            this.cboCustomer.ValueMember = "CodeID";
            this.cboCustomer.DisplayMember = "Description";
            this.cboCustomer.Items.Clear();
            foreach (CCustomer oPlan in this.module.MasterLookupCustomer)
                this.cboCustomer.Items.Add(oPlan);

            // Run the lookup relation to get the foreign entity and its fiedls;
            p_oCurrentAppUser.LookupCustomer(this.module.MasterLookupCustomer);

            this.cboCustomer.SelectedItem = p_oCurrentAppUser.Customer;
            // [C#] The single ? is for a nullable type. On the right side of the null coalescence operator ?? is what to show in case of null
            this.cboCustomer.Text = p_oCurrentAppUser.Customer?.Name ?? "No name";
        }

        private void displaySupplierLookup(CItemOrder p_oCurrentAppUser)
        {
            // Loads all the options
            this.cboSupplier.ValueMember = "CodeID";
            this.cboSupplier.DisplayMember = "Description";
            this.cboSupplier.Items.Clear();
            foreach (CSupplier oPlan in this.module.MasterLookupSupplier)
                this.cboSupplier.Items.Add(oPlan);

            // Run the lookup relation to get the foreign entity and its fiedls;
            p_oCurrentAppUser.LookupSupplier(this.module.MasterLookupSupplier);

            this.cboSupplier.SelectedItem = p_oCurrentAppUser.Supplier;
            // [C#] The single ? is for a nullable type. On the right side of the null coalescence operator ?? is what to show in case of null
            this.cboSupplier.Text = p_oCurrentAppUser.Supplier?.Name ?? "No name";
        }

        private void displayStoreLookup(CItemOrder p_oCurrentAppUser)
        {
            // Loads all the options
            this.cboStore.ValueMember = "CodeID";
            this.cboStore.DisplayMember = "Description";
            this.cboStore.Items.Clear();
            foreach (CStore oPlan in this.module.MasterLookupStore)
                this.cboStore.Items.Add(oPlan);

            // Run the lookup relation to get the foreign entity and its fiedls;
            p_oCurrentAppUser.LookupStore(this.module.MasterLookupStore);

            this.cboStore.SelectedItem = p_oCurrentAppUser.Store;
            // [C#] The single ? is for a nullable type. On the right side of the null coalescence operator ?? is what to show in case of null
            this.cboStore.Text = p_oCurrentAppUser.Store?.Name ?? "No name";
        }

        private void displayStatusLookup(CItemOrder p_oCurrentAppUser)
        {
            // Loads all the options
            this.cboStatus.ValueMember = "CodeID";
            this.cboStatus.DisplayMember = "Description";
            this.cboStatus.Items.Clear();
            foreach (CRecordStatus oPlan in this.module.MasterLookupStatus)
                this.cboStatus.Items.Add(oPlan);

            // Run the lookup relation to get the foreign entity and its fiedls;
            p_oCurrentAppUser.LookupStatus(this.module.MasterLookupStatus);

            this.cboStatus.SelectedItem = p_oCurrentAppUser.Status;
            // [C#] The single ? is for a nullable type. On the right side of the null coalescence operator ?? is what to show in case of null
            this.cboStatus.Text = p_oCurrentAppUser.Status?.Name ?? "No name";
        }
        // --------------------------------------------------------------------------------------
        protected void addLookupComboBoxOnDetailList()
        {
            //PATTERNS: Lazy Initialization. In this case we will create the column when it is first needed
            //          and prevent for adding it each time we load/create a new master entity
            DataGridViewColumn? oFoundColumn = null;
            int nIndex = 0;
            foreach (DataGridViewColumn oColumn in this.dgvDetails.Columns)
            {
                if (oColumn.DataPropertyName == "ItemName")
                {
                    oFoundColumn = oColumn;
                    break;
                }
                nIndex++;
            }

            if (oFoundColumn != null)
                oFoundColumn.Visible = false;



            this.cbcItem = new DataGridViewComboBoxColumn()
            {
                HeaderText = "Item Name",
                Width = 200,

                ValueMember = "Id",              // The key field of the lookup entity
                DisplayMember = "Code",          // The field that will used for displaying a lookup entity

                DataPropertyName = "ItemId",    // The foreign key field on the detail entity that will receive the selected value

                FlatStyle = FlatStyle.Popup,

            };


            if (oFoundColumn == null)
                this.dgvDetails.Columns.Add(cbcItem);
            else
                this.dgvDetails.Columns.Insert(nIndex, cbcItem);


            // (Re)loads all the options
            this.cbcItem.DataSource = null;
            this.cbcItem.DataSource = this.module.DetailLookup;

        }
        // --------------------------------------------------------------------------------------
        #endregion
        // --------------------------------------------------------------------------------------
        private void DoOnAnyCommand(object sender, EventArgs e)
        {
            if (sender == btnNewDetail)
                this.detailsGrid.CreateRow<CItemOrderLine>(new CItemOrderLine());
            else if (sender == btnDeleteDetail)
                this.detailsGrid.DeleteRow();
        }


        // --------------------------------------------------------------------------------------
    }
}
