using Lib.Common.Attribs;
using Lib.Logic;
using Orders.Data.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Logic.Entities
{
    public class CRecordStatus : CEntity<RECORD_STATUS>
    {
        [Key]               //.NET: Example of declaring a field as primary key, using the Key attribute
        [ColumnWidth(120)]   //.NET: Example of declaring the width of the column when the field is displayed.
        public int CodeId
        {
            get { return this.Record.CID; }
            set { this.Record.CID = value; }
        }


        [ColumnWidth(200)]
        public string Name { get { return this.Record.STATUS_NAME; } set { this.Record.STATUS_NAME = value; } }
        [ColumnWidth(250)]
        public string Descr { get { return this.Record.STATUS_DESCR; } set { this.Record.STATUS_DESCR = value; } }
        [ColumnWidth(100)]
        public int Active_Flag { get { return this.Record.IS_ACTIVE; } set { this.Record.IS_ACTIVE = value; } }

        public override String ToString()
        {
            return this.Name;
        }

        public CRecordStatus() : base()
        {
        }
    }
}
