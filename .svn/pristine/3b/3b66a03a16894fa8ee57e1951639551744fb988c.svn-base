using Lib.Common.Attribs;
using Lib.Data.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Data.Records
{
    public class RECORD_STATUS : CDBRecord
    {
        [Key]
        [ColumnWidth(30)]
        public int CID { get; set; }

        [ColumnWidth(250)]
        public string STATUS_NAME { get; set; }
        [ColumnWidth(250)]
        public string STATUS_DESCR { get; set; }
        [ColumnWidth(100)]
        public int IS_ACTIVE { get; set; }
    }
}
