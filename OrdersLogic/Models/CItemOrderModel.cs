using Lib.Common.Interfaces;
using Lib.Logic;
using Orders.Data;
using Orders.Logic.Entities;
using Orders.Logic.Visitors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Logic.Models
{
    public class CItemOrderModel: List<CItemOrder>, IMasterDetailModel
    {
        // ....................................................................
        public IDBTable MasterTable = CDBTableFactory.Instance.CreateTable("ITEM_ORDER");
        public IDBTable DetailTable = CDBTableFactory.Instance.CreateTable("ITEM_ORDER_LINE");
        // ....................................................................
        public CItemOrder Master
        {
            get
            {
                if (this.Count == 0)
                    return null;
                else
                    return this[0];
            }
        }
        // ....................................................................
        public List<CItemOrderLine> Details = new List<CItemOrderLine>();
        // ....................................................................

        // --------------------------------------------------------------------------------------
        public CItemOrderModel()
        {
        }
        // --------------------------------------------------------------------------------------

        #region // IMasterDetailModel \\
        // --------------------------------------------------------------------------------------
        public IEntity NewMasterDetail()
        {
            this.Clear();
            this.MasterTable?.RecordSet.Clear();

            this.Details.Clear();
            this.DetailTable?.RecordSet.Clear();

            CItemOrder oNewMasterEntity = new CItemOrder();
            oNewMasterEntity.Change = EntityChangeType.CREATED;
            this.Add(oNewMasterEntity);
            this.Details.Clear();

            return oNewMasterEntity;
        }
        // --------------------------------------------------------------------------------------
        public void LoadMasterDetail(int p_nMasterKeyValue)
        {
            this.MasterTable.LoadRecord(p_nMasterKeyValue);
            this.DetailTable.LoadTable(null, p_nMasterKeyValue);
        }
        // --------------------------------------------------------------------------------------
        public int SaveMasterDetail()
        {
            int nMasterID;
            using (IDbTransaction iTransaction = CData.Instance.DB.BeginTransaction())
            {
                try
                {
                    // When not deleting, first insert/update the master
                    if (this.Master.Change != EntityChangeType.DELETED)
                        this.MasterTable?.SaveTable(iTransaction);

                    // Get the ID of the master and copy to the foreign key in the details.
                    nMasterID = this.Master.Id;
                    foreach (var oDetail in this.Details)
                        oDetail.ItemOrderId = nMasterID;

                    this.DetailTable?.SaveTable(iTransaction);        // Insert/update the details.

                    // When deleting delete the master after you've deleted the dateils
                    if (this.Master.Change == EntityChangeType.DELETED)
                        this.MasterTable?.SaveTable(iTransaction);          // First insert/update the master.

                    iTransaction.Commit();
                }
                catch
                {
                    iTransaction.Rollback();
                    throw;
                }
            }
            return nMasterID;
        }
        // --------------------------------------------------------------------------------------
        public void DeleteMasterDetail()
        {
            this.Master.Change = EntityChangeType.DELETED;
            foreach (var oDetail in this.Details)
                oDetail.Change = EntityChangeType.DELETED;
            SaveMasterDetail();
        }
        // --------------------------------------------------------------------------------------
        public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
        {
            this.Clear();
            p_oEntityLoader.Visit(this.MasterTable.RecordSet, this);
            this.Details.Clear();
            p_oEntityLoader.Visit(this.DetailTable.RecordSet, this.Details);
        }
        // --------------------------------------------------------------------------------------
        // Synchronizes the table records with the entities in the model, by adding new records
        // if they are not already added
        public void AcceptVisitBeforeSave(IVisitorToModel p_oRecordAdder)
        {
            p_oRecordAdder.Visit(this.MasterTable.RecordSet, this);
            p_oRecordAdder.Visit(this.DetailTable.RecordSet, this.Details);
        }
        // --------------------------------------------------------------------------------------
        #endregion
    }
}
