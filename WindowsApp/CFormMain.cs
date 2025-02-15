﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Orders.Logic.DataModules;
using Orders.Logic.Entities;
using Orders.UX;
using Orders.UX.Builders;
using Orders.UX.WinForms;
using Lib.Common.Interfaces;
using Lib.UX.DataForms.MasterForm;

namespace WindowsApp
{
    public partial class CFormMain : Form
    {
        public CFormTableCustomer? FormTableCustomer = null;
        public CFormTableSupplier? FormTableSupplier = null;
        public CFormTableItem? FormTableItem = null;
        public CFormTableStore? FormTableStore = null;
        public CFormTableRecordStatus? FormTableRecordStatus = null;

        // --------------------------------------------------------------------------------------
        public CFormMain()
        {
            InitializeComponent();
        }
        // --------------------------------------------------------------------------------------
        private void DoOnAnyCommand(object sender, EventArgs e)
        {
            if (sender == mnuItemOrder)
                //new CMasterFormDirector(new CFormAppUserBuilder()).ConstructUX(this).Show();
                new CMasterFormDirector(new CFormItemOrderBuilder()).ConstructUX(this).Show();
            else if (sender == mnuCustomers)
            {
                //[C#] This shows a modal form, i.e. freezing all other forms.
                if (FormTableCustomer == null)
                    FormTableCustomer = new CFormTableCustomer();
                FormTableCustomer?.ShowDialog(); 
            }
            else if (sender == mnuSuppliers)
            {
                //[C#] This shows a modal form, i.e. freezing all other forms.
                if (FormTableSupplier == null)
                    FormTableSupplier = new CFormTableSupplier();
                FormTableSupplier?.ShowDialog();
            }
            else if (sender == mnuStores)
            {
                //[C#] This shows a modal form, i.e. freezing all other forms.
                if (FormTableStore == null)
                    FormTableStore = new CFormTableStore();
                FormTableStore?.ShowDialog();
            }
            else if (sender == mnuItems)
            {
                CFormTableItem oFormTableItem = new CFormTableItem();
                oFormTableItem.MdiParent = this;
                oFormTableItem?.Show();
            }
            else if (sender == mnuRecordStatus)
            {
                CFormTableRecordStatus oFormTableRecordStatus = new CFormTableRecordStatus();
                oFormTableRecordStatus.MdiParent = this;
                oFormTableRecordStatus?.Show();
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
