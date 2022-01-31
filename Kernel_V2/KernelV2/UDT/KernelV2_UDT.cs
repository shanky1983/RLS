using System;
using System.Data;
using Attune.KernelV2.Entities;


namespace Attune.KernelV2.UDT
{
   
    public static class KernelV2_UDT
       
    {
        public static DataTable ConvertToUDT_Context(UI_ContextDetails _Context)
        {
            DataTable _datatable = new DataTable();
            //
            _datatable.Columns.Add("OrgID", typeof(Int64));
            _datatable.Columns.Add("OrgName", typeof(String));
            _datatable.Columns.Add("LogoPath", typeof(String));
            _datatable.Columns.Add("OrgAddressID", typeof(Int64));
            _datatable.Columns.Add("RoleID", typeof(Int64));
            _datatable.Columns.Add("RoleName", typeof(String));
            _datatable.Columns.Add("UserID", typeof(Int64));
            _datatable.Columns.Add("LoginID", typeof(Int64));
            _datatable.Columns.Add("LoginName", typeof(String));
            _datatable.Columns.Add("Age", typeof(String));
            _datatable.Columns.Add("LocationID", typeof(Int64));
            _datatable.Columns.Add("PharmacyLocationID", typeof(Int64));
            _datatable.Columns.Add("IsTrustedOrg", typeof(String));
            _datatable.Columns.Add("BaseCurrency", typeof(String));
            _datatable.Columns.Add("CurrencyFormat", typeof(String));
            _datatable.Columns.Add("ThemeID", typeof(Int64));
            _datatable.Columns.Add("CountryID", typeof(Int64));
            _datatable.Columns.Add("StateID", typeof(Int64));
            _datatable.Columns.Add("LanguageCode", typeof(String));
            _datatable.Columns.Add("PageID", typeof(Int64));
            _datatable.Columns.Add("SessionID", typeof(String));
            _datatable.Columns.Add("DepartmentName", typeof(String));
            _datatable.Columns.Add("AdditionalInfo", typeof(String));
            _datatable.Columns.Add("DepartmentCode", typeof(String));
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
            _datarow["LanguageCode"] = (_Context != null) ? _Context.LanguageCode : "en-GB";
            _datarow["PageID"] = (_Context != null) ? _Context.PageID : -1;
            _datarow["SessionID"] = (_Context != null) ? _Context.SessionID : string.Empty;
            _datarow["DepartmentName"] = (_Context != null) ? _Context.DepartmentName : string.Empty;
            _datarow["AdditionalInfo"] = (_Context != null) ? _Context.AdditionalInfo : string.Empty;
            _datarow["DepartmentCode"] = (_Context != null) ? _Context.DepartmentCode : string.Empty;

            _datatable.Rows.Add(_datarow);
            return _datatable;
        }        
    }
}
