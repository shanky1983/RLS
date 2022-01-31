using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using Attune.Solution.QMSBusinessEntities;
using Attune.Solution.QMSBusinessEntities.CustomEntities;

namespace Attune.Solution.QMSDataAccessLayer
{
    public static class UDT_DAL
    {
        public static System.Data.DataTable ConvertToUDT_Context(ContextDetails _Context)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
         
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

        public static System.Data.DataTable ConvertToAnalyteMaster(List<AnalyteMaster> _AnalyteMaster)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Investigationid", typeof(System.Int64));
            _datatable.Columns.Add("DepartmentID", typeof(System.Int64));
            _datatable.Columns.Add("ContatinerID", typeof(System.Int64));
            _datatable.Columns.Add("ResultValueType", typeof(System.String));
            _datatable.Columns.Add("SampleID", typeof(System.Int64));
            _datatable.Columns.Add("DecimalPlaces", typeof(System.String));
            _datatable.Columns.Add("MethoidID", typeof(System.Int64));
            _datatable.Columns.Add("PrinclipleID", typeof(System.Int64));
            _datatable.Columns.Add("Classification", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));
            _datatable.Columns.Add("IsActive", typeof(System.String));
            _datatable.Columns.Add("OrgId", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CutOffTimeValue", typeof(System.Int32));
            _datatable.Columns.Add("CutOffTimeType", typeof(System.String));
            _datatable.Columns.Add("ID", typeof(System.Int64));

            DataRow _datarow;
            foreach (AnalyteMaster _list in _AnalyteMaster)
            {
                _datarow = _datatable.NewRow();
                _datarow["Investigationid"] = _list.Investigationid;
                _datarow["DepartmentID"] = _list.DepartmentID;
                _datarow["ContatinerID"] = _list.ContatinerID;
                _datarow["ResultValueType"] = _list.ResultValueType;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["DecimalPlaces"] = _list.DecimalPlaces;
                _datarow["ResultText"] = _list.MethodID;
                _datarow["PrinclipleID"] = _list.PrinclipleID;
                _datarow["Classification"] = _list.Classification;
                _datarow["IsNABL"] = _list.IsNABL;
                _datarow["IsActive"] = _list.IsActive;
                _datarow["OrgId"] = _list.OrgId;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["CutOffTimeValue"] = _list.CutOffTimeValue;
                _datarow["CutOffTimeType"] = _list.CutOffTimeType;
                _datarow["ID"] = _list.ID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToAnalyzerMaster(List<InvInstrumentMaster> _AnalyzerMaster)
        {
            System.Data.DataTable _datatable = new DataTable();
            //
            _datatable.Columns.Add("InstrumentID", typeof(Int64));
            _datatable.Columns.Add("InstrumentName", typeof(String));
            _datatable.Columns.Add("InstrumentType", typeof(Int16));
            _datatable.Columns.Add("ProductCode", typeof(String));
            _datatable.Columns.Add("Model", typeof(String));
            _datatable.Columns.Add("Manufacturer", typeof(String));
            _datatable.Columns.Add("Method", typeof(String));
            _datatable.Columns.Add("Principle", typeof(String));
            _datatable.Columns.Add("ProcessingMode", typeof(String));
            _datatable.Columns.Add("SampleVolume", typeof(String));
            _datatable.Columns.Add("DataStorage", typeof(String));
            _datatable.Columns.Add("ThroughPut", typeof(String));
            _datatable.Columns.Add("Direction", typeof(String));
            _datatable.Columns.Add("OrgID",typeof(Int16));
            _datatable.Columns.Add("LocationID", typeof(Int16));
            _datatable.Columns.Add("Status",typeof(String));
            _datatable.Columns.Add("CreatedBy",typeof(Int64));
            _datatable.Columns.Add("CreatedAt",typeof(DateTime));
            _datatable.Columns.Add("ModifiedBy",typeof(Int64));
            _datatable.Columns.Add("ModifiedAt",typeof(DateTime));
            _datatable.Columns.Add("QCData",typeof(String));
            _datatable.Columns.Add("ImagePath", typeof(String));
            _datatable.Columns.Add("Department", typeof(String));
            _datatable.Columns.Add("DeptID", typeof(int));
            _datatable.Columns.Add("MethodID", typeof(Int64));
            _datatable.Columns.Add("PrincipleID", typeof(Int64));
            _datatable.Columns.Add("InstallationDate", typeof(String));

            DataRow _datarow;
            foreach (InvInstrumentMaster _list in _AnalyzerMaster)
            {
                _datarow = _datatable.NewRow();
                _datarow["PrincipleID"] = _list.PrincipleID;
                _datarow["InstrumentName"] = _list.InstrumentName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["Status"] = _list.Status;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["QCData"] = _list.QCData;
                _datarow["InstrumentType"] = _list.InstrumentType;
                _datarow["ProductCode"] = _list.ProductCode;
                _datarow["Model"] = _list.Model;
                _datarow["Manufacturer"] = _list.Manufacturer;
                _datarow["Method"] = _list.Method;
                _datarow["Principle"] = _list.Principle;
                _datarow["ProcessingMode"] = _list.ProcessingMode;
                _datarow["SampleVolume"] = _list.SampleVolume;
                _datarow["DataStorage"] = _list.DataStorage;
                _datarow["ThroughPut"] = _list.ThroughPut;
                _datarow["Direction"] = _list.Direction;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["ImagePath"] = _list.ImagePath;
                _datarow["InstrumentID"] = _list.InstrumentID;
                _datarow["Department"] = _list.Department;
                _datarow["DeptID"] = _list.DeptID;
                _datarow["MethodID"] = _list.MethodID;
                _datarow["Installationdate"] = _list.Installationdate;
                _datatable.Rows.Add(_datarow);


            }

            return _datatable;
        }

        public static System.Data.DataTable ConvertToDeptID(string[] DeptID)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("SNO", typeof(int));
            _datatable.Columns.Add("DeptID", typeof(int));
            DataRow _datarow;
            if (DeptID != null)
            {
                int count = DeptID.Length;
                for (int i = 0; i < count; i++)
                {
                    _datarow = _datatable.NewRow();
                    _datarow["DeptID"] = DeptID[i];
                    _datarow["SNO"] = i;
                    _datatable.Rows.Add(_datarow);
                }
            }
            return _datatable;
        }
        public static System.Data.DataTable SaveLotManagement_DAL(List<LotMaster> lotmaster)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("LotID", typeof(Int64));
            _datatable.Columns.Add("LotName", typeof(string));
            _datatable.Columns.Add("LotCode", typeof(string));
            _datatable.Columns.Add("MacID", typeof(Int64));
            _datatable.Columns.Add("VendorID", typeof(Int64));
            _datatable.Columns.Add("MetaValueID", typeof(int));
            _datatable.Columns.Add("DisplayText", typeof(string));
            _datatable.Columns.Add("ExpiryDate", typeof(DateTime));
            _datatable.Columns.Add("InvestigationID", typeof(Int64));
            _datatable.Columns.Add("IsExpired", typeof(char));
            DataRow _datarow;
            foreach (LotMaster i in lotmaster)
            {
                _datarow = _datatable.NewRow();
                _datarow["LotID"] = i.LotID;
                _datarow["LotName"] = i.LotName;
                _datarow["LotCode"] = i.LotCode;
                _datarow["MacID"] = i.MacID;
                _datarow["VendorID"] = i.VendorID;
                _datarow["DisplayText"] = i.DisplayText;
                _datarow["MetaValueID"] = 0;
                _datarow["ExpiryDate"] = i.ExpiryDate;
                _datarow["IsExpired"] = i.IsExpired;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToInvestigationID(string[] DisplayText,int[] InvestigationID)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("SNO", typeof(int));
            _datatable.Columns.Add("InvestigationID", typeof(int));
            _datatable.Columns.Add("DisplayText", typeof(string));
            DataRow _datarow;
            int count = InvestigationID.Length;
            for (int i = 0; i < count; i++)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = InvestigationID[i];
                _datarow["DisplayText"] = DisplayText[i];
                _datarow["SNO"] = i;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable AnalyzermappingDetails(List<QC_AnalyzerMapping> Analyzer)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("InvestigationID", typeof(Int64));
            _datatable.Columns.Add("TestCode", typeof(string));
            _datatable.Columns.Add("DeviceID",typeof(string));
            _datatable.Columns.Add("InstrumentID",typeof(Int64));
            _datatable.Columns.Add("FrequencyDay", typeof(string));
            _datatable.Columns.Add("FrequencyTime", typeof(String));
            _datatable.Columns.Add("QCRequired", typeof(String));
            DataRow _datarow;
            foreach (QC_AnalyzerMapping i in Analyzer)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = i.InvestigationID;
                _datarow["TestCode"] = i.AssayCode;
                _datarow["DeviceID"] = i.DeviceCode;
                _datarow["InstrumentID"] = i.InstrumentID;
                _datarow["FrequencyDay"] = i.FrequencyDay;
                _datarow["FrequencyTime"] = i.FrequencyTime;
                _datarow["QCRequired"] = i.QCRequired;
                _datatable.Rows.Add(_datarow);
            }
            
            return _datatable;
        }
        public static System.Data.DataTable UDT_lotManufacturermaster(List<DeviceManufacturer> manufacturermaster)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("ManufacturerName",typeof(string));
            _datatable.Columns.Add("ManufacturerCode",typeof(string));
            _datatable.Columns.Add("EmailID",typeof(string));
            _datatable.Columns.Add("MobileNo",typeof(string));
            DataRow _datarow;
            foreach (DeviceManufacturer i in manufacturermaster)
            {
                _datarow = _datatable.NewRow();
                _datarow["ManufacturerName"] = i.ManufacturerName;
                _datarow["ManufacturerCode"] = i.ManufacturerCode;
                _datarow["EmailID"] = i.EmailID;
                _datarow["MobileNo"] = i.MobileNo;
         
                _datatable.Rows.Add(_datarow);
            }

