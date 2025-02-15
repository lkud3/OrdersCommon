﻿using Lib.Common.Interfaces;
using Lib.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Logic.Models;
using Orders.Logic.Entities;
using System.ComponentModel;
using System.Diagnostics;

namespace Orders.Logic.DataModules
{
    public class CDMItemOrder: CDataModule, IDataModule
    {
        // ....................................................................
        public IMasterDetailModel Model { get { return (IMasterDetailModel)this.model; } }
        // ....................................................................
        public CItemOrderModel ItemOrderModel { get { return (CItemOrderModel)this.model; } }
        // ....................................................................
        public CItemOrderBrowserModel BrowserModel;
        // ....................................................................

        private CStoreListModel _masterLookupStore;
        public CStoreListModel MasterLookupStore { get { return this._masterLookupStore; } }

        private CCustomerListModel _masterLookupCustomer;
        public CCustomerListModel MasterLookupCustomer { get { return this._masterLookupCustomer; } }

        private CSupplierListModel _masterLookupSupplier;
        public CSupplierListModel MasterLookupSupplier { get { return this._masterLookupSupplier; } }

        private CRecordStatusListModel _masterLookupStatus;
        public CRecordStatusListModel MasterLookupStatus { get { return this._masterLookupStatus; } }
        // ....................................................................

        public CItemListModel _detailLookup;
        public CItemListModel DetailLookup { get { return this._detailLookup; } }
        // ....................................................................


        // --------------------------------------------------------------------------------------
        public CDMItemOrder() : base()
        {
            this.model = new CItemOrderModel();
            this.BrowserModel = new CItemOrderBrowserModel();
            this._masterLookupStore = new CStoreListModel(true);
            this._masterLookupSupplier = new CSupplierListModel(true);
            this._masterLookupCustomer = new CCustomerListModel(true);
            this._masterLookupStatus = new CRecordStatusListModel(true);
            this._detailLookup = new CItemListModel(true);
        }
        // --------------------------------------------------------------------------------------

        #region // IDataModule \\
        // ....................................................................
        public int MasterKeyValue { get; set; }
        // ....................................................................

        // --------------------------------------------------------------------------------------
        public void ModuleOnAnyEntityChange(object? sender, PropertyChangedEventArgs e)
        {
            if (sender != null)
            {
                Debug.WriteLine($"Property {e.PropertyName} has changed on a :{sender.GetType().Name} entity.");

                if (sender is CItemOrder)
                {
                    ((CItemOrder)sender).LookupStore(this._masterLookupStore);
                    ((CItemOrder)sender).LookupCustomer(this._masterLookupCustomer);
                    ((CItemOrder)sender).LookupSupplier(this._masterLookupSupplier);
                    ((CItemOrder)sender).LookupStatus(this._masterLookupStatus);
                }
                else if (sender is CItemOrderLine)
                    ((CItemOrderLine)sender).LookupItem(this._detailLookup);
            }
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleLoadBrowser()
        {
            bool bResult = false;
            try
            {
                BrowserModel.View.LoadTable(null);
                BrowserModel.AcceptVisitAfterLoad(this.entityLoader);
                this.IsLoaded = true;
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleLoadLookups()
        {
            bool bResult = false;
            try
            {
                _masterLookupStore.Table.LoadTable(null);
                _masterLookupStore.AcceptVisitAfterLoad(this.entityLoader);
                _masterLookupSupplier.Table.LoadTable(null);
                _masterLookupSupplier.AcceptVisitAfterLoad(this.entityLoader);
                _masterLookupCustomer.Table.LoadTable(null);
                _masterLookupCustomer.AcceptVisitAfterLoad(this.entityLoader);
                _masterLookupStatus.Table.LoadTable(null);
                _masterLookupStatus.AcceptVisitAfterLoad(this.entityLoader);

                _detailLookup.Table.LoadTable(null);
                _detailLookup.AcceptVisitAfterLoad(this.entityLoader);

                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleNew()
        {
            IEntity iEntity = Model.NewMasterDetail();
            iEntity.OnPropertyChange += ModuleOnAnyEntityChange;
            return true;
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleLoad()
        {
            bool bResult = false;
            try
            {
                Model.LoadMasterDetail(this.MasterKeyValue);
                this.entityLoader.EntityChangeHandler = ModuleOnAnyEntityChange;
                ItemOrderModel.AcceptVisitAfterLoad(this.entityLoader);
                this.IsLoaded = true;
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleSave()
        {
            bool bResult = false;
            try
            {
                ItemOrderModel.AcceptVisitBeforeSave(this.recordAdder); // Custom code for CAppUserModel
                this.MasterKeyValue = Model.SaveMasterDetail();
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        // --------------------------------------------------------------------------------------
        public bool ModuleDelete()
        {
            bool bResult = false;
            try
            {
                Model.DeleteMasterDetail();
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        // --------------------------------------------------------------------------------------
        #endregion
    }
}
