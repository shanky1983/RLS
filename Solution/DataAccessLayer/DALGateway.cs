using System;
using System.Collections.Generic;
using System.Text;
using Attune.Podium.BusinessEntities;
using System.Data.SqlClient;
using System.Data;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using System.ComponentModel;
using System.Reflection;
using System.Transactions;
using System.Collections.Specialized;
namespace Attune.Solution.DAL
{
    public class DALGateway
    {
        ContextDetails globalContextDetails;
        public DALGateway()
        {

        }
        public DALGateway(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long AuthenticateUser(Login lgnCredentials, string sessionID, out Login login, out int OrgID, out string IsLocked, out string IsExpired, out string IsBlocked, out string BlockedTo)
        {
            long returnCode = -1;
            OrgID = 0;
            IsLocked = string.Empty;
            IsExpired = string.Empty;
            IsBlocked = string.Empty;
            BlockedTo = string.Empty;
            login = new Login();
            SqlCommand sqlCommand = new SqlCommand();
            List<Login> logins = new List<Login>();
            IDataReader dataReader = null;
            Guid LoginTime = new Guid();
            try
            {
                sqlCommand = Command.pGetUserCommand(lgnCredentials.LoginName, lgnCredentials.Password, "", sessionID, out OrgID, out IsLocked, out IsExpired, out IsBlocked, out BlockedTo, out LoginTime, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Shared))
                {
                    dataReader = dbEngine.ExecuteReader(sqlCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out logins);
                        dataReader.Close();
                    }
                    if (logins.Count > 0)
                        login = logins[0];
                    OrgID = Convert.ToInt32(sqlCommand.Parameters["@OrgID"].Value);
                    IsLocked = sqlCommand.Parameters["@Islocked"].Value.ToString();
                    IsExpired = sqlCommand.Parameters["@IsExpired"].Value.ToString();
                    IsBlocked = sqlCommand.Parameters["@IsBlocked"].Value.ToString();
                    BlockedTo = sqlCommand.Parameters["@BlockedTo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                CLogger.LogError("Error while loading AuthenticateUser", ex);
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



        public long GetPatientDetails(long patientID, long visitID, out List<Patient> patient)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            patient = new List<Patient>();
            SqlCommand cmdPDetails = Command.pGetPatientDemoCommand(patientID, visitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmdPDetails, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out patient);
            }
            return returnCode;
        }


        public long GetPhysicianDetails(long loginID, out List<PhysicianSchedule> physician)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            physician = new List<PhysicianSchedule>();
            SqlCommand cmdPDetails = Command.pGetPhysicianListLisCommand(loginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmdPDetails, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out physician);
            }
            return returnCode;
        }

