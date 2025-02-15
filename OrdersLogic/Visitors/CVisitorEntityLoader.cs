﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Orders.Logic.Entities;
using Orders.Data.Records;

namespace Orders.Logic.Visitors
{
    public class CVisitorEntityLoader: IVisitorToModel
    {
        public PropertyChangedEventHandler? EntityChangeHandler { get; set; } = null;

        #region // IVisitorToModel \\
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CCustomer> p_oEntityList)
        {
            foreach (CUSTOMER oRecord in p_oRecordSet)
            {
                CCustomer oEntity = new CCustomer();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItem> p_oEntityList)
        {
            foreach (ITEM oRecord in p_oRecordSet)
            {
                CItem oEntity = new CItem();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItemOrder> p_oEntityList)
        {
            foreach (ITEM_ORDER oRecord in p_oRecordSet)
            {
                CItemOrder oEntity = new CItemOrder();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItemOrderLine> p_oEntityList)
        {
            foreach (ITEM_ORDER_LINE oRecord in p_oRecordSet)
            {
                CItemOrderLine oEntity = new CItemOrderLine();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                oEntity.ItemId = oEntity.ItemId; 
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CStore> p_oEntityList)
        {
            foreach (STORE oRecord in p_oRecordSet)
            {
                CStore oEntity = new CStore();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CSupplier> p_oEntityList)
        {
            foreach (SUPPLIER oRecord in p_oRecordSet)
            {
                CSupplier oEntity = new CSupplier();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CVItemOrder> p_oEntityList)
        {
            foreach (V_ITEM_ORDER oRecord in p_oRecordSet)
            {
                CVItemOrder oEntity = new CVItemOrder();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CRecordStatus> p_oEntityList)
        {
            foreach (RECORD_STATUS oRecord in p_oRecordSet)
            {
                CRecordStatus oEntity = new CRecordStatus();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        #endregion
    }
}
