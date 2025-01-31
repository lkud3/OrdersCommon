using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Logic.Visitors;
using Orders.Logic.Entities;
using Lib.Common.Interfaces;

namespace Orders.Logic.Models
{
    public class CSupplierListModel : List<CSupplier>
    {
        public IDBTable Table = CDBTableFactory.Instance.CreateTable("SUPPLIER");

        private bool _isLookup = false;

        // --------------------------------------------------------------------------------------
        public CSupplierListModel(bool p_bIsLookup)
        {
            _isLookup = p_bIsLookup;
        }
        // --------------------------------------------------------------------------------------
        public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
        {
            this.Clear();
            if (_isLookup)
                this.Add(new CSupplier() { CodeId = -1, Name = "" });  //Lookup entry for null key value
            p_oEntityLoader.Visit(this.Table.RecordSet, this);
        }
        // --------------------------------------------------------------------------------------
        public void AcceptVisitBeforeSave(IVisitorToModel p_oRecordAdder)
        {
            p_oRecordAdder.Visit(this.Table.RecordSet, this);
        }
        // --------------------------------------------------------------------------------------
    }
}
