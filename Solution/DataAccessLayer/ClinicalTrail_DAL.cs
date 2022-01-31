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
    public class ClinicalTrail_DAL
    {
         ContextDetails globalContextDetails;
        public ClinicalTrail_DAL()
        {

        }
        public ClinicalTrail_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long SaveEpisodeMaster(Episode lstEpisodeDetails,
            List<EpisodeVisitDetails> lstEpisodeVisitDetails,
            List<SiteEpisodeVisitMapping> lstSiteEpisodeVisitMapping,
             List<ProductEpisodeVisitMapping> lstKitVisitDetails, int OrgID, string EpisodeStatus, string LifeStatus, out long EpisodeID)
        {
            long returnCode = -1;
            EpisodeID = -1;
            try
            {
                DataTable DtEpisodeMaster = UDT_DAL.ConvertToUDTEpisode(lstEpisodeDetails);
                DataTable dtEpisodeVisitDetails = UDT_DAL.ConvertToUDTEpisodeVisitDetails(lstEpisodeVisitDetails);
                DataTable dtSiteEpisodeVisitMapping = UDT_DAL.ConvertToSiteEpisodeVisitMapping(lstSiteEpisodeVisitMapping);
                DataTable dtProductEpisodeVisitMapping = UDT_DAL.ConvertToProductEpisodeVisitMapping(lstKitVisitDetails);
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertEpisodeMasterCommand(DtEpisodeMaster, dtEpisodeVisitDetails, dtSiteEpisodeVisitMapping, dtProductEpisodeVisitMapping, OrgID, EpisodeStatus, LifeStatus, out EpisodeID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    EpisodeID = Convert.ToInt64(cmd.Parameters["@EpisodeID"].Value);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value); 
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTreatmentPlan()", ex);
            }
            return returnCode;
        }
        public long GetEpisodeDetails(int pOrgID, string EpisodeName, long EpisodeID, out List<Episode> lstEpisode, out List<EpisodeVisitDetails> lstEpisodeVisitDetails,
            out List<ProductEpisodeVisitMapping> lstProductDetails, out List<SiteEpisodeVisitMapping> lstSiteDetails)
        {
            long returnCode = -1;
            lstEpisode = new List<Episode>();
            lstEpisodeVisitDetails = new List<EpisodeVisitDetails>();
            lstProductDetails = new List<ProductEpisodeVisitMapping>();
            lstSiteDetails = new List<SiteEpisodeVisitMapping>();
          
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetEpisodeDetailsCommand(pOrgID, EpisodeName, EpisodeID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstEpisode);
                    Utilities.ConvertTo(ds.Tables[1], out lstEpisodeVisitDetails);
                    Utilities.ConvertTo(ds.Tables[2], out lstProductDetails);
                    Utilities.ConvertTo(ds.Tables[3], out lstSiteDetails);
                   
                } 
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returnCode;
        }
        public long SaveEpisodeTRFDetails(string Fileurl, string fileName, long EpisodeID,string FileType, int orgid)
        {
            long returncode = -1;
            SqlCommand objCommand = Command.pInsertEpisodeTRFDetailsCommand(Fileurl, fileName, EpisodeID,FileType, orgid,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);

                    returncode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveTRFdetails Patient_DAL", excep);
            }
            return returncode;

        }
        // changed dataset to datareader by Arivalagan.k
        public long GetTRFDetails(int patientid, int visitid, int OrgID, string Type, out List<TRFfilemanager> TRFdetails)
        {
            long returncode = -1;
            SqlCommand objcommand = Command.pGetTRFDetailsCommand(patientid, visitid, OrgID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            TRFdetails = new List<TRFfilemanager>();
            IDataReader dataReader = null;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objcommand);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out TRFdetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing TRFdetails Patient_DAL", excep);
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
        public long GetProductListWithName(int OrgID, string pProducts, int OrgAddressID, string PType, out List<Products> lstProducts)
        {
            long returnCode = -1;
            lstProducts = new List<Products>();
            SqlCommand cmd = Command.pGetProductListWithNameCommand(OrgID, pProducts, OrgAddressID, PType,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstProducts);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSearchProductList in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long UpdateEpisodeLifeStatus(long EpisodeID, string EpisodeLifeStatus, int OrgID, long ModifiedBy)
        {
            long returncode = -1;
            SqlCommand objCommand = Command.pUpdateEpisodeLifeStatusCommand(EpisodeID, EpisodeLifeStatus, OrgID, ModifiedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);

                    returncode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveTRFdetails Patient_DAL", excep);
            }
            return returncode;

        }
        public long GetEpisodeTaskDetails(int pOrgID, long EpisodeID, out List<Episode> lstborg)
        {
            long returnCode = -1;
            lstborg = new List<Episode>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetEpisodeTaskDetailsCommand(pOrgID, EpisodeID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
        // changed dataset to datareader by Arivalagan.k
        public long GetShippingCondition(int pOrgID, out List<ShippingConditionMaster> lstShippingConditionMaster)
        {
            long returnCode = -1;
            lstShippingConditionMaster = new List<ShippingConditionMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetShippingConditionCommand(pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                
                using (DBEngine dbEngine = new DBEngine())
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstShippingConditionMaster);
                        dataReader.Close();
                    }
                }
              
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returnCode;
        }
        public long SaveEpiContainerTracking(int SiteID, long EpisodeID, int ShippingCondID, int VisitID, string AddInfo, int OrgID, long CreatedBy, out string ConsignmentNo,long CurrentRegTrackID, out long RegTrackID)
        {
            long returnCode = -1;
                ConsignmentNo = string.Empty;
                RegTrackID = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertEpiContainerTrackingCommand(EpisodeID, SiteID, ShippingCondID, VisitID, AddInfo, OrgID, CreatedBy, out ConsignmentNo,CurrentRegTrackID,out RegTrackID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    ConsignmentNo =Convert.ToString(cmd.Parameters["@ConsignmentNo"].Value);
                    RegTrackID = Convert.ToInt64(cmd.Parameters["@RegTrackID"].Value);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                    
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTreatmentPlan()", ex);
            }
            return returnCode;
        }
        public long GetEpiContainerTracking(int pOrgID, long TaskID, int TStatusID, out List<EpiContainerTracking> lstEpiContainerTracking)
        {
            long returnCode = -1;
            lstEpiContainerTracking = new List<EpiContainerTracking>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetEpiContainerTrackingCommand(pOrgID,TaskID,TStatusID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstEpiContainerTracking);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returnCode;
        }
        public long UpdateContainerStatus(long TrackID, int ContainerStatusID, 
            string Attributes, int OrgID, long ModifiedBy,
            List<ControlMappingDetails>  lstControlMappingDetails)
        {
            long returncode = -1;
            DataTable dtlstControlMappingDetails = UDT_DAL.ConvertToControlMappingDetails(lstControlMappingDetails);
            SqlCommand objCommand = Command.pUpdateContainerStatusCommand(TrackID, ContainerStatusID,
									                Attributes, OrgID, ModifiedBy, dtlstControlMappingDetails,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);

                    returncode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveTRFdetails Patient_DAL", excep);
            }
            return returncode;

        }
        public long GetEpiContainerTrackingDetails(int pOrgID,long TrackID, out List<EpiContainerTracking> lstEpiContainerTracking)
        {
            long returnCode = -1;
            lstEpiContainerTracking = new List<EpiContainerTracking>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetEpiContainerTrackingDetailsCommand(pOrgID, TrackID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstEpiContainerTracking);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returnCode;
        }
        public long GetControlListDetails(int pOrgID, long ReferenceID, string ReferenceType, string pType, long SecondaryReferenceID,
           out List<ControlMappingDetails> lstControlMappingDetails, out List<ControlMappingDetails> lstControlMappingValues)
        {
            long returnCode = -1;
            lstControlMappingDetails = new List<ControlMappingDetails>();
            lstControlMappingValues = new List<ControlMappingDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetControlListCommand(pOrgID, ReferenceID, ReferenceType, pType,SecondaryReferenceID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstControlMappingDetails);
                }
                if (ds.Tables != null && ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[1], out lstControlMappingValues);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetControlListDetails", ex);
            }
            return returnCode;
        }
        public long GetStatusMaster(int pOrgID, out List<StatusMaster> lstStatusMaster)
        {
            long returnCode = -1;
            lstStatusMaster = new List<StatusMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetStatusMasterCommand(pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstStatusMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returnCode;
        }

        public long GetSitewiseContactList(long ClientID,int EpisodeID,int OrgID, out List<AddressDetails> lstAddDetails)
        {
            long returnCode = -1;
            lstAddDetails = new List<AddressDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetSitewiseContactListCommand(ClientID,EpisodeID,OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstAddDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetSitewiseContactList", ex);
            }
            return returnCode;
        }
        public long GetPatientDetailsByConsignmentNo(int OrgID, string ConsignmentNo, long EpisodeID, long SiteID, string Type, out List<PatientInvSample> lstPatientInvSample)
        {
            long returnCode = -1;
            lstPatientInvSample = new List<PatientInvSample>();
            SqlCommand cmd = Command.pGetPatientDetailsByConsignmentNoCommand(OrgID, ConsignmentNo, EpisodeID, SiteID, Type,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvSample);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSearchProductList in Inventory_DAL", ex);
            }
            return returnCode;
        }
       
       
        public long InsertKitconsumption(int OrgID, int OrgAddressID, int LocationId, long CreatedBy, long PatientVisitID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertKitconsumptionCommand(OrgID, OrgAddressID, LocationId, CreatedBy, PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertKitconsumption", ex);
            }
            return returnCode;
        }
        public long GetOrgDetailsWithTypeLevel(long pID, string TypeLevel, out List<Organization> lstOrganization)
        {

            lstOrganization = new List<Organization>();
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetOrgDetailsWithTypeLevelCommand(pID, TypeLevel,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstOrganization);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
            }
            return returnCode;
        }
        public long GetProblemDataForm(DateTime FromDate, DateTime ToDate, int OrgID, int ILocationID, string pType,string  IsDispatch,out List<Patient> lstPatient)
        {

            lstPatient = new List<Patient>();
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetProblemDataFormDetailsCommand(FromDate, ToDate, OrgID, ILocationID, pType, IsDispatch,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting GetProblemDataForm  ", ex);
            }
            return returnCode;
        }
        public long UpdatePatientMismatchDataStatus(List<ProductEpisodeVisitMapping> lstPatientVisit, int OrgID, long ModifiedBy)
        {
            long returncode = -1;
            DataTable dtlstPatientVisit = UDT_DAL.ConvertToProductEpisodeVisitMapping(lstPatientVisit);
            SqlCommand objCommand = Command.pUpdatePatientMismatchDataStatusCommand(dtlstPatientVisit, OrgID, ModifiedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);

                    returncode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveTRFdetails Patient_DAL", excep);
            }
            return returncode;

        }
        public long GetProblemDataFormContactDetails(long PatientVisitID, int OrgID, out List<AddressDetails> lstAddress)
        {
            long returnCode = -1;
            lstAddress = new List<AddressDetails>();
            SqlCommand cmd = Command.pGetProblemDataFormContactDetailsCommand(PatientVisitID,OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAddress);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSearchProductList in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long GetProblemDataFormSampleDetails(long PatientVisitID, int OrgID, out List<EpisodeVisitDetails> EpisodeVisitDetails)
        {
            long returnCode = -1;
            EpisodeVisitDetails = new List<EpisodeVisitDetails>();
            SqlCommand cmd = Command.pGetProblemDataFormSampleDetailsCommand(PatientVisitID, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out EpisodeVisitDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSearchProductList in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long UpdateBulkSampleStatus(List<SampleTracker> lstSampleTracker)
        {
            long returncode = -1;
            DataTable dtSaveSampleTracker = new DataTable();
            SqlCommand cmd = new SqlCommand(); // Command.pUpdateBulkSampleStatusCommand(dtSaveSampleTrackerUDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertSampleCollectfromDeptID", ex);
            }
            return returncode;
        }

    }
}
