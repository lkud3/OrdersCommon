using Lib.UX.DataForms.TableForm;
using Lib.UX.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders.UX
{
    public partial class CFormTemplateTable : Form
    {
        protected CEditableGridDecorator editableGridRecords;
        protected CTableFormContext formContext;
        public CFormTemplateTable()
        {
            InitializeComponent();

            this.formContext = new CTableFormContext(this.btnLoadTable, this.btnSaveTable, this.btnCancel);
            this.formContext.Initialize(typeof(CTableFormStateInitial));


            this.editableGridRecords = new CEditableGridDecorator(this.gridRecords, this.formContext);
        }
        // --------------------------------------------------------------------------------------

        private void doLoad()
        {
            if (LoadModule())
            {
                this.DisplayModelEntitiesOnGrid();
                this.formContext.PerformAction("TableLoaded");
            }
            else
                MessageBox.Show(LastErrorMessage(), " Error");
        }
        // --------------------------------------------------------------------------------------

        private void doSave()
        {
            DialogResult oResult = MessageBox.Show("Save changes?", "Warning"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (oResult == DialogResult.Yes)
            {
                if (SaveModule())
                {
                    this.gridRecords.DataSource = null;
                    if (LoadModule())
                    {
                        this.DisplayModelEntitiesOnGrid();
                        this.formContext.PerformAction("TableLoaded");
                    }
                    else
                        MessageBox.Show(LastErrorMessage(), "Error");
                }
                else
                    MessageBox.Show(LastErrorMessage(), "Error");
            }
        }
        // --------------------------------------------------------------------------------------
        private void doCancel()
        {
            DialogResult oResult = MessageBox.Show("Cancel changes?", "Warning"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (oResult == DialogResult.Yes)
                doLoad();
        }
        // --------------------------------------------------------------------------------------

        private void DoOnAnyCommand(object sender, EventArgs e)
        {
            if (sender == this.btnLoadTable)
                doLoad();
            else if (sender == this.btnSaveTable)
                doSave();
            else
                doCancel();
        }
        // --------------------------------------------------------------------------------------

        #region // Virtual Methods \\
        // --------------------------------------------------------------------------------------
        protected virtual void CreateDataModule()
        {
        }
        // --------------------------------------------------------------------------------------
        protected virtual void DisplayModelEntitiesOnGrid()
        {
        }
        // --------------------------------------------------------------------------------------
        protected virtual bool IsModuleLoaded()
        {
            return false;
        }
        // --------------------------------------------------------------------------------------
        protected virtual bool LoadModule()
        {
            return false;
        }
        // --------------------------------------------------------------------------------------
        protected virtual bool SaveModule()
        {
            return false;
        }
        // --------------------------------------------------------------------------------------
        protected virtual string LastErrorMessage()
        {
            return String.Empty;
        }
        // --------------------------------------------------------------------------------------
        #endregion
    }
}
