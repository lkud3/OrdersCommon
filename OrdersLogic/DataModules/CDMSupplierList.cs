using Lib.Common.Interfaces;
using Orders.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Logic.DataModules
{
    public class CDMSupplierList: CDataModule, IDataModuleSimple
    {
        // ....................................................................
        public CSupplierListModel Model { get { return (CSupplierListModel)this.model; } }
        // ....................................................................


        // --------------------------------------------------------------------------------------
        public CDMSupplierList() : base()
        {
            this.model = new CSupplierListModel(false);
        }
        // --------------------------------------------------------------------------------------

        #region // IDataModuleSimple \\
        public bool ModuleLoad()
        {
            bool bResult = false;
            try
            {
                Model?.Table.LoadTable(null);
                Model?.AcceptVisitAfterLoad(this.entityLoader);
                this.IsLoaded = true;
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleSave()
        {
            bool bResult = false;
            try
            {
                Model?.AcceptVisitBeforeSave(this.recordAdder);
                Model?.Table.SaveTable(null);

                //[PATTERNS] Observer: We send a notification to all modules to reload their lookups.
                // For example: We have saved a new record and we would like it to become immediately available
                // to any other module/form that uses this as a lookup table.
                CDataModuleObserver.Instance.NotifyAllToReloadLookups();

                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        // --------------------------------------------------------------------------------------
        #endregion
    }
}
