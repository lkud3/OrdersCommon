using Orders.Logic.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Logic
{
    public class CDataModule
    {
        private static int _nextModuleID = 1;

        // ....................................................................
        private int _moduleID;
        public int ModuleID { get { return _moduleID; } }
        // ....................................................................
        public string LastError { get; set; }
        // ....................................................................
        public bool IsLoaded { get; set; }
        // ....................................................................
        protected Object model = null;
        // ....................................................................
        protected CVisitorEntityLoader entityLoader;
        protected CVisitorRecordAdder recordAdder;
        // ....................................................................

        // --------------------------------------------------------------------------------------
        public CDataModule()
        {
            //TECHNIQUE: Having an auto-increment ID for each new object instance.
            _moduleID = _nextModuleID;
            _nextModuleID++;

            LastError = "";
            IsLoaded = false;
            this.entityLoader = new CVisitorEntityLoader();
            this.recordAdder = new CVisitorRecordAdder();
        }
        // --------------------------------------------------------------------------------------
    }
}
