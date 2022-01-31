using System;
using System.Data;
using System.Configuration;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using System.Linq;
using Attune.Podium.Common;
using Attune.Podium.BillingEngine;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Attune.Solution.BusinessComponent;
using System.Text;
using System.Security.Cryptography;
using System.Web.UI.HtmlControls;
using Attune.Podium.PerformingNextAction;
using System.Transactions;

//using NUnit.Core;
/// <summary>
/// Summary description for Patient_BL
/// </summary>
//
//[NUnit.Framework.Test]
namespace Attune.Solution.BusinessComponent
{
    public class Patient_BL
    {
        ContextDetails globalContextDetails;
        public Patient_BL()
        {

        }
        public Patient_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }


        public long GetPendingPatientsForVitals(int iOrgID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetPendingPatientsForVitals(iOrgID, out lstPatient);
                foreach (Patient p in lstPatient)
                {
                    p.Name = p.TitleName + ' ' + p.Name;
                }
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPendingPatientsForVitals in Patient_BL", ex);
            }
            return returnCode;
        }


        public long SearchPatient(string iPatientNo, string PatientSmartCardNo, string strPatientName, string strDOB, string strRelation, string strLocation, string strOccupation, string strCity, string strMobile, int currOrgID, int pageSize, int StartRowIndex, out int totalRows, out List<PatientVisit> lsttotalPatientCount, List<TrustedOrgDetails> lstTOD, int parentID, string urno, long urnTypeID, out List<Patient> lstPatient, string strNationality, string TPAID, string ClientID, string pFDate, string pTDate, string pLandLineNum, string Pstatus)
        {
            long returnCode = -1;
            totalRows = 0;
            lstPatient = new List<Patient>();
            lsttotalPatientCount = new List<PatientVisit>();

            try
            {
                Attune.Solution.DAL.Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchPatient(iPatientNo, PatientSmartCardNo, strPatientName, strDOB, strRelation, strLocation, strOccupation, strCity, strMobile, currOrgID, lstTOD, parentID, urno, urnTypeID, pageSize, StartRowIndex, out totalRows, out lsttotalPatientCount, out lstPatient, strNationality, TPAID, ClientID, pFDate, pTDate, pLandLineNum, Pstatus);

                /*-----------------Handle VIP Data Start-------------------------*/
                List<Patient> lsttempDetails = new List<Patient>();
                lsttempDetails = lstPatient.FindAll(p => p.PatientStatus == "VIP");
                lstPatient.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (Patient)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (Patient)Maskedobj;
                    lstPatient.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/

                foreach (Patient patient in lstPatient)
                {
                    patient.Name = patient.TitleName + ' ' + patient.Name;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchPatient in Patient_BL", ex);
            }
            return returnCode;
        }

        public long SearchColumns(int SearchTypeID, int OrgID, out List<DynamicColumnMapping> lstColumn)
        {
            long returnCode = -1;
            lstColumn = new List<DynamicColumnMapping>();
            try
            {
                Attune.Solution.DAL.Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchColumns(SearchTypeID, OrgID, out lstColumn);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchColumns in Patient_BL", ex);
            }
            return returnCode;
        }


        public long SavePatient(Patient objPatient, DateTime pDOBConverted, int pAgeValue, string pAgeUnits, string CreateLogin, string pPicExtension, out string UName, out string Pwd, out string PatientNumber, out long patientID, long ApprovedBy, List<PatientQualification> lstQualification)
        {
            long returnCode = -1;
            UName = string.Empty;
            Pwd = string.Empty;
            PatientNumber = string.Empty;
            patientID = 0;
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                //TODO:validations
                if (objPatient.PatientID > 0)
                {
                    returnCode = objPatientDAL.Updatepatient(objPatient, pDOBConverted, pAgeValue, pAgeUnits, CreateLogin, pPicExtension, out UName, out Pwd, ApprovedBy, lstQualification);
                    PatientNumber = objPatient.PatientNumber;
                    patientID = objPatient.PatientID;
                }
                else
                {
                    returnCode = objPatientDAL.SavePatient(objPatient, pDOBConverted, pAgeValue, pAgeUnits, CreateLogin, pPicExtension, out UName, out Pwd, out PatientNumber, out patientID, lstQualification);
                }

            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing SavePatient in Patient_BL", ex);

            }

            return returnCode;

        }


        //}
        public long GetTableFormat(long OrgID, out List<SmartCardMaster> lstSmtcard)
        {
            long returnCode = -1;
            lstSmtcard = new List<SmartCardMaster>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetTableFormat(OrgID, out lstSmtcard);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetTableFormat in Patient_BL", ex);
            }

            return returnCode;
        }

        public long GetPatientDemoandAddress(long patientID, out List<Patient> patient)
        {
            long returnCode = -1;
            patient = new List<Patient>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetPatientDemoandAddress(patientID, out patient);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientDemoandAddress in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetPatientEMRDetails(long patientID, out List<PhysioCompliant> lstPhysioCompliant, out List<PatientPreferences> lstPatientPreference)
        {
            long returnCode = -1;
            lstPhysioCompliant = new List<PhysioCompliant>();
            lstPatientPreference = new List<PatientPreferences>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetPatientEMRDetails(patientID, out lstPhysioCompliant, out lstPatientPreference);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientEMRDetails in Patient_BL", ex);
            }
            return returnCode;
        }


        public long GetPatientAllergy(int patientID, out List<AllergyMaster> patient)
        {
            long returnCode = -1;
            patient = new List<AllergyMaster>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetPatientAllergy(patientID, out patient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientAllergy in Patient_BL", ex);
            }
            return returnCode;
        }


        public long GetAdmissionPatientDemoandAddress(long patientID, long patientVisitID, string AttributeType, out List<InPatientAdmissionDetails> lstPatient
                                                        , out List<PatientEmployer> lstEmp
                                                        , out List<RTAMLCDetails> lstRTAMLCDetails
                                                        , out List<Patient> lPatient
                                                         , out List<VisitClientMapping> lstVisitClientMapping)
        {
            long returnCode = -1;
            lstPatient = new List<InPatientAdmissionDetails>();
            lstEmp = new List<PatientEmployer>();
            lstRTAMLCDetails = new List<RTAMLCDetails>();
            lPatient = new List<Patient>();
            lstVisitClientMapping = new List<VisitClientMapping>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetAdmissionPatientDemoandAddress(patientID, patientVisitID, AttributeType, out lstPatient, out lstEmp, out lstRTAMLCDetails, out lPatient, out lstVisitClientMapping);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetAdmissionPatientDemoandAddress in Patient_BL", ex);
            }
            return returnCode;
        }


        public long GetEventChart(long patientId, long currentvisitId, string sTreatmentType, out List<EventChart> lstEventChart, out List<PatDtlsVPAction> lstPatDtlsVPAction, out List<PatientDrug> lstPatientDrug, out List<InvestigationPatient> lstInvestigation, out List<PatientExamination> lstExamination, out List<PatientHistory> lstHistory)
        {
            long returnCode = -1;
            lstEventChart = new List<EventChart>();
            lstPatientDrug = new List<PatientDrug>();
            lstInvestigation = new List<InvestigationPatient>();
            lstExamination = new List<PatientExamination>();
            lstHistory = new List<PatientHistory>(); lstPatDtlsVPAction = new List<PatDtlsVPAction>();
            try
            {

                Patient_DAL objEventDAL = new Patient_DAL(globalContextDetails);
                returnCode = objEventDAL.getEventChart(patientId, currentvisitId, sTreatmentType, out lstEventChart, out lstPatDtlsVPAction, out lstPatientDrug, out lstInvestigation, out lstExamination, out lstHistory);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing GetEventChart in Patient_BL", ex);
            }

            return returnCode;
        }


        public long GetTreatment(long patientId, long patientVisitId, out List<PatientDrug> lstPatientDrug)
        {
            long returnCode = -1;
            lstPatientDrug = new List<PatientDrug>();

            try
            {

                Patient_DAL objEventDAL = new Patient_DAL(globalContextDetails);
                returnCode = objEventDAL.GetTreatment(patientId, patientVisitId, out lstPatientDrug);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing GetTreatment in Patient_BL", ex);
            }

            return returnCode;
        }

        public long GetInvestigation(long patientId, long patientVisitId, out List<InvestigationPatient> lstInvestigation)
        {
            long returnCode = -1;
            lstInvestigation = new List<InvestigationPatient>();

            try
            {

                Patient_DAL objEventDAL = new Patient_DAL(globalContextDetails);
                returnCode = objEventDAL.GetInvestigation(patientId, patientVisitId, out lstInvestigation);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing GetInvestigation in Patient_BL", ex);
            }

            return returnCode;
        }

        public long GetPatientExamination(long patientId, long patientVisitId, out List<PatientExamination> lstExamination)
        {
            long returnCode = -1;
            lstExamination = new List<PatientExamination>();

            try
            {

                Patient_DAL objExamDAL = new Patient_DAL(globalContextDetails);
                returnCode = objExamDAL.GetPatientExamination(patientId, patientVisitId, out lstExamination);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing GetPatientExamination in Patient_BL", ex);
            }

            return returnCode;
        }

        public long GetPatientHistory(long patientId, long patientVisitId, out List<PatientHistory> lstHistory)
        {
            long returnCode = -1;
            lstHistory = new List<PatientHistory>();

            try
            {

                Patient_DAL objHistoryDAL = new Patient_DAL(globalContextDetails);
                returnCode = objHistoryDAL.GetPatientHistory(patientId, patientVisitId, out lstHistory);

            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing GetPatientHistory in Patient_BL", ex);
            }

            return returnCode;
        }


        public long GetEventName(int patientId, string txtEvent, out DataSet dataSet)
        {

            dataSet = new DataSet();
            long returnCode = -1;
            try
            {

                Patient_DAL objEventDAL = new Patient_DAL(globalContextDetails);
                returnCode = objEventDAL.GetEventName(patientId, txtEvent, out dataSet);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing GetEventName in Patient_BL", ex);
            }

            return returnCode;
        }

        public long GetEventChartName(long patientId, string txtEventName, out List<EventChart> lstEventChart, out List<PatDtlsVPAction> lstPatDtlsVPAction)
        {

            lstEventChart = new List<EventChart>(); lstPatDtlsVPAction = new List<PatDtlsVPAction>();
            long returnCode = -1;
            try
            {

                Patient_DAL objEventDAL = new Patient_DAL(globalContextDetails);
                returnCode = objEventDAL.GetEventChartName(patientId, txtEventName, out lstEventChart, out lstPatDtlsVPAction);

            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing GetEventChartName in Patient_BL", ex);
            }

            return returnCode;
        }

        public long GetHeaderDetails(int patientId, out List<Patient> lstHeader)
        {
            //dataSet = new DataSet();
            lstHeader = new List<Patient>();
            long returnCode = -1;
            try
            {
                Patient_DAL objHeaderDAL = new Patient_DAL(globalContextDetails);
                returnCode = objHeaderDAL.GetHeaderDetails(patientId, out lstHeader);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing GetHeaderDetails in Patient_BL", ex);
            }
            return returnCode;
        }

        //02/02/2009
        public long GetPatientDetails(string visitPurposeName, string fromDate, string toDate, out List<AdminReports> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<AdminReports>();
            try
            {
                Patient_DAL adminReportsDAL = new Patient_DAL(globalContextDetails);
                returnCode = adminReportsDAL.GetPatientDetails(visitPurposeName, fromDate, toDate, out lstPatient);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing GetPatientDetails in Patient_BL", ex);
            }
            return returnCode;

        }

        public long SavePatientEMRDetails(List<PhysioCompliant> lstPhysioCompliant, long patientID, List<PatientPreferences> PatientPreference)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL PatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = PatientDAL.SavePatientEMRDetails(lstPhysioCompliant, patientID, PatientPreference);
            }

            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SavePatientEMRDetails in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetPatientDetailsPassingVisitID(long visitID, out List<Patient> lstPatient)
        {
            lstPatient = new List<Patient>();
            long returnCode = -1;
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).GetPatientDetailsPassingVisitID(visitID, out lstPatient);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientDetailsPassingVisitID in Patient_BL", ex);
            }
            return returnCode;
        }


        public long GetPatientVitals(long patientVisitID, long patientID, int orgID, out List<Patient> proHeader, out List<VitalsUOMJoin> vitalHeader)
        {
            long result = -1;
            proHeader = new List<Patient>();
            vitalHeader = new List<VitalsUOMJoin>();

            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                result = patientDAL.GetPatientVitals(patientVisitID, patientID, orgID, out proHeader, out vitalHeader);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<Patient> lsttempDetails = new List<Patient>();
                lsttempDetails = proHeader.FindAll(p => p.PatientStatus == "VIP");
                proHeader.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    result = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (Patient)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    result = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (Patient)Maskedobj;
                    proHeader.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing GetANCSpecilaityID in ANC_BL", excp);
            }

            return result;
        }

        public long GetRegistrationStatus(string patientNo, int OrgID, out int count, out List<Patient> lPatientDetails)
        {
            long returnCode = -1;
            count = -1;
            lPatientDetails = new List<Patient>();
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).GetRegistrationStatus(patientNo, OrgID, out count, out lPatientDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetRegistrationStatus_integration in IntegrationBL", ex);
            }
            return returnCode;
        }

        public long getPatientCondition(out List<PatientCondition> lstPatientCondition)
        {
            long returnCode = -1;
            lstPatientCondition = new List<PatientCondition>();
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).getPatientCondition(out lstPatientCondition);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing getPatientCondition in Patient_BL", ex);
            }
            return returnCode;
        }

        public long getRaceDetails(out List<Racemaster> lstRace)
        {
            long returnCode = -1;
            lstRace = new List<Racemaster>();
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).getRaceDetails(out lstRace);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing getRaceDetails in Patient_BL", ex);
            }
            return returnCode;
        }

        public long pGetPatientAllergyDetails(long patientid, List<AllergyMaster> pInvMap)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Patient_DAL(globalContextDetails).pGetPatientAllergyDetails(patientid, pInvMap);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing pGetPatientAllergyDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetInPatientDischargeType(int pOrgID, out List<InPatientDischargeType> lstDischargeType)
        {
            long returnCode = -1;
            lstDischargeType = new List<InPatientDischargeType>();
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).GetInPatientDischargeType(pOrgID, out lstDischargeType);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInPatientDischargeType in Patient_BL", ex);
            }
            return returnCode;
        }


        #region DDC Code Block

        //public long SaveSampleRegistrationDetails(Patient patient, PatientVisit pVisit, PatientAddress pAddress, LabVisitDetails labVisit, out long pVisitID, out long pPatientID)
        //{
        //    long result = -1;
        //    pVisitID = -1;
        //    pPatientID = -1;
        //    try
        //    {
        //        Patient_DAL patientDAL = new  Patient_DAL(globalContextDetails);
        //        result = patientDAL.SaveSampleRegistrationDetails(patient, pVisit, pAddress, labVisit, out pVisitID, out pPatientID);
        //    }
        //    catch (Exception excep)
        //    {
        //        CLogger.LogError("Error while executing SaveSampleRegistrationDetails BL", excep);
        //    }
        //    return result;
        //}

        //public long SaveSampleRegistrationDetails(Patient patient, PatientAddress pAddress, PatientVisit labVisit, out long pVisitID, long OrgAddressID, out long pPatientID, int pAgeValue, string pAgeUnits)
        //{
        //    long result = -1;
        //    pVisitID = -1;
        //    pPatientID = -1;
        //    try
        //    {
        //        Patient_DAL patientDAL = new  Patient_DAL(globalContextDetails);   

        //        result = patientDAL.SaveSampleRegistrationDetails(patient, pAddress, labVisit, OrgAddressID, out pVisitID, out pPatientID,pAgeValue,pAgeUnits);
        //    }
        //    catch (Exception excep)
        //    {
        //        CLogger.LogError("Error while executing SaveSampleRegistrationDetails Patient_BL", excep);
        //    }
        //    return result;
        //}

        public long GetPublishingMode(out List<PublishingMode> lstPublishingMode)
        {
            long returnCode = -1;
            Patient_DAL gPublishingMode = new Patient_DAL(globalContextDetails);
            returnCode = gPublishingMode.GetPublishingMode(out lstPublishingMode);
            return returnCode;
        }
        public long SaveSamplePublishingDetails(ResultPublishing resultPub, PatientAddress pAddress)
        {
            long result = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                result = patientDAL.SaveSamplePublishingDetails(resultPub, pAddress);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing SaveSamplePublishingDetails in Patient_BL", excep);
            }
            return result;
        }
        public long SaveBillDetails(BillMaster billMaster, List<BillLineItems> billItems, out string pBillID, DataTable dtAmountreceived, decimal dserviceCharge)
        {
            long returnCode = -1;
            pBillID = "-1";
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatientDAL.SaveBillDetails(billMaster, billItems, out pBillID, dtAmountreceived, dserviceCharge);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveBillDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        //public long GetBillDetails(long pBillID, out List<BillMaster> billMaster, out List<BillLineItems> billLineItems, out decimal pPreviousDue, out string pPatientName, out string pDrName)
        //{
        //    long returnCode = -1;
        //    Patient_DAL gBillDetails = new  Patient_DAL(globalContextDetails);
        //    returnCode = gBillDetails.GetBillDetails(pBillID, out billMaster, out billLineItems, out pPreviousDue, out pPatientName, out pDrName);
        //    return returnCode;
        //}
        public long GetBillInvestigationDetails(long pVisitID, int pClientID, out List<LabPatientInvestigation> patientInvestigation1, out List<LabPatientInvestigation> patientInvestigation2)
        {
            long returnCode = -1;
            Patient_DAL gGetBillInvestigationDetails = new Patient_DAL(globalContextDetails);
            returnCode = gGetBillInvestigationDetails.GetBillInvestigationDetails(pVisitID, pClientID, out patientInvestigation1, out patientInvestigation2);
            return returnCode;
        }

        public long SearchLabPatient(string strPatientName, string sMobile, int OrgID, long VisitID, long BillID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchLabPatient(strPatientName, sMobile, OrgID, VisitID, BillID, out lstPatient);
                foreach (Patient patient in lstPatient)
                {
                    patient.Name = patient.TitleName + ' ' + patient.Name;
                }
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchLabPatient in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetLabPatientDemoandAddress(long patientID, out List<Patient> patient)
        {
            long returnCode = -1;
            patient = new List<Patient>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetLabPatientDemoandAddress(patientID, out patient);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetLabPatientDemoandAddress in Patient_BL", ex);
            }
            return returnCode;
        }
        public long SearchBill(string strBillNo, string strBillFromDate, string strBillToDate, string strPatientName, string strDrName, string strHospitalName, string clientID, int OrgID, out List<BillSearch> billSearch)
        {
            long returnCode = -1;
            billSearch = new List<BillSearch>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchBill(strBillNo, strBillFromDate, strBillToDate, strPatientName, strDrName, strHospitalName, clientID, OrgID, out billSearch);
                foreach (BillSearch bill in billSearch)
                {
                    bill.Name = bill.TitleName + ' ' + bill.Name;
                }
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchBill in Patient_BL", ex);
            }
            return returnCode;
        }
        //Modified by Perumal on 29 Oct 2011 - Start
        public long SearchBillOptionDetails(string strBillNo, string strBillFromDate, string strBillToDate, string strPatientName, int iphysicianID, int OrgID, string PatientNumber, string ClientID, string VisitNumber,string BarcodeNumber, string CaseNumber, out List<BillSearch> billSearch, int pageSize, int StartRowIndex, out int totalRows,int LocationID)
        {
            long returnCode = -1;
            totalRows = 0;
            billSearch = new List<BillSearch>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchBillOptionDetails(strBillNo, strBillFromDate, strBillToDate, strPatientName, iphysicianID, OrgID, PatientNumber, ClientID, VisitNumber,BarcodeNumber, CaseNumber, out billSearch, pageSize, StartRowIndex, out totalRows,LocationID);
                foreach (BillSearch bill in billSearch)
                {
                    bill.Name = bill.TitleName + ' ' + bill.Name;
                }
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchBillOptionDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        //Modified by Perumal on 29 Oct 2011 - End
        public long SearchpGetCorporatePrescription(string PrescriptionNo, string strFromDate, string strToDate, string strName, int OrgID, string Number, string DepType, string IsCorp, int pageSize, int StartRowIndex, out int totalRows, out List<PatientPrescription> lstPrescription, string Status)
        {
            long returnCode = -1;
            totalRows = 0;
            lstPrescription = new List<PatientPrescription>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchpGetCorporatePrescription(PrescriptionNo, strFromDate, strToDate, strName, OrgID, Number, DepType, IsCorp, pageSize, StartRowIndex, out totalRows, out lstPrescription, Status);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchpGetCorporatePrescription in Patient_BL", ex);
            }
            return returnCode;
        }

        public long SearchReceiptDetails(string strBillNo, string strReceiptFromDate, string strReceiptToDate, string strPatientName, string strPatientNo, int OrgID, int pType, string VisitID, int Page_Index, int Page_Count, out int total_rows, out List<BillSearch> billSearch)
        {
            long returnCode = -1;
            billSearch = new List<BillSearch>();
            total_rows = 0;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchReceiptDetails(strBillNo, strReceiptFromDate, strReceiptToDate, strPatientName, strPatientNo, OrgID, pType, VisitID, Page_Index, Page_Count, out total_rows, out billSearch);
                foreach (BillSearch bill in billSearch)
                {
                    bill.Name = bill.TitleName + ' ' + bill.Name;
                }
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchReceiptDetails in Patient_BL", ex);
            }
            return returnCode;
        }


        public long GetReferingPhysician(string FilterText, int OrgID, out List<ReferingPhysician> lstReferingPhysician)
        {
            long returnCode = -1;
            lstReferingPhysician = new List<ReferingPhysician>();
            try
            {

                Patient_DAL gReferingPhysician = new Patient_DAL(globalContextDetails);
                returnCode = gReferingPhysician.GetReferingPhysician(FilterText, OrgID, out lstReferingPhysician);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetReferingPhysician in Patient_BL", e);
            }
            return returnCode;
        }


        public long GetInvClientMaster(int OrgID, string Status, out List<InvClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            Patient_DAL gInvClientMaster = new Patient_DAL(globalContextDetails);
            returnCode = gInvClientMaster.GetInvClientMaster(OrgID, out lstInvClientMaster);
            return returnCode;
        }

        public long GetInvClientType(out List<InvClientType> lstInvClientType)
        {
            long returnCode = -1;
            Patient_DAL gInvClientType = new Patient_DAL(globalContextDetails);
            returnCode = gInvClientType.GetInvClientType(out lstInvClientType);
            return returnCode;
        }
        public long GetPreviousDue(long pPatientID, int pOrgID, out decimal pPreviousDue)
        {
            long returnCode = -1;
            Patient_DAL gPreviousDue = new Patient_DAL(globalContextDetails);
            returnCode = gPreviousDue.GetPreviousDue(pPatientID, pOrgID, out pPreviousDue);
            return returnCode;
        }
        //public long SaveLabVisitDetails(LabVisitDetails labVisit)
        //{
        //    long returnCode = -1;
        //    try
        //    {
        //        Patient_DAL objPatientDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = objPatientDAL.SaveLabVisitDetails(labVisit);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while executing SaveLabVisitDetails", ex);
        //    }
        //    return returnCode;
        //}

        public long SaveLabVisitDetails(PatientVisit labVisit, out long pVisitID)
        {
            pVisitID = -1;
            long returnCode = -1;
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatientDAL.SaveLabVisitDetails(labVisit, out pVisitID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveLabVisitDetails in Patient_BL", ex);
            }
            return returnCode;
        }

        //public long GetSearchActionsByPage(int roleID, string type, out List<SearchActions> sActions)
        //{
        //    long returnCode = -1;
        //    sActions = null;
        //    try
        //    {
        //        Patient_DAL nDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = nDAL.GetSearchActionsByPage(roleID, type, out sActions);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing GetSearchActionsByPage BL", excp);
        //    }
        //    return returnCode;
        //}
        public long SearchBillSummary(string strBillNo, string strBillFromDate, string strBillToDate, string strPatientName, string strDrName, string strHospitalName, string clientID, string collectionCentreID, int OrgID, int flag, out List<BillSearch> billSearch)
        {
            long returnCode = -1;
            billSearch = new List<BillSearch>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchBillSummary(strBillNo, strBillFromDate, strBillToDate, strPatientName, strDrName, strHospitalName, clientID, collectionCentreID, OrgID, flag, out billSearch);
                foreach (BillSearch bill in billSearch)
                {
                    bill.Name = bill.TitleName + ' ' + bill.Name;
                }
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchBillSummary in Patient_BL", ex);
            }
            return returnCode;
        }

        public long SaveReferingPhysician(ReferingPhysician refPhy, List<AddressDetails> lstrefPhyAddDtls, List<PhysicianOrgMapping> POM, int LoginID, out int pRefPhyID, out  List<ReferingPhysician> lstPhysician, out long PhysicianRoleID)
        {

            long result = -1;
            PhysicianRoleID = 0;
            lstPhysician = new List<ReferingPhysician>();
            pRefPhyID = -1;

            try
            {

                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);

                result = patientDAL.SaveReferingPhysician(refPhy, lstrefPhyAddDtls, POM, LoginID, out pRefPhyID, out lstPhysician, out PhysicianRoleID);

            }

            catch (Exception excep)
            {

			CLogger.LogError("Error while executing SaveReferingPhysician in Patient_BL", excep);

            }

            return result;

        }
        public long GetLabDiscount(int OrgID, out List<DiscountMaster> lstDiscountMaster)
        {
            long returnCode = -1;
            Patient_DAL gDiscount = new Patient_DAL(globalContextDetails);
            returnCode = gDiscount.GetLabDiscount(OrgID, out lstDiscountMaster);
            return returnCode;
        }
        public long GetLabRefOrg(int OrgID, int ClientTypeID, string Status, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long returnCode = -1;
            Patient_DAL gLabRefOrg = new Patient_DAL(globalContextDetails);
            returnCode = gLabRefOrg.GetLabRefOrg(OrgID, ClientTypeID, Status, out lstLabRefOrg);
            return returnCode;
        }
        public long GetLabRefOrgAddress(long LabRefOrgID, out List<LabRefOrgAddress> lstLabRefOrgAddress)
        {
            long returnCode = -1;
            Patient_DAL gLabRefOrgAddress = new Patient_DAL(globalContextDetails);
            returnCode = gLabRefOrgAddress.GetLabRefOrgAddress(LabRefOrgID, out lstLabRefOrgAddress);
            return returnCode;
        }
        public long GetLabRefOrgDetailandAddress(long LabRefOrgID, out List<LabReferenceOrg> lstLabRefOrg, out List<LabRefOrgAddress> lstLabRefOrgAddress)
        {
            long returnCode = -1;
            Patient_DAL gLabDetailandAddress = new Patient_DAL(globalContextDetails);
            returnCode = gLabDetailandAddress.GetLabRefOrgDetailandAddress(LabRefOrgID, out lstLabRefOrg, out lstLabRefOrgAddress);
            return returnCode;
        }
        public long SaveLabRefOrgDetailandAddress(LabReferenceOrg LabRefOrg, LabRefOrgAddress LabRefOrgAddress)
        {
            long result = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                result = patientDAL.SaveLabRefOrgDetailandAddress(LabRefOrg, LabRefOrgAddress);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing SaveLabRefOrgDetailandAddress in Patient_BL", excep);
            }
            return result;
        }
        public long UpdateLabRefOrgDetailandAddress(LabReferenceOrg LabRefOrg, LabRefOrgAddress LabRefOrgAddress)
        {
            long result = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                result = patientDAL.UpdateLabRefOrgDetailandAddress(LabRefOrg, LabRefOrgAddress);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing UpdateLabRefOrgDetailandAddress in Patient_BL", excep);
            }
            return result;
        }
        #endregion

        public long CheckPatientforDuplicate(string patientName, string mobileNo, string llNo, int orgID, string patientNumber, out int count)
        {
            long returnCode = -1;
            count = -1;
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).CheckPatientforDuplicate(patientName, mobileNo, llNo, orgID, patientNumber, out count);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing CheckPatientforDuplicate in Patient_BL", ex);
            }
            return returnCode;
        }

        public long RegistrationDeflag(long VisitId, long OrgId)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL adminReportsDAL = new Patient_DAL(globalContextDetails);
                returnCode = adminReportsDAL.RegistrationDeflag(VisitId, OrgId);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing RegistrationDeflag in Patient_BL", ex);
            }
            return returnCode;

        }

        public long SavePatientEmployer(PatientEmployer pEmployer,
            InPatientAdmissionDetails IPDetails,
            RTAMLCDetails objRTAMLC, List<PrimaryConsultant> lstPrimaryConsultant, int OrgID,
             long ReferingPhysicianID, string ReferingPhysicianName, int ReferingSpecialityID,
            string PhysicianType, string IsCreditBill,
            decimal CreditLimit, string CreditLimitApprover, string CreditLimitRemarks, int RoomTypeID,
            string IsSurgeryPatient, List<VisitClientMapping> lstVisitClientMapping)
        {
            long returnCode = -1;
            try
            {

                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                //TODO:validations
                returnCode = objPatientDAL.SavePatientEmployer(pEmployer, IPDetails,
                            objRTAMLC, lstPrimaryConsultant, OrgID, IsCreditBill, ReferingPhysicianID,
                            ReferingPhysicianName, ReferingSpecialityID, PhysicianType, CreditLimit, CreditLimitApprover,
                            CreditLimitRemarks, RoomTypeID, IsSurgeryPatient, lstVisitClientMapping);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing SavePatientEmployer in Patient_BL", ex);
            }

            return returnCode;

        }


        public long UpdatePatientEmployer(PatientEmployer pEmployer, InPatientAdmissionDetails IPDetails,
           RTAMLCDetails objRTAMLC, List<PrimaryConsultant> lstPrimaryConsultant,
           int OrgID, string IsCredit, long ReferingPhysicianID, string ReferingPhysicianName,
           int ReferingSpecialityID, string PhysicianType, decimal CreditLimit, string CreditLimitApprover,
            string CreditLimitRemarks, int RoomTypeID, string IsSurgeryPatient, List<VisitClientMapping> lstVisitClientMapping)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                //TODO:validations
                returnCode = objPatientDAL.UpdatePatientEmployer(pEmployer, IPDetails,
                                                                  objRTAMLC, lstPrimaryConsultant, OrgID,
                                                                IsCredit, ReferingPhysicianID, ReferingPhysicianName,
                                                                ReferingSpecialityID, PhysicianType,
    CreditLimit, CreditLimitApprover, CreditLimitRemarks, RoomTypeID, IsSurgeryPatient, lstVisitClientMapping);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing UpdatePatientEmployer in Patient_BL", ex);
            }

            return returnCode;

        }



        public long SavePatientOrganDonation(List<OrganRegWithMapping> orgMap, long VisitID)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                //TODO:validations


                returnCode = objPatientDAL.SavePatientOrganDonation(orgMap, VisitID);

            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing SavePatientOrganDonation in Patient_BL", ex);

            }

            return returnCode;

        }

        //public long GetSimilarPatientsByName(string patienName, int orgID, out List<Patient> lstPatient1, out List<Patient> lstPatient2)
        //{
        //    long returnCode = -1;
        //    lstPatient1 = new List<Patient>();
        //    lstPatient2 = new List<Patient>();

        //    try
        //    {
        //        returnCode = new Patient_BL().GetSimilarPatientsByName(patienName, orgID, out lstPatient1, out lstPatient2);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL GetSimilarPatientsByName", ex);
        //    }

        //    return returnCode;
        //}

        public long SearchInPatient(string inPatientNo, string strSmartCardNo, string strPatientName, string roomNo, string strDOB, string strCellNo, string strPurpose, int orgID, int parentID, string ipNo, string needDischarge, string strNationality, string pTPAID, string pClientID, string pFDate, string pTDate, string AdfromDate1, string AdToDate1, int pageSize, int StartRowIndex, int VisitPurposeID, out int totalRows, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            totalRows = 0;
            lstPatient = new List<Patient>();
            try
            {
                Attune.Solution.DAL.Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchInPatient(inPatientNo, strSmartCardNo, strPatientName, roomNo, strDOB, strCellNo, strPurpose, orgID, parentID, ipNo, needDischarge, strNationality, pTPAID, pClientID, pFDate, pTDate, AdfromDate1, AdToDate1, pageSize, StartRowIndex, VisitPurposeID, out totalRows, out lstPatient);

                foreach (Patient patient in lstPatient)
                {
                    patient.Name = patient.TitleName + ' ' + patient.Name;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInPatient in Patient_BL", ex);
            }
            return returnCode;
        }
        public long pCheckPatientisIPorOP(long pPatientVisitID, long pPatientID, int pOrgID, out string outStatus)
        {
            long returnCode = -1;
            outStatus = string.Empty;
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).pCheckPatientisIPorOP(pPatientVisitID, pPatientID, pOrgID, out outStatus);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing pCheckPatientisIPorOP in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetReportTemplate(long patientVisitID, int OrgID, string ReportLanguage, out List<InvReportMaster> lstReportMaster, out List<InvReportMaster> lstReportName, out List<InvDeptMaster> lstDpts)
        {
            long returnCode = -1;
            lstReportMaster = new List<InvReportMaster>();
            lstReportName = new List<InvReportMaster>();
            lstDpts = new List<InvDeptMaster>();
            try
            {
                Patient_DAL objPatientBl = new Patient_DAL(globalContextDetails);
                objPatientBl.GetReportTemplate(patientVisitID, OrgID, ReportLanguage, out lstReportMaster, out lstReportName, out lstDpts);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetReportTemplate in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetInvestigationDrug(int orgID, string filtertxt, out List<PatientPrescription> lstPrescription)
        {
            long returnCode = -1;
            lstPrescription = new List<PatientPrescription>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetInvestigationDrug(orgID, filtertxt, out lstPrescription);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetInvestigationDrug in Patient_BL", excep);
            }
            return returnCode;
        }

        public long InsertPatientFromReferredOrg(long pID, int pOrgID, out long pRefOrgPID)
        {
            long returnCode = -1;
            pRefOrgPID = -1;
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).InsertPatientFromReferredOrg(pID, pOrgID, out pRefOrgPID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertPatientFromReferredOrg in Patient_BL", ex);
            }

            return returnCode;
        }
        //public long GetLabVisitDetails(long visitID, int OrgID, out List<LabVisitDetails> lstVisitDetails)
        //{
        //    long returnCode = -1;
        //    lstVisitDetails = new List<LabVisitDetails>();
        //    try
        //    {
        //        Patient_DAL pDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = pDAL.GetLabVisitDetails(visitID, OrgID, out lstVisitDetails);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while GetLabVisitDetails Patient_BL", ex);
        //    }
        //    return returnCode;
        //}

        public long GetLabVisitDetails(long visitID, int OrgID, out List<PatientVisit> pVisitDetails)
        {
            long returnCode = -1;
            pVisitDetails = new List<PatientVisit>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetLabVisitDetails(visitID, OrgID, "", out pVisitDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetLabVisitDetails in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetLabVisitDetails(long visitID, int OrgID, string UID, out List<PatientVisit> pVisitDetails)
        {
            long returnCode = -1;
            pVisitDetails = new List<PatientVisit>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetLabVisitDetails(visitID, OrgID, UID, out pVisitDetails);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<PatientVisit> lsttempDetails = new List<PatientVisit>();
                lsttempDetails = pVisitDetails.FindAll(p => p.PatientStatus == "VIP");
                pVisitDetails.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (PatientVisit)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (PatientVisit)Maskedobj;
                    pVisitDetails.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetLabVisitDetails-with UID in Patient_BL", ex);
            }
            return returnCode;
        }



        public long GetReportTemplateForDept(long patientVisitID, string InvIDs, long roleID, int OrgID, string Uid, out List<InvReportMaster> lstReportMaster, out List<InvReportMaster> lstReportName)
        {
            long returnCode = -1;
            lstReportMaster = new List<InvReportMaster>();
            lstReportName = new List<InvReportMaster>();
            try
            {
                Patient_DAL objPatientBl = new Patient_DAL(globalContextDetails);
                returnCode = objPatientBl.GetReportTemplateForDept(patientVisitID, InvIDs, roleID, OrgID, Uid, out lstReportMaster, out lstReportName);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetReportTemplate in Patient_BL", e);
            }
            return returnCode;
        }

        //new one for lab
        public long GetPriorityMaster(out List<PriorityMaster> lstPriorityMaster)
        {
            lstPriorityMaster = new List<PriorityMaster>();
            long returnCode = -1;
            try
            {
                Patient_DAL patDAL = new Patient_DAL(globalContextDetails);
                returnCode = patDAL.GetPriorityMaster(out lstPriorityMaster);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPriorityMaster in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetCollectionCentre(int OrgID, out List<CollectionCentreMaster> lstCollectionCentre)
        {
            long returnCode = -1;
            Patient_DAL gCollectionCentre = new Patient_DAL(globalContextDetails);
            returnCode = gCollectionCentre.GetCollectionCentre(OrgID, out lstCollectionCentre);
            return returnCode;
        }

        public long GetSummaryReportData(int OrgID, out List<InvClientMaster> getInvClientMaster,
                                out List<ReferingPhysician> getReferingPhysician,
                                out  List<CollectionCentreMaster> getCollectionCentre,
                                out List<LabReferenceOrg> RefOrg,
                                out List<PatientInvestigation> lstInvestigation,
                                out List<LabSummaryReportParameter> getLabSummaryReportParameter
                                , out List<InvDeptMaster> lDeptmaster)
        {
            long returnCode = -1;
            getInvClientMaster = new List<InvClientMaster>();
            getReferingPhysician = new List<ReferingPhysician>();
            getCollectionCentre = new List<CollectionCentreMaster>();
            RefOrg = new List<LabReferenceOrg>();
            lstInvestigation = new List<PatientInvestigation>();
            getLabSummaryReportParameter = new List<LabSummaryReportParameter>();
            lDeptmaster = new List<InvDeptMaster>();
            new Patient_DAL(globalContextDetails).GetSummaryReportData(OrgID, out getInvClientMaster, out getReferingPhysician,
                                                   out getCollectionCentre, out RefOrg, out lstInvestigation
                                                   , out getLabSummaryReportParameter, out lDeptmaster);
            return returnCode;
        }


        public long GetDeptwiseReport(long UserID, long DeptId, DateTime FromDate, DateTime ToDate, int OrgID, int SplitUp, out List<DailyReport> lDailyReport, out List<DailyReport> lDeptName, out List<LabConsumables> lstLabConsumables, out decimal GrandTotal, out decimal TotalCashAmount, out decimal TotalDiscountAmount, out decimal TotalPaidAmount, out decimal TotalDuePaidAmount, out decimal CombinedDeptAmount)
        {
            long returnCode = -1;
            lDailyReport = new List<DailyReport>();
            lDeptName = new List<DailyReport>();
            lstLabConsumables = new List<LabConsumables>();
            GrandTotal = 0;
            TotalCashAmount = 0;
            TotalDiscountAmount = 0;
            TotalDuePaidAmount = 0;
            TotalPaidAmount = 0;
            CombinedDeptAmount = 0;
            try
            {
                new Patient_DAL(globalContextDetails).GetDeptwiseReport(UserID, DeptId, FromDate, ToDate, OrgID, SplitUp, out lDailyReport, out lDeptName, out lstLabConsumables, out GrandTotal, out TotalCashAmount, out TotalDiscountAmount, out TotalPaidAmount, out TotalDuePaidAmount, out CombinedDeptAmount);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDeptwiseReport in Patient_BL", ex);
            }
            return returnCode;
        }

        public long SearchBillByParameter(DateTime strBillFromDate, DateTime strBillToDate, int ReferingPhysicianID, long HospitalID, int clientID, int collectionCentreID, int InsuranceID, int OrgID, int flag, out List<DailyReport> billSearch, out List<BillLineItems> billItems, out decimal GrandTotal)
        {
            long returnCode = -1;
            GrandTotal = 0;
            billSearch = new List<DailyReport>();
            billItems = new List<BillLineItems>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchBillByParameter(strBillFromDate, strBillToDate, ReferingPhysicianID, HospitalID, clientID, collectionCentreID, InsuranceID, OrgID, flag, out billSearch, out billItems, out GrandTotal);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchBillByParameter in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetReferingPhysician(int OrgID, string physicianName, string Status, out List<ReferingPhysician> lstReferingPhysician)
        {
            long returnCode = -1;
            Patient_DAL gReferingPhysician = new Patient_DAL(globalContextDetails);
            returnCode = gReferingPhysician.GetReferingPhysician(OrgID, physicianName, Status, out lstReferingPhysician);
            return returnCode;
        }
        public long UpdateLabVisitDetails(PatientVisit labVisit)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.UpdateLabVisitDetails(labVisit);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing UpdateLabVisitDetails in Patient_BL", excep);
            }
            return returnCode;
        }
        public long GetBillDetails(string pBillID, int OrgID, out List<BillMaster> billMaster, out List<BillLineItems> billLineItems, out List<PatientVisit> labVisitDetails)
        {
            long returnCode = -1;
            Patient_DAL gBillDetails = new Patient_DAL(globalContextDetails);
            returnCode = gBillDetails.GetBillDetails(pBillID, OrgID, out billMaster, out billLineItems, out labVisitDetails);
            return returnCode;
        }
        public long CancelBillDetails(string pBillID, int OrgID, long LID, string comments)
        {
            long returnCode = -1;
            Patient_DAL cancelBillDetails = new Patient_DAL(globalContextDetails);
            returnCode = cancelBillDetails.CancelBillDetails(pBillID, OrgID, LID, comments);
            return returnCode;
        }



        public long LoadUserList(int orgID, out List<Attune.Podium.BusinessEntities.Login> lstUsers)
        {
            long returnCode = -1;
            lstUsers = new List<Attune.Podium.BusinessEntities.Login>();
            try
            {
                new Patient_DAL(globalContextDetails).LoadUserList(orgID, out lstUsers);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing LoadUserList in Patient_BL", ex);
            }
            return returnCode;
        }
        public long UpdateDispatchDetails(long visitID, int OrgID)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.UpdateDispatchDetails(visitID, OrgID);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateDispatchDetails in Patient_BL", excep);
            }
            return returnCode;
        }
        public long ChangePriority(long VisitID, int OrgID, long LID, int PriorityID)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatientDAL.ChangePriority(VisitID, OrgID, LID, PriorityID);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing ChangePriority in Patient_BL", e);
            }
            return returnCode;
        }
        public long UpdateLabPatientDetails(Patient patient, PatientAddress pAddress)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.UpdateLabPatientDetails(patient, pAddress);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing UpdateLabPatientDetails in Patient_BL", excep);
            }
            return returnCode;
        }
        public long GetDispatchDetails(long visitID, int OrgID, out List<PatientVisit> lstVisitDetails, out List<PatientAddress> lstPatientAddress, out List<ResultPublishing> lstResultPublishing, out List<ShippingAddress> lstShippingAddress, out List<PatientInvestigation> lstPatientInvestigation1, out List<PatientInvestigation> lstPatientInvestigation2, out List<CollectedSample> lstOrderedInvSample)
        {
            long returnCode = -1;
            lstVisitDetails = new List<PatientVisit>();
            lstPatientAddress = new List<PatientAddress>();
            lstResultPublishing = new List<ResultPublishing>();
            lstShippingAddress = new List<ShippingAddress>();
            lstPatientInvestigation1 = new List<PatientInvestigation>();
            lstPatientInvestigation2 = new List<PatientInvestigation>();
            lstOrderedInvSample = new List<CollectedSample>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetDispatchDetails(visitID, OrgID, out lstVisitDetails, out lstPatientAddress, out lstResultPublishing, out lstShippingAddress, out lstPatientInvestigation1, out lstPatientInvestigation2, out lstOrderedInvSample);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDispatchDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long SaveDueCollection(BillMaster objBillMaster, BillLineItems objBillLineItems, out string pNewBillID)
        {
            long returnCode = -1;
            pNewBillID = "-1";
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SaveDueCollection(objBillMaster, objBillLineItems, out pNewBillID);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing SaveDueCollection in Patient_BL", e);
            }
            return returnCode;
        }

        //public long GetLabDiscount(int OrgID, out List<DiscountMaster> lstDiscountMaster)
        //{
        //    long returnCode = -1;
        //    Patient_DAL gDiscount = new  Patient_DAL(globalContextDetails);
        //    returnCode = gDiscount.GetLabDiscount(OrgID, out lstDiscountMaster);
        //    return returnCode;
        //}

        public long GetPrescription(string DrugName, int Filter, int pOrgID, out List<PatientPrescription> lstPrescription, int
            OrgAddressId, int LocationId, long PatientVisitID)
        {
            long lresult = -1;
            lstPrescription = new List<PatientPrescription>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                lresult = patientDAL.GetPrescription(DrugName, Filter, pOrgID, out lstPrescription, OrgAddressId, LocationId, PatientVisitID);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPrescription in Patient_BL", ex);
            }
            return lresult;

        }
        public long UpdateReferingPhysician(ReferingPhysician objReferingPhysician, List<AddressDetails> lstAddressDetails, List<PhysicianOrgMapping> POM, string Deleted)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.UpdateReferingPhysician(objReferingPhysician, lstAddressDetails, POM, Deleted);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateReferingPhysician in Patient_BL", excep);
            }
            return returnCode;
        }

        public long GetPatientLoginDetails(long patientID, out List<Attune.Podium.BusinessEntities.Login> lstLoginDetails)
        {
            long returnCode = -1;
            lstLoginDetails = new List<Attune.Podium.BusinessEntities.Login>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetPatientLoginDetails(patientID, out lstLoginDetails);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetPatientLoginDetails in Patient_BL", excep);
            }
            return returnCode;
        }
        public long GetPatientRegDetails(long patientID, long pID, out List<Patient> patient, out List<PatientAddress> lstPatientAddress, out List<PatientAllergies> lstPatientAllergies)
        {
            long returnCode = -1;
            patient = new List<Patient>();
            lstPatientAddress = new List<PatientAddress>();
            lstPatientAllergies = new List<PatientAllergies>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetPatientRegDetails(patientID, pID, out patient, out lstPatientAddress, out lstPatientAllergies);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientRegDetails in Patient_BL", ex);
            }
            return returnCode;
        }

        public long UpdateRegPatient(Patient objPatient, long LID)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatientDAL.UpdateRegPatient(objPatient, LID);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing UpdateRegPatient in Patient_BL", ex);
            }

            return returnCode;

        }



        public long GetURNType(out List<URNTypes> objURNTypes, out List<URNof> objURNof)
        {
            long returnCode = -1;
            objURNTypes = new List<URNTypes>();
            objURNof = new List<URNof>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetURNType(out objURNTypes, out objURNof);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetURNType in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetSpecies(int OrgID,out List<Species> objSpecies)
        {
            long returnCode = -1;
            objSpecies = new List<Species>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetSpecies(OrgID, out objSpecies);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSpecies in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetInvDepartment(long orgID, out List<InvDeptMaster> lDeptMaster)
        {
            long returnCode = -1;
            lDeptMaster = new List<InvDeptMaster>();
            try
            {
                new Patient_DAL(globalContextDetails).GetInvDepartment(orgID, out lDeptMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDeptwiseReport in Patient_BL", ex);
            }
            return returnCode;
        }




        public long CheckURNoAvailablity(long pID, out string pURNo, out int pURNORGid)
        {
            long returnCode = -1;

            pURNo = string.Empty;
            pURNORGid = -1;
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).CheckURNoAvailablity(pID, out pURNo, out pURNORGid);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing CheckURNoAvailablity in Patient_BL", ex);
            }

            return returnCode;
        }
        //public long InsertPatientFromReferredOrg(long pID, int pOrgID, out long pRefOrgPID)
        //{
        //    long returnCode = -1;
        //    pRefOrgPID = -1;
        //    try
        //    {
        //        returnCode = new  Patient_DAL(globalContextDetails).InsertPatientFromReferredOrg(pID, pOrgID, out pRefOrgPID);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL InsertPatientFromReferredOrg", ex);
        //    }

        //    return returnCode;
        //}
        //public long GetLabVisitDetails(long visitID, int OrgID, out List<LabVisitDetails> lstVisitDetails)
        //{
        //    long returnCode = -1;
        //    lstVisitDetails = new List<LabVisitDetails>();
        //    try
        //    {
        //        Patient_DAL pDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = pDAL.GetLabVisitDetails(visitID, OrgID, out lstVisitDetails);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while GetLabVisitDetails Patient_BL", ex);
        //    }
        //    return returnCode;
        //}
        //public long GetInvestigationMethod(int OrgID, string methodName, string Status, out List<InvestigationMethod> lstInvMethod)
        //{
        //    long returnCode = -1;
        //    lstInvMethod = new List<InvestigationMethod>();
        //    try
        //    {

        //        Patient_DAL patientDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = patientDAL.GetInvestigationMethod(OrgID, methodName, Status, out lstInvMethod);
        //    }
        //    catch (Exception e)
        //    {
        //        CLogger.LogError("Error while executing GetInvestigationMethod Patient_BL", e);
        //    }
        //    return returnCode;
        //}
        //public long GetInvestigationKit(int OrgID, string kitName, string Status, out List<InvKitMaster> lstInvKitMaster)
        //{
        //    long returnCode = -1;
        //    lstInvKitMaster = new List<InvKitMaster>();
        //    try
        //    {

        //        Patient_DAL patientDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = patientDAL.GetInvestigationKit(OrgID, kitName, Status, out lstInvKitMaster);
        //    }
        //    catch (Exception e)
        //    {
        //        CLogger.LogError("Error while executing GetInvestigationKit Patient_BL", e);
        //    }
        //    return returnCode;
        //}
        //public long GetInvestigationInstrument(int OrgID, string instrumentName, string Status, out List<InvInstrumentMaster> lstInvInstrumentMaster)
        //{
        //    long returnCode = -1;
        //    lstInvInstrumentMaster = new List<InvInstrumentMaster>();
        //    try
        //    {

        //        Patient_DAL patientDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = patientDAL.GetInvestigationInstrument(OrgID, instrumentName, Status, out lstInvInstrumentMaster);
        //    }
        //    catch (Exception e)
        //    {
        //        CLogger.LogError("Error while executing GetInvestigationInstrument Patient_BL", e);
        //    }
        //    return returnCode;
        //}
        //public long GetReportTemplateForDept(long patientVisitID, long roleID, int OrgID, out List<InvReportMaster> lstReportMaster, out List<InvReportMaster> lstReportName)
        //{
        //    long returnCode = -1;
        //    lstReportMaster = new List<InvReportMaster>();
        //    lstReportName = new List<InvReportMaster>();
        //    try
        //    {
        //        Patient_DAL objPatientBl = new  Patient_DAL(globalContextDetails);
        //        returnCode = objPatientBl.GetReportTemplateForDept(patientVisitID, roleID, OrgID, out lstReportMaster, out lstReportName);
        //    }
        //    catch (Exception e)
        //    {
        //        CLogger.LogError("Error while executing GetReportTemplate Patient_Bl", e);
        //    }
        //    return returnCode;
        //}
        //public long GetInvDepartment(long orgID, out List<InvDeptMaster> lDeptMaster)
        //{
        //    long returnCode = -1;
        //    lDeptMaster = new List<InvDeptMaster>();
        //    try
        //    {
        //        new  Patient_DAL(globalContextDetails).GetInvDepartment(orgID, out lDeptMaster);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while Exececutin Patient_Dal", ex);
        //    }
        //    return returnCode;
        //}

        //public long SaveInvestigationKit(InvKitMaster InvKitMaster, out long pKitID)
        //{
        //    long returnCode = -1;
        //    pKitID = -1;
        //    try
        //    {
        //        Patient_DAL patientDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = patientDAL.SaveInvestigationKit(InvKitMaster, out pKitID);
        //    }
        //    catch (Exception excep)
        //    {
        //        CLogger.LogError("Error while executing SaveInvestigationKit Patient_BL", excep);
        //    }
        //    return returnCode;
        //}

        //public long UpdateInvestigationKit(InvKitMaster objKitMaster)
        //{
        //    long returnCode = -1;
        //    try
        //    {
        //        Patient_DAL patientDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = patientDAL.UpdateInvestigationKit(objKitMaster);
        //    }
        //    catch (Exception excep)
        //    {
        //        CLogger.LogError("Error while executing UpdateInvestigationKit in Patient_BL", excep);
        //    }
        //    return returnCode;
        //}
        //public long SaveInvestigationMethod(InvestigationMethod InvMethod, out long pMethodID)
        //{
        //    long returnCode = -1;
        //    pMethodID = -1;
        //    try
        //    {
        //        Patient_DAL patientDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = patientDAL.SaveInvestigationMethod(InvMethod, out pMethodID);
        //    }
        //    catch (Exception excep)
        //    {
        //        CLogger.LogError("Error while executing SaveInvestigationMethod Patient_BL", excep);
        //    }
        //    return returnCode;
        //}

        //public long UpdateInvestigationMethod(InvestigationMethod objInvMethod)
        //{
        //    long returnCode = -1;
        //    try
        //    {
        //        Patient_DAL patientDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = patientDAL.UpdateInvestigationMethod(objInvMethod);
        //    }
        //    catch (Exception excep)
        //    {
        //        CLogger.LogError("Error while executing UpdateInvestigationMethod in Patient_BL", excep);
        //    }
        //    return returnCode;
        //}
        public long SavePatientVisitForUpload(long PatientID, long PatientVisitID, int OrgID, int OrgAddressID, int VisitType, string PerformingOrgName,
                                                string PerformingOrgLocation, string DocumentTitle, DateTime docDate, string physicainName, out long PatientOldNotesID)
        {
            long returnCode = -1;
            PatientOldNotesID = 0;
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).SavePatientVisitForUpload(PatientID, PatientVisitID, OrgID, OrgAddressID, VisitType, PerformingOrgName, PerformingOrgLocation, DocumentTitle,
                                                             docDate, physicainName, out PatientOldNotesID);
            }
            catch (Exception ex)
            {

            }
            return returnCode;
        }

        public long SavePatientOldNotesFilemapping(List<PatientOldNotesFileMapping> lblob)
        {
            long returnCode = -1;

            try
            {

                returnCode = new Patient_DAL(globalContextDetails).SavePatientOldNotesFilemapping(lblob);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing SavePatientOldNotesFilemapping in Patient_BL", excep);
            }
            return returnCode;
        }
        public long GetEventChartIsTrustedOrg(long patientId, long currentvisitId, string sTreatmentType, out List<EventChart> lstEventChart, out List<PatDtlsVPAction> lstPatDtlsVPAction, out List<PatientDrug> lstPatientDrug, out List<InvestigationPatient> lstInvestigation, out List<PatientExamination> lstExamination, out List<PatientHistory> lstHistory)
        {
            long returnCode = -1;
            lstEventChart = new List<EventChart>();
            lstPatientDrug = new List<PatientDrug>();
            lstInvestigation = new List<InvestigationPatient>();
            lstExamination = new List<PatientExamination>();
            lstHistory = new List<PatientHistory>(); lstPatDtlsVPAction = new List<PatDtlsVPAction>();
            try
            {

                Patient_DAL objEventDAL = new Patient_DAL(globalContextDetails);
                returnCode = objEventDAL.getEventChartIsTrustedOrg(patientId, currentvisitId, sTreatmentType, out lstEventChart, out lstPatDtlsVPAction, out lstPatientDrug, out lstInvestigation, out lstExamination, out lstHistory);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing GetEventChart in Patient_BL", ex);
            }

            return returnCode;
        }


        public long GetDoctorWiseReport(DateTime strBillFromDate, DateTime strBillToDate, int ReferingPhysicianID, long HospitalID, int clientID, int collectionCentreID, int InsuranceID, int OrgID, int flag, long deptID, out List<DailyReport> lstDoctorWiseReport, out List<DailyReport> lstDisplayName)
        {
            long returnCode = -1;

            lstDoctorWiseReport = new List<DailyReport>();
            lstDisplayName = new List<DailyReport>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetDoctorWiseReport(strBillFromDate, strBillToDate, ReferingPhysicianID, HospitalID, clientID, collectionCentreID, InsuranceID, OrgID, flag, deptID, out lstDoctorWiseReport, out lstDisplayName);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDoctorWiseReport in Patient_BL", ex);
            }
            return returnCode;
        }


        public long GetAllDoctorReport(DateTime strBillFromDate, DateTime strBillToDate, int OrgID, int ReportFormatId, out List<DailyReport> lstAllDoctorWiseReport, out List<DailyReport> lstDisplayName)
        {
            long returnCode = -1;

            lstAllDoctorWiseReport = new List<DailyReport>();
            lstDisplayName = new List<DailyReport>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetAllDoctorReport(strBillFromDate, strBillToDate, OrgID, ReportFormatId, out lstAllDoctorWiseReport, out lstDisplayName);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetAllDoctorReport in Patient_BL", ex);
            }
            return returnCode;
        }
        //public long GetKnowledgeOfServiceByOrgID(int OrgID, out List<KnowledgeOfService> lstKnowledgeOfService)
        //{

        //    long returnCode = -1;
        //    lstKnowledgeOfService =

        //    new List<KnowledgeOfService>();
        //    try
        //    {

        //        Patient_DAL patientDAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = patientDAL.GetKnowledgeOfServiceByOrgID(OrgID,out lstKnowledgeOfService);
        //    }

        //    catch (Exception excep)
        //    {

        //        CLogger.LogError("Error while executing GetKnowledgeOfService in Patient_BL", excep);
        //    }

        //    return returnCode;
        //}



        public long SaveKnowledgeOfServices(long visitID, int OrgID, long LID, List<VisitKnowledgeMapping> lstVisitKnowledgeMapping)
        {
            long returnCode = -1;

            Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
            try
            {


                returnCode = patientDAL.SaveKnowledgeOfServices(visitID, OrgID, LID, lstVisitKnowledgeMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveSurgeryBillingDetails in IP_BL", ex);
            }
            return returnCode;
        }

        public long SaveHistoryPKG(List<PatientHistory> lstPatientHisPKG,
            List<PatientHistoryAttribute> lstPatientHisPKGAttributes,
            List<DrugDetails> lstdruglist,
            List<PatientPastVaccinationHistory> lstVaccHis,
            List<GPALDetails> lstGPALDetails,
            byte G, byte P, byte L, byte A, string GPLAOthers,
            List<PatientComplaint> lstPatientComplaint,
            List<PatientComplaintAttribute> lstPatientComplaintAttribute,
            List<SurgicalDetail> lstSurgicalDetail, long createdBy, long VisitID, long PatientID)
        {
            long returnCode = -1;


            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SaveHistoryPKG(lstPatientHisPKG, lstPatientHisPKGAttributes, lstdruglist, lstVaccHis, lstGPALDetails, G, P, L, A, GPLAOthers, lstPatientComplaint, lstPatientComplaintAttribute, lstSurgicalDetail, createdBy, VisitID, PatientID);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveHistoryPKG in Patient_BL", ex);
            }
            return returnCode;
        }




        public long GetPatientHistoryPackage(long pVisitId, out List<PatientHistoryAttribute> lstPatHisAttribute, out List<DrugDetails> lstPatientPrescription, out List<GPALDetails> lstGPALDetails, out List<ANCPatientDetails> lstANCPatientDetails, out List<PatientPastVaccinationHistory> lstPPVH, out List<PatientComplaintAttribute> lstPCA, out List<SurgicalDetail> lstSurgicalDetails)
        {
            long returnCode = -1;
            lstPatHisAttribute = new List<PatientHistoryAttribute>();
            lstPatientPrescription = new List<DrugDetails>();
            lstGPALDetails = new List<GPALDetails>();
            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstPPVH = new List<PatientPastVaccinationHistory>();
            lstPCA = new List<PatientComplaintAttribute>();
            lstSurgicalDetails = new List<SurgicalDetail>();

            try
            {
                returnCode = new Patient_DAL(globalContextDetails).GetPatientHistoryPackage(pVisitId, out lstPatHisAttribute, out lstPatientPrescription, out lstGPALDetails, out lstANCPatientDetails, out lstPPVH, out lstPCA, out lstSurgicalDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientHistoryPackage in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetLabelPrintingDetails(long pVisitId, int OrgID, out string pOrgAddress, out string pDOB,
                                       out string pURN
                                       , out string pAge, out string pSEX, out string pPhysicianName)
        {
            long returnCode = -1;
            pOrgAddress = string.Empty;
            pDOB = string.Empty;
            pURN = string.Empty;
            pAge = string.Empty;
            pSEX = string.Empty;
            pPhysicianName = string.Empty;
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).GetLabelPrintingDetails(pVisitId, OrgID, out  pOrgAddress, out pDOB, out pURN, out pAge, out pSEX, out pPhysicianName);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientHistoryPackage in Patient_BL", ex);
            }
            return returnCode;
        }

        public long SaveInvestigationInstrument(InvInstrumentMaster InvInsMaster, out long pInstrumentID)
        {
            long returnCode = -1;
            pInstrumentID = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SaveInvestigationInstrument(InvInsMaster, out pInstrumentID);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing SaveInvestigationInstrument in Patient_BL", excep);
            }
            return returnCode;
        }
        public long GetInvestigationInstrument(int OrgID, string instrumentName, string Status, out List<InvInstrumentMaster> lstInvInstrumentMaster)
        {
            long returnCode = -1;
            lstInvInstrumentMaster = new List<InvInstrumentMaster>();
            try
            {

                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetInvestigationInstrument(OrgID, instrumentName, Status, out lstInvInstrumentMaster);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetInvestigationInstrument in Patient_BL", e);
            }
            return returnCode;
        }
        public long UpdateInvestigationInstrument(InvInstrumentMaster objInvInstrumentMaster)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.UpdateInvestigationInstrument(objInvInstrumentMaster);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateInvestigationInstrument in Patient_BL", excep);
            }
            return returnCode;
        }
        public long SaveInvestigationKit(InvKitMaster InvKitMaster, out long pKitID)
        {
            long returnCode = -1;
            pKitID = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SaveInvestigationKit(InvKitMaster, out pKitID);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing SaveInvestigationKit in Patient_BL", excep);
            }
            return returnCode;
        }

        public long SaveInvestigationDrugBrand(InvestigationDrugBrand InvDrugBrand, out long DrugID)
        {
            long reutnCode = -1;
            DrugID = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                reutnCode = patientDAL.SaveInvestigationDrugBrand(InvDrugBrand, out DrugID);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing SaveInvestigationDrugBrand in Patient_BL", excep);
            }
            return reutnCode;
        }

        public long GetInvestigationKit(int OrgID, string kitName, string Status, out List<InvKitMaster> lstInvKitMaster)
        {
            long returnCode = -1;
            lstInvKitMaster = new List<InvKitMaster>();
            try
            {

                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetInvestigationKit(OrgID, kitName, Status, out lstInvKitMaster);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetInvestigationKit in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetInvestigationDrugBrand(int OrgID, string brandName, out List<InvestigationDrugBrand> lstInvDrugBrand)
        {
            long returnCode = -1;
            lstInvDrugBrand = new List<InvestigationDrugBrand>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetInvestigationDrugBrand(OrgID, brandName, out lstInvDrugBrand);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetInvestigationDrugBrand in Patient_BL", e);
            }
            return returnCode;
        }

        public long SearchInvestigationDrugBrand(int OrgID, string brandName, out List<InvestigationDrugBrand> lstInvDrugBrand)
        {
            long returnCode = -1;
            lstInvDrugBrand = new List<InvestigationDrugBrand>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchInvestigationDrugBrand(OrgID, brandName, out lstInvDrugBrand);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing SearchInvestigationDrugBrand in Patient_BL", e);
            }
            return returnCode;
        }

        public long UpdateInvestigationKit(InvKitMaster objKitMaster)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.UpdateInvestigationKit(objKitMaster);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateInvestigationKit in Patient_BL", excep);
            }
            return returnCode;
        }
        public long UpdateInvestigationDrugBrand(InvestigationDrugBrand invDrugBrand)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.UpdateInvestigationDrugBrand(invDrugBrand);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing UpdateInvestigationDrugBrand in Patient_BL", excep);
            }
            return returnCode;
        }
        public long SaveInvestigationMethod(InvestigationMethod InvMethod, out long pMethodID)
        {
            long returnCode = -1;
            pMethodID = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SaveInvestigationMethod(InvMethod, out pMethodID);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing SaveInvestigationMethod in Patient_BL", excep);
            }
            return returnCode;
        }
        public long GetInvestigationMethod(int OrgID, string methodName, string Status, out List<InvestigationMethod> lstInvMethod)
        {
            long returnCode = -1;
            lstInvMethod = new List<InvestigationMethod>();
            try
            {

                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetInvestigationMethod(OrgID, methodName, Status, out lstInvMethod);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetInvestigationMethod in Patient_BL", e);
            }
            return returnCode;
        }
        public long UpdateInvestigationMethod(InvestigationMethod objInvMethod)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.UpdateInvestigationMethod(objInvMethod);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateInvestigationMethod in Patient_BL", excep);
            }
            return returnCode;
        }

        public long SaveInvestigationPrinciple(InvPrincipleMaster InvPrincipleMaster, out long pPrincipleID)
        {
            long returnCode = -1;
            pPrincipleID = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SaveInvestigationPrinciple(InvPrincipleMaster, out pPrincipleID);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing SaveInvestigationPrinciple in Patient_BL", excep);
            }
            return returnCode;
        }
        public long GetInvestigationPrinciple(int OrgID, string principleName, string Status, out List<InvPrincipleMaster> lstInvPrincipleMaster)
        {
            long returnCode = -1;
            lstInvPrincipleMaster = new List<InvPrincipleMaster>();
            try
            {

                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetInvestigationPrinciple(OrgID, principleName, Status, out lstInvPrincipleMaster);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetInvestigationPrinciple in Patient_BL", e);
            }
            return returnCode;
        }
        public long UpdateInvestigationPrinciple(InvPrincipleMaster objPrincipleMaster)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.UpdateInvestigationPrinciple(objPrincipleMaster);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateInvestigationPrinciple in Patient_BL", excep);
            }
            return returnCode;
        }
        public long GetPatientRecommendationDetails(int OrgID, long PatientVisitId, long PatientID,
                        out List<PatientRecommendationDtls> lstPatientRecommendation,
                        out List<PhysicianSchedule> schedules,
                        out List<Patient> lstPatient)
        {
            long result = -1;
            schedules = new List<PhysicianSchedule>();
            lstPatient = new List<Patient>();

            lstPatientRecommendation = new List<PatientRecommendationDtls>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                result = patientDAL.GetPatientRecommendationDetails(OrgID, PatientID, PatientVisitId,
                                    out lstPatientRecommendation, out schedules, out lstPatient);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetInvestigationResultTemplate in Patient_BL", e);
            }
            return result;
        }

        public long UpdatePatientRecommendationDetails(PatientRecommendation objPatientRecommendation, DataTable dt)
        {
            long result = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                result = patientDAL.UpdatePatientRecommendationDetails(objPatientRecommendation, dt);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing UpdatePatientRecommendationDetails in Patient_BL", e);
            }
            return result;
        }

        public long UpdatePatientRecommendation(PatientRecommendation objPatientRecommendation)
        {
            long result = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                result = patientDAL.UpdatePatientRecommendation(objPatientRecommendation);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing UpdatePatientRecommendation in Patient_BL", e);
            }
            return result;
        }

        public long GetRecommendationDetails(int orgID, out List<PatientVisit> lstPatientVisit)
        {
            lstPatientVisit = new List<PatientVisit>();
            long returnCode = -1;
            long result = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetRecommendationDetails(orgID, out lstPatientVisit);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetRecommendationDetails in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetPatientRecommendationDetails(int orgID, out List<PatientVisit> lstPatientVisit)
        {
            lstPatientVisit = new List<PatientVisit>();
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                lstPatientVisit = new List<PatientVisit>();
                returnCode = patientDAL.GetPatientRecommendationDetails(orgID, out lstPatientVisit);

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPatientRecommendationDetails in Patient_BL", e);
            }
            return returnCode;
        }
        public long GetPayerType(int orgID, out List<PayerMaster> lstPayerType)
        {
            lstPayerType = new List<PayerMaster>();
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                lstPayerType = new List<PayerMaster>();
                returnCode = patientDAL.GetPayerType(orgID, out lstPayerType);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPayerType in Patient_BL", e);
            }
            return returnCode;
        }
        public long GetPCClient(int orgID, long refOrgID, int refPhyID, int payerID, long TpaOrClientID, string Type, out List<InvClientMaster> lstInvClientMaster)
        {
            lstInvClientMaster = new List<InvClientMaster>();
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                lstInvClientMaster = new List<InvClientMaster>();
                returnCode = patientDAL.GetPCClient(orgID, refOrgID, refPhyID, payerID, TpaOrClientID, Type, out lstInvClientMaster);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPCClient in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetPCPayer(int orgID, long refOrgID, int refPhyID, out List<PayerMaster> lstPayerMaster)
        {
            lstPayerMaster = new List<PayerMaster>();
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                lstPayerMaster = new List<PayerMaster>();
                returnCode = patientDAL.GetPCPayer(orgID, refOrgID, refPhyID, out lstPayerMaster);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPCPayer in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetPhysicianByType(string FilterText, int OrgID, string pType, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<Physician>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPhysicianByType(FilterText, OrgID, pType, out lstPhysician);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPhysicianByType in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetPrimaryConsultant(long pVisitID, int pType, out List<PrimaryConsultant> lstPrimaryConsultant)
        {
            long returnCode = -1;
            lstPrimaryConsultant = new List<PrimaryConsultant>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPrimaryConsultant(pVisitID, pType, out lstPrimaryConsultant);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPrimaryConsultant in Patient_BL", e);
            }
            return returnCode;
        }

        public long SaveOrderedPhysiotherapy(long visitID, int ILocationID, int OrgID, long LID, string pType, List<OrderedPhysiotherapy> lstOrderedPhysiotherapy, out int Physiocount)
        {
            long returncode = -1;
            Physiocount = 0;


            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returncode = objPatient_DAL.SaveOrderedPhysiotherapy(visitID, ILocationID, OrgID, LID, pType, lstOrderedPhysiotherapy, out Physiocount);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing SaveOrderedPhysiotherapy in Patient_BL", excep);
            }

            return returncode;
        }



        public long BindPatientRegDetail(long pPatientID, long pVisitID, string pType, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.BindPatientRegDetail(pPatientID, pVisitID, pType, out  lstPatient);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing BindPatientRegDetail in Patient_BL", e);
            }
            return returnCode;
        }


        public long BindOrderedPhysiotherapy(long pPatientID, long pVisitID, long ProcID, out List<OrderedPhysiotherapy> lstOrderedPhysiotherapy)
        {
            long returnCode = -1;
            lstOrderedPhysiotherapy = new List<OrderedPhysiotherapy>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.BindOrderedPhysiotherapy(pPatientID, pVisitID, ProcID, out lstOrderedPhysiotherapy);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing BindOrderedPhysiotherapy in Patient_BL", e);
            }
            return returnCode;
        }


        public long GetClinicalSotting(long pPatientID, long pVisitID, out List<IPTreatmentPlan> lstIPTreatmentPlan, out List<BackgroundProblem> lstBackgroundProblem)
        {
            long returnCode = -1;
            lstIPTreatmentPlan = new List<IPTreatmentPlan>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetClinicalSotting(pPatientID, pVisitID, out lstIPTreatmentPlan, out lstBackgroundProblem);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetClinicalSotting in Patient_BL", e);
            }
            return returnCode;
        }



        public long GetPatientVisitType(long pPatientID, long pVisitID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPatientVisitType(pPatientID, pVisitID, out lstPatientVisit);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing BindOrderedPhysiotherapy in Patient_BL", e);
            }
            return returnCode;
        }

        //public long GetPatientPhysioByProcID(long pProcID, long pPatientID, long pVisitID, string pType, out List<PatientPhysioDetails> lstPatientPhysioDetails)
        //{
        //    long returnCode = -1;
        //    lstPatientPhysioDetails = new List<PatientPhysioDetails>();
        //    try
        //    {

        //        Patient_DAL objPatient_DAL = new  Patient_DAL(globalContextDetails);
        //        returnCode = objPatient_DAL.GetPatientPhysioByProcID(pProcID, pPatientID, pVisitID, pType, out  lstPatientPhysioDetails);
        //    }
        //    catch (Exception e)
        //    {
        //        CLogger.LogError("Error while executing BindPatientRegDetail Patient_Bl", e);
        //    }
        //    return returnCode;
        //}


        public long SavePhysioDetails(long PatientID, long visitID, int ILocationID, int OrgID, long LID, string pType, List<PatientPhysioDetails> lstPatientPhysioDetails, PatientPhysioDetails objPPD, List<PhysioCompliant> lstPhysioCompliant, long PhysicanID)
        {
            long returncode = -1;

            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returncode = objPatient_DAL.SavePhysioDetails(PatientID, visitID, ILocationID, OrgID, LID, pType, lstPatientPhysioDetails, objPPD, lstPhysioCompliant, PhysicanID);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing SavePhysioDetails in Patient_BL", excep);
            }

            return returncode;
        }



        public long GetPatientPhysioDetail(long pPatientID, long pVisitID, string type, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPatientPhysioDetail(pPatientID, pVisitID, type, out lsPatientPhysioDetails);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPatientPhysioDetail in Patient_BL", e);
            }
            return returnCode;
        }


        public long GetPatientPhysioDetailByProcID(long PatientPhysioDtlID, out List<PatientPhysioDetails> lsPatientPhysioDetails, out List<PhysioCompliant> lstPhysioCompliant, out List<OrderedPhysiotherapy> lstOrderedPhysiotherapy)
        {
            long returnCode = -1;
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            lstPhysioCompliant = new List<PhysioCompliant>();
            lstOrderedPhysiotherapy = new List<OrderedPhysiotherapy>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPatientPhysioDetailByProcID(PatientPhysioDtlID, out lsPatientPhysioDetails, out lstPhysioCompliant, out lstOrderedPhysiotherapy);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPatientPhysioDetailByProcID in Patient_BL", e);
            }
            return returnCode;
        }

        public long UpdatePhysioDetails(long PatientID, long visitID, int ILocationID, int OrgID, long LID, string pType, List<PatientPhysioDetails> lstPatientPhysioDetails, PatientPhysioDetails objPPD, List<PhysioCompliant> lstPhysioCompliant, long PhysicanID)
        {


            long returncode = -1;

            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returncode = objPatient_DAL.UpdatePhysioDetails(PatientID, visitID, ILocationID, OrgID, LID, pType, lstPatientPhysioDetails, objPPD, lstPhysioCompliant, PhysicanID);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing SavePhysioDetails in Patient_BL", excep);
            }

            return returncode;
        }


        public long SearchPendingPhysio(int OrgID, string PatientNo, string PName, string Type, string Procedure, string EmpNo, string FromDt, string ToDt, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.SearchPendingPhysio(OrgID, PatientNo, PName, Type, Procedure, EmpNo, FromDt, ToDt, out lstPatient);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing SearchPendingPhysio in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetProcedureStatus(int OrgID, long PatientID, long ProcedureID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetProcedureStatus(OrgID, PatientID, ProcedureID, out lstPatient);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetProcedureStatus in Patient_BL", e);
            }
            return returnCode;
        }

        public long CheckVistDetails(int OrgID, long PatientId, out long VisitID)
        {
            long returncode = -1;
            VisitID = 0;
            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returncode = objPatient_DAL.CheckVistDetails(OrgID, PatientId, out VisitID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing CheckVistDetails in Patient_BL", ex);
            }
            return returncode;
        }

        public long GetPatientPhysioByProcID(long pProcID, long pPatientID, long pVisitID, string pType, out decimal Quantity, out int CurrentNoOfSitting, out int AdvisedNoOfSitting)
        {
            long returnCode = -1;
            Quantity = 0;
            CurrentNoOfSitting = 0;
            AdvisedNoOfSitting = 0;
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPatientPhysioByProcID(pProcID, pPatientID, pVisitID, pType, out Quantity, out CurrentNoOfSitting, out AdvisedNoOfSitting);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing BindPatientRegDetail in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetComplaint(string complaintName, out List<Complaint> lstComplaint)
        {
            long returnCode = -1;
            lstComplaint = new List<Complaint>();
            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetComplaint(complaintName, out lstComplaint);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetComplaint in Patient_BL", ex);
            }
            return returnCode;
        }


        public long GetPreviousPhysioVisit(long pPatientID, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPreviousPhysioVisit(pPatientID, out lsPatientPhysioDetails);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPreviousPhysioVisit in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetPreviousPhysioVisitDt(long pPatientID, string VisitDate, out List<PatientPhysioDetails> lsPatientPhysioDetails, out List<PhysioCompliant> lstPhysioCompliant)
        {
            long returnCode = -1;
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            lstPhysioCompliant = new List<PhysioCompliant>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPreviousPhysioVisitDt(pPatientID, VisitDate, out lsPatientPhysioDetails, out lstPhysioCompliant);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPatientPhysioDetail in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetPhysioName(int OrgID, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPhysioName(OrgID, out lsPatientPhysioDetails);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPhysioName in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetPhysioReport(string ProcedureName, DateTime FromDate, DateTime Todate, int OrgID, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPhysioReport(ProcedureName, FromDate, Todate, OrgID, out lsPatientPhysioDetails);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPhysioReport in Patient_BL", e);
            }
            return returnCode;
        }



        public long GetComplaintName(int OrgID, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetComplaintName(OrgID, out lsPatientPhysioDetails);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetComplaintName in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetPhysioCompliantReport(string CName, DateTime FromDate, DateTime Todate, int OrgID, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPhysioCompliantReport(CName, FromDate, Todate, OrgID, out lsPatientPhysioDetails);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPhysioCompliantReport in Patient_BL", e);
            }
            return returnCode;
        }


        public long GetPhysioCompliantPatient(int RptType, string CName, DateTime FromDate, DateTime Todate, int OrgID, out List<Patient> lsPatient)
        {
            long returnCode = -1;
            lsPatient = new List<Patient>();
            try
            {

                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPhysioCompliantPatient(RptType, CName, FromDate, Todate, OrgID, out lsPatient);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetPhysioCompliantPatient in Patient_BL", e);
            }
            return returnCode;
        }


        public long GetICDCODE(string ICDCode, out List<ICDCodes> lstICDCodes)
        {
            long returnCode = -1;
            lstICDCodes = new List<ICDCodes>();
            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetICDCODE(ICDCode, out lstICDCodes);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetICDCODE in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetICDCODEDESC(string ICDCode, out List<ICDCodes> lstICDCodes)
        {
            long returnCode = -1;
            lstICDCodes = new List<ICDCodes>();
            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetICDCODEDESC(ICDCode, out lstICDCodes);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetICDCODEDESC in Patient_BL", ex);
            }
            return returnCode;
        }

        public long UpdatePatientICDStatus(long VisitID)
        {
            long returnCode = -1;

            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.UpdatePatientICDStatus(VisitID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing UpdatePatientICDStatus in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetPendingICDCodes(long VisitID, string VisitType, string ICDStatus, out List<PatientComplaint> lstPatientComplaint, out List<PatientComplaint> lstBackgroundProblem, out List<PatientComplaint> lstPatientComplication, out List<PatientComplaint> lstOperationComplication, out  List<PatientComplaint> lstCauseOfDeath, out List<PatientComplaint> lstPhysioCompliant)
        {
            long returnCode = -1;
            lstPatientComplaint = new List<PatientComplaint>();
            lstBackgroundProblem = new List<PatientComplaint>();
            lstPatientComplication = new List<PatientComplaint>();
            lstOperationComplication = new List<PatientComplaint>();
            lstCauseOfDeath = new List<PatientComplaint>();
            lstPhysioCompliant = new List<PatientComplaint>();

            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetPendingICDCodes(VisitID, VisitType, ICDStatus, out lstPatientComplaint, out lstBackgroundProblem, out lstPatientComplication, out lstOperationComplication, out lstCauseOfDeath, out lstPhysioCompliant);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPendingICDCodes in Patient_BL", ex);
            }
            return returnCode;
        }

        public long UpdatePendingICDCodes(long VisitID, string VisitType, List<PatientComplaint> lstPatientComplaint, List<PatientComplaint> lstBackgroundProblem, List<PatientComplaint> lstPatientComplication)
        {
            long returncode = -1;

            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returncode = objPatient_DAL.UpdatePendingICDCodes(VisitID, VisitType, lstPatientComplaint, lstBackgroundProblem, lstPatientComplication);
            }
            catch (Exception excep)
            {

			CLogger.LogError("Error while executing UpdatePendingICDCodes in Patient_BL", excep);
            }

            return returncode;
        }

        public long ViewPageByICDCode(long VisitID, string VisitType, string ICDStatus, out List<PatientComplaint> lstPCT, out List<BackgroundProblem> lstBP, out  List<PatientComplication> lstPCN, out  List<OperationComplication> lstOPC, out  List<CauseOfDeath> lstCOD, out  List<PhysioCompliant> lstPHYC)
        {
            long returnCode = -1;
            lstPCT = new List<PatientComplaint>();
            lstBP = new List<BackgroundProblem>();
            lstPCN = new List<PatientComplication>();
            lstOPC = new List<OperationComplication>();
            lstCOD = new List<CauseOfDeath>();
            lstPHYC = new List<PhysioCompliant>();

            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.ViewPageByICDCode(VisitID, VisitType, ICDStatus, out lstPCT, out lstBP, out lstPCN, out lstOPC, out lstCOD, out lstPHYC);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing ViewPageByICDCode in Patient_BL", ex);
            }
            return returnCode;
        }


        public long SearchICDStatusDetails(string strStatus, string strICDFromDate, string strICDToDate, string strVisitType, string strPatientName, int OrgID, out List<PatientVisit> patientVisit)
        {
            long returnCode = -1;
            patientVisit = new List<PatientVisit>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchICDStatus(strStatus, strICDFromDate, strICDToDate, strVisitType, strPatientName, OrgID, out patientVisit);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchICDStatusDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long UpdateICDStatus(long visitID, string ICDCodeStatus)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.UpdateICDStatus(visitID, ICDCodeStatus);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateICDStatus in Patient_BL", excep);
            }
            return returnCode;
        }


        public long SaveCommunicableDiseases(int OrgId, int ILocationID, List<CommunicableDiseaseMaster> CDS, long LID)
        {
            long returnCode = -1;
            // CDS = new List<CommunicableDiseaseMaster>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);

                returnCode = patientDAL.SaveCommunicableDiseases(OrgId, ILocationID, CDS, LID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveCommunicableDiseases in Patient_BL", ex);
            }
            return returnCode;


        }

        public long GetCommunicableDiseases(int OrgId, out List<CommunicableDiseaseMaster> CDS)
        {
            long returnCode = -1;
            CDS = new List<CommunicableDiseaseMaster>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetCommunicableDiseases(OrgId, out CDS);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetCommunicableDiseases in Patient_BL", ex);
            }
            return returnCode;
        }

        public long SaveSampleRegistrationDetails(Patient patient, PatientAddress pAddress, PatientVisit labVisit, out long pVisitID, long OrgAddressID, out long pPatientID, int pAgeValue, string pAgeUnits,
            int PayerID, string PayerName, List<VisitClientMapping> lstVisitClientMapping)
        {
            long result = -1;
            pVisitID = -1;
            pPatientID = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);

                result = patientDAL.SaveSampleRegistrationDetails(patient, pAddress, labVisit, OrgAddressID, out pVisitID, out pPatientID, pAgeValue,
                    pAgeUnits, PayerID, PayerName, lstVisitClientMapping);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing SaveSampleRegistrationDetails in Patient_BL", excep);
            }
            return result;
        }
        public long SaveReferingPhysician(ReferingPhysician refPhy, out int pRefPhyID)
        {

            long result = -1;

            pRefPhyID = -1;

            try
            {

                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);

                result = patientDAL.SaveReferingPhysician(refPhy, out pRefPhyID);

            }

            catch (Exception excep)
            {

			CLogger.LogError("Error while executing SaveReferingPhysician in Patient_BL", excep);

            }

            return result;

        }
        public long GetIsCredit(int orgID, long refOrgID, int refPhyID, int clientID, out int isCredit)
        {
            isCredit = 0;
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetIsCredit(orgID, refOrgID, refPhyID, clientID, out isCredit);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetIsCredit in Patient_BL", e);
            }
            return returnCode;
        }
        public long GetMappedOrganisation(int OrgID, long PhysicianID, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long returnCode = -1;
            lstLabRefOrg = new List<LabReferenceOrg>();
            returnCode = new Patient_DAL(globalContextDetails).GetMappedOrganisation(OrgID, PhysicianID, out lstLabRefOrg);

            return returnCode;
        }
        public long GetURN(int URnTypeId, string URnNo, out List<URNTypes> lstURN)
        {
            long returnCode = -1;
            lstURN = new List<URNTypes>();
            DataSet ds = new DataSet();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetURN(URnTypeId, URnNo, out lstURN);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetURN in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetPhysicianOrgMapping(int PhysicianId, out List<PhysicianOrgMapping> lstPhysicianOrgMapping)
        {
            long returnCode = -1;
            Patient_DAL gReferingPhysician = new Patient_DAL(globalContextDetails);
            returnCode = gReferingPhysician.GetPhysicianOrgMapping(PhysicianId, out lstPhysicianOrgMapping);
            return returnCode;
        }

        public long SaveAddDiagonasis(long visitID, long pid, List<BackgroundProblem> lstBackgroundPrb, List<PatientComplaint> lstPatientComplaint, long LID)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SaveAddDiagonasis(visitID, pid, lstBackgroundPrb, lstPatientComplaint, LID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveAddDiagonasis in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientDetailsVisitID(long visitID, out List<Patient> lstPatient)
        {
            lstPatient = new List<Patient>();
            long returnCode = -1;
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).GetPatientDetailsVisitID(visitID, out lstPatient);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientDetailsPassingVisitID in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetICDCodeByComplaintID(int ComplaintID, out List<Complaint> lstComplaint)
        {
            lstComplaint = new List<Complaint>();
            long returnCode = -1;
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).GetICDCodeByComplaintID(ComplaintID, out lstComplaint);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetICDCodeByComplaintID in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientListForRegis(string pName, string pNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            Patient_DAL PatDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = PatDAL.GetPatientListForRegis(pName, pNo, pOrgID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientListForRegis in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetEMPPatientListForRegis(string pName, string pNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            Patient_DAL PatDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = PatDAL.GetEMPPatientListForRegis(pName, pNo, pOrgID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetEMPPatientListForRegis in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetRefundReceipt(int OrgID, out List<IDMaster> lstIDMaster)
        {
            long returnCode = -1;
            lstIDMaster = new List<IDMaster>();
            Patient_DAL PatDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = PatDAL.GetRefundReceipt(OrgID, out lstIDMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetRefundReceipt in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetXSLBillValue(int OrgID, int BillTypeID, out List<XslBillType> xbt)
        {
            long returnCode = -1;
            xbt = new List<XslBillType>();
            Patient_DAL pad = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = pad.GetXSLBillValue(OrgID, BillTypeID, out xbt);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetXSLBillValue in Patient_BL", ex);
            }
            return returnCode;
        }

        public long SearchPatientForRefPhysician(string iPatientNo, string strPatientName, string strDOB
                                    , string strRelation, string strLocation, string strOccupation
                                    , string strCity, string strMobile
                                    , int currOrgID, List<TrustedOrgDetails> lstTOD, int parentID
                                    , string urno, long urnTypeID, long LoginID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();

            try
            {
                Attune.Solution.DAL.Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchPatientForRefPhysician(iPatientNo, strPatientName, strDOB, strRelation, strLocation, strOccupation, strCity, strMobile, currOrgID, lstTOD, parentID, urno, urnTypeID, LoginID, out lstPatient);

                foreach (Patient patient in lstPatient)
                {
                    patient.Name = patient.TitleName + ' ' + patient.Name;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchPatientForRefPhysician in Patient_BL", ex);
            }
            return returnCode;
        }

        //code added for quick bill patient list
        public long GetPatientListForQuickBill(string pName, string pVisitType, int pOrgID, int searchType, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            Patient_DAL PatDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = PatDAL.GetPatientListForQuickBill(pName, pVisitType, pOrgID, searchType, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientListForQuickBill in Patient_BL", ex);
            }
            return returnCode;
        }

        public long UpdatePatientDetailsForIntegration(Patient patient, PatientAddress pAddress)
        {
            long returnCode = -1;
            returnCode = new Patient_DAL(globalContextDetails).UpdatePatientDetailsForIntegration(patient, pAddress);
            return returnCode;
        }


        public long GetPhysioComplaint(long PatientID, long VisitID, out List<PhysioCompliant> lstPhysioCompliant)
        {
            long returnCode = -1;
            lstPhysioCompliant = new List<PhysioCompliant>();
            Patient_DAL PatDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = PatDAL.GetPhysioComplaint(PatientID, VisitID, out lstPhysioCompliant);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPhysioComplaint in Patient_BL", ex);
            }
            return returnCode;
        }

        public long InsertSmartCardDetail(string SmartCardNo, string SmartCardIssued, string SmartCardStatus, long LID, long patientID)
        {
            long returnCode = -1;

            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatientDAL.InsertSmartCardDetail(SmartCardNo, SmartCardIssued, SmartCardStatus, LID, patientID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertSmartCardDetail in Patient_BL", ex);
            }


            return returnCode;

        }
        public long GetPatientListForQuickBillSmartCard(string pSmartCardNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            Patient_DAL PatDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = PatDAL.GetPatientListForQuickBillSmartCard(pSmartCardNo, pOrgID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientListForQuickBillSmartCard in Patient_BL", ex);
            }
            return returnCode;
        }


        public long GetInvestigationOrgChange(string ExternalVisitID, int OrgID, string FromDate, string toDate, string PatientName, string patientnumber, string pVisitNumber, out List<PatientVisit> lstpatientVisit, out List<OrderedInvestigations> lstOrderinvestication)
        {
            long returncode = -1;
            lstpatientVisit = new List<PatientVisit>();
            lstOrderinvestication = new List<OrderedInvestigations>();
            try
            {
                returncode = new Patient_DAL(globalContextDetails).GetInvestigationOrgChange(ExternalVisitID, OrgID, FromDate, toDate, PatientName, patientnumber, pVisitNumber, out lstpatientVisit, out lstOrderinvestication);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationOrgChange in Patient_BL", ex);
            }
            return returncode;
        }


        public long GETOPCreditBillReport(string TPAID, string ClientID, string FDate, string TDate, int OrgID, out List<BillSearch> lstDetails)
        {
            long returncode = -1;
            lstDetails = new List<BillSearch>();
            try
            {
                returncode = new Patient_DAL(globalContextDetails).GETOPCreditBillReport(TPAID, ClientID, FDate, TDate, OrgID, out lstDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GETOPCreditBillReport in Patient_BL", ex);
            }
            return returncode;
        }
        public long GetReportTemplateByDeptID(long patientVisitID, int OrgID, out List<InvReportMaster> lstReportMaster, out List<InvReportMaster> lstReportName, out List<InvDeptMaster> lstDpts, string deptids)
        {
            long returnCode = -1;
            lstReportMaster = new List<InvReportMaster>();
            lstReportName = new List<InvReportMaster>();
            lstDpts = new List<InvDeptMaster>();
            try
            {
                Patient_DAL objPatientBl = new Patient_DAL(globalContextDetails);
                objPatientBl.GetReportTemplateByDeptID(patientVisitID, OrgID, out lstReportMaster, out lstReportName, out lstDpts, deptids);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetReportTemplate in Patient_BL", e);
            }
            return returnCode;
        }
        public long InsertPatientEmployee(string pName, long pCreatedBy, long PatientID, long Type, List<EmployeeRegMaster> EmpDetails, string picExtension, out string EmpTypeNumber)
        {
            long returnCode = -1;
            EmpTypeNumber = string.Empty;
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatientDAL.InsertPatientEmployee(pName, pCreatedBy, PatientID, Type, EmpDetails, picExtension, out EmpTypeNumber);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertPatientEmployee in Patient_BL", ex);
            }


            return returnCode;

        }
        public long GetEmployerList(long pPatientID, string @PatientEmployerName, string @PatientEmployerNo, int OrgID, out List<EmployeeRegMaster> lstDetails)
        {
            long returncode = -1;
            lstDetails = new List<EmployeeRegMaster>();
            try
            {
                returncode = new Patient_DAL(globalContextDetails).GetEmployerList(pPatientID, @PatientEmployerName, @PatientEmployerNo, OrgID, out lstDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetEmployerList in Patient_BL", ex);
            }
            return returncode;
        }
        public long SearchCorporatePatient(string EmpNo, string EmpName, string EmpDependentNumber, string EmpDependentName, int EmployerID, int OrgID, string FromDate, string ToDate, out List<Patient> lstPatient)
        {
            long returncode = -1;
            lstPatient = new List<Patient>();
            try
            {
                returncode = new Patient_DAL(globalContextDetails).SearchCorporatePatient(EmpNo, EmpName, EmpDependentNumber, EmpDependentName, EmployerID, OrgID, FromDate, ToDate, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchCorporatePatient in Patient_BL", ex);
            }
            return returncode;
        }
        public long GetDiscountReason(int OrgID, out List<DiscountReasonMaster> lstDiscount)
        {
            long returnCode = -1;
            Patient_DAL gDiscount = new Patient_DAL(globalContextDetails);
            returnCode = gDiscount.GetDiscountReason(OrgID, out lstDiscount);
            return returnCode;
        }
        public long GetComplaintNameDESC(string ComplaintName, out List<Complaint> lstCName)
        {
            long returnCode = -1;
            lstCName = new List<Complaint>();
            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatient_DAL.GetComplaintNameDESC(ComplaintName, out lstCName);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetComplaintNameDESC in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetEmployeeDemoandAddress(long patientID, out List<Patient> patient)
        {
            long returnCode = -1;
            patient = new List<Patient>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetEmployeeDemoandAddress(patientID, out patient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetEmployeeDemoandAddress in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetMappedOrganisation(int OrgID, long PhysicianID, out List<LabReferenceOrg> lstLabRefOrg, out List<PCClientMapping> lstPCClientMapping)
        {
            long returnCode = -1;
            lstLabRefOrg = new List<LabReferenceOrg>();
            returnCode = new Patient_DAL(globalContextDetails).GetMappedOrganisation(OrgID, PhysicianID, out lstLabRefOrg, out lstPCClientMapping);

            return returnCode;
        }
        public long ServiceSearchDetails(string strBillNo, string strBillFromDate, string strBillToDate, string strPatientName, int OrgID, string PatientNumber, out List<EmployeeSearch> billSearch, int pageSize, int StartRowIndex, out int totalRows)
        {
            long returnCode = -1;
            totalRows = 0;
            billSearch = new List<EmployeeSearch>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.ServiceSearchDetails(strBillNo, strBillFromDate, strBillToDate, strPatientName, OrgID, PatientNumber, out billSearch, pageSize, StartRowIndex, out totalRows);
                foreach (EmployeeSearch bill in billSearch)
                {
                    bill.Name = bill.TitleName + ' ' + bill.Name;
                }
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchBillOptionDetails in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetRelationship(out List<RelationshipMaster> lstrelation)
        {
            long returncode = -1;

            lstrelation = new List<RelationshipMaster>();
            try
            {
                returncode = new Patient_DAL(globalContextDetails).GetRelationshipList(out lstrelation);

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing GetRelationship in Patient_BL", ex);
            }


            return returncode;

        }
        public long GetLabAllRefOrg(string prefixText, int OrgID, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long returnCode = -1;
            Patient_DAL gLabRefOrg = new Patient_DAL(globalContextDetails);
            returnCode = gLabRefOrg.GetLabAllRefOrg(prefixText, OrgID, out lstLabRefOrg);
            return returnCode;
        }

        public long GetTRFimageDetails(int patientid, int visitid, int OrgID, string Type, out List<TRFfilemanager> TRFdetails)
        {
            long returncode = -1;

            TRFdetails = new List<TRFfilemanager>();
            try
            {
                returncode = new Patient_DAL(globalContextDetails).GetTRFDetails(patientid, visitid, OrgID, Type, out TRFdetails);

            }
            catch (Exception ex)
            {

			CLogger.LogError("Error while executing GetTRFimageDetails in ClinicalTrail_BL", ex);
            }
            return returncode;

        }
        public long SaveTRFDetails(String FileName, int PatientID, int VisitID, int OrgID, long IdentifyingID, String IdentifyingType, String FilePath, long Createdby, DateTime Createdat, string Isactive,long accessionno)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatientDAL.SaveTRFDetails(FileName, PatientID, VisitID, OrgID, IdentifyingID, IdentifyingType, FilePath, Createdby, Createdat, Isactive,accessionno);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveEpisodeTRFDetails in ClinicalTrail_BL", ex);
            }
            return returnCode;
        }

        public long GetTrustedOrgInvClientMaster(int OrgID, string Status, out List<InvClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            lstInvClientMaster = new List<InvClientMaster>();
            try
            {
                Patient_DAL gInvClientMaster = new Patient_DAL(globalContextDetails);
                returnCode = gInvClientMaster.GetTrustedOrgInvClientMaster(OrgID, out lstInvClientMaster);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetTrustedOrgInvClientMaster in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetTrustedOrgReferingPhysician(string DrName, int OrgID, out List<ReferingPhysician> lstReferingPhysician)
        {
            long returnCode = -1;
            lstReferingPhysician = new List<ReferingPhysician>();
            try
            {

                Patient_DAL gReferingPhysician = new Patient_DAL(globalContextDetails);
                returnCode = gReferingPhysician.GetTrustedOrgReferingPhysician(DrName, OrgID, out lstReferingPhysician);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetTrustedOrgReferingPhysician in Patient_BL", e);
            }
            return returnCode;
        }
        public long GetQuickInternalExternalPhysician(string prefixText, int OrgID, out List<Physician> lstLabPhy)
        {
            long returnCode = -1;
            Patient_DAL gLabRefOrg = new Patient_DAL(globalContextDetails);
            returnCode = gLabRefOrg.GetQuickInternalExternalPhysician(prefixText, OrgID, out lstLabPhy);
            return returnCode;
        }
        public long Viewpatientphoto(int patientid, out List<Patient> lstpat)
        {
            long returnCode = -1;
            lstpat = new List<Patient>();
            try
            {

                Patient_DAL DAL = new Patient_DAL(globalContextDetails);
                returnCode = DAL.Getpatientphoto(patientid, out lstpat);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing Viewpatientphoto in Patient_BL", e);
            }
            return returnCode;
        }
        public long GetEmployeeNumber(int OrgID, string EmployeeNo, int EmployerID, out List<EmployeeRegMaster> lstpat)
        {
            long returnCode = -1;
            lstpat = new List<EmployeeRegMaster>();
            try
            {

                Patient_DAL DAL = new Patient_DAL(globalContextDetails);
                returnCode = DAL.GetEmployeeNumber(OrgID, EmployeeNo, EmployerID, out lstpat);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetEmployeeNumber in Patient_BL", e);
            }
            return returnCode;
        }
        public long MakeVisitToPhysio(long PatientID, long SVisitID, int OrgID, long ProcedureID)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatientDAL.MakeVisitToPhysio(PatientID, SVisitID, OrgID, ProcedureID);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing MakeVisitToPhysio in Patient_BL", e);
            }
            return returnCode;
        }

        public long LoadSearchTypeMetaData(out List<CustomPeriodRange> lstCustomPeriod, out List<PatientSearchType> lstPatientType, out List<OtherSearchCriteria> lstsearchCreteria)
        {
            long returnCode = -1;
            lstCustomPeriod = new List<CustomPeriodRange>();
            lstPatientType = new List<PatientSearchType>();
            lstsearchCreteria = new List<OtherSearchCriteria>();


            try
            {

                Patient_DAL DAL = new Patient_DAL(globalContextDetails);
                returnCode = DAL.LoadSearchTypeMetaData(out lstCustomPeriod, out lstPatientType, out lstsearchCreteria);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetEmployeeNumber in Patient_BL", e);
            }
            return returnCode;
        }
        public long GetExternalDetails(string pName, string pNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatientDAL.GetExternalDetails(pName, pNo, pOrgID, out lstPatientDetails);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetExternalDetails in Patient_BL", e);
            }
            return returnCode;
        }
        public long InsertFamilytree(int pOrgID, List<Familytree> lstFamilytree)
        {
            long returnCode = -1;
            Patient_DAL PatDAL = new Patient_DAL(globalContextDetails);

            try
            {
                returnCode = PatDAL.InsertFamilytree(pOrgID, lstFamilytree);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertFamilytree in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetOrderedPhysio(long patientID, long visitID, long createdBy, out List<OrderedPhysiotherapy> lstOrderedPhysiotherapy, out long proTaskStatus)
        {
            long returnCode = -1;
            proTaskStatus = -1;
            Patient_DAL PatDAL = new Patient_DAL(globalContextDetails);
            lstOrderedPhysiotherapy = new List<OrderedPhysiotherapy>();
            try
            {
                returnCode = PatDAL.GetOrderedPhysio(patientID, visitID, createdBy, out lstOrderedPhysiotherapy, out proTaskStatus);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetOrderedPhysio in Patient_BL", ex);
            }
            return returnCode;
        }


        public long GetClientRateMappingDetail(int OrgID, int ClientTypeID, out List<InvClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            lstInvClientMaster = new List<InvClientMaster>();
            try
            {
                Patient_DAL Patient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = Patient_DAL.GetClientRateMappingDetail(OrgID, ClientTypeID, out lstInvClientMaster);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetClientRateMappingDetail in Patient_BL", e);
            }
            return returnCode;
        }
        public long SaveClientRateMappingDetail(int OrgID, int ClientTypeID, int ClientID, int RateID, List<InvClientMaster> lstInvClientMaster, long CreatedBy,string Reason)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL Patient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = Patient_DAL.SaveClientRateMappingDetail(OrgID, ClientTypeID, ClientID, RateID, lstInvClientMaster, CreatedBy, Reason);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing SaveClientRateMappingDetail in Patient_BL", e);
            }
            return returnCode;
        }
        public long GetClientRateMappingItems(int OrgID, int ClientID, int RateID, int ClientTypeID, DateTime FromDate, DateTime ToDate, out List<InvClientMaster> lstInvClientRate, out List<InvClientMaster> lstCMaster)
        {
            long returnCode = -1;
            lstInvClientRate = new List<InvClientMaster>();
            lstCMaster = new List<InvClientMaster>();
            try
            {
                Patient_DAL Patient_DAL = new Patient_DAL(globalContextDetails);
                returnCode = Patient_DAL.GetClientRateMappingItems(OrgID, ClientID, RateID, ClientTypeID, FromDate, ToDate, out lstInvClientRate, out lstCMaster);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetClientRateMappingItems in Patient_BL", e);
            }
            return returnCode;
        }
        public long GetQuickBillRefOrg(string prefixText, int OrgID, int pClientTypeID, string pStatus, string contexttext, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long returnCode = -1;
            Patient_DAL gLabRefOrg = new Patient_DAL(globalContextDetails);
            returnCode = gLabRefOrg.GetQuickBillRefOrg(prefixText, OrgID, pClientTypeID, pStatus, contexttext, out lstLabRefOrg);
            return returnCode;
        }

        public long DeletePendingProcedure(long PatientID, long VisitID, long ProcedureID, int OrgID)
        {
            long returncode = -1;
            try
            {
                Patient_DAL objPatient_DAL = new Patient_DAL(globalContextDetails);
                returncode = objPatient_DAL.DeletePendingProcedure(PatientID, VisitID, ProcedureID, OrgID);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing DeletePendingProcedure in Patient_BL", excep);
            }
            return returncode;
        }
        public long SavePatientphoto(string PictureName, int OrgID, long PatientID)
        {
            long returnCode = -1;

            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatientDAL.UpdatepatientPhoto(PictureName, OrgID, PatientID);

            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing SavePatient in Patient_BL", ex);

            }

            return returnCode;

        }


        public long SavePatientOPBilling(int OrgID, int ILocationID, long LID, Patient objPatient, List<PatientDueChart> lstPatientDueChart,
          List<SaveBillingDetails> lstBillingDetails, FinalBill finalBill, AmountReceivedDetails amtRD,
          DataTable dtAmountReceived, DataTable dtAmountReceived_10, List<TaxBillDetails> lstTaxDetails, Patient pdetails,
       List<PatientReferringDetails> lstPatientRefDetails, List<OrderedInvestigations> lstOrderedInvestigations, List<PatientDepositUsage> lstUsage, long refPhyID,
       int refSpecialityID, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
       out long FinalBillID, ref long patientID, ref long patientVisitID, string gUID, int RoleID,
      out int cnt, List<VisitClientMapping> lstVisitClientMapping)
        {

            FinalBillID = 0;

            int returnStatus = -1, needTaskDisplay = -1;
            long returnCode = -1;
            cnt = 0;
            string pPatientNo = string.Empty;
            string pBillNumber = string.Empty;
            string pLabNO = string.Empty;
            long taskID = -1;
            string feeType = String.Empty;
            BillingEngine objBillingEngine = new BillingEngine(globalContextDetails);
            List<Patient> lstPatient = new List<Patient>();
            Tasks task = new Tasks();
            Tasks_BL taskBL = new Tasks_BL(globalContextDetails);
            Hashtable dText = new Hashtable();
            Hashtable urlVal = new Hashtable();
            int specialityID = -1;
            int otherID = -1;
            List<TaskActions> lstTaskAction = new List<TaskActions>();
            try
            {
                if (objPatient.VisitType != "1" && objPatient.PatientID <= 0)
                {
                    returnCode = new Patient_BL(globalContextDetails).CheckPatientforDuplicate(objPatient.Name, objPatient.PatientAddress[0].MobileNumber.Trim(), objPatient.PatientAddress[0].LandLineNumber.Trim(), OrgID, "", out cnt);
                }

                if (cnt <= 0)
                {

                    returnCode = objBillingEngine.InsertPatientAndVisit(ref patientID, ref patientVisitID, ref pPatientNo, LID, lstPatientDueChart, objPatient,
                                         refPhyID, refSpecialityID, OrgID, ILocationID, AgeValue, AgeUnit, pSpecialityID, ReferralType, "", lstVisitClientMapping);

                    finalBill.VisitID = patientVisitID;
                    finalBill.PatientID = patientID;

                    if (returnCode >= 0)
                    {
                        returnCode = objBillingEngine.InsertQuickBill(finalBill, amtRD, dtAmountReceived,
                              lstPatientDueChart, lstTaxDetails, pdetails, finalBill.ServiceCharge, out returnStatus,
                              lstPatientRefDetails, lstUsage, out FinalBillID, out pLabNO);


                    }
                    if (returnCode >= 0)
                    {
                        returnCode = new Patient_BL(globalContextDetails).GetPatientDemoandAddress(patientID, out lstPatient);
                        Patient patient;

                        patient = lstPatient.Count > 0 ? lstPatient[0] : new Patient();
                        if (lstOrderedInvestigations != null)
                        {
                            if (lstOrderedInvestigations.Count > 0)
                            {
                                foreach (OrderedInvestigations InvestList in lstOrderedInvestigations)
                                {
                                    InvestList.Status = "Ordered";
                                    InvestList.VisitID = patientVisitID;
                                }
                                int pOrderedInvCnt = 0;
                                string paymentstatus = "Paid";
                                returnCode = new Investigation_BL(globalContextDetails).SaveOrderedInvestigationHOS(lstOrderedInvestigations, OrgID, out pOrderedInvCnt,
                                            paymentstatus, gUID, pLabNO);
                                returnCode = CollectSampleTaskCreator(OrgID, LID, lstOrderedInvestigations, pLabNO, pBillNumber, patientID, patientVisitID, gUID, RoleID, "N", out needTaskDisplay, "", "", out taskID);
                            }
                        }


                        #region Physiotheraphy

                        List<PatientDueChart> lstTempPhysiotherapy = (from lstduetemp in lstPatientDueChart
                                                                      where lstduetemp.FeeType == "PRO" && lstduetemp.Description != "Dialysis" && lstduetemp.Description != "Others"
                                                                      select lstduetemp).ToList();


                        List<OrderedPhysiotherapy> lstOrderedPhysiotherapy = new List<OrderedPhysiotherapy>();


                        if (lstTempPhysiotherapy.Count > 0)
                        {


                            foreach (PatientDueChart dueitem in lstTempPhysiotherapy)
                            {
                                OrderedPhysiotherapy ptt = new OrderedPhysiotherapy();
                                ptt.ProcedureID = dueitem.FeeID;
                                ptt.ProcedureName = dueitem.Description;
                                ptt.OdreredQty = dueitem.Unit;
                                ptt.Status = "Ordered";
                                ptt.PaymentStatus = "";
                                lstOrderedPhysiotherapy.Add(ptt);
                            }
                        }


                        if (lstOrderedPhysiotherapy.Count > 0)
                        {
                            string Type = "Ordered";
                            int Physiocount = 0;
                            returnCode = new Patient_BL(globalContextDetails).SaveOrderedPhysiotherapy(patientVisitID, ILocationID, OrgID, LID, Type, lstOrderedPhysiotherapy, out Physiocount);
                            if (Physiocount > 0)
                            {
                                Patient_BL patientBL = new Patient_BL(globalContextDetails);
                                returnCode = patientBL.GetPatientDemoandAddress(patientID, out lstPatient);
                                patient = lstPatient[0];
                                returnCode = Utilities.GetHashTable((long)TaskHelper.TaskAction.PerformPhysiotherapy, patientVisitID, 0,
                                       patientID, patient.TitleName + " " + patient.Name, "", 0, "", 0, "", 0, feeType, out dText,
                                       out urlVal, 0, patient.PatientNumber, patient.TokenNumber, "");
                                task.TaskActionID = (int)TaskHelper.TaskAction.PerformPhysiotherapy;
                                task.DispTextFiller = dText;
                                task.URLFiller = urlVal;
                                task.PatientID = patientID;
                                task.OrgID = OrgID;
                                task.PatientVisitID = patientVisitID;
                                task.TaskStatusID = (int)TaskHelper.TaskStatus.Pending;
                                task.CreatedBy = LID;
                                returnCode = taskBL.CreateTask(task, out taskID);
                            }


                        }


                        #endregion

                        #region Dialysis

                        List<PatientDueChart> lsdia = (from lstdia in lstPatientDueChart
                                                       where lstdia.FeeType == "PRO" && lstdia.Description == "Dialysis"
                                                       select lstdia).ToList();


                        if (lsdia.Count > 0)
                        {
                            returnCode = Utilities.GetHashTable((long)TaskHelper.TaskAction.PreDialysis, patientVisitID, 0,
                                patientID, patient.TitleName + " " + patient.Name, "", lsdia[0].FeeID, "", 0, "", 0,
                                feeType, out dText, out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID

                            task.TaskActionID = (int)TaskHelper.TaskAction.PreDialysis;
                            task.DispTextFiller = dText;
                            task.URLFiller = urlVal;
                            task.PatientID = patientID;
                            task.OrgID = OrgID;
                            task.PatientVisitID = patientVisitID;
                            task.TaskStatusID = (int)TaskHelper.TaskStatus.Pending;
                            task.CreatedBy = LID;
                            returnCode = taskBL.CreateTask(task, out taskID);

                        }

                        #endregion

                        #region Consultation

                        List<PatientDueChart> lsCon = (from lstCon in lstPatientDueChart
                                                       where lstCon.FeeType == "CON"
                                                       select lstCon).ToList();


                        if (lsCon.Count > 0)
                        {

                            foreach (PatientDueChart pdc in lsCon)
                            {
                                otherID = pdc.SpecialityID;
                                specialityID = pdc.SpecialityID;
                                returnCode = new PatientVisit_BL(globalContextDetails).GetTaskActionID(OrgID, 1, otherID, out lstTaskAction);
                                TaskActions taskAction = new TaskActions();
                                taskAction = lstTaskAction.Count > 0 ? lstTaskAction[0] : new TaskActions();
                                if (returnCode == 0)
                                {

                                    //*******for Task*******************
                                    //Created by ashok to add multiple tasks

                                    if ((specialityID == Convert.ToInt32(TaskHelper.speciality.Diabetology)) || (specialityID == Convert.ToInt32(TaskHelper.speciality.Endocrinology)) || (specialityID == Convert.ToInt32(TaskHelper.speciality.ANC)))
                                    {
                                        for (int i = 1; i < lstTaskAction.Count; i++)
                                        {
                                            taskAction = lstTaskAction[i];

                                            returnCode = Utilities.GetHashTable(taskAction.TaskActionID, patientVisitID, pdc.UserID,
                                                                      patientID, patient.TitleName + " " + patient.Name,
                                                                      pdc.Description, otherID, "", 0, "", 0, "", out dText,
                                                                      out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID
                                            task.TaskActionID = taskAction.TaskActionID;

                                            task.DispTextFiller = dText;
                                            task.URLFiller = urlVal;
                                            task.PatientID = patientID;

                                            task.AssignedTo = 0;
                                            task.OrgID = OrgID;
                                            task.PatientVisitID = patientVisitID;
                                            task.SpecialityID = specialityID;
                                            task.CreatedBy = LID;
                                            returnCode = taskBL.CreateTask(task, out taskID);
                                        }
                                        taskAction = lstTaskAction[0];
                                        returnCode = Utilities.GetHashTable(taskAction.TaskActionID, patientVisitID, pdc.UserID,
                                                                  patientID, patient.TitleName + " " + patient.Name,
                                                                  pdc.Description, otherID, "", 0, "", 0, "", out dText,
                                                                  out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID
                                        task.TaskActionID = taskAction.TaskActionID;

                                        task.DispTextFiller = dText;
                                        task.URLFiller = urlVal;
                                        task.PatientID = patientID;
                                        task.AssignedTo = pdc.UserID;
                                        task.OrgID = OrgID;
                                        task.PatientVisitID = patientVisitID;
                                        task.SpecialityID = specialityID;
                                        task.CreatedBy = LID;
                                        returnCode = taskBL.CreateTask(task, out taskID);
                                    }
                                    else
                                    {
                                        for (int i = 0; i < lstTaskAction.Count; i++)
                                        {
                                            taskAction = lstTaskAction[i];

                                            returnCode = Utilities.GetHashTable(taskAction.TaskActionID, patientVisitID, pdc.UserID,
                                                                      patientID, patient.TitleName + " " + patient.Name,
                                                                      pdc.Description, otherID, "", 0, "", 0, "", out dText,
                                                                      out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID
                                            task.TaskActionID = taskAction.TaskActionID;
                                            task.DispTextFiller = dText;
                                            task.URLFiller = urlVal;
                                            task.PatientID = patientID;
                                            task.AssignedTo = pdc.UserID;
                                            task.OrgID = OrgID;
                                            task.PatientVisitID = patientVisitID;
                                            task.SpecialityID = specialityID;
                                            task.CreatedBy = LID;
                                            returnCode = taskBL.CreateTask(task, out taskID);
                                        }
                                    }

                                }
                            }
                        }
                        #endregion


                        #region Ambulance

                        //if (!string.IsNullOrEmpty(lstAmbDetails))
                        //{
                        //    string lsValue = Convert.ToString(lstAmbDetails);
                        //    char[] lcsplitFirst = { '^' };
                        //    string[] lsAMBIN = lsValue.Split(lcsplitFirst);

                        //    char[] splitOn = { '$' };
                        //    string[] lsHiddenValue = lsAMBIN[0].Split(splitOn);
                        //    PatientAmbulancedetails lobjAMBFieldValue;
                        //    List<PatientAmbulancedetails> lstPatientAmbDetails = new List<PatientAmbulancedetails>();

                        //    lobjAMBFieldValue = new PatientAmbulancedetails();
                        //    lobjAMBFieldValue.AmbulanceID = Convert.ToInt64(lsHiddenValue[0]);
                        //    lobjAMBFieldValue.DriverID = Convert.ToInt64(lsHiddenValue[1]);
                        //    lobjAMBFieldValue.LocationID = Convert.ToInt64(lsHiddenValue[2]);
                        //    lobjAMBFieldValue.Distancekgm = Convert.ToInt64(lsHiddenValue[3]);
                        //    lobjAMBFieldValue.AmbulancearrivalFromdate = Convert.ToDateTime(lsHiddenValue[4]);
                        //    lobjAMBFieldValue.AmbulancearrivalTodate = Convert.ToDateTime(lsHiddenValue[5]);
                        //    lobjAMBFieldValue.Duration = Convert.ToInt64(lsHiddenValue[6]);

                        //    lobjAMBFieldValue.FinalBillID = FinalBillID;
                        //    lobjAMBFieldValue.PatientVisitID = patientVisitID;
                        //    lobjAMBFieldValue.Createdby = LID;
                        //    lobjAMBFieldValue.Modifiedby = LID;
                        //    lobjAMBFieldValue.Createdat = DateTime.Now;
                        //    lobjAMBFieldValue.Modifiedat = DateTime.Now;

                        //    lstPatientAmbDetails.Add(lobjAMBFieldValue);

                        //    if (!string.IsNullOrEmpty(lsAMBIN[1]))
                        //    {
                        //        string[] lsHiddenSecondValue = lsAMBIN[1].Split(splitOn);
                        //        lobjAMBFieldValue = new PatientAmbulancedetails();
                        //        lobjAMBFieldValue.AmbulanceID = Convert.ToInt64(lsHiddenSecondValue[0]);
                        //        lobjAMBFieldValue.DriverID = Convert.ToInt64(lsHiddenSecondValue[1]);
                        //        lobjAMBFieldValue.LocationID = Convert.ToInt64(lsHiddenSecondValue[2]);
                        //        lobjAMBFieldValue.Distancekgm = Convert.ToInt64(lsHiddenSecondValue[3]);
                        //        lobjAMBFieldValue.AmbulancearrivalFromdate = Convert.ToDateTime(lsHiddenSecondValue[4]);
                        //        lobjAMBFieldValue.AmbulancearrivalTodate = Convert.ToDateTime(lsHiddenSecondValue[5]);
                        //        lobjAMBFieldValue.Duration = Convert.ToInt64(lsHiddenSecondValue[6]);
                        //        lobjAMBFieldValue.FinalBillID = FinalBillID;
                        //        lobjAMBFieldValue.PatientVisitID = patientVisitID;
                        //        lobjAMBFieldValue.Createdby = LID;
                        //        lobjAMBFieldValue.Modifiedby = LID;
                        //        lobjAMBFieldValue.Createdat = DateTime.Now;
                        //        lobjAMBFieldValue.Modifiedat = DateTime.Now;
                        //        lstPatientAmbDetails.Add(lobjAMBFieldValue);
                        //    }

                        //   returnCode = new Patient_BL().InsertAmbulanceDetails(lstPatientAmbDetails);  


                        // }
                        #endregion

                    }
                }
            }
            catch (Exception ex)
            {

			CLogger.LogError("Error while executing SavePatientOPBilling in Patient_BL", ex);
            }

            return returnCode;
        }





        public string GetConfigValue(string configKey, int orgID)
        {
            string configValue = string.Empty;
            long returncode = -1;
            GateWay objGateway = new GateWay(globalContextDetails);
            List<Config> lstConfig = new List<Config>();

            returncode = objGateway.GetConfigDetails(configKey, orgID, out lstConfig);
            if (lstConfig.Count > 0)
                configValue = lstConfig[0].ConfigValue;

            return configValue;
        }

        private long CollectSampleTaskCreator(int OrgID, long LID, List<OrderedInvestigations> lstOrderedInvestigations, string labno,
             string BillNumber, long patientID, long patientVisitID, string gUID, int RoleID, string IsReceptionPhlebotomist,
             out int needTaskDisplay, string IsSamplePickUP, string IsSTAT, out long taskID)
        {
            taskID = -1;
            long returnCode = -1;
            needTaskDisplay = -1;

            Tasks task = new Tasks();
            Tasks_BL taskBL = new Tasks_BL(globalContextDetails);
            Hashtable dText = new Hashtable();
            Hashtable urlVal = new Hashtable();
            List<TaskActions> lstTaskAction = new List<TaskActions>();
            List<Patient> lstPatient = new List<Patient>();
            List<PatientInvestigation> lstSampleDept1 = new List<PatientInvestigation>();
            List<PatientInvSample> lstSampleDept2 = new List<PatientInvSample>();
            List<InvestigationValues> lstInvResult = new List<InvestigationValues>();
            int specialityID = -1;
            new Investigation_BL(globalContextDetails).GetDeptToTrackSamplesForQucikBill(patientVisitID, OrgID, RoleID, gUID, out lstSampleDept1);

            foreach (var item in lstSampleDept1)
            {
                if (item.Display == "N")
                {
                    InvestigationValues inValues = new InvestigationValues();
                    inValues.InvestigationID = item.InvestigationID;
                    inValues.PerformingPhysicainName = item.PerformingPhysicainName;
                    inValues.PackageID = item.PackageID;
                    inValues.PackageName = item.PackageName;

                    lstInvResult.Add(inValues);
                }
                else
                {
                    needTaskDisplay = 1;
                }
            }
            if (lstInvResult.Count > 0)
            {
                returnCode = new Investigation_BL(globalContextDetails).UpdateInvestigationStatus(patientVisitID, "SampleReceived", OrgID, lstInvResult);
            }
            if ((IsReceptionPhlebotomist != "Y")||(IsReceptionPhlebotomist == "Y"))
            {
                #region INV
                string sVal = GetConfigValue("SampleCollect", OrgID);
                if (sVal.Trim() != "N")
                {
                    List<PatientVisitDetails> lstPatientVisitDetails = new List<PatientVisitDetails>();
                    returnCode = new PatientVisit_BL(globalContextDetails).GetVisitDetails(patientVisitID, out lstPatientVisitDetails);

                    if (lstPatientVisitDetails.Count > 0)
                    {
                        foreach (var item in lstSampleDept1)
                        {
                            if (item.Display == "Y")
                            {
                                //long createTaskID = -1;
                                Int32 TaskActionID = -1;
                                if (IsSamplePickUP == "Y")
                                {
                                    TaskActionID = Convert.ToInt32(TaskHelper.TaskAction.GenerateBarCode);
                                }
                                else
                                {
                                    TaskActionID = Convert.ToInt32(TaskHelper.TaskAction.CollectSample);

                                }
                                string patientName = lstPatientVisitDetails[0].PatientName + "-" + lstPatientVisitDetails[0].Age;
                                returnCode = Utilities.GetHashTable(Convert.ToInt64(TaskActionID),
                                             patientVisitID, 0, patientID, lstPatientVisitDetails[0].TitleName + " " +
                                             patientName, "", 0, "", 0, "", 0, "INV"
                                             , out dText, out urlVal, "0", lstPatientVisitDetails[0].PatientNumber, 0, gUID, lstPatientVisitDetails[0].ExternalVisitID, lstPatientVisitDetails[0].VisitNumber,"");
                                task.TaskActionID = TaskActionID;// Convert.ToInt32(TaskHelper.TaskAction.CollectSample);
                                task.DispTextFiller = dText;
                                task.URLFiller = urlVal;
                                task.RoleID = RoleID;
                                task.OrgID = OrgID;
                                task.PatientVisitID = patientVisitID;
                                task.PatientID = patientID;
                                task.TaskStatusID = (int)TaskHelper.TaskStatus.Pending;
                                task.CreatedBy = LID;
                                task.RefernceID = labno.ToString();
                                //Create task               
                                task.IsStat = IsSTAT;
                                returnCode = new Tasks_BL(globalContextDetails).CreateTaskAllowDuplicate(task, out taskID);
                                break;

                            }
                        }
                    }

                    if (taskID > 0)
                    {
                        returnCode = new Investigation_BL(globalContextDetails).UpdateOrderedInvestigation(patientVisitID, labno, OrgID, BillNumber, taskID);
                    }
                }
                else
                {
                    returnCode = 0;
                }

                #endregion
                #region Helath Package
                //Add By Syed
                Investigation_BL investigationBL = new Investigation_BL(globalContextDetails);
                List<InvGroupMaster> lstPackages = new List<InvGroupMaster>();
                List<PatientInvestigation> lstPackageContents = new List<PatientInvestigation>();
                List<InvPackageMapping> lstPackageMapping = new List<InvPackageMapping>();
                List<Speciality> lstSpeciality = new List<Speciality>();
                List<Speciality> lstCollectedSpeciality = new List<Speciality>();
                List<GeneralHealthCheckUpMaster> lstGeneralHealthCheckUpMaster = new List<GeneralHealthCheckUpMaster>();
                List<GeneralHealthCheckUpMaster> lstCollectedHealthCheckUpMaster = new List<GeneralHealthCheckUpMaster>();
                int PkgID = -1;
                investigationBL.GetHealthPackageData(OrgID, PkgID, out lstPackages, out lstPackageMapping, out lstPackageContents, out lstGeneralHealthCheckUpMaster);
                int purpID = 4;
                //  purpID =Convert.ToInt32(QPR.GetVisitPurposeID());

                foreach (OrderedInvestigations objItems in lstOrderedInvestigations)
                {
                    if (objItems.Type == "PKG")
                    {
                        //Get Speciality

                        foreach (InvGroupMaster PkgMaster in lstPackages)
                        {
                            if (objItems.ID == PkgMaster.AttGroupID)
                            {
                                PkgID = PkgMaster.GroupID;
                            }

                        }

                        var invPMList = from invPM in lstPackageMapping
                                        where invPM.PackageID == Convert.ToInt32(PkgID) && invPM.Type == "CON"
                                        select invPM;
                        List<InvPackageMapping> lstPI1 = invPMList.ToList<InvPackageMapping>();
                        foreach (InvPackageMapping objPMTTT in lstPI1)
                        {
                            Speciality objCollectedSpeciality = new Speciality();
                            objCollectedSpeciality.SpecialityID = Convert.ToInt32(objPMTTT.ID);
                            objCollectedSpeciality.SpecialityName = "";
                            lstCollectedSpeciality.Add(objCollectedSpeciality);
                        }
                        //Get HealthCheckUpMaster
                        var invGHList = from invPM in lstPackageMapping
                                        where invPM.PackageID == Convert.ToInt32(PkgID) && invPM.Type == "GHC"
                                        select invPM;
                        List<InvPackageMapping> lstPI2 = invGHList.ToList<InvPackageMapping>();

                        foreach (InvPackageMapping objGHTTT in lstPI2)
                        {
                            GeneralHealthCheckUpMaster objGeneralHealthCheckUpMaster = new GeneralHealthCheckUpMaster();
                            objGeneralHealthCheckUpMaster.GeneralHealthCheckUpID = Convert.ToInt32(objGHTTT.ID);
                            objGeneralHealthCheckUpMaster.GeneralHealthCheckUpName = "";
                            lstCollectedHealthCheckUpMaster.Add(objGeneralHealthCheckUpMaster);
                        }

                        PatientVisit_BL pvisitBL = new PatientVisit_BL(globalContextDetails);
                        Patient_BL patientBL = new Patient_BL(globalContextDetails);
                        PatientVisit pVisit = new PatientVisit();
                        // int purpID = 1;
                        long phyID = -1;
                        int otherID = -1;
                        returnCode = new Patient_BL(globalContextDetails).GetPatientDemoandAddress(patientID, out lstPatient);
                        Patient patient;
                        patient = lstPatient.Count > 0 ? lstPatient[0] : new Patient();

                        string feeType = String.Empty;
                        string otherName = String.Empty;
                        string physicianName = String.Empty;
                        string referrerName = string.Empty;
                        long ptaskID = -1;
                        //  string gUID = string.Empty;
                        string PaymentLogic = string.Empty;
                        long visitID = patientVisitID;

                        #region for HealthScreen Task
                        if (lstCollectedHealthCheckUpMaster.Count > 0)
                        {
                            long ptaskIDHC = -1;
                            feeType = "HEALTHPKG";
                            otherID = 0;
                            int visitPurposeID = 4;
                            phyID = 0;
                            if (PaymentLogic == string.Empty)
                            {
                                List<Config> lstConfig = new List<Config>();
                                new GateWay(globalContextDetails).GetConfigDetails(feeType, OrgID, out lstConfig);
                                if (lstConfig.Count > 0)
                                    PaymentLogic = lstConfig[0].ConfigValue.Trim();
                            }
                            pVisit.PhysicianName = "";
                            TaskActions taskActionHC = new TaskActions();

                            returnCode = pvisitBL.GetTaskActionID(OrgID, visitPurposeID, otherID, out lstTaskAction);
                            //Perform
                            taskActionHC = lstTaskAction[0];
                            returnCode = Utilities.GetHashTable(taskActionHC.TaskActionID, visitID, phyID,
                                                          patientID, patient.TitleName + " " + patient.Name,
                                                          physicianName, otherID, "", 0, "", 0, "", out dText, out urlVal, 0,
                                                          patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID

                            task.TaskActionID = taskActionHC.TaskActionID;
                            task.DispTextFiller = dText;
                            task.URLFiller = urlVal;
                            task.PatientID = patientID;
                            task.AssignedTo = phyID;
                            task.OrgID = OrgID;
                            task.PatientVisitID = visitID;
                            task.SpecialityID = specialityID;
                            task.CreatedBy = LID;
                            returnCode = taskBL.CreateTask(task, out ptaskIDHC);
                        }
                        #endregion
                        foreach (Speciality objSpeciality in lstCollectedSpeciality)
                        {
                            purpID = 1;
                            otherID = objSpeciality.SpecialityID; //21; 
                            specialityID = objSpeciality.SpecialityID; //1;// 
                            returnCode = pvisitBL.GetTaskActionID(OrgID, purpID, otherID, out lstTaskAction);
                            TaskActions taskAction = new TaskActions();
                            taskAction = lstTaskAction[0];
                            if (returnCode == 0)
                            {
                                //*******for Task*******************
                                //Created by ashok to add multiple tasks
                                //Evaluate
                                for (int i = 0; i < lstTaskAction.Count; i++)
                                {
                                    taskAction = lstTaskAction[i];

                                    returnCode = Utilities.GetHashTable(taskAction.TaskActionID, visitID, phyID,
                                                              patientID, patient.TitleName + " " + patient.Name, physicianName, otherID, "", 0, "", 0, "", out dText, out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID
                                    task.TaskActionID = taskAction.TaskActionID;
                                    task.DispTextFiller = dText;
                                    task.URLFiller = urlVal;
                                    task.PatientID = patientID;

                                    task.AssignedTo = 0;
                                    task.OrgID = OrgID;
                                    task.PatientVisitID = visitID;
                                    task.SpecialityID = specialityID;
                                    task.CreatedBy = LID;
                                    returnCode = taskBL.CreateTask(task, out ptaskID);
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            else
            {
                returnCode = 0;
            }


            return returnCode;

        }
        public long InsertPatientBilling(Patient pdetails, FinalBill finalBill, long ReferingPhysicianID, int ReferingspecialityID,
                                            long SpecialityID, List<PatientDueChart> lstDueChart, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
                                            string Paymentstaus, string pGuID, DataTable dtAmtReceived, List<OrderedInvestigations> lstOrderedInves,
                                            List<TaxBillDetails> lstTaxDetails, out List<BillingDetails> lstBillingdetails,
                                            out int returnStatus, int SavePicture, string sVal, int RoleID, long LID,
               PageContextkey PageContextDetails, string IsReceptionPhlebotomist, int ExternelPatient, string WardNo,
               long EpisodeID, long EpisodeVisitID, long EpisodeTrackID, long SiteID, string VisitSampleStatus, DateTime SamplePickupDate, string ConsignmentNo, List<ControlMappingDetails> lstControlSavedValues,
               string IsEditMode, out int needTaskDisplay, List<PatientDisPatchDetails> lstDispatchDetails, List<VisitClientMapping> lstVisitClientMapping,
               out long PatientRoleID, long OnBehalfofClientID, long TodayVisitID, string IsSamplePickUP,
               string externalVisitID, string approvalNo, out long taskID, String IsCopay, List<PatientDiscount> lstPatientDiscount, string strMyCardActiveDays, string strMemebershipcardType, string strHealthCardType, string strOTP, string strStatus, long strMembershipCardMappingID, string strCreditRedeem, long RedeemPatientid, long RedeemVisitid, long RedeemOrgId, decimal RedemPoints,
               decimal RedemValue, List<PatientRedemDetails> lstPatientRedemDetails, List<OrderedInvestigations> lstPkgandGrps, string StatFlag, string ClientFlag, long CollectionID,string EmailCC,string VisitNumber,string ClinicCode,string value,List<VisitTemplate> visittemplate,List<PatientVisitLanguage> lstPatlanguage,string DueReason,string DueAuthorizer, string HealthHubId)
        {

            long returnCode = 0;
            returnStatus = -1;
            PatientRoleID = 0;
            lstBillingdetails = new List<BillingDetails>();
            needTaskDisplay = -1;
            taskID = -1;
            string IsSTAT = "N";
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).InsertPatientBilling(pdetails, finalBill, ReferingPhysicianID, ReferingspecialityID, SpecialityID, lstDueChart, AgeValue, AgeUnit, pSpecialityID,
                                            ReferralType, Paymentstaus, pGuID, dtAmtReceived, lstOrderedInves, lstTaxDetails, out lstBillingdetails,
                                            out returnStatus, ExternelPatient, WardNo, EpisodeID, EpisodeVisitID, SiteID, VisitSampleStatus,
											EpisodeTrackID, SamplePickupDate, ConsignmentNo, lstControlSavedValues, IsEditMode, lstDispatchDetails,
                                            lstVisitClientMapping, out PatientRoleID, OnBehalfofClientID, TodayVisitID, externalVisitID, approvalNo, IsCopay, lstPatientDiscount, strMyCardActiveDays, strMemebershipcardType, strHealthCardType, strOTP, strStatus, strMembershipCardMappingID, strCreditRedeem, RedeemPatientid, RedeemVisitid, RedeemOrgId, RedemPoints,
                                            RedemValue, lstPatientRedemDetails, lstPkgandGrps, StatFlag, ClientFlag, CollectionID, EmailCC, VisitNumber, ClinicCode, value, visittemplate, lstPatlanguage, DueReason, DueAuthorizer, HealthHubId);

                foreach (PatientDueChart Obj in lstDueChart)
                {
                    if (Obj.IsSTAT == "Y")
                    {
                        IsSTAT = "Y";
                    }

                }
                if (returnStatus >= 0 && IsEditMode != "Y")
                {

                    CollectSampleTaskCreator(finalBill.OrgID, LID, lstOrderedInves, lstBillingdetails[0].LabNo,
                    lstBillingdetails[0].BillNumber, lstBillingdetails[0].PatientID, lstBillingdetails[0].VisitID, pGuID, RoleID,
                    IsReceptionPhlebotomist, out needTaskDisplay, IsSamplePickUP, IsSTAT, out  taskID);

                    PageContextDetails.PatientID = lstBillingdetails[0].PatientID;
                    PageContextDetails.PatientVisitID = lstBillingdetails[0].VisitID;
                    PageContextDetails.FinalBillID = lstBillingdetails[0].FinalBillID;
                    PageContextDetails.BillNumber = lstBillingdetails[0].FinalBillID.ToString();
                    PageContextDetails.ID = LID;// Assign OrgAdressID
                    ActionManager objActionManager = new ActionManager(globalContextDetails);
                    // objActionManager.PerformingNextStep(PageContextDetails);
                    objActionManager.PerformingNextStepNotification(PageContextDetails, "", "");
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL InsertPatientBilling", ex);
            }

            return returnStatus;
        }
		public long InsertPatientBillingHL(Patient pdetails, FinalBill finalBill, long ReferingPhysicianID, int ReferingspecialityID,
                                            long SpecialityID, List<PatientDueChart> lstDueChart, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
                                            string Paymentstaus, string pGuID, DataTable dtAmtReceived, List<OrderedInvestigations> lstOrderedInves,
                                            List<TaxBillDetails> lstTaxDetails, out List<BillingDetails> lstBillingdetails,
                                            out int returnStatus, int SavePicture, string sVal, int RoleID, long LID,
               PageContextkey PageContextDetails, string IsReceptionPhlebotomist, int ExternelPatient, string WardNo,
               long EpisodeID, long EpisodeVisitID, long EpisodeTrackID, long SiteID, string VisitSampleStatus, DateTime SamplePickupDate, string ConsignmentNo, List<ControlMappingDetails> lstControlSavedValues,
               string IsEditMode, out int needTaskDisplay, List<PatientDisPatchDetails> lstDispatchDetails, List<VisitClientMapping> lstVisitClientMapping,
               out long PatientRoleID, long OnBehalfofClientID, long TodayVisitID, string IsSamplePickUP,
               string externalVisitID, string approvalNo, out long taskID, String IsCopay, List<PatientDiscount> lstPatientDiscount, string strMyCardActiveDays, string strMemebershipcardType, string strHealthCardType, string strOTP, string strStatus, long strMembershipCardMappingID, string strCreditRedeem, long RedeemPatientid, long RedeemVisitid, long RedeemOrgId, decimal RedemPoints,
               decimal RedemValue, int ExternalVisitType, string ORCNumber, string MigratedvisitNumber, string MigratedRequestNumber, 
            List<PatientRedemDetails> lstPatientRedemDetails, List<OrderedInvestigations> lstPkgandGrps, string StatFlag, string ClientFlag, long CollectionID,
            string EmailCC, string VisitNumber, string ClinicCode, string value, string Person_Identifier, string physicianPNo, string FutureDate,
            string ReportMode, DateTime PatientRegDateTime, DateTime OrderedDateTime, string HLEnteredby, long reportClientid, bool IsCumulative,string ParentOrder,
            string Relevant_Clinical_Information,string Placer_Field2,string Collectors_Comment,string ClientInvoiceNo)
        {

            long returnCode = 0;
            returnStatus = -1;
            PatientRoleID = 0;
            lstBillingdetails = new List<BillingDetails>();
            needTaskDisplay = -1;
            taskID = -1;
            string IsSTAT = "N";
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).InsertPatientBillingHL(pdetails, finalBill, ReferingPhysicianID, ReferingspecialityID, SpecialityID, lstDueChart, AgeValue, AgeUnit, pSpecialityID,
                                            ReferralType, Paymentstaus, pGuID, dtAmtReceived, lstOrderedInves, lstTaxDetails, out lstBillingdetails,
                                            out returnStatus, ExternelPatient, WardNo, EpisodeID, EpisodeVisitID, SiteID, VisitSampleStatus,
											EpisodeTrackID, SamplePickupDate, ConsignmentNo, lstControlSavedValues, IsEditMode, lstDispatchDetails,
                                            lstVisitClientMapping, out PatientRoleID, OnBehalfofClientID, TodayVisitID, externalVisitID, approvalNo, IsCopay, lstPatientDiscount, strMyCardActiveDays, strMemebershipcardType, strHealthCardType, 
                                            strOTP, strStatus, strMembershipCardMappingID,
                                            strCreditRedeem, RedeemPatientid, RedeemVisitid, RedeemOrgId, RedemPoints,
                                            RedemValue, lstPatientRedemDetails, lstPkgandGrps, StatFlag, ClientFlag, CollectionID, EmailCC, VisitNumber, ClinicCode, value, Person_Identifier, physicianPNo, FutureDate,
                                            ExternalVisitType, ORCNumber, MigratedvisitNumber, MigratedRequestNumber, ReportMode, PatientRegDateTime,
                             OrderedDateTime, HLEnteredby, reportClientid, IsCumulative, ParentOrder, Relevant_Clinical_Information, Placer_Field2, Collectors_Comment, ClientInvoiceNo);
                foreach (PatientDueChart Obj in lstDueChart)
                {
                    if (Obj.IsSTAT == "Y")
                    {
                        IsSTAT = "Y";
                    }
                }
                if (returnStatus >= 0 && IsEditMode != "Y")
                {
                    CollectSampleTaskCreator(finalBill.OrgID, LID, lstOrderedInves, lstBillingdetails[0].LabNo,
                    lstBillingdetails[0].BillNumber, lstBillingdetails[0].PatientID, lstBillingdetails[0].VisitID, pGuID, RoleID,
                    IsReceptionPhlebotomist, out needTaskDisplay, IsSamplePickUP, IsSTAT, out  taskID);
                    PageContextDetails.PatientID = lstBillingdetails[0].PatientID;
                    PageContextDetails.PatientVisitID = lstBillingdetails[0].VisitID;
                    PageContextDetails.FinalBillID = lstBillingdetails[0].FinalBillID;
                    PageContextDetails.BillNumber = lstBillingdetails[0].FinalBillID.ToString();
                    PageContextDetails.ID = LID;// Assign OrgAdressID
                    ActionManager objActionManager = new ActionManager(globalContextDetails);
                    objActionManager.PerformingNextStepNotification(PageContextDetails, "", "");
                }
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertPatientBilling in Patient_BL", ex);
            }
            return returnStatus;
        }
        public long InsertPatientBilling_Quantum(Patient pdetails, FinalBill finalBill, long ReferingPhysicianID, int ReferingspecialityID,
                                       long SpecialityID, List<PatientDueChart> lstDueChart, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
                                       string Paymentstaus, string pGuID, DataTable dtAmtReceived, List<OrderedInvestigations> lstOrderedInves,
                                       List<TaxBillDetails> lstTaxDetails, out List<BillingDetails> lstBillingdetails,
                                       out int returnStatus, int SavePicture, string sVal, int RoleID, long LID,
          PageContextkey PageContextDetails, string IsReceptionPhlebotomist, int ExternelPatient, string WardNo,
          long EpisodeID, long EpisodeVisitID, long EpisodeTrackID, long SiteID, string VisitSampleStatus, DateTime SamplePickupDate, string ConsignmentNo, List<ControlMappingDetails> lstControlSavedValues,
          string IsEditMode, out int needTaskDisplay, List<PatientDisPatchDetails> lstDispatchDetails, List<VisitClientMapping> lstVisitClientMapping,
          out long PatientRoleID, long OnBehalfofClientID, long TodayVisitID, string IsSamplePickUP,
          string externalVisitID, string approvalNo, List<OrderedInvestigations> lstPkgandGrps, string EmailCC, out long taskID, string value,string VisitNumber,string ClinicCode)
        {

            long returnCode = 0;
            returnStatus = -1;
            PatientRoleID = 0;
            lstBillingdetails = new List<BillingDetails>();
            needTaskDisplay = -1;
            taskID = -1;
            string IsSTAT = "N";
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    returnCode = new Patient_DAL(globalContextDetails).InsertPatientBilling_Quantum(pdetails, finalBill, ReferingPhysicianID, ReferingspecialityID, SpecialityID, lstDueChart, AgeValue, AgeUnit, pSpecialityID,
                                                ReferralType, Paymentstaus, pGuID, dtAmtReceived, lstOrderedInves, lstTaxDetails, out lstBillingdetails,
                                                out returnStatus, ExternelPatient, WardNo, EpisodeID, EpisodeVisitID, SiteID, VisitSampleStatus,
                                                EpisodeTrackID, SamplePickupDate, ConsignmentNo, lstControlSavedValues, IsEditMode, lstDispatchDetails,
                                            lstVisitClientMapping, out PatientRoleID, OnBehalfofClientID, TodayVisitID, externalVisitID, approvalNo, lstPkgandGrps, EmailCC, value,VisitNumber ,ClinicCode);

                    foreach (PatientDueChart Obj in lstDueChart)
                    {
                        if (Obj.IsSTAT == "Y")
                        {
                            IsSTAT = "Y";
                        }
                    }
                    if (returnStatus >= 0 && IsEditMode != "Y")
                    {
                        returnCode = CollectSampleTaskCreator(finalBill.OrgID, LID, lstOrderedInves, lstBillingdetails[0].LabNo,
                        lstBillingdetails[0].BillNumber, lstBillingdetails[0].PatientID, lstBillingdetails[0].VisitID, pGuID, RoleID,
                        IsReceptionPhlebotomist, out needTaskDisplay, IsSamplePickUP, IsSTAT, out  taskID);
                        PageContextDetails.PatientID = lstBillingdetails[0].PatientID;
                        PageContextDetails.PatientVisitID = lstBillingdetails[0].VisitID;
                        PageContextDetails.FinalBillID = lstBillingdetails[0].FinalBillID;
                        PageContextDetails.BillNumber = lstBillingdetails[0].FinalBillID.ToString();
                        PageContextDetails.ID = LID;// Assign OrgAdressID
                        ActionManager objActionManager = new ActionManager();
                        objActionManager.PerformingNextStepNotification(PageContextDetails, "", "");
                        if (returnCode >= 0)
                        {
                            tranScope.Complete();
                        }
                        else
                        {
                            tranScope.Dispose();
                            returnStatus = -1;
                        }
                    }
                    else if (returnStatus >= 0 && IsEditMode == "Y")
                    {
                        tranScope.Complete();
                    }
                    else
                    {
                        tranScope.Dispose();
                        returnStatus = -1;
                    }
                }

                catch (Exception ex)
                {
                    tranScope.Dispose();
			CLogger.LogError("Error while executing InsertPatientBilling_Quantum in Patient_BL", ex);
                }
            }
            return returnStatus;
        }

        public long GetClientNamebyClientType(int OrgID, string prefixtext, int ClientTypeID, int CustomerTypeID, out List<ClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            Patient_DAL gInvClientType = new Patient_DAL(globalContextDetails);
            returnCode = gInvClientType.GetClientNamebyClientType(OrgID, prefixtext, ClientTypeID, CustomerTypeID, out lstInvClientMaster);
            return returnCode;
        }



        public long GetMetaName(int Orgid, string prfixtext, int TypeID, out List<MetaType_Common> lstMetaname)
        {
            long returncode = -1;
            Patient_DAL groupname = new Patient_DAL(globalContextDetails);
            returncode = groupname.GetMetaName(Orgid, prfixtext, TypeID, out lstMetaname);

            return returncode;
        }



        public long SaveMetaTypeDetails(int OrgID, string Code, string TypeName, long TypeID, string Descrip, string Isactive, string Syslock)
        {
            long returnCode = -1;
            try
            {

                Patient_DAL patient = new Patient_DAL(globalContextDetails);
                returnCode = patient.SaveMetaTypeDetails(OrgID, Code, TypeName, TypeID, Descrip, Isactive, Syslock);

            }
            catch (Exception ex)
            {

			CLogger.LogError("Error while executing SaveMetaTypeDetails in Patient_BL", ex);
            }
            return returnCode;
        }



        public long SaveMetaValueDetails(int OrgID, int MetaValueID, string Code, string value, long TypeID, string Descrip, string IsActive)
        {
            long returnCode = -1;
            try
            {

                Patient_DAL patient = new Patient_DAL(globalContextDetails);
                returnCode = patient.SaveMetaValueDetails(OrgID, MetaValueID, Code, value, TypeID, Descrip, IsActive);

            }
            catch (Exception ex)
            {

			CLogger.LogError("Error while executing SaveMetaValueDetails in Patient_BL", ex);
            }
            return returnCode;
        }




        public long GetMetaValuebyName(int OrgID, long Typeid, long ValueID, string prefixtext, string TypeDetails, out List<MetaValue_Common> lstgroup)
        {
            long returncode = -1;
            Patient_DAL groupname = new Patient_DAL(globalContextDetails);
            returncode = groupname.GetMetaValuebyName(OrgID, Typeid, ValueID, prefixtext, TypeDetails, out lstgroup);
            return returncode;
        }


        public long SaveMetaValueMapping(int OrgID, int MetaValueID, string IdentifyingType, long IdentifyingValue)
        {
            long returnCode = -1;
            try
            {

                Patient_DAL patient = new Patient_DAL(globalContextDetails);
                returnCode = patient.SaveMetaValueMapping(OrgID, MetaValueID, IdentifyingType, IdentifyingValue);

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing SaveMetaValueMapping in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetIdentifyingValue(int OrgID, string GroupValue, string prefixtext, out List<EmployeeRegMaster> lstERM)
        {
            long returncode = -1;
            Patient_DAL EmpRegMaster = new Patient_DAL(globalContextDetails);
            returncode = EmpRegMaster.GetIdentifyingValue(OrgID, GroupValue, prefixtext, out lstERM);
            return returncode;
        }

        public long GetCheckMetaValueCode(string Code, string Type)
        {
            long lresult = -1;
            Patient_DAL Dal = new Patient_DAL(globalContextDetails);
            lresult = Dal.GetCheckMetaValueCode(Code, Type);
            return lresult;
        }

        public long GetSMSRecipientsList(int OrgID,string VisitNumber, string Types, string name, string bday, out List<Patient> lstRecipients, int startRowIndex, int pageSize, DateTime FromDate, DateTime ToDate, out int totalRows)
        {
            long returncode = -1;
            Patient_DAL objPatient = new Patient_DAL(globalContextDetails);
            returncode = objPatient.GetSMSRecipientsList(OrgID,VisitNumber, Types, name, bday, out lstRecipients, startRowIndex, pageSize, FromDate, ToDate, out  totalRows);
            return returncode;
        }

        public long GetSMSTemplateList(out List<ActionTemplate> lstSMSTemplate)
        {
            long returncode = -1;
            Patient_DAL objPatient = new Patient_DAL(globalContextDetails);
            returncode = objPatient.GetSMSTemplateList(out lstSMSTemplate);
            return returncode;
        }
        public long updatePatientvisitchanges(PatientVisit PV, int orgid)
        {
            long returncode = -1;
            Patient_DAL objPatient = new Patient_DAL(globalContextDetails);
            returncode = objPatient.updatePatientvisitchanges(PV, orgid);
            return returncode;
        }

        public long SearchByFilterSendSMS(string fromDate, string ToDate, string type, long investigationid, int groupid, int packageid, string ResultType, string drpmartial,
                                          string age1, string age2, string PatientNo, string Pname, string billno, int orgid, out List<Patient> lstRecipients, int startRowIndex,
                                          int pageSize, string protocolGrpName,string clientName,string refPhyName,string visitNumber, out int totalRows)
        {
            long returnCode = -1;
            totalRows = -1;
            Patient_DAL objPatient = new Patient_DAL();
            lstRecipients = new List<Patient>();
            try
            {
                returnCode = objPatient.SearchByFilterSendSMS(fromDate, ToDate, type, investigationid, groupid, packageid, ResultType, drpmartial, age1, age2,
                                                               PatientNo, Pname, billno, orgid, out lstRecipients, startRowIndex, pageSize,
                                                               protocolGrpName, clientName, refPhyName, visitNumber, out  totalRows);
            }
            catch (Exception ex)
            {

			CLogger.LogError("Error while executing SearchByFilterSendSMS in Patient_BL", ex);
            }
            return returnCode;


        }


        public long insertNotificationAudit(int OrgID, int AddressID, long LID, List<NotificationAudit> lstNotify)
        {
            long returnCode = -1;
            Patient_DAL obj = new Patient_DAL(globalContextDetails);

            try
            {
                returnCode = obj.insertNotificationAudit(OrgID, AddressID, LID, lstNotify);
            }
            catch (Exception ex)
            {

			CLogger.LogError("Error while executing insertNotificationAudit in Patient_BL", ex);
            }
            return returnCode;

        }
        public long GetPatientVisitInvestigation(long visitid, int orgid, out List<OrderedInvestigations> lstorderedinve)
        {
            long returncode = -1;
            Patient_DAL objPatient = new Patient_DAL(globalContextDetails);
            returncode = objPatient.GetPatientVisitInvestigation(visitid, orgid, out lstorderedinve);
            return returncode;
        }
        public long saveDispatchInvestigationRestult(DataTable dtvisit, string couriername, string doctorCourier, string emid, long LID, string comments, int orgid, string despatchtype, int despatchmode, string homedate, string doctorDate, List<PatientDisPatchDetails> lstPatDispatchDetails, string MobilNo, string Email)
        {
            long returncode = -1;
            Patient_DAL objPatient = new Patient_DAL(globalContextDetails);
            try
            {
                returncode = objPatient.saveDispatchInvestigationRestult(dtvisit, couriername, doctorCourier, emid, LID, comments, orgid, despatchtype, despatchmode, homedate, doctorDate, lstPatDispatchDetails, MobilNo, Email);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing saveDispatchInvestigationRestult in Patient_BL", ex);
            }
            return returncode;


        }
        public long GetApprovedInvestigationPatient(long visitid, string PatientNo, string Name, string fromDate, string ToDate, int OrgID, out List<PatientVisit> lstpatientvisit)
        {
            long returncode = -1;
            Patient_DAL objPatient = new Patient_DAL(globalContextDetails);
            returncode = objPatient.GetApprovedInvestigationPatient(visitid, PatientNo, Name, fromDate, ToDate, OrgID, out lstpatientvisit);


            return returncode;

        }
        public long insertpublishvisitInvestigation(DataTable dtvisit, long LID, int orgid)
        {
            long returncode = -1;
            Patient_DAL objPatient = new Patient_DAL(globalContextDetails);
            try
            {
                returncode = objPatient.insertpublishvisitInvestigation(dtvisit, LID, orgid);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing insertpublishvisitInvestigation in Patient_BL", ex);
            }
            return returncode;


        }

        //-------------BABU 19-12-2012----------------

        public long InsertAmbulanceDetails(List<PatientAmbulancedetails> lstAmbulance)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Patient_DAL(globalContextDetails).InsertAmbulanceDetails(lstAmbulance);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertAmbulanceDetails in Patient_BL", ex);
            }

            return returnCode;

        }
        //--------------------end--------------------



        public long SaveEMRHistory(List<PatientHistory> lstPatientHisPKG, List<PatientHistoryAttribute> lstPatientHisPKGAttributes, long createdBy, long VisitID, long PatientID)
        {
            long returnCode = -1;


            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SaveEMRHistory(lstPatientHisPKG, lstPatientHisPKGAttributes, createdBy, VisitID, PatientID);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveEMRHistory in Patient_BL", ex);
            }
            return returnCode;
        }


        public long SaveHistoryQuickBilling(List<InvHistoryAttributes> lstInvHistoryAttributes, int OrgID, long createdBy, long VisitID, long PatientID)
        {
            long returnCode = -1;


            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SaveHistoryQuickBilling(lstInvHistoryAttributes, OrgID, createdBy, VisitID, PatientID);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveHistoryQuickBilling in Patient_BL", ex);
            }
            return returnCode;
        }


        public long GetPatientMRDDetils(string PatientNo, string PatientName, string DateFrom, string DateTO, int OrgID, string SearchType, string SearchName, string MrdStatus, out List<PatientMRDDetails> lstPatientMRDDetails)
        {
            long returnCode = -1;
            lstPatientMRDDetails = new List<PatientMRDDetails>();

            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetPatientMRDDetils(PatientNo, PatientName, DateFrom, DateTO, OrgID, SearchType, SearchName, MrdStatus, out lstPatientMRDDetails);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientMRDDetils in Patient_BL", ex);
            }

            return returnCode;
        }


        public long GetMRDFileDetails(long PatiendID, long PatiendVisitID, long OrgID, out List<PatientMRDDetails> lstPatientMRDDetails)
        {
            long returnCode = -1;
            lstPatientMRDDetails = new List<PatientMRDDetails>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetMRDFileDetails(PatiendID, PatiendVisitID, OrgID, out lstPatientMRDDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetMRDFileDetails in Patient_BL", ex);
            }

            return returnCode;
        }

        public long GetMRDType(string liType, string Desc, int OrgID, out List<PatientMRDDetails> lstPatientMRDDetails)
        {
            long returnCode = -1;
            lstPatientMRDDetails = new List<PatientMRDDetails>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetMRDType(liType, Desc, OrgID, out lstPatientMRDDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetMRDType in Patient_BL", ex);
            }

            return returnCode;
        }
        public long InsertMRDFileDetails(long PatientID, long PatientVisitID, string CatTypeID, long CatID, long ToPerson, long CreatedBy, string Status)
        {
            long returnCode = -1;

            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.InsertMRDFileDetails(PatientID, PatientVisitID, CatTypeID, CatID, ToPerson, CreatedBy, Status);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertMRDFileDetails in Patient_BL", ex);
            }

            return returnCode;
        }
        public long GetPatientQualification(long patientID, out List<PatientQualification> PatientQualification)
        {
            long returnCode = -1;
            PatientQualification = new List<PatientQualification>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetPatientQualification(patientID, out PatientQualification);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientQualification in Patient_BL", ex);
            }
            return returnCode;
        }
        public long SavePatientVisitandTask(int OrgID, int ILocationID, long LID, Patient objPatient, List<PatientDueChart> lstPatientDueChart,
              List<SaveBillingDetails> lstBillingDetails, List<PatientReferringDetails> lstPatientRefDetails,
              List<OrderedInvestigations> lstOrderedInvestigations, long refPhyID, int refSpecialityID, int AgeValue, string AgeUnit,
              long pSpecialityID, string ReferralType, ref long patientID, ref long patientVisitID, string gUID, int RoleID, out int cnt, List<VisitClientMapping> lstVisitClientMapping)
        {
            int needTaskDisplay = -1;
            long returnCode = -1;
            cnt = 0;
            string pPatientNo = string.Empty;
            string pBillNumber = string.Empty;
            string pLabNO = string.Empty;
            long taskID = -1;
            string feeType = String.Empty;
            BillingEngine objBillingEngine = new BillingEngine(globalContextDetails);
            List<Patient> lstPatient = new List<Patient>();
            Tasks task = new Tasks();
            Tasks_BL taskBL = new Tasks_BL(globalContextDetails);
            Hashtable dText = new Hashtable();
            Hashtable urlVal = new Hashtable();
            int specialityID = -1;
            int otherID = -1;
            List<TaskActions> lstTaskAction = new List<TaskActions>();
            try
            {
                if (objPatient.VisitType != "1" && objPatient.PatientID <= 0)
                {
                    returnCode = new Patient_BL(globalContextDetails).CheckPatientforDuplicate(objPatient.Name, objPatient.PatientAddress[0].MobileNumber.Trim(), objPatient.PatientAddress[0].LandLineNumber.Trim(), OrgID, "", out cnt);
                }

                if (cnt <= 0)
                {

                    returnCode = objBillingEngine.InsertPatientAndVisit(ref patientID, ref patientVisitID, ref pPatientNo, LID, lstPatientDueChart, objPatient,
                    refPhyID, refSpecialityID, OrgID, ILocationID, AgeValue, AgeUnit, pSpecialityID, ReferralType, "", lstVisitClientMapping);

                    if (returnCode >= 0)
                    {
                        returnCode = new Patient_BL(globalContextDetails).GetPatientDemoandAddress(patientID, out lstPatient);
                        Patient patient;

                        patient = lstPatient.Count > 0 ? lstPatient[0] : new Patient();
                        if (lstOrderedInvestigations != null)
                        {
                            if (lstOrderedInvestigations.Count > 0)
                            {
                                foreach (OrderedInvestigations InvestList in lstOrderedInvestigations)
                                {
                                    InvestList.Status = "Ordered";
                                    InvestList.VisitID = patientVisitID;
                                }
                                int pOrderedInvCnt = 0;
                                string paymentstatus = "Paid";
                                returnCode = new Investigation_BL(globalContextDetails).SaveOrderedInvestigationHOS(lstOrderedInvestigations, OrgID, out pOrderedInvCnt,
                                paymentstatus, gUID, pLabNO);
                                returnCode = CollectSampleTaskCreator(OrgID, LID, lstOrderedInvestigations, pLabNO, pBillNumber, patientID, patientVisitID, gUID, RoleID, "N", out needTaskDisplay, "", "", out taskID);
                            }
                        }

                        #region Physiotheraphy

                        List<PatientDueChart> lstTempPhysiotherapy = (from lstduetemp in lstPatientDueChart
                                                                      where lstduetemp.FeeType == "PRO" && lstduetemp.Description != "Dialysis" && lstduetemp.Description != "Others"
                                                                      select lstduetemp).ToList();


                        List<OrderedPhysiotherapy> lstOrderedPhysiotherapy = new List<OrderedPhysiotherapy>();


                        if (lstTempPhysiotherapy.Count > 0)
                        {


                            foreach (PatientDueChart dueitem in lstTempPhysiotherapy)
                            {
                                OrderedPhysiotherapy ptt = new OrderedPhysiotherapy();
                                ptt.ProcedureID = dueitem.FeeID;
                                ptt.ProcedureName = dueitem.Description;
                                ptt.OdreredQty = dueitem.Unit;
                                ptt.Status = "Ordered";
                                ptt.PaymentStatus = "";
                                lstOrderedPhysiotherapy.Add(ptt);
                            }
                        }


                        if (lstOrderedPhysiotherapy.Count > 0)
                        {
                            string Type = "Ordered";
                            int Physiocount = 0;
                            returnCode = new Patient_BL(globalContextDetails).SaveOrderedPhysiotherapy(patientVisitID, ILocationID, OrgID, LID, Type, lstOrderedPhysiotherapy, out Physiocount);
                            if (Physiocount > 0)
                            {
                                Patient_BL patientBL = new Patient_BL(globalContextDetails);
                                returnCode = patientBL.GetPatientDemoandAddress(patientID, out lstPatient);
                                patient = lstPatient[0];
                                returnCode = Utilities.GetHashTable((long)TaskHelper.TaskAction.PerformPhysiotherapy, patientVisitID, 0,
                                patientID, patient.TitleName + " " + patient.Name, "", 0, "", 0, "", 0, feeType, out dText,
                                out urlVal, 0, patient.PatientNumber, patient.TokenNumber, "");
                                task.TaskActionID = (int)TaskHelper.TaskAction.PerformPhysiotherapy;
                                task.DispTextFiller = dText;
                                task.URLFiller = urlVal;
                                task.PatientID = patientID;
                                task.OrgID = OrgID;
                                task.PatientVisitID = patientVisitID;
                                task.TaskStatusID = (int)TaskHelper.TaskStatus.Pending;
                                task.CreatedBy = LID;
                                returnCode = taskBL.CreateTask(task, out taskID);
                            }


                        }


                        #endregion

                        #region Dialysis

                        List<PatientDueChart> lsdia = (from lstdia in lstPatientDueChart
                                                       where lstdia.FeeType == "PRO" && lstdia.Description == "Dialysis"
                                                       select lstdia).ToList();


                        if (lsdia.Count > 0)
                        {
                            returnCode = Utilities.GetHashTable((long)TaskHelper.TaskAction.PreDialysis, patientVisitID, 0,
                            patientID, patient.TitleName + " " + patient.Name, "", lsdia[0].FeeID, "", 0, "", 0,
                            feeType, out dText, out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID

                            task.TaskActionID = (int)TaskHelper.TaskAction.PreDialysis;
                            task.DispTextFiller = dText;
                            task.URLFiller = urlVal;
                            task.PatientID = patientID;
                            task.OrgID = OrgID;
                            task.PatientVisitID = patientVisitID;
                            task.TaskStatusID = (int)TaskHelper.TaskStatus.Pending;
                            task.CreatedBy = LID;
                            returnCode = taskBL.CreateTask(task, out taskID);

                        }

                        #endregion

                        #region Consultation

                        List<PatientDueChart> lsCon = (from lstCon in lstPatientDueChart
                                                       where lstCon.FeeType == "CON"
                                                       select lstCon).ToList();


                        if (lsCon.Count > 0)
                        {

                            foreach (PatientDueChart pdc in lsCon)
                            {
                                otherID = pdc.SpecialityID;
                                specialityID = pdc.SpecialityID;
                                returnCode = new PatientVisit_BL(globalContextDetails).GetTaskActionID(OrgID, 1, otherID, out lstTaskAction);
                                TaskActions taskAction = new TaskActions();
                                taskAction = lstTaskAction.Count > 0 ? lstTaskAction[0] : new TaskActions();
                                if (returnCode == 0)
                                {

                                    //*******for Task*******************
                                    //Created by ashok to add multiple tasks

                                    if ((specialityID == Convert.ToInt32(TaskHelper.speciality.Diabetology)) || (specialityID == Convert.ToInt32(TaskHelper.speciality.Endocrinology)) || (specialityID == Convert.ToInt32(TaskHelper.speciality.ANC)))
                                    {
                                        for (int i = 1; i < lstTaskAction.Count; i++)
                                        {
                                            taskAction = lstTaskAction[i];

                                            returnCode = Utilities.GetHashTable(taskAction.TaskActionID, patientVisitID, pdc.UserID,
                                            patientID, patient.TitleName + " " + patient.Name,
                                            pdc.Description, otherID, "", 0, "", 0, "", out dText,
                                            out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID
                                            task.TaskActionID = taskAction.TaskActionID;

                                            task.DispTextFiller = dText;
                                            task.URLFiller = urlVal;
                                            task.PatientID = patientID;

                                            task.AssignedTo = 0;
                                            task.OrgID = OrgID;
                                            task.PatientVisitID = patientVisitID;
                                            task.SpecialityID = specialityID;
                                            task.CreatedBy = LID;
                                            returnCode = taskBL.CreateTask(task, out taskID);
                                        }
                                        taskAction = lstTaskAction[0];
                                        returnCode = Utilities.GetHashTable(taskAction.TaskActionID, patientVisitID, pdc.UserID,
                                        patientID, patient.TitleName + " " + patient.Name,
                                        pdc.Description, otherID, "", 0, "", 0, "", out dText,
                                        out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID
                                        task.TaskActionID = taskAction.TaskActionID;

                                        task.DispTextFiller = dText;
                                        task.URLFiller = urlVal;
                                        task.PatientID = patientID;
                                        task.AssignedTo = pdc.UserID;
                                        task.OrgID = OrgID;
                                        task.PatientVisitID = patientVisitID;
                                        task.SpecialityID = specialityID;
                                        task.CreatedBy = LID;
                                        returnCode = taskBL.CreateTask(task, out taskID);
                                    }
                                    else
                                    {
                                        for (int i = 0; i < lstTaskAction.Count; i++)
                                        {
                                            taskAction = lstTaskAction[i];

                                            returnCode = Utilities.GetHashTable(taskAction.TaskActionID, patientVisitID, pdc.UserID,
                                            patientID, patient.TitleName + " " + patient.Name,
                                            pdc.Description, otherID, "", 0, "", 0, "", out dText,
                                            out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID
                                            task.TaskActionID = taskAction.TaskActionID;
                                            task.DispTextFiller = dText;
                                            task.URLFiller = urlVal;
                                            task.PatientID = patientID;
                                            task.AssignedTo = pdc.UserID;
                                            task.OrgID = OrgID;
                                            task.PatientVisitID = patientVisitID;
                                            task.SpecialityID = specialityID;
                                            task.CreatedBy = LID;
                                            returnCode = taskBL.CreateTask(task, out taskID);
                                        }
                                    }

                                }
                            }
                        }
                        #endregion

                        #region Speciality

                        List<PatientDueChart> lstSpeciality = (from lstCon in lstPatientDueChart
                                                               where lstCon.FeeType == "SPE"
                                                               select lstCon).ToList();


                        if (lstSpeciality.Count > 0)
                        {

                            foreach (PatientDueChart pdc in lstSpeciality)
                            {
                                otherID = (int)pdc.FeeID;
                                specialityID = (int)pdc.FeeID;
                                returnCode = new PatientVisit_BL(globalContextDetails).GetTaskActionID(OrgID, 1, otherID, out lstTaskAction);
                                TaskActions taskAction = new TaskActions();
                                taskAction = lstTaskAction.Count > 0 ? lstTaskAction[0] : new TaskActions();
                                if (returnCode == 0)
                                {

                                    //*******for Task*******************
                                    //Created by ashok to add multiple tasks

                                    if ((specialityID == Convert.ToInt32(TaskHelper.speciality.Diabetology)) || (specialityID == Convert.ToInt32(TaskHelper.speciality.Endocrinology)) || (specialityID == Convert.ToInt32(TaskHelper.speciality.ANC)))
                                    {
                                        for (int i = 1; i < lstTaskAction.Count; i++)
                                        {
                                            taskAction = lstTaskAction[i];

                                            returnCode = Utilities.GetHashTable(taskAction.TaskActionID, patientVisitID, pdc.UserID,
                                            patientID, patient.TitleName + " " + patient.Name,
                                            pdc.Description, otherID, "", 0, "", 0, "", out dText,
                                            out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID
                                            task.TaskActionID = taskAction.TaskActionID;

                                            task.DispTextFiller = dText;
                                            task.URLFiller = urlVal;
                                            task.PatientID = patientID;

                                            task.AssignedTo = 0;
                                            task.OrgID = OrgID;
                                            task.PatientVisitID = patientVisitID;
                                            task.SpecialityID = specialityID;
                                            task.CreatedBy = LID;
                                            returnCode = taskBL.CreateTask(task, out taskID);
                                        }
                                        taskAction = lstTaskAction[0];
                                        returnCode = Utilities.GetHashTable(taskAction.TaskActionID, patientVisitID, pdc.UserID,
                                        patientID, patient.TitleName + " " + patient.Name,
                                        pdc.Description, otherID, "", 0, "", 0, "", out dText,
                                        out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID
                                        task.TaskActionID = taskAction.TaskActionID;

                                        task.DispTextFiller = dText;
                                        task.URLFiller = urlVal;
                                        task.PatientID = patientID;
                                        task.AssignedTo = 0;
                                        task.OrgID = OrgID;
                                        task.PatientVisitID = patientVisitID;
                                        task.SpecialityID = specialityID;
                                        task.CreatedBy = LID;
                                        returnCode = taskBL.CreateTask(task, out taskID);
                                    }
                                    else
                                    {
                                        for (int i = 0; i < lstTaskAction.Count; i++)
                                        {
                                            taskAction = lstTaskAction[i];

                                            returnCode = Utilities.GetHashTable(taskAction.TaskActionID, patientVisitID, pdc.UserID,
                                            patientID, patient.TitleName + " " + patient.Name,
                                            pdc.Description, otherID, "", 0, "", 0, "", out dText,
                                            out urlVal, 0, patient.PatientNumber, patient.TokenNumber, ""); // Other Id meand Procedure ID
                                            task.TaskActionID = taskAction.TaskActionID;
                                            task.DispTextFiller = dText;
                                            task.URLFiller = urlVal;
                                            task.PatientID = patientID;
                                            task.AssignedTo = 0;
                                            task.OrgID = OrgID;
                                            task.PatientVisitID = patientVisitID;
                                            task.SpecialityID = specialityID;
                                            task.CreatedBy = LID;
                                            returnCode = taskBL.CreateTask(task, out taskID);
                                        }
                                    }

                                }
                            }
                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SavePatientVisitandTask in Patient_BL", ex);
            }

            return returnCode;
        }

        public long GetRelationshipMaster(long OrgID, out List<RelationshipMaster> lstRelationshipMaster)
        {
            long returnCode = -1;
            lstRelationshipMaster = new List<RelationshipMaster>();
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).GetRelationshipMaster(OrgID, out lstRelationshipMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetRelationshipMaster in Patient_BL", ex);
            }

            return returnCode;
        }
        public long InsertEmegencyPatient(Patient lsPatient, int SeverityOrgMappingID, List<PatientAmbulancedetails> lstAmbulance, out List<Patient> lstPatientOut)
        {
            long returnCode = -1;
            lstPatientOut = new List<Patient>();
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).InsertEmegencyPatient(lsPatient, SeverityOrgMappingID, lstAmbulance, out lstPatientOut);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertEmegencyPatient in Patient_BL", ex);
            }

            return returnCode;

        }

        public long InsertTemporaryBills(long PatientID, long PatientVisitID, List<PatientDueChart> lstDueChart)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.InsertTemporaryBills(PatientID, PatientVisitID, lstDueChart);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertTemporaryBills in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetVisitWiseBillDetails(long VisitID, long PatientID, string Type, out List<DayWiseCollectionReport> lstVisitWiseBillDetails)
        {
            long returnCode = -1;
            lstVisitWiseBillDetails = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).GetVisitWiseBillDetails(VisitID, PatientID, Type, out lstVisitWiseBillDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetVisitWiseBillDetails in Patient_BL", ex);
            }

            return returnCode;
        }
        public long ConvertOPtoIPBill(long PatientID, List<SaveBillingDetails> lstBillingIDDetails, string Type)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.ConvertOPtoIPBill(PatientID, lstBillingIDDetails, Type);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing ConvertOPtoIPBill in Patient_BL", ex);
            }
            return returnCode;
        }


        public long GetPatientDispatchDetails(long visitid, long PatientID, int OrgID, out  List<ActionManagerType> lstPatientActiontype, out List<PatientDisPatchDetails> lstpatientDEspatchdetails, out List<MetaData> lstpatientmetadataOutput, out List<PatientVisit> lstPatientVisitDespatch)
        {
            long returncode = -1;
            lstPatientActiontype = new List<ActionManagerType>();
            lstpatientDEspatchdetails = new List<PatientDisPatchDetails>();
            lstpatientmetadataOutput = new List<MetaData>();
            lstPatientVisitDespatch = new List<PatientVisit>();
            Patient_DAL patientDAL = new Patient_DAL();

            returncode = patientDAL.GetPatientDispatchDetails(visitid, PatientID, OrgID, out lstPatientActiontype, out lstpatientDEspatchdetails, out lstpatientmetadataOutput, out lstPatientVisitDespatch);

            return returncode;

        }

        public long GetEmergencySeverity(long OrgID, out List<EmergencySeverityOrgMapping> lstEmergencySeverity)
        {
            long returnCode = -1;
            lstEmergencySeverity = new List<EmergencySeverityOrgMapping>();
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).GetEmergencySeverity(OrgID, out lstEmergencySeverity);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetEmergencySeverity in Patient_BL", ex);
            }

            return returnCode;
        }

        public long UpdateEmpPatient(long OldPatientID, long NewPatientID)
        {

            long returnCode = -1;

            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.UpdateEmpPatient(OldPatientID, NewPatientID);
            }

            catch (Exception ex)
            {

			CLogger.LogError("Error while executing UpdateEmpPatient in Patient_BL", ex);
            }

            return returnCode;

        }
        public long SearchBankcheckNo(string BankName, string ChequeorCardNumber, int OrgID, out List<AmountReceivedDetails> lstAmountReceivedDetails)
        {
            long returnCode = -1;
            lstAmountReceivedDetails = new List<AmountReceivedDetails>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SearchBankcheckNo(BankName, ChequeorCardNumber, OrgID, out lstAmountReceivedDetails);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchBankcheckNo in Patient_BL", ex);

            }
            return returnCode;
        }
        public long GetAmountApprovalDetails(long AmountApprovalDetailsID, int pOrgID, out List<AmountApprovalDetails> lstAmountApprovalDetails)
        {
            long returnCode = -1;
            lstAmountApprovalDetails = new List<AmountApprovalDetails>();

            try
            {
                returnCode = new Patient_DAL(globalContextDetails).GetAmountApprovalDetails(AmountApprovalDetailsID, pOrgID, out lstAmountApprovalDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAmountApprovalDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetUpdateAmountApprovalDetails(long AmountApprovalID, string RefType, string comments, string ApprovalStatus, int OrgId, out string GetStatus)
        {
            long returnCode = -1;
            GetStatus = "";
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetUpdateAmountApprovalDetails(AmountApprovalID, RefType, comments, ApprovalStatus, OrgId, out  GetStatus);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetUpdateAmountApprovalDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long InsertAmountApprovalDetails(AmountApprovalDetails AAD, int OrgId, int RoleId, int CreatedBy, out int BillApprovalID)
        {
            long returnCode = -1;
            BillApprovalID = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.InsertAmountApprovalDetails(AAD, OrgId, RoleId, CreatedBy, out  BillApprovalID);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertAmountApprovalDetails in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetInvTransferClientMaster(int OrgID, string Status, out List<InvClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            lstInvClientMaster = new List<InvClientMaster>();
            try
            {
                Patient_DAL gInvClientMaster = new Patient_DAL(globalContextDetails);
                returnCode = gInvClientMaster.GetInvTransferClientMaster(OrgID, out lstInvClientMaster);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetTrustedOrgInvClientMaster in Patient_BL", e);
            }
            return returnCode;
        }

        public long UpdateSampleTransfer(List<PatientInvSample> lstPatientInvSample)
        {
            long retCode = -1;
            //DataTable invPMDT = GetInvPackageMappingDataTable(lstInvPackageMapping);
            //DataTable inv = GetInvPackage(lstDeletedPackageMapping);
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.UpdateSampleTransfer(lstPatientInvSample);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing UpdateSampleTransfer in Patient_BL", e);
            }
            return retCode;
        }

        public long GetPatientInvestigationDetails(string visitnumber, string patientname, string status, long ClientID, string Fdate, string Tdate, int OrgID, long OrgAddID, long PatientID, string Category, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetPatientInvestigationDetails(visitnumber, patientname, status, ClientID, Fdate, Tdate, OrgID, OrgAddID, PatientID, Category, out lstPatient);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientInvestigationDetails in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetPatientListforBookings(string pName, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            Patient_DAL PatDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = PatDAL.GetPatientListforBookings(pName, pOrgID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientListforBookings in Patient_BL", ex);
            }
            return returnCode;
        }

        public long InsertPatientDiscount(DataTable dtPatientDiscount)
        {
            long returnCode = -1;
            try
            {

                Patient_DAL patient = new Patient_DAL(globalContextDetails);
                returnCode = patient.InsertPatientDiscount(dtPatientDiscount);

            }
            catch (Exception ex)
            {

			CLogger.LogError("Error while executing SaveMetaTypeDetails in Patient_BL", ex);
            }
            return returnCode;
        }

        public long SavePATAttributes(List<PatientHistoryAttribute> lstPatientAttributes, long VisitID)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.SavePATAttributes(lstPatientAttributes, VisitID);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SavePATAttributes in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetPatientTrackingDetails(long OrgID, string Name, string VisitNumber, string BarcodeNumber, string CaseNumber, long VsitID, string PatientNumber,
            long ClientID,out List<PatientVisitDetails> lstPatientVisitDetails, out List<PatientInvSample> lstPatientInvSample,
            out List<PatientInvestigation> lstPatientInvestigation, out List<WorklistMaster> lstWLMaster, out List<Notifications> lstNotifications)
        {
            long returnCode = -1;
            lstPatientVisitDetails = new List<PatientVisitDetails>();
            lstPatientInvSample = new List<PatientInvSample>();
            lstPatientInvestigation = new List<PatientInvestigation>();
            lstWLMaster = new List<WorklistMaster>();
            lstNotifications = new List<Notifications>();
            Patient_DAL PatDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = PatDAL.GetPatientTrackingDetails(OrgID, Name, VisitNumber, BarcodeNumber, CaseNumber, VsitID, PatientNumber, ClientID,
                    out lstPatientVisitDetails, out lstPatientInvSample, out lstPatientInvestigation,out lstWLMaster,out lstNotifications);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientTrackingDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientVisitNumber(long PatientId,out String VsitID, out String VisitNumber)
        {
            long returnCode = -1;
            VisitNumber = "";
            VsitID = "";
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetPatientVisitNumber(PatientId, out VsitID, out  VisitNumber);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientVisitNumber in Patient_BL", ex);
            }
            return returnCode;
        }

        public long GetPatientFileFath(long PatientId,String VsitID, out String FilePath)
        {
            long returnCode = -1;
            FilePath = "";
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetPatientFilePath(PatientId,VsitID, out  FilePath);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientFileFath in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientListNameandID(string pName, string pNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            Patient_DAL PatDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = PatDAL.pGetPatientListForNameandID(pName, pNo, pOrgID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientListNameandID in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientDetailsForInvestigation(long visitid, int orgid, out List<OrderedInvestigations> lstorderedinve)
        {
            long returncode = -1;
            Patient_DAL objPatient = new Patient_DAL(globalContextDetails);
            returncode = objPatient.GetPatientDetailsForInvestigation(visitid, orgid, out lstorderedinve);
            return returncode;
        }

        //Ab Code For MS Report
        public long SearchAdvanceClientDetails(int OrgID, long ClientID, string type, string fromdate, string todate, int GridPageNo, int GridPageSize, out List<AdvanceClientDetails> lstCollectionsHistory)
        {
            long returnCode = -1;
            lstCollectionsHistory = new List<AdvanceClientDetails>();
            try
            {
                Patient_DAL objPatient = new Patient_DAL(globalContextDetails);


                returnCode = objPatient.SearchAdvanceClientDetails(OrgID, ClientID, type, fromdate, todate, GridPageNo, GridPageSize, out lstCollectionsHistory);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchAdvanceClientDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        //Ab Code For MS Report
        public long SearchAdvancePatientDetails(int OrgID, long ClientID, long type, string fromdate, string todate, int GridPageNo, int GridPageSize, out List<AdvanceClientDetails> lstCollectionsHistory)
        {
            long returnCode = -1;
            lstCollectionsHistory = new List<AdvanceClientDetails>();
            try
            {
                Patient_DAL objPatient = new Patient_DAL(globalContextDetails);


                returnCode = objPatient.SearchAdvancePatientDetails(OrgID, ClientID, type, fromdate, todate, GridPageNo, GridPageSize, out lstCollectionsHistory);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchAdvancePatientDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetAdvanceAmountDetails(long CollectionID, int orgid, out List<CollectionsMaster> lstCollectionMaster)
        {
            long returncode = -1;
            Patient_DAL objPatient = new Patient_DAL(globalContextDetails);
            returncode = objPatient.GetAdvanceAmountDetails(CollectionID, orgid, out lstCollectionMaster);
            return returncode;
        }

        #region For CancelTest
        public long CheckStatusForCancelBill(long pPatientVisitID, long pPatientID, int pOrgID, out string outStatus)
        {
            long returnCode = -1;
            outStatus = string.Empty;
            try
            {
                returnCode = new Patient_DAL(globalContextDetails).CheckStatusForCancelBill(pPatientVisitID, pPatientID, pOrgID, out outStatus);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing CheckStatusForCancelBill in Patient_BL", ex);
            }
            return returnCode;
        }
        #endregion

        #region For PDF Upload
        public long pBulkInsertTRFDetails(List<TRFfilemanager> TRFdetails)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL objPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = objPatientDAL.pBulkInsertTRFDetails(TRFdetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveEpisodeTRFDetails in ClinicalTrail_BL", ex);
            }
            return returnCode;
        }
        #endregion


        public long GetPatientList(string pName, string pNo, string SmartCardNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = patientDAL.GetPatientList(pName, pNo, SmartCardNo, pOrgID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientList in Patient_BL", ex);
            }
            return returnCode;
        }
        #region HL7 Integration
        public long GetPatientData(string flag, string PatientId, int orgid, out List<HLMessages> objHLmessage)
        {
            long returnCode = -1;
            objHLmessage = new List<HLMessages>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetPatientData(flag, PatientId, orgid, out objHLmessage);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientData in Patient_BL", ex);
            }
            return returnCode;
        }
        public long insertHLMessage(HLMessages objHLmessage, string parentctrlId, string SendMsgContent, string HL7MSG)
        {
            long returncode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returncode = patientDAL.insertHLMessage(objHLmessage, parentctrlId, SendMsgContent, HL7MSG);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while insertHLMessage patient BL ", ex);
            }
            return returncode;
        }
        public long GetOrgDetails(string OrgName, string OrgAddressName, out List<Organization> objorgnaization)
        {
            long returnCode = -1;
            objorgnaization = new List<Organization>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetOrgDetails(OrgName, OrgAddressName, out objorgnaization);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetOrgDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetOrgDet(int OrgID, int OrgAddressID, out  List<Organization> objorgnaization)
        {
            long returnCode = -1;
            objorgnaization = new List<Organization>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returnCode = patientDAL.GetOrgDet(OrgID, OrgAddressID, out objorgnaization);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetOrgDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        #endregion
		
		 public long SearchParentClientPatientDetails(int OrgID, long ClientID, long type, string fromdate, string todate, int GridPageNo, int GridPageSize, out List<AdvanceClientDetails> lstCollectionsHistory)
        {
            long returnCode = -1;
            lstCollectionsHistory = new List<AdvanceClientDetails>();
            try
            {
                Patient_DAL objPatient = new Patient_DAL(globalContextDetails);


                returnCode = objPatient.SearchParentClientPatientDetails(OrgID, ClientID, type, fromdate, todate, GridPageNo, GridPageSize, out lstCollectionsHistory);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchParentClientPatientDetails in Patient_BL", ex);
            }
            return returnCode;
        }

         public long InsertQuotationbillingDetails(Patient pdetails, List<OrderedInvestigations> lstinvestigations, DataTable dtAmountReceivedDet, List<PatientDueChart> lstBillingAmountDetails,long QuotationID,out long VisitID)
         {

             long returnCode = 0;
             VisitID = 0;
          
             try
             {
                 returnCode = new Patient_DAL(globalContextDetails).InsertQuotationbillingDetails(pdetails, lstinvestigations, dtAmountReceivedDet, lstBillingAmountDetails,QuotationID,out VisitID);

                
                 
             }
             catch (Exception ex)
             {
			CLogger.LogError("Error while executing InsertQuotationbillingDetails in Patient_BL", ex);
             }

             return returnCode;
         }
		 
		 
       //---------------------------------Capture patient history start------------------------------------------
        public long SaveCapturePatientHistory(List<CapturePatientHistory> lstHistoryAttributes, int OrgID, long VisitID)
         {
             long returnCode = -1;
             try
             {
                 Patient_DAL ObjDAL = new Patient_DAL(globalContextDetails);


                 returnCode = ObjDAL.SaveCapturePatientHistory(lstHistoryAttributes, OrgID, VisitID);

             }
             catch (Exception ex)
             {
			CLogger.LogError("Error while executing SaveCapturePatientHistory in Patient_BL", ex);
             }
             return returnCode;
         }


         public long LoadAndCheckCapturePatientHistory(int Orgid, long InvestigationID, string ActionType, out List<CapturePatientHistory> lstHistoryAttributes)
         {
             lstHistoryAttributes = new List<CapturePatientHistory>();
             long returnCode = -1;
             try
             {
                 Patient_DAL ObjDAL = new Patient_DAL(globalContextDetails);


                 returnCode = ObjDAL.LoadAndCheckCapturePatientHistory(Orgid, InvestigationID, ActionType, out lstHistoryAttributes);

             }
             catch (Exception ex)
             {
			CLogger.LogError("Error while executing LoadAndCheckCapturePatientHistory in Patient_BL", ex);
             }
             return returnCode;

         }

         public long GetEditPatientHistory(int OrgID, long VisitID, out List<CapturePatientHistory> lsPatientHistory)
         {
             long returnCode = -1;
             lsPatientHistory = new List<CapturePatientHistory>();
             Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
             try
             {
                 returnCode = patientDAL.GetEditPatientHistory(OrgID, VisitID, out lsPatientHistory);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing GetEditPatientHistory in Patient_BL", ex);
             }
             return returnCode;
         }

         //----------------------Update Patient History-------------//

         public long UpdatePatientHistory(List<CapturePatientHistory> lstupdateHistory)
         {
             long result = -1;
             try
             {
                 Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                 result = patientDAL.UpdatePatientHistory(lstupdateHistory);
             }
             catch (Exception excep)
             {
			CLogger.LogError("Error while executing UpdatePatientHistory in Patient_BL", excep);
             }
             return result;
         }

        //---------------------------------Capture patient history end------------------------------------------
		
		
         public long InsertQuotationPatientInvSample(List<PatientInvSample> lstPatientInvSample, List<PatientInvSampleMapping> lstPatientInvSampleMapping,long QuotationID,long ClientID,long VisitID)
         {

             long returnCode = 0;      
             try
             {
                 returnCode = new Patient_DAL(globalContextDetails).InsertQuotationPatientInvSample(lstPatientInvSample, lstPatientInvSampleMapping, QuotationID, ClientID,VisitID);



             }
             catch (Exception ex)
             {
			CLogger.LogError("Error while executing InsertQuotationPatientInvSample in Patient_BL", ex);
             }

             return returnCode;
         }

         public long WGetBillDetails(int OrgID, long PatientVisitID, out List<BillDetails> bdetils)
         {
             long returnCode = -1;
             Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
             bdetils = new List<BillDetails>();
             returnCode = pDAL.WGetBillDetails(OrgID, PatientVisitID, out bdetils);
             return returnCode;
         }

         public long WUpdateNotifications(long PatientVisitID, int OrgID, String Msg)
         {
             long returnCode = -1;
             Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
             returnCode = pDAL.WUpdateNotifications(PatientVisitID, OrgID, Msg);
             return returnCode;
         }
         public long InsertPatientBilling_Integration(Patient pdetails, FinalBill finalBill, long ReferingPhysicianID, int ReferingspecialityID,
                                            long SpecialityID, List<PatientDueChart> lstDueChart, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
                                            string Paymentstaus, string pGuID, DataTable dtAmtReceived, List<OrderedInvestigations> lstOrderedInves,
                                            List<TaxBillDetails> lstTaxDetails, out List<BillingDetails> lstBillingdetails,
                                            out int returnStatus, int SavePicture, string sVal, int RoleID, long LID,
               PageContextkey PageContextDetails, string IsReceptionPhlebotomist, int ExternelPatient, string WardNo,
               long EpisodeID, long EpisodeVisitID, long EpisodeTrackID, long SiteID, string VisitSampleStatus, DateTime SamplePickupDate, string ConsignmentNo, List<ControlMappingDetails> lstControlSavedValues,
               string IsEditMode, out int needTaskDisplay, List<PatientDisPatchDetails> lstDispatchDetails, List<VisitClientMapping> lstVisitClientMapping,
               out long PatientRoleID, long OnBehalfofClientID, long TodayVisitID, string IsSamplePickUP,
               string externalVisitID, string approvalNo, out long taskID, String IsCopay, List<PatientDiscount> lstPatientDiscount, string strMyCardActiveDays, string strMemebershipcardType, string strHealthCardType, string strOTP, string strStatus, long strMembershipCardMappingID, string strCreditRedeem, long RedeemPatientid, long RedeemVisitid, long RedeemOrgId, decimal RedemPoints,
               decimal RedemValue, List<PatientRedemDetails> lstPatientRedemDetails, List<OrderedInvestigations> lstPkgandGrps, string StatFlag, string ClientFlag, long CollectionID, string EmailCC, string VisitNumber, string ClinicCode, string value)
         {

             long returnCode = 0;
             returnStatus = -1;
             PatientRoleID = 0;
             lstBillingdetails = new List<BillingDetails>();
             needTaskDisplay = -1;
             taskID = -1;
             string IsSTAT = "N";
             try
             {
                 returnCode = new Patient_DAL(globalContextDetails).InsertPatientBilling_Integration(pdetails, finalBill, ReferingPhysicianID, ReferingspecialityID, SpecialityID, lstDueChart, AgeValue, AgeUnit, pSpecialityID,
                                             ReferralType, Paymentstaus, pGuID, dtAmtReceived, lstOrderedInves, lstTaxDetails, out lstBillingdetails,
                                             out returnStatus, ExternelPatient, WardNo, EpisodeID, EpisodeVisitID, SiteID, VisitSampleStatus,
                                             EpisodeTrackID, SamplePickupDate, ConsignmentNo, lstControlSavedValues, IsEditMode, lstDispatchDetails,
                                             lstVisitClientMapping, out PatientRoleID, OnBehalfofClientID, TodayVisitID, externalVisitID, approvalNo, IsCopay, lstPatientDiscount, strMyCardActiveDays, strMemebershipcardType, strHealthCardType, strOTP, strStatus, strMembershipCardMappingID, strCreditRedeem, RedeemPatientid, RedeemVisitid, RedeemOrgId, RedemPoints,
                                             RedemValue, lstPatientRedemDetails, lstPkgandGrps, StatFlag, ClientFlag, CollectionID, EmailCC, VisitNumber, ClinicCode, value);

                 foreach (PatientDueChart Obj in lstDueChart)
                 {
                     if (Obj.IsSTAT == "Y")
                     {
                         IsSTAT = "Y";
                     }

                 }
                 if (returnStatus >= 0 && IsEditMode != "Y")
                 {

                     CollectSampleTaskCreator(finalBill.OrgID, LID, lstOrderedInves, lstBillingdetails[0].LabNo,
                     lstBillingdetails[0].BillNumber, lstBillingdetails[0].PatientID, lstBillingdetails[0].VisitID, pGuID, RoleID,
                     IsReceptionPhlebotomist, out needTaskDisplay, IsSamplePickUP, IsSTAT, out  taskID);

                     PageContextDetails.PatientID = lstBillingdetails[0].PatientID;
                     PageContextDetails.PatientVisitID = lstBillingdetails[0].VisitID;
                     PageContextDetails.FinalBillID = lstBillingdetails[0].FinalBillID;
                     PageContextDetails.BillNumber = lstBillingdetails[0].FinalBillID.ToString();
                     PageContextDetails.ID = LID;// Assign OrgAdressID
                     ActionManager objActionManager = new ActionManager(globalContextDetails);
                     // objActionManager.PerformingNextStep(PageContextDetails);
                     objActionManager.PerformingNextStepNotification(PageContextDetails, "", "");
                 }
             }
             catch (Exception ex)
             {
 			CLogger.LogError("Error while executing InsertPatientBilling in Patient_BL", ex);
             }

             return returnStatus;
         }

         // For Update/Insert assigned/Prior Ward Details in A02/A12 Msgtype
         //Begin
         public long UpdateWardDetails(String ExternalVisitId, String PatientNumber, String AssignedWardDetails, String PriorWardDetails, String MsgType)
         {
             long returnStatus = -1;
             // List<Patient> patient = new List<Patient>();
             try
             {
                 Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                 returnStatus = pDAL.UpdateWardDetails(ExternalVisitId, PatientNumber, AssignedWardDetails, PriorWardDetails, MsgType);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error Occur on Cancel Test in Patient_BL", ex);
             }
             return returnStatus;
         }
         //Code End
         // Merge the patient details with old to new through HL7 AdtA18
         //Begin
         public long PatientmergeHl7(String PatientNumber, String PatientName, String PriorPatientId, String MsgType)
         {
             long returnStatus = -1;
             // List<Patient> patient = new List<Patient>();
             try
             {
                 Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                 returnStatus = pDAL.PatientmergeHl7(PatientNumber, PatientName, PriorPatientId, MsgType);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error Occur on Cancel Test in Patient_BL", ex);
             }
             return returnStatus;
         }
         public long UpdateCancelBilling(String Orderid, String ObjStatus, string Person_Identifier, string physicianPNo)
         {
             long returnCancelStatus = -1;
             // List<Patient> patient = new List<Patient>();
             try
             {
                 Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                 returnCancelStatus = pDAL.UpdateCancelBilling(Orderid, ObjStatus, Person_Identifier, physicianPNo);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error Occur on Cancel Test in Patient_BL", ex);
             }
             return returnCancelStatus;
         }
        public long InsertHLMessageDetails(HLMessages objHLmessage, string parentctrlId, string SendMsgContent, string HL7MSG, List<HLMessageHeaderDetails> lstHLMessageHeaderDetails, List<HLMessageOBRDetails> lstHLMessageOBRDetails, List<HLMessageORCDetails> lstHLMessageORCDetails, List<HLMessagePatientIDDetails> lstHLMessagePatientIDDetails, List<HLMessageErrorDetails> lstHLMessageErrorDetails,List<HLMessages> lstHLMessages)
        {
            long returncode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                //lstHLMessageHeaderDetails = new List<HLMessageHeaderDetails>();
                //lstHLMessageOBRDetails = new List<HLMessageOBRDetails>();
                //lstHLMessageORCDetails = new List<HLMessageORCDetails>();
                //lstHLMessagePatientIDDetails = new List<HLMessagePatientIDDetails>();
                returncode = patientDAL.InsertHLMessageDetails(objHLmessage, parentctrlId, SendMsgContent, HL7MSG, lstHLMessageHeaderDetails, lstHLMessageOBRDetails, lstHLMessageORCDetails, lstHLMessagePatientIDDetails, lstHLMessageErrorDetails,lstHLMessages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while insertHLMessage patient BL ", ex);
            }
            return returncode;
        }
         public long InsertHistoSpecimenDetails(long OrgID, long OrgAddressID, List<HistoSpecimenDetails> lstspec)
         {
             long returnCode = -1;

             try
             {
                 returnCode = new Patient_DAL(globalContextDetails).InsertHistoSpecimenDetails(OrgID, OrgAddressID, lstspec);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while InsertHistoSpecimenDetails", ex);
             }
             return returnCode;
         }
		 public long GetHLMessageMandatoryDetails(int pOrgID, int LocationId, out List<HLMessageMandatoryDetails> lstHLMessageMandatoryDetails)
         {
             long lresult = -1;
             lstHLMessageMandatoryDetails = new List<HLMessageMandatoryDetails>();
             try
             {
                 Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                 lresult = patientDAL.GetHLMessageMandatoryDetails(pOrgID, LocationId, out lstHLMessageMandatoryDetails);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing GetPrescription in Patient_BL", ex);
             }
             return lresult;

         }
        public long GetOtherLocationFiledet(out List<HLMessageOBRDetails> lstHLMessageOBRDetails)
        {
            long lresult = -1;
            lstHLMessageOBRDetails = new List<HLMessageOBRDetails>();
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                lresult = patientDAL.GetOtherLocationFiledet(out lstHLMessageOBRDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOtherLocationFiledet in Patient_BL", ex);
            }
            return lresult;
        }
		 public long GetSecBarCodeDetForSamples(long VisitID, int OrgID, out List<PatientInvSample> lstPatientInvSample)
        {
            long returnCode = -1;
            lstPatientInvSample = new List<PatientInvSample>();
            Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = patientDAL.GetSecBarCodeDetForSamples(VisitID, OrgID, out lstPatientInvSample);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSecBarCodeDetForSamples in Patient_BL", ex);
            }
            return returnCode;
        }
		 public long GetGuidForSameVisit(string ExVisitNumber, int OrgID, out List<OrderedInvestigations> lstGuid)
        {
            long returnCode = -1;
            lstGuid = new List<OrderedInvestigations>();
            Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = patientDAL.GetGuidForSameVisit(ExVisitNumber, OrgID, out lstGuid);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSecBarCodeDetForSamples in Patient_BL", ex);
            }
            return returnCode;
        }
		public long GetHL7Segments(int OrgID, out List<HL7Segments> lstGuid)
        {
            long returnCode = -1;
            lstGuid = new List<HL7Segments>();
            Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = patientDAL.GetHL7Segments(OrgID, out lstGuid);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHL7Segments in Patient_BL", ex);
            }
            return returnCode;
        }
        //added by amar on 25-jan-1
        public long UpdateOtherLocationFileDetails(List<HLMessages> lstHLMessages, List<HLMessageErrorDetails> lstHLErrorDetails)
        {
            long returncode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                returncode = patientDAL.UpdateOtherLocationFileDetails(lstHLMessages, lstHLErrorDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateOtherLocationFileDetails in patient BL ", ex);
            }
            return returncode;
        }
        public long InsertUnRegisteredUserDetails(string ExVisitNumber, int OrgID)
        {
            long returnCode = -1;

            Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
            try
            {
                returnCode = patientDAL.InsertUnRegisteredUserDetails(ExVisitNumber, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSecBarCodeDetForSamples in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetClientName(int OrgID, string prefixtext, int ClientTypeID, out List<ClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            lstInvClientMaster = new List<ClientMaster>();
            try
            {
                Patient_DAL gInvClientType = new Patient_DAL(globalContextDetails);
                returnCode = gInvClientType.GetClientName(OrgID, prefixtext, ClientTypeID, out lstInvClientMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetClientName in patient BL ", ex);
            }
            return returnCode;
        }

        //Alex
        public long ActiveInactiveInvestigationDrugBrand(int ID, out long DrugID)
        {
            long reutnCode = -1;
            DrugID = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                reutnCode = patientDAL.ActiveInactiveInvestigationDrugBrand(ID, out DrugID);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing ActiveInactiveInvestigationDrugBrand in Patient_BL", excep);
            }
            return reutnCode;
        }

        public long GetDrugBrandMasterHistory(long ID, out List<InvestigationDrugBrand> lstDrugMaster)
        {
            long returnCode = -1;
            lstDrugMaster = new List<InvestigationDrugBrand>();
            try
            {
                Patient_DAL oPatientDAL = new Patient_DAL(globalContextDetails);
                returnCode = oPatientDAL.GetDrugBrandMasterHistory(ID, out lstDrugMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDrugBrandMasterHistory in Investigation_BL", ex);
            }

            return returnCode;
        }
		
		        public long GetBillingDetailsForEdit(long finalBillID, string pBillNo, int pOrgId, out List<FinalBill> lstFinalbill, out List<PatientDueChart> lstBillingDetails)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstFinalbill = new List<FinalBill>();
            lstBillingDetails = new List<PatientDueChart>();
            
            try
            {
                Patient_DAL oInvestigationDAL = new Patient_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetBillingDetailsForEdit(finalBillID,pBillNo,pOrgId,out lstFinalbill,out lstBillingDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBillingDetailsForEdit in Patient_Bl", ex);
            }

            return returnCode;

        }

        public long pEditPatientBillingByID(int pOrgId, long pfinalBillID, decimal pGrossValue, decimal pDiscount, decimal pNetValue, decimal pAmountReceived, List<PatientDueChart> lstPatientdue)
        {
            long returnCode = -1;           

            try
            {
                Patient_DAL oEditBill = new Patient_DAL(globalContextDetails);
                returnCode = oEditBill.pEditPatientBillingByID(pOrgId, pfinalBillID, pGrossValue, pDiscount, pNetValue, pAmountReceived, lstPatientdue);
               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing EditBill DAL", ex);
            }
            return returnCode;
        }

       
        
        public long GetHistoSpecimenDetails(long OrgID, long PatientVisitID, long TestID, string type,out List < HistoSpecimenDetails > lHistoSpecimendetails)
        {
            long rcode = -1;
            rcode = new Patient_DAL().GetHistoSpecimenDetails(OrgID, PatientVisitID, TestID, type, out lHistoSpecimendetails);
            return rcode;
        }

        public long GetInvestigationOrgChange(string ExternalVisitID, int OrgID, string FromDate, string toDate, string PatientName, string patientnumber, string pVisitNumber, string Param1, string Param2, string Param3, out List<PatientVisit> lstpatientVisit, out List<OrderedInvestigations> lstOrderinvestication)
        {
            long returncode = -1;
            lstpatientVisit = new List<PatientVisit>();
            lstOrderinvestication = new List<OrderedInvestigations>();
            try
            {
                returncode = new Patient_DAL(globalContextDetails).GetInvestigationOrgChange(ExternalVisitID, OrgID, FromDate, toDate, PatientName, patientnumber, pVisitNumber, Param1, Param2, Param3, out lstpatientVisit, out lstOrderinvestication);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationOrgChange in Patient_BL", ex);
            }
            return returncode;
        }
		
		 public long GetReprintRDLSize(int OrgID,out List<ReprintMergeRDLSize> lstReprintRDLSize)
        {
            long returnCode = -1;
            lstReprintRDLSize = new List<ReprintMergeRDLSize>();
            try
            {
                Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                returnCode = pDAL.GetReprintRDLSize(OrgID,out lstReprintRDLSize);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetReprintRDLSize in Patient_BL", ex);
            }
            return returnCode;
        }
		 public long GetVisitNumberbyPID(string PatienNumber, long PageID, out List<PatientVisit> lstVisitNumbers)
        {
            long lresult = -1;
            lstVisitNumbers = new List<PatientVisit>();
            try
            {
                Patient_DAL invdal = new Patient_DAL(globalContextDetails);
                lresult = invdal.GetVisitNumberbyPID(PatienNumber, PageID, out  lstVisitNumbers);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetVisitNumberbyPID BL", ex);

            }
            return lresult;
        }
         public long PatientTestHistoryValues(int OrgID,long PatientVisitID, out List<ClientAttributesKeyFields> lstFieldDetails)
         {
             long returnCode = -1;
             lstFieldDetails = new List<Attune.Podium.BusinessEntities.ClientAttributesKeyFields>();
             try
             {
                 Patient_DAL invdal = new Patient_DAL(globalContextDetails);
                 lstFieldDetails = new List<Attune.Podium.BusinessEntities.ClientAttributesKeyFields>();
                 returnCode = invdal.PatientTestHistoryValues(OrgID, PatientVisitID, out lstFieldDetails);

             }
             catch (Exception ex)
             {

                 CLogger.LogError("Error in ClientAttributesFieldDetails BillingEngine", ex);
             }
             return returnCode;
         }
		 public long CheckPatientConsentformAvailability(long VisitID, out string CT, out string MRI)
         {
             long returncode = -1;
             CT = string.Empty;
             MRI = string.Empty;
             try
             {
                 returncode = new Patient_DAL(globalContextDetails).CheckPatientConsentformAvailability(VisitID, out  CT, out  MRI);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error in CheckPatientConsentformAvailability patient bl", ex);
             }
             return returncode;
         }
		 
		      public long InsertPatientBillingFranchisee(Patient pdetails, FinalBill finalBill, long ReferingPhysicianID, int ReferingspecialityID,
                                           long SpecialityID, List<PatientDueChart> lstDueChart, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
                                           string Paymentstaus, string pGuID, DataTable dtAmtReceived, List<OrderedInvestigations> lstOrderedInves,
                                           List<TaxBillDetails> lstTaxDetails, out List<BillingDetails> lstBillingdetails,
                                           out int returnStatus, int SavePicture, string sVal, int RoleID, long LID,
              PageContextkey PageContextDetails, string IsReceptionPhlebotomist, int ExternelPatient, string WardNo,
              long EpisodeID, long EpisodeVisitID, long EpisodeTrackID, long SiteID, string VisitSampleStatus, DateTime SamplePickupDate, string ConsignmentNo, List<ControlMappingDetails> lstControlSavedValues,
              string IsEditMode, out int needTaskDisplay, List<PatientDisPatchDetails> lstDispatchDetails, List<VisitClientMapping> lstVisitClientMapping,
              out long PatientRoleID, long OnBehalfofClientID, long TodayVisitID, string IsSamplePickUP,
              string externalVisitID, string approvalNo, out long taskID, String IsCopay, List<PatientDiscount> lstPatientDiscount, string strMyCardActiveDays, string strMemebershipcardType, string strHealthCardType, string strOTP, string strStatus, long strMembershipCardMappingID, string strCreditRedeem, long RedeemPatientid, long RedeemVisitid, long RedeemOrgId, decimal RedemPoints,
              decimal RedemValue, List<PatientRedemDetails> lstPatientRedemDetails, List<OrderedInvestigations> lstPkgandGrps, string StatFlag, string ClientFlag, long CollectionID, string EmailCC, string VisitNumber, string ClinicCode, string value, List<VisitTemplate> visittemplate, List<PatientVisitLanguage> lstPatlanguage, string DueReason, string DueAuthorizer, string HealthHubId
					)
         {

             long returnCode = 0;
             returnStatus = -1;
             PatientRoleID = 0;
             lstBillingdetails = new List<BillingDetails>();
             needTaskDisplay = -1;
             taskID = -1;
             string IsSTAT = "N";
             try
             {
                 returnCode = new Patient_DAL(globalContextDetails).InsertPatientBillingFranchisee(pdetails, finalBill, ReferingPhysicianID, ReferingspecialityID, SpecialityID, lstDueChart, AgeValue, AgeUnit, pSpecialityID,
                                             ReferralType, Paymentstaus, pGuID, dtAmtReceived, lstOrderedInves, lstTaxDetails, out lstBillingdetails,
                                             out returnStatus, ExternelPatient, WardNo, EpisodeID, EpisodeVisitID, SiteID, VisitSampleStatus,
                                             EpisodeTrackID, SamplePickupDate, ConsignmentNo, lstControlSavedValues, IsEditMode, lstDispatchDetails,
                                             lstVisitClientMapping, out PatientRoleID, OnBehalfofClientID, TodayVisitID, externalVisitID, approvalNo, IsCopay, lstPatientDiscount, strMyCardActiveDays, strMemebershipcardType, strHealthCardType, strOTP, strStatus, strMembershipCardMappingID, strCreditRedeem, RedeemPatientid, RedeemVisitid, RedeemOrgId, RedemPoints,
                                             RedemValue, lstPatientRedemDetails, lstPkgandGrps, StatFlag, ClientFlag, CollectionID, EmailCC, VisitNumber, ClinicCode, value, visittemplate, lstPatlanguage, DueReason, DueAuthorizer,HealthHubId);

                 foreach (PatientDueChart Obj in lstDueChart)
                 {
                     if (Obj.IsSTAT == "Y")
                     {
                         IsSTAT = "Y";
                     }

                 }
                 if (returnStatus >= 0 && IsEditMode != "Y")
                 {

                     CollectSampleTaskCreator(finalBill.OrgID, LID, lstOrderedInves, lstBillingdetails[0].LabNo,
                     lstBillingdetails[0].BillNumber, lstBillingdetails[0].PatientID, lstBillingdetails[0].VisitID, pGuID, RoleID,
                     IsReceptionPhlebotomist, out needTaskDisplay, IsSamplePickUP, IsSTAT, out  taskID);

                     PageContextDetails.PatientID = lstBillingdetails[0].PatientID;
                     PageContextDetails.PatientVisitID = lstBillingdetails[0].VisitID;
                     PageContextDetails.FinalBillID = lstBillingdetails[0].FinalBillID;
                     PageContextDetails.BillNumber = lstBillingdetails[0].FinalBillID.ToString();
                     PageContextDetails.ID = LID;// Assign OrgAdressID
                     ActionManager objActionManager = new ActionManager(globalContextDetails);
                     // objActionManager.PerformingNextStep(PageContextDetails);
                     objActionManager.PerformingNextStepNotification(PageContextDetails, "", "");
                 }
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error in Billing DAL InsertPatientBilling Franchisee", ex);
             }

             return returnStatus;
         }

         public long GetPassportNo(string PassportNo, out List<URNTypes> lstURN)
         {
             long returnCode = -1;
             lstURN = new List<URNTypes>();
             DataSet ds = new DataSet();
             try
             {
                 Patient_DAL pDAL = new Patient_DAL(globalContextDetails);
                 returnCode = pDAL.GetPassportNo(PassportNo, out lstURN);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing GetPassportNo in Patient_BL", ex);
             }
             return returnCode;
         }
    }
}
