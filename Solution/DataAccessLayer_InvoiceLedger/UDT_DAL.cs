using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;
using Attune.Podium.BusinessEntities.CustomEntities;

namespace Attune.Solution.DataAccessLayer_InvoiceLedger
{
    public static class UDT_DAL
    {
        public static System.Data.DataTable ConvertToUDT_Context(ContextDetails _Context)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            //
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("OrgName", typeof(System.String));
            _datatable.Columns.Add("LogoPath", typeof(System.String));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("RoleName", typeof(System.String));
            _datatable.Columns.Add("UserID", typeof(System.Int64));
            _datatable.Columns.Add("LoginID", typeof(System.Int64));
            _datatable.Columns.Add("LoginName", typeof(System.String));
            _datatable.Columns.Add("Age", typeof(System.String));
            _datatable.Columns.Add("LocationID", typeof(System.Int64));
            _datatable.Columns.Add("PharmacyLocationID", typeof(System.Int64));
            _datatable.Columns.Add("IsTrustedOrg", typeof(System.String));
            _datatable.Columns.Add("BaseCurrency", typeof(System.String));
            _datatable.Columns.Add("CurrencyFormat", typeof(System.String));
            _datatable.Columns.Add("ThemeID", typeof(System.Int64));
            _datatable.Columns.Add("CountryID", typeof(System.Int16));
            _datatable.Columns.Add("StateID", typeof(System.Int16));
            _datatable.Columns.Add("LanguageCode", typeof(System.String));
            _datatable.Columns.Add("PageID", typeof(System.Int64));
            _datatable.Columns.Add("SessionID", typeof(System.String));
            _datatable.Columns.Add("DepartmentName", typeof(System.String));
            _datatable.Columns.Add("AdditionalInfo", typeof(System.String));
            _datatable.Columns.Add("DepartmentCode", typeof(System.String));

            //
            DataRow _datarow;
            _datarow = _datatable.NewRow();
            _datarow["OrgID"] = (_Context != null) ? _Context.OrgID : -1;
            _datarow["OrgName"] = (_Context != null) ? _Context.OrgName : String.Empty;
            _datarow["LogoPath"] = String.Empty;
            _datarow["OrgAddressID"] = (_Context != null) ? _Context.LocationID : -1;
            _datarow["RoleID"] = (_Context != null) ? _Context.RoleID : -1;
            _datarow["RoleName"] = (_Context != null) ? _Context.RoleName : String.Empty;
            _datarow["UserID"] = (_Context != null) ? _Context.UserID : -1;
            _datarow["LoginID"] = (_Context != null) ? _Context.LoginID : -1;
            _datarow["LoginName"] = (_Context != null) ? _Context.LoginName : String.Empty;
            _datarow["Age"] = String.Empty;
            _datarow["LocationID"] = (_Context != null) ? _Context.LocationID : -1;
            _datarow["PharmacyLocationID"] = (_Context != null) ? _Context.InventoryLocationID : -1;
            _datarow["IsTrustedOrg"] = String.Empty;
            _datarow["BaseCurrency"] = (_Context != null) ? _Context.OrgCurrency : String.Empty;
            _datarow["CurrencyFormat"] = (_Context != null) ? _Context.OrgCurrencyFormat : String.Empty;
            _datarow["ThemeID"] = (_Context != null) ? _Context.ThemeID : -1;
            _datarow["CountryID"] = (_Context != null) ? _Context.CountryID : -1;
            _datarow["StateID"] = (_Context != null) ? _Context.StateID : -1;
            _datarow["LanguageCode"] = (_Context != null) ? _Context.LanguageCode : String.Empty;
            _datarow["PageID"] = (_Context != null) ? _Context.PageID : -1;
            _datarow["SessionID"] = (_Context != null) ? _Context.SessionID : string.Empty;
            _datarow["DepartmentName"] = (_Context != null) ? _Context.DepartmentName : string.Empty;
            _datarow["AdditionalInfo"] = (_Context != null) ? _Context.AdditionalInfo : string.Empty;
            _datarow["DepartmentCode"] = (_Context != null) ? _Context.DepartmentCode : string.Empty;

