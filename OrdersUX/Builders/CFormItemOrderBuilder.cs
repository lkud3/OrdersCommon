using Lib.UX.DataForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Logic.DataModules;
using Orders.UX.WinForms;

namespace Orders.UX.Builders
{
    public class CFormItemOrderBuilder: CMasterFormBuilder
    {
        protected CDMItemOrder module;
        protected IBrowserViewForm browserView;
        protected Form entityView;

        // --------------------------------------------------------------------------------
        public override void BuildDataModule()
        {
            this.module = new CDMItemOrder();
        }
        // --------------------------------------------------------------------------------
        public override void BuildBrowserView()
        {
            this.browserView = new CViewBrowserItemOrder(this.module.BrowserModel);
        }
        // --------------------------------------------------------------------------------
        public override void BuildEntityView()
        {
            this.entityView = new CViewEntityItemOrder();
        }
        // --------------------------------------------------------------------------------
        public override void BuildForm()
        {
            this.Product = new CFormTemplateMaster(module, browserView, entityView);
        }
        // --------------------------------------------------------------------------------
    }
}
