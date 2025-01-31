using Lib.Data.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Data.Records
{
    public class V_ITEM_ORDER: CDBRecord
    {
        [Key]
        public int ID { get; set; }

        public string? STORE_NAME { get; set; }
    }
}
