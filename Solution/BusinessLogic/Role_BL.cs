using System;
using System.Data;
using System.Configuration;
using System.Web;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using Attune.Kernel.CacheEngine;


namespace Attune.Solution.BusinessComponent
{
    public class Role_BL
    {
         ContextDetails globalContextDetails;
        public Role_BL()
        {

        }
        public Role_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetRole(Role role, out long RoleID)
        {

            long lresult = -1;
            Role_DAL RoleDal = new Role_DAL(globalContextDetails);
            lresult = RoleDal.GetRole(role, out RoleID);
            return lresult;

        }

        public long SaveLoginRole(LoginRole LoginRole)
        {
            long lresult = -1;
            Role_DAL RoleDal = new Role_DAL(globalContextDetails);
            lresult = RoleDal.SaveLoginRole(LoginRole);

            return lresult;
        }

        public long GetRoleName(int OrgID, out List<Role> role)
        {
            long returncode = -1;
            role = new List<Role>();
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            returncode = RoleDAL.GetRoleName(OrgID, out role);
            return returncode;
        }
        public long Savesysconfig(Login login, out long LoginID)
        {
            long lresult = -1;
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            lresult = RoleDAL.Savesysconfig(login, out LoginID);
            return lresult;
        }

        public long GetUsersAgainstRole(long pRoleID, out List<OrgUsers> lstOrgUsers)
        {
            long returnCode = -1;
            lstOrgUsers = new List<OrgUsers>();
            try
            {
                returnCode = new Role_DAL(globalContextDetails).GetUsersAgainstRole(pRoleID, out lstOrgUsers);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetUsersAgainstRole", ex);
            }

            return returnCode;
        }
        //public long GetMenuMapperInfo(long pRoleID, int pOrgID, out List<RoleMenuInfo> lstRoleMenuInfo)//, out List<MenuMasterHeader> lstMenuMasterHeader
        //{
        //    long returnCode = -1;
        //    lstRoleMenuInfo = new List<RoleMenuInfo>();
        //  //  lstMenuMasterHeader = new List<MenuMasterHeader>();
        //    try
        //    {
        //        returnCode = new Role_DAL(globalContextDetails).GetMenuMapperInfo(pRoleID, pOrgID, out lstRoleMenuInfo);//, out lstMenuMasterHeader
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL GetMenuMapperInfo", ex);
        //    }

        //    return returnCode;
        //}

        public long GetMenuMapperInfo(long pRoleID, int pOrgID, out List<RoleMenuInfo> lstRoleMenuInfo, out List<RoleMenuInfo> lstRoleMenuInfoAll,out List<RoleMenuInfo> lstRoleInfo) 
        {
            long returnCode = -1;
            lstRoleMenuInfo = new List<RoleMenuInfo>();
            lstRoleMenuInfoAll = new List<RoleMenuInfo>();
            lstRoleInfo = new List<RoleMenuInfo>();
            try
            {
                returnCode = new Role_DAL(globalContextDetails).GetMenuMapperInfo(pRoleID, pOrgID, out lstRoleMenuInfo, out lstRoleMenuInfoAll, out lstRoleInfo); 
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetMenuMapperInfo", ex);
            }

            return returnCode;
        }

        public long SaveMenuMapperInfo(long pRoleID, int pOrgID, int pPageID, int pSeqNo, string pDispText, string pPageURL, int pParentID, List<RoleMenuInfo> lstRoleMenuInfo)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Role_DAL(globalContextDetails).SaveMenuMapperInfo(pRoleID, pOrgID,pPageID,pSeqNo,pDispText,pPageURL,pParentID,lstRoleMenuInfo);

                CacheProvider _cp = new CacheProvider(1);
                string pkey = _cp.getKey(AttCacheKey.MenuCache, pOrgID);
                if (_cp.IsInCache(pkey))
                {
                    _cp.Remove(pkey);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL SaveMenuMapperInfo", ex);
            }

            return returnCode;
        }

        

        public long GetAllActions(int pOrgID, long pRoleID, long pMenuID, string @pSearchTypeCode, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            try
            {
                returnCode = new Role_DAL(globalContextDetails).GetAllActions( pOrgID,  pRoleID,  pMenuID,  @pSearchTypeCode, out lstActionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetAllActions", ex);
            }

            return returnCode;
        }

        public long SaveAllActions(int pOrgID, long pRoleID, long pMenuID, string @pSearchTypeCode, List<RoleMenuInfo> lstActionMaster)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Role_DAL(globalContextDetails).SaveAllActions(pOrgID, pRoleID, pMenuID, @pSearchTypeCode, lstActionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL SaveAllActions", ex);
            }

            return returnCode;
        }

        public long UpdateDigitalSignature(Login login)
        {
            long lresult = -1;
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            lresult = RoleDAL.UpdateDigitalSignature(login);
            return lresult;
        }

