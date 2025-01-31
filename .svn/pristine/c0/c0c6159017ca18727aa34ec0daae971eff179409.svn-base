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
    public class CCustomerListModel : List<CCustomer>
    {
        public IDBTable Table = CDBTableFactory.Instance.CreateTable("CUSTOMER");

        private bool _isLookup = false;

        // --------------------------------------------------------------------------------------
        public CCustomerListModel(bool p_bIsLookup)
        {
            _isLookup = p_bIsLookup;
        }
        // --------------------------------------------------------------------------------------
        public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
        {
            this.Clear();
            if (_isLookup)
                this.Add(new CCustomer() { CodeId = -1, Name = "" });  //Lookup entry for null key value
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
