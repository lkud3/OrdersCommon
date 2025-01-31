using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Common.Attribs;
using Lib.Logic;
using Orders.Data.Records;

namespace Orders.Logic.Entities
{
    public class CVItemOrder: CEntity<V_ITEM_ORDER>
    {
        // ........................................................................
        [Key]  //.NET: Example of declaring a field as primary key, using the Key attribute
        [ReadOnly(true)]        //.NET: Example of declaring a field as read only. 
        [ColumnWidth(30)]       //.NET: Example of declaring the width of the column when the field is displayed.
        public int Id
        {
            get { return this.Record.ID; }
            set { this.Record.ID = value; }
        }
        // ........................................................................
        [DisplayName("Store Name")]
        [ReadOnly(true)]
        [ColumnWidth(250)]
        public string StoreName
        {
            get { return this.Record.STORE_NAME; }
            set { this.Record.STORE_NAME = value; }
        }

        public override string ToString()
        {
            return String.Format("Order #{0} ({1})", this.Id, this.StoreName);
        }
    }
}
