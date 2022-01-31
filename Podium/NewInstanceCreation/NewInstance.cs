using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.DataAccessLayer;
using Attune.Podium.BusinessEntities;
using System.Data;
using Attune.Podium.Common;
using System.Collections;
using System.Security.Cryptography;

namespace Attune.Podium.NewInstanceCreation
{
    public class NewInstance
    {
        ContextDetails globalContextDetails;
        public NewInstance()
        {

        }
        public NewInstance(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long CreateOrgInstanceQueue(string pOrgName, List<Organization> lstOrganization, List<Role> lstRoles, List<VisitPurpose> lstVisitPurposes,List<Department> lstDept,out int pRetStatus, string strPassword, long CurrencyID, string AliceType ,int OldInsID)
        {
            long returnCode = -1;
            pRetStatus = -1;

            try
            {
                DataTable dtOrganization = GetNewOrg(lstOrganization);
                DataTable dtVisitPurposes = GetNewVP(lstVisitPurposes);
                DataTable dtRoles = GetNewRoles(lstRoles);
                DataTable dtDept = GetNewDept(lstDept);

                returnCode = new NewInstanceCreation_DAL(globalContextDetails).CreateOrgInstanceQueue(pOrgName, dtOrganization, dtRoles, dtVisitPurposes,dtDept,out pRetStatus, strPassword, CurrencyID, AliceType, OldInsID);
 
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewInstanceCreation_BL, CreateOrgInstanceQueue", ex);
            }

            return returnCode;
        }

        private System.Data.DataTable GetNewOrg(List<Organization> lstOrg)
        {
            System.Data.DataTable dt = new DataTable();

            //add columns
            dt.Columns.Add("OrgID");
            dt.Columns.Add("OrgAddID");
            dt.Columns.Add("Name");
            dt.Columns.Add("OrganizationTypeID");
            dt.Columns.Add("LogoPath");
            dt.Columns.Add("Add1");
            dt.Columns.Add("Add2");
            dt.Columns.Add("Add3");
            dt.Columns.Add("PostalCode");
            dt.Columns.Add("CountryID");
            dt.Columns.Add("City");
            dt.Columns.Add("StateID");
            dt.Columns.Add("LandLineNumber");
            dt.Columns.Add("Location");
            dt.Columns.Add("StartDTTM");
            dt.Columns.Add("EndDTTM");
            dt.Columns.Add("OtherCountryName");
            dt.Columns.Add("OtherStateName");
            dt.Columns.Add("MobileNo");
            dt.Columns.Add("Isdefaultorg");
            dt.Columns.Add("DefaultOrgID");
            dt.Columns.Add("ReportLanguage");
            DataRow dr;

            foreach (Organization o in lstOrg)
            {
                dr = dt.NewRow();
                dr["OrgID"] = o.OrgID;
                dr["OrgAddID"] = o.AddressID;
                dr["Name"] = o.Name;
                dr["OrganizationTypeID"] = o.OrganizationTypeID;
                dr["LogoPath"] = o.LogoPath;
                dr["Add1"] = o.Add1;
                dr["Add2"] = o.Add2;
                dr["Add3"] = o.Add3;
                dr["PostalCode"] = o.PostalCode;
                dr["CountryID"] = o.CountryID;
                dr["City"] = o.City;
                dr["StateID"] = o.StateID;
                dr["LandLineNumber"] = o.LandLineNumber;
                dr["Location"] = o.Location;
                dr["StartDTTM"] = o.StartDTTM;
                dr["EndDTTM"] = o.EndDTTM;
                dr["OtherCountryName"] = o.OtherCountryName;
                dr["OtherStateName"] = o.OtherStateName;
                dr["MobileNo"] = o.PhoneNumber;
                dr["Isdefaultorg"]=o.Isdefaultorg;
                dr["DefaultOrgID"] = o.DefaultOrgID;
                dr["ReportLanguage"] = o.ReportLanguage;
                dt.Rows.Add(dr);
            }

            return dt;
        }

        private System.Data.DataTable GetNewRoles(List<Role> lstRl)
        {
            System.Data.DataTable dt = new DataTable();

            //add columns
            dt.Columns.Add("RoleID");
            dt.Columns.Add("RoleName");
            dt.Columns.Add("Description");
            dt.Columns.Add("OrgID");
            dt.Columns.Add("OrgAddressID");
            dt.Columns.Add("DeptID");

            DataRow dr;

            foreach (Role r in lstRl)
            {
                dr = dt.NewRow();
                dr["RoleID"] = r.RoleID;
                dr["RoleName"] = r.RoleName;
                dr["Description"] = r.Description;
                dr["OrgID"] = r.OrgID;
                dr["OrgAddressID"] = r.OrgAddressID;
                dr["DeptID"] = 0;
                dt.Rows.Add(dr);
            }

            return dt;
        }

        private System.Data.DataTable GetNewVP(List<VisitPurpose> lstVP)
        {
            System.Data.DataTable dt = new DataTable();

            //add columns
            dt.Columns.Add("VisitPurposeID");
            dt.Columns.Add("VisitPurposeName");
            dt.Columns.Add("OrgID");
            dt.Columns.Add("OrgAddressID");
            dt.Columns.Add("VisitType");

            DataRow dr;

            foreach (VisitPurpose vp in lstVP)
            {
                dr = dt.NewRow();
                dr["VisitPurposeID"] = vp.VisitPurposeID;
                dr["VisitPurposeName"] = vp.VisitPurposeName;
                dr["OrgID"] = vp.OrgID;
                dr["OrgAddressID"] = vp.OrgAddressID;
                dr["VisitType"] = vp.VisitType;
                dt.Rows.Add(dr);
            }

            return dt;
        }
        private System.Data.DataTable GetNewDept(List<Department> lstdept)
        {
            System.Data.DataTable dt = new DataTable();
            dt.Columns.Add("DeptID");
            dt.Columns.Add("DeptName");
            dt.Columns.Add("OrgID");
            dt.Columns.Add("OrgAddressID");

            DataRow dr;
            foreach(Department dp in lstdept)
            {
                dr = dt.NewRow();
                dr["DeptID"]=dp.DeptID;
                dr["DeptName"] = dp.DeptName;
                dr["OrgID"] = dp.OrgID;
                dr["OrgAddressID"] = dp.OrgAddressID;
                dt.Rows.Add(dr);
            }
            return dt;   
        }

        public long CreateatedOrgInstanceDetail(out List<NewInstanceCreationTracker> lstNICT, out long pReturnStatus)
        {
            long returnCode = -1;
            //pLoginName = string.Empty;
            //pPassword = string.Empty;
            //pOrgName = string.Empty;
            pReturnStatus = -1;
            lstNICT = new List<NewInstanceCreationTracker>();
            List<NewInstanceCreationTracker> lstNICT1 = new List<NewInstanceCreationTracker>();
            try
            {
                returnCode = new NewInstanceCreation_DAL(globalContextDetails).CreateatedOrgInstanceDetail(out lstNICT, out pReturnStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewInstanceCreation_BL, CreateatedOrgInstanceDetail", ex);
            }
            lstNICT1=lstNICT ;
            if (lstNICT1.Count > 0)
            {
                string strDecryptedString = "abc123";
                for (int i = 0; i < lstNICT1.Count; i++)
                {
                    try
                    {
                       
                        Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
                        obj.Crypt(lstNICT1[i].DefaultPassword, out strDecryptedString);
                        lstNICT[i].DefaultPassword = strDecryptedString;
                    }
                    catch (Exception ex)
                    {
                        CLogger.LogError("Error in NewInstanceCreation.aspx.cs_DecryptedString() Method", ex);
                        strDecryptedString = lstNICT1[i].DefaultPassword;
                    }
                }
            }

            return returnCode;
        }

        public long pCheckOrganizationName(string pOrgName, out int pReturnStatus)
        {
            long returnCode = -1;
            pReturnStatus = -1;
            try
            {
                returnCode = new NewInstanceCreation_DAL(globalContextDetails).pCheckOrganizationName(pOrgName, out pReturnStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewInstanceCreation_BL, pCheckOrganizationName", ex);
            }

            return returnCode;
        }

    }
}
