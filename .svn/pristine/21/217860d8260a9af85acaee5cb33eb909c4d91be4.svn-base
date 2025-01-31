using Lib.Common.Attribs;
using Lib.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Orders.Data.Records;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Logic.Entities
{
    public class CItem: CEntity<ITEM>
    {
        [Key]
        public int Id { get { return this.Record.ID; } set { this.Record.ID = value; } }
        [ColumnWidth(200)]
        public string Code { get { return this.Record.CODE; } set { this.Record.CODE = value; } }
        [ColumnWidth(200)]
        public float price{ get { return this.Record.PRICE; } set { this.Record.PRICE = value; } }

        public CItem() : base()
        {
        }
    }
}
