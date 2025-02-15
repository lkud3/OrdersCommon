﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Orders.Logic.Entities;

namespace Orders.Logic.Visitors
{
    public interface IVisitorToModel
    {
        public void Visit(IList p_oRecordSet, List<CCustomer> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CItem> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CItemOrder> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CItemOrderLine> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CStore> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CSupplier> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CVItemOrder> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CRecordStatus> p_oEntityList);
    }
}
