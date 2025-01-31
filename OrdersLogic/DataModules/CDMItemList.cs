using Lib.Common.Interfaces;
using Orders.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Logic.Models;

namespace Orders.Logic.DataModules
{
    public class CDMItemList : CDataModule, IDataModuleSimple
    {
        // ....................................................................
        public CItemListModel Model { get { return (CItemListModel)this.model; } }
        // ....................................................................


        // --------------------------------------------------------------------------------------
        public CDMItemList() : base()
        {
            this.model = new CItemListModel(false);
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
