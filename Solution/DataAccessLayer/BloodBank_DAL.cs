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
    public class BloodBank_DAL
    {
         ContextDetails globalContextDetails;
        public BloodBank_DAL()
        {

        }
        public BloodBank_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long InsertOrUpdateDonorStatus(long visitID, string PS1, string PS2, string TS1, string TS2, string ES1, string ES2)
        {
            long returncode = -1;
            SqlCommand cmdStatus = Command.pInsertOrUpdateDonorStatusCommand(visitID, PS1, PS2, TS1, TS2, ES1, ES2,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdStatus.Parameters.Add("@Return", SqlDbType.Int);
            cmdStatus.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdStatus);

                    returncode = Convert.ToInt64(cmdStatus.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing InsertOrUpdateDonorStatus Patient_DAL", excep);
            }
            return returncode;

        }
        public long GetDonorDetailsAndStatus(long patientVisitId, out List<PatientVisitDetails> lstPatientVisitDetails, out List<DonorStatus> lstDonorStatus)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetDonorDetailsAndStatusCommand(patientVisitId,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPatientVisitDetails = new List<PatientVisitDetails>();
            lstDonorStatus = new List<DonorStatus>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisitDetails);
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDonorStatus);
            }
            return returnCode;
        }
        public long InsertBloodCollectionDetails(long VisitID, List<BloodCollectionDetails> lstBloodCollection, 
       List<BloodCapturedDetials> lstBloodCapture, long OrgID, long OrgAddressID, long UserID, long RoleID, long LocationID)
        {
            long returnCode = -1;
            DataTable dtBloodCapture =UDT_DAL.ConvertToUDTBloodCapture(lstBloodCapture);
            DataTable dtBloodCollect =UDT_DAL.ConvertToUDTBloodCollect(lstBloodCollection);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pInsertBloodCollectionDetailsCommand(VisitID, dtBloodCollect, dtBloodCapture, OrgID, OrgAddressID,UserID,RoleID, LocationID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
        public long GetBloodGroupsAndComponents(out List<BloodGroup> lstBloodGrp, out List<BloodComponent> lstBloodComponent)
        {
            long returnCode = -1;
            lstBloodGrp = new List<BloodGroup>();
            lstBloodComponent = new List<BloodComponent>();
            SqlCommand objCommand = Command.pGetBloodGroupsAndComponentsCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBloodGrp);
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBloodComponent);
            }
            return returnCode;
        }
        public long SearchBloodBag(string BagNo, string BagType, string BloodGroup, string BloodType, int OrgID, out List<BloodCollectionDetails> lstBloodCollection)
        {
            long returnCode = -1;
            lstBloodCollection = new List<BloodCollectionDetails>();
            SqlCommand objCommand = Command.pSearchBloodBagCommand(BagNo, BagType, BloodGroup, BloodType, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBloodCollection);
            }
            return returnCode;
        }
        public long GetPatientHistoryPKGEditForBloodBank(long visitID, long LoginID, long SpecialityID, long OrgID, out List<PatientHistoryAttribute> lstPHA, out List<DrugDetails> lstDrugDetails, out List<GPALDetails> lstGPALDetails, out List<ANCPatientDetails> lstANCPatientDetails, out List<PatientPastVaccinationHistory> lstPPVH, out List<PatientComplaintAttribute> lstPCA, out List<SurgicalDetail> lstSurgicalDetails, out List<PatientComplaintAttribute> lsthisPCA, out List<PatientHistoryAttribute> lsthisPHA)
        {
            long returnCode = -1;
            lstPHA = new List<PatientHistoryAttribute>();
            lstDrugDetails = new List<DrugDetails>();
            lstGPALDetails = new List<GPALDetails>();
            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstPPVH = new List<PatientPastVaccinationHistory>();
            lstPCA = new List<PatientComplaintAttribute>();
            lstSurgicalDetails = new List<SurgicalDetail>();
            lsthisPHA = new List<PatientHistoryAttribute>();
            lsthisPCA = new List<PatientComplaintAttribute>();
            try
            {
                SqlCommand cmd = Command.pGetPatientHistoryPKGEditForBloodBankCommand(visitID, LoginID, SpecialityID, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPHA);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstDrugDetails);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstGPALDetails);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstANCPatientDetails);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPPVH);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPCA);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstSurgicalDetails);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lsthisPCA);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lsthisPHA);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPatientHistoryPKGEdit", ex);
            }

            return returnCode;
        }
        public long GetBloodRequestDetails(long patientID,long visitID,DateTime FromDate,DateTime ToDate,out long BloodRequestNumber,out List<BloodRequistionDetails> lstBloodRequest,out List<Patient> lstPatient)
        {
            long returnCode = -1;
            BloodRequestNumber = 0;
            lstBloodRequest = new List<BloodRequistionDetails>();
            lstPatient = new List<Patient>();
            try
            {
                SqlCommand cmd = Command.pGetBloodRequestDetailsCommand(patientID,visitID,FromDate,ToDate,out BloodRequestNumber,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                BloodRequestNumber = Convert.ToInt64(cmd.Parameters["@pRequestNo"].Value);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBloodRequest);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetBloodRequestDetails", ex);
            }

            return returnCode;
        }
        public long InsertPatientDonor(long PatientID, long PatientVisitID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pInsertPatientDonorCommand(PatientID, PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertPatientDonor", ex);
            }
            return returnCode;
        }
        public long InsertBloodRequest(long PatientID, long PatientVisitID, long OrgID, DateTime RequestDate, DateTime TransfusionScheduledDate,
                                       string Status,string ClinicalIndication,long CrossMatchingMethod,string HasPrevTrans,long PrevTransComponent,
                                       DateTime PrevTransDate,string PrevTransReaction,string IsPregnant,string PregnancyDetails,
            List<BloodRequistionDetails> lstBloodRequest)
        {
            long returnCode = -1;
            DataTable dtBloodRequest = UDT_DAL.ConvertToUDTBloodRequest(lstBloodRequest);
            try
            {
                SqlCommand objCommand = Command.pInsertBloodRequestDetailsCommand(PatientID, PatientVisitID, OrgID, RequestDate, TransfusionScheduledDate,
									Status, ClinicalIndication, CrossMatchingMethod, HasPrevTrans, PrevTransComponent,
								  PrevTransDate, PrevTransReaction, IsPregnant, PregnancyDetails, dtBloodRequest,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertBloodRequest", ex);
            }
            return returnCode;
        }

        public long GetBloodComponent(string PrefixText,long BloodComponentID,  out List<Products> lstproducts)
        {
            long returnCode = -1;
            lstproducts = new List<Products>();
            try
            {
                SqlCommand cmd = Command.PgetBloodComponentCommand(PrefixText, BloodComponentID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstproducts);
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertPatientDonor", ex);
            }
            return returnCode;
        }



        public long InsertBloodSeparationDetails(List<BloodSeparationDetails> lstBloodSeparation)
        {
            long returnCode = -1;
            try
            {
                
                DataTable dtBloodSeparation = UDT_DAL.ConvertToUDTBloodSeparation(lstBloodSeparation);

                SqlCommand cmd = new SqlCommand();
                cmd = Command.PinsertBloodSeparationDetailsCommand(dtBloodSeparation, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertBloodSeparationDetails", ex);
            }
            return returnCode;
        }


        public long GetBloodIssuedComponents(long PatientVisitID, long FinalbillID,out List<BillingDetails> lstBloodBillingdetails)
        {
            long returnCode = -1;
            lstBloodBillingdetails = new List<BillingDetails>();
            try
            {
              
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PgetBloodIssuedComponentsCommand(PatientVisitID,FinalbillID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBloodBillingdetails);
                }
              
              
               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetBloodIssuedComponents", ex);
            }
            return returnCode;
        }

     
      
    }
}