            return _datatable;
        }
        public static System.Data.DataTable UDT_lotvendormaster(List<LotVendorMaster> vendormaster)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("VendorName",typeof(string));
            _datatable.Columns.Add("Vendorcode",typeof(string));
            _datatable.Columns.Add("PanNo",typeof(string));
            _datatable.Columns.Add("SPOCName",typeof(string));
            _datatable.Columns.Add("EmailID",typeof(string));
            _datatable.Columns.Add("Mobileno",typeof(string));
            _datatable.Columns.Add("Landlineno",typeof(string));
            _datatable.Columns.Add("FaxNo",typeof(string));
            _datatable.Columns.Add("CountryID",typeof(int));
            _datatable.Columns.Add("StateID",typeof(int));
            _datatable.Columns.Add("CityID",typeof(int));
            _datatable.Columns.Add("PostalCode",typeof(string));
            _datatable.Columns.Add("TempAddress", typeof(string));
            _datatable.Columns.Add("PermenentAddress", typeof(string));
            _datatable.Columns.Add("Termsandconditions", typeof(string));
            DataRow _datarow;
            foreach (LotVendorMaster i in vendormaster)
            {
                _datarow = _datatable.NewRow();
                _datarow["VendorName"] = i.VendorName;
                _datarow["Vendorcode"] = i.Vendorcode;
                _datarow["PanNo"] = i.PanNo;
                _datarow["SPOCName"] = i.SPOCName;
                _datarow["EmailID"] = i.EmailID;
                _datarow["Mobileno"] = i.Mobileno;
                _datarow["Landlineno"] = i.Landlineno;
                _datarow["FaxNo"] = i.FaxNo;
                _datarow["CountryID"] = i.CountryID;
                _datarow["StateID"] = i.StateID;
                _datarow["CityID"] = i.CityID;
                _datarow["PostalCode"] = i.PostalCode;
                _datarow["TempAddress"] = i.TempAddress;
                _datarow["PermenentAddress"] = i.PermenentAddress;
                _datarow["Termsandconditions"] = i.Termsandconditions;

                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable AnalyteQcValueDetails(List<QcValueDetails> Analyzer)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("InvestigationID", typeof(Int64));
            _datatable.Columns.Add("TestCode", typeof(string));
            _datatable.Columns.Add("InvestigationName", typeof(string));
            _datatable.Columns.Add("InstrumentID", typeof(Int64));
            _datatable.Columns.Add("QCValueID", typeof(Int64));
            _datatable.Columns.Add("QCLevel", typeof(String));
            _datatable.Columns.Add("OrgAddressID", typeof(Int64));
            _datatable.Columns.Add("value1", typeof(string));
            _datatable.Columns.Add("value2", typeof(string));
            _datatable.Columns.Add("value3", typeof(string));
            _datatable.Columns.Add("value4", typeof(String));
            _datatable.Columns.Add("ProcessedAt", typeof(DateTime));
            _datatable.Columns.Add("IsUpdate", typeof(string));
            _datatable.Columns.Add("LotID", typeof(Int64));
            _datatable.Columns.Add("LotName", typeof(string));
            DataRow _datarow;
            foreach (QcValueDetails i in Analyzer)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = i.InvestigationID;
                _datarow["TestCode"] = i.TestCode;
                _datarow["InvestigationName"] = i.InvestigationName;
                _datarow["InstrumentID"] = i.InstrumentID;
                _datarow["QCValueID"] = i.QCValueID;
                _datarow["QCLevel"] = i.QCLevel;
                _datarow["OrgAddressID"] = i.OrgAddressID;
                _datarow["value1"] = i.Value1;
                _datarow["value2"] = i.Value2;
                _datarow["value3"] = i.Value3;
                _datarow["value4"] = i.Value4;
                _datarow["ProcessedAt"] = i.ProcessedAt;
                _datarow["IsUpdate"] = i.IsUpdate;
                _datarow["LotID"] = i.LotID;
                _datarow["LotName"] = i.LotName;
                _datatable.Rows.Add(_datarow);
            }

            return _datatable;
        }

        public static System.Data.DataTable InternalExternalQuality(List<InternalExternalQuality> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("AnalyteName", typeof(System.String));
            _datatable.Columns.Add("ResultValue", typeof(System.String));
            _datatable.Columns.Add("InternalResultValue", typeof(System.String));
            _datatable.Columns.Add("ExternalResultValue", typeof(System.String));
            _datatable.Columns.Add("Score", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("RootCause", typeof(System.String));
            _datatable.Columns.Add("Correction", typeof(System.Decimal));
            _datatable.Columns.Add("CorrectiveActions", typeof(System.String));
            _datatable.Columns.Add("PreventiveActions", typeof(System.String));
            _datatable.Columns.Add("Deviation", typeof(System.Decimal));
            _datatable.Columns.Add("EQMID", typeof(System.Int64));
            _datatable.Columns.Add("ID", typeof(System.Int64));

            DataRow _datarow;

            foreach (InternalExternalQuality _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["AnalyteName"] = _list.AnalyteName;
                _datarow["ResultValue"] = _list.ResultValue;
                _datarow["InternalResultValue"] = _list.InternalResultValue;
                _datarow["ExternalResultValue"] = _list.ExternalResultValue;
                _datarow["Score"] = _list.Score;
                _datarow["Status"] = _list.Status;
                _datarow["RootCause"] = _list.RootCause;
                _datarow["Correction"] = _list.Correction;
                _datarow["CorrectiveActions"] = _list.CorrectiveActions;
                _datarow["PreventiveActions"] = _list.PreventiveActions;
                _datarow["Deviation"] = _list.Deviation;
                _datarow["EQMID"] = _list.EQMID;
                _datarow["ID"] = _list.ID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConverttoEQAMaster(List<EQAMaster> EQAMaster)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("VendorID", typeof(System.Int64));
            _datatable.Columns.Add("CycleIdentification", typeof(System.String));
            _datatable.Columns.Add("DateOfProcessing", typeof(System.String));
            _datatable.Columns.Add("Interpretation", typeof(System.String));
            _datatable.Columns.Add("HasFile", typeof(System.Char));
            _datatable.Columns.Add("FileType", typeof(System.String));
            _datatable.Columns.Add("FilePath", typeof(System.String));
            _datatable.Columns.Add("ResultType", typeof(System.String));
            _datatable.Columns.Add("Extras", typeof(System.String));
            _datatable.Columns.Add("DeptID", typeof(System.Int64));
            DataRow _datarow;
            foreach (EQAMaster i in EQAMaster)
            {
                _datarow = _datatable.NewRow();
                _datarow["VendorID"] = i.VendorID;
                _datarow["CycleIdentification"] = i.CycleIdentification;
                _datarow["DateOfProcessing"] = i.DateOfProcessing;
                _datarow["Interpretation"] = i.Interpretation;
                _datarow["HasFile"] = i.HasFile;
                _datarow["FileType"] = i.FileType;
                _datarow["FilePath"] = i.FilePath;
                _datarow["ResultType"] = i.ResultType;
                _datarow["Extras"] = i.Extras;
                _datarow["DeptID"] = i.DeptID;

                

                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToUDT_TRFfilemanager_QMS(List<QMS_TRFfilemanager> lstFilemanager)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FileID", typeof(System.Int64));
            _datatable.Columns.Add("FileName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("IdentifyingID", typeof(System.String));
            _datatable.Columns.Add("IdentifyingType", typeof(System.String));
            _datatable.Columns.Add("FilePath", typeof(System.String));
            _datatable.Columns.Add("FileType", typeof(System.String));
            _datatable.Columns.Add("PageID", typeof(System.Int64));
            _datatable.Columns.Add("Createdby", typeof(System.Int64));
            _datatable.Columns.Add("Createdat ", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt ", typeof(System.DateTime));
            _datatable.Columns.Add("IsDelete", typeof(System.String));

            DataRow _datarow;

            foreach (QMS_TRFfilemanager _list in lstFilemanager)
            {
                _datarow = _datatable.NewRow();
                _datarow["FileID"] = _list.FileID;
                _datarow["FileName"] = _list.FileName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["IdentifyingID"] = _list.IdentifyingID;
                _datarow["IdentifyingType"] = _list.IdentifyingType;
                _datarow["FilePath"] = _list.FilePath;
                _datarow["FileType"] = _list.FileType;
                _datarow["PageID"] = _list.PageID;
                _datarow["Createdby"] = _list.Createdby;
                _datarow["Createdat "] = _list.Createdat;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt "] = _list.ModifiedAt;
                _datarow["IsDelete"] = _list.IsDelete;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable TrainingPrograms_QMS(List<TrainingProgram_QMS> List)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("OrgID", typeof(Int64));
            _datatable.Columns.Add("PlanScheduleID", typeof(Int64));
            _datatable.Columns.Add("ExamType", typeof(string));
            _datatable.Columns.Add("Participant", typeof(string));
            _datatable.Columns.Add("TotalMarks", typeof(Int32));
            _datatable.Columns.Add("MarksObtained", typeof(Int32));
            _datatable.Columns.Add("Remarks", typeof(String));
            _datatable.Columns.Add("TrainingProgramID", typeof(Int64));
            DataRow _datarow;
            foreach (TrainingProgram_QMS i in List)
            {
                _datarow = _datatable.NewRow();
                _datarow["OrgID"] = i.OrgID;
                _datarow["PlanScheduleID"] = i.PlanScheduleID;
                _datarow["ExamType"] = i.ExamType;
                _datarow["Participant"] = i.Participant;
                _datarow["TotalMarks"] = i.TotalMarks;
                _datarow["MarksObtained"] = i.MarksObtained;
                _datarow["Remarks"] = i.Remarks;
                _datarow["TrainingProgramID"] = i.TrainingProgramID;
                _datatable.Rows.Add(_datarow);
            }

            return _datatable;
        }


        public static System.Data.DataTable ConvertToUDT_PlanAndSchedule_QMS(List<PlanScheduleDetails_QMS> _lstCollection)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PlanScheduleID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("EventType", typeof(System.Int32));
            _datatable.Columns.Add("EventTypeCode", typeof(System.String));
            _datatable.Columns.Add("EventName", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("Todate", typeof(System.DateTime));
            _datatable.Columns.Add("AuditScope", typeof(System.String));
            _datatable.Columns.Add("AuditCriteria", typeof(System.String));
            _datatable.Columns.Add("Venue", typeof(System.String));
            _datatable.Columns.Add("Topic", typeof(System.String));
            _datatable.Columns.Add("Agenda", typeof(System.String));
            _datatable.Columns.Add("ProgramType", typeof(System.String));
            _datatable.Columns.Add("DeptID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("createdAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("Location", typeof(System.Int32));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ParicipantID", typeof(System.Int64));
            _datatable.Columns.Add("UserID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("Files", typeof(System.String));

            DataRow _datarow;

            foreach (PlanScheduleDetails_QMS _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PlanScheduleID"] = _list.PlanScheduleID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["EventType"] = _list.EventType;
                _datarow["EventTypeCode"] = _list.EventTypeCode;

                _datarow["EventName"] = _list.EventName;
                _datarow["FromDate"] = _list.FromDate;
                _datarow["Todate"] = _list.Todate;
                _datarow["AuditScope"] = _list.AuditScope;
                _datarow["AuditCriteria"] = _list.AuditCriteria;
                _datarow["Venue"] = _list.Venue;
                _datarow["Topic"] = _list.Topic;
                _datarow["Agenda"] = _list.Agenda;
                _datarow["ProgramType"] = _list.ProgramType;
                _datarow["DeptID"] = _list.DeptID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["createdAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["Location"] = _list.Location;
                _datarow["Status"] = _list.Status;
                _datarow["ParicipantID"] = _list.ParicipantID;
                _datarow["UserID"] = _list.UserID;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["Files"] = _list.Files;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToUDTScheduledMOM(List<ScheduledMOM> List)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("scheduledMOMID", typeof(System.Int64));
            _datatable.Columns.Add("PlanScheduleID", typeof(System.Int64));
            _datatable.Columns.Add("PointsDiscussed", typeof(System.String));
            _datatable.Columns.Add("ActionProposed", typeof(System.String));
            _datatable.Columns.Add("ProposedCompDate", typeof(System.DateTime));
            _datatable.Columns.Add("ResponsiblePerson", typeof(System.Int64));
            _datatable.Columns.Add("status", typeof(System.String));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            DataRow _datarow;

            foreach (ScheduledMOM i in List)
            {
                _datarow = _datatable.NewRow();
                _datarow["scheduledMOMID"] = i.ScheduledMOMID;
                _datarow["PlanScheduleID"] = i.PlanScheduleID;
                _datarow["PointsDiscussed"] = i.PointsDiscussed;
                _datarow["ActionProposed"] = i.ActionProposed;
                _datarow["ProposedCompDate"] = i.ProposedCompDate;
                _datarow["ResponsiblePerson"] = i.ResponsiblePerson;
                _datarow["status"] = i.Status;
                _datarow["DeptID"] = i.DeptID;
                _datarow["OrgID"] = i.OrgID;
                _datatable.Rows.Add(_datarow);
            }

            return _datatable;
        }

        public static System.Data.DataTable ConvertToUDTQCEvaluvationsDetails(List<QCEvaluvationsDetails> lstQCEvaluvationsDetails)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("InstrumentID", typeof(System.Int64));
            _datatable.Columns.Add("LotID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("Mean", typeof(System.Decimal));
            _datatable.Columns.Add("StandardDeviation", typeof(System.Decimal));
            _datatable.Columns.Add("CoVariation", typeof(System.Decimal));
            _datatable.Columns.Add("QCLevel", typeof(System.String));
            DataRow _datarow;

            foreach (QCEvaluvationsDetails i in lstQCEvaluvationsDetails)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = i.InvestigationID;
                _datarow["InstrumentID"] = i.InstrumentID;
                _datarow["LotID"] = i.LotID;
                _datarow["OrgID"] = i.OrgID;
                _datarow["Mean"] = i.Mean;
                _datarow["StandardDeviation"] = i.StandardDeviation;
                _datarow["CoVariation"] = i.CoVariation;
                _datarow["QCLevel"] = i.QCLevel;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
    }
}