﻿using Orders.Logic.DataModules;
using Orders.Logic.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders.UX.WinForms
{
    public partial class CFormTableRecordStatus : CFormTemplateTable
    {
        private CDMRecordStatusList module;
        public CFormTableRecordStatus() : base()
        {
            InitializeComponent();

            this.module = new CDMRecordStatusList();
        }
        // --------------------------------------------------------------------------------------
        protected override void DisplayModelEntitiesOnGrid()
        {
            editableGridRecords.Populate<CRecordStatus>(this.module.Model);
        }
        // --------------------------------------------------------------------------------------
        protected override bool IsModuleLoaded()
        {
            return this.module.IsLoaded;
        }
        // --------------------------------------------------------------------------------------
        protected override bool LoadModule()
        {
            return this.module.ModuleLoad();
        }
        // --------------------------------------------------------------------------------------
        protected override bool SaveModule()
        {
            return this.module.ModuleSave();
        }
        // --------------------------------------------------------------------------------------
        protected override string LastErrorMessage()
        {
            return this.module.LastError;
        }
        // --------------------------------------------------------------------------------------
    }
}
