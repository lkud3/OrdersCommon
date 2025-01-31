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
    public class CRecordStatusListModel : List<CRecordStatus>
    {
        public IDBTable Table = CDBTableFactory.Instance.CreateTable("RECORD_STATUS");

        private bool _isLookup = false;

        // --------------------------------------------------------------------------------------
        public CRecordStatusListModel(bool p_bIsLookup)
        {
            _isLookup = p_bIsLookup;
        }
        // --------------------------------------------------------------------------------------
        public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
        {
            this.Clear();
            if (_isLookup)
                this.Add(new CRecordStatus() { CodeId = -1, Name = "" });  //Lookup entry for null key value
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
