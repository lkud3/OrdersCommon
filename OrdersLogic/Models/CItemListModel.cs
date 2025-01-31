using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Logic.Entities;
using Lib.Common.Interfaces;
using Orders.Logic.Visitors;
using System.Net;

namespace Orders.Logic.Models
{
    public class CItemListModel: List<CItem>
    {
        public IDBTable Table = CDBTableFactory.Instance.CreateTable("ITEM");

        private bool _isLookup = false;

        // --------------------------------------------------------------------------------------
        public CItemListModel(bool p_bIsLookup)
        {
            _isLookup = p_bIsLookup;
        }
        // --------------------------------------------------------------------------------------
        public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
        {
            this.Clear();
            if (_isLookup)
                this.Add(new CItem() { Id = -1, Code = "" });  //Lookup entry for null key value
            p_oEntityLoader.Visit(this.Table.RecordSet, this);
        }
        // --------------------------------------------------------------------------------------
        // Synchronizes the table records with the entries in the model, by adding any 
        // missing records to the list Records.
        public void AcceptVisitBeforeSave(IVisitorToModel p_oRecordAdder)
        {
            p_oRecordAdder.Visit(this.Table.RecordSet, this);
        }
        // --------------------------------------------------------------------------------------
    }
}
