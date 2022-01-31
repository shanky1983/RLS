using System;
using System.Data;
using System.Configuration;
using System.Web;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class BloodBank_BL
    {
         ContextDetails globalContextDetails;
        public BloodBank_BL()
        {

        }
        public BloodBank_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long InsertOrUpdateDonorStatus(long visitID, string PS1, string PS2, string TS1, string TS2, string ES1, string ES2)
        {
            long returnCode = -1;
            try
            {
                BloodBank_DAL DAL = new BloodBank_DAL(globalContextDetails);
                returnCode = DAL.InsertOrUpdateDonorStatus(visitID, PS1, PS2, TS1, TS2, ES1, ES2);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing InsertOrUpdateDonorStatus Patient_BL", e);
            }
            return returnCode;
        }
        public long GetDonorDetailsAndStatus(long patientVisitId, out List<PatientVisitDetails> lstPatientVisitDetails, out List<DonorStatus> lstDonorStatus)
        {
            long returnCode = -1;
            lstPatientVisitDetails = new List<PatientVisitDetails>();
            lstDonorStatus = new List<DonorStatus>();
            try
            {

                BloodBank_DAL objDAL = new BloodBank_DAL(globalContextDetails);
                returnCode = objDAL.GetDonorDetailsAndStatus(patientVisitId, out lstPatientVisitDetails, out lstDonorStatus);

            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing GetDonorDetailsAndStatus method", ex);
            }

            return returnCode;
        }
        public long InsertBloodCollectionDetails(long VisitID, List<BloodCollectionDetails> lstBloodCollection, List<BloodCapturedDetials> lstBloodCapture, long OrgID, long OrgAddressID,long UserID,long RoleID, long LocationID)
        {
            long returnCode = -1;
            try
            {
                BloodBank_DAL objPatientDAL = new BloodBank_DAL(globalContextDetails);
                returnCode = objPatientDAL.InsertBloodCollectionDetails(VisitID, lstBloodCollection, lstBloodCapture, OrgID, OrgAddressID,UserID,RoleID, LocationID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertBloodCollectionDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetBloodGroupsAndComponents(out List<BloodGroup> lstBloodGrp, out List<BloodComponent> lstBloodComponent)
        {
            long returnCode = -1;
            lstBloodGrp = new List<BloodGroup>();
            lstBloodComponent = new List<BloodComponent>();
            try
            {

                BloodBank_DAL objDAL = new BloodBank_DAL(globalContextDetails);
                returnCode = objDAL.GetBloodGroupsAndComponents(out lstBloodGrp, out lstBloodComponent);

            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing GetBloodGroupsAndComponents method", ex);
            }

            return returnCode;
        }
        public long SearchBloodBag(string BagNo, string BagType, string BloodGroup, string BloodType, int OrgID, out List<BloodCollectionDetails> lstBloodCollection)
        {
            long returnCode = -1;
            lstBloodCollection = new List<BloodCollectionDetails>();
            try
            {

                BloodBank_DAL objDAL = new BloodBank_DAL(globalContextDetails);
                returnCode = objDAL.SearchBloodBag(BagNo, BagType, BloodGroup, BloodType, OrgID, out lstBloodCollection);

            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing SearchBloodBag method", ex);
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
                returnCode = new BloodBank_DAL(globalContextDetails).GetPatientHistoryPKGEditForBloodBank(visitID, LoginID, SpecialityID, OrgID, out lstPHA, out lstDrugDetails, out lstGPALDetails, out lstANCPatientDetails, out lstPPVH, out lstPCA, out lstSurgicalDetails, out lsthisPCA, out lsthisPHA);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetPatientHistoryPKGEdit", ex);
            }
            return returnCode;
        }
        public long GetBloodRequestDetails(long patientID, long visitID,DateTime FromDate,DateTime ToDate, out long BloodRequestNumber, out List<BloodRequistionDetails> lstBloodRequest,out List<Patient> lstPatient)
        {
            long returnCode = -1;
            BloodRequestNumber = 0;
            lstBloodRequest = new List<BloodRequistionDetails>();
            lstPatient = new List<Patient>();
            try
            {
                returnCode = new BloodBank_DAL(globalContextDetails).GetBloodRequestDetails(patientID, visitID,FromDate,ToDate, out BloodRequestNumber,out lstBloodRequest,out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetBloodRequestDetails", ex);
            }

            return returnCode;
        }
        public long InsertPatientDonor(long PatientID, long PatientVisitID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BloodBank_DAL(globalContextDetails).InsertPatientDonor(PatientID, PatientVisitID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL InsertPatientDonor", ex);
            }
            return returnCode;
        }
        public long InsertBloodRequest(long PatientID, long PatientVisitID, long OrgID, DateTime RequestDate, DateTime TransfusionScheduledDate,
                                       string Status, string ClinicalIndication, long CrossMatchingMethod, string HasPrevTrans, long PrevTransComponent,
                                       DateTime PrevTransDate, string PrevTransReaction, string IsPregnant, string PregnancyDetails, List<BloodRequistionDetails> lstBloodRequest)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BloodBank_DAL(globalContextDetails).InsertBloodRequest(PatientID, PatientVisitID,OrgID,RequestDate,TransfusionScheduledDate,
                                                                    Status,ClinicalIndication,CrossMatchingMethod,HasPrevTrans,PrevTransComponent,
                                                                    PrevTransDate,PrevTransReaction,IsPregnant,PregnancyDetails,lstBloodRequest);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL InsertBloodRequest", ex);
            }
            return returnCode;
        }


        public long GetBloodComponent(string PrefixText, long BloodComponentID , out List<Products> lstproducts)
        {
            long returnCode = -1;
            lstproducts = new List<Products>();
            try
            {
                returnCode = new BloodBank_DAL(globalContextDetails).GetBloodComponent(PrefixText,BloodComponentID,out lstproducts );
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetBloodComponet", ex);
            }
            return returnCode;
        }

        public long InsertBloodSeparationDetails(List<BloodSeparationDetails> lstBloodSeparation)
        {
            long returnCode = -1;
            try
            {
                BloodBank_DAL objPatientDAL = new BloodBank_DAL(globalContextDetails);
                returnCode = objPatientDAL.InsertBloodSeparationDetails(lstBloodSeparation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertBloodSeparationDetails in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetBloodIssuedComponents(long PatientVisitID, long FinalbillID, out List<BillingDetails> lstBloodBillingdetails)
        {
            long returnCode = -1;
            lstBloodBillingdetails = new List<BillingDetails>();
            try
            {
                BloodBank_DAL objPatientDAL = new BloodBank_DAL(globalContextDetails);
                returnCode = objPatientDAL.GetBloodIssuedComponents(PatientVisitID, FinalbillID,out lstBloodBillingdetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertBloodSeparationDetails in Patient_BL", ex);
            }
            return returnCode;
        }
    }
}
