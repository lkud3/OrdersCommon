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
    public class TableRECORD_STATUS : CDBTable<RECORD_STATUS>
    {
        public TableRECORD_STATUS() { }
        public override void LoadRecord(int p_nKeyValue)
        {
            this.records.Clear(); // Empty the existing records

            // We create an object to hold the ID parameter for the select statement
            RECORD_STATUS? oParams = new RECORD_STATUS();
            oParams.CID = p_nKeyValue;


            using (var iTransaction = CData.Instance.DB.BeginTransaction())
            {
                try
                {
                    var oRecords = CData.Instance.DB.SelectWithParams<RECORD_STATUS>(
                            "select * from RECORD_STATUS where CID = @CID", oParams, iTransaction);
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
        // --------------------------------------------------------------------------------------
        public override void LoadTable(IDbTransaction p_iTransaction)
        {
            var oRecords = CData.Instance.DB.Select<RECORD_STATUS>("select * from RECORD_STATUS");

            // When a select returns no records a null object might be returned by the method
            if (oRecords != null)
            {
                this.records = oRecords;

                foreach (var oRecord in this.records)
                    Debug.WriteLine(oRecord.ToString());
            }
        }
        // --------------------------------------------------------------------------------------
        public override void SaveTable(IDbTransaction p_iTransaction)
        {
            if (this.records != null)
            {
                CData.Instance.DB.SaveChanges<RECORD_STATUS>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into RECORD_STATUS
                                  (
                                     STATUS_NAME
	                                ,STATUS_DESCR
                                    ,IS_ACTIVE
                                  )
                                  values
                                  (
                                     @STATUS_NAME
	                                ,@STATUS_DESCR
                                    ,@IS_ACTIVE
                                  )",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update RECORD_STATUS set
                                     STATUS_NAME                     = @STATUS_NAME
	                                ,STATUS_DESCR                    = @STATUS_DESCR
                                    ,IS_ACTIVE = @IS_ACTIVE
                                  where 
                                    CID = @CID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from RECORD_STATUS where CID = @CID",

                            p_iTransaction
                        );

                // We reload the table to reflect all the changes that have been saved in the DB
                // With this we secure that fields altered by DB triggers are properly loaded
                this.LoadTable(p_iTransaction);
            }
        }
    }
}