        public long GetUserImage(long OrgID, long LoginID, out Login lstlogin)
        { 
            long returnCode = -1;
            lstlogin = new Login();
            Role_DAL roleDAL=new Role_DAL(globalContextDetails);
            try
            {
                returnCode = roleDAL.GetUserImage(OrgID, LoginID, out lstlogin);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetUserImage Role_BL", excp);
            }
            return returnCode;
        }

        public long GetPerformRefundRole(int OrgID,int TaskActionId, out List<Role> role)
        {
            long returncode = -1;
            role = new List<Role>();
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            returncode = RoleDAL.GetPerformRefundRole(OrgID, TaskActionId,out role);
            return returncode;
        }
        public long SaveRole(string RoleName, int Organisation, string Desc, int OrgId )
        {
            long returncode = -1;
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            returncode = RoleDAL.SaveRole(RoleName, Organisation, Desc, OrgId );
            return returncode;
        }
        public long LoadPageURL(int OrgID, out List<Role> PageURL)
        {
            long returncode = -1;
            PageURL = new List<Role>();
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            returncode = RoleDAL.LoadPageURL(OrgID, out PageURL);
            return returncode;
        }
        public long GetRoleNameForMenuMapper(int OrgID, out List<Role> role)
        {
            long returncode = -1;
            role = new List<Role>();
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            returncode = RoleDAL.GetRoleNameForMenuMapper(OrgID, out role);
            return returncode;
        }
        public long GetRoleLocation(int OrgID, long RoleID, long LoginID, out List<OrganizationAddress> lstRole, out List<InvDeptMaster> lstRoleDeptMap)
        {
            long returncode = -1;
            lstRole = new List<OrganizationAddress>();
            lstRoleDeptMap = new List<InvDeptMaster>();
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            returncode = RoleDAL.GetRoleLocation(OrgID, RoleID, LoginID, out lstRole, out lstRoleDeptMap);
            return returncode;
        }

        public long UpdateBlockUser(long LoginID, DateTime BlockedFrom, DateTime BlockedTo, string BlockReason, DateTime EndDTTM, long ModifiedBy)
        {
            long lresult = -1;
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            lresult = RoleDAL.UpdateBlockUser(LoginID,BlockedFrom,BlockedTo,BlockReason,EndDTTM,ModifiedBy);
            return lresult;
        }


        public long InsertMapDetails(List<RoleDeptMap> allChecked )
        {
            long returnCode = -1;
            try
            {
                Role_DAL objUserDAL = new Role_DAL(globalContextDetails);
                returnCode= objUserDAL.InsertRoleDeptMap(allChecked);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL InsertMapDetails", ex);
            }

            return returnCode;  
           
        }
        public long GetDeptID(long RoleID, out List<RoleDeptMap> lstDeptID)
        {
            long returncode = -1;
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            returncode = RoleDAL.GetDeptID(RoleID, out lstDeptID);
            return returncode;
        }

        public long SearchUserDetail(int orgID, List<Role> allchecked, out List<Role> lstRole, out List<LoginRole> lstLoginRole, int pageSize, int StartRowIndex, out int totalRows, string Pname)
        {
            long returnCode = -1;
            totalRows = 0;
            lstRole = new List<Role>();
            lstLoginRole = new List<LoginRole>();
            try
            {
                Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
                returnCode = RoleDAL.SearchUserDetail(orgID, allchecked, out lstRole, out lstLoginRole, pageSize, StartRowIndex, out totalRows, Pname);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetAdminInvestigationRate BL", ex);
            }
            return returnCode;
        }
        public long GetUserName(long OrgID, long RoleID, out List<Users> lstUsers)
        {
            long returncode = -1;
            lstUsers = new List<Users>();

            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            returncode = RoleDAL.GetUserName(OrgID, RoleID, out lstUsers);
            return returncode;
        }
        public long GetDepartment(int OrgID, out List<Department> dept)
        {
            long returncode = -1;
            dept = new List<Department>();
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            returncode = RoleDAL.GetDepartment(OrgID, out dept);
            return returncode;
        } 
        //-------------client logo----//

        public long UpdateClientLogo(Login login)
        {
            long lresult = -1;
            Role_DAL RoleDAL = new Role_DAL(globalContextDetails);
            lresult = RoleDAL.UpdateClientLogo(login);
            return lresult;
        }

        public long GetClientLogo(long OrgID, long LoginID, out Login lstlogin)
        {
            long returnCode = -1;
            lstlogin = new Login();
            Role_DAL roleDAL = new Role_DAL(globalContextDetails);
            try
            {
                returnCode = roleDAL.GetClientLogo(OrgID, LoginID, out lstlogin);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetUserImage Role_BL", excp);
            }
            return returnCode;
        }
        //-------------client logo----//
        
    }
}
