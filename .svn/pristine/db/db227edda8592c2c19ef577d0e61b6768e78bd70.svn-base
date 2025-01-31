using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Lib.Logic;
using Orders.Logic.Entities;

namespace Orders.Logic.Visitors
{
    public class CVisitorRecordAdder: IVisitorToModel
    {
        #region // IVisitorToModel \\
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CCustomer> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItem> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItemOrder> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CItemOrderLine> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CStore> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CSupplier> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CVItemOrder> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CRecordStatus> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        #endregion
    }
}
