using Lib.Data.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Data.Records
{
    public class ITEM_ORDER_LINE: CDBRecord
    {
        [Key]       //.NET: Example of declaring a field as primary key, using the Key attribute
        public int ID { get; set; }
        public int ITEM_ORDER_ID { get; set; }
        public int ITEM_ID { get; set; }
        public int QTY { get; set; }
        public int? DISCOUNT { get; set; }
    }
}
