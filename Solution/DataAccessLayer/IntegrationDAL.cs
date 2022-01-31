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
using Attune.Podium.ClientEntity;

namespace Attune.Solution.DAL
{
    public class IntegrationDAL
    {
        ContextDetails globalContextDetails;
        public IntegrationDAL()
        {

        }
        public IntegrationDAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long SaveIntegrationData(List<IntegrationHistory> lstIntegrationDetails)
        {
            long returnCode = -1;
            DataTable dt = UDT_DAL.ConvertToUDTIntegrationDetails(lstIntegrationDetails);

            SqlCommand cmd = Command.pInsertIntegrationDetailsCommand(dt, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@preturnCode"].Value);

            }

            return returnCode;
        }



        public long UpdateVisitDetails(PatientVisit labVisit, List<VisitClientMapping> lstVisitClientMapping)
        {
            long returnCode = -1;
            //DataTable dt = UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping);
            SqlCommand objCommand = Command.pUpdateVisitDetailsForIntegrationCommand(labVisit.PatientID, labVisit.OrgID, labVisit.PriorityID,
                                     labVisit.ReferingPhysicianID, labVisit.ReferingPhysicianName, labVisit.HospitalID,
                                     labVisit.HospitalName, labVisit.ModifiedBy,
                                                    labVisit.CollectionCentreID, labVisit.CollectionCentreName, labVisit.ExternalVisitID, labVisit.VisitType, labVisit.WardNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails)
                                                    , UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteNonQuery(objCommand);
                returnCode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
            }

            return returnCode;
        }

