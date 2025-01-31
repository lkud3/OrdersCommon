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
    public class TableITEM_ORDER_LINE: CDBTable<ITEM_ORDER_LINE>
    {
        public int MasterID { get; set; }
        // ....................................................................
        public TableITEM_ORDER_LINE()
        {
        }
        // ....................................................................
        public override void LoadTable(IDbTransaction? p_iTransaction, int p_nMasterKeyValue)
        {
            this.MasterID = p_nMasterKeyValue;
            this.LoadTable(p_iTransaction);
        }
        // --------------------------------------------------------------------------------------
        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            this.records.Clear(); // Empty the existing records
                                  // We create an object to hold the ID parameter for the select statement
            ITEM_ORDER_LINE? oParams = new ITEM_ORDER_LINE();
            oParams.ITEM_ORDER_ID = this.MasterID;
            var oRecords = CData.Instance.DB.SelectWithParams<ITEM_ORDER_LINE>(
                    "select * from ITEM_ORDER_LINE where ITEM_ORDER_ID = @ITEM_ORDER_ID", oParams, p_iTransaction);

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
                CData.Instance.DB.SaveChanges<ITEM_ORDER_LINE>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"  insert into ITEM_ORDER_LINE
                                    (
                                       ITEM_ORDER_ID
                                      ,ITEM_ID
                                      ,QTY
                                      ,DISCOUNT
                                    )
                                    values
                                    (
                                       @ITEM_ORDER_ID
                                      ,@ITEM_ID
                                      ,@QTY
                                      ,@DISCOUNT
                                    )",

                            // Provide the update statement that will be used for updated records
                            @"
                                update ITEM_ORDER_LINE set
                                     ITEM_ORDER_ID    = @ITEM_ORDER_ID
                                    ,ITEM_ID     = @ITEM_ID	
                                    ,QTY     = @QTY
                                    ,DISCOUNT    = @DISCOUNT
                                where
                                    ID = @ID",

                            // Provide the delete statement that will be used for deleted records
                            @"delete from ITEM_ORDER_LINE where ID = @ID",

                            p_iTransaction
                        );

                // We reload the table to reflect all the changes that have been saved in the DB
                // With this we secure that fields altered by DB triggers are properly loaded
                this.LoadTable(p_iTransaction);
            }
        }
    }
}
