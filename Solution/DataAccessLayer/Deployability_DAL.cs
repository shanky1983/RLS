using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;

namespace Attune.Solution.DAL
{
    public class Deployability_DAL
    {
        ContextDetails globalContextDetails;
        public Deployability_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public Deployability_DAL()
        {
        }
        public long SaveFeeTypes(int DefaultOrgid, string DestOrgid, string Reset, List<InvestigationDetail> lstInvestigationDetail)
        {
            long returnCode = -1;
            DataTable dtInvestigationDetail = UDT_DAL.ConvertToInvestigationDetail(lstInvestigationDetail);

            SqlCommand cmd = Command.pSetLabForCopyingMastersCommand(DefaultOrgid, DestOrgid, Reset, dtInvestigationDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveFeeTypes in Investigation_DAL", ex);
            }
            return returnCode;
        }

        public long GetCopyMasterDetails(int OrgId, String FeeType, out List<InvestigationMaster> lstInvestigationMaster)
        {
            long result = -1;
            lstInvestigationMaster = new List<InvestigationMaster>();
            SqlCommand cmd = Command.PGetCopyMasterDetailsCommand(OrgId, FeeType);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationMaster);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMemberShipCardOTP Investigation_DAL", ex);
            }

            return result;
        }

        public long InsertDocData(List<FileUploadDetails> lstInvestigationDetail, DateTime UploadDate, String Reason)
        {

            long returnCode = -1;
            int OrgID = 0;

            try
            {
                DataTable dtInvestigationDetail = UDT_DAL.ConvertToFileUploadUDT(lstInvestigationDetail);
                DataTable dtGlobalDetail = UDT_DAL.ConvertToUDT_Context(globalContextDetails);
                //foreach (DataRow drOutput in dtInvestigationDetail.Rows)
                //{
                //    drOutput["DocFileUrl"] = drOutput["DocFileUrl"].ToString().Replace('E', '\n');
                //    //your remaining code
                //}
                foreach (DataRow row in dtGlobalDetail.Rows)
                {

                    OrgID = Convert.ToInt32(row["OrgID"]);

                }
                SqlCommand cmd = Command.pInsertDocUploadDetailsCommand(0, OrgID, 0, "Insert", "", dtInvestigationDetail, dtGlobalDetail, UploadDate, Reason);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertMetaData", ex);
            }
            return returnCode;
        }

        public long GetUploadDocDetail(int FileDetails, out List<FileUploadDetails> lstUploadDocDetail)
        {
            long returnCode = -1;
            lstUploadDocDetail = new List<FileUploadDetails>();
            DataTable dtGlobalDetail = UDT_DAL.ConvertToUDT_Context(globalContextDetails);
            SqlCommand cmd = Command.PgetRateDocumentUploadCommand(FileDetails, dtGlobalDetail);
            DataSet ds = new DataSet();
            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {
                    //returnCode = dbEngine.ExecuteNonQuery(cmd);
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstUploadDocDetail);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertMetaData", ex);
            }
            return returnCode;
        }
        public long InsertInvGrpPkgLog(int orgID, string testtype, string filename, int username, string status)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.PInsertInvGrpPkgLogCommand(orgID, testtype, filename, username, status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Insert data", ex);
            }
            return returnCode;
        }
        public long GetInvGrpPkgLog(int orgID, string type, int createdby, out List<InvCreateUpdate> lstloginfo)
        {
            long returnCode = -1;
            lstloginfo = new List<InvCreateUpdate>();
            try
            {
                SqlCommand cmd = Command.PGETInvGrpPkgLogCommand(orgID, type, createdby, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstloginfo);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get data", ex);
            }
            return returnCode;
        }

        public long GetRefillTestMaster(int orgID, string type, int createdby, int rateid, out List<Stage2_MHL_T_01_TESTMASTER> lstInvestigationMaster, out List<Stage2_MHL_T_02_GROUP_MASTER> lstInvGroupMaster, out List<Stage2_MHL_T_03_Package_Master> lstInvGroupMasterpkg, out List<Stage2_MHL_T_04_GROUP_TESTS> lstGroupContent, out List<Stage2_MHL_T_05_PACKAGE_TESTS> lstPackageContent, out List<Stage2_MHL_T_02_RATE_MASTER> lstRateMaster, out List<DeviceTestOrgMapping> lstDeviceTestMap, out List<PStage_Physician> lstStage_Physician, out List<Stage_LocationMaster> lstStage_LocationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<Stage2_MHL_T_01_TESTMASTER>();
            lstInvGroupMaster = new List<Stage2_MHL_T_02_GROUP_MASTER>();
            lstInvGroupMasterpkg = new List<Stage2_MHL_T_03_Package_Master>();

            lstPackageContent = new List<Stage2_MHL_T_05_PACKAGE_TESTS>();

            lstGroupContent = new List<Stage2_MHL_T_04_GROUP_TESTS>();

            lstRateMaster = new List<Stage2_MHL_T_02_RATE_MASTER>();
            lstStage_Physician = new List<PStage_Physician>();

            lstStage_LocationMaster = new List<Stage_LocationMaster>();

            //, out List<TblUserMaster> lstUserslstUsers = new List<TblUserMaster>();
            lstDeviceTestMap = new List<DeviceTestOrgMapping>();
            try
            {
                SqlCommand cmd = Command.PGetRefillTestMasterCommand(orgID, type, createdby, rateid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                cmd.CommandTimeout = 30 * 1000;
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (type.Equals("INV"))
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationMaster);
                }
                else if (type.Equals("GRP"))
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvGroupMaster);
                }
                else if (type.Equals("PKG"))
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvGroupMasterpkg);
                }
                else if (type.Equals("PKGCONTENT"))
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPackageContent);
                }
                else if (type.Equals("RateMaster"))
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRateMaster);
                }
                else if (type.Equals("DeviceTestMap"))
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeviceTestMap);
                }
                else if (type.Equals("PhysicianMaster"))
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstStage_Physician);
                }
                else if (type.Equals("LocationMaster"))
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstStage_LocationMaster);
                }
                else
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstGroupContent);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get data from GetRefillTestMaster", ex);
            }
            return returnCode;
        }

        public long getTestInsertUpdate(int ORGID, List<Stage2_MHL_T_02_GROUP_MASTER> lstGroupMaster, List<Stage2_MHL_T_03_Package_Master> lstPackageMaster, List<Stage2_MHL_T_01_TESTMASTER> lstInvestigationMaster, List<Stage2_MHL_T_05_PACKAGE_TESTS> lstPackageContent, List<Stage2_MHL_T_04_GROUP_TESTS> lstGroupContent)
        {

            long returnCode = -1;

            SqlCommand cmdInvestigation = new SqlCommand();

            DataTable dtGroupMaster = new DataTable();
            DataTable dtInvestigationMaster = new DataTable();
            DataTable dtPackageMaster = new DataTable();
            DataTable dtPackageMasterContent = new DataTable();
            DataTable dtGroupMasterContent = new DataTable();
            DataTable dtUsers = new DataTable();
            dtGroupMaster = UDT_DAL.ConvertToStage2_MHL_T_02_GROUP_MASTER(lstGroupMaster);
            dtPackageMaster = UDT_DAL.ConvertToStage2_MHL_T_03_Package_Master(lstPackageMaster);
            dtInvestigationMaster = UDT_DAL.ConvertToStage2_MHL_T_01_TESTMASTER(lstInvestigationMaster);
            dtPackageMasterContent = UDT_DAL.ConvertToStage2_MHL_T_05_PACKAGE_TESTS(lstPackageContent);
            dtGroupMasterContent = UDT_DAL.ConvertToStage2_MHL_T_04_GROUP_TESTS(lstGroupContent);




            cmdInvestigation = Command.PgetTestInsertUpdateCommand(ORGID, dtGroupMaster, dtPackageMaster, dtInvestigationMaster, dtPackageMasterContent, dtGroupMasterContent,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {


                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmdInvestigation);

                }

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving getTestInsertUpdate InvBulkDataUpload_DAL", e);
            }
            return returnCode;

        }


        public long GetInvGrpPkgError(out List<InvCreateUpdate> lsterrorinfo)
        {
            long returnCode = -1;
            lsterrorinfo = new List<InvCreateUpdate>();
            try
            {
                SqlCommand cmd = Command.PGetInvGrpPkgErrorCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lsterrorinfo);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GETDownLoadInvGrpPkgLog", ex);
            }
            return returnCode;
        }
        public long BulkUpdateRatesDetails(Int32 OrgID, List<RateCardMaster> lstRateCardDetails, out List<RateCardMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            lstInvClientMaster = new List<RateCardMaster>();
            DataTable dtRateCardData = UDT_DAL.ConvertToUDTInvBulkRate(lstRateCardDetails);
            try
            {
                SqlCommand cmd = Command.PBulkUpdateRatesCommand(dtRateCardData, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
        public long BulkInsertUpdateDeviceMapping(Int32 OrgID, List<DeviceTestOrgMapping> lstDeviceTestMap)
        {
            long returnCode = -1;

            DataTable dtDeviceTestMap = new DataTable();
            dtDeviceTestMap = UDT_DAL.ConvertToStage_DeviceMap_Template(lstDeviceTestMap);
            SqlCommand cmd = Command.PBulkUpdateDeviceMapCommand(dtDeviceTestMap,OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving BulkInsertUpdateDeviceMapping BulkInsertUpdateDeviceMapping_DAL", e);
            }
            return returnCode;
        }
        public long BulkInsertUserMaster(List<Stage_User_Template> lstUsers, out int DuplicateCount, out int InsertedCount)
        {
            DuplicateCount = -1;
            InsertedCount = -1;
            long returnCode = -1;

            DataTable dtUsers = new DataTable();


            dtUsers = UDT_DAL.ConvertToStage_User_Template(lstUsers);

            SqlCommand cmd = Command.Pget_UserMapCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails), dtUsers, out DuplicateCount, out InsertedCount);
            try
            {


                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    DuplicateCount = Convert.ToInt32(cmd.Parameters["@DuplicateCount"].Value.ToString());
                    InsertedCount = Convert.ToInt32(cmd.Parameters["@InsertedCount"].Value.ToString());
                }

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving BulkInsertUserMaster InvBulkDataUpload_DAL", e);
            }
            finally
            {

            }
            return returnCode;
        }
        public long GetAssociatedClientDetails(int OrgId, int ClientId, out List<ClientMaster> lstClientMaster)
        {
            long result = -1;
            lstClientMaster = new List<ClientMaster>();
            SqlCommand cmd = Command.pGetAssociatedClientCommand(OrgId, ClientId);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstClientMaster);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMemberShipCardOTP Investigation_DAL", ex);
            }

            return result;
        }
        public long GetOrderableLocation(int OrgId, out List<OrganizationAddress> lstLocationsMaster, out List<EmployeeMaster> lstEmployeeMaster)
        {
            long result = -1;
            lstLocationsMaster = new List<OrganizationAddress>();
            lstEmployeeMaster = new List<EmployeeMaster>();
            SqlCommand cmd = Command.pGetOrderableLocationCommand(OrgId);
            DataSet ds = new DataSet();
            try
            {


                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstLocationsMaster);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[1], out lstEmployeeMaster);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMemberShipCardOTP Investigation_DAL", ex);
            }

            return result;
        }
        public long GetAddressDetails(int OrgId, String PostalCode, out List<AddressDetails> lstAddressMaster)
        {
            long result = -1;
            lstAddressMaster = new List<AddressDetails>();
            SqlCommand cmd = Command.PGetAddressDetailsCommand(OrgId, PostalCode);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstAddressMaster);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMemberShipCardOTP Investigation_DAL", ex);
            }

            return result;
        }
        public long GetClientMasterDetails(int OrgId, int ClientId, String ClientCode, out List<ClientBasicGridDetails> lstClientMaster)
        {
            long result = -1;
            lstClientMaster = new List<ClientBasicGridDetails>();
            SqlCommand cmd = Command.pGetClientMasterDetailsCommand(OrgId, ClientCode, ClientId);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstClientMaster);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMemberShipCardOTP Investigation_DAL", ex);
            }

            return result;
        }
        public long SaveLocationPrintMapDetails(long pOrgID, string pCodestr, int pOrgAddressID, LocationPrintMap objLocationPrintMap)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveLocationPrintMapDetailsCommand(pOrgID, objLocationPrintMap.Code, pCodestr, objLocationPrintMap.PrinterName, pOrgAddressID);
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveLocationPrintMapDetails", ex);
            }
            return returnCode;
        }
        public long pDeleteLocationPrintMapDetails(long pOrgID, int pOrgAddressID)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pDeleteLocationPrintMapDetailsCommand(pOrgID, pOrgAddressID);
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteLocationPrintMapDetails", ex);
            }
            return returnCode;
        }
        public long GetLocationPrinter(int OrgID, int OrgAddressID,string PrinterType, out List<LocationPrintMap> lstLocation)
        {
            long returnCode = -1;
            lstLocation = new List<LocationPrintMap>();
            try
            {
                SqlCommand cmd = Command.pGetLocationPrinterCommand(OrgID, OrgAddressID, PrinterType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLocation);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetALLLocation in Invoice_DAL", ex);
            }

            return returnCode;

        }
        public long GetClientTabMappingDetails(out List<TabMaster> lstTabDetails)
        {
            lstTabDetails = new List<TabMaster>();
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pGetClientTabMappingDetailsCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTabDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetALLLocation in Invoice_DAL", ex);
            }

            return returnCode;

        }
        public long InsertInvoiceClientDetails(long ClientID,
                     string ClientCode,
                     string ClientName,
                     long ReportTemplateID,
                     string Attributes,
                     string Termsconditions,
                     string ReasonForUpdate,
                     DateTime ReportPrintFrom,
                     string TabDesiable,
                List<ClientBasicDetails> lstClientBasicDetails,
                List<AddressDetails> lstClientAddress,
                List<ClientAttributesDetails> lstClientAttributes,
                List<ClientCommunication> lstClientCommunication,
                List<ClientCreditDetails> lstClientCreditDetails,
                List<ClientDiscountPolicyMapping> lstClientDoscountPolicyMapping,
                List<ClientTaxMaster> lstClientTaxMaster,
                List<FileUploadDetails> lstUploadDocDetail, out long newClientID)
        {
            long returnCode = -1;
            DataTable DtClientBasicDetails = UDT_DAL.ConvertToUDTClientBasicDetails(lstClientBasicDetails);
            DataTable DtAddressdetails = UDT_DAL.ConvertToUDTAddressDetails(lstClientAddress);
            DataTable dtAttributes = UDT_DAL.ConvertToUDTClientAttributes(lstClientAttributes);
            DataTable dtClientCommunication = UDT_DAL.ConvertToUDTClientCommunication(lstClientCommunication);
            DataTable dtClientCreditDetails = UDT_DAL.ConvertToUDTClientCreditDetails(lstClientCreditDetails);
            DataTable dtClientDiscountPolicy = UDT_DAL.ConvertToUDTClientDiscountPolicyMapping(lstClientDoscountPolicyMapping);
            DataTable dtClientTaxMaster = UDT_DAL.ConvertToUDTClientTaxMaster(lstClientTaxMaster);
            DataTable dtClientDocUpload = UDT_DAL.ConvertToFileUploadUDT(lstUploadDocDetail);
            newClientID = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertInvoiceClientDetailsCommand(ClientID, ClientCode, ClientName, ReportTemplateID, Attributes, Termsconditions, ReasonForUpdate, ReportPrintFrom, TabDesiable,
                    DtClientBasicDetails, DtAddressdetails, dtAttributes, dtClientCommunication, dtClientCreditDetails, dtClientDiscountPolicy, dtClientTaxMaster, dtClientDocUpload, out newClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
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
                cmd = Command.pGetInvoiceClientDetailsCommand(pOrgID, orgaddid, cname, code, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
        //Service Exclusivity Changes
        public long GetClientNamebyClientTypeExclusivity(int OrgID, string prefixtext, int ClientTypeID, int CustomerTypeID, out List<ClientMaster> lstInvClientMaster)
        {
            lstInvClientMaster = new List<ClientMaster>();
            IDataReader dataReader = null;
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pGetClientNamebyClientTypeExclusivityCommand(OrgID, prefixtext, ClientTypeID, CustomerTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
                CLogger.LogError("Error while loading GetClientNamebyClientType in PatientDal", ex);
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


        public long GetOrgInvestigationsGroupandPKGExclusivity(int Orgid, long ClientID, string prefixText, string ItemType, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd;
                cmd = Command.pGetOrgInvestigationsGroupandPKGExclusivityCommand(Orgid, ClientID, prefixText, ItemType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingFeeDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetOrgInvestigationsGroupandPKG in Schedule_DAL.cs", ex);
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


        public long GetClientMappingServiceExclusivity(int OrgID, long ClientID, string refType, out List<ClientMappingService> lstClientMappingService)
        {
            long returnCode = -1;
            lstClientMappingService = new List<ClientMappingService>();
            try
            {
                SqlCommand objCommand = Command.pGetClientMappingServiceExclusivityCommand(OrgID, ClientID, refType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
                CLogger.LogError("Error while loading GetClientMappingService() in Deployability_DAL", ex);
            }
            return returnCode;
        }

        public long SaveClientServiceExclusivity(string RateName, int OrgID, long CreatedBy, string MappingType, List<ClientServiceExclusivity> lstCSExclusivity, int ClientID)
        {
            long returnCode = -1;
            try
            {
                DataTable dtCSExclusivity = UDT_DAL.ConvertToClientServiceExclusivityUDT(lstCSExclusivity);
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveClientServiceExclusivityCommand(RateName, OrgID, CreatedBy, MappingType,
                                                        dtCSExclusivity, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while SaveClientServiceExclusivity() in Deployability_DAL", ex);
            }
            return returnCode;
        }

        public long GetOrgInvestigationsGroupandPKGs(int Orgid, int LocationID, string prefixText, string ItemType, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd;
                cmd = Command.pGetOrgInvestigationsGroupandPKGsCommand(Orgid, LocationID, prefixText, ItemType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingFeeDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetOrgInvestigationsGroupandPKGs in Deployability_DAL.cs", ex);
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
        public long SaveSpecialRateMasters(string RateName, int OrgID, long CreatedBy, string MappingType, List<RateMaster> lstRateMaster, int ClientID)
        {
            long returnCode = -1;
            try
            {
                DataTable dtRateMaster = UDT_DAL.ConvertToSpecialRateMaster(lstRateMaster);
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveSpecialRateMastersCommand(RateName, OrgID, CreatedBy, MappingType,
                                                        dtRateMaster, UDT_DAL.ConvertToUDT_Context(globalContextDetails), ClientID);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while SaveSpecialRateMasters() in Deployability_DAL", ex);
            }
            return returnCode;
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
                CLogger.LogError("Error while loading GetClientMappingService() in Deployability_DAL", ex);
            }
            return returnCode;
        }
        public long UpdateBulkReferenceRanges(List<InvOrgReferenceMapping> InvReferenceRange, List<BulkReferenceRange> InvReferenceRR)
        {
            long returnCode = -1; // ConvertToInvRR
            DataTable dtReferenceMapping = UDT_DAL.ConvertToInvOrgReferenceMapping(InvReferenceRange);
            DataTable dtBulkRR = UDT_DAL.ConvertToInvRR(InvReferenceRR);
            SqlCommand cmd = Command.pUpdateBulkReferenceRangesCommand(dtReferenceMapping, dtBulkRR, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateBulkReferenceRanges in Investigation_DAL", ex);
            }
            return returnCode;
        }

        public long GetBulkReferenceRanges(int OrgId, out List<BulkReferenceRange> lstInvestigationRR)
        {
            long result = -1;
            lstInvestigationRR = new List<BulkReferenceRange>();
            SqlCommand cmd = Command.pGetBulkReferenceRangesCommand(OrgId);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        // lstInvestigationRR= from GetR in lstInvestigationRR
                        result = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationRR);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMemberShipCardOTP Investigation_DAL", ex);
            }
            return result;
        }
        public long BulkInsertLocationMaster(List<Stage_LocationMaster> lstUsers, out int DuplicateCount, out int InsertedCount)
        {
            DuplicateCount = -1;
            InsertedCount = -1;
            long returnCode = -1;

            DataTable dtUsers = new DataTable();


            dtUsers = UDT_DAL.ConvertToStage_LocationMaster(lstUsers);

            SqlCommand cmd = Command.PBulkInsertLocationMasterCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails), dtUsers, out DuplicateCount, out InsertedCount);
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    DuplicateCount = Convert.ToInt32(cmd.Parameters["@DuplicateCount"].Value.ToString());
                    InsertedCount = Convert.ToInt32(cmd.Parameters["@InsertedCount"].Value.ToString());
                }

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving BulkInsertUserMaster InvBulkDataUpload_DAL", e);
            }
            finally
            {

            }
            return returnCode;
        }
        public long BulkInsertPhysican(List<PStage_Physician> lstPhysician, out int DuplicateCount, out int InsertedCount)
        {
            DuplicateCount = -1;
            InsertedCount = -1;
            long returnCode = -1;

            DataTable dtphysician = new DataTable();


            dtphysician = UDT_DAL.ConvertToStage_Physician(lstPhysician);

            SqlCommand cmd = Command.pBulkInsertReferingPhysicianCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails), dtphysician, out DuplicateCount, out InsertedCount);
            try
            {


                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    DuplicateCount = Convert.ToInt32(cmd.Parameters["@DuplicateCount"].Value.ToString());
                    InsertedCount = Convert.ToInt32(cmd.Parameters["@InsertedCount"].Value.ToString());
                }

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving BulkInsertPhysican deployability_DAL", e);
            }
            finally
            {

            }
            return returnCode;
        }	
        public long pLoadTemplate(out List<History> lstTemplate)
        {
            long returnCode = -1;
            lstTemplate = new List<History>();
            try
            {
                SqlCommand cmd = Command.pLoadTemplateCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTemplate);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pLoadTemplate in deployability_DAL", ex);
            }

            return returnCode;

        }
        public long SaveInvMedicalDetailsMapping(long TestID, int TemplateID, string MedicalDetailType, string IsInternal, string IsMandatory, string InvType, long InvMedMappingID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveInvMedicalDetailsMappingCommand(TestID, TemplateID, MedicalDetailType, IsInternal, IsMandatory, InvType, InvMedMappingID);
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Deployability_DAL AddManageMedicalHistory", ex);
            }
            return returnCode;
        }

        public long GETInvMedicalDetailsMapping(long TestID, string InvType, int OrgID, out List<InvMedicalDetailsMapping> lstDetails)
        {
            long returnCode = -1;
            lstDetails = new List<InvMedicalDetailsMapping>();
            try
            {
                SqlCommand cmd = Command.pGETInvMedicalDetailsMappingCommand(TestID, InvType, OrgID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetMedicalHistoryDetails in deployability_DAL", ex);
            }

            return returnCode;

        }
        public long RemoveInvMedicalDetailsMapping(long InvMedMappingID, long TestID, int TemplateID)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pRemoveInvMedicalDetailsMappingCommand(InvMedMappingID, TestID, TemplateID);
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing RemoveMedicalHistoryDetails", ex);
            }
            return returnCode;
        }
        public long AddInterdependency(int OrgID, long GroupID, long PrimaryInvID, long DependentInvID, string DependentType, long OldPrimaryInvID, long OldDependentInvID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pAddInterdependencyCommand(OrgID, GroupID, PrimaryInvID, DependentInvID, DependentType, OldPrimaryInvID, OldDependentInvID);
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Deployability_DAL AddInterdependency", ex);
            }
            return returnCode;
        }

        public long RemoveInterdependencyDetails(int OrgId, long GroupID, long PrimaryInvID, long DependentInvID, string DependentType)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pRemoveInterdependencyDetailsCommand(OrgId, GroupID, PrimaryInvID, DependentInvID, DependentType);
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteLocationPrintMapDetails", ex);
            }
            return returnCode;
        }

        public long GetInterdependencyDetails(int OrgID, long GroupID, out List<DependentInvestigation> lstDetails)
        {
            long returnCode = -1;
            lstDetails = new List<DependentInvestigation>();
            try
            {
                SqlCommand cmd = Command.pGetInterdependencyDetailsCommand(OrgID, GroupID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInterdependencyDetails in deployability_DAL", ex);
            }

            return returnCode;

        }
        public long InsertLocationPrintMapDetails(int OrgID, int OrgAddressID, String PrinterName, bool IsColorPrinter, bool IsActive, long AutoPrinterID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertLocationPrintMapDetailsCommand(OrgID, OrgAddressID, PrinterName, IsColorPrinter, IsActive, AutoPrinterID);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Deployability_DAL SaveLocationPrintMapDetails", ex);
            }
            return returnCode;
        }

        public long GetAllLocationPrinter(int OrgID, int OrgAddressID, out List<LocationPrintMap> lstLocation)
        {
            long returnCode = -1;
            lstLocation = new List<LocationPrintMap>();
            try
            {
                SqlCommand cmd = Command.pGetAllLocationPrinterCommand(OrgID, OrgAddressID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLocation);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetALLLocation in deployability_DAL", ex);
            }

            return returnCode;

        }

        public long pRemoveLocationPrintMapDetails(int pOrgID, int pOrgAddressID, string pPrinterName)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pRemoveLocationPrintMapDetailsCommand(pOrgID, pOrgAddressID, pPrinterName);
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteLocationPrintMapDetails", ex);
            }
            return returnCode;
        }
        public long BulkUpdatebillSupplyNo(List<Stage_InvoiceBillSupplyNo_Template> lstbillsupplyno, out int DuplicateCount, out int InsertedCount)
        {
            DuplicateCount = -1;
            InsertedCount = -1;
            long returnCode = -1;

            DataTable dtbillsupplyupdate = new DataTable();


            dtbillsupplyupdate = UDT_DAL.ConvertToStage_billSupply(lstbillsupplyno);

            SqlCommand cmd = Command.pBulkInsertBillSupplyNoUpdateCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails), dtbillsupplyupdate, out DuplicateCount, out InsertedCount);
            try
            {


                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    DuplicateCount = Convert.ToInt32(cmd.Parameters["@DuplicateCount"].Value.ToString());
                    InsertedCount = Convert.ToInt32(cmd.Parameters["@InsertedCount"].Value.ToString());
                }

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving BulkUpdatebillSupplyNo deployability_DAL", e);
            }
            finally
            {

            }
            return returnCode;
        }	

    }
}
