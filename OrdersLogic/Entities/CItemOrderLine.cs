using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Lib.Logic;
using Orders.Data.Records;
using Lib.Common.Attribs;
using System.ComponentModel;
using System.Net;

namespace Orders.Logic.Entities
{
    public class CItemOrderLine: CEntity<ITEM_ORDER_LINE>
    {
        // ........................................................................
        [Key]  
        [ColumnWidth(45)]
        public int Id
        {
            get { return this.Record.ID; }
            set { this.Record.ID = value; }
        }
        // ........................................................................
        [Browsable(false)]
        public int ItemOrderId
        {
            get { return this.Record.ITEM_ORDER_ID; }
            set { this.Record.ITEM_ORDER_ID = value; }
        }
        // ........................................................................
        [ColumnWidth(100)]
        public int? ItemId
        {
            get
            {
                if (this.Record.ITEM_ID == 0)
                    return -1;
                else
                    return this.Record.ITEM_ID;
            }
            set
            {
                if (value != null)
                    this.Record.ITEM_ID = value ?? -1;
                this.InvokePropertyChanged(nameof(ItemId));
            }
        }
        public void LookupItem(List<CItem> p_oItems)
        {
            var oFound = p_oItems.Where(x => x.Id == this.ItemId).ToList();
            if (oFound.Count > 0)
                this.Item = oFound[0];
            else
                this.Item = null;
        }

        [Browsable(false)]
        public CItem? Item { get; set; } = null;

        [ColumnWidth(200)]
        public string ItemName
        {
            get
            {
                if (this.Item == null)
                    return "";
                else
                    return this.Item.Code;
            }
        }
        // ........................................................................
        public int Quantity
        {
            get { return this.Record.QTY; }
            set { this.Record.QTY = value; }
        }
        // ........................................................................
        public int? Discount
        {
            get { return this.Record.DISCOUNT; }
            set { this.Record.DISCOUNT = value; }
        }
        // --------------------------------------------------------------------------------------
        [ReadOnly(true)]
        public float? Total
        {
            get { return this.Quantity * this.Item.price; }
            set { }
        }
        // --------------------------------------------------------------------------------------
        [DisplayName("Total with Discount")]
        [ReadOnly(true)]
        [ColumnWidth(250)]
        public float? TotalWDiscount
        {
            get { return this.Total * (1 - ((float)this.Discount / 100)); }
            set { }
        }
        // --------------------------------------------------------------------------------------
        public CItemOrderLine() : base()
        {
        }
        // --------------------------------------------------------------------------------------
    }
}