        public long GetDetailsForExtVisitID(PatientVisit labVisit, out List<PatientVisit> VisitDetail, out long patientCount)
        {
            long returnCode = -1;
            patientCount = -1;
            VisitDetail = new List<PatientVisit>();
            SqlCommand objCommand = Command.pgetDetailsForExVisitIDCommand(labVisit.PatientID, labVisit.OrgID, labVisit.PriorityID,
                                     Convert.ToInt32(labVisit.ClientMappingDetailsID), labVisit.ReferingPhysicianName, labVisit.HospitalID,
                                     labVisit.HospitalName, labVisit.ModifiedBy, labVisit.CollectionCentreID, labVisit.CollectionCentreName,
                                     labVisit.ExternalVisitID, labVisit.VisitType, labVisit.WardNo, labVisit.ClientID,
                                     out patientCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                returnCode = db.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out VisitDetail);
            }
            return returnCode;
        }
        public long GetImageServerDetails(int OrgID, long OrgAddressID, out List<ImageServerDetails> ImgServerDetails)
        {
            long returnCode = -1;
            ImgServerDetails = new List<ImageServerDetails>();
            SqlCommand cmd = Command.pGetImageServerDetailsCommand(OrgID, OrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out ImgServerDetails);
                }
            }

            return returnCode;
        }

        public long GetIntegrationVisitDetail(string sampleInstanceID, out Int64 visitID, out int visitCount, out string UID, out int intOrgID)
        {
            long returnCode = -1;
            visitID = 0;
            visitCount = 0;
            UID = string.Empty;
            intOrgID = 0;
            try
            {

                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetInvIntegrationDetailCommand(sampleInstanceID, out intOrgID, out visitID, out visitCount, out UID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);


                    visitID = Convert.ToInt64(cmd.Parameters["@VisitID"].Value);
                    visitCount = Convert.ToInt32(cmd.Parameters["@VisitCount"].Value);
                    UID = Convert.ToString(cmd.Parameters["@UID"].Value);
                    intOrgID = Convert.ToInt32(cmd.Parameters["@OrgID"].Value);

                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetIntegrationVisitDetail in IntegrationDAL", ex);
            }

            return returnCode;


        }




        public long GetTestCodeInvestigation(List<InvestigationMaster> lstIM, int OrgID, long PatientVisitID, string UID, string BarCode, string DeviceID, out List<PatientInvestigation> lstPI)
        {
            long returnCode = -1;
            lstPI = new List<PatientInvestigation>();
            DataTable dtTestCode = UDT_DAL.ConvertToUDTInvestigationMaster(lstIM);
            SqlCommand cmd = Command.pGetTestCodeInvestigationCommand(PatientVisitID, OrgID, UID, BarCode, DeviceID, dtTestCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstPI);
                }
            }

            return returnCode;
        }


        public long InsertInvestigationHistory(List<List<InvestigationValues>> InvestigationValues, string gUID)
        {
            long returnCode = -1;
            int retValue = -1;
            DataTable dtInvestigationValues = UDT_DAL.ConvertToInvestigationResults(InvestigationValues);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pInsertInvestigationValuesHistoryCommand(dtInvestigationValues, gUID, out retValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing InsertInvestigationHistory Integration_DAL", e);
            }
            return returnCode;
        }



        public long GetTestCodesForBarCodes(string DeviceID, List<DeviceImportData> lstBarCode, out List<DeviceImportData> lstTestCode)
        {
            long returnCode = -1;
            lstTestCode = new List<DeviceImportData>();
            DataTable dtBarCode = UDT_DAL.ConvertToUDTDeviceImportData(lstBarCode);
            SqlCommand cmd = Command.pGetTestCodesForBarCodesCommand(DeviceID, dtBarCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Utilities.ConvertTo(ds.Tables[0], out lstTestCode);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError(" Error in GetTestCodesForBarCodes IntegrationDAL", ex);
            }

            return returnCode;
        }



        public long GetDuplicateIDforIntegration(long OrgID, List<InvestigationDetail> lstIds, out List<InvestigationDetail> lstIdExists, out List<InvestigationDetail> lstDupIds)
        {
            long returnCode = -1;
            lstIdExists = new List<InvestigationDetail>();
            lstDupIds = new List<InvestigationDetail>();
            DataTable dtIds = UDT_DAL.ConvertToInvestigationDetail(lstIds);
            SqlCommand cmd = Command.pgetDuplicateIDforIntegrationCommand(dtIds, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Utilities.ConvertTo(ds.Tables[0], out lstIdExists);
                    }

                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        Utilities.ConvertTo(ds.Tables[1], out lstDupIds);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError(" Error in GetDuplicateIDforIntegration IntegrationDAL", ex);
            }

            return returnCode;
        }

        public long GetDeviceIntegrationFormula(long OrgID, string DeviceID, int InvID, out string Formula)
        {
            long lresult = -1;

            SqlCommand cmd = Command.pGetDeviceIntegrationFormulaCommand(OrgID, DeviceID, InvID, out Formula);
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                    Formula = Convert.ToString(cmd.Parameters["@Formula"].Value);
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeviceIntegrationFormula", ex);
            }
            return lresult;
        }


        public long UpdateDeviceSampleStatus(int OrgID, long OrgAddressID, List<DeviceImportData> lstBarCode)
        {
            long returnCode = -1;
            int retValue = -1;
            DataTable dtBarCode = UDT_DAL.ConvertToUDTDeviceSampleStatus(lstBarCode);

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateDeviceSampleStatusCommand(OrgID, OrgAddressID, dtBarCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {

                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing InsertInvestigationHistory Integration_DAL", e);
            }
            return returnCode;
        }

        public long SaveVitekDeviceIntegrationResult(List<VitekDeviceIntegrationResult> lstVitekDeviceIntegrationResult)
        {
            long returnCode = -1;
            DataTable dtVitekDeviceIntegrationResult = UDT_DAL.ConvertToUDTVitekDeviceIntegrationResult(lstVitekDeviceIntegrationResult);

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveVitekDeviceIntegrationResultCommand(dtVitekDeviceIntegrationResult, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {

                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveVitekDeviceIntegrationResult Integration_DAL", e);
            }
            return returnCode;
        }

        public long GetVitekDeviceIntegrationResult(List<VitekDeviceIntegrationResult> UDTVitekDeviceIntegrationResult, out List<VitekDeviceIntegrationResult> lstVitekDeviceIntegrationResult)
        {
            long returnCode = -1;
            lstVitekDeviceIntegrationResult = new List<VitekDeviceIntegrationResult>();
            DataTable dtVitekDeviceIntegrationResult = UDT_DAL.ConvertToUDTVitekDeviceIntegrationResult(UDTVitekDeviceIntegrationResult);
            SqlCommand cmd = new SqlCommand();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.pGetVitekDeviceIntegrationResultCommand(dtVitekDeviceIntegrationResult, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstVitekDeviceIntegrationResult);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetVitekDeviceIntegrationResult Integration_DAL", e);
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
        public long GetBidirectionalBarCodeDetails(DateTime FromDate, DateTime ToDate, int OrgID, string DeviceID, out List<BidirectionalBarcodes> lstBarCode)
        {
            long returnCode = -1;
            lstBarCode = new List<BidirectionalBarcodes>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PGetBidirectionalBarCodeDetailsCommand(FromDate, ToDate, OrgID, DeviceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBarCode);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get BarCodeDetails", ex);
            }
            return returnCode;

        }
        public long UpdateBidirectionalBarCodeDetails(List<BidirectionalBarcodes> lstBarCode)
        {
            long returnCode = -1;
            int retValue = -1;
            DataTable dtBarCode = UDT_DAL.ConvertToBidirectionalBarcodes(lstBarCode);

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateBidirectionalBarCodeDetailsCommand(dtBarCode);
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateBidirectionalBarCodeDetails Integration_DAL", e);
            }
            return returnCode;
        }
        //Vijayalakshmi.M      
        public long GetBarCodeDetails(string ExternalVistiId, int OrgId, out int TranStatus, out List<BarcodeIntegrationResults> lstsample)
        {
            long returnCode = -1;
            TranStatus = -1;
            lstsample = new List<BarcodeIntegrationResults>();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            cmd = Command.pGetBarCodeDetailsCommand(ExternalVistiId, OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out TranStatus);
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstsample);
                        TranStatus = Convert.ToInt32(cmd.Parameters["@TranStatus"].Value);

                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstsample);
                        TranStatus = Convert.ToInt32(cmd.Parameters["@TranStatus"].Value);
                    }



                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving GetBarCodeForSample investigation_DAL", e);
            }
            return returnCode;

        }
        #region HL7 integration
        public long InsertIntegrationHistoryAck(long IntegrationHistoryID, string FailureReason, string Status, int OrgID, int LocationID, string Acknowledgement)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pInsertIntegrationHistoryAckCommand(IntegrationHistoryID, FailureReason, Status, OrgID, LocationID, Acknowledgement, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine db = new DBEngine())
            {

                returnCode = db.ExecuteNonQuery(cmd);

            }

            return returnCode;
        }
        public long InsertIntegrationHistory(List<IntegrationHistory> lstIntegrationDetails, out long HistoryID)
        {
            long returnCode = -1;
            DataTable dt = UDT_DAL.ConvertToUDTIntegrationDetails(lstIntegrationDetails);

            SqlCommand cmd = Command.pInsertIntegrationHistoryCommand(dt, out returnCode, out HistoryID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@preturnCode"].Value);
                HistoryID = Convert.ToInt64(cmd.Parameters["@pIntegrationHistoryID"].Value);

            }

            return returnCode;
        }
        #endregion
        public long SaveClientDetails(List<ClientDetails_Integration> pClientDetails, out long ClientID)
        {
            long returnCode = -1;
            ClientID = 0;
            try
            {
                DataSet ds = new DataSet();
                DataTable dtClientDetails = UDT_DAL.ConvertToClientDetails(pClientDetails);
                SqlCommand cmd = Command.pSaveClientDetailsCommand(dtClientDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out ClientID);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    ClientID = Convert.ToInt64(cmd.Parameters["@ClientID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while SaveClientDetails in IntegrationDAL", ex);
            }
            return returnCode;
        }
        public long GetIntegrationError(string type, int orgid, out List<Status> lststatus)
        {
            long returncode = -1;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            lststatus = new List<Status>();
            cmd = Command.PGetIntegrationErrorCommand(type, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returncode = Utilities.ConvertTo(ds.Tables[0], out lststatus);


                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetIntegrationError in IntegrationDAL", ex);
            }
            return returncode;
        }
        public long SaveReferingphysiciandetails(List<ReferingPhysicianDetails> lstrefphy, out long Refferingphysicianid)
        {
            long returnCode = -1;
            Refferingphysicianid = 0;
            try
            {
                DataSet ds = new DataSet();
                DataTable dtreferingphysicianDetails = UDT_DAL.ConverttoRefeingphysiciandetails(lstrefphy);
                SqlCommand cmd = Command.pSaveReferingphysiciandetailsCommand(dtreferingphysicianDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out Refferingphysicianid);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    Refferingphysicianid = Convert.ToInt64(cmd.Parameters["@referingphysianid"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while SaveRefferingphysiciandetails in IntegrationDAL", ex);
            }
            return returnCode;
        }
        public long GetRateforInvestigation(string Testcode, int Orgid, long clientid, out int investigationid, out decimal Rate, out int Rateid, out int LoginID, out int Roleid, out string type)
        {
            long returnCode = -1;
            investigationid = 0;
            Rate = decimal.Zero;
            Rateid = 0;
            LoginID = 0;
            Roleid = 0;
            type = string.Empty;




            // DataTable Dt = UDT_DAL.ConvertToUDT_Context(globalContextDetails);
            try
            {
                DataSet ds = new DataSet();

                SqlCommand cmd = Command.PGetRateforInvestigationCommand(Testcode, Orgid, clientid, out investigationid, out Rate, out Rateid, out LoginID, out Roleid, out type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    investigationid = Convert.ToInt32(cmd.Parameters["@investigationid"].Value);
                    Rate = Convert.ToDecimal(cmd.Parameters["@Rate"].Value);
                    Rateid = Convert.ToInt32(cmd.Parameters["@Rateid"].Value);
                    Roleid = Convert.ToInt32(cmd.Parameters["@LoginID"].Value);
                    LoginID = Convert.ToInt32(cmd.Parameters["@Roleid"].Value);
                    type = Convert.ToString(cmd.Parameters["@type"].Value);



                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetRateforInvestigation", ex);
            }
            return returnCode;
        }
        public long GetRegistrationStatus_integration(string ExternalPatientNo, string ExternalVisitid, int OrgID, out int count, out List<Patient> lPatientDetails, out List<PatientVisit> LstPatientvisit)
        {
            long returnCode = -1;
            count = -1;
            DataSet ds = new DataSet();
            lPatientDetails = new List<Patient>();
            LstPatientvisit = new List<PatientVisit>();
            try
            {
                SqlCommand cmd = Command.pGetRegistrationStatus_IntegrationCommand(ExternalPatientNo, ExternalVisitid, OrgID, out count, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    //dataReader = dbEngine.ExecuteReader(cmd);
                    //if (dataReader != null)
                    //{
                    //    Utilities.ConvertTo(dataReader, out lPatientDetails);

                    //    dataReader.Close();
                    //}


                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lPatientDetails);
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out LstPatientvisit);


                    }
                    count = Convert.ToInt32(cmd.Parameters["@pCount"].Value);

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetRegistrationStatus in Patient_DAL", e);
            }

            return returnCode;
        }
        public long GetOrderedStatus(string ExternalVisitID, out List<OrderedStatus> lstOrderedStatus)
        {
            long returnCode = -1;
            lstOrderedStatus = new List<OrderedStatus>();

            try
            {
                DataSet ds = new DataSet();

                SqlCommand cmd = Command.PgetorderedstatusCommand(ExternalVisitID);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrderedStatus);
                    }
                }



            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while SaveClientDetails in IntegrationDAL", ex);
            }
            return returnCode;
        }


        public long GetBidirectionalBarCodeDetails(int OrgID, int OrgAddressID, string DeviceID, out List<BidirectionalBarcodesDetails> lstBarCode)
        {
            long returnCode = -1;
            lstBarCode = new List<BidirectionalBarcodesDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PGetBidirectionalBarCodeDetailsCommand(OrgID, OrgAddressID, DeviceID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBarCode);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get BidirectionalBarCodeDetails", ex);
            }
            return returnCode;

        }

        public long InsertDeviceInvestigationData(List<DeviceInvestigationData> oDeviceTranData, int OrgID)
        {
            SqlCommand sqlCommand = Command.pInsertDeviceInvestigationDataCommand(UDT_DAL.ConvertToDeviceTranData(oDeviceTranData), OrgID);
            try
            {
                using (DBEngine engine = new DBEngine())
                {
                    engine.ExecuteTransactionalNonQuery(sqlCommand);
                }
            }
            catch (Exception exception)
            {
                CLogger.LogError("Error while executing InsertDeviceInvestigationData in Investigation_DAL", exception);
            }
            return -1L;
        }

        public long UpdateBidirectionalBarCodeDetails(List<BidirectionalBarcodesDetails> lstBarCode)
        {
            long returnCode = -1;
            DataTable dtBarCode = UDT_DAL.ConvertToBidirectionalBarcodesDetails(lstBarCode);

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateBidirectionalBarCodesDetailsCommand(dtBarCode);
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateBidirectionalBarCodeDetails Integration_DAL", e);
            }
            return returnCode;
        }

        public long GetIntegrationVisitDetailforExternalBarcode(string sampleInstanceID, string DeviceID, string AssayCode, out Int64 visitID, out int visitCount, out string UID, out int intOrgID)
        {
            long returnCode = -1;
            visitID = 0;
            visitCount = 0;
            UID = string.Empty;
            intOrgID = 0;
            try
            {

                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetInvIntegrationDetailforExBarcodeCommand(sampleInstanceID, DeviceID, AssayCode, out intOrgID, out visitID, out visitCount, out UID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);


                    visitID = Convert.ToInt64(cmd.Parameters["@VisitID"].Value);
                    visitCount = Convert.ToInt32(cmd.Parameters["@VisitCount"].Value);
                    UID = Convert.ToString(cmd.Parameters["@UID"].Value);
                    intOrgID = Convert.ToInt32(cmd.Parameters["@OrgID"].Value);

                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetIntegrationVisitDetail in IntegrationDAL", ex);
            }

            return returnCode;


        }

        public long SaveIntegrationData(List<IntegrationHistory> lstIntegrationDetails, string OrgCode, string Location, string VisitTypeCode, string PatientTitle, out int OrgID, out int LocationID, out int VisitType, out long ClientID, out byte titlecode)
        {
            long returnCode = -1;
            //OrgID = -1;
            //LocationID = -1;
            ClientID = -1;
            titlecode = 0x00;
            DataTable dt = UDT_DAL.ConvertToUDTIntegrationDetails(lstIntegrationDetails);

            SqlCommand cmd = Command.pInsertIntegrationDetails_IAPICommand(OrgCode, Location, VisitTypeCode, PatientTitle, dt, out returnCode, out  OrgID, out LocationID, out VisitType, out ClientID, out titlecode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine oDbHelper = new DBEngine())
            {
                oDbHelper.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@preturnCode"].Value);
                OrgID = Convert.ToInt32(cmd.Parameters["@OrgID"].Value);
                LocationID = Convert.ToInt32(cmd.Parameters["@LocationID"].Value);
                VisitType = Convert.ToInt32(cmd.Parameters["@VisitType"].Value);
                ClientID = Convert.ToInt32(cmd.Parameters["@pClientID"].Value);
                titlecode = Convert.ToByte(cmd.Parameters["@pTitlecode"].Value);
            }

            return returnCode;
        }

        public long GetIntegrationVisitDetailforLabCode(string sampleInstanceID, string DeviceID, string AssayCode, out Int64 visitID, out int visitCount, out string UID, out int intOrgID, out string barcode)
        {
            long returnCode = -1;
            visitID = 0;
            visitCount = 0;
            UID = string.Empty;
            barcode = string.Empty;
            intOrgID = 0;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetInvIntegrationDetailforLabcodeCommand(sampleInstanceID, DeviceID, AssayCode, out intOrgID, out visitID, out visitCount, out UID, out barcode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    visitID = Convert.ToInt64(cmd.Parameters["@VisitID"].Value);
                    visitCount = Convert.ToInt32(cmd.Parameters["@VisitCount"].Value);
                    UID = Convert.ToString(cmd.Parameters["@UID"].Value);
                    intOrgID = Convert.ToInt32(cmd.Parameters["@OrgID"].Value);
                    barcode = Convert.ToString(cmd.Parameters["@Barcode"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetIntegrationVisitDetailforLabCode in IntegrationDAL", ex);
            }

            return returnCode;
        }

    }
}
