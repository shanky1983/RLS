using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using Attune.Solution.DAL;
using System.Web;
using System.Collections.Specialized;
using System.Web.Caching;
using System.Configuration;
using System.IO;
using System.Xml;
using Attune.Kernel.CacheEngine;
namespace Attune.Solution.BusinessComponent
{
    public class GateWay
    {
        ContextDetails globalContextDetails;
        public GateWay()
        {

        }
        public GateWay(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetLandingPage(long roleID, out string relPathPage)
        {
            long returnCode = 0;
            relPathPage = string.Empty;
            List<PageRoleMapping> lstPageMapping = null;
            try
            {
                Utilities objUtilities = new Utilities();
                string KeyValue = string.Empty;
                objUtilities.GetApplicationValue("LandingPageCache", out KeyValue);
                if (!string.IsNullOrEmpty(KeyValue) && KeyValue == "Y")
                {
                    CacheProvider _cp = new CacheProvider(0);
                    string pkey = _cp.getKey(AttCacheKey.LandingPageCache, 0);
                    if (_cp.IsInCache(pkey))
                    {
                        lstPageMapping = _cp.Get<List<PageRoleMapping>>(pkey);
                    }
                    else
                    {
                        NavigationDAL navigationDAL = new NavigationDAL();
                        returnCode = navigationDAL.GetLandingPage(0, out lstPageMapping);

                        if (lstPageMapping != null && lstPageMapping.Count > 0)
                        {
                            _cp.Set(pkey, lstPageMapping);
                        }
                    }

                    if (lstPageMapping.Exists(p => p.RoleID == roleID))
                    {
                        relPathPage = lstPageMapping.Find(p => p.RoleID == roleID).PageURL;
                    }

                    if (string.IsNullOrEmpty(relPathPage))
                    {
                        _cp.Remove(pkey);
                        NavigationDAL navigationDAL = new NavigationDAL();
                        returnCode = navigationDAL.GetLandingPage(0, out lstPageMapping);

                        if (lstPageMapping != null && lstPageMapping.Count > 0)
                        {
                            _cp.Set(pkey, lstPageMapping);
                        }
                        if (lstPageMapping.Exists(p => p.RoleID == roleID))
                        {
                            relPathPage = lstPageMapping.Find(p => p.RoleID == roleID).PageURL;
                        }
                    }
                }
                else
                {
                    NavigationDAL navigationDAL = new NavigationDAL();
                    returnCode = navigationDAL.GetLandingPage(roleID, out lstPageMapping);
                    if (lstPageMapping != null && lstPageMapping.Count > 0)
                    {
                        relPathPage = lstPageMapping.Find(p => p.RoleID == roleID).PageURL;
                    }

                }


            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing landing page In gateway", excp);
            }



              
            return returnCode;
        }

       public long AuthenticateUser(Login lgnCredentials, string sessionID, out Login login, out int OrgID, out string IsLocked, out string IsExpired, out string IsBlocked, out string BlockedTo)
        {
            long returnCode = -1;
            OrgID = -1;
            IsLocked = null;
            IsBlocked = null;
            IsExpired = null;
            BlockedTo = null;
            login = null;

            try
            {
                login = new Login();
                if ((Helper.IsNullorEmpty(lgnCredentials.LoginName) == false) && (Helper.IsNullorEmpty(lgnCredentials.Password) == false))
                {
                    DALGateway dalGateWay = new DALGateway(globalContextDetails);
                    Users usr = new Users();
                    returnCode = dalGateWay.AuthenticateUser(lgnCredentials, sessionID, out login, out OrgID, out IsLocked, out IsExpired, out IsBlocked, out BlockedTo);
                }
                else
                {
                    returnCode = 100;
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing AutheticateUser", excp);
            }

            return returnCode;
        }

        public long GetRoles(Login login, out List<Role> loginRoles)
        {
            long returnCode = -1;
            loginRoles = null;

            try
            {

                DALGateway dalGateWay = new DALGateway(globalContextDetails);
                returnCode = dalGateWay.GetRoles(login, out loginRoles);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetRoles", excp);
            }
            return returnCode;
        }

        public long GetPatientDetails(long patientID, out Patient patient)
        {
            long returnCode = -1;
            patient = new Patient();

            try
            {
                DALGateway dalGateway = new DALGateway(globalContextDetails);
                List<Patient> patients = new List<Patient>();
                returnCode = dalGateway.GetPatientDetails(patientID, 0, out patients);
                if (patients.Count > 0)
                {
                    patient = patients[0];
                    returnCode = 0;
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPatientDetails BL", excp);
            }

            return returnCode;
        }

        public long GetPhysicianDetails(long loginID, out PhysicianSchedule physician)
        {
            long returnCode = -1;
            physician = new PhysicianSchedule();
            try
            {
                DALGateway dalGateway = new DALGateway(globalContextDetails);

                List<PhysicianSchedule> physicians = new List<PhysicianSchedule>();
                returnCode = dalGateway.GetPhysicianDetails(loginID, out physicians);
                if (physicians.Count > 0)
                {
                    physician = physicians[0];
                    returnCode = 0;
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPhysicianDetails BL", excp);
            }

            return returnCode;
        }

        public long GetNurseDetails(long loginID, out Nurse nurse)
        {
            long returnCode = -1;
            nurse = new Nurse();
            try
            {
                DALGateway dalGateway = new DALGateway(globalContextDetails);

                List<Nurse> nurses = new List<Nurse>();
                returnCode = dalGateway.GetNurseDetails(loginID, out nurses);
                if (nurses.Count > 0)
                {
                    nurse = nurses[0];
                    returnCode = 0;
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetNurseDetails BL", excp);
            }
            return returnCode;
        }



        public long IsUserLoggedIn(long UID, string SessionID, out bool IsLoggedIn)
        {
            long returnCode = -1;
            IsLoggedIn = false;
            try
            {
                DALGateway dalGateway = new DALGateway(globalContextDetails);

                List<LoggedInUsers> loggedInUsers = new List<LoggedInUsers>();
                returnCode = dalGateway.IsUserLoggedIn(UID, SessionID, out loggedInUsers);
                if (loggedInUsers.Count > 0)
                {
                    IsLoggedIn = true;
                    returnCode = 0;
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetNurseDetails BL", excp);
            }
            return returnCode;
        }


        public long GetLoggedInRoles(LoginRole loginRole, out List<LoginRole> lstloggedroles)
        {
            long returncode = -1;
            lstloggedroles = null;
            try
            {
                DALGateway dalGateway = new DALGateway(globalContextDetails);
                returncode = dalGateway.GetLoggedInRoles(loginRole, out lstloggedroles);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while load GetLoggedInRoles", ex);
            }
            return returncode;
        }

        public long GetConfigDetails(string configkey, int orgID, out List<Config> lstConfig)
        {
            long returnCode = -1;
            lstConfig = new List<Config>();
            List<Config> templstConfig = null;
            string configValue = string.Empty;
            try
            {

                Utilities objUtilities = new Utilities();
                string KeyValue = string.Empty;
                objUtilities.GetApplicationValue("ConfigCache", out KeyValue);
                if (!string.IsNullOrEmpty(KeyValue) && KeyValue == "Y")
                {
                    CacheProvider _cp = new CacheProvider(1);
                    string pkey = _cp.getKey(AttCacheKey.ConfigCache, orgID);
                    if (_cp.IsInCache(pkey))
                    {
                        templstConfig = _cp.Get<List<Config>>(pkey);
                    }
                    else
                    {
                        returnCode = new DALGateway(globalContextDetails).GetConfigDetails("", orgID, out templstConfig);
                        if (templstConfig != null && templstConfig.Count > 0)
                        {
                            _cp.Set(pkey, templstConfig);
                        }
                    }
                    if (templstConfig != null && templstConfig.Count > 0)
                    {
                        lstConfig= templstConfig.FindAll(p => p.ConfigKey == configkey);
					    returnCode = 0;
                    }

                    if (lstConfig == null || lstConfig.Count == 0)
                    {
                        _cp.Remove(pkey);
                        returnCode = new DALGateway(globalContextDetails).GetConfigDetails("", orgID, out templstConfig);
                        if (templstConfig != null && templstConfig.Count > 0)
                        {
                            _cp.Set(pkey, templstConfig);
                        }
                        if (templstConfig != null && templstConfig.Count > 0)
                        {
                            lstConfig = templstConfig.FindAll(p => p.ConfigKey == configkey);
                            returnCode = 0;
                        }
                    }
                }
                else
                {
                    returnCode = new DALGateway(globalContextDetails).GetConfigDetails(configkey, orgID, out lstConfig);
					 

                }

                 
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetConfigDetails BL", ex);
            }
            return returnCode;
        }

        public long GetUserDetail(long loginID, out List<Users> lstUsers)
        {
            long returnCode = -1;
            lstUsers = new List<Users>();
            try
            {
                returnCode = new DALGateway(globalContextDetails).GetUserDetails(loginID, out lstUsers);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetUserDetail BL", ex);
            }
            return returnCode;
        }

        public long ChangePassword(long loginID, string oldPassword, string oldTransPwd, string newPassword, string newTransPassword, DateTime pwdexpdate, DateTime transpwdexpdate)
        {
            long returnCode = -1;
            try
            {
                returnCode = new DALGateway(globalContextDetails).ChangePassword(loginID, oldPassword, oldTransPwd, newPassword, newTransPassword, pwdexpdate, transpwdexpdate);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while lading ChangePassword BL", ex);
            }
            return returnCode;
        }

        public long GetIsReceptionCashier(string pConfigKey, int pOrgID, out string pOutStatus)
        {
            long returnCode = -1;
            pOutStatus = string.Empty;

            try
            {
                returnCode = new DALGateway(globalContextDetails).GetIsReceptionCashier(pConfigKey, pOrgID, out pOutStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetIsReceptionCashier", ex);
            }

            return returnCode;
        }


        public long GetPatientDetail(long loginID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                returnCode = new DALGateway(globalContextDetails).GetPatientDetail(loginID, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetPatientDetail BL", ex);
            }
            return returnCode;
        }

        public long UpdateLoginDetails(Login objlogin)
        {
            long returnCode = -1;
            try
            {
                returnCode = new DALGateway(globalContextDetails).UpdateLoginDetails(objlogin);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while UpdateLoginDetails BL", ex);
            }
            return returnCode;
        }

        public long CheckIfLoggedIn(long loginID, string sessionID)
        {
            long returnCode = -1;
            try
            {
                DALGateway dalGateWay = new DALGateway(globalContextDetails);
                returnCode = dalGateWay.CheckIfLoggedIn(loginID, sessionID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing CheckIfLoggedIn", excp);
            }
            return returnCode;
        }

        public long DeleteLoggedInUserBySessionID(string sessionID)
        {
            long returnCode = -1;

            try
            {
                returnCode = new DALGateway(globalContextDetails).DeleteLoggedInUserBySessionID(sessionID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetIsReceptionCashier", ex);
            }

            return returnCode;
        }


        public long GetInventoryConfigDetails(string configkey, int orgID, int OrgAddressID, out List<InventoryConfig> lstInventoryConfig)
        {
            long returnCode = -1;
            lstInventoryConfig = new List<InventoryConfig>();
            try
            {
                returnCode = new DALGateway(globalContextDetails).GetInventoryConfigDetails(configkey, orgID, OrgAddressID, out lstInventoryConfig);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetConfigDetails BL", ex);
            }
            return returnCode;
        }

        public long GetLocationUserMap(long Lid, int orgID, int OrgAddressID, out List<LocationUserMap> lstLocationUserMap)
        {
            long returnCode = -1;
            lstLocationUserMap = new List<LocationUserMap>();
            try
            {
                returnCode = new DALGateway(globalContextDetails).GetLocationUserMap(Lid, orgID, OrgAddressID, out lstLocationUserMap);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetLocationUserMap BL", ex);
            }
            return returnCode;
        }

        public long GetBillConfigDetails(int BillGroupID, string configKey, int orgID, long OrgAddressID, out List<Config> lstConfig)
        {
            long returnCode = -1;
            lstConfig = new List<Config>();
            Config objConfig = new Config();
            StringDictionary objDictionary = new StringDictionary();
            string billConfigValue = string.Empty;
            try
            {
                //----
                Utilities objUtilities = new Utilities();
                string KeyValue = string.Empty;
                objUtilities.GetApplicationValue("BillCache", out KeyValue);
                //----               

                if (KeyValue.ToUpper() == "Y" && KeyValue != null)
                {
                    if (HttpContext.Current.Cache["BillConfigData"] != null)
                    {
                        objDictionary = (StringDictionary)HttpContext.Current.Cache["BillConfigData"];
                    }
                    else
                    {
                        returnCode = new DALGateway(globalContextDetails).GetBillConfigDetails(BillGroupID, configKey, orgID, OrgAddressID, out objDictionary);
                        string filename = HttpContext.Current.Request.PhysicalApplicationPath + "App_Data\\BillConfigCacheFile.Txt";
                        if (!File.Exists(filename))
                        {
                            StreamWriter writer = File.CreateText(filename);
                            writer.WriteLine(".LOG");
                            writer.Close();
                        }
                        HttpContext.Current.Cache.Insert("BillConfigData", objDictionary, new CacheDependency(filename));
                    }
                    if (objDictionary != null)
                    {
                        string sKey = BillGroupID.ToString() + '_';
                        sKey += orgID.ToString() + '_';
                        sKey += OrgAddressID.ToString() + '_';
                        sKey += configKey;
                        billConfigValue = objDictionary[sKey];
                        if (billConfigValue != null && billConfigValue != string.Empty)
                        {
                            objConfig.ConfigValue = billConfigValue;
                            lstConfig.Add(objConfig);
                        }
                    }
                }
                else
                {
                    returnCode = new DALGateway(globalContextDetails).GetBillConfigDetails(BillGroupID, configKey, orgID, OrgAddressID, out lstConfig);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetBillConfigDetails BL", ex);
            }
            return returnCode;
        }
        public long GetConfigKeyDetails(int Orgid, string ConfigType, out List<ConfigKeyMaster> lstConfigKeyMaster, out List<ConfigOrgMaster> lstConfigOrgMaster, out  List<ConfigValueMaster> lstConfigValueMaster, out List<Locations> lstLocations)
        {
            long returnCode = -1;
            lstConfigKeyMaster = new List<ConfigKeyMaster>();
            lstConfigOrgMaster = new List<ConfigOrgMaster>();
            lstConfigValueMaster = new List<ConfigValueMaster>();
            lstLocations = new List<Locations>();
            try
            {
                returnCode = new DALGateway(globalContextDetails).GetConfigKeyDetails(Orgid, ConfigType, out lstConfigKeyMaster, out lstConfigOrgMaster, out lstConfigValueMaster, out lstLocations);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetConfigKeyDetails BL", ex);
            }
            return returnCode;
        }
        public long SaveConfigMaster(List<ConfigOrgMaster> lstConfigOrgMaster, int OrgID, long LID)
        {
            long returnCode = -1;
            string fileName = string.Empty;
            try
            {
                returnCode = new DALGateway(globalContextDetails).SaveConfigMaster(lstConfigOrgMaster, OrgID, LID);
                if (returnCode != -1)
                {
                    CacheProvider _cp = new CacheProvider(1);
                    string pkey = _cp.getKey(AttCacheKey.PageCache, 0);
                    if (_cp.IsInCache(pkey))
                    {
                        _cp.Remove(pkey);
                    }
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
                returnCode = new DALGateway(globalContextDetails).GetDischargeConfigDetails(configkey, orgID, out lstDischargeConfig);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetDischargeConfigDetails BL", ex);
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
                returnCode = new DALGateway(globalContextDetails).GetAllDischargeConfig(pOrgID, out DisChargeConfig, out lstAllDischargeConfig);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetIsReceptionCashier", ex);
            }

            return returnCode;
        }
        public long InsertLoggedInProfile(LoggedInProfile objLoggedInProfile)
        {
            long returnCode = -1;

            try
            {
                returnCode = new DALGateway(globalContextDetails).InsertLoggedInProfile(objLoggedInProfile);
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
            lstTrustedOrgDetails = new List<TrustedOrgDetails>();
            try
            {
                new DALGateway(globalContextDetails).GetOrgDetails(OrgID, out lstTrustedOrgDetails);
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
            try
            {
                new DALGateway(globalContextDetails).GetCurrencyDetails(OrgID, out lstCurrencyDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetCurrencyDetails", ex);
            }
            return returnCode;
        }
        public long UpdateLoggedInUser(string SessionID, long LID, long RoleID, long DeptID, long OrgID)
        {
            long returnCode = -1;

            try
            {
                returnCode = new DALGateway(globalContextDetails).UpdateLoggedInUser(SessionID, LID, RoleID, DeptID, OrgID);
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
                returnCode = new DALGateway(globalContextDetails).UpdateLoginfailureAttempt(LoginName);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in UpdateLoggedInUser", ex);
            }

            return returnCode;
        }
        public long GetLoginAttemptFailureDetail(string LoginName, out string LogInAttempt, out string OrgHit)
        {
            long returnCode = -1;
            LogInAttempt = string.Empty;
            OrgHit = string.Empty;
            try
            {
                DALGateway objGatway = new DALGateway(globalContextDetails);
                returnCode = objGatway.GetLoginAttemptFailureDetail(LoginName, out LogInAttempt, out OrgHit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading LoginAttemptFailureDetail BL", ex);
            }
            return returnCode;
        }

        public long GetCommunicationDetails(string Type, long VisitID, string OrgLocation, out List<CommunicationDetails> lstCommunicationDetails)
        {
            long returnCode = -1;
            lstCommunicationDetails = new List<CommunicationDetails>();
            try
            {
                DALGateway objGatway = new DALGateway(globalContextDetails);
                returnCode = objGatway.GetCommunicationDetails(Type, VisitID, OrgLocation, out lstCommunicationDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetCommunicationDetails", ex);
            }
            return returnCode;
        }

        public long GetBarcodeAttributeNValues(Int32 OrgID, String lstPatientVisitID, String lstSampleId, Int64 BillId, String CategoryCode, out List<BarcodeAttributes> lstBarcodeAttributes, out List<BarcodePattern> lstBarcodePattern)
        {
            long returnCode = -1;
            lstBarcodeAttributes = new List<BarcodeAttributes>();
            lstBarcodePattern = new List<BarcodePattern>();
            try
            {
                DALGateway objGatway = new DALGateway(globalContextDetails);
                returnCode = objGatway.GetBarcodeAttributeNValues(OrgID, lstPatientVisitID, lstSampleId, BillId, CategoryCode, out lstBarcodeAttributes, out lstBarcodePattern);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetBarcodeAttributeNValues", ex);
            }
            return returnCode;
        }

        public long GetActioncodeforSplAuthorise(int Roleid, string Actioncode, string SearchTypeID, out string IsSplAuthorize)
        {

            long returnCode = -1;
            IsSplAuthorize = "";

            try
            {
                DALGateway objDAL = new DALGateway(globalContextDetails);
                returnCode = objDAL.GetActioncodeforSplAuthorize(Roleid, Actioncode, SearchTypeID, out IsSplAuthorize);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while Get isSplAuthorizeValues", excp);
            }
            return returnCode;
        }
        public long CheckTransPassword(long LID, string Transapaswd, out string TPWD)
        {

            long returnCode = -1;
            TPWD = "";

            try
            {
                DALGateway objDAL = new DALGateway(globalContextDetails);
                returnCode = objDAL.CheckTransactionPassword(LID, Transapaswd, out TPWD);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while Get isSplAuthorizeValues", excp);
            }
            return returnCode;
        }
        public long GetPageDetails(string PageURL, out Int64 PageID)
        {
            long returnCode = -1;
            PageID = 0;
            List<PageRoleMapping> oPage=null;
            try
            {


                Utilities objUtilities = new Utilities();
                string KeyValue = string.Empty;
                objUtilities.GetApplicationValue("PageCache", out KeyValue);
                if (!string.IsNullOrEmpty(KeyValue) && KeyValue == "Y")
                {

                    CacheProvider _cp = new CacheProvider(0);
                    string pkey = _cp.getKey(AttCacheKey.PageCache, 0);
                    if (_cp.IsInCache(pkey))
                    {
                        oPage = _cp.Get<List<PageRoleMapping>>(pkey);
                    }
                    else
                    {
                        returnCode = new DALGateway(globalContextDetails).GetPageDetails("",out oPage);
                        if (oPage != null && oPage.Count > 0)
                        {
                            _cp.Set(pkey, oPage);
                        }
                    }

                    if (oPage.Exists(p => p.PageURL == PageURL))
                    {
                        PageID = oPage.Find(p => p.PageURL == PageURL).PageID;
                        returnCode = 0;
                    }

                    if (PageID <= 0)
                    {
                        _cp.Remove(pkey);
                        returnCode = new DALGateway(globalContextDetails).GetPageDetails("", out oPage);
                        if (oPage != null && oPage.Count > 0)
                        {
                            _cp.Set(pkey, oPage);
                        }
                        if (oPage.Exists(p => p.PageURL == PageURL))
                        {
                            PageID = oPage.Find(p => p.PageURL == PageURL).PageID;
                            returnCode = 0;
                        }
                    }
                }
                else
                {
                    returnCode = new DALGateway(globalContextDetails).GetPageDetails(PageURL,out oPage);
                    if (oPage != null && oPage.Count > 0)
                    {
                        PageID = oPage.Find(p => p.PageURL == PageURL).PageID;

                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting page details", ex);
            }
            return returnCode;
        }
        public long CheckSecurityToken(String SessionID, out Int32 ReturnStatus)
        {
            long returnCode = -1;
            ReturnStatus = 0;
            try
            {
                returnCode = new DALGateway(globalContextDetails).CheckSecurityToken(SessionID, out ReturnStatus);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error In BL CheckSecurityToken", ex);
            }
            return returnCode;
        }

        public long GetLabelPrintDetails(Int32 OrgID, Int64 PatientVisitID, String CategoryCode, String UID, out List<BarcodeAttributes> lstBarcodeAttributes, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            lstBarcodeAttributes = new List<BarcodeAttributes>();
            try
            {
                DALGateway objGatway = new DALGateway(globalContextDetails);
                returnCode = objGatway.GetLabelPrintDetails(OrgID, PatientVisitID, CategoryCode, UID, out lstBarcodeAttributes, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetLabelPrintDetail", ex);
            }
            return returnCode;
        }

        public long GetBarcodePrintJobDetails(Int32 OrgId, Int64 OrgAddressId, String MachineID, out List<BarcodeAttributes> lstBarcodeAttributes)
        {
            long returnCode = -1;
            lstBarcodeAttributes = new List<BarcodeAttributes>();
            try
            {
                DALGateway objGatway = new DALGateway(globalContextDetails);
                returnCode = objGatway.GetBarcodePrintJobDetails(OrgId, OrgAddressId, MachineID, out lstBarcodeAttributes);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetBarcodePrintJobDetails", ex);
            }
            return returnCode;
        }

        public long GetBarcodeDetails(String BatchNo, out List<BarcodeAttributes> lstBarcodeAttributes)
        {
            long returnCode = -1;
            lstBarcodeAttributes = new List<BarcodeAttributes>();
            try
            {
                DALGateway objGatway = new DALGateway(globalContextDetails);
                returnCode = objGatway.GetBarcodeDetails(BatchNo, out lstBarcodeAttributes);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetBarcodeDetails", ex);
            }
            return returnCode;
        }

        public long UpdateBarcodePrintStatus(string ID)
        {
            long returnCode = -1;
            try
            {
                DALGateway objGatway = new DALGateway(globalContextDetails);
                returnCode = objGatway.UpdateBarcodePrintStatus(ID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in UpdateBarcodePrintStatusDetails", ex);
            }
            return returnCode;
        }

        public long SaveBarcodePrintDetails(List<PrintBarcode> lstPrintBarocde, out int returnStatus)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {
                DALGateway objGatway = new DALGateway(globalContextDetails);
                returnCode = objGatway.SaveBarcodePrintDetails(lstPrintBarocde, out returnStatus);
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
            try
            {
                DALGateway objGatway = new DALGateway(globalContextDetails);
                returnCode = objGatway.UpdateBarcodePrintStatusDetails(OrgID, OrgAddressID, MachineID, lstBarcodeAttributes, out returnStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in UpdateBarcodePrintStatusDetails", ex);
            }
            return returnCode;
        }
        public long GetClientDetails(long loginID, out ClientMaster clientMaster)
        {
            long returnCode = -1;
            clientMaster = new ClientMaster();
            try
            {
                DALGateway dalGateway = new DALGateway(globalContextDetails);

                List<ClientMaster> lstClientMaster = new List<ClientMaster>();
                returnCode = dalGateway.GetClientDetails(loginID, out lstClientMaster);
                if (lstClientMaster.Count > 0)
                {
                    clientMaster = lstClientMaster[0];
                    returnCode = 0;
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetClientDetails BL", excp);
            }
            return returnCode;
        }
		 public long UpdatePassword(long loginID, string OTP, string newPassword, DateTime pwdexpdate, out string Status)
        {
            long returnCode = -1;
            Status = string.Empty;
            try
            {
                returnCode = new DALGateway().UpdatePassword(loginID, OTP, newPassword, pwdexpdate, out Status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while lading ChangePassword BL", ex);
            }
            return returnCode;
        }
        public long SaveOTPDetails(string Loginname, string OTP, string OTPMode, string OTPModevalue, string btnName, out string returnStatus, out long LID, out long OrgID, out string Value,
          out string Template, out string Subject)
        {
            long returnCode = -1;
            returnStatus = string.Empty;
            LID = 0;
            OrgID = 0;
            Value = string.Empty; Subject = string.Empty; Template = string.Empty;

            try
            {
                DALGateway dalGateway = new DALGateway(globalContextDetails);
                returnCode = dalGateway.SaveOTPDetails(Loginname, OTP, OTPMode, OTPModevalue, btnName, out returnStatus, out LID, out OrgID, out Value, out Template, out Subject);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SaveOTPDetails", ex);
            }
            return returnCode;
        }
        public long UpdateExistingBarcode(long VisitID, string OldBarcodeNumber, string NewBarcodeNumber)
        {
            long returnCode = -1;

            try
            {

                DALGateway objGatway = new DALGateway(globalContextDetails);
                returnCode = objGatway.UpdateExistingBarcode(VisitID, OldBarcodeNumber, NewBarcodeNumber);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in pUpdateExistingBarcode", ex);
            }

            return returnCode;
        }
        #region hl7 integration
        public long GetLoginDetails(string LoginName, string RoleName, out List<Login> objLogin)
        {
            long returnCode = -1;
            objLogin = new List<Login>();
            try
            {
                DALGateway objGatway = new DALGateway(globalContextDetails);
                returnCode = objGatway.GetLoginDetails(LoginName, RoleName, out objLogin);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetLoginDetails patient BL ", ex);
            }
            return returnCode;
        }
        #endregion
		
		public long GetOrganizationDBMapping(int OrgID)
        {
            long returnCode = -1;
            List<OrganizationDBMapping> lstDBMapping = null;
            CacheProvider _cp = new CacheProvider(1);
            string pCon = "";
            string pkey = "";
            try
            {
                DALGateway objdal = new DALGateway();
                pkey = _cp.getKey(AttCacheKey.PrimaryDB, OrgID);
                if (!_cp.IsInCache(pkey))
                {
                    returnCode = objdal.GetOrganizationDBMapping(0, out lstDBMapping);
                    if (lstDBMapping != null && lstDBMapping.Count > 0)
                    {
                        Utilities objUtilities = new Utilities();
                        foreach (var item in lstDBMapping)
                        {
                            pkey = _cp.getKey(AttCacheKey.PrimaryDB, item.OrgID);
                            if (!string.IsNullOrEmpty(pkey) && item.IsPrimary)
                            {
                                pCon = string.Format("Server = {0}; Database = {1}; uid = {2};pwd = {3};{4}", item.Instancename, item.DBName, item.DBLogin, item.DBPwd,item.PoolingValue);
                                _cp.Set(pkey, pCon);
                            }
                            pkey = _cp.getKey(AttCacheKey.SecondaryDB, item.OrgID);
                            if (!string.IsNullOrEmpty(pkey) && !item.IsPrimary)
                            {
                                pCon = string.Format("Server = {0}; Database = {1}; uid = {2};pwd = {3};{4}", item.Instancename, item.DBName, item.DBLogin, item.DBPwd, item.PoolingValue);
                                _cp.Set(pkey, pCon);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrganizationDBMapping in Gateway_BL", ex);
            }
            return returnCode;

        }
        public long GetSessionConfidential(Role usrRole, out string Showconfidential)
        {
            long returnCode = 0;

            Showconfidential = string.Empty;
            NavigationDAL navigationDAL = new NavigationDAL();


           // navigationDAL.GetSessionConfidential(usrRole, out Showconfidential);


            return returnCode;
        }
    }
}
