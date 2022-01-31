using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.BusinessEntities;
using System.Data;

namespace OutBoundMsgDataAccessLayer
{
    class UDT_DAL
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
        public static System.Data.DataTable ConvertToLoginDetail(LoginDetail _list)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LoginID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("Orgid", typeof(System.Int32));
            _datatable.Columns.Add("DummyString", typeof(System.String));

            DataRow _datarow;


            _datarow = _datatable.NewRow();
            _datarow["LoginID"] = _list.LoginID;
            _datarow["RoleID"] = _list.RoleID;
            _datarow["Orgid"] = _list.Orgid;
            _datarow["DummyString"] = _list.DummyString;
            _datatable.Rows.Add(_datarow);

            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTHl7OutBoundMessageDetails(Hl7OutBoundMessageDetails _list)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("HL7ID", typeof(System.Int64));
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("AccessionNumber", typeof(System.Int64));
            _datatable.Columns.Add("GeneratedXML", typeof(System.String));
            _datatable.Columns.Add("TestStatus", typeof(System.String));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            DataRow _datarow;


            _datarow = _datatable.NewRow();
            _datarow["HL7ID"] = _list.HL7ID;
            _datarow["ID"] = _list.ID;
            _datarow["Name"] = _list.Name;
            _datarow["Type"] = _list.Type;  
            _datarow["Status"] = _list.Status;
            _datarow["AccessionNumber"] = _list.AccessionNumber;
            _datarow["GeneratedXML"] = _list.GeneratedXML;
            _datarow["TestStatus"] = _list.TestStatus;
            _datarow["PatientVisitID"] = _list.PatientVisitID;
            _datatable.Rows.Add(_datarow);

            return _datatable;
            //Test
        }

        internal static DataTable ConvertToUDTHl7OutBoundMessageDetails(List<Hl7OutBoundMessageDetails> PatientInvestigation)
        {
            throw new NotImplementedException();
        }
    }
}
