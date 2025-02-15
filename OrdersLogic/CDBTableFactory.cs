﻿using Lib.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Data.Tables;

namespace Orders.Logic
{
    public class CDBTableFactory
    {
        #region // Singleton \\
        // ....................................................................
        private static CDBTableFactory? __instance = null;
        public static CDBTableFactory Instance
        {
            get
            {
                //PATTERN: Lazy initialization. The only instance is created at the first time that is needed.
                if (__instance == null)
                    __instance = new CDBTableFactory();
                return __instance;
            }
        }
        private CDBTableFactory()
        {
        }
        // ....................................................................
        #endregion

        // --------------------------------------------------------------------------------------
        // [PATTERNS] Factory Method
        public IDBTable CreateTable(string p_sTableName)
        {
            if (p_sTableName == "CUSTOMER")
                return new TableCUSTOMER();
            else if (p_sTableName == "ITEM")
                return new TableITEM();
            else if (p_sTableName == "ITEM_ORDER")
                return new TableITEM_ORDER();
            else if (p_sTableName == "ITEM_ORDER_LINE")
                return new TableITEM_ORDER_LINE();
            else if (p_sTableName == "STORE")
                return new TableSTORE();
            else if (p_sTableName == "SUPPLIER")
                return new TableSUPPLIER();
            else if (p_sTableName == "V_ITEM_ORDER")
                return new ViewITEM_ORDER();
            else if (p_sTableName == "RECORD_STATUS")
                return new TableRECORD_STATUS();
            else
                return null;
        }
        // --------------------------------------------------------------------------------------
    }
}
