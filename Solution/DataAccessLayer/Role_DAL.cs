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

namespace Attune.Solution.DAL
{
    public class Role_DAL
    {
        ContextDetails globalContextDetails;
        public Role_DAL()
        {
            
        }
        public Role_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetRole(Role role, out long RoleID)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pGetRoleCommand(role.RoleName, out RoleID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                    RoleID = Convert.ToInt64(cmd.Parameters["@pRoleID"].Value);
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing role" + cmd.CommandText, ex);
            }

            return lresult;
        }



        public long SaveLoginRole(LoginRole LoginRole)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pInsertLoginRoleCommand(LoginRole.RoleID, LoginRole.LoginID, LoginRole.CreatedBy, LoginRole.ModifiedBy, "", 0,LoginRole.Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Loginrole" + cmd.CommandText, ex);
            }

            return lresult;
        }

        public long GetRoleName(int OrgID, out List<Role> role)
        {
            long returncode = -1;
            role = new List<Role>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetRoleNameCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out role);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetRoleName Role_DAL", e);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returncode;
        }

        public long Savesysconfig(Login login, out long LoginID)
        {
            long lresult = -1;
            LoginID = -1;

            SqlCommand cmd = Command.pInsertSysConfigCommand(login.LoginName, login.OrgID, login.CreatedBy, login.FilePath, login.ImageSource,
                out LoginID, login.Password, login.Transactionpasssword, login.LoginPwdExpDate, login.TransPwdExpDate, login.EndDTTM, login.Status, login.PrinterPath,
                UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                    LoginID = Convert.ToInt64(cmd.Parameters["@pLoginID"].Value);
                }
            }




            catch (Exception ex)
            {
                CLogger.LogError("Error while executing savesysconfig" + cmd.CommandText, ex);
            }

            return lresult;
        }

        public long GetCheckLogindetails(string LoginName)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pGetCheckLoginExistCommand(LoginName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@return", SqlDbType.Int);
            cmd.Parameters["@return"].Direction = ParameterDirection.ReturnValue;

            try
            {

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    lresult = Convert.ToInt16(cmd.Parameters["@return"].Value.ToString());
                }


            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while Check login details" + cmd.CommandText, ex);
            }

            return lresult;



        }

        public long GetUsersAgainstRole(long pRoleID, out List<OrgUsers> lstOrgUsers)
        {
            long returnCode = -1;
            lstOrgUsers = new List<OrgUsers>();
            try
            {
                SqlCommand cmd = Command.pGetUsersAgainstRoleCommand(pRoleID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrgUsers);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetUsersAgainstRole", ex);
            }


            return returnCode;
        }



        public long GetMenuMapperInfo(long pRoleID, int pOrgID, out List<RoleMenuInfo> lstRoleMenuInfo, out List<RoleMenuInfo> lstRoleMenuInfoAll, out List<RoleMenuInfo> lstRoleInfo) 
        {
            long returnCode = -1;
            lstRoleMenuInfo = new List<RoleMenuInfo>();
            lstRoleMenuInfoAll = new List<RoleMenuInfo>();
            lstRoleInfo = new List<RoleMenuInfo>();
            try
            {
                SqlCommand cmd = Command.pGetMenuMapperInfoCommand(pRoleID, pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRoleMenuInfo);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstRoleMenuInfoAll);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstRoleInfo);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetMenuMapperInfo", ex);
            }
            return returnCode;
        }

        public long SaveMenuMapperInfo(long pRoleID, int pOrgID,int pPageID,int pSeqNo,string pDispText,string pPageURL,int pParentID, List<RoleMenuInfo> lstRoleMenuInfo)
        {
            long returnCode = -1;
            DataTable dtRoleMenuInfo = UDT_DAL.ConvertToUDTRoleMenuInfo(lstRoleMenuInfo);
            SqlCommand cmd = Command.pSaveMenuMapperInfoCommand(pRoleID, pOrgID, pPageID, pSeqNo, pDispText, pPageURL, pParentID, dtRoleMenuInfo,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing savesysconfig" + cmd.CommandText, ex);
            }
            return returnCode;
        }

    
        

        public long GetAllActions(int pOrgID, long pRoleID, long pMenuID, string @pSearchTypeCode, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            try
            {
                SqlCommand cmd = Command.pGetAllActionsCommand(pOrgID, pRoleID, pMenuID, @pSearchTypeCode,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstActionMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetAllActions", ex);
            }
            return returnCode;
        }

        public long UpdateDigitalSignature(Login login)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pUpdateDigitalSignatureCommand(login.OrgID, login.LoginID, login.FilePath, login.ImageSource,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateDigitalSignature", ex);
            }
            return lresult;
        }

        public long GetUserImage(long OrgID, long LoginID, out Login lstLogin)
        {
            long returnCode = -1;
            lstLogin = new Login();
            List<Login> logins = new List<Login>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetUserImageCommand(OrgID, LoginID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out logins);
                        dataReader.Close();
                    }
                    if (logins.Count > 0)
                        lstLogin = logins[0];
                }
            }
            catch (Exception ex)
            { 
                CLogger.LogError("Error while executing GetUserImage in RoleDAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }

        public long SaveAllActions(int pOrgID, long pRoleID, long pMenuID, string @pSearchTypeCode, List<RoleMenuInfo> lstActionMaster)
        {
            long returnCode = -1;
            DataTable dtActionMaster = UDT_DAL.ConvertToUDTRoleMenuInfo(lstActionMaster);
            SqlCommand cmd = Command.pSaveAllActionsCommand(pOrgID, pRoleID, pMenuID, @pSearchTypeCode, dtActionMaster,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveAllActions" + cmd.CommandText, ex);
            }
            return returnCode;
        }
        public long GetPerformRefundRole(int OrgID,int TaskActionId, out List<Role> role)
        {
            long returncode = -1;
            role = new List<Role>();
            IDataReader dataReader = null;
           
            try
            {
                SqlCommand cmd = Command.pGetPerformRefundRoleCommand(OrgID, TaskActionId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out role);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPerformRefundRole Role_DAL", e);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returncode;
        }
        public long SaveRole(string RoleName, int Organisation, string Desc, int OrgId )
        {
            long returncode = -1;

            SqlCommand cmd = Command.pSaveRoleCommand(RoleName,Organisation, Desc, OrgId ,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            return returncode;
        }
        public long LoadPageURL(int OrgID, out List<Role>PageURL)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pGetPageURLCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            PageURL = new List<Role>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[0], out PageURL);
            }

            return returncode;
        }

        public long GetRoleNameForMenuMapper(int OrgID, out List<Role> role)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pGetRoleNameformenumapperCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            role = new List<Role>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[0], out role);
            }

            return returncode;
        }
        public long GetRoleLocation(int OrgID, long RoleID, long LoginID, out List<OrganizationAddress> lstRole, out List<InvDeptMaster> lstRoleDeptMap)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pGetRoleLocationCommand(OrgID, RoleID, LoginID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstRole = new List<OrganizationAddress>();
            lstRoleDeptMap = new List<InvDeptMaster>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[0], out lstRole);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[1], out lstRoleDeptMap);
            }
            return returncode;
        }

        public long UpdateBlockUser(long LoginID, DateTime BlockedFrom, DateTime BlockedTo, string BlockReason, DateTime EndDTTM,long ModifiedBy)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pUpdateBlockUserCommand(LoginID,BlockedFrom,BlockedTo,BlockReason,EndDTTM,ModifiedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateBlockUser", ex);
            }
            return lresult;
        }
        
        public long InsertRoleDeptMap(List<RoleDeptMap> allChecked)
        {
            long lresult = -1;
            DataTable dTable = UDT_DAL.ConvertToUDTRole(allChecked);
            SqlCommand cmd = Command.pInsertRoleDeptMapCommand(dTable,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pInsertMapDetailsCommand", ex);
            }
            return lresult;
        }

       
      

        public long GetDeptID(long RoleID, out List<RoleDeptMap> lstDeptID)
        {
            long returncode = -1;
            lstDeptID = new List<RoleDeptMap>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetRoleDeptMapCommand(RoleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstDeptID);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetDeptID Role_DAL", e);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returncode;
        }
        public long SearchUserDetail(int orgID, List<Role> allchecked, out List<Role> lstRole, out List<LoginRole> lstLoginRole, int pageSize, int StartRowIndex, out int totalRows, string Pname)
        {
            lstRole = new List<Role>();
            lstLoginRole = new List<LoginRole>();
            totalRows = 0;
            //   DataTable dTable = GetRoleTable(allchecked);
            IDataReader dataReader = null;
            int rsCount = 0;
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pSearchUserDetailCommand(orgID, pageSize, StartRowIndex, out totalRows, Pname, UDT_DAL.ConvertToUDTRole(allchecked), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstRole);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstLoginRole);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                    Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting SearchUserDetail in Role_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }
        public long GetUserName(long  OrgID, long RoleID, out List<Users> lstUsers)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pGetUserNameCommand(OrgID, RoleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstUsers = new List<Users>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[0], out lstUsers);
            }

            return returncode;
        }
        public long GetDepartment(int OrgID, out List<Department> dept)
        {
            long returncode = -1;
            SqlCommand cmd = Command.pGetDepartmentListCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            dept = new List<Department>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[0], out dept);
            }
            return returncode;
        }
        //-------------------Client Logo-------------------------
        public long GetClientLogo(long OrgID, long LoginID, out Login lstLogin)
        {
            long returnCode = -1;
            lstLogin = new Login();
            List<Login> logins = new List<Login>();
            try
            {
                SqlCommand cmd = Command.pGetClientLogoCommand(OrgID, LoginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out logins);
                    }
                    if (logins.Count > 0)
                        lstLogin = logins[0];
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetUserImage in RoleDAL", ex);
            }
            return returnCode;
        }

        public long UpdateClientLogo(Login login)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pUpdateClientLogoCommand(login.OrgID, login.LoginID, login.FilePath, login.ImageSource, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateDigitalSignature", ex);
            }
            return lresult;
        }
        //-----------------------------------------//

        public long GetCheckSamplePersonMobileNo(OrgUsers e, string Mode)
        {
                  
            long lresult = -1;
            SqlCommand cmd = Command.pGetCheckSamplePersonMobileNoCommand(e.LoginID, e.MobileNumber, Mode);
            cmd.Parameters.Add("@return", SqlDbType.Int);
            cmd.Parameters["@return"].Direction = ParameterDirection.ReturnValue;

            try
            {

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    lresult = Convert.ToInt16(cmd.Parameters["@return"].Value.ToString());
                }


            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while Check login details" + cmd.CommandText, ex);
            }

            return lresult;



        }
    
    }
   
}