        public long GetNurseDetails(long loginID, out List<Nurse> nurse)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            nurse = new List<Nurse>();
            SqlCommand cmdPDetails = Command.pGetNurseListCommand(loginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmdPDetails, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out nurse);
            }
            return returnCode;
        }


        public long GetRoles(Login login, out List<Role> userRoles)
        {
            long returnCode = -1;
            userRoles = new List<Role>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand sqlCommand = Command.pGetUserRolesCommand(login.LoginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    dataReader = dbEngine.ExecuteReader(sqlCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out userRoles);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetRoles DALGateway.cs", ex);
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


        public long IsUserLoggedIn(long UID, string SessionID, out List<LoggedInUsers> loggedIn)
        {
            long returnCode = -1;
            loggedIn = new List<LoggedInUsers>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand sqlCommand = Command.pIsUserLoggedInCommand(UID, SessionID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    dataReader = dbEngine.ExecuteReader(sqlCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out loggedIn);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading IsUserLoggedIn in DALGateway", ex);
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



        public long GetLoggedInRoles(LoginRole login, out List<LoginRole> userRoles)
        {
            long returncode = -1;
            userRoles = new List<LoginRole>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand sqlCommand = Command.pGetLoggedInRolesCommand(login.LoginID, login.RoleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    dataReader = dbEngine.ExecuteReader(sqlCommand);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out userRoles);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while loading GetLoggedInRoles DALGateway.cs", ex);
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


        public long GetConfigDetails(out StringDictionary objDictionary)
        {
            long returnCode = -1;
            objDictionary = new StringDictionary();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetConfigDataForAllOrgCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out objDictionary);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get config details", ex);
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


        public long GetConfigDetails(string configkey, int orgID, out List<Config> lstConfig)
        {
            long returnCode = -1;
            lstConfig = new List<Config>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetConfigDetailsCommand(configkey, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstConfig);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetConfigDetails()", ex);
            }

            return returnCode;
        }

        public long GetUserDetails(long loginID, out List<Users> lstUserDetail)
        {
            long returnCode = -1;
            lstUserDetail = new List<Users>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetUserDetailCommand(loginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstUserDetail);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading user detail", ex);
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

        public long ChangePassword(long loginID, string oldPassword, string oldTranspwd, string newPassword, string newTransPassword, DateTime pwdexpdate, DateTime transpwdexpdate)
        {
            long returncode = -1;
            SqlCommand sqlCmd = Command.pChangePasswordCommand(loginID, oldPassword, oldTranspwd, newPassword, newTransPassword, pwdexpdate, transpwdexpdate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Shared))
            {
                returncode = dbEngine.ExecuteNonQuery(sqlCmd);

            }
            return returncode;

        }

        public long GetIsReceptionCashier(string pConfigKey, int pOrgID, out string pOutStatus)
        {
            long returnCode = -1;
            pOutStatus = string.Empty;
            try
            {
                SqlCommand cmd = Command.pGetIsReceptionCashierCommand(pConfigKey, pOrgID, out pOutStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Secondary))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    pOutStatus = cmd.Parameters["@pOutStatus"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetIsReceptionCashier", ex);
            }

            return returnCode;
        }
        public long GetPatientDetail(long loginID, out List<Patient> lstPatient)
        {

            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetPatientDetailCommand(loginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading user detail", ex);
            }

            return returnCode;

        }
        public long UpdateLoginDetails(Login objlogin)
        {

            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pUpdateLoginDetailsCommand(objlogin.LoginID, objlogin.Password, objlogin.SecretAnswer, objlogin.SecretQuestion, objlogin.HasUserChangedPassword, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Shared))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while UpdateLoginDetails", ex);
            }

            return returnCode;

        }


        public long CheckIfLoggedIn(long loginID, string sessionID)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            SqlCommand cmdLDetails = Command.pCheckIfUserLoggedInCommand(loginID, sessionID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmdLDetails.Parameters.Add("@retval", SqlDbType.BigInt);
            cmdLDetails.Parameters["@retval"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
            {
                if (dbEngine.ExecuteNonQuery(cmdLDetails) == 0)
                {
                    returnCode = Convert.ToInt64(cmdLDetails.Parameters["@retval"].Value);
                }

            }
            return returnCode;
        }

        public long DeleteLoggedInUserBySessionID(string sessionID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pDeleteLoggedInUserBySessionIDCommand(sessionID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Shared))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetIsReceptionCashier", ex);
            }

            return returnCode;
        }

        public long GetInventoryConfigDetails(string configkey, int orgID, int OrgAddressID, out List<InventoryConfig> lstInventoryConfig)
        {
            long returnCode = -1;
            lstInventoryConfig = new List<InventoryConfig>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInventoryConfigDetailsCommand(configkey, orgID, OrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Secondary))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInventoryConfig);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get config details", ex);
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


        public long GetLocationUserMap(long Lid, int orgID, int OrgAddressID, out List<LocationUserMap> lstLocationUserMap)
        {
            long returnCode = -1;
            lstLocationUserMap = new List<LocationUserMap>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetLocationUserMapCommand(Lid, orgID, OrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Secondary))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLocationUserMap);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get config details", ex);
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



        public long GetBillConfigDetails(int BillGroupID, string configKey, int orgID, long OrgAddressID, out StringDictionary objDictionary)
        {
            long returnCode = -1;
            objDictionary = new StringDictionary();
            BillGroupID = 0;
            configKey = "";
            orgID = 0;
            OrgAddressID = 0;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetBillConfigDetailsCommand(configKey, orgID, OrgAddressID, BillGroupID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Secondary))
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out objDictionary);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetBillConfigDetails", ex);
            }

            return returnCode;
        }

        public long GetBillConfigDetails(int BillGroupID, string configKey, int orgID, long OrgAddressID, out List<Config> lstConfig)
        {
            long returnCode = -1;
            lstConfig = new List<Config>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBillConfigDetailsCommand(configKey, orgID, OrgAddressID, BillGroupID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Secondary))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstConfig);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetBillConfigDetails", ex);
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

        public long GetConfigKeyDetails(int Orgid, string ConfigType, out List<ConfigKeyMaster> lstConfigKeyMaster, out List<ConfigOrgMaster> lstConfigOrgMaster, out List<ConfigValueMaster> lstConfigValueMaster, out List<Locations> lstLocations)
        {
            long returnCode = -1;
            lstConfigKeyMaster = new List<ConfigKeyMaster>();
            lstConfigOrgMaster = new List<ConfigOrgMaster>();
            lstConfigValueMaster = new List<ConfigValueMaster>();
            lstLocations = new List<Locations>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetConfigKeyDetailsCommand(Orgid, ConfigType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Secondary))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstConfigKeyMaster);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstConfigValueMaster);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstConfigOrgMaster);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[3], out lstLocations);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while UpdateLoginDetails", ex);
            }

            return returnCode;

        }
        public long SaveConfigMaster(List<ConfigOrgMaster> lstConfigOrgMaster, int OrgID, long LID)
        {
            long returnCode = -1;
            try
            {
                DataTable dtConfig = UDT_DAL.ConvertToConfigValue(lstConfigOrgMaster);
                SqlCommand cmd = Command.pInsertConfigMasterCommand(OrgID, LID, dtConfig, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading SaveConfigMaster BL", ex);
            }
            return returnCode;
        }


        public long GetDischargeConfigDetails(string configkey, int orgID, out List<DischargeConfig> lstDischargeConfig)
        {
            long returnCode = -1;
            lstDischargeConfig = new List<DischargeConfig>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetDischargeConfigDetailsCommand(configkey, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDischargeConfig);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get GetDischargeConfigDetails details", ex);
            }

            return returnCode;
        }





        public long GetLoginAttemptFailureDetail(string LoginName, out string LogInAttempt, out string OrgHit)
        {
            LogInAttempt = string.Empty;
            OrgHit = string.Empty;
            long returnCode = -1;
            IDataReader reader = null;
            try
            {
                using (DBEngine dBEngine = new DBEngine(SqlConnectionKey.Shared))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd = Command.pGetLoginAttemptFailureDetailCommand(LoginName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                    reader = dBEngine.ExecuteReader(cmd);
                    if (reader != null)
                    {
                        if (reader.Read())
                        {
                            LogInAttempt = Convert.ToString(reader[0]);
                            OrgHit = Convert.ToString(reader[1]);
                        }
                        reader.Close();

                        returnCode = 0;
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetLoginAttemptFailureDetail DALGateway", e);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return returnCode;
        }




        public long GetAllDischargeConfig(int pOrgID, out string DisChargeConfig, out List<DischargeConfig> lstAllDischargeConfig)
        {
            long returnCode = -1;
            DisChargeConfig = string.Empty;
            lstAllDischargeConfig = new List<DischargeConfig>();
            try
            {
                SqlCommand cmd = Command.pGetAllDischargeConfigCommand(pOrgID, out DisChargeConfig, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    DisChargeConfig = cmd.Parameters["@pOutStatus"].Value.ToString();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAllDischargeConfig);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetIsReceptionCashier", ex);
            }

            return returnCode;
        }
        public long InsertLoggedInProfile(LoggedInProfile objLoggedInProfile)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pInsertLoggedInProfileCommand(objLoggedInProfile.LoginID, objLoggedInProfile.OrgID, objLoggedInProfile.OrgAddressID, objLoggedInProfile.IPAddress, "", "", "", 0, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Secondary))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in InsertLoggedInProfile", ex);
            }

            return returnCode;
        }
        public long GetOrgDetails(int OrgID, out List<TrustedOrgDetails> lstTrustedOrgDetails)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            lstTrustedOrgDetails = new List<TrustedOrgDetails>();
            try
            {
                SqlCommand cmd = Command.pGetOrgDetailsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Secondary))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTrustedOrgDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetOrgDetails", ex);
            }
            return returnCode;
        }

        public long GetCurrencyDetails(int OrgID, out List<CurrencyDetails> lstCurrencyDetails)
        {
            long returnCode = -1;
            lstCurrencyDetails = new List<CurrencyDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetCurrencyDetailsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Secondary))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCurrencyDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetCurrencyDetails", ex);
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

        public long UpdateLoggedInUser(string SessionID, long LID, long RoleID, long DeptID, long OrgID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pUpdateLoggedInUserCommand(SessionID, LID, RoleID, DeptID, LID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Shared))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in UpdateLoggedInUser", ex);
            }

            return returnCode;
        }

        public long UpdateLoginfailureAttempt(String LoginName)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pUpdateloginAttemptCommand(LoginName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Shared))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in UpdateLoginFailureAttempt", ex);
            }

            return returnCode;
        }

        public long GetCommunicationDetails(string Type, long VisitID, string OrgLocation, out List<CommunicationDetails> lstCommunicationDetails)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            lstCommunicationDetails = new List<CommunicationDetails>();
            try
            {
                SqlCommand cmd = Command.pGetCommunicationDetailsCommand(Type, VisitID, OrgLocation, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Secondary))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCommunicationDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetCommunicationDetails", ex);
            }
            return returnCode;
        }

        public long GetBarcodeAttributeNValues(Int32 OrgId, String lstPatientVisitId, String lstSampleId, Int64 BillId, String CategoryCode, out List<BarcodeAttributes> lstBarcodeAttributes, out List<BarcodePattern> lstBarcodePattern)
        {
            long returnCode = -1;
            int rsCount = 0;
            lstBarcodeAttributes = new List<BarcodeAttributes>();
            lstBarcodePattern = new List<BarcodePattern>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBarcodeAttributeNValuesCommand(OrgId, lstPatientVisitId, lstSampleId, BillId, CategoryCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstBarcodeAttributes);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstBarcodePattern);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetBarcodeAttributeNValues", ex);
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


        public long GetActioncodeforSplAuthorize(int Roleid, string Actioncode, string SearchTypeID, out string IsSplAuthorize)
        {

            long returnCode = -1;
            SqlCommand objCommand = Command.pGetActioncodeforSplAuthorizeCommand(Roleid, Actioncode, SearchTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            IsSplAuthorize = "";
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }

                if (ds.Tables.Count > 0)
                {
                    IsSplAuthorize = ds.Tables[0].Rows[0]["isSplAuthorize"].ToString();

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetisSplAuthorizeValues", ex);
            }
            return returnCode;

        }
        public long CheckTransactionPassword(long LID, string Transapaswd, out string TPWD)
        {

            long returnCode = -1;
            SqlCommand objCommand = Command.pCheckTransactionPasswordCommand(LID, Transapaswd, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            TPWD = "";
            try
            {
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Shared))
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }

                if (ds.Tables.Count > 0)
                {
                    TPWD = ds.Tables[0].Rows[0]["Transactionpasssword"].ToString();

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetTransactionpasssword", ex);
            }
            return returnCode;

        }
        // changed dataset to datareader by thiyagu
        public long GetPageDetails(string PageURL,out List<PageRoleMapping> objDictionary)
        {
            long returnCode = -1;
            objDictionary = null;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPageListCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails),PageURL);
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out objDictionary);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting page details", ex);
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

        public long CheckSecurityToken(String pSessionID, out Int32 pReturnStatus)
        {
            long returnCode = -1;
            pReturnStatus = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pCheckSecurityTokenCommand(pSessionID, out pReturnStatus,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Shared))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        dataReader.Close();
                        Int32.TryParse(cmd.Parameters["@pReturnStatus"].Value.ToString(), out pReturnStatus);
                    }
                }
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error In DAL CheckSecurityToken", ex);
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



        public long GetLabelPrintDetails(Int32 OrgId, Int64 PatientVisitId, String CategoryCode, String uid, out List<BarcodeAttributes> lstBarcodeAttributes, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            lstPatientDetails = new List<Patient>();
            lstBarcodeAttributes = new List<BarcodeAttributes>();
            try
            {
                SqlCommand cmd = Command.pGetLabelPrintAttributeCommand(OrgId, PatientVisitId, CategoryCode, uid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBarcodeAttributes);
                    }

                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetLabelPrintValues", ex);
            }
            return returnCode;
        }

        public long GetBarcodePrintJobDetails(Int32 OrgId, Int64 OrgAddressId, String MachineID, out List<BarcodeAttributes> lstBarcodeAttributes)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            lstBarcodeAttributes = new List<BarcodeAttributes>();
            try
            {
                SqlCommand cmd = Command.pGetBarcodePrintJobDetailsCommand(OrgId, OrgAddressId, MachineID);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBarcodeAttributes);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetBarcodePrintJobDetails", ex);
            }
            return returnCode;
        }
        public long SaveBarcodePrintDetails(List<PrintBarcode> lstPrintBarocde, out int returnStatus)
        {
            long returnCode = -1;
            returnStatus = -1;
            DataTable printBarocde = UDT_DAL.ConvertToBarcodePrintDetails(lstPrintBarocde);
            try
            {
                SqlCommand cmd = Command.pInsertBarcodePrintJobCommand(printBarocde, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out returnStatus);
                using (DBEngine dbengine = new DBEngine())
                {
                    returnCode = dbengine.ExecuteNonQuery(cmd);
                    returnStatus = Convert.ToInt32(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SaveBarcodePrintDetails", ex);
            }
            return returnCode;
        }
        public long UpdateBarcodePrintStatusDetails(Int32 OrgID, Int64 OrgAddressID, String MachineID, List<BarcodeAttributes> lstBarcodeAttributes, out int returnStatus)
        {
            long returnCode = -1;
            returnStatus = -1;
            DataTable printBarocde = UDT_DAL.ConvertToBarcodePrintAttributesDetails(lstBarcodeAttributes);
            try
            {
                SqlCommand cmd = Command.pUpdateBarcodePrintJobStatusCommand(printBarocde, OrgID, OrgAddressID, MachineID, out returnStatus);
                using (DBEngine dbengine = new DBEngine())
                {
                    returnCode = dbengine.ExecuteNonQuery(cmd);
                    returnStatus = Convert.ToInt32(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in UpdateBarcodePrintDetails", ex);
            }
            return returnCode;
        }
        public long GetClientDetails(long loginID, out List<ClientMaster> clientMaster)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            clientMaster = new List<ClientMaster>();
            try
            {
                SqlCommand cmdPDetails = Command.pGetClientDetailsListCommand(loginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmdPDetails, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out clientMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetClientDetails in DalGateWay_DAL", ex);
            }
            return returnCode;
        }

        public long UpdateBarcodePrintStatus(string ID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateBarcodePrintJobCommand(ID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    returnCode = dbengine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in UpdateBarcodePrintStatus", ex);
            }
            return returnCode;
        }
        public long GetBarcodeDetails(String BatchNo, out List<BarcodeAttributes> lstBarcodeAttributes)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            lstBarcodeAttributes = new List<BarcodeAttributes>();
            try
            {
                SqlCommand cmd = Command.pBulkBarcodePrintCommand(Convert.ToInt32(BatchNo));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBarcodeAttributes);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetBarcodeDetails", ex);
            }
            return returnCode;
        }
		     public long SaveOTPDetails(string Loginname, string OTP, string OTPMode, string OTPModevalue, string btnName, out string returnStatus, out long LID, out long OrgID, out string Value,
                  out string Template, out string Subject)
                {
                    long returnCode = -1;
                    returnStatus = String.Empty;
                    LID = 0;
                    OrgID = 0; Value = string.Empty; Subject = string.Empty; Template = string.Empty;

                    try
                    {
                        SqlCommand cmd = Command.pSaveOTPDetailsCommand(Loginname, OTP, OTPMode, OTPModevalue, btnName, out returnStatus, out LID, out OrgID, out Value, out Template, out Subject);
                        using (DBEngine dbengine = new DBEngine())
                        {
                            returnCode = dbengine.ExecuteNonQuery(cmd);
                            OrgID = Convert.ToInt64(cmd.Parameters["@OrgID"].Value);
                            LID = Convert.ToInt64(cmd.Parameters["@LID"].Value);
                            returnStatus = cmd.Parameters["@Status"].Value.ToString();
                            Subject = cmd.Parameters["@Subject"].Value.ToString();
                            Template = cmd.Parameters["@Template"].Value.ToString();
                            Value = cmd.Parameters["@Value"].Value.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        CLogger.LogError("Error in SaveOTPDetails", ex);
                    }
                    return returnCode;
                }
                public long UpdatePassword(long loginID, string OTP, string newPassword, DateTime pwdexpdate, out string Status)
                {
                    long returncode = -1;
                    Status = string.Empty;
                    try
                    {
                        SqlCommand sqlCmd = Command.pUpdatePasswordCommand(loginID, OTP, newPassword, pwdexpdate, out Status);
                        DataSet ds = new DataSet();
                        using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Shared))
                        {
                            returncode = dbEngine.ExecuteNonQuery(sqlCmd);
                            Status = sqlCmd.Parameters["@Status"].Value.ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        CLogger.LogError("Error in SaveOTPDetails", ex);
                    }
                    return returncode;

                }		
        public long UpdateExistingBarcode(long VisitID, string OldBarcodeNumber, string NewBarcodeNumber)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pUpdateExistingBarcodeCommand(VisitID, OldBarcodeNumber, NewBarcodeNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in pUpdateExistingBarcode", ex);
            }

            return returnCode;
        }
        #region HL7 integration
        public long GetLoginDetails(string LoginName, string RoleName, out  List<Login> objLogin)
        {
            objLogin = new List<Login>();
            long returnCode = -1;
            SqlCommand cmd = Command.pGetLoginDetailslistCommand(LoginName, RoleName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out objLogin);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetLoginDetails patient BL ", ex);
            }
            return returnCode;
        }
        #endregion
		
		public long GetOrganizationDBMapping(int pOrgID, out List<OrganizationDBMapping> lstDBMapping)
        {
            long returnCode = -1;
            lstDBMapping = null;
            SqlCommand cmd = Command.pGetOrganizationDBMappingCommand(pOrgID);
            DataSet ds = null;
            using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables != null && ds.Tables.Count > 0  && ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDBMapping);
            }
            return returnCode;
        }

    }
}
