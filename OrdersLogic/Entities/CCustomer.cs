using Lib.Logic;
using Lib.Common.Attribs;
using Orders.Data.Records;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Logic.Entities
{
    public class CCustomer: CEntity<CUSTOMER>
    {
        [Key]               //.NET: Example of declaring a field as primary key, using the Key attribute
        [ColumnWidth(120)]   //.NET: Example of declaring the width of the column when the field is displayed.
        public int CodeId
        {
            get { return this.Record.ID; }
            set { this.Record.ID = value; }
        }

        
        [ColumnWidth(200)]
        public string Name { get { return this.Record.NAME; } set { this.Record.NAME = value; } }
        [ColumnWidth(250)]
        public string Phone { get { return this.Record.PHONE; } set { this.Record.PHONE = value; } }

        public override String ToString()
        {
            return this.Name;
        }

        public CCustomer() : base()
        {
        }
    }
}
