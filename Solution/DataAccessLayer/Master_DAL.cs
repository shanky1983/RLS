using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.BusinessEntities.CustomEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class Master_DAL
    {
        ContextDetails globalContextDetails;
        public Master_DAL()
        {

        }
        public Master_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetCasuality(int pOrgID, out List<CasualtyCharges> lstCas)
        {
            long returnCode = -1;
            lstCas = new List<CasualtyCharges>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetCasualtyDetailsCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstCas);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetCasuality", ex);
            }
            return returnCode;
        }
        //added by sudha for location print map page
        public long UpdateLocationPrintMapping(Int64 autoID, Int64 printerCode, string printerName, string Description, string type, string path, int isActive, int isColorPrinter, string FileContent, string FileNameAndPath)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pUpdateLocationPrintMappingCommand(autoID, printerCode, printerName, Description, type, path, isActive, isColorPrinter, FileContent, FileNameAndPath, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt32(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateLocationPrintMapping in MasterDAL", e);
            }
            return returnCode;
        }
        // added by sudha for location print map
        public long DeleteLocationPrintMapping(Int32 autoId, string Status)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pDeleteLocationPrintMappingCommand(autoId, Status, out returnCode);

                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt32(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateLocationPrintMapping in MasterDAL", e);
            }
            return returnCode;

        }


        public long GetViewTestDetails(long ClientId, long OrgId, out List<ClientDetails> lstClientDetails, out List<ClientDetails> lstClientDetails1)
        {
            long lResult = -1;
            DataSet ds = new DataSet();
            DataTable globalContDetails = new DataTable();
            lstClientDetails = new List<ClientDetails>();
            lstClientDetails1 = new List<ClientDetails>();
            try
            {
            //    SqlCommand cmd = new SqlCommand();
            //    cmd = Command.pGetClientTestDetailsCommand(ClientId, OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));            

            //    using (DBEngine dBEngine = new DBEngine())
            //    {
            //        lResult = dBEngine.ExecuteDataSet(cmd, out ds);
            //        if (ds.Tables.Count > 0)
            //        {
            //            lResult = Utilities.ConvertTo(ds.Tables[0], out lstClientDetails);
            //            lResult = Utilities.ConvertTo(ds.Tables[1], out lstClientDetails1);
                        
            //        }
            //    }
               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetCasuality", ex);
            }
            return lResult;
        }
        public long GetProcedreMaster(int OrgID, long procID, out List<ProcedureMasterMain> lstProcedureMasterMain, out List<ProcedureMasterSub> lstProcedureMasterSub)
        {
            long returnCode = -1;
            lstProcedureMasterMain = new List<ProcedureMasterMain>();
            lstProcedureMasterSub = new List<ProcedureMasterSub>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetProcedureMasterCommand(OrgID, procID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstProcedureMasterMain);
                    Utilities.ConvertTo(ds.Tables[1], out lstProcedureMasterSub);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in MasterDAL GetProcedureMaster", ex);
            }
            return returnCode;
        }

        public long GetDesigantionMaster(int OrgID, out List<DesignationMaster> lstDesignationMaster)
        {
            long returnCode = -1;
            lstDesignationMaster = new List<DesignationMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDesignationMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstDesignationMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetDesignationMaster", ex);
            }
            return returnCode;
        }

        public long InsertCasuality(int pOrgID, CasualtyCharges pCas)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertCasualityCommand(pOrgID, pCas.CasualtyID, pCas.TestName, pCas.CasualtyCode, pCas.CasualtyRate, pCas.CreatedBy, pCas.ModifiedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertCasuality", ex);
            }
            return returncode;
        }

        public long GetMappedTaskActions(long orgID, long roleID, out List<TaskActions> lstTaskActions)
        {
            long returnCode = -1;
            lstTaskActions = new List<TaskActions>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetMappedTaskActionsCommand(orgID, roleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstTaskActions);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTaskActions", ex);
            }
            return returnCode;
        }

        public long SaveAndDeleteTaskActions(string stype, List<TaskActionOrgMapping> lstTaskActionOrgMapping)
        {
            long returnCode = -1;

            DataTable DtTaskActionOrgMapping = UDT_DAL.ConvertToTaskActionOrgMapping(lstTaskActionOrgMapping);

            SqlCommand cmd = Command.pSaveAndDeleteTaskActionsCommand(stype, DtTaskActionOrgMapping, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing SaveAndDeleteTaskActions Master_DAL", ex);
            }
            return returnCode;
        }

        public long GetTaskActions(out List<TaskActions> lstTaskActions)
        {
            long returnCode = -1;
            lstTaskActions = new List<TaskActions>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetTaskActionsCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstTaskActions);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTaskActions", ex);
            }
            return returnCode;
        }

        public long GetGeneralBillingItemsRateDetails(int pOrgID, out List<GeneralBillingItems> GBI)
        {
            long returnCode = -1;
            GBI = new List<GeneralBillingItems>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetGeneralBillingItemsRateDetailsCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                GBI = new List<GeneralBillingItems>();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out GBI);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetGeneralBillingItemsRateDetails", ex);
            }
            return returnCode;
        }

        public long pGetRateName(int pOrgID, out List<RateMaster> lstRateMaster)
        {
            long returnCode = -1;
            lstRateMaster = new List<RateMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetRateMasterCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstRateMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Master_DAL pGetRateName", ex);
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


        public long GetBannerDetails(int pOrgID, int BannerID, out List<Banners> lstBanners, out List<BannerRoleMapping> lstBannerRoleMapping)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetBannerTextCommand(pOrgID, BannerID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstBanners = new List<Banners>();
            lstBannerRoleMapping = new List<BannerRoleMapping>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0) // History
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBanners);
                }

                if (ds.Tables[1].Rows.Count > 0) // Examination 
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBannerRoleMapping);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetBannerDetails", ex);
            }
            return returnCode;
        }

        public long InsertBannerMaster(Banners ObjBanners, string Stype, BannerRoleMapping ObjBannerRoleMapping,
            List<BannerRoleMapping> lstBannerRoleMapping)
        {
            long returnCode = -1;
            DataTable DtBannerRoleMapping = UDT_DAL.ConvertToBannerMaster(lstBannerRoleMapping);
            SqlCommand cmd = Command.pInsertBannerMasterCommand(ObjBanners.BannerText, ObjBanners.OrgID, Stype,
                                                    ObjBannerRoleMapping.BannerID, DtBannerRoleMapping, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing InsertBannerMaster Master_DAL", ex);
            }
            return returnCode;
        }

        public long InsertGeneralBillingMaster(GeneralBillingMaster pGBM)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertGeneralBillingMasterCommand(pGBM.GenBillName, pGBM.OrgID, pGBM.GenBillID, pGBM.CreatedAt, pGBM.CreatedBy, pGBM.IsDefaultBilling, pGBM.IsDiscountable, pGBM.IsTaxable, pGBM.IsVariable, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Master", ex);
            }
            return returncode;
        }
        public long GetCurrencyForOrg(int OrgID, out int BaseCurrency, out string BaseCurrencyCode, out List<CurrencyMaster> lstCurrencyMaster)
        {
            long returnCode = -1;
            BaseCurrency = 0;
            BaseCurrencyCode = string.Empty;

            lstCurrencyMaster = new List<CurrencyMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetCurrencyForOrgCommand(OrgID, out BaseCurrency, out BaseCurrencyCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCurrencyMaster);
                        dataReader.Close();
                    }
                }
                BaseCurrency = Convert.ToInt32(objCommand.Parameters["@pBaseCurrencyID"].Value);
                BaseCurrencyCode = objCommand.Parameters["@pBaseCurrencyCode"].Value.ToString();
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetCurrencyForOrg in Master_DAL", excep);
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

        public long GetCurrencyForOrgMapping(int OrgID, out List<CurrencyMaster> lstCurrencyMaster)
        {
            long returnCode = -1;
            lstCurrencyMaster = new List<CurrencyMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetCurrencyForOrgMappingCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCurrencyMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetCurrencyForOrgMapping in Master_DAL", excep);
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

        public long SaveBaseCurrency(int OrgID, int BaseCurrency)
        {
            long returnCode = -1;
            SqlCommand cmdInsertBaseCurrency = new SqlCommand();
            cmdInsertBaseCurrency = Command.pInsertBaseCurrencyCommand(OrgID, BaseCurrency, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertBaseCurrency.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertBaseCurrency.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdInsertBaseCurrency);
                    returnCode = Convert.ToInt64(cmdInsertBaseCurrency.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveBaseCurrency Master_DAL", excep);
            }
            return returnCode;
        }
        public long SaveOtherCurrency(List<CurrencyOrgMapping> lstCurrOrgMapp)
        {
            long returnCode = -1;
            DataTable DtCurrOrgMappDataList = UDT_DAL.ConvertToUDTCurrencyOrgMapping(lstCurrOrgMapp);
            SqlCommand cmdInsertOtherCurrency = new SqlCommand();
            cmdInsertOtherCurrency = Command.pInsertOtherCurrencyCommand(DtCurrOrgMappDataList, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertOtherCurrency.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertOtherCurrency.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmdInsertOtherCurrency);
                    returnCode = Convert.ToInt64(cmdInsertOtherCurrency.Parameters["@Return"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveOtherCurrency Master_DAL", e);
            }
            return returnCode;
        }
        public long GetCurrencyForRateConversion(int OrgID, string pType, out List<CurrencyOrgMapping> lstCurrOrgMapp)
        {
            long returnCode = -1;
            lstCurrOrgMapp = new List<CurrencyOrgMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetCurrencyForConversionRateCommand(OrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCurrOrgMapp);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetCurrencyForRateConversion in Master_DAL", excep);
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

        public long GetCurrencyOrgMapping(int OrgID, out List<CurrencyOrgMapping> lstCurrOrgMap)
        {
            long returnCode = -1;
            lstCurrOrgMap = new List<CurrencyOrgMapping>();
            SqlCommand cmd = Command.pGetCurrencyOrgMappingCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCurrOrgMap);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCurrencyOrgMapping in Master_DAL", ex);
            }
            return returnCode;
        }
        public long UpdateOtherCurrency(List<CurrencyOrgMapping> lstCurrOrgMapp)
        {
            long returnCode = -1;
            DataTable DtCurrOrgMappDataList = UDT_DAL.ConvertToUDTCurrencyOrgMapping(lstCurrOrgMapp);
            SqlCommand cmdUpdateOtherCurrency = new SqlCommand();
            cmdUpdateOtherCurrency = Command.pUpdateOtherCurrencyCommand(DtCurrOrgMappDataList, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateOtherCurrency.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateOtherCurrency.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmdUpdateOtherCurrency);
                    returnCode = Convert.ToInt64(cmdUpdateOtherCurrency.Parameters["@Return"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateOtherCurrency Master_DAL", e);
            }
            return returnCode;
        }
        public long GetOrgMappedCurrencies(int OrgID, out List<CurrencyOrgMapping> lstCurrOrgMapp)
        {
            long returnCode = -1;
            lstCurrOrgMapp = new List<CurrencyOrgMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetOrgMappedCurrenciesCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCurrOrgMapp);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetOrgMappedCurrencies in Master_DAL", excep);
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

        public long GetIncomeSourceMaster(int OrgID, out List<IncomeSourceMaster> lstIncomeSource)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetIncomeSourceCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstIncomeSource = new List<IncomeSourceMaster>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIncomeSource);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetOrgMappedCurrencies in Master_DAL", excep);
            }
            return returnCode;
        }

        public long GetGeneralBillingMaster(int pOrgID, out List<GeneralBillingMaster> GBI)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            GBI = new List<GeneralBillingMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pgetGeneralBillingMasterCommand(pOrgID, "", UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out GBI);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetGeneralBillingItemsRateDetails in MasterDAL", ex);
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



        public long InsertDiscountMaster(int pOrgID, DiscountMaster pCas)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertDiscountMasterCommand(pOrgID, pCas.DiscountID, pCas.DiscountName, pCas.Discount, pCas.DiscountPercentage, pCas.Code, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returncode;
        }

        public long InsertEmployeeMaster(int OrgID, string TypeName, EmployeeMaster ObjEmployeeMaster, long LID)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertEmployeeMasterCommand(OrgID, TypeName, ObjEmployeeMaster.ID, ObjEmployeeMaster.Name, LID, ObjEmployeeMaster.Code, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returncode;
        }

        public long GetDiscountMaster(int pOrgID, out List<DiscountMaster> lstCas)
        {
            long returnCode = -1;
            lstCas = new List<DiscountMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDiscountMasterCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstCas);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returnCode;
        }

        public long DeleteDiscountMaster(int pOrgID, int pDiscountID)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pDeleteDiscountMasterCommand(pOrgID, pDiscountID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DeleteDiscountMaster in MasterDal", ex);
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


        public long InsertTaxMaster(int pOrgID, Taxmaster ptax)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertTaxMasterCommand(pOrgID, ptax.TaxID, ptax.TaxName, ptax.TaxPercent, ptax.CreatedBy, ptax.Code, ptax.ReferenceType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returncode;
        }

        public long GetTaxMaster(int pOrgID, out List<Taxmaster> lstTax)
        {
            long returnCode = -1;
            lstTax = new List<Taxmaster>();
            SqlCommand cmd = new SqlCommand();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.pGetTaxMasterCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTax);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTaxMaster", ex);
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


        public long DeleteTaxMaster(int pOrgID, int pTaxID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pDeleteTaxMasterCommand(pOrgID, pTaxID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DeleteTaxMaster", ex);
            }
            return returnCode;
        }

        public long GetClientFeeTypeRateDetails(long ClientID, int RoomTypeID, int OrgId, out List<ClientFeeTypeRateCustomization> lstClientRateMaster)
        {
            long returnCode = -1;
            lstClientRateMaster = new List<ClientFeeTypeRateCustomization>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetClientFeeTypeRateDetailsCommand(ClientID, RoomTypeID, OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstClientRateMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientFeeTypeRateDetails()", ex);
            }
            return returnCode;
        }


        public long GetClientFeeTypeRateGroup(int OrgId, out List<ClientFeeTypeRateCustomization> lstClientRateMaster)
        {
            long returnCode = -1;
            lstClientRateMaster = new List<ClientFeeTypeRateCustomization>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetClientFeeTypeRateGroupCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstClientRateMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientFeeTypeRateGroup()", ex);
            }
            return returnCode;
        }

        public long GetclientTpaRoomFeeTypes(long OrgID, out List<FeeTypeMaster> lstFeeDesc, out List<FeeTypeMaster> lstFeeType, out List<RoomType> lstRoomType, out List<InvClientMaster> lstInvClientMaster, out List<TPAMaster> lstTPAMaster)
        {
            long returnCode = -1;
            lstFeeDesc = new List<FeeTypeMaster>();
            lstFeeType = new List<FeeTypeMaster>();
            lstRoomType = new List<RoomType>();
            lstInvClientMaster = new List<InvClientMaster>();
            lstTPAMaster = new List<TPAMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetclientTpaRoomFeeTypesCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 1)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFeeDesc);
                    Utilities.ConvertTo(ds.Tables[1], out lstFeeType);
                    Utilities.ConvertTo(ds.Tables[2], out lstRoomType);
                    Utilities.ConvertTo(ds.Tables[3], out lstInvClientMaster);
                    Utilities.ConvertTo(ds.Tables[4], out lstTPAMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Get Customize Client Fee type Rate Master", ex);
            }
            return returnCode;
        }

        public long SaveProcDescription(string sType, ProcedureMasterSub objProcedureMasterSub, long LID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveProcDescriptionCommand(sType, objProcedureMasterSub.RunningID, objProcedureMasterSub.ProcMainID, objProcedureMasterSub.OrgID, objProcedureMasterSub.IsVisitPurpose, objProcedureMasterSub.ProcDesc, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertCasuality", ex);
            }
            return returnCode;
        }

        public long SaveProcedureMain(ProcedureMasterMain objProcedureMasterMain)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveProcedureMainCommand(objProcedureMasterMain.ProcName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Insert Procedure Main", ex);
            }
            return returnCode;
        }


        public long DeleteClientFeeTypeRate(long lngClientId, int intRoomtypeId)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pDelClientFeeTypeRateDetailsCommand(lngClientId, intRoomtypeId, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DeleteClientFeeTypeRate()", ex);
            }
            return returnCode;
        }


        public long GetEmployeeMasters(int OrgID,
                                         out List<DesignationMaster> lstDesignationMaster,
                                         out List<RelationshipMaster> lstRealtionshipMaster,
                                         out List<EmploymentType> lstEmploymentType,
                                         out List<EmployerDeptMaster> lstEmployerDeptMaster,
                                         out List<PatientTypeMaster> lstPatientTypeMaster,
                                         out List<GradeMaster> lstGradMaster,
                                         out List<EmployerMaster> lstEmployerMaster,
                                         out List<EmployerLocationMaster> lstEmployerLocationMaster,
                                         out long EmpID,
                                         out long ExterID
                                         )
        {
            long returnCode = -1;
            EmpID = 0;
            ExterID = 0;
            lstDesignationMaster = new List<DesignationMaster>();
            lstRealtionshipMaster = new List<RelationshipMaster>();
            lstEmploymentType = new List<EmploymentType>();
            lstEmployerDeptMaster = new List<EmployerDeptMaster>();
            lstPatientTypeMaster = new List<PatientTypeMaster>();
            lstGradMaster = new List<GradeMaster>();
            lstEmployerMaster = new List<EmployerMaster>();
            lstEmployerLocationMaster = new List<EmployerLocationMaster>();
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetEmployeeMastersCommand(OrgID, out EmpID, out ExterID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                Utilities.ConvertTo(dataReader, out lstDesignationMaster);
                            }
                            else if (rsCount == 1)
                            {
                                Utilities.ConvertTo(dataReader, out lstRealtionshipMaster);
                            }
                            else if (rsCount == 2)
                            {
                                Utilities.ConvertTo(dataReader, out lstEmploymentType);
                            }
                            else if (rsCount == 3)
                            {
                                Utilities.ConvertTo(dataReader, out lstEmployerDeptMaster);
                            }
                            else if (rsCount == 4)
                            {
                                Utilities.ConvertTo(dataReader, out lstPatientTypeMaster);
                            }
                            else if (rsCount == 5)
                            {
                                Utilities.ConvertTo(dataReader, out lstGradMaster);
                            }
                            else if (rsCount == 6)
                            {
                                Utilities.ConvertTo(dataReader, out lstEmployerMaster);
                            }
                            else if (rsCount == 7)
                            {
                                Utilities.ConvertTo(dataReader, out lstEmployerLocationMaster);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                    EmpID = Convert.ToInt64(cmd.Parameters["@ID"].Value);
                    ExterID = Convert.ToInt64(cmd.Parameters["@ExID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveSurgeryMasterItems", ex);
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


        public long SaveSurgeryMasterItems(IPTreatmentPlan objTreatmentPlan)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveSurgeryMasterItemsCommand(objTreatmentPlan.PhysicianName, objTreatmentPlan.IPTreatmentPlanName, objTreatmentPlan.OrgID,
                                                                                                objTreatmentPlan.CreatedBy, objTreatmentPlan.OperationID, objTreatmentPlan.ParentName, objTreatmentPlan.Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveSurgeryMasterItems", ex);
            }
            return returnCode;
        }
        public long GetSurgeryMasterItems(int OrgId, out List<IPTreatmentPlan> lstTreatmentPlan)
        {
            long returnCode = -1;
            lstTreatmentPlan = new List<IPTreatmentPlan>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetSurgeryMasterItemsCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstTreatmentPlan);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetSurgeryMasterItems()", ex);
            }
            return returnCode;
        }
        public long GetTreatmentPlan(int OrgId, out List<IPTreatmentPlan> lstGetTreatmentPlan)
        {
            long returnCode = -1;
            lstGetTreatmentPlan = new List<IPTreatmentPlan>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetTreatmentPlanCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstGetTreatmentPlan);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTreatmentPlan()", ex);
            }
            return returnCode;
        }

        public long InsertDiscountReasonMaster(int pOrgID, DiscountReasonMaster disrea)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertDiscountResonMasterCommand(pOrgID, disrea.ReasonId, disrea.ReasonCode, disrea.ReasonDesc, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returncode;
        }
        public long GetReasonMaster(int pOrgID, out List<DiscountReasonMaster> lstDiscountReason)
        {
            long returnCode = -1;
            lstDiscountReason = new List<DiscountReasonMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDiscountReasonMasterCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstDiscountReason);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returnCode;
        }
        public long DeleteDiscountReasonMaster(int pOrgID, int pReasonID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pDeleteDiscountReasonMasterCommand(pOrgID, pReasonID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DeleteDiscountMaster", ex);
            }
            return returnCode;
        }

        public long GetCategoriesAndPatterns(int OrgID, out List<MasterCategories> lstCategories, out List<MasterPatterns> lstPatterns, out List<MasterCategories> lstCategoryNPattern)
        {
            long returnCode = -1;
            lstCategories = new List<MasterCategories>();
            lstPatterns = new List<MasterPatterns>();
            lstCategoryNPattern = new List<MasterCategories>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetCategoriesAndPatternsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstCategories);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[1], out lstPatterns);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[2], out lstCategoryNPattern);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTreatmentPlan()", ex);
            }
            return returnCode;
        }
        public long CheckAndAssignPattern(int OrgID, long pOrgAddressID, List<MasterCategories> lstMC)
        {
            long returnCode = -1;
            try
            {
                DataTable DTvalues = UDT_DAL.ConvertToUDTCategoriesAndPatterns(lstMC);
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pCheckAndAssignPatternCommand(OrgID, pOrgAddressID, DTvalues, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTreatmentPlan()", ex);
            }
            return returnCode;
        }


        public long BarcodeCategoryName(out List<BarcodeCategories> lstBarcodeCategories)
        {
            long returnCode = -1;
            lstBarcodeCategories = new List<BarcodeCategories>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetBarcodeCategoryNameCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstBarcodeCategories);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL BarcodeCategories", ex);
            }
            return returnCode;
        }


        public long BarcodeMainAttributesName(out List<BarcodeMainAttributes> lstBarcodeMainAttributes)
        {
            long returnCode = -1;
            lstBarcodeMainAttributes = new List<BarcodeMainAttributes>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetBarcodeMainAttributesNameCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstBarcodeMainAttributes);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL BarcodeMainAttributes", ex);
            }
            return returnCode;
        }


        public long BarcodePlaceHoldersName(out List<BarcodePlaceHolders> lstBarcodePlaceHolders)
        {
            long returnCode = -1;
            lstBarcodePlaceHolders = new List<BarcodePlaceHolders>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetBarcodePlaceHoldersNameCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstBarcodePlaceHolders);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL BarcodePlaceHolders", ex);
            }
            return returnCode;
        }



        public long BarcodeCheckAndAssignPattern(int OrgID, List<BarcodeOrgMapping> lstMC)
        {
            long returnCode = -1;
            try
            {
                DataTable dtValues = UDT_DAL.ConvertToUDTBarcodeCategoriesAndPatterns(lstMC);
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertBarcodeorgmappingCommand(OrgID, dtValues, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTreatmentPlan()", ex);
            }
            return returnCode;
        }

        public long GetBarcodeOrgMapping(int pOrgID, out List<BarcodeOrgMapping> lstborg)
        {
            long returnCode = -1;
            lstborg = new List<BarcodeOrgMapping>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetBarcodeorgmappingCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstborg);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returnCode;
        }


        public long SaveClientMasters(int pOrgID,
            int orgaddid,
            long lid,
            ClientMaster obj,
            List<AddressDetails> lstClientAddress,
            List<ClientAttributesDetails> lstClientAttributes,
            List<DespatchMode> lstdespatchmode,
            List<ClientAttributesDetails> lstpaymode,
            out long newClientID,
            int IsClient,
            int IsRemoteAccess,
            List<ClientTaxMaster> lstClientTaxMaster,string Reason, List<ClientLanguage> lstlanguage)
        {
            long returnCode = -1;
            DataTable Dtaddressdetails = UDT_DAL.ConvertToUDTAddressDetails(lstClientAddress);
            DataTable dtattributes = UDT_DAL.ConvertToUDTClientAttributes(lstClientAttributes);
            DataTable dtDespatchmode = UDT_DAL.ConvertToUDTClientDespatchmode(lstdespatchmode);
            DataTable dtpaymode = UDT_DAL.ConvertToUDTClientAttributes(lstpaymode);
            DataTable dtClientTaxMaster = UDT_DAL.ConvertToUDTClientTaxMaster(lstClientTaxMaster);
            DataTable dtclientlang = UDT_DAL.ConvertToUDTClientLanguage(lstlanguage);
            newClientID = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertInvoiceClientCommand(obj.ClientID, obj.ClientCode, obj.ClientName, obj.ContactPerson, obj.CstNo, obj.DespatchModeID,
                         obj.ServiceTaxNo, obj.PanNo, obj.ApprovalRequired, obj.ClientStatus, obj.ClientTypeID, obj.Attributes, obj.ZonalID, obj.RouteID, obj.SapCode, obj.SalesManID, obj.CreditLimit,
                         obj.Pathologist, obj.BlockedClient, obj.CustomerType, obj.IsMappedItem, obj.ReportTemplateID, obj.CreditDays,
                         obj.GraceLimit, obj.GraceDays, obj.ParentClientID, obj.CollectionCenterID, obj.Termsconditions, obj.ISCash, obj.IsDeleted,
                         pOrgID, orgaddid, lid, Dtaddressdetails, dtattributes, dtDespatchmode, dtpaymode, obj.IsParentPayer, obj.Status, obj.Reason, obj.HubID, obj.PaymentDays, obj.ReferingID, obj.TodID, obj.VoLID, obj.IsDiscount, obj.BlockFrom, obj.BlockTo, obj.AuthorizedBy,
                         obj.TransitTimeValue, obj.TransitTimeType, obj.Tax, obj.DiscountPolicyID, obj.PromisedAmount, obj.PrintOrgAddressID, out newClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), IsClient, IsRemoteAccess, obj.InvoiceCycle, dtClientTaxMaster, obj.ReportPrintdate, Reason, obj.IsAdvanceClient, obj.ThresholdType, obj.ThresholdValue, obj.ThresholdValue2, obj.ThresholdValue3, obj.VirtualCreditType, obj.VirtualCreditValue, obj.MinimumAdvanceAmt, obj.MaximumAdvanceAmt, obj.FilePath
                    /*BEGIN || TAT || RAJKUMAR G || 20191001*/
                         , obj.Tatprocessdatetype, obj.Tattransitbasetype
                    /*END || TAT || RAJKUMAR G || 20191001*/
                        , dtclientlang, obj.InvoiceShowColumns
						/* Franchisee changes by Surya */
						,obj.IsFranchisee,obj.FranchiseeType 
/* Franchisee changes by Surya */
						); //Alex
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {

                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                    newClientID = Convert.ToInt64(cmd.Parameters["@ClientIDs"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveClientMasters()", ex);
            }
            return returnCode;
        }



        public long GetInvoiceClientDetails(int pOrgID, int orgaddid, string cname, string code, long ClientID, out List<ClientMaster> lstborg)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstborg = new List<ClientMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetClientDetailsCommand(pOrgID, orgaddid, cname, code, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstborg);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
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


        public long Getsearchclientbatchmaster(int orgID, int Clientid, string clientcode, string batchid, DateTime Fromdate, DateTime Todate,string Status, out List<ClientBatchMasterDetails> lstinvmasters)
        {
            DataSet ds = new DataSet();
            long returnCode = -1;
            lstinvmasters = new List<ClientBatchMasterDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetsearchclientbatchmasterCommand(orgID, Clientid, clientcode, batchid,Fromdate,Todate,Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstinvmasters);

                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save HomeCollection Details ", ex);
            }
            return returnCode;
        }


        public long insertClientBatchMaster(string Batchidtxt, DateTime Fromdatetext, DateTime Todatetext, int Billingid,int Clientid,int Testnameid,int OrgID,long LID,string TestType)
        {

            long returnCode = -1;
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd = Command.PinsertClientBatchMasterCommand(Batchidtxt, Fromdatetext, Todatetext, Billingid, Clientid, Testnameid,OrgID,LID,TestType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {

                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveClientBatchMasters()", ex);
            }


            return returnCode;
        }

public long Getsearchbatchid(int orgID, int Clientid, string batchid, out List<ClientBatchMaster> lstinvmasters)
        {
            DataSet ds = new DataSet();
            long returnCode = -1;
            lstinvmasters = new List<ClientBatchMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetsearchbatchidCommand(orgID, Clientid, batchid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstinvmasters);

                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save HomeCollection Details ", ex);
            }
            return returnCode;
        }

        public long Insertpushingordereddetails(int orgID, string batchid, string category,out List<ClientBatchMaster> lstinvmasters)
        {
            DataSet ds = new DataSet();
            long returnCode = -1;
            lstinvmasters = new List<ClientBatchMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pinsertpushingordereddetailsCommand(orgID, batchid,category, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstinvmasters);

                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save HomeCollection Details ", ex);
            }
            return returnCode;
        }


        public long GetClientList(int pOrgID, string prefixText, int typeid, out List<InvClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            lstInvClientMaster = new List<InvClientMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetClientNameCommand(pOrgID, prefixText, typeid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvClientMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InvClientMaster", ex);
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

        public long GetClientRateCard(int pOrgID, string prefixText, string RateType, out List<RateMaster> lstRateMaster)
        {
            long returnCode = -1;
            lstRateMaster = new List<RateMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PgetclientratecardCommand(pOrgID, prefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails), RateType);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstRateMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientRateMaster", ex);
            }
            return returnCode;
        }
        public long GetDespatchMode(out List<DespatchMode> lstDespatchMode)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetDespatchModeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstDespatchMode = new List<DespatchMode>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDespatchMode);
            }
            return returnCode;
        }
        public long GetAddressType(out List<AddressType> lstAddressType)
        {
            IDataReader dataReader = null;
            lstAddressType = new List<AddressType>();
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pGetAddressTypeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstAddressType);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetPerformingAction", ex);
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


        public long GetGroupValues(int orgid, out List<MetaValue_Common> lstmetavalue, out List<ActionManagerType> lstactionmanager, out List<ClientAttributes> lstclientattributes,
                                    out List<InvReportMaster> lstinvrptmaster)
        {
            long returnCode = -1;
            int rsCount = 0;
            lstmetavalue = new List<MetaValue_Common>();
            lstactionmanager = new List<ActionManagerType>();
            lstclientattributes = new List<ClientAttributes>();
            lstinvrptmaster = new List<InvReportMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetGroupValuesCommand(orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstmetavalue);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstactionmanager);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstclientattributes);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstinvrptmaster);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Master_DAL GetGroupValues", ex);
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


        public long GetGroupMasterDetails(int pOrgID, string Code, string prefixText, out List<Localities> lstLocalities)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstLocalities = new List<Localities>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pgetGroupMasterDetailsCommand(pOrgID, Code, prefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLocalities);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Master_DAL GetGroupMasterDetails", ex);
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


        public long GetSalesManname(int orgid, string Designation, string prefixText, out List<EmployeeRegMaster> lstemployee)
        {
            long returnCode = -1;
            lstemployee = new List<EmployeeRegMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetSalesMannameCommand(orgid, Designation, prefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstemployee);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientRateMaster", ex);
            }
            return returnCode;
        }
        public long GetCollectionCentreMaster(int orgid, string prefixText, out List<OrganizationAddress> lstorgaddress)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstorgaddress = new List<OrganizationAddress>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetCollectionCentreMasterCommand(orgid, prefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstorgaddress);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetCollectionCentreMaster in masterDal", ex);
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

        public long GetCollectionCentreClients(int orgid, int LocationID, string prefixText, out List<ClientMaster> lstClientNames)
        {
            long returnCode = -1;
            lstClientNames = new List<ClientMaster>();
            SqlCommand cmd = new SqlCommand();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.PGetLocationClientsCommand(orgid, LocationID, prefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstClientNames);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientRateMaster", ex);
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

        public long GetEmployeeRegistration(long OrgID, out List<EmployeeRegMaster> lstEmpReg)
        {
            long returnCode = -1;
            lstEmpReg = new List<EmployeeRegMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetEmployeeRegMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        Utilities.ConvertTo(dataReader, out lstEmpReg);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetEmployeeRegistration", ex);
            }
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }

        public long GetClientforDiscount(int pOrgID, string prefixText, int typeid, out List<InvClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            lstInvClientMaster = new List<InvClientMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetClientforDiscountCommand(pOrgID, prefixText, typeid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstInvClientMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientRateMaster", ex);
            }
            return returnCode;
        }
        public long SaveTurnOverDiscountDetail(int OrgID, List<DiscountPolicy> lstDP)
        {
            long returnCode = -1;

            DataTable DtlstDP = UDT_DAL.ConvertToDiscountPolicyUDT(lstDP);

            SqlCommand cmd = Command.pSaveTurnOverDiscountDetailCommand(OrgID, DtlstDP, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing SaveTurnOverDiscountDetail Master_DAL", ex);
            }
            return returnCode;
        }
        public long SaveEmpRegistration(List<EmployeeRegMaster> lstEmployeeRegMaster)
        {
            long returnCode = -1;
            DataTable DtEmployeeRegMaster = UDT_DAL.ConvertToUDTEmployeeRegMaster(lstEmployeeRegMaster);
            SqlCommand cmdSaveEmpRegistration = new SqlCommand();
            cmdSaveEmpRegistration = Command.pSaveEmployeeRegMasterCommand(DtEmployeeRegMaster, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmdSaveEmpRegistration);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveEmpRegistration Master_DAL", e);
            }
            return returnCode;
        }

        public long SaveSpecialRateMaster(string RateName, int OrgID, long CreatedBy, string MappingType,
            List<RateMaster> lstRateMaster)
        {
            long returnCode = -1;
            try
            {
                DataTable dtSpecialRates = UDT_DAL.ConvertToSpecialRateMaster(lstRateMaster);
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveSpecialRateMasterCommand(RateName, OrgID, CreatedBy, MappingType,
                                                        dtSpecialRates, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while SaveSpecialRateMaster() in Master_DAL", ex);
            }
            return returnCode;
        }

        public long GetSpecialRates(int OrgID, out List<RateMaster> lstRateMaster)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstRateMaster = new List<RateMaster>();
            try
            {
                SqlCommand cmd = Command.pGetSpecialRatesCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstRateMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetSpecialRates() in MasterDAL", ex);
            }
            return returnCode;
        }


        public long GetCustomerTODdetails(int OrgID, string Code, out List<DiscountPolicy> lstDiscountPolicy)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstDiscountPolicy = new List<DiscountPolicy>();
            try
            {
                SqlCommand cmd = Command.pGetCustomerTODdetailsCommand(OrgID, Code, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDiscountPolicy);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading pGetCustomerTODdetails() in MasterDAL", ex);
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


        public long UpdateSpecialRateMaster(int OrgID, long RateID, long ModifiedBy, List<RateMaster> lstRateMaster)
        {
            long returnCode = -1;
            try
            {
                DataTable dtSpecialRates = UDT_DAL.ConvertToSpecialRateMaster(lstRateMaster);
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pUpdateSpecialRateMasterCommand(OrgID, RateID, ModifiedBy, dtSpecialRates, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while UpdateSpecialRateMaster() in Master_DAL", ex);
            }
            return returnCode;
        }



        public long GetSampleCollectionZones(int OrgID, out List<Localities> lstMetaValues)
        {
            long returnCode = -1;
            lstMetaValues = new List<Localities>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetSampleCollectionZonesCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstMetaValues);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetSampleCollectionZones() in MasterDAL", ex);
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



        public long GetEmployerDeptMaster(int OrgID, out List<EmployerDeptMaster> lstEmployerDeptMaster)
        {
            long returnCode = -1;
            lstEmployerDeptMaster = new List<EmployerDeptMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetEmployerDeptMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstEmployerDeptMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetEmployerDeptMaster() in MasterDAL", ex);
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


        public long GetSpecifiedDeptEmployee(int OrgID, string DeptCode, string PrefixText, out List<EmployeeRegMaster> lstEmployeeRegMaster)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstEmployeeRegMaster = new List<EmployeeRegMaster>();
            try
            {
                SqlCommand cmd = Command.pGetSpecifiedDeptEmployeeCommand(OrgID, DeptCode, PrefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstEmployeeRegMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetSpecifiedDeptEmployee() in MasterDAL", ex);
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


        public long GetTODCode(int OrgID, string PrefixText, out List<DiscountPolicy> lstTOD)
        {
            long returnCode = -1;
            lstTOD = new List<DiscountPolicy>();
            try
            {
                SqlCommand objCommand = Command.pGetTODCODECommand(OrgID, PrefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTOD);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetSpecifiedDeptEmployee() in MasterDAL", ex);
            }
            return returnCode;
        }

        public long GetmetaValue(int OrgID, string Code, out List<MetaValue_Common> lstMetaValue)
        {
            long returnCode = -1;
            lstMetaValue = new List<MetaValue_Common>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetMetaValueCommand(Code, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstMetaValue);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetEmployerDeptMaster() in MasterDAL", ex);
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


        public long GetHospAndRefPhy(int OrgID, string PrefixText, int ClientTypeID, out List<ClientMaster> lstClientMaster)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstClientMaster = new List<ClientMaster>();
            try
            {
                SqlCommand cmd = Command.pGetHospAndRefPhyCommand(OrgID, PrefixText, ClientTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstClientMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetHospAndRefPhy() in MasterDAL", ex);
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


        public long GetCoupon(int pOrgID, out List<CouponMaster> lstCouponMaster, out List<CouponDetails> lstCouponDetails)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstCouponMaster = new List<CouponMaster>();
            lstCouponDetails = new List<CouponDetails>();
            int rsCount = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetCouponCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCouponMaster);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCouponDetails);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetCoupon in MasterDal", ex);
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


        public long SaveCoupon(int intOrgID, List<CouponMaster> lstCouponMaster, List<CouponDetails> lstCouponDetails, string strMasterDetail, string strInsUpdate, long lngLID, out string strResult)
        {
            long returncode = -1;
            strResult = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dtCouponMaster = UDT_DAL.ConvertToUDTCouponMaster(lstCouponMaster);
                DataTable dtCouponDetail = UDT_DAL.ConvertToUDTCouponDetails(lstCouponDetails);

                cmd = Command.pSaveCouponCommand(intOrgID, dtCouponMaster, dtCouponDetail, strMasterDetail, strInsUpdate, lngLID, out strResult, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                    strResult = cmd.Parameters["@result"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returncode;
        }

        public long GetTODforInvoice(int OrgID, long ClientID, out List<DiscountPolicy> lstTOD)
        {
            long returnCode = -1;
            lstTOD = new List<DiscountPolicy>();
            try
            {
                SqlCommand objCommand = Command.pGetTODdetailsforInvoiceCommand(OrgID, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTOD);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading pGetTODdetailsforInvoice() in MasterDAL", ex);
            }
            return returnCode;
        }

        public long CheckClientCreditLimit(long ClientID, int OrgID, out string CreditStatus, out Decimal BalanceAmount)
        {
            long returncode = -1;
            CreditStatus = "";
            BalanceAmount = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pCheckClientCreditLimitCommand(ClientID, OrgID, out CreditStatus, out BalanceAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                    CreditStatus = cmd.Parameters["@pCreditStatus"].Value.ToString();
                    BalanceAmount = Convert.ToDecimal(cmd.Parameters["@pBalanceAmount"].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CheckClientCreditLimit", ex);
            }
            return returncode;
        }

        public long GetClientMappingService(int OrgID, long ClientID, string refType, out List<ClientMappingService> lstClientMappingService)
        {
            long returnCode = -1;
            lstClientMappingService = new List<ClientMappingService>();
            try
            {
                SqlCommand objCommand = Command.pGetClientMappingServiceCommand(OrgID, ClientID, refType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstClientMappingService);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetClientMappingService() in MasterDAL", ex);
            }
            return returnCode;
        }

        public long SavePrintPolicy(Int32 pOrgID, Int64 pLoginID, PrintPolicyMaster oPrintPolicyMaster, out Int64 pID)
        {
            long returnCode = -1;
            pID = 0;
            try
            {
                DataTable dtPrintPolicy = UDT_DAL.ConvertToPrintPolicy(oPrintPolicyMaster);
                SqlCommand cmd = Command.pSavePrintPolicyMasterCommand(dtPrintPolicy, pOrgID, pLoginID, out pID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    Int64.TryParse(cmd.Parameters["@pID"].Value.ToString(), out pID);
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SavePrintPolicy in Master_DAL", ex);
            }
            return returnCode;
        }
        public long DeletePrintPolicy(Int64 pID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pDeletePrintPolicyMasterCommand(pID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeletePrintPolicy in Master_DAL", ex);
            }
            return returnCode;
        }
        public long GetPrintPolicy(Int32 pOrgID, Int64 pRoleID, Int64 pLocationID, out List<PrintPolicy> lstPrintPolicyMaster)
        {
            long returnCode = -1;
            lstPrintPolicyMaster = new List<PrintPolicy>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPrintPolicyMasterCommand(pOrgID, pRoleID, pLocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPrintPolicyMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetPrintPolicy", ex);
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


        public long GetServieandServicetMaster(int OrgID, out List<FeeTypeMaster> lstService, out List<FeeTypeMaster> lstResource, out List<MetaData> lstdurations)
        {
            long returnCode = -1;
            lstService = new List<FeeTypeMaster>();
            lstResource = new List<FeeTypeMaster>();
            lstdurations = new List<MetaData>();

            try
            {
                SqlCommand objCommand = Command.pGetServiceandResourceTypesCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstService);
                }

                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstResource);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstdurations);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Service and Resource() in MasterDAL", ex);
            }
            return returnCode;
        }

        public long GetServiceNames(int OrgID, string servicetype, string PrefixText, out List<BillingFeeDetails> lstDetails)
        {
            long returnCode = -1;
            lstDetails = new List<BillingFeeDetails>();



            try
            {
                SqlCommand objCommand = Command.pGetServiceNamesCommand(OrgID, servicetype, PrefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDetails);
                }



            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetServiceNames() in MasterDAL", ex);
            }
            return returnCode;
        }

        public long GetResourceNames(int OrgID, string ProductName, int OrgAddressID, int LocationID, int TypeID, string ResourceType, out List<InventoryItemsBasket> InventoryItemsBasket)
        {
            long returnCode = -1;
            InventoryItemsBasket = new List<InventoryItemsBasket>();
            try
            {
                SqlCommand objCommand = Command.pGetResourceNamesCommand(OrgID, ProductName, OrgAddressID, LocationID, TypeID, ResourceType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out InventoryItemsBasket);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetResourceNames() in MasterDAL", ex);
            }
            return returnCode;
        }


        public long InsertBillOfMaterials(List<BillOfMaterials> lstBillOfMaterials, List<BillofMaterialDetails> lstBillOfMaterialDetails, out List<BillofMaterialDetails> lstBillofMaterialDetails)
        {
            long returncode = -1;

            lstBillofMaterialDetails = new List<BillofMaterialDetails>();
            try
            {

                DataTable dtBillofMaterials = UDT_DAL.ConvertToUDTBillOfMaterials(lstBillOfMaterials);
                DataTable dtMaterialDetails = UDT_DAL.ConvertToUDTBillOfMaterialDetails(lstBillOfMaterialDetails);

                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                cmd = Command.pInsertBillofMaterialsCommand(dtBillofMaterials, dtMaterialDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstBillofMaterialDetails);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertCasuality", ex);
            }
            return returncode;
        }



        public long GetServiceMaster(int OrgID, string SearchType, out List<BillofMaterialDetails> lstBillofMaterials)
        {
            long returnCode = -1;
            lstBillofMaterials = new List<BillofMaterialDetails>();
            try
            {
                SqlCommand objCommand = Command.pGetServiceandResourceMasterCommand(OrgID, SearchType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillofMaterials);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetResourceNames() in GetServiceMaster", ex);
            }
            return returnCode;
        }

        public long GetReasonTypes(Int16 pReasonCategoryID, out List<ReasonType> lstReasonTypes)
        {
            long returnCode = -1;
            lstReasonTypes = new List<ReasonType>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetReasonTypesCommand(pReasonCategoryID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReasonTypes);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Master_DAL GetReasonTypes", ex);
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

        public long GetReasonMaster(Int16 pReasonCategoryID, int pReasonTypeID, string ReasonCode, out List<ReasonMaster> lstReasonMaster)
        {
            long returnCode = -1;
            lstReasonMaster = new List<ReasonMaster>();
            SqlCommand cmd = new SqlCommand();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.pGetReasonMasterCommand(pReasonCategoryID, pReasonTypeID, ReasonCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReasonMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetReasonMaster", ex);
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

        public long SaveReasonMaster(long pReasonID, int pReasonTypeID, string pReason, string pReasonCode, string pStatus, long pCreatedBy, string pSaveUpdate, out string pResult, string ExtCmt)
        {
            long returnCode = -1;
            pResult = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveReasonMasterCommand(pReasonID, pReasonTypeID, pReason, pReasonCode, pStatus, pCreatedBy, pSaveUpdate, out pResult,ExtCmt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    pResult = cmd.Parameters["@pResult"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveReasonMaster", ex);
            }
            return returnCode;
        }

        public long GetTestMasterDropDownValues(Int32 pOrgID, out List<InvDeptMaster> lstDept, out List<InvSampleMaster> lstSample, out List<InvestigationSampleContainer> lstAdditive, out List<InvestigationMethod> lstMethod, out List<InvPrincipleMaster> lstPrinciple, out List<MetaValue_Common> lstResultValue, out List<MetaValue_Common> lstSubCategory, out List<Role> lstRoles, out List<InvInstrumentMaster> lstInstrument, out List<Products> lstKit, out List<InvClientMaster> lstInvClientMaster, out List<ReasonMaster> lstReasonMaster, out List<MetaValue_Common> lstCategory, out List<InvestigationHeader> lstHeader,out List<ShippingConditionMaster> lstSampleCondition)
        {
            long returnCode = -1;
            lstDept = new List<InvDeptMaster>();
            lstSample = new List<InvSampleMaster>();
            lstAdditive = new List<InvestigationSampleContainer>();
            lstMethod = new List<InvestigationMethod>();
            lstPrinciple = new List<InvPrincipleMaster>();
            lstResultValue = new List<MetaValue_Common>();
            lstSubCategory = new List<MetaValue_Common>();
            lstRoles = new List<Role>();
            lstInstrument = new List<InvInstrumentMaster>();
            lstKit = new List<Products>();
            lstInvClientMaster = new List<InvClientMaster>();
            lstReasonMaster = new List<ReasonMaster>();
            lstCategory = new List<MetaValue_Common>();
            lstHeader = new List<InvestigationHeader>();
            lstSampleCondition =new List<ShippingConditionMaster>();
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTestMasterDropDownValuesCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDept);
                            }
                            if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSample);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstAdditive);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstMethod);
                            }
                            else if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPrinciple);
                            }
                            else if (rsCount == 5)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstResultValue);
                            }
                            else if (rsCount == 6)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSubCategory);
                            }
                            else if (rsCount == 7)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstRoles);
                            }
                            else if (rsCount == 8)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInstrument);
                            }
                            else if (rsCount == 9)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstKit);
                            }
                            else if (rsCount == 10)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvClientMaster);
                            }
                            else if (rsCount == 11)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstReasonMaster);
                            }
                            else if (rsCount == 12)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCategory);
                            }
                            else if (rsCount == 13)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstHeader);
                            }
                            else if (rsCount == 14)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSampleCondition);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                        returnCode = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetTestMasterDropDownValues", ex);
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

        public long GetTestCodingScheme(Int32 pOrgID, String pType, String pSearchText, out List<CodingScheme> lstCodingScheme)
        {
            long returnCode = -1;
            lstCodingScheme = new List<CodingScheme>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTestCodingSchemeCommand(pOrgID, pType, pSearchText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCodingScheme);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetTestCodingScheme", ex);
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

        public long GetRemarkDetails(String pRemarksType, String pSearchText, out List<Remarks> lstRemarks)
        {
            long returnCode = -1;
            lstRemarks = new List<Remarks>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetRemarkDetailsCommand(pRemarksType, pSearchText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstRemarks);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetRemarkDetails", ex);
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

        public long InsertICDCodes(List<ICDCodes> LSTICDCodes, out List<ICDCodes> ICDCodes)
        {
            long returncode = -1;

            ICDCodes = new List<ICDCodes>();
            try
            {

                DataTable dtICDCodess = UDT_DAL.ConvertToUDTICDCode(LSTICDCodes);
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                cmd = Command.PInsertICDCodesCommand(dtICDCodess, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out ICDCodes);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertCasuality", ex);
            }
            return returncode;
        }

        public long GetClientHistory(long ClientID, int OrgID, out List<ClientMaster_HIST> lstClientMaster_HIST)
        {
            long returnCode = -1;
            lstClientMaster_HIST = new List<ClientMaster_HIST>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetClientHistoryCommand(ClientID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstClientMaster_HIST);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetClientHistory", ex);
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

        public long GetServiceForConsumption(long PatientID, long VisitID, long ServiceID, out List<SurgeryOrderedServices> lstOrderedServices, out List<BillOfMaterials> lstBillofMeterials)
        {
            long returnCode = -1;
            lstOrderedServices = new List<SurgeryOrderedServices>();
            lstBillofMeterials = new List<BillOfMaterials>();
            try
            {
                SqlCommand objCommand = Command.PGetServicesForConsumptionCommand(PatientID, VisitID, ServiceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrderedServices);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBillofMeterials);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetResourceNames() in GetServiceMaster", ex);
            }
            return returnCode;

        }

        public long InsertResourceConsumption(List<ResourceConsumption> LSTResourceConsumption, out List<ResourceConsumption> lstResourceConsumption)
        {
            long returncode = -1;

            lstResourceConsumption = new List<ResourceConsumption>();
            try
            {

                DataTable dtResourceConsumption = UDT_DAL.ConvertToUDTResourceConsumption(LSTResourceConsumption);
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                cmd = Command.pInsertResourceConsumptionCommand(dtResourceConsumption, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstResourceConsumption);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertCasuality", ex);
            }
            return returncode;
        }

        public long GetTaxforClient(int pOrgID, long ClientID, out List<ClientMaster> lstTax)
        {
            long returnCode = -1;
            lstTax = new List<ClientMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetTaxforClientCommand(pOrgID, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstTax);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientMaster", ex);
            }
            return returnCode;
        }

        public long SaveAndUpdateDiscountPolicy(int OrgID, string PolicyName, long CreatedBy,
            List<DiscountPolicyMapping> lstDiscountPolicyMapping)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dtRateCardDiscount = UDT_DAL.ConvertToRateCardDiscount(lstDiscountPolicyMapping);
                cmd = Command.pSaveAndUpdateDiscountPolicyCommand(OrgID, PolicyName, CreatedBy, dtRateCardDiscount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveAndUpdateRateCardDiscount", ex);
            }
            return returncode;
        }

        public long GetDiscountPolicyMapping(int OrgID, long PolicyID, out List<DiscountPolicyMapping> lstDiscountPolicyMapping)
        {
            long returnCode = -1;
            lstDiscountPolicyMapping = new List<DiscountPolicyMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetDiscountPolicyMappingCommand(OrgID, PolicyID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDiscountPolicyMapping);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetRateCardDiscountDetails", ex);
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



        public long GetAmbulanceDetails(string prefixText, int Orgid, out List<Ambulance> lstAmbulance)
        {

            long returnCode = -1;
            SqlCommand cmd = Command.pGetAmbulanceDetailsCommand(prefixText, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstAmbulance = new List<Ambulance>();

            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAmbulance);
            }

            return returnCode;
        }


        public long GetDriverName(string prefixText, int Orgid, out List<EmployeeRegMaster> lstDriverMaster)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetEmployeeTypeMasterCommand(prefixText, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstDriverMaster = new List<EmployeeRegMaster>();

            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDriverMaster);
            }

            return returnCode;
        }

        public long GetAMBLocation(string prefixText, out List<Localities> lstLocation)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetAMBLocationCommand(prefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstLocation = new List<Localities>();

            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLocation);
            }

            return returnCode;
        }
        public long SaveAndDeleteReasonMapping(string Stype, List<TaskActionOrgMapping> lstTaskActionOrgMapping, int orgid, int reasontype)
        {
            long returnCode = -1;
            DataTable DtTaskActionOrgMapping = UDT_DAL.ConvertToTaskActionOrgMapping(lstTaskActionOrgMapping);
            SqlCommand cmd = Command.pSaveAndDeleteReasonMappingCommand(Stype, DtTaskActionOrgMapping, orgid, reasontype, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing SaveAndDeleteReasonMapping Master_DAL", ex);
            }
            return returnCode;
        }

        public long GetCommunicationConfig(Int32 pOrgID, String pType, out List<CommunicationConfig> lstCommunicationConfig)
        {
            long returnCode = -1;
            lstCommunicationConfig = new List<CommunicationConfig>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetCommunicationConfigCommand(pOrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCommunicationConfig);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetCommunicationConfig", ex);
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


        public long GetFeeTypeAttributes(string prefixText, string contextKey, int OrgID, out List<FeeTypeAttributes> lstFeeTypeAttributes)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetFeeTypeAttributesCommand(prefixText, contextKey, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstFeeTypeAttributes = new List<FeeTypeAttributes>();

            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFeeTypeAttributes);
            }

            return returnCode;
        }
        public long GetGroupValues(int orgid, string typeName, out List<MetaValue_Common> lstmetavalue)
        {

            long returnCode = -1;
            lstmetavalue = new List<MetaValue_Common>();
            SqlCommand objCommand = Command.pGetMetaValuesCommand(typeName, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstmetavalue);
            }
            return returnCode;

        }

        public long GetInstrumentName(int orgid, out List<InvInstrumentMaster> lstInvInst)
        {
            long returnCode = -1;
            lstInvInst = new List<InvInstrumentMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInstrumentNameCommand(orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvInst);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInstrumentName", ex);
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



        public long GetDeviceInstrumentDetails(int orgid, string InstrumentName, out List<DeviceIntegrationOrgMapping> lstInvInst, out List<DeviceIntegrationOrgMapping> lstInvInst1)
        {

            long returnCode = -1;
            lstInvInst = new List<DeviceIntegrationOrgMapping>();
            lstInvInst1 = new List<DeviceIntegrationOrgMapping>();
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetDeviceInstrumentDetailsCommand(orgid, InstrumentName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvInst);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvInst1);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetDeviceInstrumentDetails", ex);
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


        public long GetDeviceInstrumentDetailsEdit(int orgid, string DeviceID, string TestCode, long InvestigationID, out List<DeviceIntegrationOrgMapping> lstInvInst)
        {

            long returnCode = -1;
            lstInvInst = new List<DeviceIntegrationOrgMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetDeviceInstrumentDetailsEditCommand(orgid, DeviceID, TestCode, InvestigationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvInst);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetDeviceInstrumentDetails", ex);
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



        public long SaveAndUpdateDeviceIntegration(int OrgID, string DeviceID, long DeviceMappingID, string TestCode, long InvestigationID, string InstrumentName, int ValueId, string Formula, string IsActive)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd = Command.pInsertDeviceIntegrationDetailsCommand(OrgID, DeviceID, DeviceMappingID, TestCode, InvestigationID, InstrumentName, ValueId, Formula, IsActive, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveAndUpdateDeviceIntegration", ex);
            }
            return returncode;
        }

        public long SaveCodingScheme(int orgid, int CodeTypeID, List<CodingSchemeMaster> lstCodingSchemeMaster, List<CodingSchemeOrgMapping> lstCodingSchemeOrgMapping)
        {

            long returncode = -1;

            try
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dtCodingSchemeMaster = UDT_DAL.ConvertToUDTCodingSchemeMaster(lstCodingSchemeMaster);
                DataTable dtCodingSchemeOrgMapping = UDT_DAL.ConvertToUDTCodingSchemeOrgMapping(lstCodingSchemeOrgMapping);
                cmd = Command.pInsertCodingSchemeCommand(orgid, CodeTypeID, dtCodingSchemeMaster, dtCodingSchemeOrgMapping, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine DbEngine = new DBEngine())
                {
                    returncode = DbEngine.ExecuteNonQuery(cmd);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveCodingScheme", ex);
            }
            return returncode;
        }


        public long GetCodingSchemeName(int pOrgID, string PkgName, string Type, int InvID, out List<CodingSchemeMaster> CSM)
        {
            long returnCode = -1;
            CSM = new List<CodingSchemeMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetCodingSchemeNameCommand(pOrgID, PkgName, Type, InvID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out CSM);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetCodingSchemeName", ex);
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




        public long DeleteCodingScheme(int Orgid, int CodeTypeID)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pDeleteCodingSchemeNameCommand(Orgid, CodeTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DeleteCodingScheme", ex);
            }
            return returncode;

        }

        public long GetCodingSchemeMaster(string CodingSchemaName, int OrgID, out List<CodingSchemeMaster> lstCodingSchemeMaster)
        {
            long returnCode = -1;
            lstCodingSchemeMaster = new List<CodingSchemeMaster>();
            SqlCommand objCommand = Command.pGetCodingSchemeMasterCommand(CodingSchemaName, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            //SqlCommand objCommand = Command.pGetAmountReceivedDetailCommand(BankName, ChequeorCardNumber, OrgID);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCodingSchemeMaster);
                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while  GetPatientVisitInvestigation in Patient_DAL", ex);
            }
            return returnCode;


        }

        public long GetRouteNames(int pOrgID, string Code, string prefixText, int ZoneID, out List<Localities> lstLocalities)
        {
            long returnCode = -1;
            lstLocalities = new List<Localities>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pgetRouteDetailsCommand(pOrgID, Code, prefixText, ZoneID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstLocalities);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL MetaValues", ex);
            }
            return returnCode;
        }

        public long GetZoneDetails(int pOrgID, string Code, string prefixText, int HubID, out List<Localities> lstLocalities)
        {
            long returnCode = -1;
            lstLocalities = new List<Localities>();
            SqlCommand cmd = new SqlCommand();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.pgetZoneDetailsCommand(pOrgID, Code, prefixText, HubID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLocalities);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL MetaValues", ex);
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


        public long GetDoctorName(int orgID, int deptID, int roleID, out List<InvOrgAuthorization> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<InvOrgAuthorization>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDoctorNameCommand(orgID, deptID, roleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPhysician);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL MetaValues", ex);
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



        public long GetDeptName(int orgID, int roleID, out List<InvDeptMaster> lstDept)
        {
            long returnCode = -1;
            lstDept = new List<InvDeptMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDeptNameCommand(orgID, roleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDept);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL MetaValues", ex);
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


        public long GetLoginDept(int LoginID, int OrgID, int RoleID, out List<InvDeptMaster> lstDept)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstDept = new List<InvDeptMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetLoginDeptCommand(LoginID, OrgID, RoleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDept);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL MetaValues", ex);
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

        public long InsertCreditDebitSummary(List<CreditDebitSummary> CrDr, int OrgID, out long ReceiptNo)
        {
            //CrDr = new List<CreditDebitSummary>();
            long returnCode = -1;
            ReceiptNo = -1;
            DataTable dtCreditDebit = UDT_DAL.ConvertToCreditDebitSummary(CrDr);
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            cmd = Command.pInsertCreditDebitSummaryCommand(dtCreditDebit, UDT_DAL.ConvertToUDT_Context(globalContextDetails), OrgID, out ReceiptNo);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                ReceiptNo = Convert.ToInt32(cmd.Parameters["@ReceiptNo"].Value);
            }
            //if (ds.Tables[0].Rows.Count > 0)
            //{                    

            //}

            return returnCode;
        }

        public long GetCreditDebitSummary(long ClientID, string FrmDate, string ToDate, int OrgId, int PageSize, int currentPageNo, out int totalRows, out List<CreditDebitSummary> lstCreditDebit)
        {
            long returnCode = -1;
            totalRows = -1;
            IDataReader dataReader = null;
            lstCreditDebit = new List<CreditDebitSummary>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetCreditDebitSummaryCommand(ClientID, FrmDate, ToDate, OrgId, PageSize, currentPageNo, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCreditDebit);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in master DAL GetCreditDebitSummary", ex);
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

        public long GetClientValidation(int WClientID, string WClientType, string WReferenceID, string WType, int WPatientID, out List<CreditDebitSummary> lstCreditDebit)
        {
            long returnCode = -1;
            lstCreditDebit = new List<CreditDebitSummary>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                cmd = Command.pGetClientValidationCommand(WClientID, WClientType, WReferenceID, WType, WPatientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCreditDebit);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL MetaValues", ex);
            }
            return returnCode;
        }

        public long GetReasonMasterCrDr(int OrgID, out List<ReasonMaster> lstReasonMaster)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstReasonMaster = new List<ReasonMaster>();
            try
            {
                SqlCommand cmd = Command.pGetReasonMasterCrDrCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReasonMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In masterDAL GetReasonMasterCrDr", ex);
            }
            return returnCode;
        }

        public long GetCreditDebitSummaryforprint(long Clientid, long AuthorizedId, int orgidprint, out List<CreditDebitSummary> lstCreditInsertPrint)
        {
            long returnCode = -1;

            lstCreditInsertPrint = new List<CreditDebitSummary>();
            try
            {
                SqlCommand objCommand = Command.pGetCreditDebitSummaryPrintCommand(Clientid, AuthorizedId, orgidprint, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCreditInsertPrint);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL MetaValues", ex);
            }
            return returnCode;
        }
        public long GetrefPhysician(long refcode, int OrgID, string Category, DateTime FrmDate, DateTime ToDate, out List<BillingDetails> lstBillingDetails)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PgetReferingPhysicanRateCommand(refcode, OrgID, Category, FrmDate, ToDate);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get refPhysician in MasterDAL", ex);
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

        public long DeleteOutsourceDocDetails(List<TRFfilemanager> lstTRF)
        {
            long returnCode = -1;
            DataTable DtTRFfilemanager = UDT_DAL.ConvertToTRFfilemanager(lstTRF);
            SqlCommand cmd = Command.pDeleteOutsourceDocDetailsCommand(DtTRFfilemanager, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing DeleteOutsourceDocDetails Master_DAL", ex);
            }
            return returnCode;
        }


        public long GetOutsourceDocDetails(long Patientid, long Visitid, int pOrgID, string pType, out List<TRFfilemanager> lstTRF)
        {

            long returnCode = -1;
            lstTRF = new List<TRFfilemanager>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetOutsourceDocDetailsCommand(Patientid, Visitid, pOrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTRF);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get GetOutsourceDocDetails", ex);
            }
            return returnCode;

        }

        public long GetClientAndRefPhyAndLocation(int SearchTypeID, string PrefixText, int OrgID, out List<ClientMaster> lstClientMaster)
        {
            long returnCode = -1;
            lstClientMaster = new List<ClientMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetClientAndRefPhyAndLocationCommand(SearchTypeID, PrefixText, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstClientMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetClientAndRefPhyAndLocation() in MasterDAL", ex);
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


        public long GetAddresBookDetails(int SearchType, int SearchTypeID, int OrgID, out List<OrganizationAddress> lstOragnizationAddress)
        {
            long returnCode = -1;
            lstOragnizationAddress = new List<OrganizationAddress>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetAddresBookDetailsCommand(SearchType, SearchTypeID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOragnizationAddress);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetAddresBookDetails() in MasterDAL", ex);
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

        public long LoadTaxDetails(int OrgID, out List<Taxmaster> lstTaxmaster)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTaxmaster = new List<Taxmaster>();
            try
            {
                SqlCommand cmd = Command.pGet_ddlTaxDetailsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTaxmaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading LoadTaxDetails() in MasterDAL", ex);
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

        public long SaveInterpretationNotes(Int32 pInvID, String pType, String pNotes)
        {
            long returnCode = -1;
            try
            {

                SqlCommand cmd = Command.pSaveInterpretationNotesCommand(pInvID, pType, pNotes, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (TransactionScope tranScope = new TransactionScope())
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmd);
                    }
                    tranScope.Complete();
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveInterpretationNotes in Master_DAL", ex);
            }
            return returnCode;
        }
        public long GetTestCodingDetails(Int32 pOrgID, String pSearchType, out List<CodingScheme> lstTestCodingDetails)
        {
            long returnCode = -1;
            lstTestCodingDetails = new List<CodingScheme>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTestCodingDetailsCommand(pOrgID, pSearchType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTestCodingDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In Master DAL GetTestCodingDetails", ex);
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
        public long GetInterpretationNotes(Int32 pID, String pType, out List<NameValuePair> lstInterpretationNotes)
        {
            long returnCode = -1;
            lstInterpretationNotes = new List<NameValuePair>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInterpretationNotesCommand(pID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInterpretationNotes);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In Master DAL GetInterpretationNotes", ex);
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

        public long GetInvLocationMapping(int orgID, out List<MetaValue_Common> lstType, out List<OrganizationAddress> lstOrgLocation)
        {
            long returncode = -1;
            lstType = new List<MetaValue_Common>();
            lstOrgLocation = new List<OrganizationAddress>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetInvLocationMappingCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstType);
                            }
                            else if (rsCount == 1)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstOrgLocation);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Exception Occured in GetInvLocationMapping in Master_DAL", ex);
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

        public long GetProcessingOrgLocation(int OrgID, string OrgName,string Type, out List<OrganizationAddress> lstProcessingLocation)
        {
            long returncode = -1;
            lstProcessingLocation = new List<OrganizationAddress>();
            try
            {

                SqlCommand cmd = Command.pGetProcessingOrgLocationCommand(OrgID, OrgName,Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstProcessingLocation);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Exception occured in GetProcessingLocation in Master_BL", ex);
            }
            return returncode;
        }

        public long UpdateRateCardDetails(Int32 OrgID, List<RateCardMaster> lstRateCardDetails, out List<RateCardMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            lstInvClientMaster = new List<RateCardMaster>();
            DataTable dtRateCardData = UDT_DAL.ConvertToRateCardBulkUdate(lstRateCardDetails);
            try
            {
                SqlCommand cmd = Command.PinsertBulkRateforTestsCommand(dtRateCardData, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvClientMaster);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetBarcodeDetails", ex);
            }
            return returnCode;
        }
        #region Sample Workflow
        public long GetSampleSubType(int OrgID, long GroupTypeID, out List<InvSampleMaster> lstInvSampleMaster)
        {

            long returnCode = -1;
            lstInvSampleMaster = new List<InvSampleMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetSampleSubTypeCommand(OrgID, GroupTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvSampleMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetSampleSubType", ex);
            }
            return returnCode;
        }
        #endregion
        #region 
        public long GetSampleType(int OrgID, long LocationID, out List<InvSampleGroupMaster> lstInvSampleGroupMaster)
        {

            long returnCode = -1;
            lstInvSampleGroupMaster = new List<InvSampleGroupMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetSampleTypeCommand(OrgID, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvSampleGroupMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetSampleType", ex);
            }
            return returnCode;

        }
        #endregion

        #region Remarks
        public long InsertRemarks(string RemarkType, string RemarkCode, string Remark, out long returnCode)
        {
            //lstremark = new List<Remarks>();
            returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetInsertRemarksCommand(RemarkType, RemarkCode, Remark,UDT_DAL.ConvertToUDT_Context(globalContextDetails), out returnCode);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt32(cmd.Parameters["@ReturnCode"].Value);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Insert Remarks", ex);
            }
            return returnCode;

        }
        public long UpdateRemarks(string RemarkType, int RemarkID, string Remarktext, string RemarkCode, out long returnCode)
        {
            // lstremark = new List<Remarks>();
            returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pUpdateRemarksCommand(RemarkType, RemarkID, Remarktext, RemarkCode,UDT_DAL.ConvertToUDT_Context(globalContextDetails), out returnCode);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt32(cmd.Parameters["@ReturnCode"].Value);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Update Remarks", ex);
            }
            return returnCode;
        }
        #endregion


        //#region sample Archival Master
        //public long GetSampleType(int OrgID, long LocationID, out List<InvSampleGroupMaster> lstInvSampleGroupMaster)
        //{

        //    long returnCode = -1;
        //    lstInvSampleGroupMaster = new List<InvSampleGroupMaster>();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd = Command.pGetSampleTypeCommand(OrgID, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //        DataSet ds = new DataSet();
        //        using (DBEngine dbEngine = new DBEngine())
        //        {
        //            dbEngine.ExecuteDataSet(cmd, out ds);
        //        }
        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvSampleGroupMaster);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error While GetSampleType", ex);
        //    }
        //    return returnCode;

        //}
        //#endregion
        #region MedicalRemarks
        public long GetMedicalComments(long Invid, string TxtValue, int OrgID, out List<InvRemarks> lstInvRemarks)
        {

            long returnCode = -1;
            lstInvRemarks = new List<InvRemarks>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetMedicalCommentsCommand(Invid, TxtValue, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvRemarks);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get refPhysician", ex);
            }
            return returnCode;

        }
        #endregion

        public long GetAutoComments(long Invid, string CommentCode, out List<InvestigationBulkData> lstInvRemarks)
        {

            long returnCode = -1;
            lstInvRemarks = new List<InvestigationBulkData>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetAutoCommentsCommand(Invid, CommentCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvRemarks);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetAutoComments", ex);
            }
            return returnCode;

        }
        #region LibraryCode
        public long GetInvNames(long InvId, string InvName, out List<InvestigationBulkData> lstInvBulk, out List<InvestigationBulkData> lstInvBulk1)
        {

            long returnCode = -1;

            lstInvBulk = new List<InvestigationBulkData>();
            lstInvBulk1 = new List<InvestigationBulkData>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetInvNamesCommand(InvId, InvName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvBulk);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInvBulk1);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetInvNames", ex);
            }
            return returnCode;

        }
        public long InsertInvValues(List<InvestigationBulkData> lstInvBulkValues, out long returnCode)
        {
            returnCode = -1;

            DataTable DTvalues = UDT_DAL.ConvertToUDTInvBulkDataValues(lstInvBulkValues);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetInsertInvValuesCommand(DTvalues, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt32(cmd.Parameters["@ReturnCode"].Value);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetInvNames", ex);
            }
            return returnCode;
        }
        public long DeleteInvBulkData(int InvID, string InvName, string InvValue, int InvStatus, string pCommend)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetDeleteBulkValuesCommand(InvID, InvName, InvValue, InvStatus, pCommend, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine(false))
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
                //returnCode = Convert.ToInt32(cmd.Parameters["@returnStatus"].Value);
            }
            return returnCode;

        }
        #endregion
        public long GetSamplesForAdditionalTube(int orgID, int ID, string Type, out List<InvSampleMaster> lstInvSampleMaster, out List<AdditionalTubeMapping> lstAdditionalTubeMapping)
        {
            long returnCode = -1;
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstAdditionalTubeMapping = new List<AdditionalTubeMapping>();
            try
            {
                SqlCommand cmd = Command.pGetSamplesForAdditionalTubeCommand(orgID, ID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvSampleMaster);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstAdditionalTubeMapping);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetSamplesForAdditionalTube using pGetSamplesForAdditionalTubeCommand sp", ex);
            }

            return returnCode;

        }
        public long CheckExistingBarcode(int OrgID, string Barcodenumber, out List<PatientInvSample> lstBarcode)
        {
            long returnCode = -1;
            lstBarcode = new List<PatientInvSample>();
            try
            {
                SqlCommand cmd = Command.pCheckExistingBarcodeCommand(OrgID, Barcodenumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBarcode);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL CheckExistingBarcode", ex);
            }
            return returnCode;
        }
        public long InsertCoupenValueMaster(List<CouponValueMaster> pCVM, out   List<CouponValueMaster> lstOutputMsg)
        {
            long returncode = -1;
            lstOutputMsg = new List<CouponValueMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt = UDT_DAL.ConvertToCouponValueMaster(pCVM);

                cmd = Command.pInsertCoupenTestValuemasterCommand(dt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstOutputMsg);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Master", ex);
            }
            return returncode;
        }
        public long GetCoupenTestValuemaster(out   List<CouponValueMaster> lstCouponValueMaster, int orgid, string TestName, string CouponBarcode, long PhysicianId)
        {
            long returncode = -1;
            lstCouponValueMaster = new List<CouponValueMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                cmd = Command.pGetCoupenTestValuemasterCommand(orgid, TestName, CouponBarcode, PhysicianId);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                } if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstCouponValueMaster);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Master", ex);
            }
            return returncode;
        }
        public long UpdateCoupenTestValuemaster(List<CouponValueMaster> pCVM)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt = UDT_DAL.ConvertToCouponValueMaster(pCVM);

                cmd = Command.pUpdateCoupenTestValuemasterCommand(dt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Master", ex);
            }
            return returncode;
        }
        #region Round Master

        public long SaveRoundManagement(string roundName, string isActive, string startLocation, string endLocation, DateTime createdAt, string startTime, string endTime, string logisticEmployee, string roundSheetTime, string value, List<RoundMasterAttributes> lstRoundAttributes, int OrgID, long roundId, out long roundId1)
        {
            long returnCode = -1;
            DataTable dtRoundMasterAttributes = UDT_DAL.ConvertToRoundMasterAttributes(lstRoundAttributes);
            SqlCommand cmd = Command.pSaveRoundManagementCommand(roundName, isActive, startLocation, endLocation, createdAt, startTime, endTime, logisticEmployee, roundSheetTime, value, dtRoundMasterAttributes, OrgID, roundId, out roundId1, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
                roundId1 = Convert.ToInt64(cmd.Parameters["@pRoundID1"].Value);

            }
            return returnCode;
        }

        public long GetRoundNameList(string prefixText, int pOrgID, string searchType, out List<RoundMaster> lstRoundMaster)
        {
            long returnCode = -1;
            lstRoundMaster = new List<RoundMaster>();
            SqlCommand cmd = Command.pGetRoundNameListCommand(prefixText, pOrgID, searchType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRoundMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientListForQuickBill in Inventory_DAL", ex);
            }
            return returnCode;
        }

        public long GetRoundNameAttributes(string prefixText, int pOrgID, string searchType, long roundId, out List<RoundMasterAttributes> lstRoundAttributes)
        {
            long returnCode = -1;
            lstRoundAttributes = new List<RoundMasterAttributes>();
            try
            {

                SqlCommand cmd = Command.pGetRoundNameAttributesCommand(prefixText, pOrgID, searchType, roundId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRoundAttributes);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Master_DAL- GetRoundNameAttributes", ex);
            }

            return returnCode;
        }

        public long DeleteRoundMasterClient(int ID, long roundID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pDeleteRoundMasterClientCommand(ID, roundID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In Master_DAL DeleteRoundMasterClient", ex);
            }
            return returnCode;
        }

        public long CheckRoundName(string prefixText, int pOrgID, out int Id)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pCheckRoundNameCommand(prefixText, pOrgID, out Id, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    Id = Convert.ToInt32(cmd.Parameters["@pId"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing CheckRoundName in Master_DAL", excep);
            }
            return returnCode;
        }

        #endregion
        #region Manage Referral Policy
        public long SaveReferrealPolicy(int OrgID, List<ManageReferralPolicy> lstManageReferralPolicy)
        {
            long returnCode = -1;

            DataTable dtManageReferralPolicy = new DataTable();
            dtManageReferralPolicy = UDT_DAL.ConvertToUDTReferralPolicy(lstManageReferralPolicy);

            SqlCommand cmd = Command.pSaveReferralPolicyCommand(OrgID, dtManageReferralPolicy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing Save Referral Policy Master_DAL", ex);
            }
            return returnCode;
        }
        public long Getreferralpolicy(out  List<ManageReferralPolicy> lstManageReferralPolicy)
        {
            long returnCode = -1;
            lstManageReferralPolicy = new List<ManageReferralPolicy>();
            try
            {
                SqlCommand objCommand = Command.pGetreferralpolicyCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstManageReferralPolicy);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading pGetCustomerTODdetails() in MasterDAL", ex);
            }
            return returnCode;
        }
      
        public long GetReferralCategory(out  List<ManageReferralPolicy> lstManageReferralPolicy)
        {
            long returnCode = -1;
            lstManageReferralPolicy = new List<ManageReferralPolicy>();
            try
            {
                SqlCommand objCommand = Command.pGetReferralCategoryCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstManageReferralPolicy);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetReferralCategory() in MasterDAL", ex);
            }
            return returnCode;
        }
        #endregion
        public long GetInvGroupforDept(int OrgID, out List<InvOrgGroup> lstDptGroup)
        {
            long lresult = -1;
            lstDptGroup = new List<InvOrgGroup>();
            SqlCommand cmd = Command.pGetGroupDepartmentMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstDptGroup);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Department Group DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetGroupInvestigationMaster(int OrgID, string displayText, out List<InvOrgGroup> lstDptGroup)
        {
            long lresult = -1;
            lstDptGroup = new List<InvOrgGroup>();
            SqlCommand cmd = Command.pGetGroupInvestigationMasterCommand(OrgID, displayText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstDptGroup);

                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Department Group DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetInvestigationforDepartment(int OrgID, out List<InvDeptMaster> lstDpt)
        {
            long lresult = -1;
            lstDpt = new List<InvDeptMaster>();
            SqlCommand cmd = Command.pGetInvestigationDepartmentMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstDpt);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Department DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long pUpdateInvandGroupSequenceMaster(List<InvOrgGroup> lstInvOrgDT, int pOrgID, int pDptID)
        {

            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pUpdateInvandGroupSequenceMasterCommand(UDT_DAL.ConvertToInvGroupMapMaster(lstInvOrgDT), pOrgID, pDptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveAndUpdateDeviceIntegration", ex);
            }
            return returncode;
        }
        public long GetAutoPackageContentandRflex(int OrgID, string packgeContent, out List<InvOrgGroup> lstReflex)
        {
            //MANAGE PACKAGE CONTENT AND REFELEX MODULE

            long returnCode = -1;
            long lresult = -1;
            lstReflex = new List<InvOrgGroup>();
            SqlCommand cmd = Command.pGetAutoPackageContentandRflexCommand(OrgID, packgeContent, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstReflex);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PackageRefelex DAL" + cmd.CommandText, ex);
            }
            return lresult;

        }

        public long GetFetchPackageContentandRflex(int OrgID, string packgeName, string packgeCode, out List<InvOrgGroup> lstReflex)
        {
            //MANAGE PACKAGE CONTENT AND REFELEX MODULE

            long returnCode = -1;
            long lresult = -1;
            lstReflex = new List<InvOrgGroup>();
            SqlCommand cmd = Command.pGetFetchPackageContentandRflexCommand(OrgID, packgeName, packgeCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstReflex);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PackageRefelex DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long pUpdatePackageMappingContent(string pType, int pOrgID, int PPackageId, string PAdditionalTubeCode, List<InvOrgGroup> lstReflex)
        {
            //MANAGE PACKAGE CONTENT AND REFELEX MODULE

            long returncode = -1;
            long lresult = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable dtReflexDetails = UDT_DAL.ConvertInvGroupMapMasterPackage(lstReflex);
            cmd = Command.pUpdatePackageMappingContentCommand(pType, pOrgID, PPackageId, PAdditionalTubeCode, dtReflexDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PackageRefelex DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long pGetReflexPackege(string pType, long pInvId, long pID, long pOrgID, out List<InvOrgGroup> lstReflex)
        {
            //MANAGE CAPTURE HISTORY ATTRIBUTES
            lstReflex = new List<InvOrgGroup>();
            long returncode = -1;
            long lresult = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetReflexPackegeCommand(pType, pInvId, pID, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstReflex);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CaptureHistory DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long UpdatePackagesDetails(InvOrgGroup objorgrouppackages, DataTable dtCodingSchemeMaster, int CutOffTimeValue, string CutOffTimeType, string SubCategory, short ScheduleType, string IsOptionalTest)
        {
            long returncode = 0;
            SqlCommand cmd = Command.pUpdatePackagesDetailsCommand(objorgrouppackages.OrgGroupID, objorgrouppackages.OrgID, objorgrouppackages.DisplayText, objorgrouppackages.Remarks, objorgrouppackages.Status, objorgrouppackages.Packagecode, objorgrouppackages.ModifiedBy, objorgrouppackages.PrintSeparately, dtCodingSchemeMaster, CutOffTimeValue, CutOffTimeType, objorgrouppackages.Gender, objorgrouppackages.IsServicetaxable, UDT_DAL.ConvertToUDT_Context(globalContextDetails), SubCategory, ScheduleType, IsOptionalTest);
            cmd.Parameters.Add("@ret", SqlDbType.Int);
            cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returncode = Convert.ToInt64(cmd.Parameters["@ret"].Value);
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while updating Updatepackages", ex);
            }

            return returncode;
        }
        public long GetInsertInvGroupDetails(List<InvestigationOrgMapping> pInvMap, string groupName, int dptID, long gHeader, int DdlCase, string type, long OrgID, string ModifiedBy, string GroupCode, string Remarks, string Status, string Pkgcode, string printSeparately, DataTable dtCodingSchemeMaster, int CutOffTimeValue, string CutOffTimeType, string Gender, string IsServiceTaxable, short ScheduleType, string IsOptionalTest)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable InvMap = UDT_DAL.ConvertToInvestigationAdminRate(pInvMap);
            cmd = Command.pGetInsertInvGroupDetailsCommand(InvMap, groupName, dptID, gHeader, DdlCase, OrgID, type, ModifiedBy, out returnCode, GroupCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails), Remarks, Status, Pkgcode, printSeparately, dtCodingSchemeMaster, CutOffTimeValue, CutOffTimeType, Gender, IsServiceTaxable, pInvMap[0].SubCategory, ScheduleType, IsOptionalTest);
            using (DBEngine dBEngine = new DBEngine(false))
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt32(cmd.Parameters["@returnStatus"].Value);
            }
            return returnCode;
        }
        /*AB Code for Rolling Advance*/
        public long GetRollingAdvanceClients(out List<ClientMaster> lstAttributesDetails)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstAttributesDetails = new List<ClientMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetRollingAdvanceClientsCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstAttributesDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
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
        /*added By jagatheesh  for Test wise Analyzer report*/
        public long GetAnalyzerName(int orgid, out List<InvInstrumentMaster> lstInvInst)
        {
            long returnCode = -1;
            lstInvInst = new List<InvInstrumentMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetAnalyzerNameCommand(orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvInst);

                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetAnalyzerName For TestWiseAnalyzerReport", ex);
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
        /* End Added */ 

        public long GetRolesbyName(string Roles, long orgID, out List<Role> lstrole)
        {
            long returnCode = -1;
            lstrole = new List<Role>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetRolesCommand(Roles,orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstrole);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetRolesbyName", ex);
            }
            return returnCode;
        }
		public long GetTATSchedulecode(int OrgID, string PrefixText, out List<TATSchedule> lstTATSchedulecode)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTATSchedulecode = new List<TATSchedule>();
            try
            {
                SqlCommand cmd = Command.pGetTATSchedulecodeCommand(OrgID, PrefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTATSchedulecode);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetTATSchedulecode() in MasterDAL", ex);
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
        public long GetTATSchedulecategoryItem(int OrgID, string PrefixText, string SearchType, out List<CodingScheme> lstTATSchedulecategoryItem)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTATSchedulecategoryItem = new List<CodingScheme>();
            try
            {

                SqlCommand cmd = Command.pGetTATSchedulecategoryItemCommand(OrgID, PrefixText, SearchType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTATSchedulecategoryItem);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetTATSchedulecategoryItem() in MasterDAL", ex);
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
public long SaveTestforTAT(List<Tatschedulemapping> lstTATAdded)
        {
            long lstresult = -1;
            SqlCommand cmdSaveTestforTAT = Command.pSaveTestforTATCommand(UDT_DAL.ConvertToUDTTatschedulemapping(lstTATAdded), UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lstresult = dbEngine.ExecuteNonQuery(cmdSaveTestforTAT);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving SaveTestforTAT. Query: " + cmdSaveTestforTAT.CommandText, ex);
            }
            return lstresult;
        }


        public long DeleteTestforTAT(List<Tatschedulemapping> lstDeleteAdded)
        {
            long lstresult = -1;
            SqlCommand cmdDeleteTestforTAT = Command.pDeleteTestforTATCommand(UDT_DAL.ConvertToUDTTatschedulemapping(lstDeleteAdded), UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lstresult = dbEngine.ExecuteNonQuery(cmdDeleteTestforTAT);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving DeleteTestforTAT. Query: " + cmdDeleteTestforTAT.CommandText, ex);
            }
            return lstresult;
        }
        public long LoadtatTestname(int OrgID, int TatID, out List<CodingScheme> lstLoadCategoryTestname)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstLoadCategoryTestname = new List<CodingScheme>();
            try
            {
                SqlCommand cmd = Command.pLoadtatTestnameCommand(OrgID, TatID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLoadCategoryTestname);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading LoadtatTestname() in MasterDAL", ex);
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
        public long LoadtatClientTestname(int OrgID, int TatID, int ClientID, out List<CodingScheme> lstLoadCategoryTestname)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstLoadCategoryTestname = new List<CodingScheme>();
            try
            {
                // SqlCommand cmd = Command.pLoadtatTestnameCommand(OrgID, TatID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                SqlCommand cmd = Command.pLoadtatClientTestnameCommand(OrgID, TatID, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLoadCategoryTestname);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading LoadtatTestname() in MasterDAL", ex);
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
        public long LoadTATLogisticsDetails(int OrgID, long LocID, out List<Tatlogisticdetails> lstTatlogistic)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTatlogistic = new List<Tatlogisticdetails>();
            try
            {
                SqlCommand cmd = Command.pLoadTATLogisticsDetailsCommand(OrgID, LocID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTatlogistic);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetOrgLocationDetails() in MasterDAL", ex);
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
        public long SaveTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
        {
            long lstresult = -1;
            SqlCommand cmd = Command.pSaveTATLogisticsDetailsCommand(UDT_DAL.ConvertToUDTTatlogisticdetails(lstTatlogisticdetails), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lstresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving SaveTATLogisticsDetails. Query: " + cmd.CommandText, ex);
            }
            return lstresult;
        }
        public long UpdateTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
        {
            long lstresult = -1;
            SqlCommand cmd = Command.pUpdateTATLogisticsDetailsCommand(UDT_DAL.ConvertToUDTTatlogisticdetails(lstTatlogisticdetails), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lstresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving UpdateTATLogisticsDetails. Query: " + cmd.CommandText, ex);
            }
            return lstresult;
        }
        public long EditTATLogisticsDetails(int Logisticdetailsid, out List<Tatlogisticdetails> lstTatlogistic)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTatlogistic = new List<Tatlogisticdetails>();
            try
            {
                SqlCommand cmd = Command.pEditTATLogisticsDetailsCommand(Logisticdetailsid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTatlogistic);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading LoadTATLogisticsDetails() in MasterDAL", ex);
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
        public long DeleteTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
        {
            long lstresult = -1;
            SqlCommand cmd = Command.pDeleteTATLogisticsDetailsCommand(UDT_DAL.ConvertToUDTTatlogisticdetails(lstTatlogisticdetails), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lstresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving PDeleteTATLogisticsDetails. Query: " + cmd.CommandText, ex);
            }
            return lstresult;
        }
        public long pGetLoginNamesbyRole(long RoleID, long orgID, out List<Login> lstlogin)
        {
            long returnCode = -1;
            lstlogin = new List<Login>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetLoginNamesbyRoleCommand(RoleID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstlogin);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetLoginNamesbyRole", ex);
            }
            return returnCode;
        }
		public long GetHealthLabData(string MessageControlId, DateTime Datefrom, DateTime DateTo, string ExternalVisitId,int MessageId,  out List<HLMessages> lstHLM)
        {
            long returnCode = -1;
            lstHLM = new List<HLMessages>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetHealthLabDataCommand(MessageControlId, Datefrom, DateTo, ExternalVisitId,MessageId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstHLM);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetHealthLabData in Master DAL", ex);
            }
            return returnCode;
        }
        public long pGetWidgetNames(long RoleID, out List<Widgetmaster_Custom> lst)
        {
            long returnCode = -1;
            lst = new List<Widgetmaster_Custom>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetWidgetNamesCommand(RoleID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lst);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetWidgetNames", ex);
            }
            return returnCode;
        }
		 public long GetErrorMsgByMsgId(long Id, out List<HLMessageErrorDetails> lstHLM)
        {
            long returnCode = -1;
            lstHLM = new List<HLMessageErrorDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetErrorMsgByMsgIdCommand(Id, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstHLM);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetErrorMsgByMsgId in Master DAL", ex);
            }
            return returnCode;
        }
		public long GetHL7PatientDetail(long MessageId, DateTime Datefrom, DateTime DateTo, out List<HLMessagePatientIDDetails> lstHLM)
        {
            long returnCode = -1;
            lstHLM = new List<HLMessagePatientIDDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetHL7PatientDetailCommand(MessageId, Datefrom, DateTo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstHLM);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetHL7PatientDetail in master DAL", ex);
            }
            return returnCode;
        }

        public long GetHL7OrderedDetails(long MessageId, DateTime Datefrom, DateTime DateTo, out List<HLMessageOBRDetails> lstHLM)
        {
            long returnCode = -1;
            lstHLM = new List<HLMessageOBRDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetHL7OrderedDetailsCommand(MessageId, Datefrom, DateTo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstHLM);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetHL7OrderedDetails in master DAL", ex);
            }
            return returnCode;
        }
        public long pGetWidgetsbyRoleandUser(long RoleID, long LoginID, long orgID, out List<Widgetmaster_Custom> lstwst)
        {
            long returnCode = -1;
            lstwst = new List<Widgetmaster_Custom>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetWidgetsbyroleanduserCommand(RoleID,LoginID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstwst);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetWidgetsbyRole", ex);
            }
            return returnCode;
        }

        public long pGetWidgetsuserdetails(long RoleID, long LoginID, long orgID, out List<WidgetUserDetails> lstwst)
        {
            long returnCode = -1;
            lstwst = new List<WidgetUserDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetWidgetsuserdetailsCommand(RoleID, LoginID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstwst);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetWidgetsuserdetails", ex);
            }
            return returnCode;
        }
		public long GetHL7VisitDetails(long MessageId, DateTime Datefrom, DateTime DateTo, out List<HLMessageORCDetails> lstHLM)
        {
            long returnCode = -1;
            lstHLM = new List<HLMessageORCDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetHL7VisitDetailsCommand(MessageId, Datefrom, DateTo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstHLM);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetHL7OrderedDetails in master DAL", ex);
            }
            return returnCode;
        }
        public long SaveHL7MessageFiles(string FileName, string FilePath, int OrgID, long LocationID, long CreatedBy, DateTime ModifiedAt, long ModifiedBy)
        {
            long returncode = -1;
            SqlCommand objCommand = Command.pInsertHL7MessageFilesCommand(FileName, FilePath, OrgID, LocationID, CreatedBy, ModifiedAt, ModifiedBy,
            UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            //objCommand.Parameters.Add("@Return", SqlDbType.Int);
            //objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returncode = dbEngine.ExecuteNonQuery(objCommand);

                    //returncode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveTRFdetails Patient_DAL", excep);
            }
            return returncode;

        }
        public long pSaveWidgetsbyroleanduser(List<WidgetRoleMapping_Custom> lst)
        {
            long returncode = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable dt = UDT_DAL.Convertwidgetroleanduserdetail(lst);
            cmd = Command.pSaveWidgetsbyroleanduserCommand(dt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pSaveWidgetsbyroleanduser DAL" + cmd.CommandText, ex);
            }
            return returncode;
        }
		public long GetHL7HealthLabDataDetail(long MessageId, DateTime Datefrom, DateTime DateTo, out List<HLMessagePatientIDDetails> lstHLM, out List<HLMessageORCDetails> lstHLMORC, out List<HLMessageOBRDetails> lstHLMORD)
        {
            long returnCode = -1;
            lstHLM = new List<HLMessagePatientIDDetails>();
            lstHLMORC = new List<HLMessageORCDetails>();
            lstHLMORD = new List<HLMessageOBRDetails>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetHL7HealthLabDataDetailCommand(MessageId, Datefrom, DateTo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstHLM);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[1], out lstHLMORC);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[2], out lstHLMORD);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetHL7HealthLabDataDetail in master DAL", ex);
            }
            return returnCode;
        }
        public long pGetWidgetcountmis(long OrgID, long LocationID, long DeptID, DateTime FromDate, DateTime ToDate,long RoleID,out DataTable billing,out DataTable TestDetails, out DataTable analyserdetails, out DataTable sampledetails,out DataTable NearingTatDetails,out DataTable DelayedTATDetails,out DataSet dsCountDetails)
        {
            long returnCode = -1;
            billing = new DataTable();
            TestDetails = new DataTable();
            analyserdetails = new DataTable();
            sampledetails = new DataTable();
            NearingTatDetails = new DataTable();
            DelayedTATDetails = new DataTable();
            dsCountDetails = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetWidgetcountmisCommand(OrgID,LocationID,DeptID,FromDate,ToDate,RoleID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    dsCountDetails = ds;
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    billing = ds.Tables[0];
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    TestDetails = ds.Tables[1];
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    analyserdetails = ds.Tables[2];
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    sampledetails = ds.Tables[3];
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    NearingTatDetails = ds.Tables[4];
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    DelayedTATDetails = ds.Tables[5];
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetWidgetcountmis DAL" + cmd.CommandText, ex);
            }
            return returnCode;
        }



        public DataSet pGetMISReport(int OrgID, int LocationID, int DepartmentID, DateTime fromDate, DateTime toDate, int checkDiff, string WCode, string WGCode)
        {
            DataSet ds = new DataSet();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetDashboardMISReportCommand(OrgID, LocationID, DepartmentID, fromDate, toDate, checkDiff, WCode, WGCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    //System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                    // returncode = Attune.Podium.Common.Utilities.ConvertTo<DashboardContent>(IdR, out InstrumentList);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pGetMISReport", e);
            }
            return ds;
        }
        public DataSet pGetWorkLoadMISReport(long OrgID, long LocationID, int DepartmentID, DateTime fromDate, DateTime toDate, string WorkloadCode)
        {
            DataSet ds = new DataSet();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetDashboardGeneralStatisticsMISCommand(OrgID, LocationID, DepartmentID, fromDate, toDate, WorkloadCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                   
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                    
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pGetWorkLoadMISReport", e);
            }
            return ds;
        }
		
		/***********Alex Starts***************/
			public long pgetScanIn(int deptId, string Barcode, int SampleType, out List<SampleBatchScanOutDetails> scanout, out string ReturnValue)
        {
            long returnCode = -1;
            scanout = new List<SampleBatchScanOutDetails>();
            // objScanOutDetails = null;
            DataSet ds = new DataSet();
            ReturnValue = string.Empty;
            //DataTable dt = UDT_DAL.ConvertToUDTScanOutDetails(ScanIndept);
            try
            {
                SqlCommand cmd = Command.pgetscanindetailsCommand(Barcode, SampleType, deptId, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out ReturnValue);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out scanout);
                    }
                }
                ReturnValue = cmd.Parameters["@ReturnValue"].Value.ToString();
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While pgetScanInDept in Master_DAL", ex);
            }
            return returnCode;
        }
		
		  public long pgetSampleDetailsInSacanInOut(string Barcode, long deptid, out List<PatientInvSample> scanout)
        {
            long returnCode = -1;
            scanout = new List<PatientInvSample>();
            // objScanOutDetails = null;
            DataSet ds = new DataSet();
            //DataTable dt = UDT_DAL.ConvertToUDTScanOutDetails(ScanIndept);
            try
            {
                SqlCommand cmd = Command.pGetSampleBatchScanInScanOutDetailsCommand(Barcode, deptid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out scanout);
                    }
                }
                if (ds.Tables.Count > 1)
                {
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        //returnCode = Utilities.ConvertTo(ds.Tables[1], out objScanOutDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in pgetSampleDetailsInSacanInOut at master DAL", ex);
            }
            return returnCode;
        }
		
		  public long SampleTrackingDetails(string Barcode, int deptId, out List<SampleBatchScanOutDetails> scanout)
        {
            scanout = new List<SampleBatchScanOutDetails>();
            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetSampleTrackingDetailsCommand(Barcode, deptId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out scanout);
                    }
                }
                if (ds.Tables.Count > 1)
                {
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        //returnCode = Utilities.ConvertTo(ds.Tables[1], out objScanOutDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Master DAL at SampleTrackingDetails", ex);
            }
            return returnCode;
        }
		
		 public long ScanInHistory(string BarcodeNumber, int deptId, int BarcodeType, out List<SampleBatchScanOutDetails> scanout)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            scanout = new List<SampleBatchScanOutDetails>();
            try
            {

                SqlCommand cmd = Command.pGetScanInHistoryCommand(BarcodeNumber, deptId, BarcodeType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out scanout);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In Master DAL ScanInHistory", ex);
            }
            return returnCode;
        }
		
		public long ScanOut(string BarcodeNumber, int DDLno, out List<SampleBatchScanOutDetails> scanout, out string BatchNo)
        {
            long returnCode = -1;
            scanout = new List<SampleBatchScanOutDetails>();
            BatchNo = string.Empty;

            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetScanOutDetailsCommand(BarcodeNumber, DDLno, out BatchNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out scanout);


                }
                BatchNo = cmd.Parameters["@ReturnBatch"].Value.ToString();
                // returnCode = 5;
                // return 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While ScanOut in Master_DAL", ex);
            }
            return returnCode;
        }
		
		#region Error Flag Mapping        

        public long GetAllInstrumentInfo(int orgId, int locId, out List<InstrumentInfoErrorFlag> instrumentInfos)
        {
            instrumentInfos = new List<InstrumentInfoErrorFlag>();

            long lResult = -1;
            SqlCommand cmd = Command.pGetAllInstrumentsCommand(orgId, locId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                lResult = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out instrumentInfos);
                }
            }
            return lResult;
        }

        public long GetAllErrorFlagInfos(int orgId, int locId, out List<DeviceErrorFlags> errorMapingItems)
        {
            errorMapingItems = new List<DeviceErrorFlags>();

            long lResult = -1;
            SqlCommand cmd = Command.pGetAllDeviceErrorFlagCommand(orgId, locId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                lResult = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out errorMapingItems);
                }
            }
            return lResult;
        }

        public long GetAllErrorFlagInfosByBarCode(string barCode, out List<DeviceErrorFlags> errorMapingItems)
        {
            errorMapingItems = new List<DeviceErrorFlags>();

            long lResult = -1;
            SqlCommand cmd = Command.pGetAllDeviceErrorFlagByBarcodeCommand(barCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                lResult = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out errorMapingItems);
                }
            }
            return lResult;
        }

        public long SaveErrorFlagMapping(int orgId, List<DeviceErrorFlags> errorMapingItems)
        {
            long lResult = -1;
            SqlCommand cmd = Command.pErrorFlagMappingMasterCommand(orgId, UDT_DAL.ConvertToErrorMappingInfo(errorMapingItems), UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                //DataSet ds = new DataSet();
                dBEngine.ExecuteTransactionalNonQuery(cmd);

            }
            return lResult;
        }
		 #endregion Error Flag Mapping
		 
		 
		 #region PageContext
		    public long FetchGetPageNames(long OrgId, out List<PageContext> lstPageName)
        {
            long returnCode = -1;
            lstPageName = new List<PageContext>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pgetPageNamesCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPageName);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchGetPageNames in Master_DAL", ex);
            }
            return returnCode;
        }


        public long FetchGetPageContext(long OrgId, out List<PageContext> lstPageName)
        {
            long returnCode = -1;
            lstPageName = new List<PageContext>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pgetPageContextCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPageName);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchGetPageContext in Master_DAL", ex);
            }
            return returnCode;
        }

        public long InsertPageContext(long pOrgID, PageContext pagecontext)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertPageContextCommand(pOrgID, pagecontext.PageContextID, pagecontext.PageName, pagecontext.ButtionValue, pagecontext.ButtonName, pagecontext.PageID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertPageContext", ex);
            }
            return returncode;
        }

        public long DeletePageContextbyId(int Id)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pDeletePageContextCommand(Id, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While DeletePageContextbyId in Master_DAL", ex);
            }
            return returnCode;
        }

        public long FetchActionManagerType(out List<ActionManagerType> lst)
        {
            long returnCode = -1;
            lst = new List<ActionManagerType>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pgetActionManagerTypeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lst);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchActionManagerType in Master_DAL", ex);
            }
            return returnCode;
        }

        public long InsertActionManagerType(ActionManagerType actionmanagerype)
        {
            long returncode = 0;
            int ReturnValue = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertActionManagerTypeCommand(actionmanagerype.ActionType, actionmanagerype.IsDisplay, actionmanagerype.ActionCode, actionmanagerype.Type, actionmanagerype.LangCode, actionmanagerype.ActionTypeID, out ReturnValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returncode = Convert.ToInt32(cmd.Parameters["@ReturnValue"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchPageContextbyId in Master_DAL", ex);
            }
            return returncode;
        }

        public long DeleteActionManagerType(int Id)
        {
            long returncode = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PDeleteActionManagerTypeCommand(Id, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While DeleteActionManagerType in Master_DAL", ex);
            }
            return returncode;
        }

        public long FetchActionTemplateType(out List<ActionTemplateType> lst)
        {
            long returnCode = -1;
            lst = new List<ActionTemplateType>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetActionTemplateTypeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lst);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchActionTemplateType in Master_DAL", ex);
            }
            return returnCode;
        }

        public long InsertActionTemplateType(ActionTemplateType actiontemplatetype, out int ReturnValue)
        {
            long returncode = 0;
            ReturnValue = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertActionTemplateTypeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails), actiontemplatetype.TemplateTypeID, actiontemplatetype.TemplateType, out ReturnValue);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                    ReturnValue = Convert.ToInt32(cmd.Parameters["@ReturnValue"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While InsertActionTemplateType in Master_DAL", ex);
            }
            return returncode;
        }

        public long DeleteActionTemplateType(int Id)
        {
            long returncode = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pDeleteActionTemplateTypeCommand(Id, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While DeleteActionTemplateType in Master_DAL", ex);
            }
            return returncode;
        }

        public long FetchLanguageMaster(out List<LanguageMaster> lst)
        {
            long returnCode = -1;
            lst = new List<LanguageMaster>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetLanguageCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lst);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchLanguageMaster in Master_DAL", ex);
            }
            return returnCode;
        }

        public long FetchActionTemplate(out List<ActionTemplate> lst)
        {
            long returnCode = -1;
            lst = new List<ActionTemplate>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pgetActionTemplateCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lst);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchActionTemplate in Master_DAL", ex);
            }
            return returnCode;
        }

        public long InsertActionTemplate(ActionTemplate actiontemplate, out int ReturnValue)
        {
            long returncode = 0;
            ReturnValue = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertActionTemplateCommand(actiontemplate.TemplateID, actiontemplate.TemplateTypeID, actiontemplate.Template, actiontemplate.Subject,
                    actiontemplate.TemplateName, actiontemplate.AttachmentName, out ReturnValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                    ReturnValue = Convert.ToInt32(cmd.Parameters["@ReturnValue"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While InsertActionTemplate in Master_DAL", ex);
            }
            return returncode;
        }

        public long DeleteActionTemplate(int Id)
        {
            long returncode = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pdeleteActionTemplateCommand(Id, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While DeleteActionTemplate in Master_DAL", ex);
            }
            return returncode;
        }


        public long FetchPagecontextActionMapping(out List<PageContextActionMapping> lst)
        {
            long returnCode = -1;
            lst = new List<PageContextActionMapping>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetContextActionMappingCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lst);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchPagecontextActionMapping in Master_DAL", ex);
            }
            return returnCode;
        }

        public long InsertPagecontextActionMapping(PageContextActionMapping actionmapping, out int ReturnValue)
        {
            long returncode = 0;
            ReturnValue = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertPageContextActionMappingCommand(actionmapping.PageContextID, actionmapping.RoleID, actionmapping.ActionTypeID, actionmapping.TemplateID, actionmapping.ContextType, actionmapping.AdditionalContext,
                    actionmapping.Description, actionmapping.IsAttachment, actionmapping.MappingID, actionmapping.Category, out ReturnValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                    ReturnValue = Convert.ToInt32(cmd.Parameters["@ReturnValue"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While InsertPagecontextActionMapping in Master_DAL", ex);
            }
            return returncode;
        }

        public long DeletePagecontextActionMapping(int Id)
        {
            long returncode = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pDeletePageContextActionMappingCommand(Id, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While DeletePagecontextActionMapping in Master_DAL", ex);
            }
            return returncode;
        }
		 #endregion PageContext
		
		/***********Alex Ends***************/
//added by sudha1
        public long GetPageType(int OrgId, out List<MetaData> lstMetaData)
        {
            long returnCode = -1;
            lstMetaData = new List<MetaData>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetPageTypefromMetadateCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstMetaData);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchGetPageNames in Master_DAL", ex);
            }
            return returnCode;
        }





        //added by sudha -1 for langCode
        public long GetPageLang(out List<LanguageMaster> lstLanguageMaster)
        {
            long returnCode = -1;
            lstLanguageMaster = new List<LanguageMaster>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetLanguageCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLanguageMaster);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchGetPageNames in Master_DAL", ex);
            }
            return returnCode;
        }






        //added by sudha 2
        public long GetPageStatus(int OrgId, out List<InvSampleStatusmaster> lstInvSampleStatusmaster)
        {
            long returnCode = -1;
            lstInvSampleStatusmaster = new List<InvSampleStatusmaster>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetStatusfromInvSampleStatusmasterCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvSampleStatusmaster);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchGetPageNames in Master_DAL", ex);
            }
            return returnCode;
        }



        //added by sudha for gridload in dummyPage3
        public long GetIInvStatusOrgPageMapping(int OrgId, out List<InvStatusOrgPageMapping> lstInvStatusOrgPageMapping)
        {
            long returnCode = -1;
            lstInvStatusOrgPageMapping = new List<InvStatusOrgPageMapping>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pgetInvStatusOrgPageMappingCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvStatusOrgPageMapping);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While FetchGetPageNames in Master_DAL", ex);
            }
            return returnCode;

        }



        ////added by sudha for dummy page 4

        public long InsertInvStatusOrgPageMapping(InvStatusOrgPageMapping objInvStatusOrgPageMapping, out long returnCode)
        {
            returnCode = -1;
            SqlCommand cmd = Command.pInsertInvStatusOrgPageMappingCommand(objInvStatusOrgPageMapping.OrgID, objInvStatusOrgPageMapping.PageType, objInvStatusOrgPageMapping.IsDefault, objInvStatusOrgPageMapping.Displaytext, objInvStatusOrgPageMapping.StatusID,objInvStatusOrgPageMapping.LangCode, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    // returnCode = Convert.ToInt64(cmd.Parameters["@ReturnCode"].Value);
                    // returnStatus
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing InsertAnalyzerType Master_DAL", ex);
            }
            return returnCode;
        }



        ////added by sudha for dummy page 5 Update




        public long UpdateInvStatusOrgPageMapping(InvStatusOrgPageMapping objInvStatusOrgPageMapping, out long returnCode)
        {
            returnCode = -1;
            SqlCommand cmd = Command.pUpdateInvStatusOrgPageMappingCommand(objInvStatusOrgPageMapping.PageType, objInvStatusOrgPageMapping.StatusID, objInvStatusOrgPageMapping.IsDefault, objInvStatusOrgPageMapping.Displaytext, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@ReturnCode"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing InsertAnalyzerType Master_DAL", ex);
            }
            return returnCode;
        }

        // added by sudha for NewUpdate button 5-

        public long NewUpdateInvStatusOrgPageMapping(InvStatusOrgPageMapping objInvStatusOrgPageMapping, out long returnCode)
        {
            returnCode = -1;
            SqlCommand cmd = Command.pNewUpdateInvStatusOrgPageMappingCommand(objInvStatusOrgPageMapping.InvStatusOrgPageMappingID, objInvStatusOrgPageMapping.PageType, objInvStatusOrgPageMapping.StatusID, objInvStatusOrgPageMapping.IsDefault, objInvStatusOrgPageMapping.Displaytext, out returnCode, objInvStatusOrgPageMapping.LangCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing InsertAnalyzerType Master_DAL", ex);
            }
            return returnCode;
        }


        // added by sudha for NewUpdate button 5-








        //addded by sudha for deletion 6

        public long DeleteInvStatusOrgPageMapping(int refid, out long returnCode)
        {
            returnCode = -1;
            SqlCommand cmd = Command.pDeleteInvStatusOrgPageMappingCommand(refid, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@ReturnCode"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing InsertAnalyzerType Master_DAL", ex);
            }
            return returnCode;
        }
