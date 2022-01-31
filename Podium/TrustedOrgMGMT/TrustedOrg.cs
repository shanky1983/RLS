using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.DataAccessLayer;
using Attune.Podium.BusinessEntities;
using System.Data;
using Attune.Podium.Common;

namespace Attune.Podium.TrustedOrg
{
    public class TrustedOrg
    {
         ContextDetails globalContextDetails;
        public TrustedOrg()
        {

        }
        public TrustedOrg(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetTrustedOrgList(int pLoggedOrgID, long pRID, string pType, out List<TrustedOrgDetails> lstTrustedOrgDetails)
        {
            long returnCode = -1;
            lstTrustedOrgDetails = new List<TrustedOrgDetails>();
            try
            {
                returnCode = new TrustedOrgDAL(globalContextDetails).GetTrustedOrgList(pLoggedOrgID, pRID, pType, out lstTrustedOrgDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in TrustedOrg", ex);
            }

            return returnCode;
        }

        public long CheckPageAccess(string ActionCode, int ownerOrgID, int patOrgID, out int pCount)
        {
            long returnCode = -1;
            pCount = -1;

            try
            {
                returnCode = new TrustedOrgDAL(globalContextDetails).CheckPageAccess(ActionCode, ownerOrgID, patOrgID, out pCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL CheckPageAccess", ex);
            }
            return returnCode;
        }
        public long CheckActionAccess(List<TrustedOrgActions> lstTrustedOrgActions, out int pCount)
        {
            long returnCode = -1;
            pCount = -1;
            DataTable DtLDetail = GetTrustedOrgActionsDataTable(lstTrustedOrgActions);
            try
            {
                returnCode = new TrustedOrgDAL(globalContextDetails).CheckActionAccess(DtLDetail, out pCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL CheckPageAccess", ex);
            }
            return returnCode;
        }
        private System.Data.DataTable GetTrustedOrgActionsDataTable(List<TrustedOrgActions> lstTrustedOrgActions)
        {
           System.Data.DataTable dt = new DataTable();
            DataColumn dbCol1 = new DataColumn("LoggedOrgID");
            DataColumn dbCol2 = new DataColumn("SharingOrgID");
            DataColumn dbCol3 = new DataColumn("IdentifyingType");
            DataColumn dbCol4 = new DataColumn("IdentifyingActionID");
            DataColumn dbCol5 = new DataColumn("RoleID");
            DataColumn dbCol6 = new DataColumn("DummyString");
            dt.Columns.Add(dbCol1);
            dt.Columns.Add(dbCol2);
            dt.Columns.Add(dbCol3);
            dt.Columns.Add(dbCol4);
            dt.Columns.Add(dbCol5);
            dt.Columns.Add(dbCol6);
            DataRow dr;

            foreach (TrustedOrgActions oTrustedOrgActions in lstTrustedOrgActions)
            {
                dr = dt.NewRow();
                dr["LoggedOrgID"] = oTrustedOrgActions.LoggedOrgID;
                dr["SharingOrgID"] = oTrustedOrgActions.SharingOrgID;
                dr["IdentifyingType"] = oTrustedOrgActions.IdentifyingType;
                dr["IdentifyingActionID"] = oTrustedOrgActions.IdentifyingActionID;
                dr["RoleID"] = oTrustedOrgActions.RoleID;
                dr["DummyString"] = oTrustedOrgActions.DummyString;

                dt.Rows.Add(dr);
            }
            return dt;
        }
        public long GetSharingOrgList(int orgID, out List<Organization> lstorgn, out List<Locations> lstloc)
        {
            long returnCode = -1;
            TrustedOrgDAL trustedOrgDAL = new TrustedOrgDAL(globalContextDetails);
            lstorgn = new List<Organization>();
            lstloc = new List<Locations>();
            try
            {
                returnCode = trustedOrgDAL.GetSharingOrgList(orgID, out lstorgn, out lstloc);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSharingOrgList in Inventory_BL", ex);
            }
            return returnCode;

        }

        public long GetTrustedItemsForMapping(int orgID, List<ModuleCategory> lstModuleCategory, out List<TrustedItems> lstorgn)
        {
            long returnCode = -1;
            TrustedOrgDAL trustedOrgDAL = new TrustedOrgDAL(globalContextDetails);
            lstorgn = new List<TrustedItems>();
            DataTable DtLModuleCategory = GetModuleCategoryTable(lstModuleCategory);
            try
            {
                returnCode = trustedOrgDAL.GetTrustedItemsForMapping(orgID, DtLModuleCategory, out lstorgn);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSharingOrgList in TrustedOrg_BL", ex);
            }
            return returnCode; 
        }
        public long GetModuleCategory(out List<ModuleCategory> lstorgn)
        {
            long returnCode = -1;
            TrustedOrgDAL trustedOrgDAL = new TrustedOrgDAL(globalContextDetails);
            lstorgn = new List<ModuleCategory>();

            try
            {
                returnCode = trustedOrgDAL.GetModuleCategory(out lstorgn);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSharingOrgList in TrustedOrg_BL", ex);
            }
            return returnCode;
        }
        private System.Data.DataTable GetModuleCategoryTable(List<ModuleCategory> pModuleCategory)
        {
            System.Data.DataTable dt = new DataTable();
            DataColumn dbCol1 = new DataColumn("ModuleID");
            DataColumn dbCol2 = new DataColumn("ModuleName");
            DataColumn dbCol3 = new DataColumn("ModuleCode");
         
            dt.Columns.Add(dbCol1);
            dt.Columns.Add(dbCol2);
            dt.Columns.Add(dbCol3);

            foreach (ModuleCategory Obj in pModuleCategory)
            {
                DataRow dr; 
                dr = dt.NewRow();
                dr["ModuleID"] = Obj.ModuleID;
                dr["ModuleName"] = Obj.ModuleName;
                dr["ModuleCode"] = Obj.ModuleCode;

                dt.Rows.Add(dr);
            }
            return dt;
        }

        public long SaveMappedTrustedItems(int ShareOrgID, int OrgID, List<TrustedOrgActions> lstTrustedOrgActions)
        {
            long returnCode = -1;
            TrustedOrgDAL trustedOrgDAL = new TrustedOrgDAL(globalContextDetails);
            DataTable DtTrustedOrgActions = GetDataTrustedOrgActions(lstTrustedOrgActions);
            int LoggedOrgID = ShareOrgID;
            int SharingOrgID = OrgID;
            try
            {
                returnCode = trustedOrgDAL.SaveMappedTrustedItems(LoggedOrgID, SharingOrgID, DtTrustedOrgActions);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMapTrustedItems method in TrustedOrg_BL", ex);
            }
            return returnCode;
        }
        private System.Data.DataTable GetDataTrustedOrgActions(List<TrustedOrgActions> pTrustedOrgActions)
        {
            System.Data.DataTable dt = new DataTable();
            DataColumn dbCol1 = new DataColumn("LoggedOrgID");
            DataColumn dbCol2 = new DataColumn("SharingOrgID");
            DataColumn dbCol3 = new DataColumn("IdentifyingType");
            DataColumn dbCol4 = new DataColumn("IdentifyingActionID");
            DataColumn dbCol5 = new DataColumn("RoleID");
            DataColumn dbCol6 = new DataColumn("DummyString");
            dt.Columns.Add(dbCol1);
            dt.Columns.Add(dbCol2);
            dt.Columns.Add(dbCol3);
            dt.Columns.Add(dbCol4);
            dt.Columns.Add(dbCol5);
            dt.Columns.Add(dbCol6);
            DataRow dr;

            foreach (TrustedOrgActions Obj in pTrustedOrgActions)
            {
                dr = dt.NewRow();
                dr["LoggedOrgID"] = Obj.LoggedOrgID;
                dr["SharingOrgID"] = Obj.SharingOrgID;
                dr["IdentifyingType"] = Obj.IdentifyingType;
                dr["IdentifyingActionID"] = Obj.IdentifyingActionID;
                dr["RoleID"] = Obj.RoleID;
                dr["DummyString"] = Obj.DummyString;

                dt.Rows.Add(dr);
            }
            return dt;
        }

        public long GetMappedTrustedItems(int ShareOrgID,int  OrgID, out List<TrustedOrgActions> lstorgn)
        {
            long returnCode = -1;
            TrustedOrgDAL trustedOrgDAL = new TrustedOrgDAL(globalContextDetails);
            lstorgn = new List<TrustedOrgActions>();
            int LoggedOrgID =ShareOrgID ;
            int SharingOrgID = OrgID;
            try
            {
                returnCode = trustedOrgDAL.GetMappedTrustedItems(LoggedOrgID, SharingOrgID, out lstorgn);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetMappedTrustedItems in TrustedOrg_BL", ex);
            }
            return returnCode;
        }
    }
}
