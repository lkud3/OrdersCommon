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
    public partial class CFormTableItem : CFormTemplateTable
    {
        private CDMItemList module;
        public CFormTableItem() : base()
        {
            InitializeComponent();

            this.module = new CDMItemList();
        }
        // --------------------------------------------------------------------------------------
        protected override void DisplayModelEntitiesOnGrid()
        {
            editableGridRecords.Populate<CItem>(this.module.Model);
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