            _datatable.Rows.Add(_datarow);
            return _datatable;
        }
        public static System.Data.DataTable ConvertToUDT_ClientDebit(ClientDebit _Context)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DebitID", typeof(System.Int64));
            _datatable.Columns.Add("DebitDate", typeof(System.DateTime));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("Category", typeof(System.String));
            _datatable.Columns.Add("SourceCode", typeof(System.String));
            _datatable.Columns.Add("SubSourceCode", typeof(System.String));
            _datatable.Columns.Add("Narration", typeof(System.String));
            _datatable.Columns.Add("BarCode", typeof(System.String));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            DataRow _datarow;
            _datarow = _datatable.NewRow();
            _datarow["DebitID"] = _Context.DebitID;
            _datarow["DebitDate"] = _Context.DebitDate;
            _datarow["OrgID"] = _Context.OrgID;
            _datarow["Category"] = _Context.Category;
            _datarow["SourceCode"] = _Context.SourceCode;
            _datarow["SubSourceCode"] = _Context.SubSourceCode;
            _datarow["Narration"] = _Context.Narration;
            _datarow["BarCode"] = _Context.BarCode;
            _datarow["Amount"] = _Context.Amount;
            _datarow["Remarks"] = _Context.Remarks;
            _datarow["Status"] = _Context.Status;
            _datarow["CreatedBy"] = _Context.CreatedBy;
            _datarow["CreatedAt"] = _Context.CreatedAt;
            _datarow["ModifiedBy"] = _Context.ModifiedBy;
            _datarow["ModifiedAt"] = _Context.ModifiedAt;
            _datatable.Rows.Add(_datarow);
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDT_ClientCredit(ClientCredit _Context)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CreditID", typeof(System.Int64));
            _datatable.Columns.Add("CreditDate", typeof(System.DateTime));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("Category", typeof(System.String));
            _datatable.Columns.Add("SourceCode", typeof(System.String));
            _datatable.Columns.Add("SubSourceCode", typeof(System.String));
            _datatable.Columns.Add("Narration", typeof(System.String));
            _datatable.Columns.Add("BarCode", typeof(System.String));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            DataRow _datarow;
            _datarow = _datatable.NewRow();
            _datarow["CreditID"] = _Context.CreditID;
            _datarow["CreditDate"] = _Context.CreditDate;
            _datarow["OrgID"] = _Context.OrgID;
            _datarow["Category"] = _Context.Category;
            _datarow["SourceCode"] = _Context.SourceCode;
            _datarow["SubSourceCode"] = _Context.SubSourceCode;
            _datarow["Narration"] = _Context.Narration;
            _datarow["BarCode"] = _Context.BarCode;
            _datarow["Amount"] = _Context.Amount;
            _datarow["Remarks"] = _Context.Remarks;
            _datarow["Status"] = _Context.Status;
            _datarow["CreatedBy"] = _Context.CreatedBy;
            _datarow["CreatedAt"] = _Context.CreatedAt;
            _datarow["ModifiedBy"] = _Context.ModifiedBy;
            _datarow["ModifiedAt"] = _Context.ModifiedAt;
            _datatable.Rows.Add(_datarow);
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDT_ClientCreditDebit(List<ClientCreditDebit> _Context)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("Id", typeof(System.Int64));
            _datatable.Columns.Add("Date", typeof(System.DateTime));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("Category", typeof(System.String));
            _datatable.Columns.Add("SourceCode", typeof(System.String));
            _datatable.Columns.Add("SubSourceCode", typeof(System.String));
            _datatable.Columns.Add("Narration", typeof(System.String));
            _datatable.Columns.Add("Barcode", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ClientName", typeof(System.String));
            _datatable.Columns.Add("ClientCode", typeof(System.String));
            _datatable.Columns.Add("InCharge", typeof(System.String));
            _datatable.Columns.Add("Address1", typeof(System.String));
            _datatable.Columns.Add("Address2", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("Pincode", typeof(System.String));
            _datatable.Columns.Add("State", typeof(System.String));
            _datatable.Columns.Add("Country", typeof(System.String));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("Count", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));

            DataRow _datarow;

            foreach (ClientCreditDebit _list in _Context)
            {
                _datarow = _datatable.NewRow();
                _datarow["Id"] = _list.Id;
                _datarow["Date"] = _list.Date;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["Category"] = _list.Category;
                _datarow["SourceCode"] = _list.SourceCode;
                _datarow["SubSourceCode"] = _list.SubSourceCode;
                _datarow["Narration"] = _list.Narration;
                _datarow["Barcode"] = _list.Barcode;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["Status"] = _list.Status;
                _datarow["ClientName"] = _list.ClientName;
                _datarow["ClientCode"] = _list.ClientCode;
                _datarow["InCharge"] = _list.InCharge;
                _datarow["Address1"] = _list.Address1;
                _datarow["Address2"] = _list.Address2;
                _datarow["City"] = _list.City;
                _datarow["Pincode"] = _list.Pincode;
                _datarow["State"] = _list.State;
                _datarow["Country"] = _list.Country;
                _datarow["Amount"] = _list.Amount;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["Count"] = _list.Count;
                _datarow["Type"] = _list.Type;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToUDT_ClientReceipt(List<ClientReceipt> _Context)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ReceiptID", typeof(System.Int64));
            _datatable.Columns.Add("ReceiptDate", typeof(System.DateTime));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("SourceCode", typeof(System.String));
            _datatable.Columns.Add("SubSourceCode", typeof(System.String));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("Mode", typeof(System.String));
            _datatable.Columns.Add("ChequeNo", typeof(System.String));
            _datatable.Columns.Add("ChequeDate", typeof(System.DateTime));
            _datatable.Columns.Add("BankCode", typeof(System.String));
            _datatable.Columns.Add("BankName", typeof(System.String));
            _datatable.Columns.Add("AccCode", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("DepositedBy", typeof(System.String));
            _datatable.Columns.Add("ResponseCode", typeof(System.String));
            _datatable.Columns.Add("ResponseMsg", typeof(System.String));
            _datatable.Columns.Add("PaymentReceiptNo", typeof(System.String));
            _datatable.Columns.Add("TransactionID", typeof(System.String));
            _datatable.Columns.Add("AuthIDCode", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("PaymentType", typeof(System.String));
            _datatable.Columns.Add("ManualRemarks", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("UploadedImages", typeof(System.String));

            DataRow _datarow;

            foreach (ClientReceipt _list in _Context)
            {
                _datarow = _datatable.NewRow();
                _datarow["ReceiptID"] = _list.ReceiptID;
                _datarow["ReceiptDate"] = _list.ReceiptDate;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["SourceCode"] = _list.SourceCode;
                _datarow["SubSourceCode"] = _list.SubSourceCode;
                _datarow["Amount"] = _list.Amount;
                _datarow["Mode"] = _list.Mode;
                _datarow["ChequeNo"] = _list.ChequeNo;
                _datarow["ChequeDate"] = _list.ChequeDate;
                _datarow["BankCode"] = _list.BankCode;
                _datarow["BankName"] = _list.BankName;
                _datarow["AccCode"] = _list.AccCode;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["DepositedBy"] = _list.DepositedBy;
                _datarow["ResponseCode"] = _list.ResponseCode;
                _datarow["ResponseMsg"] = _list.ResponseMsg;
                _datarow["PaymentReceiptNo"] = _list.PaymentReceiptNo;
                _datarow["TransactionID"] = _list.TransactionID;
                _datarow["AuthIDCode"] = _list.AuthIDCode;
                _datarow["Status"] = _list.Status;
                _datarow["PaymentType"] = _list.PaymentType;
                _datarow["ManualRemarks"] = _list.ManualRemarks;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["UploadedImages"] = _list.UploadedImages;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDT_ClientReceiptDetail(List<ClientReceiptDetail> _Context)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("Id", typeof(System.Int64));
            _datatable.Columns.Add("Date", typeof(System.DateTime));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("SourceCode", typeof(System.String));
            _datatable.Columns.Add("SubSourceCode", typeof(System.String));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("Mode", typeof(System.String));
            _datatable.Columns.Add("ChequeNo", typeof(System.String));
            _datatable.Columns.Add("ChequeDate", typeof(System.DateTime));
            _datatable.Columns.Add("BankCode", typeof(System.String));
            _datatable.Columns.Add("BankName", typeof(System.String));
            _datatable.Columns.Add("AccCode", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("DepositedBy", typeof(System.String));
            _datatable.Columns.Add("ResponseCode", typeof(System.String));
            _datatable.Columns.Add("ResponseMsg", typeof(System.String));
            _datatable.Columns.Add("PaymentReceiptNo", typeof(System.String));
            _datatable.Columns.Add("TransactionID", typeof(System.String));
            _datatable.Columns.Add("AuthIDCode", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ClientName", typeof(System.String));
            _datatable.Columns.Add("ClientCode", typeof(System.String));
            _datatable.Columns.Add("InCharge", typeof(System.String));
            _datatable.Columns.Add("Address1", typeof(System.String));
            _datatable.Columns.Add("Address2", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("Pincode", typeof(System.String));
            _datatable.Columns.Add("State", typeof(System.String));
            _datatable.Columns.Add("Country", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("Category", typeof(System.String));

            DataRow _datarow;

            foreach (ClientReceiptDetail _list in _Context)
            {
                _datarow = _datatable.NewRow();
                _datarow["Id"] = _list.Id;
                _datarow["Date"] = _list.Date;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["SourceCode"] = _list.SourceCode;
                _datarow["SubSourceCode"] = _list.SubSourceCode;
                _datarow["Amount"] = _list.Amount;
                _datarow["Mode"] = _list.Mode;
                _datarow["ChequeNo"] = _list.ChequeNo;
                _datarow["ChequeDate"] = _list.ChequeDate;
                _datarow["BankCode"] = _list.BankCode;
                _datarow["BankName"] = _list.BankName;
                _datarow["AccCode"] = _list.AccCode;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["DepositedBy"] = _list.DepositedBy;
                _datarow["ResponseCode"] = _list.ResponseCode;
                _datarow["ResponseMsg"] = _list.ResponseMsg;
                _datarow["PaymentReceiptNo"] = _list.PaymentReceiptNo;
                _datarow["TransactionID"] = _list.TransactionID;
                _datarow["AuthIDCode"] = _list.AuthIDCode;
                _datarow["Status"] = _list.Status;
                _datarow["ClientName"] = _list.ClientName;
                _datarow["ClientCode"] = _list.ClientCode;
                _datarow["InCharge"] = _list.InCharge;
                _datarow["Address1"] = _list.Address1;
                _datarow["Address2"] = _list.Address2;
                _datarow["City"] = _list.City;
                _datarow["Pincode"] = _list.Pincode;
                _datarow["State"] = _list.State;
                _datarow["Country"] = _list.Country;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["Category"] = _list.Category;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDT_LedgerInvoiceDetails(List<LedgerInvoiceDetails> _Context)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ClientCode", typeof(System.String));
            _datatable.Columns.Add("ClientName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("InvoiceNumber", typeof(System.String));
            _datatable.Columns.Add("InvoiceId", typeof(System.Int64));
            _datatable.Columns.Add("ClientId", typeof(System.Int64));
            _datatable.Columns.Add("BillNumber", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("InvoiceDate", typeof(System.DateTime));
            _datatable.Columns.Add("FromDate", typeof(System.String));
            _datatable.Columns.Add("ToDate", typeof(System.String));
            _datatable.Columns.Add("ReceivedAmt", typeof(System.Decimal));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("NetValue", typeof(System.Decimal));
            _datatable.Columns.Add("ContactPerson", typeof(System.String));
            _datatable.Columns.Add("CreditLimit", typeof(System.Decimal));
            _datatable.Columns.Add("CreditID", typeof(System.Int64));
            _datatable.Columns.Add("CreditDate", typeof(System.DateTime));
            _datatable.Columns.Add("Narration", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("DebitID", typeof(System.Int64));
            _datatable.Columns.Add("DebitDate", typeof(System.DateTime));
            _datatable.Columns.Add("Address", typeof(System.String));
            _datatable.Columns.Add("Total", typeof(System.Int32));
            _datatable.Columns.Add("BillDate", typeof(System.DateTime));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("BillId", typeof(System.Int64));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Age", typeof(System.String));
            _datatable.Columns.Add("Test", typeof(System.String));
            _datatable.Columns.Add("Barcode", typeof(System.String));
            _datatable.Columns.Add("InvoiceDetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PaymentMode", typeof(System.String));
            _datatable.Columns.Add("CurrencyCode", typeof(System.String));
            _datatable.Columns.Add("AdvanceDetailID", typeof(System.Decimal));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("PaymentType", typeof(System.String));
            _datatable.Columns.Add("M1Pending", typeof(System.Decimal));
            _datatable.Columns.Add("M2Pending", typeof(System.Decimal));
            _datatable.Columns.Add("M3Pending", typeof(System.Decimal));
            _datatable.Columns.Add("M4Pending", typeof(System.Decimal));
            _datatable.Columns.Add("TotalPending", typeof(System.Decimal));
            _datatable.Columns.Add("TotalAmount", typeof(System.String));
            _datatable.Columns.Add("CR", typeof(System.String));
            _datatable.Columns.Add("DR", typeof(System.String));
            _datatable.Columns.Add("DiscountPercentage", typeof(System.Decimal));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(System.Decimal));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("TotalAmt", typeof(System.Decimal));
            _datatable.Columns.Add("TotalAdvanceAmount", typeof(System.Decimal));
            _datatable.Columns.Add("UsedAdvanceAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RemainingAdvanceAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsAdvanceUsed", typeof(System.String));
            _datatable.Columns.Add("IsSucceedTransaction", typeof(System.String));

            DataRow _datarow;

            foreach (LedgerInvoiceDetails _list in _Context)
            {
                _datarow = _datatable.NewRow();
                _datarow["ClientCode"] = _list.ClientCode;
                _datarow["ClientName"] = _list.ClientName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["InvoiceNumber"] = _list.InvoiceNumber;
                _datarow["InvoiceId"] = _list.InvoiceId;
                _datarow["ClientId"] = _list.ClientId;
                _datarow["BillNumber"] = _list.BillNumber;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["InvoiceDate"] = _list.InvoiceDate;
                _datarow["FromDate"] = _list.FromDate;
                _datarow["ToDate"] = _list.ToDate;
                _datarow["ReceivedAmt"] = _list.ReceivedAmt;
                _datarow["Status"] = _list.Status;
                _datarow["NetValue"] = _list.NetValue;
                _datarow["ContactPerson"] = _list.ContactPerson;
                _datarow["CreditLimit"] = _list.CreditLimit;
                _datarow["CreditID"] = _list.CreditID;
                _datarow["CreditDate"] = _list.CreditDate;
                _datarow["Narration"] = _list.Narration;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["DebitID"] = _list.DebitID;
                _datarow["DebitDate"] = _list.DebitDate;
                _datarow["Address"] = _list.Address;
                _datarow["Total"] = _list.Total;
                _datarow["BillDate"] = _list.BillDate;
                _datarow["Amount"] = _list.Amount;
                _datarow["BillId"] = _list.BillId;
                _datarow["Name"] = _list.Name;
                _datarow["Age"] = _list.Age;
                _datarow["Test"] = _list.Test;
                _datarow["Barcode"] = _list.Barcode;
                _datarow["InvoiceDetailsID"] = _list.InvoiceDetailsID;
                _datarow["PaymentMode"] = _list.PaymentMode;
                _datarow["CurrencyCode"] = _list.CurrencyCode;
                _datarow["AdvanceDetailID"] = _list.AdvanceDetailID;
                _datarow["City"] = _list.City;
                _datarow["PaymentType"] = _list.PaymentType;
                _datarow["M1Pending"] = _list.M1Pending;
                _datarow["M2Pending"] = _list.M2Pending;
                _datarow["M3Pending"] = _list.M3Pending;
                _datarow["M4Pending"] = _list.M4Pending;
                _datarow["TotalPending"] = _list.TotalPending;
                _datarow["TotalAmount"] = _list.TotalAmount;
                _datarow["CR"] = _list.CR;
                _datarow["DR"] = _list.DR;
                _datarow["DiscountPercentage"] = _list.DiscountPercentage;
                _datarow["DiscountAmount"] = _list.DiscountAmount;
                _datarow["ActualAmount"] = _list.ActualAmount;
                _datarow["Description"] = _list.Description;
                _datarow["TotalAmt"] = _list.TotalAmt;
                _datarow["TotalAdvanceAmount"] = _list.TotalAdvanceAmount;
                _datarow["UsedAdvanceAmount"] = _list.UsedAdvanceAmount;
                _datarow["RemainingAdvanceAmount"] = _list.RemainingAdvanceAmount;
                _datarow["IsAdvanceUsed"] = _list.IsAdvanceUsed;
                _datarow["IsSucceedTransaction"] = _list.IsSucceedTransaction;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
    }
}