using Lib.Data.DB;
using Orders.Data.Records;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Data.Tables
{
    public class TableITEM_ORDER: CDBTable<ITEM_ORDER>
    {
        // --------------------------------------------------------------------------------------
        public TableITEM_ORDER() 
        { 
        }
        // --------------------------------------------------------------------------------------

        public override void LoadRecord(int p_nKeyValue)
        {
            this.records.Clear(); // Empty the existing records

            // We create an object to hold the ID parameter for the select statement
            ITEM_ORDER? oParams = new ITEM_ORDER();
            oParams.ID = p_nKeyValue;


            using (var iTransaction = CData.Instance.DB.BeginTransaction())
            {
                try
                {
                    var oRecords = CData.Instance.DB.SelectWithParams<ITEM_ORDER>(
                            "select * from ITEM_ORDER where ID = @ID", oParams, iTransaction);
                    iTransaction.Commit();

                    // When a select returns no records a null object might be returned by the method
                    if (oRecords != null)
                    {
                        this.records = oRecords;

                        foreach (var oRecord in this.records)
                            Debug.WriteLine(oRecord.ToString());
                    }
                }
                catch
                {
                    iTransaction.Rollback();
                    throw;
                }
            }
        }
        // --------------------------------------------------------------------------------------

        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            this.records.Clear(); // Empty the existing records

            var oRecords = CData.Instance.DB.Select<ITEM_ORDER>("select * from ITEM_ORDER", p_iTransaction);

            // When a select returns no records a null object might be returned by the method
            if (oRecords != null)
            {
                this.records = oRecords;

                foreach (var oRecord in this.records)
                    Debug.WriteLine(oRecord.ToString());
            }
        }
        // --------------------------------------------------------------------------------------
        public override void SaveTable(IDbTransaction? p_iTransaction)
        {
            if (this.records != null)
            {
                CData.Instance.DB.SaveChanges<ITEM_ORDER>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"  insert into ITEM_ORDER
                                (
                                   IS_CUSTOMER_ORDER				
                                  ,CUSTOMER_ID
                                  ,SUPPLIER_ID	
                                  ,ORDER_DATETIME
                                  ,STORE_CID
                                  ,RECORD_STATUS_CID
                                )
                                values
                                (
                                     @IS_CUSTOMER_ORDER				
                                     ,@CUSTOMER_ID
                                     ,@SUPPLIER_ID	
                                     ,@ORDER_DATETIME
                                     ,@STORE_CID
                                     ,@RECORD_STATUS_CID
                                )",

                            // Provide the update statement that will be used for updated records
                            @"
                            update ITEM_ORDER set
                                IS_CUSTOMER_ORDER      = @IS_CUSTOMER_ORDER
                                ,CUSTOMER_ID    = @CUSTOMER_ID	
                                ,SUPPLIER_ID  = @SUPPLIER_ID
                                ,ORDER_DATETIME = @ORDER_DATETIME
                                ,STORE_CID    = @STORE_CID
                                ,RECORD_STATUS_CID = @RECORD_STATUS_CID
                            where
                                ID = @ID",

                            // Provide the delete statement that will be used for deleted records
                            @"delete from ITEM_ORDER where ID = @ID",

                            p_iTransaction
                        );

                // We reload the table to reflect all the changes that have been saved in the DB
                // With this we secure that fields altered by DB triggers are properly loaded
                this.LoadTable(p_iTransaction);
            }
        }
    }
}
