using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;
using Attune.Podium.PerformingNextAction;
using Attune.Podium.BusinessEntities.CustomEntities;

namespace Attune.Solution.BusinessComponent
{
    public class Investigation_BL
    {
        ContextDetails globalContextDetails;
        public Investigation_BL()
        {

        }
        public Investigation_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }


        public long SavePatientHistory(List<PatientHistory> lstPatientHistory, List<BackgroundProblem> lstBackground, List<PatientComplaint> lstPatientComplaint, List<PatientAdvice> lstAdvice, List<PatientExamination> lstPatientExamination, List<PatientPrescription> lstPrescription)
        {


            long lresult = -1;
            try
            {
                Investigation_DAL investigationdaL = new Investigation_DAL(globalContextDetails);
                lresult = investigationdaL.SavePatientHistory(lstPatientHistory, lstBackground, lstPatientComplaint, lstAdvice, lstPatientExamination, lstPrescription);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SavePatientHistory in Investigation_BL", excp);
            }
            return lresult;

        }

        public long SaveReFlexItemBilling(List<InvestigationQueue> InvQueue, long OrgID, out List<FinalBill> lstFinalBill, ContextDetails Context)
        {
            long retCode = -1;
            lstFinalBill = new List<FinalBill>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SaveReFlexItemBilling(InvQueue, OrgID, out lstFinalBill, Context);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveReFlexItemBilling in Investigation_BL", e);
            }
            return retCode;
        }
        public long GetPatientSex(long patientVisitID, out List<Patient> lstPatient)
        {
            long lresult = -1;
            lstPatient = new List<Patient>();
            try
            {

                Patient_DAL patientSex = new Patient_DAL(globalContextDetails);
                lresult = patientSex.GetPatientDemo(patientVisitID, out lstPatient);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientSex in Investigation_BL", ex);
            }
            return lresult;
        }
        public long GetPatientDueStatus(string PatientNumber, long PatientID, long PatientVisitID, long OrgId, long LocationID, long ClientID, out decimal DueAmount)
        {
            long returnCode = -1;
            DueAmount = -1;
            try
            {
                Investigation_DAL investigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = investigationDAL.GetPatientDueStatus(PatientNumber, PatientID, PatientVisitID, OrgId, LocationID, ClientID, out DueAmount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIntegrationVisitDetail in IntegrationBL", ex);
            }
            return returnCode;
        }

        public long getCaseSheetDetail(long patientVisitId, out List<PatientHistory> lstPatientHistory, out List<PatientExamination> lstPatientExamination, out List<PatientComplaint> lstPatientComplaint, out List<Patient> lstpatientDetail, out List<Advice> lstAdvice, out List<PatientPrescription> lstPatientPrescription, out List<PatientInvestigation> lstPatientInvestigation, out List<PatientComplaint> lstPhysicianComments)
        {
            long result = -1;
            lstPatientHistory = new List<PatientHistory>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstpatientDetail = new List<Patient>();
            lstAdvice = new List<Advice>();
            lstPatientPrescription = new List<PatientPrescription>();
            lstPatientInvestigation = new List<PatientInvestigation>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstPhysicianComments = new List<PatientComplaint>();

            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                result = InvestigationDAL.getCaseSheetDetails(patientVisitId, out lstPatientHistory, out lstPatientExamination, out lstPatientComplaint, out lstpatientDetail, out lstAdvice, out lstPatientPrescription, out lstPatientInvestigation, out lstPhysicianComments);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getCaseSheetDetail in Investigation_BL", ex);
            }
            return result;
        }

        public long getPrintPrescription(long patientVisitId, string pPrescriptionNo, out List<Patient> lstpatientDetail,
                                                              out List<Physician> lstPhysician,
                                                              out List<PatientPrescription> lstPatientPrescription)
        {
            long result = -1;

            lstpatientDetail = new List<Patient>();
            lstPhysician = new List<Physician>();
            lstPatientPrescription = new List<PatientPrescription>();

            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                result = InvestigationDAL.getPrintPrescription(patientVisitId, pPrescriptionNo, out lstpatientDetail, out lstPhysician, out lstPatientPrescription);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getPrintPrescription in Investigation_BL", ex);
            }
            return result;
        }


        public long GetInvestigationResults(long patientVisitId, out List<InvestigationValues> lstInvestigationValues, out List<InvestigationDisplayName> lstDispalyName, out List<PatientInvSampleResults> lstPatientInvSampleResults)
        {

            lstInvestigationValues = new List<InvestigationValues>();
            lstDispalyName = new List<InvestigationDisplayName>();
            lstPatientInvSampleResults = new List<PatientInvSampleResults>();
            long lresult = -1;
            try
            {
                Investigation_DAL investigationDAL = new Investigation_DAL(globalContextDetails);
                lresult = investigationDAL.GetInvestigationResults(patientVisitId, out lstInvestigationValues, out lstDispalyName, out lstPatientInvSampleResults);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationResults in Investigation_BL", ex);
            }

            return lresult;
        }

        public long getPendingInvestigation(long PatientId, out List<PendingInvestigation> lstPendingInvestigaion)
        {
            long lresult = -1;
            lstPendingInvestigaion = new List<PendingInvestigation>();
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                lresult = InvestigationDAL.getPendingInvestigation(PatientId, out lstPendingInvestigaion);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing getPendingInvestigation in Investigation_BL", excp);
            }
            return lresult;
        }


        //public long GetInvestigationFiles(long VisitID, out List<Investigation> lstInvestigation)
        //{
        //    lstInvestigation = new List<Investigation>();
        //    long result = -1;
        //    try
        //    {


        //        Investigation_DAL investigationFiles = new Investigation_DAL(globalContextDetails);
        //        result = investigationFiles.GetInvestigationFiles(VisitID, out lstInvestigation);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while executing GetInvestigationFiles BL", ex);
        //    }
        //    return result;
        //}

        //public long SavePatientInvestigationFiles(List<PatientInvestigationFiles> lstFiles)
        //{
        //    long returnCode = -1;
        //    try
        //    {

        //        Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
        //        returnCode = InvestigationDAL.SavePatientInvestigationFiles(lstFiles);
        //    }

        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while executing SavePatientInvestigation BL", ex);
        //    }

        //    return returnCode;
        //}


        //public long GetInvestigatonCapture(long VID, int OrgID, long RoleID, out List<PatientInvestigation> lstInvestigation, out List<InvestigationStatus> lstStatus)
        //{
        //    long result = -1;
        //    lstInvestigation = new List<PatientInvestigation>();
        //    lstStatus = new List<InvestigationStatus>();
        //    try
        //    {
        //        Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
        //        result = DemoDal.GetInvestigatonCapture(VID, OrgID, RoleID, out lstInvestigation, out lstStatus);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error wghile loading DemoInvestigation", ex);
        //    }
        //    return result;
        //}
        #region BatchWise EnterResult
        public long GetInvBulkData(string guid, long InvestigationID, long patientVisitID, int orgID, int GroupID, List<InvPackageMapping> lstInvPackageMapping,
                  out List<InvestigationValues> lstBulkData
             , out List<InvestigationValues> lstPendingValue, out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom)
        {
            long result = -1;
            lstBulkData = new List<InvestigationValues>();
            lstPendingValue = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetInvBulkData(guid, InvestigationID, patientVisitID, orgID, GroupID, lstInvPackageMapping, out lstBulkData, out lstPendingValue, out header, out  lstiom);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvBulkData in Investigation_BL", ex);
            }
            return result;
        }
        #endregion

        public long GetInvestigationSample(long VID, out List<PatientInvestigation> lstInvestigation)
        {
            long lresult = -1;
            lstInvestigation = new List<PatientInvestigation>();
            try
            {
                Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);
                lresult = IDAL.GetInvestigationSample(VID, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSample BL", ex);
            }
            return lresult;

        }

        public string PGetConfidentialvisit(long pVisit)
        {
            string lresult = string.Empty;

            try
            {
                Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);
                lresult = IDAL.PGetConfidentialvisit(pVisit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSample BL", ex);
            }
            return lresult;

        }

        public long UpdateSampleCollected(List<PatientInvestigation> lstPatient, int filter, out int count)
        {

            long lresult = -1;
            count = 0;
            try
            {
                Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);
                lresult = IDAL.UpdateSampleCollected(lstPatient, filter, out count);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateSampleCollected in Investigation_BL", ex);
            }
            return lresult;
        }


        public long GetLabInvestigation(int OrgAddID, int OrgID, long RoleID, int currentPageNo, int PageSize,
            out List<PatientVisitDetails> lstPatient, out int totalRows, long lngSourceId,
            LoginDetail LDetail)
        {
            long lresult = -1;
            totalRows = -1;
            lstPatient = new List<PatientVisitDetails>();

            try
            {
                Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);
                lresult = IDAL.GetLabInvestigation(OrgAddID, OrgID, RoleID, currentPageNo, PageSize, out lstPatient, out totalRows, lngSourceId, LDetail);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<PatientVisitDetails> lsttempDetails = new List<PatientVisitDetails>();
                lsttempDetails = lstPatient.FindAll(p => p.PatientStatus == "VIP");
                lstPatient.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    lresult = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (PatientVisitDetails)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    lresult = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (PatientVisitDetails)Maskedobj;
                    lstPatient.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetLabInvestigation in Investigation_BL", ex);
            }
            return lresult;
        }

        public long GetReferedInvestigation(long patientVisitID, out List<Patient> lstPatient, out List<PatientHistory> lstPatientHistory,
                                           out List<PatientExamination> lstPatientExamination, out List<PatientComplaint> lstPatientComplaint,
                                           out List<Investigation> lstInvestigation, out List<Physician> lstphysician)
        {
            lstPatient = new List<Patient>();
            lstPatientHistory = new List<PatientHistory>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstInvestigation = new List<Investigation>();
            lstphysician = new List<Physician>();
            long returnCode = -1;

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetReferedInvestigation(patientVisitID, out lstPatient, out lstPatientHistory,
                                                   out lstPatientExamination, out lstPatientComplaint,
                                                   out lstInvestigation, out lstphysician);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetReferedInvestigation in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetReferedInvCount(long patientVisitID, out int referedCount, out int orderedCount)
        {
            long returnCode = -1;
            referedCount = -1;
            orderedCount = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetReferedInvCount(patientVisitID, out referedCount, out orderedCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetReferedInvCount in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvesforApproval(int OrgID, out List<PatientVisitDetails> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<PatientVisitDetails>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetInvesforApproval(OrgID, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvesforApproval in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetInvforDept(int OrgID, out List<InvDeptMaster> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<InvDeptMaster>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetInvforDept(OrgID, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvforDept in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long pGetInvDeptData(int OrgID, int DeptID, out List<InvestigationOrgMapping> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<InvestigationOrgMapping>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pGetInvDeptData(OrgID, DeptID, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetInvDeptData in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long pGetGrpData(int OrgID, int GroupID, out List<InvOrgGroup> lstGrp)
        {
            long returnCode = -1;
            lstGrp = new List<InvOrgGroup>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pGetGrpData(OrgID, GroupID, out lstGrp);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetGrpData in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long pUpdateInvSequence(DataTable dt, int OrgID, int DeptID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pUpdateInvSequence(dt, OrgID, DeptID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pUpdateInvSequence in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long pUpdateGrpSequence(DataTable dt, int OrgID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pUpdateGrpSequence(dt, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pUpdateGrpSequence in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetinvestigationReport(string patientName, DateTime fromDate, DateTime toDate, int orgID, out List<PatientVisitDetails> lstPatientVisit)
        {

            long returncode = -1;
            lstPatientVisit = new List<PatientVisitDetails>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvestigationReport(patientName, fromDate, toDate, orgID, out lstPatientVisit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetinvestigationReport in Investigation_BL", ex);
            }
            return returncode;
        }

        public long GetComplaintInvestigation(int complaintID, int orgID, out List<InvestigationMaster> lstInvesMaster, out List<PatientInvestigation> lstPatientInvestigationHL)
        {

            long returncode = -1;
            lstInvesMaster = null;
            lstPatientInvestigationHL = null;
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetComplaintInvestigation(complaintID, orgID, out  lstInvesMaster, out lstPatientInvestigationHL);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetComplaintInvestigation in Investigation_BL", ex);
            }
            return returncode;
        }

        //Prasanna

        //public long GetInvestigationSamplesCollect(long PatientVisitID, int OrgID, out List<PatientInvestigation> lstPatientInvestigation, out List<InvSampleMaster> lstInvSampleMaster, out List<InvDeptMaster> lstInvDeptMaster)
        //{
        //    long returncode = -1;

        //    lstPatientInvestigation = new List<PatientInvestigation>();
        //    lstInvSampleMaster = new List<InvSampleMaster>();
        //    lstInvDeptMaster = new List<InvDeptMaster>();

        //    lstPatientInvestigation = null;
        //    lstInvSampleMaster = null;
        //    lstInvDeptMaster = null;

        //    try
        //    {
        //        returncode = new Investigation_DAL(globalContextDetails).GetInvestigationSamplesCollect(PatientVisitID, OrgID, out lstPatientInvestigation, out lstInvSampleMaster, out lstInvDeptMaster);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL pSelectInvestigationSamples", ex);
        //    }
        //    return returncode;
        //}

        //public long SavePatientInvSample(PatientInvSample EntityPatientInvSample, List<SampleTracker> lstSampleTracker, out int spIS)
        //{
        //    long returncode = -1;
        //    spIS = -1;
        //    try
        //    {
        //        Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);
        //        returncode = IDAL.SavePatientInvSamples(EntityPatientInvSample, lstSampleTracker, out spIS);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in SavePatientInvSample", ex);
        //    }

        //    return returncode;
        //}
        public long updatePatientInvestigationStatus(long PatientVisitID, string Status, int DeptID, string SampleStatus, out int upis)
        {
            long returncode = -1;
            upis = -1;
            try
            {
                Investigation_DAL idal = new Investigation_DAL(globalContextDetails);
                returncode = idal.updatePatientInvestigationStatus(PatientVisitID, Status, DeptID, SampleStatus, out upis);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing updatePatientInvestigationStatus in Investigation_BL", ex);
            }
            return returncode;
        }
        public long getSampleCollectionforDepartment(long RoleID, int OrgID, long PatientVisitID, int OrgAddressID, out List<PatientInvestigation> lstPatientInvestigation, out List<InvDeptMaster> lstDeptMaster, out List<PatientInvSample> lstPatientInvSample)
        {

            return new Investigation_DAL(globalContextDetails).getSampleCollectionforDepartment(RoleID, OrgID, PatientVisitID, OrgAddressID, out lstPatientInvestigation, out lstDeptMaster, out lstPatientInvSample);

        }

        public long GetTAID(long RoleID, int OrgID, out List<TaskActions> lstTaskActions)
        {
            return new Investigation_DAL(globalContextDetails).GetTAID(RoleID, OrgID, out lstTaskActions);
        }


        public long saveSampleCollectionFromDeptID(List<SampleTracker> lstSampleTracker)
        {
            long returncode = -1;

            try
            {
                Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);
                returncode = IDAL.InsertSampleCollectfromDeptID(lstSampleTracker);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing saveSampleCollectionFromDeptID in Investigation_BL", ex);
            }
            return returncode;

        }

        public long GetDepartmentID(long RoleID, out List<InvDeptMaster> lstInvDeptMaster)
        {
            long returncode = -1;
            lstInvDeptMaster = new List<InvDeptMaster>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).getDepartmentID(RoleID, out lstInvDeptMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDepartmentID in Investigation_BL", ex);
            }

            return returncode;
        }


        public long getInvOrgSampleStatus(int OrgID, string inStatus, out string outStatus)
        {
            long returncode = -1;
            outStatus = String.Empty;
            try
            {
                return new Investigation_DAL(globalContextDetails).getInvOrgSampleStatus(OrgID, inStatus, out outStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvOrgSampleStatus in Investigation_BL", ex);
            }

            return returncode;
        }

        // Prasanna End

        public long GetInvestigationProfile(int orgID, string type, out List<PatientInvestigation> lstInvestigationProfiile)
        {
            long returnCode = -1;
            lstInvestigationProfiile = new List<PatientInvestigation>();

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetInvestigationProfile(orgID, type, out lstInvestigationProfiile);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationProfile in Investigation_BL", ex);
            }
            return returnCode;
        }

        //public long GetInvestigationByDept(int deptID, int OrgID, out List<PatientInvestigation> lstInvestigation)
        //{
        //    long returnCode = -1;
        //    lstInvestigation = new List<PatientInvestigation>();
        //    try
        //    {
        //        returnCode = new Investigation_DAL(globalContextDetails).GetInvestigationByDept(deptID, OrgID, out lstInvestigation);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("", ex);
        //    }
        //    return returnCode;
        //}

        public long GetInvestigationByOrgID(int OrgID, string Filtertext, out List<PatientInvestigation> lstInvestigation)
        {
            long returnCode = -1;
            lstInvestigation = new List<PatientInvestigation>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetInvestigationByOrgID(OrgID, Filtertext, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationByOrgID in Investigation_BL", ex);
            }
            return returnCode;
        }


        public long SavePatientInvestigation(List<PatientInvestigation> PatientInvestigation, long OrgID, string gUID, out int pOrderedInvCnt)
        {
            long retCode = -1;
            int ret = -1;
            pOrderedInvCnt = 0;


            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SavePatientInvestigation(PatientInvestigation, OrgID, gUID, out pOrderedInvCnt);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SavePatientInvestigation in Investigation_BL", e);
            }
            return retCode;
        }



        public long GetInvestigationByClientID(int OrgID, int clientID, string type, out List<PatientInvestigation> lstPatInv)
        {

            lstPatInv = new List<PatientInvestigation>();
            long returnCode = -1;

            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetInvestigationByClientID(OrgID, clientID, type, out lstPatInv);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationByClientID in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetSurgeryByClientID(long lVisitID, int OrgID, int clientID, string type, out List<PatientInvestigation> lstPatInv)
        {

            lstPatInv = new List<PatientInvestigation>();
            long returnCode = -1;

            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetSurgeryByClientID(lVisitID, OrgID, clientID, type, out lstPatInv);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSurgeryByClientID in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvestigation(int OrgID, out List<PatientInvestigation> lstInvestigation)
        {
            long returnCode = -1;
            lstInvestigation = new List<PatientInvestigation>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetInvestigation(OrgID, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigation in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvestigationData(int OrgID, int orgSpecific, out List<InvGroupMaster> lstGroups, out List<InvestigationMaster> lstInvestigation)
        {
            lstInvestigation = null;
            lstGroups = new List<InvGroupMaster>();
            long returnCode = -1;
            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetInvestigationData(OrgID, orgSpecific, out lstGroups, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationData in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvestigationDatabyComplaint(int OrgID, int orgSpecific, int ComplaintID, int ClientID, out List<InvGroupMaster> lstGroups, out List<InvestigationMaster> lstInvestigation)
        {
            lstInvestigation = null;
            lstGroups = new List<InvGroupMaster>();
            long returnCode = -1;
            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetInvestigationDatabyComplaint(OrgID, orgSpecific, ComplaintID, ClientID, out lstGroups, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationDatabyComplaint in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetOrderedInvestigation(int pOrgID, long patientVisitID, out List<OrderedInvestigations> lstOrderedInves, out List<OrderedInvestigations> oInvestigations)
        {
            long returnCode = -1;
            lstOrderedInves = new List<OrderedInvestigations>();
            oInvestigations = new List<OrderedInvestigations>();

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetOrderedInvestigation(pOrgID, patientVisitID, out lstOrderedInves, out oInvestigations);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrderedInvestigation in Investigation_BL", ex);

            }
            return returnCode;
        }

        public long getOrgClientID(long PatientVisitID, out long outStatus)
        {
            long returncode = -1;
            outStatus = 0;
            try
            {
                return new Investigation_DAL(globalContextDetails).getOrgClientID(PatientVisitID, out outStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvOrgSampleStatus in Investigation_BL", ex);
            }

            return returncode;
        }

        public long getOrgClientName(int orgID, out List<InvClientMaster> lstClientname)
        {
            long returnCode = -1;
            lstClientname = new List<InvClientMaster>();

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).getOrgClientName(orgID, out lstClientname);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getOrgClientName in Investigation_BL", ex);

            }
            return returnCode;
        }

        public long getOrgTPAName(int orgID, out List<TPAMaster> lstTPAname)
        {
            long returnCode = -1;
            lstTPAname = new List<TPAMaster>();

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).getOrgTPAName(orgID, out lstTPAname);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getOrgTPAName in Investigation_BL", ex);

            }
            return returnCode;
        }


        public long SaveNewInvestigation(int pGroupID, string PInvestigationID)
        {
            long returnCode = -1;
            Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
            try
            {
                returnCode = InvDAL.SaveNewInvestigation(pGroupID, PInvestigationID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveNewInvestigation in Investigation_BL", excp);
            }
            return returnCode;
        }



        public long getOrgDepartName(int orgID, out List<InvDeptMaster> lstDepname)
        {
            long returnCode = -1;
            lstDepname = new List<InvDeptMaster>();

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).getOrgDepartName(orgID, out lstDepname);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getOrgDepartName in Investigation_BL", ex);

            }
            return returnCode;
        }

        //public long getOrgDepartHeadName(int orgID, out List<InvDeptMaster> lstDepname, out List<InvestigationHeader> lstHeader)
        //{
        //    long returnCode = -1;
        //    lstDepname = new List<InvDeptMaster>();
        //    lstHeader = new List<InvestigationHeader>();

        //    try
        //    {
        //        returnCode = new Investigation_DAL(globalContextDetails).getOrgDepartHeadName(orgID, out lstDepname, out lstHeader);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while investigation BL Department Name", ex);

        //    }
        //    return returnCode;
        //}



        public long getOrgHeaderName(out List<InvestigationHeader> lstHeader)
        {
            long returnCode = -1;
            lstHeader = new List<InvestigationHeader>();

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).getOrgHeaderName(out lstHeader);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getOrgHeaderName in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long getInvGroupName(int orgID, out List<InvGroupMaster> lstHeader)
        {
            long returnCode = -1;
            lstHeader = new List<InvGroupMaster>();

            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.getInvGroupName(orgID, out lstHeader);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvGroupName in Investigation_BL", ex);

            }
            return returnCode;
        }

        public long GetInvForMDMAddInvAndGrp(int OrgID, string pType, out List<InvestigationMaster> lstInvNames)
        {
            long returnCode = -1;
            lstInvNames = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetInvForMDMAddInvAndGrp(OrgID, pType, out lstInvNames);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvForMDMAddInvAndGrp in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetInvForMDMAddInvAndNewGrp(int OrgID, string pType, out List<OrderedInvestigations> lstInvNames)
        {
            long returnCode = -1;
            lstInvNames = new List<OrderedInvestigations>();
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetInvForMDMAddInvAndNewGrp(OrgID, pType, out lstInvNames);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvForMDMAddInvAndNewGrp in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetInvForMDMAddGrp(int OrgID, string pType, out List<InvGroupMaster> lstInvNames, out List<OrderedInvestigations> grovalid)
        {
            long returnCode = -1;
            lstInvNames = new List<InvGroupMaster>();
            grovalid = new List<OrderedInvestigations>();
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetInvForMDMAddGrp(OrgID, pType, out lstInvNames, out grovalid);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvForMDMAddGrp in Investigation_BL", ex);
            }

            return returnCode;

        }


        public long GetInvForMDMAddInv(int OrgID, string pType, out List<InvestigationOrgMapping> lstInvNames)
        {
            long returnCode = -1;
            lstInvNames = new List<InvestigationOrgMapping>();
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetInvForMDMAddInv(OrgID, pType, out lstInvNames);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvForMDMAddInv in Investigation_BL", ex);
            }

            return returnCode;

        }
        public long GetInvForMDLoadInvInGrp(long OrgID, int GrpID, out List<InvestigationMaster> lstInvNames)
        {
            long returnCode = -1;
            lstInvNames = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetInvForMDLoadInvInGrp(OrgID, GrpID, out lstInvNames);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvForMDLoadInvInGrp in Investigation_BL", ex);
            }

            return returnCode;

        }
        public long GetInvForMDLoadInvInNewGrp(long OrgID, int GrpID, out List<OrderedInvestigations> lstInvNames)
        {
            long returnCode = -1;
            lstInvNames = new List<OrderedInvestigations>();
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetInvForMDLoadInvInNewGrp(OrgID, GrpID, out lstInvNames);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvForMDLoadInvInNewGrp in Investigation_BL", ex);
            }
            return returnCode;
        }
        //public long GetInvForMDLoadInvGrpMAP(int OrgID, int GrpID, out List<OrderedInvestigations> lstInvNames, out string groupname)
        //{
        //    long returnCode = -1;
        //    lstInvNames = new List<OrderedInvestigations>();
        //    groupname = String.Empty;
        //    try
        //    {
        //        Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
        //        returnCode = InvDAL.GetInvForMDLoadInvGrpMAP(OrgID, GrpID, out lstInvNames, out groupname);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while loading GetInvestigationName BL", ex);
        //    }
        //    return returnCode;
        //}

        public long GetInvForMDMAddInvAndGrp(int OrgID, out List<InvestigationMaster> lstInvNames)
        {
            long returnCode = -1;
            lstInvNames = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetInvForMDMAddInvAndGrp(OrgID, out lstInvNames);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvForMDMAddInvAndGrp-InvestigationMaster in Investigation_BL", ex);
            }

            return returnCode;

        }

        public long GetDeleteMDMInv(int OrgID, string InvID)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetDeleteMDMInv(OrgID, InvID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeleteMDMInv in Investigation_BL", ex);
            }

            return returnCode;

        }


        public long GetDeleteShowInv(int GroupID, string InvID)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetDeleteShowInv(GroupID, InvID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeleteShowInv in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetGrpInvList(string GrpName, int OrgID, int Filter, out List<InvGroupMaster> lstInvGroupMaster)
        {
            long returnCode = -1;
            lstInvGroupMaster = new List<InvGroupMaster>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.GetGrpInvList(GrpName, OrgID, Filter, out lstInvGroupMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetGrpInvList in Investigation_BL", ex);
            }

            return returnCode;
        }



        public long SaveInvestigationGrpName(List<InvestigationOrgMapping> pInvMap, string groupName, string billingName, int dptID, long gHeader, int DdlCase, string type, long OrgID, string ModifiedBy, string GroupCode, string Remarks, string status, string Pkgcode, string printSeparately, DataTable dtCodingSchemeMaster, int CutOffTimeValue, string CutOffTimeType, string Gender, string IsServiceTaxable, short ScheduleType, bool ISpkgtransfer)
        {
            long returnCode = -1;
            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

            try
            {
                returnCode = invDAL.SaveInvestigationGrpName(pInvMap, groupName, billingName, dptID, gHeader, DdlCase, type, OrgID, ModifiedBy, GroupCode, Remarks, status, Pkgcode, printSeparately, dtCodingSchemeMaster, CutOffTimeValue, CutOffTimeType, Gender, IsServiceTaxable, ScheduleType, ISpkgtransfer);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvestigationGrpName in Investigation_BL", excp);
            }
            return returnCode;
        }




        public long SaveInvestigationName(List<InvestigationOrgMapping> pInvMap)
        {
            long returnCode = -1;
            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
            //DataTable DtInvGp = GetInvDataTable(pInvMap);

            try
            {
                returnCode = invDAL.SaveInvestigationName(pInvMap);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvestigationName in Investigation_BL", excp);
            }
            return returnCode;
        }
        //public long DeleteInvestigationName(List<InvestigationOrgMapping> pInvMap)
        //{
        //    long returnCode = -1;
        //    Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
        //    DataTable DtInvGp = DeleteInvDataTable(pInvMap);
        //    try
        //    {
        //        returnCode = invDAL.DeleteInvestigationName(DtInvGp);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing SaveInvestigationRate BL", excp);
        //    }
        //    return returnCode;
        //}

        public long GetIndInvList(string IndName, int OrgID, int Filter, out List<InvestigationMaster> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.GetIndInvList(IndName, OrgID, Filter, out lstInvestigationMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIndInvList-withFilter in Investigation_BL", ex);
            }

            return returnCode;
        }
        //public long GetInvList(int OrgID,  out List<InvestigationMaster> lstInvestigationMaster)
        //{
        //    long returnCode = -1;
        //    lstInvestigationMaster = new List<InvestigationMaster>();
        //    try
        //    {
        //        Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
        //        returnCode = invDAL.GetInvList(OrgID, out lstInvestigationMaster);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL pGetIndInvList", ex);
        //    }

        //    return returnCode;
        //}


        public long SearchInvForMDMAddInvAndGrp(string invName, int OrgID, string pType, string GroupCode, out List<InvestigationMaster> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.SearchInvForMDMAddInvAndGrp(invName, OrgID, pType, GroupCode, out lstInvestigationMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvAndGrp in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long SearchInvForMDMAddInvAndNewGrp(string invName, int OrgID, string pType, string GroupCode, out List<OrderedInvestigations> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<OrderedInvestigations>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.SearchInvForMDMAddInvAndNewGrp(invName, OrgID, pType, GroupCode, out lstInvestigationMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvAndNewGrp in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long SearchInvForMDMAddInvAndINGrp(string invName, int OrgID, string pGrp, out List<OrderedInvestigations> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<OrderedInvestigations>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.SearchInvForMDMAddInvAndINGrp(invName, OrgID, pGrp, out lstInvestigationMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvAndINGrp in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long SearchInvForMDMAddGrp(string invName, int OrgID, string pType, string GroupCode, out List<InvGroupMaster> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvGroupMaster>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.SearchInvForMDMAddGrp(invName, OrgID, pType, GroupCode, out lstInvestigationMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddGrp in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long SearchInvForMDMAddInvMapping(string invName, int OrgID, string pType, string GroupCode, out List<InvestigationOrgMapping> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvestigationOrgMapping>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.SearchInvForMDMAddInvMapping(invName, OrgID, pType, GroupCode, out lstInvestigationMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvMapping in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long SearchInvGrpName(string invName, int OrgID, string Type, out List<InvGroupMaster> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvGroupMaster>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.SearchInvGrpName(invName, OrgID, Type, out lstInvestigationMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvGrpName in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long SearchInvForMDMAddInvAndGrp(string invName, int OrgID, string pType, string GroupCode, out List<InvestigationOrgMapping> lstInv)
        {
            long returnCode = -1;
            lstInv = new List<InvestigationOrgMapping>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.SearchInvForMDMAddInvAndGrp(invName, OrgID, pType, GroupCode, out lstInv);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvAndGrp in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetInvRefRangeForMDM(int OrgID, long StartIndex, long EndIndex, out List<InvestigationOrgMapping> lstIOM, out List<InvSampleMaster> lstInvSampleMaster, out List<InvestigationMethod> lstInvMethod, out List<InvPrincipleMaster> lstInvPrinciple, out List<InvKitMaster> lstInvKit, out List<InvInstrumentMaster> lstInvInstrument,
            out List<InvestigationSampleContainer> lstSampleContainer, out List<OrganizationAddress> lstOrganizationAddress, out long TotalCount, out List<OrganizationAddress> lstProcessingCentre)
        {
            long returnCode = -1;
            TotalCount = -1;
            lstIOM = new List<InvestigationOrgMapping>();
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstInvMethod = new List<InvestigationMethod>();
            lstInvPrinciple = new List<InvPrincipleMaster>();
            lstInvKit = new List<InvKitMaster>();
            lstInvInstrument = new List<InvInstrumentMaster>();
            lstSampleContainer = new List<InvestigationSampleContainer>();
            lstOrganizationAddress = new List<OrganizationAddress>();
            lstProcessingCentre = new List<OrganizationAddress>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.GetInvRefRangeForMDM(OrgID, StartIndex, EndIndex, out lstIOM, out lstInvSampleMaster, out lstInvMethod, out lstInvPrinciple, out lstInvKit, out lstInvInstrument, out lstSampleContainer, out lstOrganizationAddress, out TotalCount, out lstProcessingCentre);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvRefRangeForMDM in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetGrpRefRangeForMDM(int OrgID, long StartIndex, long EndIndex, out List<InvGroupMaster> lstIOM, out long TotalCount)
        {
            long returnCode = -1;
            TotalCount = -1;
            lstIOM = new List<InvGroupMaster>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.GetGrpRefRangeForMDM(OrgID, StartIndex, EndIndex, out lstIOM, out TotalCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetGrpRefRangeForMDM in Investigation_BL", ex);
            }
            return returnCode;
        }



        public long GetInvGroupLt(int OrgGroupID, out List<InvestigationMaster> lstIOM)
        {
            long returnCode = -1;

            lstIOM = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.GetInvGroupLt(OrgGroupID, out lstIOM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvGroupLt in Investigation_BL", ex);
            }

            return returnCode;

        }

        public long GetAddNewINVGroup(int OrgID, int GroupID, out List<InvestigationOrgMapping> lstIOM)
        {
            long returnCode = -1;

            lstIOM = new List<InvestigationOrgMapping>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.GetAddNewINVGroup(OrgID, GroupID, out lstIOM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAddNewINVGroup in Investigation_BL", ex);
            }

            return returnCode;

        }



        //public long GetPatientInvSample(long pVisitId, out List<PatientInvSample> lstPatientInvSample, out List<SampleAttributes> lstSampleAttributes)
        //{
        //    long returnCode = -1;

        //    lstPatientInvSample = new List<PatientInvSample>();
        //    lstSampleAttributes = new List<SampleAttributes>();
        //    try
        //    {
        //        returnCode = new Investigation_DAL(globalContextDetails).GetPatientInvSample(pVisitId, out lstPatientInvSample, out lstSampleAttributes);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL GetPatientInvSample", ex);
        //    }

        //    return returnCode;
        //}

        //public long SavePInvSampleResults(List<PatientInvSampleResults> lstPatientInvSampleResults)
        //{
        //    long returncode = -1;

        //    try
        //    {
        //        returncode = new Investigation_DAL(globalContextDetails).SavePInvSampleResults(lstPatientInvSampleResults);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL InsertPInvSampleResults", ex);
        //    }
        //    return returncode;

        //}

        public long pCheckInvValuesbyVID(long pVid, out int pCount, out string pPatientNumber, out List<OrderedInvestigations> lstOrderderd)
        {
            long returncode = -1;
            pCount = 0;
            lstOrderderd = new List<OrderedInvestigations>();
            pPatientNumber = "0";
            try
            {
                return new Investigation_DAL(globalContextDetails).pCheckInvValuesbyVID(pVid, out pCount, out pPatientNumber, out lstOrderderd);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvOrgSampleStatus in Investigation_BL", ex);
            }
            return returncode;
        }

        public long InsertIPInvestigation(IpInvSampleCollectionMaster entIPInvSCMaster, int pOrgId, List<PatientInvSample> lstPatientInvSample, List<PatientInvestigation> lstPatientInvestigation)//, out int ret)
        {
            long returnCode = -1;
            //ret = -1;
            //entIPInvSCMaster = new IpInvSampleCollectionMaster();
            //lstPatientInvestigation = new List<PatientInvestigation>();
            //lstPatientInvSample = new List<PatientInvSample>();

            returnCode = new Investigation_DAL(globalContextDetails).InsertIPInvestigation(entIPInvSCMaster, pOrgId, lstPatientInvSample, lstPatientInvestigation);//, out ret);

            return returnCode;
        }

        public long GetIPPatientForInvestigation(long pVisitID, int OrgID, out List<IpInvSampleCollectionMaster> ipSampleMaster)
        {
            long returnCode = -1;
            ipSampleMaster = new List<IpInvSampleCollectionMaster>();
            try
            {
                new Investigation_DAL(globalContextDetails).GetIPPatientForInvestigation(pVisitID, OrgID, out ipSampleMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPPatientForInvestigation in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetIPInvestigatonCapture(long VID, int OrgID, long RoleID, long pSCMID, out List<PatientInvestigation> lstInvestigation, out List<InvestigationStatus> lstStatus)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetIPInvestigatonCapture(VID, OrgID, RoleID, pSCMID, out lstInvestigation, out lstStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPInvestigatonCapture in Investigation_BL", ex);
            }
            return result;
        }
        public long CheckIPInvCompleted(long pPatientVisitID, long pSCMID, out int pCount)
        {
            long returnCode = -1;

            pCount = 0;
            try
            {
                return new Investigation_DAL(globalContextDetails).CheckIPInvCompleted(pPatientVisitID, pSCMID, out pCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CheckIPInvCompleted in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long SaveClientMaster(InvClientMaster InvClientMaster, string sClientTypeName, int RateTypeID, int RateID)
        {
            long lresult = -1;
            try
            {
                Investigation_DAL objInvestigation_DAL = new Investigation_DAL(globalContextDetails);
                lresult = objInvestigation_DAL.SaveClientMaster(InvClientMaster, sClientTypeName, RateTypeID, RateID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveClientMaster in Investigation_BL", ex);
            }
            return lresult;
        }
        public long SaveTPAMaster(TPAMaster InvTPAMaster)
        {
            long lresult = -1;
            try
            {
                Investigation_DAL objInvestigation_DAL = new Investigation_DAL(globalContextDetails);
                lresult = objInvestigation_DAL.SaveTPAMaster(InvTPAMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveTPAMaster in Investigation_BL", ex);
            }
            return lresult;
        }

        public long UpdateTPAMaster(TPAMaster InvTPAMaster)
        {
            long lresult = -1;
            try
            {
                Investigation_DAL objInvestigation_DAL = new Investigation_DAL(globalContextDetails);
                lresult = objInvestigation_DAL.UpdateTPAMaster(InvTPAMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateTPAMaster in Investigation_BL", ex);
            }
            return lresult;
        }
        public long GetClientInvestigationData(int OrgID, int orgSpecific,
                                                out List<InvGroupMaster> lstGroups,
                                                out List<InvestigationMaster> lstInvestigation,
                                                int pVisitID)
        {
            lstInvestigation = null;
            lstGroups = new List<InvGroupMaster>();
            long returnCode = -1;
            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetClientInvestigationData(OrgID, orgSpecific, out lstGroups, out lstInvestigation, pVisitID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetClientInvestigationData in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long SaveInPatientInvestigation(List<PatientInvestigation> PatientInvestigation, long OrgID, out int pOrderedInvCnt)
        {
            long retCode = -1;
            //int ret = -1;
            pOrderedInvCnt = 0;


            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SaveInPatientInvestigation(PatientInvestigation, OrgID, out pOrderedInvCnt);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveInPatientInvestigation in Investigation_BL", e);
            }
            return retCode;
        }


        public long GetAllInvestigationWithRate(int OrgID, int clientID, string type, long visitID, out List<PatientInvestigation> lstPatInv)
        {

            lstPatInv = new List<PatientInvestigation>();
            long returnCode = -1;

            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetAllInvestigationWithRate(OrgID, clientID, type, visitID, out lstPatInv);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllInvestigationWithRate in Investigation_BL", ex);
            }
            return returnCode;
        }


        public long SaveIPInvestigation(List<PatientInvestigation> PatientInvestigation, long OrgID, out int pOrderedInvCnt)
        {
            long retCode = -1;
            //int ret = -1;
            pOrderedInvCnt = 0;


            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SaveIPInvestigation(PatientInvestigation, OrgID, out pOrderedInvCnt);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveIPInvestigation in Investigation_BL", e);
            }
            return retCode;
        }
        public long GetUOMCode(out List<UOM> lstUOM)
        {
            long returnCode = -1;
            lstUOM = new List<UOM>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetUOMCode(out lstUOM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetUOMCode in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long DeleteClientCorporate(long OrgID, long ClientID, string sClientTypeName, out string Uavailable)
        {
            long retCode = -1;
            //int ret = -1;
            Uavailable = string.Empty;
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.DeleteClientCorporate(OrgID, ClientID, sClientTypeName, out Uavailable);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing DeleteClientCorporate in Investigation_BL", e);
            }
            return retCode;
        }
        public long SaveOrderedInvestigationHOS(List<OrderedInvestigations> OrderedInves, long OrgID, out int pOrderedInvCnt, string paymentstatus, string UID, string labno)
        {
            long retCode = -1;
            pOrderedInvCnt = -1;
            // DataTable invs = GetOrdInvDataTable(OrderedInves);
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SaveOrderedInvestigationHOS(OrderedInves, OrgID, out pOrderedInvCnt, paymentstatus, UID, labno);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveOrderedInvestigationHOS in Investigation_BL", e);
            }
            return retCode;
        }


        public long UpdateOrderedInvSampleCollected(List<OrderedInvestigations> lstOrderedInv, int filter, out int count)
        {
            long lresult = -1;
            count = -1;
            try
            {

                lresult = new Investigation_DAL(globalContextDetails).UpdateOrderedInvSampleCollected(lstOrderedInv, filter, out count);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateOrderedInvSampleCollected in Investigation_BL", ex);
            }
            return lresult;
        }
        public long getSampleCollectionforDepartment(long RoleID, int OrgID, long PatientVisitID, int OrgAddressID, out List<PatientInvestigation> lstPatientInvestigation, out List<InvDeptMaster> lstDeptMaster, out List<PatientInvSample> lstPatientInvSample, out List<CollectedSample> lstCollectedSample, out List<InvDeptMaster> deptList)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            lstDeptMaster = new List<InvDeptMaster>();
            lstPatientInvSample = new List<PatientInvSample>();
            lstCollectedSample = new List<CollectedSample>();
            deptList = new List<InvDeptMaster>();
            try
            {
                return new Investigation_DAL(globalContextDetails).getSampleCollectionforDepartment(RoleID, OrgID, PatientVisitID, OrgAddressID, out lstPatientInvestigation, out lstDeptMaster, out lstPatientInvSample, out lstCollectedSample, out deptList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getSampleCollectionforDepartment in Investigation_BL", ex);
            }

            return returnCode;
        }


        public long GetBulkInvestigationSamplesCollect(string patientno, string orgcode, string LocCode, string userId, out List<PatientInvestigation> lstPatientInvestigation,
                                                    out List<InvSampleMaster> lstInvSampleMaster, out List<InvDeptMaster> lstInvDeptMaster,
                                                    out List<RoleDeptMap> lstDept, out List<CollectedSample> lstSamples, out List<InvDeptMaster> deptList, out List<InvestigationSampleContainer> lstSampleContainer)
        {
            long returncode = -1;

            lstPatientInvestigation = new List<PatientInvestigation>();
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstInvDeptMaster = new List<InvDeptMaster>();
            lstDept = new List<RoleDeptMap>();
            lstSamples = new List<CollectedSample>();
            deptList = new List<InvDeptMaster>();
            lstPatientInvestigation = null;
            lstInvSampleMaster = null;
            lstInvDeptMaster = null;
            lstSampleContainer = new List<InvestigationSampleContainer>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetBulkInvestigationSamplesCollect(patientno, orgcode, LocCode, userId, out lstPatientInvestigation, out lstInvSampleMaster, out lstInvDeptMaster, out lstDept, out lstSamples, out deptList, out lstSampleContainer);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSamplesCollect in Investigation_BL", ex);
            }
            return returncode;
        }

        public long GetInvestigationSamplesCollect(long PatientVisitID, int OrgID, long roleID, string gUID, int LocationID, int taskactionID, out List<PatientInvestigation> lstPatientInvestigation,
                                                    out List<InvSampleMaster> lstInvSampleMaster, out List<InvDeptMaster> lstInvDeptMaster,
                                                    out List<RoleDeptMap> lstDept, out List<CollectedSample> lstSamples, out List<InvDeptMaster> deptList, out List<InvestigationSampleContainer> lstSampleContainer)
        {
            long returncode = -1;

            lstPatientInvestigation = new List<PatientInvestigation>();
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstInvDeptMaster = new List<InvDeptMaster>();
            lstDept = new List<RoleDeptMap>();
            lstSamples = new List<CollectedSample>();
            deptList = new List<InvDeptMaster>();
            lstPatientInvestigation = null;
            lstInvSampleMaster = null;
            lstInvDeptMaster = null;
            lstSampleContainer = new List<InvestigationSampleContainer>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvestigationSamplesCollect(PatientVisitID, OrgID, roleID, gUID, LocationID, taskactionID, out lstPatientInvestigation, out lstInvSampleMaster, out lstInvDeptMaster, out lstDept, out lstSamples, out deptList, out lstSampleContainer);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSamplesCollect in Investigation_BL", ex);
            }
            return returncode;
        }


        public long SavePatientInvSample(List<PatientInvSample> PatientInvSample,
           List<SampleTracker> lstSampleTracker,
           List<InvDeptSamples> deptSamples, List<PatientInvSampleMapping> lstPatientInvSampleMapping, List<PatientInvestigation> lstPatientInvestigation,
           List<InvestigationValues> lInvestigation, string gUID,
           out int spIS, out string lstSampleId)
        {
            long returncode = -1;
            spIS = -1;
            lstSampleId = string.Empty;
            try
            {

                //Utilities.ConvertFrom(PatientInvSample, out dtPatSample);
                //dtPatSample = GetDataTable(PatientInvSample);
                //Utilities.ConvertFrom(deptSamples, out dtinvSample);
                Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);

                returncode = IDAL.SavePatientInvSamples(PatientInvSample, lstSampleTracker,
                    deptSamples, lstPatientInvSampleMapping, lstPatientInvestigation, lInvestigation, gUID, out spIS, out lstSampleId);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SavePatientInvSample in Investigation_BL", ex);
            }

            return returncode;
        }

        public long InsertBulkPatientInvSample(List<PatientInvSample> PatientInvSample,
           List<SampleTracker> lstSampleTracker,
           List<InvDeptSamples> deptSamples, List<PatientInvSampleMapping> lstPatientInvSampleMapping, List<PatientInvestigation> lstPatientInvestigation,
           List<InvestigationValues> lInvestigation,
           out int spIS, out string lstSampleId)
        {
            long returncode = -1;
            spIS = -1;
            lstSampleId = string.Empty;
            try
            {

                //Utilities.ConvertFrom(PatientInvSample, out dtPatSample);
                //dtPatSample = GetDataTable(PatientInvSample);
                //Utilities.ConvertFrom(deptSamples, out dtinvSample);
                Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);

                returncode = IDAL.InsertBulkPatientInvSample(PatientInvSample, lstSampleTracker,
                    deptSamples, lstPatientInvSampleMapping, lstPatientInvestigation, lInvestigation, out spIS, out lstSampleId);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SavePatientInvSample in Investigation_BL", ex);
            }

            return returncode;
        }


        public long GetDeptToTrackSamples(long PatientVisitID, int OrgID, long roleID, string gUID, out List<PatientInvestigation> lstSampleDept, out List<PatientInvSample> lstPatientInvSample)
        {
            long returncode = -1;
            lstSampleDept = new List<PatientInvestigation>();
            lstPatientInvSample = new List<PatientInvSample>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetDeptToTrackSamples(PatientVisitID, OrgID, roleID, gUID, out lstSampleDept, out lstPatientInvSample);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeptToTrackSamples in Investigation_BL", ex);
            }
            return returncode;
        }
        public long UpdateOrderedInvestigationStatusinLab(List<InvestigationValues> lInvestigation, long PatientVisitID, string Status, int DeptID, string SampleStatus, string gUID, out int upis)
        {
            long returncode = -1;
            upis = -1;
            try
            {


                Investigation_DAL idal = new Investigation_DAL(globalContextDetails);
                returncode = idal.UpdateOrderedInvestigationStatusinLab(lInvestigation, PatientVisitID, Status, DeptID, SampleStatus, gUID, out upis);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateOrderedInvestigationStatusinLab in Investigation_BL", ex);
            }
            return returncode;
        }
        public long UpdateOrderedInvestigationStatusinLabBulk(List<PatientInvestigation> lstpatinv)
        {
            long returncode = -1;
            //upis = -1;
            try
            {


                Investigation_DAL idal = new Investigation_DAL(globalContextDetails);
                returncode = idal.UpdateOrderedInvestigationStatusinLabBulk(lstpatinv);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateOrderedInvestigationStatusinLabBulk in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetInvestigatonCapture(long VID, int OrgID, long RoleID, out List<OrderedInvestigations> lstInvestigation, out List<InvestigationStatus> lstStatus)
        {
            long result = -1;
            lstInvestigation = new List<OrderedInvestigations>();
            lstStatus = new List<InvestigationStatus>();
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetInvestigatonCapture(VID, OrgID, RoleID, out lstInvestigation, out lstStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigatonCapture in Investigation_BL", ex);
            }
            return result;
        }
        public long GetInvestigationForBillVisit(long visitID, long FinalBillID, int orgID, int LocationID,
            out List<OrderedInvestigations> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<OrderedInvestigations>();
            LoginDetail objLoginDetail = new LoginDetail();
            try
            {
                new Investigation_DAL(globalContextDetails).GetInvestigationForBillVisit(visitID, FinalBillID, orgID, LocationID, objLoginDetail, out lstPatientInvestigation);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationForBillVisit in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvestigationForVisit(long visitID, int orgID, int LocationID,
            out List<OrderedInvestigations> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<OrderedInvestigations>();
            LoginDetail objLoginDetail = new LoginDetail();
            try
            {
                new Investigation_DAL(globalContextDetails).GetInvestigationForVisit(visitID, orgID, LocationID, objLoginDetail, out lstPatientInvestigation);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationForVisit in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetInvestigationForVisit(long visitID, int orgID, int LocationID,
            LoginDetail LDetail, out List<OrderedInvestigations> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<OrderedInvestigations>();
            //DataTable DtLDetail = GetLoginDetailDataTable(LDetail);
            try
            {
                new Investigation_DAL(globalContextDetails).GetInvestigationForVisit(visitID, orgID, LocationID, LDetail, out lstPatientInvestigation);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationForVisit-LoginDetails in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetTaskPickedByDetails(long pPatientVisitID, long pLID,
             out long AssignedTo)
        {
            long returnCode = -1;
            AssignedTo = -1;
            //DataTable DtLDetail = GetLoginDetailDataTable(LDetail);
            try
            {
                new Investigation_DAL(globalContextDetails).GetTaskPickedByDetails(pPatientVisitID, pLID, out AssignedTo);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetTaskPickedByDetails in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long SaveInvestigationResults(long pSCMID, List<List<InvestigationValues>> lstInvestigationValues, List<PatientInvestigation> lstInvestigation, List<PatientInvSampleResults> lstPatientInvSampleResults, List<PatientInvSampleMapping> lstPatientInvSampleMapping, List<PatientInvestigationFiles> lPfiles, long vid, int OrgID, int deptID, long ApprovadBy, string gUID, PageContextkey PageContextDetails, out int returnStatus, List<PatientInvestigation> lstReflexPatientinvestigation,string isFromDevice,List<PatientInvestigationAttributes> lstPatAttr)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {

                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.SaveInvestigationResults(pSCMID, lstInvestigationValues, lstInvestigation, lstPatientInvSampleResults, lstPatientInvSampleMapping, lPfiles, vid, OrgID, deptID, ApprovadBy, gUID, out returnStatus, lstReflexPatientinvestigation, isFromDevice, lstPatAttr);
                if (returnStatus >= 0)
                {
                    //List<PatientInvestigation> lstNonApprovedInvestigation = lstInvestigation.FindAll(P => P.Status != InvStatus.Approved);
                    //if (lstNonApprovedInvestigation != null && lstNonApprovedInvestigation.Count == 0)
                    //{
                    //    ActionManager objActionManager = new ActionManager();
                    //    objActionManager.PerformingNextStep(PageContextDetails);
                    //}
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvestigationResults in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long GetInvestigationValues(long vid, int OrgID, string Guid, out List<InvestigationValues> lstInvestigationValues)
        {
            long result = -1;
            lstInvestigationValues = new List<InvestigationValues>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetInvestigationValues(vid, OrgID, Guid, out lstInvestigationValues);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationValues in Investigation_BL", e);
            }
            return result;
        }
        public long GetInvestigationResultTemplate(int OrgID, string TemplateType, long DeptID, out List<InvResultTemplate> lstInvResultTemplate)
        {
            long result = -1;
            lstInvResultTemplate = new List<InvResultTemplate>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetInvestigationResultTemplate(OrgID, TemplateType, DeptID, out lstInvResultTemplate);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationResultTemplate in Investigation_BL", e);
            }
            return result;
        }
        public long GetInvestigationResultTemplateByID(int OrgID, long ResultID, string ResultName, string TemplateType, out List<InvResultTemplate> lInvResultTemplate)
        {
            long result = -1;
            lInvResultTemplate = new List<InvResultTemplate>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetInvestigationResultTemplateByID(OrgID, ResultID, ResultName, TemplateType, out lInvResultTemplate);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationResultTemplateByID Investigation_BL", e);
            }
            return result;
        }
        public long GetInvestigatonResultsCapture(long VID, int OrgID, long RoleID, string gUID, long DeptID, string InvIDs, int LocationID,
                                              LoginDetail LDetail, long taskid, string IsTrustedDetails, string status,
                                                 out List<PatientInvestigation> lstInvestigation,
                                                 out List<InvestigationStatus> lstStatus,
                                                 out List<RoleDeptMap> lRoleDeptmap, out List<MedicalRemarksRuleMaster> lstmdRemarks
            //, out List<InvReportMaster> lEditInvestigationValues
            //, out List<InvestigationHeader> lstHeader
                                                 )
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            lRoleDeptmap = new List<RoleDeptMap>();
            lstmdRemarks = new List<MedicalRemarksRuleMaster>();
            //lEditInvestigationValues = new List<InvReportMaster>();
            //lstHeader = new List<InvestigationHeader>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetInvestigatonResultsCapture(VID, OrgID, RoleID, gUID, DeptID, InvIDs, LocationID, LDetail, taskid, IsTrustedDetails, status, out lstInvestigation, out lstStatus, out lRoleDeptmap,out lstmdRemarks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigatonResultsCapture in Investigation_BL", ex);
            }
            return result;
        }
        public long GetPatientInvSample(long pVisitId, int orgID, out List<PatientInvSample> lstPatientInvSample, out List<SampleAttributes> lstSampleAttributes, out List<PerformingPhysician> lPerfPhysician)
        {
            long returnCode = -1;

            lstPatientInvSample = new List<PatientInvSample>();
            lstSampleAttributes = new List<SampleAttributes>();
            lPerfPhysician = new List<PerformingPhysician>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetPatientInvSample(pVisitId, orgID, out lstPatientInvSample, out lstSampleAttributes, out lPerfPhysician);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientInvSample in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetPatientInvestigationSampleResults(long vid, int OrgID, out List<PatientInvSampleResults> lstPatientInvSampleResults)
        {
            long result = -1;
            lstPatientInvSampleResults = new List<PatientInvSampleResults>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetPatientInvestigationSampleResults(vid, OrgID, out lstPatientInvSampleResults);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPatientInvestigationSampleResults in Investigation_BL", e);
            }
            return result;
        }
        public long GetOrderedInvestigations(long vid, int OrgID, out List<PatientInvestigation> lstOrderedInvestigations, out List<PatientInvSampleMapping> lstPatientInvSampleMapping, out List<PatientInvSampleResults> lstPatientInvSampleResults)
        {
            long result = -1;
            lstOrderedInvestigations = new List<PatientInvestigation>();
            lstPatientInvSampleMapping = new List<PatientInvSampleMapping>();
            lstPatientInvSampleResults = new List<PatientInvSampleResults>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetOrderedInvestigations(vid, OrgID, out lstOrderedInvestigations, out lstPatientInvSampleMapping, out lstPatientInvSampleResults);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetOrderedInvestigations in Investigation_BL", e);
            }
            return result;
        }
        public long SaveInvestigationMethodKit(long vid, int OrgID, int deptID, List<PatientInvestigation> PatientInvestigation)
        {
            long retCode = -1;

            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SaveInvestigationMethodKit(vid, OrgID, deptID, PatientInvestigation);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveInvestigationMethodKit in Investigation_BL", e);
            }
            return retCode;
        }
        public long GetInvMethodKit(long vid, int OrgID, int deptID, string gUID, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long result = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetInvMethodKit(vid, OrgID, deptID, gUID, out lstPatientInvestigation);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvMethodKit in Investigation_BL", e);
            }
            return result;
        }
        public long GetGroupAndInvestigationByVisitID(long vid, int OrgID, int deptID, out List<InvestigationValues> lstInvestigationValues)
        {
            long result = -1;
            lstInvestigationValues = new List<InvestigationValues>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetGroupAndInvestigationByVisitID(vid, OrgID, deptID, out lstInvestigationValues);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetGroupAndInvestigationByVisitID in Investigation_BL", e);
            }
            return result;
        }
        public long GetInvestigationResultByRoleID(long patientVisitID, long roleID, int OrgID, out List<PatientVisit> lstPatientDemographics, out List<InvestigationValues> lstInvestigationValues)
        {
            long result = -1;
            lstInvestigationValues = new List<InvestigationValues>();
            lstPatientDemographics = new List<PatientVisit>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetInvestigationResultByRoleid(patientVisitID, OrgID, roleID, out lstPatientDemographics, out lstInvestigationValues);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationValues in Investigation_BL", e);
            }
            return result;
        }
        public long UpdateInvestigationStatus(long patientVisitID, string status, int OrgID, List<InvestigationValues> lstInvValues)
        {
            long returncode = -1;
            try
            {

                returncode = new Investigation_DAL(globalContextDetails).UpdateInvestigationStatus(patientVisitID, status, OrgID, lstInvValues);

            }
            catch (Exception EX)
            {
                CLogger.LogError("Error while executing UpdateInvestigationStatus in Investigation_BL", EX);
            }

            return returncode;
        }

        public long SaveIPOrderedInvestigation(List<OrderedInvestigations> pInvestigationHL, long OrgID, out int returnstatus, string guid)
        {
            returnstatus = -1;
            long retCode = -1;

            //cmdInvestigation = Command.pInsertInvestigationProfileBulkCommand(invs, OrgID, out ret);
            try
            {
                retCode = new Investigation_DAL(globalContextDetails).SaveIPOrderedInvestigation(pInvestigationHL, OrgID, out returnstatus, guid);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveIPOrderedInvestigation in Investigation_BL", e);
            }
            return retCode;

        }

        public long GetModalityWorkList(string modalityName, DateTime FromDate, DateTime ToDate, int orgid, out List<ModalityWorkList> modalityWorklist, out List<ModalityWorkList> CompletionList)
        {
            long returncode = -1;
            modalityWorklist = new List<ModalityWorkList>();
            CompletionList = new List<ModalityWorkList>();
            try
            {
                new Investigation_DAL(globalContextDetails).GetModalityWorkList(modalityName, FromDate, ToDate, orgid, out modalityWorklist, out CompletionList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetModalityWorkList in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetLabConsumablesByOrg(int OrgID, string type, long ClientID, out List<LabConsumables> lstLabConsumables)
        {

            lstLabConsumables = new List<LabConsumables>();
            long returnCode = -1;

            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetLabConsumablesByOrg(OrgID, type, ClientID, out lstLabConsumables);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetLabConsumablesByOrg in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long SaveOrderedInvestigation(List<OrderedInvestigations> OrderedInves, long OrgID)
        {
            long retCode = -1;
            //AffectedrowCount = 0;
            //DataTable invs = new DataTable();
            if (OrderedInves[0].LabNo.ToString() != null & OrderedInves[0].LabNo.ToString() != "" & OrderedInves[0].LabNo != "")
            {
                //invs = GetOrdInvDataTable1(OrderedInves);
            }
            else
            {
                //invs = GetOrdInvDataTable(OrderedInves);
            }
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SaveOrderedInvestigation(OrderedInves, OrgID);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveOrderedInvestigationHOS in Investigation_BL", e);
            }
            return retCode;
        }



        public long SaveIPPaidInvestigationAndPatientIndents(List<PatientDueChart> lstSurgergicalPkg, List<OrderedInvestigations> pInvestigationHL, int OrgID, out List<OrderedInvestigations> lstOrderedInv, List<PatientDueChart> pPatientConsultation,
                                          List<PatientDueChart> pPatientProcedure, List<PatientDueChart> pPatientIndents, List<DHEBAdder> pDHEBPatientIndents,
                                         long visitID, long CreatedBy, long patientID, DateTime dtInvDate, string GuID, out string InterimBillNo, out string LabNo)
        {

            long returncode = -1;

            //DataTable invs = GetOrdInvDataTable(pInvestigationHL);
            returncode = new Investigation_DAL(globalContextDetails).SaveIPPaidInvestigationAndPatientIndents(lstSurgergicalPkg, pInvestigationHL, OrgID, out lstOrderedInv, pPatientConsultation, pPatientProcedure, pPatientIndents, pDHEBPatientIndents, visitID, CreatedBy, patientID, dtInvDate, GuID, out InterimBillNo, out LabNo);
            return returncode;


        }

        public long SaveIPPaidInvestigationAndPatientIndents(List<OrderedInvestigations> pInvestigationHL, int OrgID, out List<OrderedInvestigations> lstOrderedInv, long visitID, long CreatedBy, long patientID, string GuID, out string InterimBillNo)
        {

            long returncode = -1;

            // DataTable invs = GetOrdInvDataTable(pInvestigationHL);
            returncode = new Investigation_DAL(globalContextDetails).SaveIPPaidInvestigationAndPatientIndents(pInvestigationHL, OrgID, out lstOrderedInv, visitID, CreatedBy, patientID, GuID, out InterimBillNo);
            return returncode;




        }
        public long SaveInvestiagtionResult(long AccessionNumber, string InvestigationResult)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).SaveInvestiagtionResult(AccessionNumber, InvestigationResult);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveInvestiagtionResult in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetOrderedInvForPhysician(int pOrgID, long patientVisitID, out List<OrderedInvestigations> lstOrderedInves)
        {
            long returnCode = -1;
            lstOrderedInves = new List<OrderedInvestigations>();

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetOrderedInvForPhysician(pOrgID, patientVisitID, out lstOrderedInves);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrderedInvestigation in Investigation_BL", ex);

            }
            return returnCode;
        }

        public long SearchInvRefRangeForMDM(string invName, int OrgID, long StartIndex, long EndIndex, out List<InvestigationOrgMapping> lstInv, out List<InvSampleMaster> lstInvSampleMaster, out List<InvestigationMethod> lstInvMethod, out List<InvPrincipleMaster> lstInvPrinciple, out List<InvKitMaster> lstInvKit, out List<InvInstrumentMaster> lstInvInstrument, out List<InvestigationSampleContainer> lstSampleContainer, out List<OrganizationAddress> lstOrganizationAddress, out long TotalSerachCount, out List<OrganizationAddress> lstProcessingCentre)
        {
            long returnCode = -1;
            TotalSerachCount = -1;
            lstInv = new List<InvestigationOrgMapping>();
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstInvMethod = new List<InvestigationMethod>();
            lstInvPrinciple = new List<InvPrincipleMaster>();
            lstInvKit = new List<InvKitMaster>();
            lstInvInstrument = new List<InvInstrumentMaster>();
            lstSampleContainer = new List<InvestigationSampleContainer>();
            lstOrganizationAddress = new List<OrganizationAddress>();
            lstProcessingCentre = new List<OrganizationAddress>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.SearchInvRefRangeForMDM(invName, OrgID, StartIndex, EndIndex, out lstInv, out lstInvSampleMaster, out lstInvMethod, out lstInvPrinciple, out lstInvKit, out lstInvInstrument, out lstSampleContainer, out lstOrganizationAddress, out TotalSerachCount, out lstProcessingCentre);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvRefRangeForMDM in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long SearchGrpRefRangeForMDM(int OrgID, long StartIndex, long EndIndex, string invName, out List<InvGroupMaster> lstInv, out long TotalSerachCount)
        {
            long returnCode = -1;
            TotalSerachCount = -1;
            lstInv = new List<InvGroupMaster>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.SearchGrpRefRangeForMDM(OrgID, StartIndex, EndIndex, invName, out lstInv, out TotalSerachCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchGrpRefRangeForMDM in Investigation_BL", ex);
            }

            return returnCode;
        }


        public long SaveReferenceRange(List<InvestigationOrgMapping> lstIOM, int orgID)
        {
            long returnCode = -1;
            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

            try
            {
                returnCode = invDAL.SaveReferenceRange(lstIOM, orgID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveReferenceRange in Investigation_BL", excp);
            }
            return returnCode;
        }
        public long SaveGrpReferenceRange(List<InvOrgGroup> lstIOM, int orgID)
        {
            long returnCode = -1;
            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

            try
            {
                returnCode = invDAL.SaveGrpReferenceRange(lstIOM, orgID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveGrpReferenceRange in Investigation_BL", excp);
            }
            return returnCode;
        }
        public long InsertReferenceRangeXML(List<InvestigationOrgMapping> lstIOM, int orgID)
        {
            long returnCode = -1;
            Investigation_DAL invDAL = new Investigation_DAL();

            try
            {
                returnCode = invDAL.InsertReferenceRangeXML(orgID, lstIOM);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing InsertReferenceRangeXML in Investigation_BL", excp);
            }
            return returnCode;
        }
        public long SavePatientRecommendation(PatientRecommendation precommendation, List<PatientRecommendationDtls> precommendationDtls)
        {

            long returnCode = -1;

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).SavePatientRecommendation(precommendation, precommendationDtls);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SavePatientRecommendation in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetInvResultsCaptureForApprovel(long VID, int OrgID, long RoleID, string gUID, long DeptID,
            LoginDetail LDetail, long TaskID,
                                                  out List<PatientInvestigation> lstInvestigation,
                                                  out List<InvestigationStatus> lstStatus,
                                                  out List<RoleDeptMap> lRoleDeptmap
                                                  , out List<InvReportMaster> lEditInvestigationValues, string IsTrustedDetails)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            lRoleDeptmap = new List<RoleDeptMap>();
            lEditInvestigationValues = new List<InvReportMaster>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetInvResultsCaptureForApprovel(VID, OrgID, RoleID, gUID, DeptID, LDetail, TaskID, out lstInvestigation, out lstStatus, out lRoleDeptmap, out lEditInvestigationValues, IsTrustedDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvResultsCaptureForApprovel in Investigation_BL", ex);
            }
            return result;
        }

        //public long GetInvBulkDataForApprovel(long InvestigationID, long patientVisitID, int orgID, int GroupID
        //      , out List<InvestigationValues> lstBulkData
        //  , out List<InvestigationValues> lstPendingValue, out List<InvestigationStatus> header)
        //{
        //    long result = -1;
        //    lstBulkData = new List<InvestigationValues>();
        //    lstPendingValue = new List<InvestigationValues>();
        //    header = new List<InvestigationStatus>();
        //    try
        //    {
        //        Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
        //        result = DemoDal.GetInvBulkDataForApprovel(InvestigationID, patientVisitID, orgID, GroupID, out lstBulkData, out lstPendingValue, out header);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error While loading GetDemoBulkData BL", ex);
        //    }
        //    return result;
        //}
        public long GetInvBulkDataForApprovel(string gUID, long InvestigationID, long patientVisitID, int orgID, int GroupID
      , out List<InvestigationValues> lstBulkData
  , out List<InvestigationValues> lstPendingValue, out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom)
        {
            long result = -1;
            lstBulkData = new List<InvestigationValues>();
            lstPendingValue = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetInvBulkDataForApprovel(gUID, InvestigationID, patientVisitID, orgID, GroupID, out lstBulkData, out lstPendingValue, out header, out lstiom);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvBulkData in Investigation_BL", ex);
            }
            return result;
        }


        public long GetPatientRecommendationTemplate(int OrgID, string TemplateType, string ResultName, out List<InvResultTemplate> lstInvResultTemplate)
        {
            long result = -1;
            lstInvResultTemplate = new List<InvResultTemplate>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetPatientRecommendationTemplate(OrgID, TemplateType, ResultName, out lstInvResultTemplate);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationResultTemplate in Investigation_BL", e);
            }
            return result;
        }

        public long GetHealthPackageData(int OrgID, int pkgid, out List<InvGroupMaster> lstPackages, out List<InvPackageMapping> lstPackageMapping, out List<PatientInvestigation> lstPackageContents, out List<GeneralHealthCheckUpMaster> lstGeneralHealthCheckUpMaster)
        {
            long returnCode = -1;
            lstPackages = new List<InvGroupMaster>();
            lstPackageMapping = new List<InvPackageMapping>();
            lstPackageContents = new List<PatientInvestigation>();
            lstGeneralHealthCheckUpMaster = new List<GeneralHealthCheckUpMaster>();
            try
            {
                Investigation_DAL investigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = investigationDAL.GetHealthPackageData(OrgID, pkgid, out lstPackages, out lstPackageMapping, out lstPackageContents, out lstGeneralHealthCheckUpMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHealthPackageData in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetHealthPackageDataWithClientID(int OrgID, int ClientID, out List<InvGroupMaster> lstPackages, out List<InvPackageMapping> lstPackageMapping, out List<PatientInvestigation> lstPackageContents, out List<GeneralHealthCheckUpMaster> lstGeneralHealthCheckUpMaster)
        {
            long returnCode = -1;
            lstPackages = new List<InvGroupMaster>();
            lstPackageMapping = new List<InvPackageMapping>();
            lstPackageContents = new List<PatientInvestigation>();
            lstGeneralHealthCheckUpMaster = new List<GeneralHealthCheckUpMaster>();
            try
            {
                Investigation_DAL investigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = investigationDAL.GetHealthPackageDataWithClientID(OrgID, ClientID, out lstPackages, out lstPackageMapping, out lstPackageContents, out lstGeneralHealthCheckUpMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHealthPackageDataWithClientID in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long UpdatePackageContent(List<InvPackageMapping> lstInvPackageMapping, List<InvPackageMapping> lstDeletedPackageMapping, int OrgID, List<AdditionalTubeMapping> lstAdditionalTubeMapping)
        {
            long retCode = -1;
            //DataTable invPMDT = GetInvPackageMappingDataTable(lstInvPackageMapping);
            //DataTable inv = GetInvPackage(lstDeletedPackageMapping);
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.UpdatePackageContent(lstInvPackageMapping, lstDeletedPackageMapping, OrgID, lstAdditionalTubeMapping);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdatePackageContent in Investigation_BL", e);
            }
            return retCode;
        }




        public long GetInvestigationByPCClientID(int orgID, long refOrgID, int refPhyID, int clientID, string type, out List<PatientInvestigation> lstPatInv)
        {
            lstPatInv = new List<PatientInvestigation>();
            long returnCode = -1;
            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetInvestigationByPCClientID(orgID, refOrgID, refPhyID, clientID, type, out lstPatInv);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationByPCClientID in Investigation_BL", ex);
            }
            return returnCode;
        }



        public long GetInvForMDLoadInvGrpMAP(int OrgID, int GrpID, out List<OrderedInvestigations> lstInvNames, out string groupname)
        {
            long returnCode = -1;
            lstInvNames = new List<OrderedInvestigations>();
            groupname = String.Empty;
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetInvForMDLoadInvGrpMAP(OrgID, GrpID, out lstInvNames, out groupname);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvForMDMAddInvAndGrp-OrderedInvestigations in Investigation_BL", ex);
            }
            return returnCode;
        }
        //public long GetWayToMethodKit(long RoleID, int OrgID, int DeptID, out string Display)
        //{
        //    long returnCode = -1;
        //    Display = "";
        //    try
        //    {
        //        Investigation_DAL patientVisitDAL = new Investigation_DAL(globalContextDetails);
        //        returnCode = patientVisitDAL.GetWayToMethodKit(RoleID, OrgID, DeptID, out Display);
        //    }
        //    catch (Exception excep)
        //    {
        //        CLogger.LogError("Error while executing GetWayToMethodKit in Investigation_DAL", excep);
        //    }
        //    return returnCode;
        //}
        public long GetCustomPrice(int OrgID, int RefPhyID, long RefOrgID, out List<PCCustomPriceMapping> lstPCCPM, out List<InvestigationOrgMapping> lstIOM)
        {
            long returnCode = -1;
            lstPCCPM = new List<PCCustomPriceMapping>();
            lstIOM = new List<InvestigationOrgMapping>();
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetCustomPrice(OrgID, RefPhyID, RefOrgID, out lstPCCPM, out lstIOM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCustomPrice in Investigation_BL", ex);
            }
            return returnCode;
        }


        public long SaveCustomPrice(int OrgID, int RefPhyID, long RefOrgID, List<PCCustomPriceMapping> lstPCCPM)
        {
            long retCode = -1;

            lstPCCPM = new List<PCCustomPriceMapping>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.SaveCustomPrice(OrgID, RefPhyID, RefOrgID, lstPCCPM);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveCustomPrice in Investigation_BL", e);
            }
            return retCode;
        }
        public long GetWayToMethodKit(long PatientVisitID, int OrgID, long roleID, out List<PatientInvestigation> lstSampleDept, out List<PatientInvSample> lstPatientInvSample)
        {
            long returncode = -1;
            lstSampleDept = new List<PatientInvestigation>();
            lstPatientInvSample = new List<PatientInvSample>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetWayToMethodKit(PatientVisitID, OrgID, roleID, out lstSampleDept, out lstPatientInvSample);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeptToTrackSamples in Investigation_BL", ex);
            }
            return returncode;
        }

        public long GetInvList(int OrgID, out List<InvestigationMaster> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.GetInvList(OrgID, out lstInvestigationMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIndInvList in Investigation_BL", ex);
            }



            return returnCode;
        }

        public long getOrgDepartHeadName(int orgID, out List<InvDeptMaster> lstDepname, out List<InvestigationHeader> lstHeader)
        {
            long returnCode = -1;
            lstDepname = new List<InvDeptMaster>();
            lstHeader = new List<InvestigationHeader>();

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).getOrgDepartHeadName(orgID, out lstDepname, out lstHeader);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getOrgDepartName in Investigation_BL", ex);

            }


            return returnCode;
        }


        public long DeleteInvestigationName(List<InvestigationOrgMapping> pInvMap, out string inv)
        {
            long returnCode = -1;
            inv = "";
            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
            try
            {
                returnCode = invDAL.DeleteInvestigationName(pInvMap, out inv);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing DeleteInvestigationName in Investigation_BL", excp);
            }
            return returnCode;

        }
        public long SaveInvResultTemplate(InvResultTemplate InvRt)
        {
            long retCode = -1;
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.SaveInvResultTemplate(InvRt);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveInvResultTemplate in Investigation_BL", e);
            }
            return retCode;
        }
        public long GetInvResultTemplateByResultName(int OrgID, int ResultID, string ResultName, int DeptID, out List<InvResultTemplate> lstInvResultTemplate)
        {
            long result = -1;
            lstInvResultTemplate = new List<InvResultTemplate>();
            try
            {

                result = new Investigation_DAL(globalContextDetails).GetInvResultTemplateByResultName(OrgID, ResultID, ResultName, DeptID, out lstInvResultTemplate);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationResultTemplate in Investigation_BL", e);
            }
            return result;
        }
        public long DelResultTemplate(string ResultID)
        {
            long returnCode = -1;
            Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
            try
            {
                returnCode = InvDAL.DelResultTemplate(ResultID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DelResultTemplate in Investigation_BL", ex);
            }
            return returnCode;
        }



        //code added on 23-07-2010 QRM - Started
        public long GetInvQualitativeResultMaster(out List<InvQualitativeResultMaster> lstInvQualitativeResultMaster)
        {
            long result = -1;
            lstInvQualitativeResultMaster = new List<InvQualitativeResultMaster>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetInvQualitativeResultMaster(out lstInvQualitativeResultMaster);

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvQualitativeResultMaster in Investigation_BL", e);
            }
            return result;
        }

        public long SaveQRMData(List<InvestigationBulkData> lstQRMData)
        {
            long returnCode = -1;
            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
            try
            {
                returnCode = invDAL.SaveQRMData(lstQRMData);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveQRMData in Investigation_BL", excp);
            }
            return returnCode;
        }



        public long SaveOrderLocation(List<OrderedInvestigations> lstOrderInvestigation, int OrgID)
        {
            long returncode = -1;
            Investigation_DAL invdal = new Investigation_DAL(globalContextDetails);

            try
            {
                returncode = invdal.SaveOrderLocation(lstOrderInvestigation, OrgID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveOrderLocation in Investigation_BL", excp);
            }
            return returncode;
        }
        public long UpdateTestStatus(List<OrderedInvestigations> lstOrderInvestigation, int OrgID)
        {
            long returncode = -1;
            Investigation_DAL invdal = new Investigation_DAL(globalContextDetails);

            try
            {
                returncode = invdal.UpdateTestStatus(lstOrderInvestigation, OrgID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveOrderLocation in Investigation_BL", excp);
            }
            return returncode;
        }
        public long UpdateToHoldInvestigationReport(List<PatientInvestigation> lstOrderInvestigation)
        {
            long returncode = -1;
            Investigation_DAL invdal = new Investigation_DAL(globalContextDetails);

            try
            {
                returncode = invdal.UpdateToHoldInvestigationReport(lstOrderInvestigation);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveOrderLocation in Investigation_BL", excp);
            }
            return returncode;
        }

        //code added on 23-07-2010 QRM - Completed

        public long InsertNewInvestigation(string InvestigationName, int DepartmentID, int HeaderID, int TemplateID, int PatternID, int OrgID)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).InsertNewInvestigation(InvestigationName, DepartmentID, HeaderID, TemplateID, PatternID, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertNewInvestigation in Investigation_BL", ex);
            }
            return returnCode;
        }


        public long UpdateTaskPickedByDetails(string Type, long PatientVisitID, long LID)
        {
            long returnCode = -1;
            Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);
            try
            {
                returnCode = IDAL.UpdateTaskPickedByDetails(Type, PatientVisitID, LID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateTaskPickedByDetails in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetLabInvestigationPatientSearch(int OrgAddID, int OrgID, long RoleID, int currentPageNo, int PageSize, Int64 PatientId, string PatientName, out List<EnterResult> lstPatient, out int totalRows, int intVisitType, long lngSourceId,
                                                      string wardno, string status, string invname, string fdate, string tdate, int priority, string VisitNumber, string PatNumber, string Type, long DeptID, string pTaskAction, int pRefPhyID, long pLocationID, LoginDetail LDetail, string IsTimed, long ProtocalGroupID, string BarcodeNumber, string tasks, string SampleID)
        {
            long lresult = -1;
            totalRows = -1;
            lstPatient = new List<EnterResult>();
            try
            {
                Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);
                lresult = IDAL.GetLabInvestigationPatientSearch(OrgAddID, OrgID, RoleID, currentPageNo, PageSize, PatientId, PatientName, out lstPatient, out totalRows, intVisitType, lngSourceId, wardno, status, invname, fdate, tdate, priority, VisitNumber, PatNumber, Type, DeptID, pTaskAction, pRefPhyID, pLocationID, LDetail, IsTimed, ProtocalGroupID, BarcodeNumber, tasks, SampleID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetLabInvestigationPatientSearch in Investigation_BL", ex);
            }
            return lresult;
        }

        //    public long InsertNewInvestigation(string InvestigationName, int DepartmentID, int HeaderID, int TemplateID, int PatternID, int OrgID)
        //    {
        //        long returnCode = -1;

        //        try
        //        {
        //            returnCode = new Investigation_DAL(globalContextDetails).InsertNewInvestigation(InvestigationName, DepartmentID, HeaderID, TemplateID, PatternID, OrgID);
        //        }
        //        catch (Exception ex)
        //        {
        //            CLogger.LogError("Error while executing GetDeptToTrackSamples Investigation_DAL", ex);
        //        }
        //        return returnCode;
        //    }
        public long GetCustomPriceWithInvName(int OrgID, int RefPhyID, long RefOrgID, string InvName, out List<PCCustomPriceMapping> lstPCCPM, out List<InvestigationOrgMapping> lstIOM)
        {
            long returnCode = -1;
            lstPCCPM = new List<PCCustomPriceMapping>();
            lstIOM = new List<InvestigationOrgMapping>();
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetCustomPriceWithInvName(OrgID, RefPhyID, RefOrgID, InvName, out lstPCCPM, out lstIOM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCustomPriceWithInvName in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetLabNo(int OrgID, List<OrderedInvestigations> OrderedInves, out string LabNo)
        {
            long returnCode = -1;

            List<OrderedInvestigations> ordInves = new List<OrderedInvestigations>();
            foreach (OrderedInvestigations invs in OrderedInves)
            {
                OrderedInvestigations objInvest = new OrderedInvestigations();
                objInvest.ID = invs.ID;
                objInvest.Name = invs.Name;
                objInvest.Status = "Paid";
                objInvest.PaymentStatus = "Paid";
                //objInvest.CreatedBy = LID;
                objInvest.Type = invs.Type;
                objInvest.OrgID = OrgID;
                objInvest.StudyInstanceUId = CreateUniqueDecimalString();
                ordInves.Add(objInvest);
            }


            Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
            returnCode = InvDAL.GetLabNo(OrgID, ordInves, out LabNo);
            return returnCode;
        }
        public long SaveOrderedInvestigation(List<OrderedInvestigations> OrderedInves, int OrgID, long VisitID, string gUID)
        {
            long retCode = -1;
            //string gUID = System.Guid.NewGuid().ToString();

            try
            {
                List<OrderedInvestigations> ordInves = new List<OrderedInvestigations>();
                foreach (OrderedInvestigations invs in OrderedInves)
                {
                    OrderedInvestigations objInvest = new OrderedInvestigations();
                    objInvest.ID = invs.ID;
                    objInvest.Name = invs.Name;
                    objInvest.VisitID = VisitID;
                    objInvest.Status = "Paid";
                    objInvest.PaymentStatus = "Paid";
                    //objInvest.CreatedBy = LID;
                    objInvest.Type = invs.Type;
                    objInvest.OrgID = OrgID;
                    objInvest.UID = gUID;
                    objInvest.StudyInstanceUId = CreateUniqueDecimalString();
                    ordInves.Add(objInvest);
                }
                // DataTable dtinvs = GetOrdInvDataTable(ordInves);

                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SaveOrderedInvestigation(ordInves, OrgID);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveOrderedInvestigationHOS in Investigation_BL", e);
            }
            return retCode;
        }
        private string GetUniqueKey()
        {
            int maxSize = 10;
            char[] chars = new char[62];
            string a;
            //a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            a = "0123456789012345678901234567890123456789012345678901234567890123456789";
            chars = a.ToCharArray();
            int size = maxSize;
            byte[] data = new byte[1];
            System.Security.Cryptography.RNGCryptoServiceProvider crypto = new System.Security.Cryptography.RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            size = maxSize;
            data = new byte[size];
            crypto.GetNonZeroBytes(data);
            System.Text.StringBuilder result = new System.Text.StringBuilder(size);
            foreach (byte b in data)
            { result.Append(chars[b % (chars.Length - 1)]); }
            return result.ToString();
        }

        private string CreateUniqueDecimalString()
        {
            string uniqueDecimalString = "1.2.840.113619.";
            uniqueDecimalString += GetUniqueKey() + ".";
            uniqueDecimalString += GetUniqueKey();
            return uniqueDecimalString;
        }

        public long UpdateRefDoctorName(long PatientVisitId, int RefDocID, int OrgID)
        {
            long returnCode = -1;

            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.UpdateRefDoctorName(PatientVisitId, RefDocID, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCustomPriceWithInvName in Investigation_BL", ex);
            }
            return returnCode;
        }


        public long GetLabWorkListForVisit(long vid, int OrgID, int RoleID, string GUID, out List<InvestigationOrgMapping> lstInvestigationOrgMapping)
        {
            long result = -1;
            lstInvestigationOrgMapping = new List<InvestigationOrgMapping>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetLabWorkListForVisit(vid, OrgID, RoleID, GUID, out lstInvestigationOrgMapping);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetLabWorkListForVisit in Investigation_BL", e);
            }
            return result;
        }
        //code added for SampleNotGiven - begin
        public long GetSampleNotGiven(int OrgID, long PatientVisitId, out List<SampleTracker> lstST)
        {
            long returnCode = -1;
            lstST = new List<SampleTracker>();
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetSampleNotGiven(OrgID, PatientVisitId, out lstST);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSampleNotGiven in Investigation_BL", ex);
            }
            return returnCode;
        }



        public long SaveSampleTrackerStatus(List<SampleTracker> lstSampleTracker)
        {
            long returnCode = -1;
            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
            //DataTable SampleTrackerDT = (lstSampleTracker);
            try
            {
                returnCode = invDAL.SaveSampleTrackerStatus(lstSampleTracker);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveSampleTrackerStatus in Investigation_BL", excp);
            }
            return returnCode;
        }
        //code added for SampleNotGiven - ends

        //code added for GroupLevelComments - Begins
        public long SaveGroupComments(List<PatientInvestigation> lstPInvestigation, string GUID)
        {
            long returnCode = -1;
            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
            //DataTable DtGroupComment = (lstPInvestigation);
            try
            {
                returnCode = invDAL.SaveGroupComments(lstPInvestigation, GUID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveGroupComments Investigation_BL", excp);
            }
            return returnCode;
        }
        //code added for GroupLevelComments - Ends
        public long DeleteInvestigation(List<OrderedInvestigations> InvestigationDetail, long ExternalVisitID, int OrgID, out long VisitID)
        {
            long returnCode = -1;
            //InvestigationDetail = new List<OrderedInvestigations>();
            returnCode = new Investigation_DAL(globalContextDetails).DeleteInvestigationDetails(InvestigationDetail, ExternalVisitID, OrgID, out VisitID);
            return returnCode;
        }
        public long GetWorkOrderFromVisitToVisit(string pFromVisitID, string pToVisitID, string pFromDate, string pToDate, string pLocation, string pSourceName, int pVisitType, string pWard, string pInvestigationName, int OrgID, int pHistoryMode, long pLoginId, string pPageMode, int pLoggedLocationId, out List<WorkOrder> lstWorkOrder)
        {
            long result = -1;
            lstWorkOrder = new List<WorkOrder>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetWorkOrderFromVisitToVisit(pFromVisitID, pToVisitID, pFromDate, pToDate, pLocation, pSourceName, pVisitType, pWard, pInvestigationName, OrgID, pHistoryMode, pLoginId, pPageMode, pLoggedLocationId, out lstWorkOrder);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetWorkOrderFromVisitToVisit in Investigation_BL", e);
            }
            return result;
        }
        public long GetRadiologyReport(int OrgAddID, int OrgID, string FromVisit, string ToVisit, string RefPhyName, string RefHosName, string ReportedBy, string UrnNo, string PatientName, string ReportText, int currentPageNo, int PageSize, out int totalRows, out List<RadiologyReport> lstRadiologyReport)
        {
            long result = -1;
            lstRadiologyReport = new List<RadiologyReport>();
            totalRows = 0;
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetRadiologyReport(OrgAddID, OrgID, FromVisit, ToVisit, RefPhyName, RefHosName, ReportedBy, UrnNo, PatientName, ReportText, currentPageNo, PageSize, out totalRows, out lstRadiologyReport);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetRadiologyReport in Investigation_BL", e);
            }
            return result;
        }

        public long GetPerformingPhysician(int OrgID, out List<PerformingPhysician> lstPerformingPhysician)
        {
            long result = -1;
            lstPerformingPhysician = new List<PerformingPhysician>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetPerformingPhysician(OrgID, out lstPerformingPhysician);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPerformingPhysician in Investigation_BL", e);
            }
            return result;
        }

        public long GetReferingHospitalList(string PrefixText, int OrgID, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long result = -1;
            lstLabRefOrg = new List<LabReferenceOrg>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetReferingHospitalList(PrefixText, OrgID, out lstLabRefOrg);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetReferingHospitalList in Investigation_BL", e);
            }
            return result;
        }
        public long GetWorkListFromVisitToVisit(string fromVisit, string toVisit, int OrgID, int deptID, int orgadd, int clientid,
             long LocationID, string WardName, string InvestigationName, int PriorityID,
             out List<WorkOrder> lstWorkList, int intVisitType, string FromDate, string Todate, int pHistoryMode,
            string pPageMode, long pLoginId, string IsIncludevalues, string Preference)
        {
            long result = -1;
            lstWorkList = new List<WorkOrder>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetWorkListFromVisitToVisit(fromVisit, toVisit, OrgID, deptID, orgadd,
                    clientid, LocationID, WardName, InvestigationName, PriorityID, out lstWorkList, intVisitType, FromDate, Todate, pHistoryMode,
                    pPageMode, pLoginId, IsIncludevalues, Preference);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetWorkListFromVisitToVisit in Investigation_BL", e);
            }
            return result;
        }
        public long GetPatInvDetailsForVisit(long PatientVisitId, int OrgID, List<OrderedInvestigations> lOrdList, string gUID, out List<PatientInvestigation> lstPatientInvestigaion)
        {
            long lresult = -1;
            lstPatientInvestigaion = new List<PatientInvestigation>();
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);

                List<OrderedInvestigations> ordInves = new List<OrderedInvestigations>();
                foreach (OrderedInvestigations invs in lOrdList)
                {
                    OrderedInvestigations objInvest = new OrderedInvestigations();
                    objInvest.ID = invs.ID;
                    objInvest.Name = invs.Name;
                    objInvest.VisitID = PatientVisitId;
                    objInvest.Status = "Paid";
                    objInvest.PaymentStatus = "Paid";
                    //objInvest.CreatedBy = LID;
                    objInvest.Type = invs.Type;
                    objInvest.OrgID = OrgID;
                    objInvest.UID = gUID;
                    objInvest.StudyInstanceUId = CreateUniqueDecimalString();
                    ordInves.Add(objInvest);
                }

                //DataTable dt = GetOrdInvDataTable(ordInves);
                int rowsAffected = 0;
                lresult = InvestigationDAL.GetPatInvDetailsForVisit(ordInves, PatientVisitId, OrgID, out lstPatientInvestigaion, out rowsAffected);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPatInvDetailsForVisit in Investigation_BL", excp);
            }
            return lresult;
        }
        /* BEGIN | NA | Sabari | 20190515 | Created | MRNNumberSearch */
        public long GetReceiveSampleList(int OrgID, int OrgAddressID, int CollectedLocationID, string visitid, string patientname, int visittype, int priority, string fromdate, string todate, string sourcename, string InvestigationName, long InvestigationID, string InvestigationType, string refPhyName, long refPhyID, long refPhyOrg, string BarcodeNumber, out List<PatientVisitDetails> lPatientDetails, int pagesize, int startrowindex, out int totalrows, string patientnumber)
        {
            long returnCode = -1;
            totalrows = -1;
            lPatientDetails = new List<PatientVisitDetails>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetReceiveSampleList(OrgID, OrgAddressID, CollectedLocationID, visitid, patientname, visittype, priority, fromdate, todate, sourcename, InvestigationName, InvestigationID, InvestigationType, refPhyName, refPhyID, refPhyOrg, BarcodeNumber, out lPatientDetails, pagesize, startrowindex, out totalrows, patientnumber);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetReceiveSampleList in Investigation_BL", ex);
            }
            return returnCode;
        }
        /* END | NA | Sabari | 20190515 | Created | MRNNumberSearch */
        public long UpdateClientMaster(InvClientMaster InvClientMaster)
        {
            long lresult = -1;
            try
            {
                Investigation_DAL objInvestigation_DAL = new Investigation_DAL(globalContextDetails);
                lresult = objInvestigation_DAL.UpdateClientMaster(InvClientMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateClientMaster in Investigation_BL", ex);
            }
            return lresult;
        }
        public long InsertPatientSampleMapping(List<PatientInvSampleMapping> lsampleresult, long VisitID, int OrgID, int DeptID, long CreatedBy, out int returnStatus)
        {
            long returncode = -1;
            returnStatus = -1;
            try
            {


                returncode = new Investigation_DAL(globalContextDetails).InsertPatientSampleMapping(lsampleresult, VisitID, OrgID, DeptID, CreatedBy, out returnStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertPatientSampleMapping in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetDeviceImportData(string date, int orgID, string Status, string DeviceId, out List<DeviceImportData> objImportData)
        {
            long returncode = -1;
            objImportData = new List<DeviceImportData>();
            try
            {
                new Investigation_DAL(globalContextDetails).GetDeviceImportData(date, orgID, Status, DeviceId, out objImportData);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeviceImportData in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetInvestigationDetailsForExternalVisitID(string FromPatientVisitID, string ToPatientVisitID, int OrgID
                    , long roleID, string gUID, int LocationID, string fDate, string toDate,
                  out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetInvestigationDetailsForExternalVisitID(FromPatientVisitID, ToPatientVisitID,
                    OrgID, roleID, gUID, LocationID, fDate, toDate, out lstPatientInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationDetailsForExternalVisitID in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long pGetInvANDGroup(int OrgID, int GrpID, out List<OrderedInvestigations> lstInvNames, out string groupname)
        {
            long returnCode = -1;
            lstInvNames = new List<OrderedInvestigations>();
            groupname = String.Empty;
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.pGetInvANDGroup(OrgID, GrpID, out lstInvNames, out groupname);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetInvANDGroup in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long pUpdateInvANDGrpSequence(DataTable dt, int OrgID, int GroupID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pUpdateInvANDGrpSequence(dt, OrgID, GroupID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pUpdateInvANDGrpSequence in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetDeptSequence(int OrgID, out List<InvDeptMaster> lstDept)
        {
            long returnCode = -1;
            lstDept = new List<InvDeptMaster>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetDeptSequence(OrgID, out lstDept);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeptSequence in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long pUpdateDeptSequence(DataTable dt, int OrgID, int DeptID, string DeptName, string DtCode)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pUpdateDeptSequence(dt, OrgID, DeptID, DeptName, DtCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pUpdateDeptSequence in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long pInsertDeptName(int OrgID, string pdept, long DeptCode, string Code, out List<InvDeptMaster> lstDept)
        {
            long returnCode = -1;
            lstDept = new List<InvDeptMaster>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pInsertDeptName(OrgID, pdept, DeptCode, Code, out lstDept);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pInsertDeptName in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long pUpdateDeptSequenceNo(DataTable dt, int OrgID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pUpdateDeptSequenceNo(dt, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pUpdateDeptSequenceNo in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetProductUsage(int OrgID, int OrgAddressID, DateTime fromdate, DateTime todate, int LocationID, string DeviceName, string InvestigationName, string ProductName, long DeviceID, out List<InventoryProductMapping> lsttotalInvest, out List<ProductCategories> lstCategories, out List<Locations> lstLocations)
        {
            lsttotalInvest = new List<InventoryProductMapping>();
            lstCategories = new List<ProductCategories>();
            lstLocations = new List<Locations>();
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetProductUsage(OrgID, OrgAddressID, fromdate, todate, LocationID, DeviceName, InvestigationName, ProductName, DeviceID, out lsttotalInvest, out lstCategories, out lstLocations);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductUsage in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long SaveHomeCollectionDetails(long PatientID, string CollectionAddr, DateTime Fromdate, DateTime Todate, long RoleID,
             long UserID, int CollecOrgID, long CollecOrgAddrID, int LoginOrgID, DateTime BookedFrom, DateTime BookedTo, string Status, string Task,
             out List<Bookings> lstHomeCollectionDetails, string Add2, string City, string MobileNumber,
             string pAge, string Sex, string pName, int PageSize, int currentPageNo, out int totalRows)
        {
            lstHomeCollectionDetails = new List<Bookings>();
            long returnCode = -1;
            totalRows = 0;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).SaveHomeCollectionDetails(PatientID, CollectionAddr, Fromdate, Todate,
                    RoleID, UserID, CollecOrgID, CollecOrgAddrID, LoginOrgID, BookedFrom, BookedTo, Status, Task,
                    out lstHomeCollectionDetails, Add2, City, MobileNumber, pAge, Sex, pName, PageSize, currentPageNo, out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveHomeCollectionDetails in Investigation_BL", ex);
            }
            return returnCode;
        }


        //public long UpdateHomeCollectiondetails(long HCID, long pVisitID, string status, long pPatientID)
        //{
        //    long returnCode = -1;
        //    try
        //    {
        //        returnCode = new Investigation_DAL(globalContextDetails).UpdateHomeCollectiondetails(HCID, pVisitID, status, pPatientID);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while Updating HomeCollection Details ", ex);
        //    }
        //    return returnCode;
        //}

        public long UpdateHomeCollectiondetails(long BKNO, long patientVisitID, string status, long patientID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).UpdateHomeCollectiondetails(BKNO, patientVisitID, status, patientID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateHomeCollectiondetails in Investigation_BL", ex);
            }
            return returnCode;
        }


        public long GetRoleUserLogin(long OrgId, out List<LoginRole> objLoginRole)
        {
            long returncode = -1;
            objLoginRole = new List<LoginRole>();
            try
            {
                new Investigation_DAL(globalContextDetails).GetRoleUserLogin(OrgId, out objLoginRole);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRoleUserLogin in Investigation_BL", ex);
            }
            return returncode;
        }




        public long DeleteInventoryProductMapping(List<InventoryProductMapping> lstProductMapping, int OrgId, int lid)
        {
            long returnCode = -1;

            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
            // DataTable DtPMap = SaveProdDataTable(lstProductMapping);
            try
            {
                returnCode = invDAL.DeleteInventoryProductMapping(lstProductMapping, OrgId, lid);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing DeleteInventoryProductMapping in Investigation_BL", excp);
            }

            return returnCode;

        }


        public long SaveInventoryProductMapping(List<InventoryProductMapping> lstProductMapping, int OrgId, int lid, out string valid)
        {
            long returnCode = -1;
            valid = string.Empty;
            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
            // DataTable DtPMap = SaveProdDataTable(lstProductMapping);
            try
            {
                returnCode = invDAL.SaveInventoryProductMapping(lstProductMapping, OrgId, lid, out valid);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInventoryProductMapping in Investigation_BL", excp);
            }

            return returnCode;

        }

        public long SearchInventoryProductMapping(int OrgID, out List<InventoryProductMapping> lstProductMapping)
        {
            long returnCode = -1;
            lstProductMapping = new List<InventoryProductMapping>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.SearchInventoryProductMapping(OrgID, out lstProductMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInventoryProductMapping in Investigation_BL", ex);

            }
            return returnCode;


        }


        public long SearchInvestigationProductMapping(int InvestigationId, int OrgID, out List<InventoryProductMapping> lstProductMapping)
        {
            long returnCode = -1;
            lstProductMapping = new List<InventoryProductMapping>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.SearchInvestigationProductMapping(InvestigationId, OrgID, out lstProductMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvestigationProductMapping in Investigation_BL", ex);

            }
            return returnCode;
        }
        public long SavePatientInvestigationForWorkList(List<PatientInvestigation> PatientInvestigation, long OrgID, string gUID, out int pOrderedInvCnt)
        {
            long retCode = -1;
            int ret = -1;
            pOrderedInvCnt = 0;

            //DataTable invs = GetDataTableForWorkList(PatientInvestigation);
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SavePatientInvestigationForWorkList(PatientInvestigation, OrgID, gUID, out pOrderedInvCnt);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SavePatientInvestigation in Investigation_BL", e);
            }
            return retCode;
        }


        public long pGetpatientInvestigationForVisit(long visitID, int orgID, int LocationID, string gUID, out List<OrderedInvestigations> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<OrderedInvestigations>();

            try
            {
                new Investigation_DAL(globalContextDetails).pGetpatientInvestigationForVisit(visitID, orgID, LocationID, gUID, out lstPatientInvestigation);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetpatientInvestigationForVisit in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long ADDinvestigationName(int OrgID, string InvName, DataTable dtCodingSchemeMaster, string CodeType, out List<InvestigationMaster> lstInvestigation)
        {
            long returnCode = -1;
            lstInvestigation = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.ADDinvestigationName(OrgID, InvName, dtCodingSchemeMaster, CodeType, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing ADDinvestigationName in Investigation_BL", ex);

            }
            return returnCode;


        }
        public long SearchInvestigation(int OrgID, string InvName, out List<InvestigationMaster> lstInvestigation, int pageSize, int StartRowIndex, out int totalRows)
        {
            long returnCode = -1;
            totalRows = 0;
            lstInvestigation = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.SearchInvestigation(OrgID, InvName, out lstInvestigation, pageSize, StartRowIndex, out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvestigation in Investigation_BL", ex);

            }
            return returnCode;


        }


        public long pGetPatientInvestigationStatus(string PatientNo, string PatientName,
                 string fromDate, string toDate, long OrgID, long OrgAddressID, string Status,
                 List<InvDeptSamples> deptSamples, string ReportStatus,
                 out List<InvestigationStatusReport> lstPatientInvestigationStatus,
                 int intVisitType, Int64 intSourceId, string TestName,
                   Int64 TestID, string TestType, string TestCategory, int InvestigationStatusId,
                 int ClientTypeID, long ClientID, int PageSize, int currentPageNo, out int totalRows, int STATStatus)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientInvestigationStatus = new List<InvestigationStatusReport>();
            //DataTable dtinvSample = new DataTable();
            //Utilities.ConvertFrom(deptSamples, out dtinvSample);
            //DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pGetPatientInvestigationStatus(PatientNo, PatientName,
                    fromDate, toDate, OrgID, OrgAddressID, Status,
                    deptSamples, ReportStatus, out lstPatientInvestigationStatus,
                    intVisitType, intSourceId, TestName, TestID, TestType, TestCategory, InvestigationStatusId,
                    ClientTypeID, ClientID, PageSize, currentPageNo, out totalRows, STATStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetPatientInvestigationStatus in Investigation_BL", ex);
            }
            return returnCode;

        }





        public long GetINVandPatternChange(string InvName, out List<InvestigationMaster> lstPatternForINV)
        {
            long returnCode = -1;
            lstPatternForINV = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.GetINVandPatternChange(InvName, out lstPatternForINV);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvestigation in Investigation_BL", ex);

            }
            return returnCode;
        }
        public long pGetPattern(int InvestigationID, int PatternID, out List<InvestigationPattern> lstPattern)
        {
            long returnCode = -1;
            //lstPatternForINV = new List<InvestigationMaster>();
            lstPattern = new List<InvestigationPattern>();
            //DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pGetPattern(InvestigationID, PatternID, out lstPattern);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetPattern in Investigation_BL", ex);
            }
            return returnCode;

        }

        public long pSavePattern(List<PatternMapping> lstsavepattern, List<InvReportMapping> lstSaveInvReportMapping) //Perumal
        {
            long returnCode = -1;

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pSavePattern(lstsavepattern, lstSaveInvReportMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pSavePattern in Investigation_BL", ex);
            }
            return returnCode;

        }

        public long pGetPatternInvestigation(int PatternID, int orgid, out List<InvestigationMaster> lstPattern)
        {
            long returnCode = -1;
            //lstPatternForINV = new List<InvestigationMaster>();
            lstPattern = new List<InvestigationMaster>();
            //DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pGetPatternInvestigation(PatternID, orgid, out lstPattern);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetPatternInvestigation in Investigation_BL", ex);
            }
            return returnCode;

        }
        public long UpdateMMPSStatus(long AccessioNumber, string StudyInstanceUID, int Status)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).UpdateMMPSStatus(AccessioNumber, StudyInstanceUID, Status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateMMPSStatus in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetPatientDemography(int OrgID, long PatientVisitID, out List<PatientDemography> PatientDemography)
        {
            long returnCode = -1;
            PatientDemography = new List<PatientDemography>();

            //DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetPatientDemography(OrgID, PatientVisitID, out PatientDemography);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientDemography in Investigation_BL", ex);
            }
            return returnCode;

        }

        public long GetInvestigationValuesForID(int OrgID, long PatientVisitID, int TemplateID, long InvestigationID, out List<InvestigationValues> InvestigationValues)
        {
            long returnCode = -1;

            InvestigationValues = new List<InvestigationValues>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetInvestigationValuesForID(OrgID, PatientVisitID, TemplateID, InvestigationID, out InvestigationValues);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationValuesForID in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetImageForApproval(long OrgID, long PatientVisitID, long InvestigationID, out  Login lstLogin)
        {
            long returnCode = -1;

            lstLogin = new Login();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetImageForApproval(OrgID, PatientVisitID, InvestigationID, out lstLogin);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetImageForApproval in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long PGetInvQualitativeResult(long orgid, out List<InvQualitativeResultMaster> lstInvQual)
        {
            long lresult = -1;
            lstInvQual = new List<InvQualitativeResultMaster>();
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                lresult = InvestigationDAL.PGetInvQualitativeResult(orgid, out lstInvQual);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing PGetInvQualitativeResult in Investigation_BL", excp);
            }
            return lresult;
        }
        public long PInsertInvQualitactiveResultMaster(long orgid, string Name)
        {
            long lresult = -1;
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                lresult = InvestigationDAL.PInsertInvQualitactiveResultMaster(orgid, Name);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing PInsertInvQualitactiveResultMaster in Investigation_BL", excp);
            }
            return lresult;
        }
        public long PdeleteInvQualitativeResultMaster(long OrgID, long id, string perphyname)
        {
            long returnCode = -1;

            try
            {
                Attune.Solution.DAL.Investigation_DAL physicianDAL = new Investigation_DAL(globalContextDetails);
                returnCode = physicianDAL.PdeleteInvQualitativeResultMaster(OrgID, id, perphyname);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing PdeleteInvQualitativeResultMaster in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long PUpdateInvQualitativeResultMaster(long OrgID, long id, string perphyname)
        {
            long returnCode = -1;

            try
            {
                Attune.Solution.DAL.Investigation_DAL physicianDAL = new Investigation_DAL(globalContextDetails);
                returnCode = physicianDAL.PUpdateInvQualitativeResultMaster(OrgID, id, perphyname);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing PUpdateInvQualitativeResultMaster in Investigation_BL", excp);
            }

            return returnCode;
        }

        public long GetInvestigationSymbols(long OrgID, out List<InvestigationMaster> INVMaster)
        {
            INVMaster = new List<InvestigationMaster>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL physicianDAL = new Investigation_DAL(globalContextDetails);
                returnCode = physicianDAL.GetInvestigationSymbols(OrgID, out INVMaster);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetInvestigationSymbols in Investigation_BL", excp);
            }

            return returnCode;
        }

        public long SaveUOMSymbols(long OrgID, string UOMCode, string UOMDesc)
        {
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL physicianDAL = new Investigation_DAL(globalContextDetails);
                returnCode = physicianDAL.SaveUOMSymbols(OrgID, UOMCode, UOMDesc);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveUOMSymbols in Investigation_BL", excp);
            }

            return returnCode;
        }

        public long UploadUOMCode(int OrgID, string Symbol, string Description)
        {
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL physicianDAL = new Investigation_DAL(globalContextDetails);
                returnCode = physicianDAL.UploadUOMCode(OrgID, Symbol, Description);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UploadUOMCode in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long UpdateOrderedInvestigation(long patientVisitID, string labno, int OrgID, string BillNo, long TaskId)
        {
            long returncode = -1;
            try
            {

                returncode = new Investigation_DAL(globalContextDetails).UpdateOrderedInvestigation(patientVisitID, labno, OrgID, BillNo, TaskId);

            }
            catch (Exception EX)
            {
                CLogger.LogError("Error while executing UpdateInvestigationStatus in Investigation_BL", EX);
            }

            return returncode;
        }
        public long GetInvestigationNameForOrg(string Name, long orgid, out List<OrderedInvestigations> lstOrd)
        {
            lstOrd = new List<OrderedInvestigations>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetInvestigationNameForOrg(Name, orgid, out lstOrd);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetInvestigationNameForOrg in Investigation_BL", excp);
            }

            return returnCode;
        }


        public long GetBatchSheet(string pFromVisitID, string pToVisitID, string pFromDate, string pToDate, string pLocation, long ILocationID, long Orgid, out DataSet DSWorkOrder, out List<PatientInvSample> lstPatientInvSample, out List<InvestigationSampleContainer> lstInvestigationSampleContainer, string Mode, int BatchID, long ClientID, long CollectedID)
        {
            long result = -1;
            lstPatientInvSample = new List<PatientInvSample>();
            lstInvestigationSampleContainer = new List<InvestigationSampleContainer>();
            DSWorkOrder = new DataSet();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetBatchSheet(pFromVisitID, pToVisitID, pFromDate, pToDate, pLocation, ILocationID, Orgid, out DSWorkOrder, out lstPatientInvSample, out lstInvestigationSampleContainer, Mode, BatchID, ClientID, CollectedID);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetBatchSheet in Investigation_BL", e);
            }
            return result;
        }
        public long GetBatchNumbers(long pRegLocId, string pFromDate, string pToDate, string BatchStatus, out  List<SampleBatchTracker> lstSampleBatchTracker)
        {
            long result = -1;
            lstSampleBatchTracker = new List<SampleBatchTracker>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetBatchNumbers(pRegLocId, pFromDate, pToDate, BatchStatus, out lstSampleBatchTracker);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetBatchNumbers in Investigation_BL", e);
            }
            return result;
        }


        public long GetCorpoRateHealthPackageDataWithClientID(int OrgID, int ClientID, out List<InvGroupMaster> lstPackages, out List<InvPackageMapping> lstPackageMapping, out List<PatientInvestigation> lstPackageContents, out List<GeneralHealthCheckUpMaster> lstGeneralHealthCheckUpMaster)
        {

            long returnCode = -1;
            lstPackages = new List<InvGroupMaster>();
            lstPackageMapping = new List<InvPackageMapping>();
            lstPackageContents = new List<PatientInvestigation>();
            lstGeneralHealthCheckUpMaster = new List<GeneralHealthCheckUpMaster>();
            try
            {
                Investigation_DAL investigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = investigationDAL.GetCorpoRateHealthPackageDataWithClientID(OrgID, ClientID, out lstPackages, out lstPackageMapping, out lstPackageContents, out lstGeneralHealthCheckUpMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCorpoRateHealthPackageDataWithClientID in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetInvestigationshowincollecttasks(long visitID, int orgID, int LocationID, string Labno, LoginDetail LDetail, out List<OrderedInvestigations> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<OrderedInvestigations>();

            try
            {
                new Investigation_DAL(globalContextDetails).GetInvestigationshowincollecttasks(visitID, orgID, LocationID, Labno, LDetail, out lstPatientInvestigation);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationshowincollecttasks in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetLabNoforApproveShowstatus(int orgID, long visitID, string UID, out List<OrderedInvestigations> lstLabNo)
        {
            long returnCode = -1;
            lstLabNo = new List<OrderedInvestigations>();
            try
            {
                new Investigation_DAL(globalContextDetails).GetLabNoforApproveShowstatus(orgID, visitID, UID, out lstLabNo);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetLabNoforApproveShowstatus in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetTestDetails(int OrgID, int searchtype, long PatientID, string BillNumber, long SampleCode, out List<InvestigationQueue> lstTest)
        {
            long returnCode = -1;
            lstTest = new List<InvestigationQueue>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.GetTestDetails(OrgID, searchtype, PatientID, BillNumber, SampleCode, out lstTest);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInvestigation in Investigation_BL", ex);


            }
            return returnCode;


        }
        public long pGetbarcodePrint(long visitID, int orgID, string UID, out List<OrderedInvestigations> lstbarcode)
        {
            long returnCode = -1;
            lstbarcode = new List<OrderedInvestigations>();
            try
            {
                new Investigation_DAL(globalContextDetails).pGetbarcodePrint(visitID, orgID, UID, out lstbarcode);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetbarcodePrint in Investigation_BL", ex);
            }
            return returnCode;
        }
        /* BEGIN | NA | Sabari | 20190515 | Created | MRNNumberSearch */
        public long GetInvSamplesForStatus(int OrgID, string FromDate, string ToDate, int Status, int LocationID, string LocationType, string VisitID,
                      string PatientName, int VisitType, int Priority, string SourceName, string InvestigationName, long InvestigationID, string InvestigationType,
                      string refPhyName, long refPhyID, long refPhyOrg, long SampleID, int SearchType, string preference, out List<CollectedSample> lstSamples, int PageSize, int startRowIndex, out int totalRows, string BarcodeFrom, string BarcodeTo, string UserLoginID, string SubStatus, long RegLocation, long OutLocations, string pkgout, string patientnumber)
        {
            long returncode = -1;
            totalRows = 0;
            lstSamples = new List<CollectedSample>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvSamplesForStatus(OrgID, FromDate, ToDate, Status, LocationID, LocationType, VisitID,
            PatientName, VisitType, Priority, SourceName, InvestigationName, InvestigationID, InvestigationType,
            refPhyName, refPhyID, refPhyOrg, SampleID, SearchType, preference, out lstSamples, PageSize, startRowIndex, out totalRows, BarcodeFrom, BarcodeTo, UserLoginID, SubStatus, RegLocation, OutLocations, pkgout, patientnumber);

                /*-----------------Handle VIP Data Start-------------------------*/
                List<CollectedSample> lsttempDetails = new List<CollectedSample>();
                lsttempDetails = lstSamples.FindAll(P => P.PatientStatus == "VIP");
                lstSamples.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returncode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (CollectedSample)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returncode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (CollectedSample)Maskedobj;
                    lstSamples.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvSamplesForStatus in Investigation_BL", ex);
            }
            return returncode;
        }
        /* END | NA | Sabari | 20190515 | Created | MRNNumberSearch */
        public long GetInvExpectedSamplesForStatus(int OrgID, string FromDate, string ToDate, int Status, int LocationID, string LocationType, string VisitID,
          string PatientName, int VisitType, int Priority, string SourceName, string InvestigationName, long InvestigationID, string InvestigationType,
          string refPhyName, long refPhyID, long refPhyOrg, long SampleID, int SearchType,
          out List<CollectedSample> lstSamples)
        {
            long returncode = -1;
            lstSamples = new List<CollectedSample>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvExpectedSamplesForStatus(OrgID, FromDate, ToDate, Status, LocationID, LocationType, VisitID,
            PatientName, VisitType, Priority, SourceName, InvestigationName, InvestigationID, InvestigationType,
            refPhyName, refPhyID, refPhyOrg, SampleID, SearchType, out lstSamples);

                /*-----------------Handle VIP Data Start-------------------------*/
                List<CollectedSample> lsttempDetails = new List<CollectedSample>();
                lsttempDetails = lstSamples.FindAll(P => P.PatientStatus == "VIP");
                lstSamples.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returncode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (CollectedSample)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returncode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (CollectedSample)Maskedobj;
                    lstSamples.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvExpectedSamplesForStatus in Investigation_BL", ex);
            }
            return returncode;
        }

        public long GetInvStatus(int OrgID, string PageType, out List<InvSampleStatusmaster> lstSampleStatus)
        {
            long returncode = -1;
            lstSampleStatus = new List<InvSampleStatusmaster>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvStatus(OrgID, PageType, out lstSampleStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvStatus in Investigation_BL", ex);
            }
            return returncode;
        }

        public long GetInvReasonsForStatus(int OrgID, long StatusID, out List<InvReasonMasters> lstSampleReasons)
        {
            long returncode = -1;
            lstSampleReasons = new List<InvReasonMasters>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvReasonsForStatus(OrgID, StatusID, out lstSampleReasons);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvReasonsForStatus in Investigation_BL", ex);
            }
            return returncode;
        }

        public long GetInvReasons(int OrgID, out List<InvReasonMasters> lstSampleReasons)
        {
            long returncode = -1;
            lstSampleReasons = new List<InvReasonMasters>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvReasons(OrgID, out lstSampleReasons);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvReasons in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetInvestigationNameFromOrgMapping(string Name, long orgid, out List<InvestigationOrgMapping> lstOrd)
        {
            lstOrd = new List<InvestigationOrgMapping>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetInvestigationNameFromOrgMapping(Name, orgid, out lstOrd);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetInvestigationNameFromOrgMapping in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long GetAbnormalReport(DateTime fDate, DateTime tDate, long LocationID, long InvestigationID, int OrgID, out  List<PatientInvestigation> lstPatientInvestigation)
        {
            lstPatientInvestigation = new List<PatientInvestigation>();
            long returnCode = -1;
            try
            {
                Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetAbnormalReport(fDate, tDate, LocationID, InvestigationID, OrgID, out lstPatientInvestigation);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetAbnormalReport in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long GetQuickInvSamplesStatus(int OrgID, string FromDate, string ToDate, int Status, int LocationID, out List<CollectedSample> lstSamples1, out List<CollectedSample> lstSamples2, out List<InvestigationQueue> lstRetestInvestigationQueue)
        {
            long returncode = -1;
            lstSamples1 = new List<CollectedSample>();
            lstSamples2 = new List<CollectedSample>();
            lstRetestInvestigationQueue = new List<InvestigationQueue>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetQuickInvSamplesStatus(OrgID, FromDate, ToDate, Status, LocationID, out lstSamples1, out lstSamples2, out lstRetestInvestigationQueue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQuickInvSamplesStatus in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetNextBarcode(int OrgID, long pOrgAddressID, string Type, out string Barcode, long RefID, string RefType)
        {
            long returnCode = -1;
            Barcode = "";
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.GetNextBarcode(OrgID, pOrgAddressID, Type, out Barcode, RefID, RefType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetNextBarcode in Investigation_BL", ex);
            }
            return returnCode;
        }
        //Added for Client Billing on 24/01/2015 by Sudhakar
        public long GetNextMLNumber(int OrgID, long pOrgAddressID, string Type, out string MLNumber, long RefID, string RefType)
        {
            long returnCode = -1;
            MLNumber = "";
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.GetNextMLNumber(OrgID, pOrgAddressID, Type, out MLNumber, RefID, RefType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetNextMLNumber in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvestigationForSampleID(long VisitID, int OrgID, int SampleID, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returncode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvestigationForSampleID(VisitID, OrgID, SampleID, out lstPatientInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationForSampleID in Investigation_BL", ex);
            }
            return returncode;
        }

        public long GetInvSampleMaster(int OrgID, out List<InvSampleMaster> lstInvSampleMaster)
        {
            long returncode = -1;
            lstInvSampleMaster = new List<InvSampleMaster>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvSampleMaster(OrgID, out lstInvSampleMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvSampleMaster in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetSamplesByID(int OrgID, long RoleID, int SearchType, string SearchNo, out List<CollectedSample> lstOrderedSamples)
        {
            long returnCode = -1;
            lstOrderedSamples = new List<CollectedSample>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.GetSamplesByID(OrgID, RoleID, SearchType, SearchNo, out lstOrderedSamples);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSamplesByID in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long UpdateSampleStatusDetails(List<SampleTracker> lstSampleTracker)
        {
            long returncode = -1;

            try
            {
                Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);
                returncode = IDAL.UpdateSampleStatusDetails(lstSampleTracker);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateBulkSampleStatus in ClinicalTrail_BL", ex);
            }
            return returncode;

        }

        public long GetAberrantSampleInvestigations(long VisitID, int SampleID, int OrgID, out List<OrderedInvestigations> lstInvestigations)
        {
            long returnCode = -1;
            lstInvestigations = new List<OrderedInvestigations>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.GetAberrantSampleInvestigations(VisitID, SampleID, OrgID, out lstInvestigations);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAberrantSampleInvestigations in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvRejected(long VisitID, int OrgID, out List<PatientInvestigation> lstInvestigations)
        {
            long returnCode = -1;
            lstInvestigations = new List<PatientInvestigation>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.GetInvRejected(VisitID, OrgID, out lstInvestigations);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvRejected in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientInvestigationValuesHisiory(long patientVisitID, int OrgID, long PatternID, long InvID, out List<InvestigationValues> lstPendingValue)
        {
            long result = -1;
            lstPendingValue = new List<InvestigationValues>();
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetPatientInvestigationValuesHisiory(patientVisitID, OrgID, PatternID, InvID, out lstPendingValue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvBulkData in Investigation_BL", ex);
            }
            return result;
        }

        public long GetInvestigationByGroup(Int32 OrgGroupID, out List<InvestigationMaster> lstInvMaster)
        {
            long returnCode = -1;
            lstInvMaster = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.GetInvestigationByGroup(OrgGroupID, out lstInvMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationByGroup in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvComputationRuleByGroup(Int32 OrgID, Int32 OrgGroupID, out List<InvOrgGroup> lstInvOrgGroup)
        {
            long returnCode = -1;
            lstInvOrgGroup = new List<InvOrgGroup>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.GetInvComputationRuleByGroup(OrgID, OrgGroupID, out lstInvOrgGroup);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvComputationRuleByGroup in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long UpdateInvComputationRuleByGroup(Int32 OrgGroupID, String pValidationText, String pValidationRule)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.UpdateInvComputationRuleByGroup(OrgGroupID, pValidationText, pValidationRule);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateInvComputationRuleByGroup in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long CancelInvestigationSample(int pOrgID, long pVisitID, int pSampleID, long pUserID)
        {
            long returncode = -1;
            try
            {
                Investigation_DAL idal = new Investigation_DAL(globalContextDetails);
                returncode = idal.CancelInvestigationSample(pOrgID, pVisitID, pSampleID, pUserID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CancelInvestigationSample in Investigation_BL", ex);
            }
            return returncode;
        }
        public long SaveRetestDetails(List<OrderedInvestigations> OrderedInves, long OrgID)
        {
            long retCode = -1;
            //AffectedrowCount = 0;
            // DataTable invs = new DataTable();
            if (OrderedInves[0].LabNo.ToString() != null & OrderedInves[0].LabNo.ToString() != "" & OrderedInves[0].LabNo != "")
            {
                // invs = GetOrdInvDataTable1(OrderedInves);
            }
            else
            {
                // invs = GetOrdInvDataTable(OrderedInves);
            }
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SaveRetestDetails(OrderedInves, OrgID);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveRetestDetails in Investigation_BL", e);
            }
            return retCode;
        }
        public long PatientInvSampleAliquot(int pOrgID, long pVisitID, int pSampleID, string pBarcodeNumber, int layer, string samples, string slidevalues)
        {
            long returncode = -1;
            try
            {
                Investigation_DAL idal = new Investigation_DAL(globalContextDetails);
                returncode = idal.PatientInvSamplealiquot(pOrgID, pVisitID, pSampleID, pBarcodeNumber, layer, samples, slidevalues);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PatientInvSampleAliquot in Investigation_BL", ex);
            }
            return returncode;
        }
        public long PatientInvSampleAliquot_BlockSlide(int pOrgID, long pVisitID, int pSampleID, string pBarcodeNumber, int layer, string samples, string slidevalues)
        {
            long returncode = -1;
            try
            {
                Investigation_DAL idal = new Investigation_DAL(globalContextDetails);
                returncode = idal.PatientInvSampleAliquot_BlockSlide(pOrgID, pVisitID, pSampleID, pBarcodeNumber, layer, samples, slidevalues);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PatientInvSampleAliquot_BlockSlide in Investigation_BL", ex);
            }
            return returncode;
        }
        public long pgetPatientInvSampleAliquot(int pOrgID, long pVisitID, int pSampleID, string pBarcodeNumber, int return_Status)
        {
            long returncode = -1;

            try
            {
                Investigation_DAL idal = new Investigation_DAL(globalContextDetails);
                returncode = idal.pgetPatientInvSampleAliquot(pOrgID, pVisitID, pSampleID, pBarcodeNumber, return_Status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pgetPatientInvSampleAliquot in Investigation_BL", ex);
            }
            return returncode;
        }
        public long pgetPatientlayerAliquot(int pOrgID, long pVisitID, int pSampleID, string pBarcodeNumber, int return_Status)
        {
            long returncode = -1;

            try
            {
                Investigation_DAL idal = new Investigation_DAL(globalContextDetails);
                returncode = idal.pgetPatientlayerAliquot(pOrgID, pVisitID, pSampleID, pBarcodeNumber, return_Status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pgetPatientlayerAliquot in Investigation_BL", ex);
            }
            return returncode;
        }




        public long InvSaveDefProcCentre(string ColCentreList, string ProcCentreList, long InvestigationID, string strAllInvestigations)
        {
            long returncode = -1;

            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returncode = InvDAL.InvSaveDefProcCentre(ColCentreList, ProcCentreList, InvestigationID, strAllInvestigations);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InvSaveDefProcCentre in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetOutSourceInvestigations(int OrgID, long LocationID, out List<InvestigationMaster> lstOutSourceInvestigations)
        {
            lstOutSourceInvestigations = null;
            long returnCode = -1;
            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetOutSourceInvestigations(OrgID, LocationID, out lstOutSourceInvestigations);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOutSourceInvestigations in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long ReorderInvestigation(List<OrderedInvestigations> OrderedInves, long OrgID, string LabNo)
        {
            long retCode = -1;
            //AffectedrowCount = 0;
            DataTable invs = new DataTable();
            if (OrderedInves[0].LabNo.ToString() != null & OrderedInves[0].LabNo.ToString() != "" & OrderedInves[0].LabNo != "")
            {
                // invs = GetOrdInvDataTable1(OrderedInves);
            }
            else
            {
                // invs = GetOrdInvDataTable(OrderedInves);
            }
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.ReorderInvestigation(invs, OrgID, LabNo);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveOrderedInvestigationHOS in Investigation_BL", e);
            }
            return retCode;
        }
        public long GetAliquotBarcode(string guid, long InvestigationID, long patientVisitID, int orgID, int GroupID, out List<PatientInvSampleAliquot> lstPatientInvSampleAliquot)
        {
            long result = -1;
            lstPatientInvSampleAliquot = new List<PatientInvSampleAliquot>();
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetAliquotBarcode(guid, InvestigationID, patientVisitID, orgID, GroupID, out lstPatientInvSampleAliquot);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAliquotBarcode in Investigation_BL", ex);
            }
            return result;
        }

        public long GetInvMappedLocations(long InvestigationID, out List<InvestigationLocationMapping> lstInvMappedLocation)
        {
            lstInvMappedLocation = null;
            long returnCode = -1;
            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetInvMappedLocations(InvestigationID, out lstInvMappedLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvMappedLocations in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientDetailsForRetest(int OrgID, string FromDate, string ToDate, long PatientID, string BillNumber, long ClientID, long LocationID, string Priority, string TestType, out List<InvestigationQueue> lstRetestPatients)
        {
            long returncode = -1;
            lstRetestPatients = new List<InvestigationQueue>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetPatientDetailsForRetest(OrgID, FromDate, ToDate, PatientID, BillNumber, ClientID, LocationID, Priority, TestType, out lstRetestPatients);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<InvestigationQueue> lsttempDetails = new List<InvestigationQueue>();
                lsttempDetails = lstRetestPatients.FindAll(p => p.PatientStatus == "VIP");
                lstRetestPatients.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returncode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (InvestigationQueue)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returncode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (InvestigationQueue)Maskedobj;
                    lstRetestPatients.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientDetailsForRetest in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetAbberantQueue(int OrgID, string FromDate, string ToDate, int LocationID, long pClientID, out List<AbberantQueue> lstAbberantQueue)
        {
            long returncode = -1;
            lstAbberantQueue = new List<AbberantQueue>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetAbberantQueue(OrgID, FromDate, ToDate, LocationID, pClientID, out lstAbberantQueue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQuickInvSamplesStatus in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetInvReportTemplateList(out List<InvReportMaster> lstInvReportMaster, out List<InvReportMapping> lstInvReportMapping)
        {
            lstInvReportMaster = new List<InvReportMaster>();
            lstInvReportMapping = new List<InvReportMapping>();
            long returnCode = -1;
            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetInvReportTemplateList(out lstInvReportMaster, out lstInvReportMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvReportTemplateList in Investigation_BL", ex);
            }
            return returnCode;
        }


        public long GetReportTemplateMaster(List<InvReportMaster> lstReportTemplateMasterIn, out List<InvReportMaster> lstReportTemplateMasterOut, string strAction, out string DuplicateDefault)
        {
            lstReportTemplateMasterOut = new List<InvReportMaster>();
            long returnCode = -1;
            DuplicateDefault = "";
            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.GetReportTemplateMaster(lstReportTemplateMasterIn, out lstReportTemplateMasterOut, strAction, out DuplicateDefault);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetReportTemplateMaster in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long SaveReportTemplateMaster(List<InvReportMaster> lstReportTemplateMasterIn, string strAction, out string DuplicateDefault)
        {
            //lstReportTemplateMasterIn = new List<InvReportMaster>();
            long returnCode = -1;
            DuplicateDefault = "";
            try
            {
                Investigation_DAL invesDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invesDAL.SaveReportTemplateMaster(lstReportTemplateMasterIn, strAction, out DuplicateDefault);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveReportTemplateMaster in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetDeptToTrackSamplesForQucikBill(long PatientVisitID, int OrgID, long roleID, string gUID, out List<PatientInvestigation> lstSampleDept)
        {
            long returncode = -1;
            lstSampleDept = new List<PatientInvestigation>();

            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetDeptToTrackSamplesForQucikBill(PatientVisitID, OrgID, roleID, gUID, out lstSampleDept);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeptToTrackSamples in Investigation_BL", ex);
            }
            return returncode;
        }

        public long InsertRejectedSample(long PatientVisitID, int SampleID, int InvStatusID, string InvReason, long CreatedBy, long AccessionNo)
        {
            long retCode = -1;
            try
            {
                retCode = new Investigation_DAL(globalContextDetails).InsertRejectedSample(PatientVisitID, SampleID, InvStatusID, InvReason, CreatedBy, AccessionNo);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing InsertRejectedSample in Investigation_BL", e);
            }
            return retCode;

        }
        public long GetInvstatusForDropdowns(int OrgID, long taskid, out List<InvestigationStatus> lstStatus)
        {
            long returncode = -1;
            lstStatus = new List<InvestigationStatus>();

            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvstatusForDropdowns(OrgID, taskid, out lstStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvstatusForDropdowns in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetCollectSampleDropDownValues(Int32 OrgID, String PageType, out List<InvSampleStatusmaster> lstInvSampleStatus, out List<InvReasonMasters> lstInvReasonMaster, out List<OrganizationAddress> lstLocation, out List<LabRefOrgAddress> lstOutsource)
        {
            long returnCode = -1;
            lstInvSampleStatus = new List<InvSampleStatusmaster>();
            lstInvReasonMaster = new List<InvReasonMasters>();
            lstLocation = new List<OrganizationAddress>();
            lstOutsource = new List<LabRefOrgAddress>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetCollectSampleDropDownValues(OrgID, PageType, out lstInvSampleStatus, out lstInvReasonMaster, out lstLocation, out lstOutsource);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCollectSampleDropDownValues in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetInvreportFooter(int OrgID, long InvestigationID, out List<InvReportTemplateFooter> lstInvReportFoot)
        {
            long returncode = -1;
            lstInvReportFoot = new List<InvReportTemplateFooter>();

            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvreportFooter(OrgID, InvestigationID, out lstInvReportFoot);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvreportFooter in Investigation_BL", ex);
            }
            return returncode;
        }

        public long GetExpectantSampleQueue(int OrgID, long RoleID, int LocationID, string FromDate, string ToDate, out List<AbberantQueue> lstExpectantQueue)
        {
            long returncode = -1;
            lstExpectantQueue = new List<AbberantQueue>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetExpectantSampleQueue(OrgID, RoleID, LocationID, FromDate, ToDate, out lstExpectantQueue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetExpectantSampleQueue in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetSummaryReportConfig(Int32 OrgID, Int64 VisitID, out List<InvSummaryReport> lstInvSummaryReport, out List<InvSummaryTrend> lstInvSummaryTrend, out List<InvestigationMaster> lstTrendInvestigations)
        {
            long returnCode = -1;
            lstInvSummaryReport = new List<InvSummaryReport>();
            lstInvSummaryTrend = new List<InvSummaryTrend>();
            lstTrendInvestigations = new List<InvestigationMaster>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetSummaryReportConfig(OrgID, VisitID, out lstInvSummaryReport, out lstInvSummaryTrend, out lstTrendInvestigations);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSummaryReportConfig in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long SaveInvSummaryReport(Int32 pOrgID, Int64 pVisitID, Int64 pLoginID, InvSummaryReport invSummaryReport, List<InvSummaryTrend> lstInvSummaryTrend)
        {
            long returnCode = -1;
            Investigation_DAL objInvDAL = null;
            try
            {
                //DataTable dtInvSummaryReport, dtInvSummaryTrend = new DataTable();
                //returnCode = this.GetInvSummaryReportDataTable(invSummaryReport, lstInvSummaryTrend, out dtInvSummaryReport, out dtInvSummaryTrend);
                if (returnCode == 0)
                {
                    objInvDAL = new Investigation_DAL(globalContextDetails);
                    returnCode = objInvDAL.SaveInvSummaryReport(pOrgID, pVisitID, pLoginID, invSummaryReport, lstInvSummaryTrend);
                }
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while executing SaveInvSummaryReport in Investigation_BL", ex);
                throw ex;
            }

            return returnCode;
        }
        private long GetInvSummaryReportDataTable(InvSummaryReport invSummaryReport, List<InvSummaryTrend> lstInvSummaryTrend, out DataTable dtInvSummaryReport, out DataTable dtInvSummaryTrend)
        {
            long returnCode = -1;
            dtInvSummaryReport = new DataTable();
            dtInvSummaryTrend = new DataTable();
            DataRow dr, dr1;
            try
            {
                dtInvSummaryReport.Columns.Add("ResultSummary", typeof(System.String));
                dtInvSummaryReport.Columns.Add("ClinicalInterpretation", typeof(System.String));
                dtInvSummaryReport.Columns.Add("Suggestions", typeof(System.String));
                dtInvSummaryReport.Columns.Add("Comments", typeof(System.String));
                dtInvSummaryReport.Columns.Add("ShowTRF", typeof(System.Boolean));
                dtInvSummaryReport.Columns.Add("OrgID", typeof(System.Int32));
                dtInvSummaryReport.Columns.Add("VisitID", typeof(System.Int64));

                dr = dtInvSummaryReport.NewRow();
                dr["ResultSummary"] = invSummaryReport.ResultSummary;
                dr["ClinicalInterpretation"] = invSummaryReport.ClinicalInterpretation;
                dr["Suggestions"] = invSummaryReport.Suggestions;
                dr["Comments"] = invSummaryReport.Comments;
                dr["ShowTRF"] = invSummaryReport.ShowTRF;
                dr["OrgID"] = invSummaryReport.OrgID;
                dr["VisitID"] = invSummaryReport.VisitID;

                dtInvSummaryReport.Rows.Add(dr);

                dtInvSummaryTrend.Columns.Add("TrendInvId", typeof(System.String));
                dtInvSummaryTrend.Columns.Add("Content", typeof(System.Byte[]));

                foreach (InvSummaryTrend oInvSummaryTrend in lstInvSummaryTrend)
                {
                    dr1 = dtInvSummaryTrend.NewRow();
                    dr1["TrendInvId"] = oInvSummaryTrend.TrendInvId;
                    dr1["Content"] = oInvSummaryTrend.Content;

                    dtInvSummaryTrend.Rows.Add(dr1);
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                returnCode = -1;
                throw ex;
            }
            return returnCode;
        }
        public long GetInvSuggested(Int32 OrgID, String SearchText, out List<InvestigationMaster> lstInvMaster)
        {
            long returnCode = -1;
            lstInvMaster = new List<InvestigationMaster>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetInvSuggested(OrgID, SearchText, out lstInvMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvSuggested in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetComplaints(Int32 OrgID, String SearchText, out List<Complaint> lstComplaint)
        {
            long returnCode = -1;
            lstComplaint = new List<Complaint>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetComplaints(OrgID, SearchText, out lstComplaint);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetComplaints in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long CheckInvSummaryReport(Int32 OrgID, Int64 VisitID, out List<InvReportMaster> lstInvReportMaster, out Int32 pRecordCount, out bool pShowTRF)
        {
            long returnCode = -1;
            lstInvReportMaster = new List<InvReportMaster>();
            pRecordCount = 0;
            pShowTRF = false;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).CheckInvSummaryReport(OrgID, VisitID, out lstInvReportMaster, out pRecordCount, out pShowTRF);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CheckInvSummaryReport in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientDeltaValues(Int64 pVisitID, Int32 pOrgID, Int64 pPatternID, Int64 pInvID, out List<InvestigationValues> lstPatientDeltaValues)
        {
            long returnCode = -1;
            lstPatientDeltaValues = new List<InvestigationValues>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetPatientDeltaValues(pVisitID, pOrgID, pPatternID, pInvID, out lstPatientDeltaValues);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientDeltaValues in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long getSuggedtedInvestigations(Int64 pVisitID, Int32 pOrgID, out List<OrderedPatientInvs> lstOrderedPatientInvs, out List<InvValueRangeMaster> lstInvValueRangeMaster, out List<SuggestedInvMapping> lstSuggestedInvMapping)
        {
            long returnCode = -1;
            lstOrderedPatientInvs = new List<OrderedPatientInvs>();
            lstInvValueRangeMaster = new List<InvValueRangeMaster>();
            lstSuggestedInvMapping = new List<SuggestedInvMapping>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).getSuggedtedInvestigations(pVisitID, pOrgID, out lstOrderedPatientInvs, out lstInvValueRangeMaster, out lstSuggestedInvMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getSuggedtedInvestigations in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetSummaryReportTemplate(Int32 OrgID, String TemplateType, String SearchText, out List<InvResultTemplate> lstInvResultTemplate)
        {
            long returnCode = -1;
            lstInvResultTemplate = new List<InvResultTemplate>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetSummaryReportTemplate(OrgID, TemplateType, SearchText, out lstInvResultTemplate);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSummaryReportTemplate in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long SaveOutSourcingDetails(Int32 OrgID, long CreatedBy, List<OutsourcingDetail> lstOutSourcingDetails, string OutsourcedDateTime, string ReceivedDateTime, string CourierDetails, string Acknowledgement, string Status)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).SaveOutSourcingDetails(OrgID, CreatedBy, lstOutSourcingDetails, OutsourcedDateTime, ReceivedDateTime, CourierDetails, Acknowledgement, Status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveOutSourcingDetails in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long SaveCollectedDateTimeDetails(long VisitID, long SampleId, DateTime NewCollectedDateTime, string slidevalues, string BarcodeNumber)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).SaveCollectedDateTimeDetails(VisitID, SampleId, NewCollectedDateTime, slidevalues, BarcodeNumber);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveCollectedDateTimeDetails in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetOutSourcingDetails(Int32 OrgID, long SampleId, long PatientVisitId, long SampleTrackerID, string pGuid, out List<OutsourcingDetail> lstOutsourcingDetail)
        {
            long returnCode = -1;
            lstOutsourcingDetail = new List<OutsourcingDetail>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetOutSourcingDetails(OrgID, SampleId, PatientVisitId, SampleTrackerID, pGuid, out lstOutsourcingDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOutSourcingDetails in Investigation_BL", ex);
            }
            return returnCode;
        }

        //InvRemarks
        public long GetInvRemarks(long pInvID, int pOrgID, string pType, string pSearchText, long pRoleID, string pRemarksType, out List<Remarks> lstRemarks)
        {
            lstRemarks = new List<Remarks>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetInvRemarks(pInvID, pOrgID, pType, pSearchText, pRoleID, pRemarksType, out lstRemarks);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetInvRemarks in Investigation_BL", excp);
            }

            return returnCode;
        }
        //InvRemarks

        public long GetTestMasterDetails(Int32 pOrgID, Int64 pInvID, String pType, out List<TestMaster> lstTestMasterDetails, out List<CodingScheme> lstCodingScheme, out List<Remarks> lstInvRemarks, out List<InvOrgReferenceMapping> lstInvOrgReferenceMapping, out List<InvValueRangeMaster> lstInvValueRangeMaster, out List<InvOrgNotifications> lstInvOrgNotifications, out List<InvOrgAuthorization> lstCoAuth, out List<InvestigationBulkData> lstInvBulkData, out List<InvInstrumentMaster> lstInstrumentMaster, out List<InvestigationLocationMapping> lstLocationMapping, out List<InvDeltaCheck> objInvDeltaCheck, out List<InvValueRangeMaster> lstCrossparametertest,
            out List<InvAutoCertifyValidation> lstInvAutoCertify)
        {
            long returnCode = -1;
            lstTestMasterDetails = new List<TestMaster>();
            lstCodingScheme = new List<CodingScheme>();
            lstInvRemarks = new List<Remarks>();
            lstInvOrgReferenceMapping = new List<InvOrgReferenceMapping>();
            lstInvValueRangeMaster = new List<InvValueRangeMaster>();
            lstInvOrgNotifications = new List<InvOrgNotifications>();
            lstCoAuth = new List<InvOrgAuthorization>();
            lstInvBulkData = new List<InvestigationBulkData>();
            lstInstrumentMaster = new List<InvInstrumentMaster>();
            lstLocationMapping = new List<InvestigationLocationMapping>();
            objInvDeltaCheck = new List<InvDeltaCheck>();
            lstCrossparametertest = new List<InvValueRangeMaster>();
            lstInvAutoCertify = new List<InvAutoCertifyValidation>();

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetTestMasterDetails(pOrgID, pInvID, pType, out lstTestMasterDetails, out lstCodingScheme, out lstInvRemarks, out lstInvOrgReferenceMapping, out lstInvValueRangeMaster, out lstInvOrgNotifications, out lstCoAuth, out lstInvBulkData, out lstInstrumentMaster, out lstLocationMapping, out objInvDeltaCheck, out lstCrossparametertest,out lstInvAutoCertify);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetTestMasterDetails in Investigation_BL", ex);
            }
            return returnCode;
        }


        public long GetTestProcessingLocation(Int32 pOrgID, string pType, out List<OrganizationAddress> lstProcessingLocation)
        {
            long returnCode = -1;
            lstProcessingLocation = new List<OrganizationAddress>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetTestProcessingLocation(pOrgID, pType, out lstProcessingLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetTestProcessingLocation in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetTestProcessingOrgName(int OrgID, string pType, out List<Organization> lstOrgName)
        {
            long returnCode = -1;
            lstOrgName = new List<Organization>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetTestProcessingOrgName(OrgID, pType, out lstOrgName);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetTestProcessingOrgName in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long SaveTestMasterDetails(TestMaster oTestMaster, List<InvRemarks> lstInvRemarks, List<InvOrgReferenceMapping> lstInvOrgReferenceMapping, InvestigationLocationMapping oInvestigationLocationMapping, Int32 pOrgID, Int64 pInvID, String pType, Int64 pLoginID, List<InvValueRangeMaster> lstInvValueRangeMaster, List<InvOrgNotifications> lstInvOrgNotifications, List<InvOrgAuthorization> lstCoAuth, List<InvestigationLocationMapping> lstInvLocation, string Reason, List<BulkReferenceRange> InvReferenceRR, InvDeltaCheck oInvDeltaCheck, List<InvValueRangeMaster> lstInvCrossparameterTest
            , List<InvAutoCertifyValidation> lstInvAutoCertify)
        {
            long returnCode = -1;
            Investigation_DAL objInvDAL = null;
            try
            {
                //DataTable dtTestMaster = new DataTable();
                //DataTable dtInvRemarks = new DataTable();
                //DataTable dtInvOrgReferenceMapping = new DataTable();
                //DataTable dtInvestigationLocationMapping = new DataTable();
                //returnCode = this.GetTestMasterDataTable(oTestMaster, lstInvRemarks, lstInvOrgReferenceMapping, 
                //    oInvestigationLocationMapping, out dtTestMaster, out dtInvRemarks, out dtInvOrgReferenceMapping,
                //    out dtInvestigationLocationMapping);
                //if (returnCode == 0)
                //{
                objInvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = objInvDAL.SaveTestMasterDetails(oTestMaster, lstInvRemarks, lstInvOrgReferenceMapping,
                    oInvestigationLocationMapping, pOrgID, pInvID, pType, pLoginID, lstInvValueRangeMaster, lstInvOrgNotifications, lstCoAuth, lstInvLocation, Reason, InvReferenceRR,
                    oInvDeltaCheck, lstInvCrossparameterTest, lstInvAutoCertify);
                //}
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while executing SaveTestMasterDetails in Investigation_BL", ex);
                throw ex;
            }

            return returnCode;
        }
        public long GetDispatchReports(int OrgID, string FromDate, string ToDate, int LocationID, long Roleid, out List<AbberantQueue> lstAbberantQueue)
        {
            long returncode = -1;
            lstAbberantQueue = new List<AbberantQueue>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetDispatchReports(OrgID, FromDate, ToDate, LocationID, Roleid, out lstAbberantQueue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDispatchReports in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetDespatchPatientReport(int statusid, string FromDate, string ToDate, int orgid, out List<PatientVisit> lstpatientvisit)
        {
            long returncode = -1;
            lstpatientvisit = new List<PatientVisit>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetDespatchPatientReport(statusid, FromDate, ToDate, orgid, out lstpatientvisit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDespatchPatientReport in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetDeptToTrackSamplesWithID(List<OrderedInvestigations> OrderedInves, long InvID, string Type, int OrgID, out List<PatientInvSample> lstPatientInvSample)
        {
            long returncode = -1;

            lstPatientInvSample = new List<PatientInvSample>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetDeptToTrackSamplesWithID(OrderedInves, InvID, Type, OrgID, out lstPatientInvSample);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeptToTrackSamples in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetBatchWiseInvestigationResultsCaptureFormat(string VIDs, int OrgID, string BarcodeNumber, long RoleID, long DeptID, long InvID, string InvType, LoginDetail LDetail,
            string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalID, string pActionName, string pIsMaster, int pRecordCount, int ClientID,
            out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetBatchWiseInvestigationResultsCaptureFormat(VIDs, OrgID, BarcodeNumber, RoleID, DeptID, InvID, InvType, LDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalID, pActionName, pIsMaster, pRecordCount, ClientID, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseInvestigationResultsCaptureFormat in Investigation_BL", ex);
            }
            return result;
        }
        public long GetOrderedPatientInvestigations(string Name, long orgid, out List<PatientInvestigation> lstOrdPinv)
        {
            lstOrdPinv = new List<PatientInvestigation>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetOrderedPatientInvestigations(Name, orgid, out lstOrdPinv);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetOrderedPatientInvestigations in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long GetOrgGroups(string Name, int orgid, out List<InvOrgGroup> lstOrdPinv)
        {
            lstOrdPinv = new List<InvOrgGroup>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetOrgGroups(Name, orgid, out lstOrdPinv);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetOrgGroups in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long GetBatchWiseInvBulkData(PatientInvestigation oInve, int orgID, string pActionName, out List<InvestigationValues> lstBulkData
       , out List<InvestigationValues> lstPendingValue, out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom)
        {
            long result = -1;
            List<PatientInvestigation> lstInve = new List<PatientInvestigation>();
            lstInve.Add(oInve);


            lstBulkData = new List<InvestigationValues>();
            lstPendingValue = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetBatchWiseInvBulkData(lstInve, orgID, pActionName, out lstBulkData, out lstPendingValue, out header, out  lstiom);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvBulkData in Investigation_BL", ex);
            }
            return result;
        }
        public long BatchWiseSaveInvestigationResults(long pSCMID, List<List<InvestigationValues>> lstInvestigationValues, List<PatientInvestigation> lstInvestigation, List<PatientInvSampleResults> lstPatientInvSampleResults, List<PatientInvSampleMapping> lstPatientInvSampleMapping, List<PatientInvestigationFiles> lPfiles, long vid, int OrgID, int deptID, long ApprovadBy, string gUID, PageContextkey PageContextDetails, out int returnStatus)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {

                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.BatchWiseSaveInvestigationResults(pSCMID, lstInvestigationValues, lstInvestigation, lstPatientInvSampleResults, lstPatientInvSampleMapping, lPfiles, vid, OrgID, deptID, ApprovadBy, gUID, out returnStatus);
                if (returnStatus >= 0)
                {
                    List<PatientInvestigation> lstNonApprovedInvestigation = lstInvestigation.FindAll(P => P.Status != InvStatus.Approved);
                    if (lstNonApprovedInvestigation != null && lstNonApprovedInvestigation.Count == 0)
                    {
                        ActionManager objActionManager = new ActionManager();
                        objActionManager.PerformingNextStep(PageContextDetails);
                    }
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvestigationResults in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long DeleteInvOrgRefMapping(long InvRefMappingID, long DeviceMappingID, long InvID, int OrgID)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL oInvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvDAL.DeleteInvOrgRefMapping(InvRefMappingID, DeviceMappingID, InvID, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteInvOrgRefMapping in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetOrgInstruments(int OrgID, out List<InvInstrumentMaster> lstInstrument)
        {
            long returnCode = -1;
            lstInstrument = new List<InvInstrumentMaster>();
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.GetOrgInstruments(OrgID, out lstInstrument);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetOrgInstruments in Investigation_BL", excp);
            }
            return returnCode;
        }

        public long GetBatchWiseWorklist(int ClientID, string WorkListType, long SearchID, int OrgID, string WLMode, string fromDate, string toDate, string TestType, long MinVistId, long MaxVisitId, string PendingDays, string TestStatus, out string Delaydays, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            Delaydays = "";
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.GetBatchWiseWorklist(ClientID, WorkListType, SearchID, OrgID, WLMode, fromDate, toDate, TestType, MinVistId, MaxVisitId, PendingDays, TestStatus, out Delaydays, out lstPatientInvestigation);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetBatchWiseWorklist in Investigation_BL", excp);
            }
            return returnCode;
        }
        public long GetWorkListIds(string WLID, int OrgID, out List<PatientInvestigation> lstWorkListId)
        {
            long returnCode = -1;
            lstWorkListId = new List<PatientInvestigation>();
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.GetWorkListIds(WLID, OrgID, out lstWorkListId);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetWorkListIds in Investigation_BL", excp);
            }
            return returnCode;
        }
        public long UpdatePatientInvestigationStatusinLab(List<PatientInvestigation> lstPatientInvestigation, out int upIS)
        {
            long returncode = -1;
            upIS = -1;
            try
            {
                Investigation_DAL idal = new Investigation_DAL(globalContextDetails);
                returncode = idal.UpdatePatientInvestigationStatusinLab(lstPatientInvestigation, out upIS);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdatePatientInvestigationStatusinLab in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetSampleDetails(int SampleID, long VisitID, int OrgID, string gUID, out PatientInvSample OPatientInvSample)
        {
            long returncode = -1;
            OPatientInvSample = new PatientInvSample();
            try
            {
                Investigation_DAL idal = new Investigation_DAL(globalContextDetails);
                returncode = idal.GetSampleDetails(SampleID, VisitID, OrgID, gUID, out OPatientInvSample);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSampleDetails in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetDrawPatternInvBulkData(string guid, List<InvPackageMapping> lstInvPackageMapping, long patientVisitID, int orgID, string status,
                 out List<InvestigationValues> lstBulkData
            , out List<InvestigationValues> lstPendingValue, out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom, out List<PerformingPhysician> lPerformingPhysicain)
        {
            long result = -1;
            lstBulkData = new List<InvestigationValues>();
            lstPendingValue = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();
            lPerformingPhysicain = new List<PerformingPhysician>();
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetDrawPatternInvBulkData(guid, lstInvPackageMapping, patientVisitID, orgID, status, out lstBulkData, out lstPendingValue, out header, out  lstiom, out lPerformingPhysicain);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvBulkData in Investigation_BL", ex);
            }
            return result;
        }
        public long GetHealthPackageDataName(int orgid, string packagename, string Pkgcode, out List<InvOrgGroup> lstPackages, out List<InvOrgGroup> lstorggroup)
        {
            long reurncode = 0;
            lstPackages = new List<InvOrgGroup>();
            lstorggroup = new List<InvOrgGroup>();
            try
            {
                Investigation_DAL investigationDAL = new Investigation_DAL();
                reurncode = investigationDAL.GetHealthPackageDataName(orgid, packagename, Pkgcode, out lstPackages, out lstorggroup);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing GetHealthPackageDataName in Investigation_BL", ex);
            }
            return reurncode;
        }


        public long Updatepackages(InvOrgGroup objorgrouppackages, DataTable dtCodingSchemeMaster, int CutOffTimeValue, string CutOffTimeType, string SubCategory, short ScheduleType)
        {
            long returncode = 0;
            try
            {
                Investigation_DAL investigationDAL = new Investigation_DAL();
                returncode = investigationDAL.Updatepackages(objorgrouppackages, dtCodingSchemeMaster, CutOffTimeValue, CutOffTimeType, SubCategory, ScheduleType);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing Updatepackages in Investigation_BL", ex);
            }
            return returncode;
        }


        public long GetHealthPackageDataSearch(int Orgid, string Groupname, int pkgid, out List<InvGroupMaster> lstPackages, out List<InvPackageMapping> lstPackageMapping, out List<PatientInvestigation> lstPackageContents, out List<GeneralHealthCheckUpMaster> lstGeneralHealthCheckUpMaster)
        {
            long returncode = 0;
            lstPackages = new List<InvGroupMaster>();
            lstPackageMapping = new List<InvPackageMapping>();
            lstPackageContents = new List<PatientInvestigation>();
            lstGeneralHealthCheckUpMaster = new List<GeneralHealthCheckUpMaster>();
            try
            {
                Investigation_DAL investigationDAL = new Investigation_DAL(globalContextDetails);
                returncode = investigationDAL.GetHealthPackageDataSearch(Orgid, Groupname, pkgid, out lstPackages, out lstPackageMapping, out lstPackageContents, out lstGeneralHealthCheckUpMaster);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing GetHealthPackageDataSearch in Investigation_BL", ex);
            }
            return returncode;
        }
        public long Getpackagesearch(int OrgID, int pkgid, string status, out List<InvOrgGroup> lstpackages, int pageSize, int StartRowIndex, out int totalRows, string packagename, string Remarks, string pkgcode)
        {
            long returnCode = -1;
            totalRows = 0;
            lstpackages = new List<InvOrgGroup>();
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL();
                returnCode = InvestigationDAL.GetSearchPackage(OrgID, pkgid, status, out lstpackages, pageSize, StartRowIndex, out totalRows, packagename, Remarks, pkgcode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationRates in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long GetDeviceValue(int PorgID, long PvisitID, long pinvID, string pguID, out List<InvestigationValues> lstDeviceValue)
        {
            long lresult = -1;
            lstDeviceValue = new List<InvestigationValues>();
            try
            {
                Investigation_DAL IDAL = new Investigation_DAL();
                lresult = IDAL.GetDeviceValue(PorgID, PvisitID, pinvID, pguID, out lstDeviceValue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeviceValue in Investigation_BL", ex);
            }
            return lresult;

        }
        public long GetInvestigationBulkData(Int64 invId, String name, String searchText, out List<InvestigationBulkData> lstInvBulkData)
        {
            long returnCode = -1;
            lstInvBulkData = new List<InvestigationBulkData>();
            try
            {
                Investigation_DAL IDAL = new Investigation_DAL();
                returnCode = IDAL.GetInvestigationBulkData(invId, name, searchText, out lstInvBulkData);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationBulkData in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvSampleMasterTransfer(string Name, int orgid, out List<InvSampleMaster> lstInvSampleMaster)
        {
            lstInvSampleMaster = new List<InvSampleMaster>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetInvSampleMasterTransfer(Name, orgid, out lstInvSampleMaster);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetInvSampleMasterTransfer in IntegrationBL", excp);
            }

            return returnCode;
        }

        public long GetInvClient(string Name, int orgid, out List<ClientMaster> lstClientMaster)
        {
            lstClientMaster = new List<ClientMaster>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetInvClient(Name, orgid, out lstClientMaster);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetInvClient in IntegrationBL", excp);
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
                CLogger.LogError("Error while executing UpdateSampleTransfer in Investigation_BL", e);
            }
            return retCode;
        }

        public long UpdateoneSampleTransfer(List<PatientInvSample> lstPatientInvSample)
        {
            long retCode = -1;
            //DataTable invPMDT = GetInvPackageMappingDataTable(lstInvPackageMapping);
            //DataTable inv = GetInvPackage(lstDeletedPackageMapping);
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.UpdateoneSampleTransfer(lstPatientInvSample);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateSampleTransfer in Investigation_BL", e);
            }
            return retCode;
        }
        public long GetTransferInvestionStatus(int OrgID, out List<InvestigationStatus> lstInvestigationStatus, out List<LabReferenceOrg> lstLabReferenceOrg)
        {
            long returncode = -1;
            lstInvestigationStatus = new List<InvestigationStatus>();
            lstLabReferenceOrg = new List<LabReferenceOrg>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetTransferInvestionStatus(OrgID, out lstInvestigationStatus, out lstLabReferenceOrg);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetTransferInvestionStatus in IntegrationBL", ex);
            }
            return returncode;
        }


        public long GetInvSamplesTransferStatus(int OrgID, string FromDate, string ToDate, int Status, int LocationID, string LocationType, string VisitID,
      string PatientName, int VisitType, int Priority, string SourceName, string InvestigationName, long InvestigationID, string InvestigationType,
      string refPhyName, long refPhyID, long refPhyOrg, long SampleID, int SearchType,
      out List<CollectedSample> lstSamples, int pagesize, int startrowindex, out int totalrows, int SmpleID, int ProcessedLocID, int OutSourceID, string BarcodeNo,
            int ContainerID, int proLocation, int Locationn, long CollectedID)
        {
            long returncode = -1;
            totalrows = -1;
            lstSamples = new List<CollectedSample>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvSamplesTransferStatus(OrgID, FromDate, ToDate, Status, LocationID, LocationType, VisitID,
            PatientName, VisitType, Priority, SourceName, InvestigationName, InvestigationID, InvestigationType,
            refPhyName, refPhyID, refPhyOrg, SampleID, SearchType, out lstSamples, pagesize, startrowindex, out totalrows, SmpleID, ProcessedLocID, OutSourceID, BarcodeNo, ContainerID, proLocation, Locationn, CollectedID);

                /*-----------------Handle VIP Data Start-------------------------*/
                List<CollectedSample> lsttempDetails = new List<CollectedSample>();
                lsttempDetails = lstSamples.FindAll(P => P.PatientStatus == "VIP");
                lstSamples.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returncode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (CollectedSample)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returncode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (CollectedSample)Maskedobj;
                    lstSamples.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvSamplesTransferStatus in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetInvoneSamplesTransferStatus(int OrgID, string FromDate, string ToDate, int Status, int LocationID, string LocationType, string VisitID,
      string PatientName, int VisitType, int Priority, string SourceName, string InvestigationName, long InvestigationID, string InvestigationType,
      string refPhyName, long refPhyID, long refPhyOrg, long SampleID, int SearchType,
      out List<CollectedSample> lstSamples, int pagesize, int startrowindex, out int totalrows, int SmpleID, int ProcessedLocID, int OutSourceID, string BarcodeNo,
            int ContainerID, int proLocation)
        {
            long returncode = -1;
            totalrows = -1;
            lstSamples = new List<CollectedSample>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvoneSamplesTransferStatus(OrgID, FromDate, ToDate, Status, LocationID, LocationType, VisitID,
            PatientName, VisitType, Priority, SourceName, InvestigationName, InvestigationID, InvestigationType,
            refPhyName, refPhyID, refPhyOrg, SampleID, SearchType, out lstSamples, pagesize, startrowindex, out totalrows, SmpleID, ProcessedLocID, OutSourceID, BarcodeNo, ContainerID, proLocation);

                /*-----------------Handle VIP Data Start-------------------------*/
                List<CollectedSample> lsttempDetails = new List<CollectedSample>();
                lsttempDetails = lstSamples.FindAll(P => P.PatientStatus == "VIP");
                lstSamples.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returncode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (CollectedSample)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returncode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (CollectedSample)Maskedobj;
                    lstSamples.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetInvSamplesTransferStatus", ex);
            }
            return returncode;
        }

        public long GetTimingSpecimenDelails(DateTime fromDate, DateTime toDate, int pageSize, int StartRowIndex, out int totalRows, out List<PatientInvSample> lstInvsampleList)
        {
            totalRows = 0;
            long returncode = -1;
            lstInvsampleList = new List<PatientInvSample>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetTimingSpecimenDelails(fromDate, toDate, pageSize, StartRowIndex, out totalRows, out lstInvsampleList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetinvestigationReport in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetHomeCollectionPatientDetails(long HCDID, string pType, out List<Bookings> lstHomeCollectionDetails)
        {
            long returncode = -1;
            lstHomeCollectionDetails = new List<Bookings>();
            try
            {
                new Investigation_DAL(globalContextDetails).GetHomeCollectionPatientDetails(HCDID, pType, out lstHomeCollectionDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRoleUserLogin in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetSampleContainerName(string Name, int orgid, out List<InvestigationSampleContainer> lstInvestigationSampleContainer)
        {
            lstInvestigationSampleContainer = new List<InvestigationSampleContainer>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetSampleContainerName(Name, orgid, out lstInvestigationSampleContainer);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetSampleContainerName in Investigation_BL", excp);
            }

            return returnCode;
        }

        public long GetInvestigationNameForResult(string Name, long orgid, out List<PatientInvestigation> lstPatientInvestigation)
        {
            lstPatientInvestigation = new List<PatientInvestigation>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetInvestigationNameForResult(Name, orgid, out lstPatientInvestigation);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetInvestigationNameForResult in Investigation_BL", excp);
            }

            return returnCode;
        }

        public long GetDepartmentNameForResult(string Name, long RoleID, long loginID, long OrgID, out List<InvDeptMaster> lstInvDeptMaster)
        {
            lstInvDeptMaster = new List<InvDeptMaster>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetDepartmentNameForResult(Name, RoleID, loginID, OrgID, out lstInvDeptMaster);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetDepartmentNameForResult-DeptMaster in Investigation_BL", excp);
            }

            return returnCode;
        }


        public long GetInvStatus(out List<InvestigationStatus> lstInvestigationStatus, out List<InvestigationStatus> lstInvestigationSampleStatus)
        {
            lstInvestigationStatus = new List<InvestigationStatus>();
            lstInvestigationSampleStatus = new List<InvestigationStatus>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetInvStatus(out lstInvestigationStatus, out lstInvestigationSampleStatus);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetSampleContainerName in Investigation_BL", excp);
            }

            return returnCode;


        }
        public long GetExtraSampleList(long patienid, long SampleCode, int OrgID, out List<PatientInvSample> lstPatientInvSample)
        {
            long returncode = -1;

            lstPatientInvSample = new List<PatientInvSample>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetExtraSampleList(patienid, SampleCode, OrgID, out lstPatientInvSample);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetExtraSampleList in Investigation_BL", ex);
            }
            return returncode;
        }


        public long GetInvStatusSampleResult(long VisitId, long OrgId, int AccessionNumber, out List<InvestigationSampleResult> lstInvestigationSampleResult)
        {
            lstInvestigationSampleResult = new List<InvestigationSampleResult>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetInvStatusSampleResult(VisitId, OrgId, AccessionNumber, out lstInvestigationSampleResult);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetSampleContainerName in Investigation_BL", excp);
            }

            return returnCode;


        }

        public long SavePatientInvSampleNMapping(List<PatientInvSample> LstPinvsample, List<PatientInvSampleMapping> LstPinvsamplemapping, string GUID, int orgid)
        {
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.SavePatientInvSampleNMapping(LstPinvsample, LstPinvsamplemapping, GUID, orgid);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SavePatientInvSampleNMapping in Investigation_BL", excp);
            }

            return returnCode;
        }


        public long GetHomeCollectionDetails(long PatientID, DateTime Fromdate, DateTime Todate, long RoleID,
             long UserID, int CollecOrgID, long CollecOrgAddrID, int LoginOrgID, DateTime BookedFrom, DateTime BookedTo, string Status, string Task,
             out List<Bookings> lstHomeCollectionDetails, string MobileNumber, string TelePhone,
             string pName, int PageSize, int currentPageNo, long BookingNumber, out int totalRows)
        {
            lstHomeCollectionDetails = new List<Bookings>();
            long returnCode = -1;
            totalRows = 0;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetHomeCollectionDetails(PatientID, Fromdate, Todate,
                    RoleID, UserID, CollecOrgID, CollecOrgAddrID, LoginOrgID, BookedFrom, BookedTo, Status, Task,
                    out lstHomeCollectionDetails, MobileNumber, TelePhone, pName, PageSize, currentPageNo, BookingNumber, out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHomeCollectionDetails in Investigation_BL", ex);
            }
            return returnCode;
        }




        public long UpdateInvestigationName(int OrgID, int InvID, string InvName, DataTable dtCodingSchemeMaster, string CodeType, out List<InvestigationMaster> lstInvestigation)
        {
            long returnCode = -1;
            lstInvestigation = new List<InvestigationMaster>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.UpdateInvestigationName(OrgID, InvID, InvName, dtCodingSchemeMaster, CodeType, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing ADDinvestigationName in Investigation_BL", ex);

            }
            return returnCode;


        }

        public long SearchGroups(int OrgID, string GrpName, out List<InvOrgGroup> lstGroups, int pageSize, int StartRowIndex, out int totalRows)
        {
            long returnCode = -1;
            lstGroups = new List<InvOrgGroup>();
            totalRows = 0;
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.SearchGroups(OrgID, GrpName, out lstGroups, pageSize, StartRowIndex, out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchGroups in Investigation_BL", ex);

            }
            return returnCode;


        }

        public long UpdateInvestigationGrpName(int groupid, int OrgID, string groupName, string remarks, string status, string ModifiedBy, DataTable dtCodingSchemeMaster)
        {
            long returncode = 0;
            try
            {
                Investigation_DAL investigationDAL = new Investigation_DAL();
                returncode = investigationDAL.UpdateInvestigationGrpName(groupid, OrgID, groupName, remarks, status, ModifiedBy, dtCodingSchemeMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateInvestigationGrpName in Investigation_BL", ex);
            }
            return returncode;
        }

        public long GetSampleItem(int OrgId, int ID, long visitid, out List<PatientInvSample> lstInvestigationSampleItem)
        {
            lstInvestigationSampleItem = new List<PatientInvSample>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetSampleItem(OrgId, ID, visitid, out lstInvestigationSampleItem);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetSampleContainerName in Investigation_BL", excp);
            }

            return returnCode;


        }
        public long GetReflexTestDetailsbyInvID(long InvID, int OrgID, out List<InvValueRangeMaster> lstInvValueRangeMaster)
        {
            lstInvValueRangeMaster = new List<InvValueRangeMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetReflexTestDetailsbyInvID(InvID, OrgID, out lstInvValueRangeMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetReflexTestDetailsbyInvID in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetPhlebotomistName(string Name, int orgid, String Type, long ZoneID,
           out List<Users> lstUsers, out List<EmployeeRegMaster> lstEmployeeRegMaster, out List<InvClientMaster> lstInvClientMaster, out List<Localities> lstLocalities)
        {
            lstUsers = new List<Users>();
            lstEmployeeRegMaster = new List<EmployeeRegMaster>();
            lstInvClientMaster = new List<InvClientMaster>();
            lstLocalities = new List<Localities>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetphlebotomistName(Name, orgid, Type, ZoneID, out lstUsers, out lstEmployeeRegMaster, out lstInvClientMaster, out lstLocalities);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPhlebotomistName in Investigation_BL", excp);
            }

            return returnCode;
        }

        public long GetGrouplevelvalidation(long vid, int TaskActionID, List<PatientInvestigation> Patinvestasks, int OrgID, int LID, out List<PatientInvestigation> pattasks)
        {
            long returncode = -1;

            pattasks = new List<PatientInvestigation>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetGrouplevelvalidation(vid, TaskActionID, Patinvestasks, OrgID, LID, out pattasks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetGrouplevelvalidation in Investigation_BL", ex);
            }
            return returncode;

        }

        //public long SaveTestMasterDetails(TestMaster oTestMaster, List<InvRemarks> lstInvRemarks, List<InvOrgReferenceMapping> lstInvOrgReferenceMapping, InvestigationLocationMapping oInvestigationLocationMapping, Int32 pOrgID, Int64 pInvID, String pType, Int64 pLoginID, List<InvValueRangeMaster> lstInvValueRangeMaster, List<InvOrgNotifications> lstInvOrgNotifications, out List<InvOrgAuthorization> lstCoAuth)
        //{
        //    long returnCode = -1;
        //    Investigation_DAL objInvDAL = null;
        //    try
        //    {
        //        //DataTable dtTestMaster = new DataTable();
        //        //DataTable dtInvRemarks = new DataTable();
        //        //DataTable dtInvOrgReferenceMapping = new DataTable();
        //        //DataTable dtInvestigationLocationMapping = new DataTable();
        //        //returnCode = this.GetTestMasterDataTable(oTestMaster, lstInvRemarks, lstInvOrgReferenceMapping, 
        //        //    oInvestigationLocationMapping, out dtTestMaster, out dtInvRemarks, out dtInvOrgReferenceMapping,
        //        //    out dtInvestigationLocationMapping);
        //        //if (returnCode == 0)
        //        //{
        //        objInvDAL = new Investigation_DAL(globalContextDetails);
        //        returnCode = objInvDAL.SaveTestMasterDetails(oTestMaster, lstInvRemarks, lstInvOrgReferenceMapping,
        //            oInvestigationLocationMapping, pOrgID, pInvID, pType, pLoginID, lstInvValueRangeMaster, lstInvOrgNotifications, lstCoAuth);
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        returnCode = -1;
        //        CLogger.LogError("Error in SaveTestMasterDetails", ex);
        //        throw ex;
        //    }

        //    return returnCode;
        //}

        public long GetTemplatesforAction(string ActionName, out List<ActionTemplate> lstActiontemplate)
        {
            long returnCode = -1;
            lstActiontemplate = new List<ActionTemplate>();
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetTemplatesforAction(ActionName, out lstActiontemplate);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTemplatesforAction in Investigation_BL", excp);
            }

            return returnCode;


        }

        public long DeleteInvCoAuth(long ID, long InvID, int OrgID)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL oInvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvDAL.DeleteInvCoAuth(ID, InvID, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteInvOrgRefMapping in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long getReferencerangetype(int orgid, string LangCode, out List<ReferenceRangeType> lstReferenceRangeType)
        {
            long returnCode = -1;
            lstReferenceRangeType = new List<ReferenceRangeType>();
            try
            {
                Investigation_DAL oInvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvDAL.getReferencerangetype(orgid, LangCode, out lstReferenceRangeType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getReferencerangetype in Investigation_BL", ex);
            }
            return returnCode;
        }


        public Boolean UpdateReceiveSamplePickedBy(long PatientVisitID, long LID, string IsClearPickedBy)
        {
            long returnCode = -1;
            string isAlreadyPicked = "Y";
            bool blnReturn = false;
            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
            try
            {
                returnCode = invDAL.UpdateReceiveSamplePickedBy(PatientVisitID, LID, IsClearPickedBy, out isAlreadyPicked);
                if (returnCode == 0 && isAlreadyPicked == "Y")
                    blnReturn = true;
                else
                    blnReturn = false;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateReceiveSamplePickedBy in Investigation_BL", ex);
            }
            return blnReturn;
        }
        public long ProbeImagesForPatientVisits(long pPatientVisitid, long pInvestigationId, long POrgID, out List<PatientInvestigationFiles> lstpatientImages)
        {
            lstpatientImages = new List<PatientInvestigationFiles>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL();
                returnCode = ObjDAL.ProbeImagesForPatientVisits(pPatientVisitid, pInvestigationId, POrgID, out lstpatientImages);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing ProbeImagesForPatientVisits in Investigation_BL", excp);
            }

            return returnCode;

        }
        public long GetImageForProbes(long PatientVisitID, long InvestigationID, long ImageID, long POrgID, out  PatientInvestigationFiles imgprobe)
        {
            long returnCode = -1;

            imgprobe = new PatientInvestigationFiles();
            try
            {
                returnCode = new Investigation_DAL().GetImageForProbes(PatientVisitID, InvestigationID, ImageID, POrgID, out imgprobe);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetImageForProbes in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long DeleteProbeImageDeatils(long PVisitId, long Pinvid, int OrgID, long ImageId)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL oInvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvDAL.DeleteProbeImageDeatils(PVisitId, Pinvid, OrgID, ImageId);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteProbeImageDeatils in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetProbeNames(long Pinvid, out List<InvestigationBulkData> lstbulkdata)
        {
            long returnCode = -1;
            lstbulkdata = new List<InvestigationBulkData>();
            try
            {
                Investigation_DAL oInvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvDAL.GetProbeNames(Pinvid, out lstbulkdata);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProbeNames in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetMappingStatus(int TaskActionID, string MappingType, int OrgID, out List<InvestigationStatus> lstInvestigationStatus)
        {
            long returncode = -1;
            lstInvestigationStatus = new List<InvestigationStatus>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetMappingStatus(TaskActionID, MappingType, OrgID, out lstInvestigationStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetMappingStatus in Investigation_BL", ex);
            }
            return returncode;
        }
        public long GetSignalPatterns(long Pinvid, int Orgid, out List<InvResultTemplate> lstResultTemplate)
        {
            long returnCode = -1;
            lstResultTemplate = new List<InvResultTemplate>();
            try
            {
                Investigation_DAL oInvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvDAL.GetSignalPatterns(Pinvid, Orgid, out lstResultTemplate);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSignalPatterns in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvSamplesforOutSource(int OrgID, string SubStatus, long OutLocations, out List<OutsourcingDetail> lstOutSourcingDetail)
        {
            long returnCode = -1;
            lstOutSourcingDetail = new List<OutsourcingDetail>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetInvSamplesforOutSource(OrgID, SubStatus, OutLocations, out lstOutSourcingDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvSamplesforOutSource in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetOutSourcedLocations(int OrgID, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long returnCode = -1;
            lstLabRefOrg = new List<LabReferenceOrg>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetOutSourcedLocations(OrgID, out lstLabRefOrg);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOutSourcedLocations in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetBarcodeNumForDoFromVisit(long OrgID, long DoFromVisitID, out string Barcode, int SampleCode, string UID, string type, int ContainerID)
        {
            long returnCode = -1;
            Barcode = "";
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returnCode = invDaL.GetBarcodeNumForDoFromVisit(OrgID, DoFromVisitID, out Barcode, SampleCode, UID, type, ContainerID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBarcodeNumForDoFromVisit in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetInvBulkDataAuto(long InvID, long GrpID, int OrgID, string KeyName, out  List<InvestigationBulkData> lstBulkData)
        {
            long returnCode = -1;
            lstBulkData = new List<InvestigationBulkData>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.GetInvBulkDataAuto(InvID, GrpID, OrgID, KeyName, out lstBulkData);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvBulkDataAuto in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetPatientOrderedInvestigation(long patientVisitID, int OrgID, long grpid, string type, long accNo, string parentType, out List<OrderedInvestigations> lstOrderedInvestigations
        , out List<OrderedInvestigations> lstMasterreflex)
        {
            long result = -1;
            lstOrderedInvestigations = new List<OrderedInvestigations>();
            lstMasterreflex = new List<OrderedInvestigations>();
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetPatientOrderedInvestigation(patientVisitID, OrgID, grpid, type, accNo, parentType, out lstOrderedInvestigations, out lstMasterreflex);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientOrderedInvestigation in Investigation_BL", ex);
            }
            return result;
        }


        public long GetOrganismList(long pInvID, out List<OrganismMaster> lstOrganismMaster)
        {
            long returnCode = -1;
            lstOrganismMaster = new List<OrganismMaster>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetOrganismList(pInvID, out lstOrganismMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrganismList in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetOrganismDrugDetails(long pInvID, long pOrganismID, string pOrganismCode, string pType, out List<InvOrganismDrugMapping> lstOrganismDrugDetails)
        {
            long returnCode = -1;
            lstOrganismDrugDetails = new List<InvOrganismDrugMapping>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetOrganismDrugDetails(pInvID, pOrganismID, pOrganismCode, pType, out lstOrganismDrugDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrganismDrugDetails in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetPatientInvestigationStatus(long pVisitID, int pOrgID, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetPatientInvestigationStatus(pVisitID, pOrgID, out lstPatientInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientInvestigationStatus in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetBatchWiseDropDownValues(int pOrgID, LoginDetail oLoginDetail, out List<InvInstrumentMaster> lstInstrumentMaster, out List<InvDeptMaster> lstDeptMaster, out List<InvestigationHeader> lstInvHeaderMaster, out List<MetaDataOrgMapping> lstProtocolGroupMaster)
        {
            long returnCode = -1;
            lstInstrumentMaster = new List<InvInstrumentMaster>();
            lstDeptMaster = new List<InvDeptMaster>();
            lstInvHeaderMaster = new List<InvestigationHeader>();
            lstProtocolGroupMaster = new List<MetaDataOrgMapping>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetBatchWiseDropDownValues(pOrgID, oLoginDetail, out lstInstrumentMaster, out lstDeptMaster, out lstInvHeaderMaster, out lstProtocolGroupMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseDropDownValues in Investigation_BL", ex);
            }

            return returnCode;
        }
        /* ----------------Prasanna.S - Batch sheet-----------------------*/
        public long GetORCheckGeneratedBatch(int OrgID, DateTime FromDate, DateTime ToDate, int SourceLocationID, int ProcessingLocationID, out int isExists, string pType, out List<BatchSheet> lstBatchSheet, string Prefix)
        {
            long retCode = -1;
            isExists = 0;
            lstBatchSheet = new List<BatchSheet>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.GetORCheckGeneratedBatch(OrgID, FromDate, ToDate, SourceLocationID, ProcessingLocationID, out isExists, pType, out lstBatchSheet, Prefix);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetORCheckGeneratedBatch in Investigation_BL", e);
            }
            return retCode;
        }

        public long SaveBatchSheet(int OrgID, DateTime FromDate, DateTime ToDate, int SourceLocationID, int ProcessingLocationID, long CreatedBy, List<PatientInvSample> lstPatientInvSample, out string BatchNo)
        {
            long retCode = -1;
            BatchNo = string.Empty;
            try
            {
                DataTable BatchSheet = new DataTable();
                //UDT_DAL ud = new UDT_DAL();
                BatchSheet = UDT_DAL.ConvertToGetPatientInvDataTable(lstPatientInvSample);
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.SaveBatchSheet(OrgID, FromDate, ToDate, SourceLocationID, ProcessingLocationID, CreatedBy, BatchSheet, out BatchNo);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveBatchSheet in Investigation_BL", e);
            }
            return retCode;
        }

        public long UpdateBatchSheet(int OrgID, DateTime FromDate, DateTime ToDate, int SourceLocationID, int ProcessingLocationID, long CreatedBy, List<PatientInvSample> lstPatientInvSample, int Batchid)
        {
            long retCode = -1;
            try
            {
                DataTable BatchSheet = new DataTable();
                BatchSheet = UDT_DAL.ConvertToGetPatientInvDataTable(lstPatientInvSample);
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.UpdateBatchSheet(OrgID, FromDate, ToDate, SourceLocationID, ProcessingLocationID, CreatedBy, BatchSheet, Batchid);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateBatchSheet in Investigation_BL", e);
            }
            return retCode;
        }

        /* ----------------Prasanna.S - Batch sheet-----------------------*/
        /*/-----------Sathish.E------------/*/

        public long GetSamplesForBatch(int OrgID, string BatchNumber, out List<SampleBatchTrackerDetails> lstSampleBatchTrackerDetails, out List<SampleBatchTrackerConflictDetails> lstSampleBatchTrackerConflictDetails)
        {
            long returnCode = -1;
            lstSampleBatchTrackerDetails = new List<SampleBatchTrackerDetails>();
            lstSampleBatchTrackerConflictDetails = new List<SampleBatchTrackerConflictDetails>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetSamplesForBatch(OrgID, BatchNumber, out lstSampleBatchTrackerDetails, out lstSampleBatchTrackerConflictDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSamplesForBatch in Investigation_BL", ex);
            }

            return returnCode;
        }

        /*/-----------Sathish.E------------/*/

        /*/-----------Sathish.E------------/*/

        public long UpdateSampleBatchTrackerDetails(List<SampleBatchTrackerDetails> lstSampleBatchTracker, List<SampleBatchTrackerConflictDetails> lstSampleBatchConflictDetails)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).UpdateSampleBatchTrackerDetails(lstSampleBatchTracker, lstSampleBatchConflictDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateSampleBatchTrackerDetails in Investigation_BL", ex);
            }

            return returnCode;
        }

        /*/-----------Sathish.E------------/*/

        public long GetOrderedInvStatus(long VisitId, long OrgId, string AccessionNumber, out List<OrderedInvestigations> lstOrderedInvestigations)
        {
            lstOrderedInvestigations = new List<OrderedInvestigations>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetOrderedInvStatus(VisitId, OrgId, AccessionNumber, out lstOrderedInvestigations);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetOrderedInvStatus in Investigation_BL", excp);
            }

            return returnCode;


        }
        public long GetInvestigationAbbCode(int GroupID, long VisitNumber, out List<DeviceImportData> LstDevice)
        {
            long returnCode = -1;
            LstDevice = new List<DeviceImportData>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetInvestigationAbbCode(GroupID, VisitNumber, out LstDevice);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientInvestigationStatus in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long SaveQuickApprovalInvestigationResults(List<PatientInvestigation> lstInvestigation)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.SaveQuickApprovalInvestigationResults(lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveQuickApprovalInvestigationResults in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetInvAuthorizationList(long pVisitID, int pOrgID, out List<InvOrgAuthorization> lstInvOrgAuthorization)
        {
            long returnCode = -1;
            lstInvOrgAuthorization = new List<InvOrgAuthorization>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetInvAuthorizationList(pVisitID, pOrgID, out lstInvOrgAuthorization);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvAuthorizationList in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long SaveInvestigationQueue(List<InvestigationQueue> InvQueue, long OrgID)
        {
            long retCode = -1;
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SaveInvestigationQueue(InvQueue, OrgID);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveOrderedInvestigationHOS in Investigation_BL", e);
            }
            return retCode;
        }

        public long DeleteReflexTest(List<InvValueRangeMaster> lstInvValueRangeMaster)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL oInvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvDAL.DeleteReflexTest(lstInvValueRangeMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In BL DeleteInvOrgRefMapping", ex);
            }
            return returnCode;
        }
        public long UpdateInvStatus(List<PatientInvestigation> lstpatientIds, int OrgId)
        {

            long returnCode = -1;
            try
            {
                Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.UpdateInvStatus(lstpatientIds, OrgId);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetOrderedInvStatus in Investigation_BL", excp);
            }

            return returnCode;


        }


        public long GetInvStatusLoad(string VIDs, int OrgID, long RoleID, long DeptID, string InvName, string InvType, LoginDetail LDetail,
                    string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalID, string pActionName, string pIsMaster,
                    out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetInvStatusLoad(VIDs, OrgID, RoleID, DeptID, InvName, InvType, LDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalID, pActionName, pIsMaster, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvStatusLoad in Investigation_BL", ex);
            }
            return result;
        }
        public long GetPendingList(int OrgID, long RoleID, long InvID, string InvType, LoginDetail LDetail,
                  string IsTrustedDetails, long deviceid, long pProtocalGroupID, DateTime fromdate, DateTime todate, string pStatus, string IsSTAT, long pDeptid, string pGroupLevel, out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetPendingList(OrgID, RoleID, InvID, InvType, LDetail, IsTrustedDetails, deviceid, pProtocalGroupID, fromdate, todate, pStatus, IsSTAT, pDeptid, pGroupLevel, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPendingList in Investigation_BL", ex);
            }
            return result;
        }

        public long GetPatientInvestigationStatus(long pVisitID, int pOrgID, string UID, out List<InvestigationStatus> lstInvStatus, out List<PatientVisitDetails> lstVisitDetails, out int completedCount, out int notGivenCount)
        {
            long returnCode = -1;
            lstInvStatus = new List<InvestigationStatus>();
            lstVisitDetails = new List<PatientVisitDetails>();
            completedCount = 0;
            notGivenCount = 0;
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetPatientInvestigationStatus(pVisitID, pOrgID, UID, out lstInvStatus, out lstVisitDetails, out completedCount, out notGivenCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientInvestigationStatus in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetBatchWiseBulkData(List<PatientInvestigation> lstInve, int orgID, string pActionName, out List<InvestigationValues> lstBulkData
       , out List<InvestigationValues> lstPendingValue, out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom)
        {
            long result = -1;

            lstBulkData = new List<InvestigationValues>();
            lstPendingValue = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetBatchWiseBulkData(lstInve, orgID, pActionName, out lstBulkData, out lstPendingValue, out header, out  lstiom);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvBulkData in Investigation_BL", ex);
            }
            return result;
        }
        public long ApprovePatientInvestigationStatus(List<PatientInvestigation> InvestigationList, string gUID, out int returnStatus)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {

                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.ApprovePatientInvestigationStatus(InvestigationList, gUID, out returnStatus);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvestigationResults in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long GetDiscountSlab(int DiscountId, out List<DiscountMaster> lstDiscountmaster, out List<InvReasonOrgMapping> lstDiscountreason)
        {
            long returnCode = -1;
            lstDiscountmaster = new List<DiscountMaster>();
            lstDiscountreason = new List<InvReasonOrgMapping>();
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.GetDiscountSlab(DiscountId, out lstDiscountmaster, out lstDiscountreason);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetDiscountSlab in Investigation_BL", e);
            }
            return returnCode;
        }
        public long SaveTRFverificationDetails(long PatientVisitId, bool IsEdit)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).SaveTRFverificationDetails(PatientVisitId, IsEdit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveTRFverificationDetails in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long UpdatePatientdetails(long PatientID, long PatientVisitID, int Titlecode, string Name, string Gender, string PatientAddress1, string PatientAddress2, string City, string Age, string AgeDesc, string Mobileno, string Landlineno, DateTime DOB, string EmailID, long RefPhyID, string RefPhyName, int orgID, List<PatientHistoryExt> lstpatientHistory, out long FinallBillId)
        {

            long returnCode = -1;
            FinallBillId = -1;
            try
            {
                Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.UpdatePatientdetails(PatientID, PatientVisitID, Titlecode, Name, Gender, PatientAddress1, PatientAddress2, City, Age, AgeDesc, Mobileno, Landlineno, DOB, EmailID, RefPhyID, RefPhyName, orgID, lstpatientHistory, out FinallBillId);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetOrderedInvStatus in Investigation_BL", excp);
            }

            return returnCode;


        }

        public long CheckInvImageAttachmentMandatory(Int32 pOrgID, Int64 pVisitID, out bool pIsAttachmentMandatory, out bool pHasAttachment)
        {
            long returnCode = -1;
            pIsAttachmentMandatory = false;
            pHasAttachment = false;
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL();
                returnCode = InvestigationDAL.CheckInvImageAttachmentMandatory(pOrgID, pVisitID, out pIsAttachmentMandatory, out pHasAttachment);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CheckInvImageAttachmentMandatory in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetRecollectCount(long VisitId, long ID, int pOrgID, out List<InvestigationQueue> lstInvestigationQueue)
        {
            long returnCode = -1;
            lstInvestigationQueue = new List<InvestigationQueue>();
            Investigation_DAL MDAL = new Investigation_DAL(globalContextDetails);
            try
            {
                returnCode = MDAL.GetRecollectCount(VisitId, ID, pOrgID, out lstInvestigationQueue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRecollectCount in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetMemberDetails(string MemberCardNo, string CardType, string Type, out List<PatientMembershipCardMapping> lstPatientCardMap)
        {
            long returnCode = -1;
            lstPatientCardMap = new List<PatientMembershipCardMapping>();
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.GetMemberDetails(MemberCardNo, CardType, Type, out lstPatientCardMap);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetMemberDetails in Investigation_BL", e);
            }
            return returnCode;
        }
        public long SaveMemberShipCardOTP(long MembershipCardMappingId, string OTP, out List<PatientMembershipCardMapping> lstPatientCardMap)
        {
            long returnCode = -1;
            lstPatientCardMap = new List<PatientMembershipCardMapping>();
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.SaveMemberShipCardOTP(MembershipCardMappingId, OTP, out  lstPatientCardMap);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveMemberShipCardOTP in Investigation_BL", e);
            }
            return returnCode;
        }

        public long InsertCommercialsForOrgtransfer(long pVisitID, int OrgID)
        {

            long returnCode = -1;
            try
            {
                Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.InsertCommercialsForOrgtransfer(pVisitID, OrgID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing InsertCommercialsForOrgtransfer in Investigation_BL", excp);
            }

            return returnCode;


        }

        public long CheckIsValidtoTransfer(List<PatientInvSample> lstpinvsample, out List<CollectedSample> lstpinvsampleVisits)
        {
            long returnCode = -1;
            lstpinvsampleVisits = new List<CollectedSample>();
            Investigation_DAL InvDaL = new Investigation_DAL(globalContextDetails);
            try
            {
                returnCode = InvDaL.CheckIsValidtoTransfer(lstpinvsample, out lstpinvsampleVisits);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CheckIsValidtoTransfer in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long DeleteInvLocationMapping(long ID, long InvID, int OrgID)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL oInvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvDAL.DeleteInvLocationMapping(ID, InvID, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteInvLocationMapping in Investigation_BL", ex);
            }
            return returnCode;
        }
        #region For SampleWorkFlow
        public long GetSampleWorkflowDetails(int OrgID, string BarcodeNumber, int ExtraSampleID, out List<SampleWorkFlow> lstSampleWorkFlow)
        {
            lstSampleWorkFlow = new List<SampleWorkFlow>();
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetSampleWorkflowDetails(OrgID, BarcodeNumber, ExtraSampleID, out lstSampleWorkFlow);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSampleWorkflowDetails in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long ShowSamplesforBarcode(string BarcodeNumber, out List<InvSampleMaster> lstInvSampleMaster)
        {
            long returnCode = -1;
            lstInvSampleMaster = new List<InvSampleMaster>();

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).ShowSamplesforBarcode(BarcodeNumber, out lstInvSampleMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing ShowSamplesforBarcode in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetSampleArchivalDetails(int trayId, string barcodeNo, out List<SampleArchival> lstSampleArchival)
        {
            long returnCode = -1;
            lstSampleArchival = new List<SampleArchival>();
            try
            {
                new Investigation_DAL(globalContextDetails).GetSampleArchivalDetails(trayId, barcodeNo, out lstSampleArchival);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSampleArchivalDetails in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long SaveSampleArchivalMasterDetails(string pType, List<SampleArchival> lstSampleArchival)
        {
            long lresult = -1;
            try
            {
                Investigation_DAL investigationdaL = new Investigation_DAL(globalContextDetails);
                lresult = investigationdaL.SaveSampleArchivalMasterDetails(pType, lstSampleArchival);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveSampleArchivalMasterDetails in Investigation_BL", excp);
            }
            return lresult;

        }
        #endregion
        #region For NewWorkList
        public long SaveWorkList(int OrgID, List<NewWorkList> lstWorklist, long LocationID, string searchType, long pLoginId, out string WorklistId)
        {
            long result = -1;
            WorklistId = string.Empty;
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.SaveWorkList(OrgID, lstWorklist, LocationID, searchType, pLoginId, out WorklistId);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveWorkList in Investigation_BL", e);
            }
            return result;
        }
        public long GetNewWorkListFromVisitToVisit(string fromVisit, string toVisit, int OrgID, int deptID, int orgadd, int clientid,
          long LocationID, string searchType, string InvestigationName, int PriorityID, out List<NewWorkList> lstWorkList,
         int intVisitType, string FromDate, string Todate, int pHistoryMode,
         string pPageMode, long pLoginId, string IsIncludevalues, string Preference, long WorklistId)
        {
            long result = -1;
            lstWorkList = new List<NewWorkList>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetNewWorkListFromVisitToVisit(fromVisit, toVisit, OrgID, deptID, orgadd,
                    clientid, LocationID, searchType, InvestigationName, PriorityID, out lstWorkList, intVisitType, FromDate, Todate, pHistoryMode,
                    pPageMode, pLoginId, IsIncludevalues, Preference, WorklistId);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetWorkListFromVisitToVisit in Investigation_BL", e);
            }
            return result;
        }

        #endregion
        #region Batchwise Enter Result
        public long GetBatchWiseInvestigationResultsCaptureFormat(string VIDs, int OrgID, long RoleID, long DeptID, string InvName, string InvType, LoginDetail LDetail,
         string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalID, string pActionName, string pIsMaster, string workListType,
         out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetBatchWiseInvestigationResultsCaptureFormat(VIDs, OrgID, RoleID, DeptID, InvName, InvType, LDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalID, pActionName, pIsMaster, workListType, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseInvestigationResultsCaptureFormat in Investigation_BL", ex);
            }
            return result;
        }
        #endregion
        #region sample archieval master
        public long GetSampleArchival(int rackId, out DataTable oSampleArchival)
        {
            long returnCode = -1;
            oSampleArchival = new DataTable();
            try
            {
                new Investigation_DAL(globalContextDetails).GetSampleArchival(rackId, out oSampleArchival);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSampleArchival in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetDeptAndAnalyser(out List<InvDeptMaster> lstInvDeptMaster, out List<InvInstrumentMaster> lstAnalyser)
        {
            long returnCode = -1;
            lstInvDeptMaster = new List<InvDeptMaster>();
            lstAnalyser = new List<InvInstrumentMaster>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetDeptAndAnalyser(out lstInvDeptMaster, out lstAnalyser);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeptAndAnalyser in Investigation_BL", ex);
            }
            return returnCode;
        }

        #endregion

        /* Quantum Changes */
        public long GetStatusForApproval(string guid, long patientVisitID, int orgID, string status, long taskid, out List<InvestigationStatus> header, out List<InvReasonMasters> reason, out List<ReferenceRangeType> lstReferenceRangeType, out List<PatientVisit> lstVisit)
        {
            long result = -1;
            header = new List<InvestigationStatus>();
            reason = new List<InvReasonMasters>();
            lstReferenceRangeType = new List<ReferenceRangeType>();
            lstVisit = new List<PatientVisit>();
            try
            {
                Investigation_DAL objInvDal = new Investigation_DAL(globalContextDetails);
                result = objInvDal.GetStatusForApproval(guid, patientVisitID, orgID, status, taskid, out header, out reason, out lstReferenceRangeType, out lstVisit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCopyMasterDetails in Deployability_BL", ex);
            }
            return result;
        }

        public long SaveInvResults(long pSCMID, List<List<InvestigationValues>> lstInvestigationValues, List<PatientInvestigation> lstInvestigation, List<PatientInvestigationFiles> lPfiles, long vid, int OrgID, int deptID, long ApprovadBy, string gUID, PageContextkey PageContextDetails, out int returnStatus, string isFromDevice, List<PatientInvestigation> lstReflexPatientinvestigation)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {

                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.SaveInvResults(pSCMID, lstInvestigationValues, lstInvestigation, lPfiles, vid, OrgID, deptID, ApprovadBy, gUID, out returnStatus, isFromDevice, lstReflexPatientinvestigation);
                if (returnStatus >= 0)
                {
                    //List<PatientInvestigation> lstNonApprovedInvestigation = lstInvestigation.FindAll(P => P.Status != InvStatus.Approved);
                    //if (lstNonApprovedInvestigation != null && lstNonApprovedInvestigation.Count == 0)
                    //{
                    //    ActionManager objActionManager = new ActionManager();
                    //    objActionManager.PerformingNextStep(PageContextDetails);
                    //}
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvResults in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long GetAutocompleteForGroupid(int GroupID, int OrgID, out List<InvOrgGroup> lstInvorgGroup)
        {
            lstInvorgGroup = new List<InvOrgGroup>();
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetAutocompleteForGroupid(GroupID, OrgID, out lstInvorgGroup);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAutocompleteForGroupid in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long DeviceErrorFlagcheck(long OrgID, string DeviceID, string DeviceErrorCode, int investigationID, out List<InvestigationValues> Investigationvalues)
        {
            long returnCode = -1;
            Investigationvalues = new List<InvestigationValues>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.DeviceErrorFlagcheck(OrgID, DeviceID, DeviceErrorCode, investigationID, out Investigationvalues);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientInvestigationStatus in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetDependentInvestigationdetails(long visitid, int OrgID, List<PatientInvestigation> lstpatinv, out List<PatientInvestigation> lstDependentinv, out List<PatientInvestigation> lstPatientinv)
        {
            lstDependentinv = new List<PatientInvestigation>();
            lstPatientinv = new List<PatientInvestigation>();
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetDependentInvestigationdetails(visitid, OrgID, lstpatinv, out lstDependentinv, out lstPatientinv);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDependentInvestigationdetails in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long BatchWiseSaveInvestigationResults_Lab(long pSCMID, List<List<InvestigationValues>> lstInvestigationValues, List<PatientInvestigation> lstInvestigation, List<PatientInvSampleResults> lstPatientInvSampleResults, List<PatientInvSampleMapping> lstPatientInvSampleMapping, List<PatientInvestigationFiles> lPfiles, long vid, int OrgID, int deptID, long ApprovadBy, string gUID, PageContextkey PageContextDetails, out int returnStatus)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {

                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.BatchWiseSaveInvestigationResults_Lab(pSCMID, lstInvestigationValues, lstInvestigation, lstPatientInvSampleResults, lstPatientInvSampleMapping, lPfiles, vid, OrgID, deptID, ApprovadBy, gUID, out returnStatus);
                if (returnStatus >= 0)
                {
                    List<PatientInvestigation> lstNonApprovedInvestigation = lstInvestigation.FindAll(P => P.Status != InvStatus.Approved);
                    if (lstNonApprovedInvestigation != null && lstNonApprovedInvestigation.Count == 0)
                    {
                        ActionManager objActionManager = new ActionManager();
                        objActionManager.PerformingNextStep(PageContextDetails);
                    }
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvestigationResults in Investigation_BL", excp);
            }

            return returnCode;
        }

        public long GetBarcodeLayerOption(long PatientvisitID, int SampleID, out List<BarcodeLayer> lstBarcodeOption)
        {
            long returnCode = -1;
            lstBarcodeOption = new List<BarcodeLayer>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetBarcodeLayer(PatientvisitID, SampleID, out lstBarcodeOption);
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetImageServerDetails in IntegrationBL", ex);
            }
            return returnCode;
        }
        //kapil
        public long GetSortingTasks(int orgid, int deptid, DateTime FromDate, DateTime ToDate, string InvestigationName, long InvestigationID, string InvestigationType, string VisitID, int index, int pagesize, out int totalrow, LoginDetail LDetail, int Reassing, out List<OrderedInvestigations> lsttasks)
        {
            long returnCode = -1;
            totalrow = -1;
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            lsttasks = new List<OrderedInvestigations>();
            try
            {
                Investigation_DAL oInvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvDAL.GetSortingTasks(orgid, deptid, FromDate, ToDate, InvestigationName, InvestigationID, InvestigationType, VisitID, index, pagesize, out totalrow, LDetail, Reassing, out lsttasks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSortingTasks in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long Insertsortedtask(int pOrgID, int deptid, List<OrderedInvestigations> lstOrderedInves, DataTable dtrole)
        {

            long returnCode = -1;
            try
            {
                Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.Insertsortedtask(pOrgID, deptid, lstOrderedInves, dtrole);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetOrderedInvStatus in Investigation_BL", excp);
            }

            return returnCode;


        }
        //added for populate pattern: kapil
        public long GetGeneralPattern(long Pinvid, out List<TabularPatternConfigurationMaster> lstDynamicTable, int OrgID)
        {
            long returnCode = -1;
            lstDynamicTable = new List<TabularPatternConfigurationMaster>();
            try
            {
                Investigation_DAL oInvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvDAL.GetGeneralPattern(Pinvid, out lstDynamicTable, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSortingTasks in Investigation_BL", ex);
            }
            return returnCode;
        }
        //kapil
        //Vijayalakshmi.M

        public long GetBarcodeNo(int OrgID, int SampleCode, long VisitId, string BarcodeNumber, out string Barcode)
        {
            long returnCode = -1;
            Barcode = string.Empty;
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.GetBarcodeNo(OrgID, SampleCode, VisitId, BarcodeNumber, out Barcode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBarcodeNo in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long pUpdatePkgSequence(DataTable dt, int OrgID, int PkgID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pUpdatePkgSequence(dt, OrgID, PkgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pUpdatePkgSequence in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long pGetSequencepkg(int OrgID, int PkgID, out List<InvOrgGroup> lstPkg)
        {
            long returnCode = -1;
            lstPkg = new List<InvOrgGroup>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pGetSequencepkg(OrgID, PkgID, out lstPkg);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetSequencepkg in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long pGetPKG(int OrgID, int PkgID, out List<OrderedInvestigations> lstInvNames, out string Pkgname)
        {
            long returnCode = -1;
            lstInvNames = new List<OrderedInvestigations>();
            Pkgname = String.Empty;
            try
            {
                Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvDAL.pGetPKG(OrgID, PkgID, out lstInvNames, out Pkgname);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetPKG in Investigation_BL", ex);
            }
            return returnCode;
        }


        //End
        //Added by Vijayalakshmi.M for Mobile APP API
        public long GetReferenceRangeDetails(long VisitID, long InvestigationID, string Value, int OrgID, string IsAbnormal, out List<VisitDetails> lstVisitdetails, out string textColor, out string Abnormal)
        {
            long returnCode = -1;
            textColor = "";
            Abnormal = "";
            lstVisitdetails = new List<VisitDetails>();
            try
            {
                Investigation_DAL InvDal = new Investigation_DAL();
                returnCode = InvDal.GetReferenceRangeDetails(VisitID, InvestigationID, Value, OrgID, out lstVisitdetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetReferenceRangeDetails in Investigation_BL", ex);
            }
            return returnCode;

        }
        public long GetInvestigationReportDetails(int VisitID, long OrgID, out VisitCountDetails[] lstValues)
        {
            lstValues = null;
            long returnCode = -1;
            try
            {
                Investigation_DAL InvDal = new Investigation_DAL();
                returnCode = InvDal.GetInvestigationReportDetails(VisitID, OrgID, out lstValues);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationReportDetails in Investigation_BL", ex);
            }
            return returnCode;

        }
        //END

        public long pGetQuickApprovelForCompletedStatus(long OrgID, out List<InvStatusmapping> LstInvStatusmapping)
        {
            long returnCode = -1;
            LstInvStatusmapping = new List<InvStatusmapping>();
            try
            {
                Investigation_DAL Investigation_DAL = new Investigation_DAL(globalContextDetails);
                returnCode = Investigation_DAL.pGetQuickApprovelForCompletedStatus(OrgID, out LstInvStatusmapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetQuickApprovelForCompletedStatus in Investigation_BL", ex);
            }
            return returnCode;
        }
        #region HL7 integration
        public long HL7SavePatientInvestigation(List<InvestigationValues> PatientInvestigation, long OrgID, string gUID, HLMessages objHLMessage, out int pOrderedInvCnt)
        {
            long retCode = -1;
            int ret = -1;
            pOrderedInvCnt = 0;


            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.HL7SavePatientInvestigation(PatientInvestigation, OrgID, gUID, objHLMessage, out pOrderedInvCnt);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SavePatientInvestigation in Investigation_BL", e);
            }
            return retCode;
        }
        public long GetInvestigationList(List<DischargeInvNotes> lstinvMaster, int Orgid, out List<OrderedInvestigations> lstordinv)
        {
            long returncode = -1;
            lstordinv = new List<OrderedInvestigations>();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                returncode = invDaL.GetInvestigationList(lstinvMaster, Orgid, out lstordinv);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationList in Investigation_BL", ex);
            }
            return returncode;
        }
        #endregion
        public long GetTestNameForMedicalDetailsMapping(string Name, long orgid, out List<OrderedInvestigations> lstOrd)
        {
            lstOrd = new List<OrderedInvestigations>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.GetTestNameForMedicalDetailsMapping(Name, orgid, out lstOrd);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTestNameForMedicalDetailsMapping in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long AddUOMCode(string UOMCode, string UOMDescription, out int pUOMID)
        {
            long returnCode = -1;
            pUOMID = 0;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).AddUOMCode(UOMCode, UOMDescription, out pUOMID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing AddUOMCode in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long IsUOMCodeExists(string UOMCode, string UOMDescription, out int pCount)
        {
            long returnCode = -1;
            pCount = 0;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).IsUOMCodeExists(UOMCode, UOMDescription, out pCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing IsUOMCodeExists in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetDepartmentHeaders(out List<InvestigationHeader> lstManageHeader)
        {

            lstManageHeader = new List<InvestigationHeader>();
            long lresult = -1;
            try
            {
                Investigation_DAL investigationdaL = new Investigation_DAL(globalContextDetails);
                lresult = investigationdaL.GetDepartmentHeaders(out lstManageHeader);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetDepartmentHeaders in Investigation_BL", excp);
            }
            return lresult;

        }
        public long pSaveManageHeader(string HeaderName, bool IsActive)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pSaveManageHeader(HeaderName, IsActive);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pSaveManageHeader in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long pUpdateManageHeader(long HeaderID, string HeaderName, bool IsActive)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).pUpdateManageHeader(HeaderID, HeaderName, IsActive);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pUpdateManageHeader in Investigation_BL", ex);
            }
            return returnCode;
        }
        //-----------------GetColletApproveAndReceivedDate-------------------
        public long GetColletApproveAndReceivedDate_BL(string strPrefix, int intOrgID, out List<PendingInvestigation> lstVisitNumber)
        {
            long returnCode = -1;
            lstVisitNumber = new List<PendingInvestigation>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetColletApproveAndReceivedDate_DAL(strPrefix, intOrgID, out lstVisitNumber);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetColletApproveAndReceivedDate_BL in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long UpdateCollectReceiveApprovedDate_BL(long longVisitID, int intOrgID, string strVisitNumber, DateTime CollectDatetime, DateTime ReceviedDatetime, DateTime ApprovedDatetime)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).UpdateCollectReceiveApprovedDate_DAL(longVisitID, intOrgID, strVisitNumber, CollectDatetime, ReceviedDatetime, ApprovedDatetime);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateCollectReceiveApprovedDate_BL in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long SaveInvestigationResultsPreview(long pSCMID, List<List<InvestigationValues>> lstInvestigationValues, List<PatientInvestigation> lstInvestigation, List<PatientInvSampleResults> lstPatientInvSampleResults, List<PatientInvSampleMapping> lstPatientInvSampleMapping, List<PatientInvestigationFiles> lPfiles, long vid, int OrgID, int deptID, long ApprovadBy, string gUID, PageContextkey PageContextDetails, out int returnStatus, List<PatientInvestigation> lstReflexPatientinvestigation, string isFromDevice)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {

                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.SaveInvestigationResultsPreview(pSCMID, lstInvestigationValues, lstInvestigation, lstPatientInvSampleResults, lstPatientInvSampleMapping, lPfiles, vid, OrgID, deptID, ApprovadBy, gUID, out returnStatus, lstReflexPatientinvestigation, isFromDevice);
                if (returnStatus >= 0)
                {
                    //List<PatientInvestigation> lstNonApprovedInvestigation = lstInvestigation.FindAll(P => P.Status != InvStatus.Approved);
                    //if (lstNonApprovedInvestigation != null && lstNonApprovedInvestigation.Count == 0)
                    //{
                    //    ActionManager objActionManager = new ActionManager();
                    //    objActionManager.PerformingNextStep(PageContextDetails);
                    //}
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvestigationResults in Investigation_BL", excp);
            }

            return returnCode;
        }
        //----------------------------------------------------------------------------------//

        public long GetPatientComparisonReport(string pPatientIds, List<InvestigationMaster> lstInvID, string IsRerun, long pPageID, out List<TrendAnalysis> lstGetPatientComparisonResult)
        {
            long returnCode = -1;
            lstGetPatientComparisonResult = new List<TrendAnalysis>();
            Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
            try
            {
                returnCode = InvDAL.GetPatientComparisonReport(pPatientIds, lstInvID, IsRerun, pPageID, out lstGetPatientComparisonResult);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientComparisonReport in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientTestLevelResult(string VisitNumber, string PatientNumber, long pPageID, out List<Patient> lstPatientDetails, out List<TrendAnalysis> lstGetPatientTestLevelResult)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            lstGetPatientTestLevelResult = new List<TrendAnalysis>();
            Investigation_DAL InvDAL = new Investigation_DAL(globalContextDetails);
            try
            {
                returnCode = InvDAL.GetPatientTestLevelResult(VisitNumber, PatientNumber, pPageID, out lstPatientDetails, out lstGetPatientTestLevelResult);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientTestLevelResult in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long GetInBoundListForLIMS(int OrgID, string Status, out List<HLMessages> lstHl7InBoundMessageDetails, out List<HLMessagePatientIDDetails> lstPatient, out List<HLMessageOBRDetails> lstHLMessageOBRDetails)
        {
            lstHl7InBoundMessageDetails = new List<HLMessages>();
            lstPatient = null;
            lstHLMessageOBRDetails = null;
            long returnCode = -1;
            try
            {
                Investigation_DAL INDAL = new Investigation_DAL();
                returnCode = INDAL.GetInBoundListForLIMS(OrgID, Status, out lstHl7InBoundMessageDetails, out lstPatient, out lstHLMessageOBRDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Saving GetInBoundListForLIMS ", ex);
            }
            return returnCode;
        }
        public long CheckHL7InboundService(int pInterval, string pServiceType, DateTime pProcessingTime, out string pIsActive)
        {
            long result = -1;
            pIsActive = "N";
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.CheckHL7InboundService(pInterval, pServiceType, pProcessingTime, out pIsActive);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CheckHL7InboundService in Investigation_BL", ex);
            }
            return result;
        }
        public long getPakageDetails(int ID, out List<PackageDetails> lstpkgdetails)
        {
            long result = -1;
            lstpkgdetails = new List<PackageDetails>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.getPakageDetails(ID, out lstpkgdetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getPakageDetails in Investigation_BL", ex);
            }
            return result;
        }
        public long UpdateInBoundMsgDetails(int OrgID, DataTable DtApprovedXML)
        {
            long retCode = -1;
            int ret = -1;
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.UpdateInBoundMsgDetails(OrgID, DtApprovedXML);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving UpdateInBoundMsgDetils Investigation_BL", ex);
            }
            return retCode;
        }
        public DataSet GetHLMessageDetails(int orgid, string MessageControlId, string MessageType, string DateTime, string PatientIdentifier)
        {
            DataSet ds = new DataSet();
            try
            {
                Investigation_DAL invDaL = new Investigation_DAL(globalContextDetails);
                ds = invDaL.GetHLMessageDetail(orgid, MessageControlId, MessageType, DateTime, PatientIdentifier);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetInvestigationsDetail", ex);
            }
            return ds;
        }
        public long GetBatchWiseWorklistforspecialsamples(string WorkListType, long SearchID, long deptid, int OrgID, string WLMode, string fromDate, string toDate, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.GetBatchWiseWorklistforspecialsamples(WorkListType, SearchID, deptid, OrgID, WLMode, fromDate, toDate, out lstPatientInvestigation);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetBatchWiseWorklist BL", excp);
            }
            return returnCode;
        }

        public long getBlockSlidePreparation(long VisitNumber, string BarCode, out List<BlockSlideBarcodePreparation> lstBarcodeDetails)
        {
            long lresult = -1;
            lstBarcodeDetails = new List<BlockSlideBarcodePreparation>();

            try
            {

                Investigation_DAL invdal = new Investigation_DAL(globalContextDetails);

                lresult = invdal.GetBlockSlidePreparation(VisitNumber, BarCode, out lstBarcodeDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getBlockSlidePreparation BL", ex);
            }
            return lresult;
        }

        public long pUpdateBlockSlideDetails(string PrimaryBarcode, string BarcodeNumber, string BlockType, string SlideName, string StainType, string SlideComments, long Orgid)
        {
            long lresult = -1;
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                lresult = invDAL.pUpdateBlockSlideDetails(PrimaryBarcode, BarcodeNumber, BlockType, SlideName, StainType, SlideComments, Orgid);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing GetPatientSex BL", ex);
            }
            return lresult;
        }
        public long GetHistoDeptTestNames(int DeptID, out List<InvDeptMaster> lsttestname)
        {
            long lresult = -1;
            lsttestname = new List<InvDeptMaster>();
            try
            {

                Investigation_DAL invdal = new Investigation_DAL(globalContextDetails);
                lresult = invdal.GetHistoDeptTestNames(DeptID, out lsttestname);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientSex BL", ex);
            }
            return lresult;
        }
        public long GetKPIReport(DateTime fromdate, DateTime todate, int DeptID, int TestID, out List<HistopathologyReport> lsthisto)
        {
            long lresult = -1;
            lsthisto = new List<HistopathologyReport>();
            try
            {

                Investigation_DAL invdal = new Investigation_DAL(globalContextDetails);
                lresult = invdal.GetKPIReport(fromdate, todate, DeptID, TestID, out lsthisto);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientSex BL", ex);
            }
            return lresult;
        }

        public long InsertNotGivenSample(long PatientVisitID, int SampleID, int InvStatusID, string InvReason, long CreatedBy, long AccessionNo)
        {
            long retCode = -1;
            try
            {
                retCode = new Investigation_DAL(globalContextDetails).InsertNotGivenSample(PatientVisitID, SampleID, InvStatusID, InvReason, CreatedBy, AccessionNo);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing InsertNotGivenSample in Investigation_BL", e);
            }
            return retCode;

        }

        public string PGetConfidential(long pVisit)
        {
            string lresult = string.Empty;

            try
            {
                Investigation_DAL IDAL = new Investigation_DAL(globalContextDetails);
                lresult = IDAL.PGetConfidential(pVisit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PGetConfidential Investigation_BL", ex);
            }
            return lresult;

        }
        //Added by Jegan

        public long pGetpatientInvestigationValues(string visitNumber, string BarcodeNumber, int orgID, int LocationID, out List<InvestigationValues> lstInvestigationValues)
        {
            long returnCode = -1;
            lstInvestigationValues = new List<InvestigationValues>();

            try
            {
                new Investigation_DAL(globalContextDetails).pGetpatientInvestigationValues(visitNumber, BarcodeNumber, orgID, LocationID, out lstInvestigationValues);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetpatientInvestigationValues in Investigation_BL", ex);
            }
            return returnCode;
        }
        //Added by Jegan
        public long GetIsAutoAuthorization(long VisitID, int OrgID, int AutoAuthorizationCount, long InvID, out int ReturnCode)
        {
            long result = -1;
            ReturnCode = 0;
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.GetIsAutoAuthorization(VisitID, OrgID, AutoAuthorizationCount, InvID, out ReturnCode);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIsAutoAuthorization in Investigation_BL", ex);
            }
            return result;

        }
        public long GetIsActiveOrganismList(long pInvID, out int IsActive)
        {
            long returnCode = -1;
            IsActive = -1;
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetIsActiveOrganismList(pInvID, out IsActive);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIsActiveOrganismList in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long InsertUpdateOrganismMaster(OrganismMaster organismMaster, out int Id)
        {
            long returnCode = -1;
            Id = -1;
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.InsertUpdateOrganismMaster(organismMaster, out Id);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIsActiveOrganismList in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long InsertUpdateFamilyMaster(InvestigationDrugFamilyMaster familyMaster, out int Id)
        {
            long returnCode = -1;
            Id = -1;
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.InsertUpdateFamilyMaster(familyMaster, out Id);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertUpdateFamilyMaster in Investigation_BL", ex);
            }

            return returnCode;
        }
        /* BEGIN | sabari | 20181129 | Dev | Culture Report */
        public long InsertUpdateDrugLevelMapping(List<DrugLevelMapping> lstDrugLevelMapping, out int Id)
        {
            long returnCode = -1;
            Id = -1;
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.InsertUpdateDrugLevelMapping(lstDrugLevelMapping, out Id);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertUpdateDrugLevelMapping in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetDrugLevelMappingDetails(out List<DrugLevelMapping> lstDrugLevelMapping)
        {
            long returnCode = -1;
            lstDrugLevelMapping = new List<DrugLevelMapping>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetDrugLevelMappingDetails(out lstDrugLevelMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDrugLevelMappingDetails in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetOrganismDrugLevelMapDetails(long DrugID, out List<DrugLevelMapping> lstDrugLevelMapping)
        {
            long returnCode = -1;
            lstDrugLevelMapping = new List<DrugLevelMapping>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetOrganismDrugLevelMapDetails(DrugID, out lstDrugLevelMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrganismDrugLevelMapDetails in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetIsActiveDrugLevelMapping(long pInvID, out int IsActive)
        {
            long returnCode = -1;
            IsActive = -1;
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetIsActiveDrugLevelMapping(pInvID, out IsActive);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIsActiveDrugLevelMapping in Investigation_BL", ex);
            }

            return returnCode;
        }
        /*XL Upload Starts*/
        public DataSet OrganismMasterBulkUpload(int OrgID, string UploadXLMasterType, string UploadXLMasterCode, DataTable DtTbl)
        {
            // long returnCode = -1;

            DataSet ds = new DataSet();
            try
            {
                Investigation_DAL objinvDAL = new Investigation_DAL(globalContextDetails);
                ds = objinvDAL.OrganismMasterBulkUpload(OrgID, UploadXLMasterType, UploadXLMasterCode, DtTbl);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveClientRateMappingBulkLoad Patient_Bl", e);
            }
            return ds;
        }
        /*XL Upload Ends*/
        /* END | sabari | 20181129 | Dev | Culture Report */
        public long GetMappedDrugBrand(long OrganismId, long InvestigationId, out List<InvestigationDrugBrand> lstDrugBrand)
        {
            long returnCode = -1;
            lstDrugBrand = new List<InvestigationDrugBrand>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetMappedDrugBrand(OrganismId, InvestigationId, out lstDrugBrand);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetMappedDrugBrand in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetInvestigationDrugFamilyList(out List<InvestigationDrugFamilyMaster> lstFamilyMaster)
        {
            long returnCode = -1;
            lstFamilyMaster = new List<InvestigationDrugFamilyMaster>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetInvestigationFamilymList(out lstFamilyMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationDrugFamilyList in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetInvestigationDrugFamilyListHistory(long Id, out List<InvestigationDrugFamilyMaster> lstFamilyMaster)
        {
            long returnCode = -1;
            lstFamilyMaster = new List<InvestigationDrugFamilyMaster>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetInvestigationFamilymListHistory(Id, out lstFamilyMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationDrugFamilyListHistory in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetOrganismListHistory(long ID, out List<OrganismMaster> lstOrganismMaster)
        {
            long returnCode = -1;
            lstOrganismMaster = new List<OrganismMaster>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetOrganismListHistory(ID, out lstOrganismMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrganismListHistory in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetIsActiveDrugFamilyList(long pInvID, out int IsActive)
        {
            long returnCode = -1;
            IsActive = -1;
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetIsActiveDrugFamilyList(pInvID, out IsActive);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIsActiveDrugFamilyList in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetOrganismMappingList(long Id, out List<InvOrganismDrugMapping> lstInvOrganismDrugMapping)
        {
            long returnCode = -1;
            lstInvOrganismDrugMapping = new List<InvOrganismDrugMapping>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetOrganismMappingList(Id, out lstInvOrganismDrugMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIsActiveDrugFamilyList in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long InsertUpdateOrganismMapping(long pInvID, DataTable dtValues)
        {
            long returnCode = -1;

            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.InsertUpdateOrganismMapping(pInvID, dtValues);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIsActiveDrugFamilyList in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetFamilyIdByName(string Name, out List<InvestigationDrugFamilyMaster> lstInvestigationDrugFamilyMaster)
        {
            long returnCode = -1;
            lstInvestigationDrugFamilyMaster = new List<InvestigationDrugFamilyMaster>();
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.GetFamilyIdByName(Name, out lstInvestigationDrugFamilyMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIsActiveDrugFamilyList in Investigation_BL", ex);
            }

            return returnCode;
        }

        public long GetDeptBatchWiseInvestigationResultsCaptureFormat(string VIDs, int OrgID, string BarcodeNumber, long RoleID, long DeptID, long InvID, string InvType, LoginDetail LDetail,
                  string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalID, string pActionName, string pIsMaster, int pRecordCount, string visittype, string Location, string QcCheck, string PatIds,
                  string CollectionLocID, DateTime fromdate, DateTime todate, out List<PatientInvestigation> lstInvestigation, string Status)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetDeptBatchWiseInvestigationResultsCaptureFormat(VIDs, OrgID, BarcodeNumber, RoleID, DeptID, InvID, InvType, LDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalID, pActionName, pIsMaster, pRecordCount, visittype, Location, QcCheck, PatIds, CollectionLocID, fromdate, todate, out lstInvestigation, Status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseInvestigationResultsCaptureFormat in Investigation_BL", ex);
            }
            return result;
        }
        public long GetBatchWiseInvestigationResultsCaptureFormat(string VIDs, int OrgID, string BarcodeNumber, long RoleID, long DeptID, long InvID, string InvType, LoginDetail LDetail,
                  string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalID, string pActionName, string pIsMaster, int pRecordCount, string visittype, string Location, string QcCheck, string PatIds,
                  out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetBatchWiseInvestigationResultsCaptureFormat(VIDs, OrgID, BarcodeNumber, RoleID, DeptID, InvID, InvType, LDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalID, pActionName, pIsMaster, pRecordCount, visittype, Location, QcCheck, PatIds, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseInvestigationResultsCaptureFormat in Investigation_BL", ex);
            }
            return result;
        }

        public long CheckIsValidtoTransferNew(List<PatientInvSample> lstpinvsample, out List<CollectedSample> lstpinvsampleVisits)
        {
            long returnCode = -1;
            lstpinvsampleVisits = new List<CollectedSample>();
            Investigation_DAL InvDaL = new Investigation_DAL(globalContextDetails);
            try
            {
                returnCode = InvDaL.CheckIsValidtoTransferNew(lstpinvsample, out lstpinvsampleVisits);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CheckIsValidtoTransferNew in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long UpdateSampleTransferNew(List<PatientInvSample> lstPatientInvSample)
        {
            long retCode = -1;
            //DataTable invPMDT = GetInvPackageMappingDataTable(lstInvPackageMapping);
            //DataTable inv = GetInvPackage(lstDeletedPackageMapping);
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.UpdateSampleTransferNew(lstPatientInvSample);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateSampleTransfer in Investigation_BL", e);
            }
            return retCode;
        }

        public long GetInvSamplesTransferStatusNew(int OrgID, string FromDate, string ToDate, int Status, int LocationID, string LocationType, string VisitID,
string PatientName, int VisitType, int Priority, string SourceName, string InvestigationName, long InvestigationID, string InvestigationType,
string refPhyName, long refPhyID, long refPhyOrg, long SampleID, int SearchType,
out List<CollectedSample> lstSamples, int pagesize, int startRowIndex, out int totalrows, int SmpleID, int ProcessedLocID, int OutSourceID, string BarcodeNo,
      int ContainerID, int proLocation)
        {
            long returncode = -1;
            totalrows = -1;
            lstSamples = new List<CollectedSample>();
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).GetInvSamplesTransferStatusNew(OrgID, FromDate, ToDate, Status, LocationID, LocationType, VisitID,
            PatientName, VisitType, Priority, SourceName, InvestigationName, InvestigationID, InvestigationType,
            refPhyName, refPhyID, refPhyOrg, SampleID, SearchType, out lstSamples, pagesize, startRowIndex, out totalrows, SmpleID, ProcessedLocID, OutSourceID, BarcodeNo, ContainerID, proLocation);

                /*-----------------Handle VIP Data Start-------------------------*/
                List<CollectedSample> lsttempDetails = new List<CollectedSample>();
                lsttempDetails = lstSamples.FindAll(P => P.PatientStatus == "VIP");
                lstSamples.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returncode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (CollectedSample)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returncode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (CollectedSample)Maskedobj;
                    lstSamples.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetInvSamplesTransferStatusNew", ex);
            }
            return returncode;
        }
        public long Updatedeltacheckstatus(long patientvisitid, long Invid, bool IsdeltacheckPass)
        {
            long retCode = -1;
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                retCode = invDAL.Updatedeltacheckstatus(patientvisitid, Invid, IsdeltacheckPass);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing Update patientinvestigationattributes in Investigation_BL", e);
            }
            return retCode;
        }
        public DataSet InterfacedValueWorklist(string worklistType, long SearchID, string Testtype, int orgid, string WLMode, string fromdate, string todate, long minvid, long maxvid, string visitnumber)
        {
            DataSet set = new DataSet();
            try
            {
                set = new Investigation_DAL(this.globalContextDetails).InterfacedValueWorklist(worklistType, SearchID, Testtype, orgid, WLMode, fromdate, todate, minvid, maxvid, visitnumber);
            }
            catch (Exception exception)
            {
                CLogger.LogError("Error in Investigation_BL - InterfacedValueWorklist", exception);
            }
            return set;
        }
        /* BEGIN | NA | Sabari | 20181202 | Created | HOLD */
        public long GetInvestigatonResultsCaptureHoldOrApprovelTaskDetailsByVID(string _VisitNumber, string _LabNumber, string _PatientName, LoginDetail LDetail, out List<TaskDetails> lstTasks)
        {
            long result = -1;
            lstTasks = new List<TaskDetails>();
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetInvestigatonResultsCaptureHoldOrApprovelTaskDetailsByVID(_VisitNumber, _LabNumber, _PatientName, LDetail, out lstTasks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigatonResultsCaptureHoldOrApprovel in Investigation_BL", ex);
            }
            return result;
        }
        public long GetInvestigatonResultsCaptureUnHoldTaskDetails(int startRowIndex, int pageSize, out int totalRows, LoginDetail LDetail, out List<TaskDetails> lstTasks)
        {
            long returnCode = -1;
            lstTasks = null;
            totalRows = -1;

            try
            {


                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                returnCode = DemoDal.GetInvestigatonResultsCaptureUnHoldTaskDetails(startRowIndex, pageSize, out totalRows, LDetail, out lstTasks);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing Investigation BL", excp);
            }


            return returnCode;
        }
        public long GetInvestigationResultsCaptureForUnHold(long VID, int OrgID, long RoleID, string gUID, long DeptID, string InvIDs, int LocationID,
                                              LoginDetail LDetail, long taskid, string IsTrustedDetails, string status,
                                                 out List<PatientInvestigation> lstInvestigation,
                                                 out List<InvestigationStatus> lstStatus,
                                                 out List<RoleDeptMap> lRoleDeptmap
            //, out List<InvReportMaster> lEditInvestigationValues
            //, out List<InvestigationHeader> lstHeader
                                                 )
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            lRoleDeptmap = new List<RoleDeptMap>();
            //lEditInvestigationValues = new List<InvReportMaster>();
            //lstHeader = new List<InvestigationHeader>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetInvestigationResultsCaptureForUnHold(VID, OrgID, RoleID, gUID, DeptID, InvIDs, LocationID, LDetail, taskid, IsTrustedDetails, status, out lstInvestigation, out lstStatus, out lRoleDeptmap);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationResultsCaptureForHold in Investigation_BL", ex);
            }
            return result;
        }
        /* BEGIN | NA | Sabari | 20181202 | Created | HOLD */
        public long GetInvestigatonResultsCaptureToHold(long VID, int OrgID, long RoleID, string gUID, long DeptID, string InvIDs, int LocationID,
                                                      LoginDetail LDetail, long taskid, string IsTrustedDetails, string status,
                                                         out List<PatientInvestigation> lstInvestigation,
                                                         out List<InvestigationStatus> lstStatus,
                                                         out List<RoleDeptMap> lRoleDeptmap
            //, out List<InvReportMaster> lEditInvestigationValues
            //, out List<InvestigationHeader> lstHeader
                                                         )
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            lRoleDeptmap = new List<RoleDeptMap>();
            //lEditInvestigationValues = new List<InvReportMaster>();
            //lstHeader = new List<InvestigationHeader>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetInvestigatonResultsCaptureToHold(VID, OrgID, RoleID, gUID, DeptID, InvIDs, LocationID, LDetail, taskid, IsTrustedDetails, status, out lstInvestigation, out lstStatus, out lRoleDeptmap);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigatonResultsCaptureToHold in Investigation_BL", ex);
            }
            return result;
        }
        /* END | NA | Sabari | 20181202 | Created | HOLD */
        public long SaveUnHoldDetails(List<PatientInvestigation> lstInvestigation)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                returnCode = DemoDal.SaveUnHoldDetails(lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveUnHoldDetails in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long UpdateNotificationForApprovedHold(long visitID, int orgID)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                returnCode = DemoDal.UpdateNotificationForApprovedHold(visitID, orgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateNotificationForApprovedHold in Investigation_BL", ex);
            }
            return returnCode;
        }
        /* END | NA | Sabari | 20181202 | Created | HOLD */
        /* BEGIN | NA | Sabari | 20190508 | Created | BulkEnterResult */
        public long GetBatchWiseInvestigationResultsCaptureFormatBulkEnterResult(string VIDs, int OrgID, string BarcodeNumber, long RoleID, long DeptID, long InvID, string InvType, LoginDetail LDetail,
            string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalID, string pActionName, string pIsMaster, int pRecordCount, string visittype, string Location, string QcCheck, string PatIds,
            string CollectLocID, out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetBatchWiseInvestigationResultsCaptureFormatBulkEnterResult(VIDs, OrgID, BarcodeNumber, RoleID, DeptID, InvID, InvType, LDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalID, pActionName, pIsMaster, pRecordCount, visittype, Location, QcCheck, PatIds, CollectLocID, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseInvestigationResultsCaptureFormat in Investigation_BL", ex);
            }
            return result;
        }
        /* END | NA | Sabari | 20190508 | Created | BulkEnterResult */

        public long SaveSensitiveTestRemarks(long iVisitID, long iPatientID, long iTaskID, string patienthistory, string remarks)
        {
            long returncode = -1;
            try
            {
                returncode = new Investigation_DAL(globalContextDetails).SaveSensitiveTestRemarks(iVisitID, iPatientID, iTaskID, patienthistory, remarks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL SaveSensitiveTestRemarks", ex);
            }
            return returncode;
        }
        public long GetIsSensitiveTestForVisit(long VisitID, long InvestigationID, int orgID, long AccessionNumber, string Status, string Type, out List<OrderedInvestigations> lstIO)
        {
            long returnCode = -1;
            lstIO = new List<OrderedInvestigations>();

            try
            {
                new Investigation_DAL(globalContextDetails).GetIsSensitiveTestForVisit(VisitID, InvestigationID, orgID, AccessionNumber, Status, Type, out lstIO);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIsSensitiveTestForVisit in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long PgetPreQuotation(int OrgID, string Searchtext, out List<InvestigationValues> PgetPreQuotation)
        {
            long result = -1;
            PgetPreQuotation = new List<InvestigationValues>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.PgetPreQuotation(OrgID, Searchtext, out PgetPreQuotation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getPakageDetails in Investigation_BL", ex);
            }
            return result;
        }
        public long pGetBillingTestItemsSV(int OrgID, int FeeID, string FeeType, out List<BillingDetails> pGetBillingTestItemsSV)
        {
            long result = -1;
            pGetBillingTestItemsSV = new List<BillingDetails>();
            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                result = invDAL.pGetBillingTestItemsSV(OrgID, FeeID, FeeType, out pGetBillingTestItemsSV);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getPakageDetails in Investigation_BL", ex);
            }
            return result;
        }

        public long PreQuotationBilling(int BookingID, int OrgID, out List<Bookings> lstPatientDetailes, out List<BillingDetails> lstPreQuotationBilling)
        {
            long returnCode = -1;
            lstPatientDetailes = new List<Bookings>();
            lstPreQuotationBilling = new List<BillingDetails>();

            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
                returnCode = invDAL.PreQuotationBilling(BookingID, OrgID, out lstPatientDetailes, out lstPreQuotationBilling);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getPakageDetails in Investigation_BL", ex);
            }
            return returnCode;
        }
        public long SaveOrderLocation(List<OrderedInvestigations> lstOrderInvestigation, int OrgID, string TaskAssignTo)
        {
            long returncode = -1;
            Investigation_DAL invdal = new Investigation_DAL(globalContextDetails);

            try
            {
                returncode = invdal.SaveOrderLocation(lstOrderInvestigation, OrgID, TaskAssignTo);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveOrderLocation in Investigation_BL", excp);
            }
            return returncode;
        }
        public long SaveOrganismRangeValues(List<InvOrganismDrugMapping> lstOrganismDrugDetails)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL oInvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = oInvestigationDAL.SaveOrganismRangeValues(lstOrganismDrugDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveOrganismRangeValues in Investigation_BL", ex);
            }

            return returnCode;
        }
        /* BEGIN | NA | Sabari | 17072019 | Created | LabTechPhysicianUsers */
        public long GetInvestigatonResultsCaptureSingleScreen(long VID, int OrgID, long RoleID, string gUID, long DeptID, string InvIDs, int LocationID,
                                                      LoginDetail LDetail, long taskid, string IsTrustedDetails, string status,
                                                         out List<PatientInvestigation> lstInvestigation,
                                                         out List<InvestigationStatus> lstStatus,
                                                         out List<RoleDeptMap> lRoleDeptmap
            //, out List<InvReportMaster> lEditInvestigationValues
            //, out List<InvestigationHeader> lstHeader
                                                         )
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            lRoleDeptmap = new List<RoleDeptMap>();
            //lEditInvestigationValues = new List<InvReportMaster>();
            //lstHeader = new List<InvestigationHeader>();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetInvestigatonResultsCaptureSingleScreen(VID, OrgID, RoleID, gUID, DeptID, InvIDs, LocationID, LDetail, taskid, IsTrustedDetails, status, out lstInvestigation, out lstStatus, out lRoleDeptmap);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigatonResultsCaptureSingleScreen in Investigation_BL", ex);
            }
            return result;
        }
        public long GetDrawPatternInvBulkDataSingleScreen(string guid, List<InvPackageMapping> lstInvPackageMapping, long patientVisitID, int orgID, string status,
                 out List<InvestigationValues> lstBulkData
            , out List<InvestigationValues> lstPendingValue, out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom, out List<PerformingPhysician> lPerformingPhysicain)
        {
            long result = -1;
            lstBulkData = new List<InvestigationValues>();
            lstPendingValue = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();
            lPerformingPhysicain = new List<PerformingPhysician>();
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetDrawPatternInvBulkDataSingleScreen(guid, lstInvPackageMapping, patientVisitID, orgID, status, out lstBulkData, out lstPendingValue, out header, out  lstiom, out lPerformingPhysicain);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDrawPatternInvBulkDataSingleScreen in Investigation_BL", ex);
            }
            return result;
        }
        public long SaveInvestigationResultsSingleScreen(long pSCMID, List<List<InvestigationValues>> lstInvestigationValues, List<PatientInvestigation> lstInvestigation, List<PatientInvSampleResults> lstPatientInvSampleResults, List<PatientInvSampleMapping> lstPatientInvSampleMapping, List<PatientInvestigationFiles> lPfiles, long vid, int OrgID, int deptID, long ApprovadBy, string gUID, PageContextkey PageContextDetails, out int returnStatus, List<PatientInvestigation> lstReflexPatientinvestigation, string isFromDevice)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {

                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.SaveInvestigationResultsSingleScreen(pSCMID, lstInvestigationValues, lstInvestigation, lstPatientInvSampleResults, lstPatientInvSampleMapping, lPfiles, vid, OrgID, deptID, ApprovadBy, gUID, out returnStatus, lstReflexPatientinvestigation, isFromDevice);
                if (returnStatus >= 0)
                {
                    //List<PatientInvestigation> lstNonApprovedInvestigation = lstInvestigation.FindAll(P => P.Status != InvStatus.Approved);
                    //if (lstNonApprovedInvestigation != null && lstNonApprovedInvestigation.Count == 0)
                    //{
                    //    ActionManager objActionManager = new ActionManager();
                    //    objActionManager.PerformingNextStep(PageContextDetails);
                    //}
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvestigationResultsSingleScreen in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long SavePatientInvestigationSingleScreen(List<PatientInvestigation> PatientInvestigation, long OrgID, string gUID, out int pOrderedInvCnt)
        {
            long retCode = -1;
            int ret = -1;
            pOrderedInvCnt = 0;


            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.SavePatientInvestigationSingleScreen(PatientInvestigation, OrgID, gUID, out pOrderedInvCnt);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SavePatientInvestigationSingleScreen in Investigation_BL", e);
            }
            return retCode;
        }
        public long SavePatientInvSampleNMappingSingleScreen(List<PatientInvSample> LstPinvsample, List<PatientInvSampleMapping> LstPinvsamplemapping, string GUID, int orgid)
        {
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL(globalContextDetails);
                returnCode = ObjDAL.SavePatientInvSampleNMappingSingleScreen(LstPinvsample, LstPinvsamplemapping, GUID, orgid);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SavePatientInvSampleNMappingSingleScreen in Investigation_BL", excp);
            }

            return returnCode;
        }
        /* END | NA | Sabari | 17072019 | Created | LabTechPhysicianUsers */

        public long UpdatenotificationforCancel(long visitID)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                returnCode = DemoDal.UpdatenotificationforCancel(visitID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdatenotificationforCancel in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetOrganismByStaintype(int CultureStainTypeId, int ResultID, int OrgID, string ResultTemplateType, out List<InvResultTemplate> lstOrganism)
        {
            long returnCode = -1;
            Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);
            returnCode = invDAL.GetOrganismByStaintype(CultureStainTypeId, ResultID, OrgID, ResultTemplateType, out lstOrganism);
            return returnCode;
        }
        public long UpdatePatientVisitInvestigationStatus(List<PatientInvestigation> InvestigationList, string gUID, out int returnStatus)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {

                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.UpdatePatientVisitInvestigationStatus(InvestigationList, gUID, out returnStatus);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdatePatientVisitInvestigationStatus in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long GetVisitWiseInvestigationResults(string VIDs, int OrgID, string BarcodeNumber, long RoleID, long DeptID, long InvID, string InvType, LoginDetail LDetail,
            string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalID, string pActionName, string pIsMaster, int pRecordCount, string visittype, string Location, string QcCheck, string PatIds,
            string CollectionLocID, DateTime fromdate, DateTime todate, out DataSet lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new DataSet();

            try
            {
                Investigation_DAL DemoDal = new Investigation_DAL(globalContextDetails);
                result = DemoDal.GetVisitWiseInvestigationResults(VIDs, OrgID, BarcodeNumber, RoleID, DeptID, InvID, InvType, LDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalID, pActionName, pIsMaster, pRecordCount, visittype, Location, QcCheck, PatIds, CollectionLocID, fromdate, todate, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetVisitWiseInvestigationResults in Investigation_BL", ex);
            }
            return result;
        }

        public long SaveInvestigationQCResults(string Barcode, int OrgID, int OrgAddressID, List<InvIntegrationQCResultValue> lstInvIntegrationQCResultValue, out int returnStatus)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.SaveInvestigationQCResults(Barcode, OrgID, OrgAddressID, lstInvIntegrationQCResultValue, out returnStatus);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvestigationQCResults in Investigation_BL", excp);
            }

            return returnCode;
        }

        public long GetQCResultValidationDetails(string DeviceID, string LotNumber, string TestCode, string Level, int OrgID, out List<QCResultValidationDetails> lstQCValidateDetails, out List<QCResultDetails> lstlotResults, out List<QCResultDetails> lstotherlotResults)
        {
            long returnCode = -1;
            lstQCValidateDetails = new List<QCResultValidationDetails>();
            lstlotResults = new List<QCResultDetails>();
            lstotherlotResults = new List<QCResultDetails>();
            try
            {
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.GetQCResultValidationDetails(DeviceID, LotNumber, TestCode, Level, OrgID, out lstQCValidateDetails, out lstlotResults, out lstotherlotResults);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvestigationQCResults in Investigation_BL", excp);
            }

            return returnCode;
        }
        public long GetInvestigationInstruction(long PatientvisitID, int OrgID, int FeeID, string FeeType, out List<OrderedInvestigations> lstOrderedInstruction)
        {
            long returnCode = -1;
            lstOrderedInstruction = new List<OrderedInvestigations>();
            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).GetInvestigationInstruction(PatientvisitID, OrgID, FeeID, FeeType, out lstOrderedInstruction);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetUOMCode in Investigation_BL", ex);
            }

            return returnCode;
        }
        public long GetBulkRegIntegrationNotifications(int InstanceID, out List<BulkRegIntegration> lstBulkRegIntegrations,out List<BulkRegFileDetails> lsfile)
        {
            lstBulkRegIntegrations = new List<BulkRegIntegration>();
            lsfile = new List<BulkRegFileDetails>();
            long returnCode = -1;
            try
            {
                Investigation_DAL INDAL = new Investigation_DAL();
                returnCode = INDAL.GetBulkRegIntegrationNotifications(InstanceID, out lstBulkRegIntegrations, out lsfile);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While getting GetBulkRegIntegrationNotifications ", ex);
            }
            return returnCode;


        }

        public long GetBulkRegIntegrationResultValue(long NotificationID, out List<BulkRegIntegrationResultValue> lstBulkRegIntegrationResultValue)
        {
            lstBulkRegIntegrationResultValue = new List<BulkRegIntegrationResultValue>();
            long returnCode = -1;
            try
            {
                Investigation_DAL INDAL = new Investigation_DAL(globalContextDetails);
                returnCode = INDAL.GetBulkRegIntegrationResultValue(NotificationID, out lstBulkRegIntegrationResultValue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Saving GetFeedbackNotifications ", ex);
            }
            return returnCode;


        }


        public long UpdateBulkRegIntegrationNotifications(int InstanceID, List<BulkRegIntegration> lstBulkRegIntegrations)
        {
            long retCode = -1;
            // lstFeedbackNotifications = new List<FeedbackNotifications>();

            try
            {
                Investigation_DAL invDAL = new Investigation_DAL(globalContextDetails);

                retCode = invDAL.UpdateBulkRegIntegrationNotifications(InstanceID, lstBulkRegIntegrations);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving UpdateInBoundMsgDetils Investigation_BL", ex);
            }
            return retCode;
        }

        public long SaveOutSourcingPDFFilesDetails(string visitNumber, string testCode, string orgCode, string filePath,string ActionType)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Investigation_DAL(globalContextDetails).SaveOutSourcingPDFFilesDetails(visitNumber, testCode, orgCode, filePath,ActionType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveOutSourcingPDFFilesDetails in Investigation_BL", ex);
            }

            return returnCode;
        }
		
        public long GetOutSourcePDFFileDetails(long pPatientVisitid, long pInvestigationId, long POrgID, out List<PatientInvestigationFiles> lstpatientImages)
        {
            lstpatientImages = new List<PatientInvestigationFiles>();
            long returnCode = -1;
            try
            {
                Attune.Solution.DAL.Investigation_DAL ObjDAL = new Investigation_DAL();
                returnCode = ObjDAL.GetOutSourcePDFFileDetails(pPatientVisitid, pInvestigationId, POrgID, out lstpatientImages);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetOutSourcePDFFileDetails in Investigation_BL", excp);
            }
            return returnCode;
        }
		 public long GetValidateAutoCertify(long investigationid, int orgid, long visitid, long groupid, out List<InvAutoCertifyValidation> objInvAutoCertifyValidation, out  List<InvAutoCertifyValidation> lstCrossInvAutoCertifyValidation)
        {
            long returnCode = -1;
            objInvAutoCertifyValidation = new List<InvAutoCertifyValidation>();
            lstCrossInvAutoCertifyValidation = new List<InvAutoCertifyValidation>();
            try
            {
                Investigation_DAL objDL = new Investigation_DAL(globalContextDetails);
                returnCode = objDL.GetValidateAutoCertify(investigationid, orgid, visitid, groupid, out objInvAutoCertifyValidation, out lstCrossInvAutoCertifyValidation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetValidateAutoCertify Investigation_BL", ex);
            }
            return returnCode;
        }


        public long CalculateFormulatest(long groupid, long visitid, long orgid,long investigationid,string value,string deviceID, out List<InvestigationValues> lstInvValues)
        {
            long returnCode = -1;
            lstInvValues = new List<InvestigationValues>();
            try
            {
                Investigation_DAL objDL = new Investigation_DAL(globalContextDetails);
                returnCode = objDL.CalculateFormulatest(groupid, visitid, orgid, investigationid, value, deviceID, out lstInvValues);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CalculateFormulatest Investigation_BL", ex);
            }
            return returnCode;
        }

        public long SaveInvRulemaster(List<InvRuleMaster> lstInvRuleMaster, List<PatientAgeGenderRule> lstPatientAgeGenderRule, List<TestResultsRule> lstTestResultsRule, List<MachineErrorRule> lstMachineErrorRule, int orgID, int RemarksId, out  List<InvRuleMaster> lstOutInvRuleMaster)
        {
            long returnCode = -1;
            lstOutInvRuleMaster = new List<InvRuleMaster>();
            try
            {   
                Investigation_DAL InvestigationDAL = new Investigation_DAL(globalContextDetails);
                returnCode = InvestigationDAL.SaveInvRulemaster(lstInvRuleMaster, lstPatientAgeGenderRule, lstTestResultsRule, lstMachineErrorRule, orgID,RemarksId, out lstOutInvRuleMaster);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveInvRulemaster in Investigation_BL", excp);
            }

            return returnCode;
        }

        public long GetInvRulemaster(int RuleTypeid, long investigationid, int orgid,int RemarksId, out List<InvRuleMaster> lstInvRuleMaster, out  List<PatientAgeGenderRule> lstPatientAgeGenderRule, out List<TestResultsRule> lstTestResultsRule, out List<MachineErrorRule> lstMachineErrorRule)
        {
            long returnCode = -1;
            lstInvRuleMaster = new List<InvRuleMaster>();
            lstPatientAgeGenderRule = new List<PatientAgeGenderRule>();
            lstTestResultsRule = new List<TestResultsRule>();
            lstMachineErrorRule = new List<MachineErrorRule>();
            try
            {
                Investigation_DAL objDL = new Investigation_DAL(globalContextDetails);
                returnCode = objDL.GetInvRulemaster(RuleTypeid, investigationid, orgid,RemarksId, out lstInvRuleMaster, out lstPatientAgeGenderRule, out lstTestResultsRule, out  lstMachineErrorRule);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvRulemaster Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvRulemasterCondition(int RuleTypeid, long investigationid, int orgid, string InvType, out List<InvRuleMaster> lstInvRuleMaster)
        {
            long returnCode = -1;
            lstInvRuleMaster = new List<InvRuleMaster>();
            try
            {
                Investigation_DAL objDL = new Investigation_DAL(globalContextDetails);
                returnCode = objDL.GetInvRulemasterCondition(RuleTypeid, investigationid, orgid,InvType, out lstInvRuleMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvRulemaster Investigation_BL", ex);
            }
            return returnCode;
        }
        public long deleteRuleMaster(int RuleMasterId, int RuleTypeid, long investigationid, int orgid, int RemarksId)
        {
            long returnCode = -1;
            try
            {
                Investigation_DAL objDL = new Investigation_DAL(globalContextDetails);
                returnCode = objDL.deleteRuleMaster(RuleMasterId, RuleTypeid, investigationid, orgid, RemarksId);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvRulemaster Investigation_BL", ex);
            }
            return returnCode;
        }

        public long GetInvRulemasterVisit(long Visitid, long investigationid, int orgid, string InvType, out List<InvRuleMaster> lstInvRuleMaster, out  List<PatientAgeGenderRule> lstPatientAgeGenderRule, out List<TestResultsRule> lstTestResultsRule, out List<MachineErrorRule> lstMachineErrorRule, out List<InvRuleMaster>  lstInvremarks)
        {
            long returnCode = -1;
            lstInvRuleMaster = new List<InvRuleMaster>();
            lstInvremarks = new List<InvRuleMaster>();
            lstPatientAgeGenderRule = new List<PatientAgeGenderRule>();
            lstTestResultsRule = new List<TestResultsRule>();
            lstMachineErrorRule = new List<MachineErrorRule>();
            try
            {
                Investigation_DAL objDL = new Investigation_DAL(globalContextDetails);
                returnCode = objDL.GetInvRulemasterVisit(Visitid, investigationid, orgid, InvType, out lstInvRuleMaster, out lstPatientAgeGenderRule, out lstTestResultsRule, out  lstMachineErrorRule, out lstInvremarks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvRulemaster Investigation_BL", ex);
            }
            return returnCode;
        }
		 public DataSet DynamicInvValues(DateTime Fdate, DateTime Tdate, string VisitNo,long GroupID, string Param1, string Param2, string  Param3,string Param4,long Param5)
        {
            DataSet set = new DataSet();
            try
            {
                set = new Investigation_DAL(this.globalContextDetails).DynamicInvValues(Fdate, Tdate, VisitNo,GroupID, Param1, Param2, Param3, Param4, Param5);
            }
            catch (Exception exception)
            {
                CLogger.LogError("Error in Investigation_BL - DynamicInvValues", exception);
            }
            return set;
        }

        public long SaveInvValuesforCovidReport(List<InvValuesforCovidReport> historyMappingLst,long GroupID, string Param1, string Param2, string Param3, string Param4, long Param5)
        {
            long resultCode = -1;
            try
            {
                Investigation_DAL oMaster_DAL = new Investigation_DAL(globalContextDetails);
                resultCode = oMaster_DAL.SaveInvValuesforCovidReport(historyMappingLst,GroupID,Param1, Param2, Param3, Param4, Param5);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  Save Clinical History Mapping  ", ex);
            }

            return resultCode;
        }

    }
}