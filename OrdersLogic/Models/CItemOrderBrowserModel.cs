using Lib.Common.Interfaces;
using Orders.Logic.Entities;
using Orders.Logic.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Logic.Models
{
    public class CItemOrderBrowserModel: List<CVItemOrder>
    {
        // ....................................................................
        public IDBTable View = CDBTableFactory.Instance.CreateTable("V_ITEM_ORDER");
        // ....................................................................
        private Dictionary<string, Object> _criteria = new Dictionary<string, object>();
        public Dictionary<string, object> Criteria { get { return _criteria; } }
        // ....................................................................


        // --------------------------------------------------------------------------------------
        public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
        {
            this.Clear();
            p_oEntityLoader.Visit(this.View.RecordSet, this);
        }
        // --------------------------------------------------------------------------------------
    }
}
