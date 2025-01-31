using Lib.Common.Attribs;
using Lib.Logic;
using Orders.Data.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Logic.Entities
{
    public class CStore : CEntity<STORE>
    {
        [Key]               //.NET: Example of declaring a field as primary key, using the Key attribute
        [ColumnWidth(120)]   //.NET: Example of declaring the width of the column when the field is displayed.
        public int CodeId
        {
            get { return this.Record.CID; }
            set { this.Record.CID = value; }
        }
        [ColumnWidth(200)]
        public string? Name { 
            get { return this.Record.NAME; } 
            set 
            { 
                if (value == null)
                    throw new Exception("The store must have a name");
                else
                    this.Record.NAME = value; 
            } 
        }

        public override String ToString()
        {
            return this.Name;
        }
        public CStore() : base()
        {
        }
    }
}
