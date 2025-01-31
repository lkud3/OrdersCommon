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
    public class CItemOrder: CEntity<ITEM_ORDER>
    {
        [Key]
        public int Id
        {
            get { return this.Record.ID; }
            set { this.Record.ID = value; }
        }
        // ........................................................................
        public int CustomerFlag
        {
            get { return this.Record.IS_CUSTOMER_ORDER; }
            set { this.Record.IS_CUSTOMER_ORDER = value; }
        }
        // ........................................................................
        public int? CustomerID
        {
            get { return this.Record.CUSTOMER_ID ?? -1; }
            set
            {
                if (value == -1)
                    this.Record.CUSTOMER_ID = null;
                else
                    this.Record.CUSTOMER_ID = value;
                InvokePropertyChanged(nameof(CustomerID));
            }
        }
        public void LookupCustomer(List<CCustomer> p_oCustomers)
        {
            var oFound = p_oCustomers.Where(x => x.CodeId == this.CustomerID).ToList();
            if (oFound.Count > 0)
                this.Customer = oFound[0];
            else
                this.Customer = null;
        }

        [Browsable(false)]
        public CCustomer? Customer { get; set; } = null;

        public string CustomerName
        {
            get
            {
                if (this.Customer == null)
                    return "";
                else
                    return this.Customer.Name ?? "";
            }
        }
        // ........................................................................
        public int? SupplierID
        {
            get { return this.Record.SUPPLIER_ID ?? -1; }
            set
            {
                if (value == -1)
                    this.Record.SUPPLIER_ID = null;
                else
                    this.Record.SUPPLIER_ID = value;
                InvokePropertyChanged(nameof(SupplierID));
            }
        }
        public void LookupSupplier(List<CSupplier> p_oSuppliers)
        {
            var oFound = p_oSuppliers.Where(x => x.CodeId == this.SupplierID).ToList();
            if (oFound.Count > 0)
                this.Supplier = oFound[0];
            else
                this.Supplier = null;
        }

        [Browsable(false)]
        public CSupplier? Supplier { get; set; } = null;

        public string SupplierName
        {
            get
            {
                if (this.Supplier == null)
                    return "";
                else
                    return this.Supplier.Name ?? "";
            }
        }
        // ........................................................................
        public DateTime? OrderDatetime
        {
            get { return this.Record.ORDER_DATETIME; }
            set { this.Record.ORDER_DATETIME = value; }
        }
        // ........................................................................
        public int StoreCodeID
        {
            get { return this.Record.STORE_CID ?? -1; }
            set
            {
                if (value == -1)
                    this.Record.STORE_CID = null;
                else
                    this.Record.STORE_CID = value;
                InvokePropertyChanged(nameof(StoreCodeID));
            }
        }
        public void LookupStore(List<CStore> p_oStores)
        {
            var oFound = p_oStores.Where(x => x.CodeId == this.StoreCodeID).ToList();
            if (oFound.Count > 0)
                this.Store = oFound[0];
            else
                this.Store = null;
        }

        [Browsable(false)]
        public CStore? Store { get; set; } = null;

        public string StoreName
        {
            get
            {
                if (this.Store == null)
                    return "";
                else
                    return this.Store.Name ?? "";
            }
        } 
        // ........................................................................
        public int? StatusID
        {
            get { return this.Record.RECORD_STATUS_CID ?? -1; }
            set
            {
                if (value == -1)
                    this.Record.RECORD_STATUS_CID = null;
                else
                    this.Record.RECORD_STATUS_CID = value;
                InvokePropertyChanged(nameof(StatusID));
            }
        }
        public void LookupStatus(List<CRecordStatus> p_oStatuses)
        {
            var oFound = p_oStatuses.Where(x => x.CodeId == this.StatusID).ToList();
            if (oFound.Count > 0)
                this.Status = oFound[0];
            else
                this.Status = null;
        }

        [Browsable(false)]
        public CRecordStatus? Status { get; set; } = null;

        public string StatusName
        {
            get
            {
                if (this.Status == null)
                    return "";
                else
                    return this.Status.Name ?? "";
            }
        }
        // ........................................................................

        public CItemOrder() : base()
        {
        }
        // --------------------------------------------------------------------------------------   
    }
}