/*Employee Intimation*/
        public long InsertEmployeeEmailSms(int OrgID, int ID, string NotificationType, string NotificationCategory, string Value, long CreatedBy, string EmailType)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //SqlCommand objCommand = Command.pInsertEmployeeEmailSmsCommand(OrgID, ID, NotificationType, NotificationCategory, Value, CreatedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd = Command.pInsertEmployeeEmailSmsCommand(OrgID, ID, NotificationType, NotificationCategory, Value, CreatedBy, EmailType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                //UDT_DAL.ConvertToUDT_Context(globalContextDetails
                // cmd = Command.PInsertEmployeeEmailSmsCommand(OrgID, ID, NotificationType, NotificationCategory, Value, CreatedBy);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Master", ex);
            }
            return returncode;
        }

        /*Employee Intimation*/
        public long GetEmployeeEmailSms(int Orgid, out List<AddressDetails> listCommunication)
        {
            IDataReader dataReader = null;
            long returnCode = -1;

            listCommunication = new List<AddressDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetEmployeeEmailSmsCommand(Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                //PGetEmployeeEmailSmsCommand(Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out listCommunication);

                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetCommuicationvisitDetails in Communication_DAL", ex);
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
//Added by Jegan - Product merge start
        #region Clinical History

        public long GetAllClinicalHistoryItems(int orgId, out List<History> historyMasterLst)
        {
            historyMasterLst = new List<History>();

            long lResult = -1;
            SqlCommand cmd = Command.pGetAllClinicalHistoryMasterCommand(orgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                lResult = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out historyMasterLst);
                }
            }
            return lResult;
        }

        public long SaveClinicalHistoryMaster(List<History> historyMstrLst)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pClinicalHistoryManagerCommand(UDT_DAL.ConvertToClinicalHistoryMaster(historyMstrLst),
                UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                //DataSet ds = new DataSet();
                dBEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = 0;
            }
            return returnCode;
        }

        public long GetAllClinicalHistoryMappingItems(int orgId, out List<InvMedicalDetailsMapping> historyMappingLst)
        {
            historyMappingLst = new List<InvMedicalDetailsMapping>();

            long lResult = -1;
            SqlCommand cmd = Command.pGetAllClinicalHistoryMappingCommand(orgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                lResult = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out historyMappingLst);
                }
            }
            return lResult;
        }

        public long SaveClinicalHistoryMapping(List<InvMedicalDetailsMapping> historyMappingLst)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pClinicalHistoryMappingManagerCommand(UDT_DAL.ConvertToClinicalHistoryMapping(historyMappingLst),
                UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                //DataSet ds = new DataSet();
                dBEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = 0;
            }
            return returnCode;
        }

        #endregion Clinical History
        //end

  public long InsertAnalyzerType(AnalyzerType ObjAnalyzerType, out long returnCode)
        {
            returnCode = -1;

            SqlCommand cmd = Command.pInsertAnalyzerTypeCommand(ObjAnalyzerType.Productid, ObjAnalyzerType.Productname, ObjAnalyzerType.Productdescription, ObjAnalyzerType.IsActive, ObjAnalyzerType.OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out  returnCode);
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@ReturnCode"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing InsertAnalyzerType Master_DAL", ex);
            }
            return returnCode;
        }
        public long GetAnalyzerType(out List<AnalyzerType> lstAnalyzerType)
        {

            long returncode = -1;
            IDataReader dataReader = null;


            lstAnalyzerType = new List<AnalyzerType>();
            try
            {

                SqlCommand cmd = new SqlCommand();
                //lstanalyzertype = new List<AnalyzerType>();


                cmd = Command.pGetAnalyzerTypeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstAnalyzerType);

                        dataReader.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetAnalyzerType DAL Master", ex);
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

  public long GetInstrumentNameDeviceMapping(int orgid, long Analyzertype, out List<InvInstrumentMaster> lstInvInst)
        {
            long returnCode = -1;
            lstInvInst = new List<InvInstrumentMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInstrumentNameDeviceMappingCommand(orgid, Analyzertype, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvInst);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInstrumentName", ex);
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

public long GetProductsIsNotActive(int OrgID, out List<InvInstrumentMaster> lstInvInstrumentMaster)
        {
            long returncode = -1;
            lstInvInstrumentMaster = new List<InvInstrumentMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetProductsIsNotActiveCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstInvInstrumentMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetProductsIsNotActive master dal", e);
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
		        public long SaveQuestionaryTemplate(long TemplateID,string TemplateName, string TemplateText, long InvestigationID, string InvType)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pSaveQuestionaryTemplateCommand(TemplateID,TemplateName, TemplateText, InvestigationID, InvType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {

                    returncode = dbEngine.ExecuteNonQuery(cmd);
                    
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pGetWorkLoadMISReport", e);
            }
            return returncode;
        }
        public long GetAllQuestionaryTemplates(long TemplateID, long InvestigationID, string InvType, string SType, out List<QuestionayTemplateDetails> lstTemplate, out List<QuestionayTemplateDetails> lstTemplateMap)
        {
            lstTemplate = new List<QuestionayTemplateDetails>();
            lstTemplateMap = new List<QuestionayTemplateDetails>(); 
            DataSet ds =  new  DataSet ();
            long returnCode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetQuestionaryTemplatesCommand(TemplateID, InvestigationID, InvType, SType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables.Count>0 && ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTemplate);
                }
                if (ds.Tables.Count>1 && ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstTemplateMap);
                }

                
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pGetWorkLoadMISReport", e);
            }
            return returnCode;
        }
        
		
		     /// <summary>
        /// Get the Action Type
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="lstTaskActions"></param>
        /// <returns></returns>
         public long pGetActionType(int roleID, out List<ActionManagerType> lstTaskActions)
         {
             long returncode = -1;
             lstTaskActions = new List<ActionManagerType>();
             DataSet ds = new DataSet();

             try
             {
                 SqlCommand cmd = Command.pGetActionTypeCommand(roleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                 using (DBEngine dbEngine = new DBEngine())
                 {
                     returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                 }
                 if (ds.Tables.Count > 0)
                 {
                     Utilities.ConvertTo(ds.Tables[0], out lstTaskActions);
                 }
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while executing pGetActionType Master_DAL", e);
             }
             return returncode;

         }
		 
		  /// <summary>
         /// Get the Notification table Details
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="LabNumber"></param>
        /// <param name="ActionType"></param>
        /// <param name="Status"></param>
        /// <param name="Location"></param>
        /// <param name="ClientName"></param>
        /// <param name="Reason"></param>
        /// <param name="CreatedFromDate"></param>
        /// <param name="CreatedToDate"></param>
        /// <param name="ReportingCenter"></param>
        /// <param name="ReportType"></param>
        /// <param name="Zone"></param>
        /// <param name="startRowIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRows"></param>
        /// <param name="lstNotificationMaster"></param>
         /// <returns>returns a list "lstNotificationMaster"</returns>
         public long pgetNotificationDetails(string Name, string LabNumber, string ActionType, string Status, string Location, string ClientName, string Reason, string CreatedFromDate, string CreatedToDate, string ReportingCenter, string ReportType, string Zone, int startRowIndex, int pageSize, out int totalRows, out List<NotificationMaster> lstNotificationMaster)
         {
             lstNotificationMaster = new List<NotificationMaster>();
             long returncode = -1;
             DataSet ds = new DataSet();
             IDataReader dataReader = null;
             totalRows = -1;

             try
             {
                 SqlCommand cmd = Command.pGetNotificationDetailsCommand(Name, LabNumber, ActionType, Status, Location, ClientName, Reason, CreatedFromDate, CreatedToDate, ReportingCenter, ReportType, Zone, startRowIndex, pageSize, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                 using (DBEngine dbEngine = new DBEngine())
                 {
                     dbEngine.ExecuteDataSet(cmd, out ds);
                 }
                 if (ds.Tables.Count > 0)
                 {
                     if (ds.Tables[0].Rows.Count > 0)
                     {
                         returncode = Utilities.ConvertTo(ds.Tables[0], out lstNotificationMaster);
                     }
                     Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
                 }
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while executing pgetNotificationDetails Master_DAL", e);
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

		 
	     /// <summary>
        /// Update Notificaton Status
        /// </summary>
        /// <param name="lstNotication"></param>
        /// <returns></returns>
         public long pUpdateNotificationStatus(List<Notifications> lstNotication)
         {
             long returnCode = -1;
             DataTable dtNotificationData = UDT_DAL.ConvertToNotificationUpdate(lstNotication);

             SqlCommand cmd = Command.pUpdateNotificationStatusCommand(dtNotificationData, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
             try
             {
                 using (DBEngine dbEngine = new DBEngine())
                 {
                     returnCode = dbEngine.ExecuteNonQuery(cmd);
                 }
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while saving pUpdateNotificationStatus Master_DAL", e);
             }
             return returnCode;
         }
#region Department sequence Number

        public long InsertSharedDeptDetails(long DeptID, List<RoleDeptMap> lstDept)
        {
            long lresult = -1;
            DataTable dTable = UDT_DAL.ConvertToUDTRole(lstDept);
            SqlCommand cmd = Command.pInsertSharedDeptCommand(DeptID, dTable, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
        public long SaveLocDepUserMap(long DeptID, long LocID, string defaults, long SeqNo, long OrgID, string InsUpdflag, List<RoleDeptMap> allChecked)
        {
            long lresult = -1;
            DataTable dTable = UDT_DAL.ConvertToUDTRole(allChecked);
            SqlCommand cmd = Command.pSaveLocDepUserMapCommand(DeptID, LocID, defaults, SeqNo, OrgID, InsUpdflag, dTable, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
        public long pUpdateSequenceNo(DataTable dtSequence, int pOrgID)
        {
            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pUpdateLoginSequenceCommand(pOrgID, dtSequence, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Refered count and Ordered count", ex);
            }

            return returnCode;
        }
        public long SaveLocationMap(int OrgID, int DeptID, string deptName, string Code, string deptcode, string CDisplay, string ChkPriSep, string AutoScan, string InsUpdfl, long shareable,bool IsclientSMS, List<Role> lstRoleLocation)
        {
            long returnCode = -1;
            DataTable dtlstLocation = UDT_DAL.ConvertToUDTRole(lstRoleLocation);
            try
            {
                SqlCommand objCommand = Command.pSaveDeptLocationMapCommand(OrgID, DeptID, deptName, Code, deptcode, CDisplay, ChkPriSep, AutoScan, InsUpdfl, shareable, IsclientSMS, dtlstLocation, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pSaveRoleDeptLocationMapCommand in PatientVisit_DAL", ex);
            }

            return returnCode;
        }

        public long GetDeptSigSeqMapLog(int OrgID, int DepID, int AddressID, out List<UserSigLocBasedDept> stUsLoDep)
        {
            long lresult = -1;
            stUsLoDep = new List<UserSigLocBasedDept>();
            IDataReader dataReader = null;

            try
            {
                SqlCommand cmd = Command.PGetDeptSeqLocCommand(OrgID, DepID, AddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out stUsLoDep);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Department DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }
        public long GetDeptSigSeqMap(int OrgID, out List<UserSigLocBasedDept> stUsLoDep)
        {
            long lresult = -1;
            stUsLoDep = new List<UserSigLocBasedDept>();
            IDataReader dataReader = null;

            try
            {
                SqlCommand cmd = Command.PGetDeptSeqCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out stUsLoDep);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Department DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }

        public long GetSharedDeptID(int OrgID, long DeptshareID, out List<InvDeptMaster> lstInvInst)
        {
            long lresult = -1;
            lstInvInst = new List<InvDeptMaster>();
            IDataReader dataReader = null;

            try
            {
                SqlCommand cmd = Command.pGetInvsharedDeptIDCommand(OrgID, DeptshareID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstInvInst);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSharedDept DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }

        public long GetManageDeptDetails(int orgid, out List<InvDeptMaster> lstInvInst)
        {

            long returnCode = -1;
            lstInvInst = new List<InvDeptMaster>();
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetManageDepartmentCommand(orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvInst);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetDeviceInstrumentDetails", ex);
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
        public long GetLocID(long DeptID, int OrgID, out List<OrganizationAddress> lstDeptID)
        {
            long returncode = -1;
            lstDeptID = new List<OrganizationAddress>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetLocationIDCommand(DeptID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
        public long GetSharedDept(int OrgID, out List<InvDeptMaster> lstInvInst)
        {
            long lresult = -1;
            lstInvInst = new List<InvDeptMaster>();
            IDataReader dataReader = null;

            try
            {
                SqlCommand cmd = Command.pGetSharedDeptCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstInvInst);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSharedDept DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }


        public long GetLogID(long DeptID, long LocID, int OrgID, out List<Users> lstUse)
        {
            long returncode = -1;
            lstUse = new List<Users>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetloginNameForDepSigCommand(DeptID, LocID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstUse);
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
        #endregion
		 

    }
}
