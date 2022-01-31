using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Linq;

namespace Attune.Solution.BusinessComponent
{
    public class ClinicalTrail_BL
    {
        ContextDetails globalContextDetails;
        public ClinicalTrail_BL()
        {

        }
        public ClinicalTrail_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long SaveEpisodeMaster(Episode lstEpisodeDetails,
            List<EpisodeVisitDetails> lstEpisodeVisitDetails,
            List<SiteEpisodeVisitMapping> lstSiteEpisodeVisitMapping,
            List<ProductEpisodeVisitMapping> lstKitVisitDetails,
            int OrgID, string EpisodeStatus, string LifeStatus, out long EpisodeID)
        {

            EpisodeID = -1;
            long returnCode = -1;

            try
            {

                returnCode = new ClinicalTrail_DAL(globalContextDetails).SaveEpisodeMaster(lstEpisodeDetails, lstEpisodeVisitDetails, lstSiteEpisodeVisitMapping, lstKitVisitDetails, OrgID, EpisodeStatus, LifeStatus, out EpisodeID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting SaveClientMasters  ", ex);
            }
            return returnCode;
        }
        

        public long GetEpisodeDetails(int pOrgID, string EpisodeName, long EpisodeID, out List<Episode> lstEpisode, out List<EpisodeVisitDetails> lstEpisodeVisitDetails,
            out List<ProductEpisodeVisitMapping> lstProductDetails, out List<SiteEpisodeVisitMapping> lstSiteDetails)
        {

            lstEpisode = new List<Episode>();
            lstEpisodeVisitDetails = new List<EpisodeVisitDetails>();
            lstProductDetails = new List<ProductEpisodeVisitMapping>();
            lstSiteDetails = new List<SiteEpisodeVisitMapping>();
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).GetEpisodeDetails(pOrgID, EpisodeName, EpisodeID, out lstEpisode, out lstEpisodeVisitDetails, out lstProductDetails, out lstSiteDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
            }
            return returnCode;
        }

        public long SaveEpisodeTRFDetails(string Fileurl, string fileName, long EpisodeID, string FileType, int orgid)
        {
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).SaveEpisodeTRFDetails(Fileurl, fileName, EpisodeID, FileType, orgid);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving TRFDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetTRFimageDetails(int patientid, int visitid, int OrgID, string Type, out List<TRFfilemanager> TRFdetails)
        {
            long returncode = -1;

            TRFdetails = new List<TRFfilemanager>();
            try
            {
                returncode = new ClinicalTrail_DAL(globalContextDetails).GetTRFDetails(patientid, visitid, OrgID, Type, out TRFdetails);

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing TRFdetails in Patient_BL", ex);
            }
            return returncode;

        }
        public long GetProductListWithName(int OrgID, string pProducts, int OrgAddressID, string PType, out List<Products> lstProducts)
        {
            long returnCode = -1;
            lstProducts = new List<Products>();
            ClinicalTrail_DAL CT_DAL = new ClinicalTrail_DAL(globalContextDetails);
            try
            {
                returnCode = CT_DAL.GetProductListWithName(OrgID, pProducts, OrgAddressID, PType, out lstProducts);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllSuppliersDetails in Inventory_BL", ex);
            }
            return returnCode;
        }

        public long UpdateEpisodeLifeStatus(long EpisodeID, string EpisodeLifeStatus, int OrgID, long ModifiedBy)
        {
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).UpdateEpisodeLifeStatus(EpisodeID, EpisodeLifeStatus, OrgID, ModifiedBy);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving TRFDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetEpisodeTaskDetails(int pOrgID, long EpisodeID, out List<Episode> lstborg)
        {

            lstborg = new List<Episode>();
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).GetEpisodeTaskDetails(pOrgID, EpisodeID, out lstborg);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
            }
            return returnCode;
        }
        public long GetShippingCondition(int pOrgID, out List<ShippingConditionMaster> lstShippingConditionMaster)
        {

            lstShippingConditionMaster = new List<ShippingConditionMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).GetShippingCondition(pOrgID, out lstShippingConditionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
            }
            return returnCode;
        }
        public long SaveEpiContainerTracking(int SiteID, long EpisodeID, int ShippingCondID, int VisitID, string AddInfo, int OrgID, long CreatedBy,long CurrentRegTrackID,out long RegTrackID)
        {
            long returnCode = -1;
            string ConsignmentNo = string.Empty;
            RegTrackID = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).SaveEpiContainerTracking(SiteID, EpisodeID, ShippingCondID, VisitID, AddInfo, OrgID, CreatedBy, out ConsignmentNo,CurrentRegTrackID,out RegTrackID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting Save EpiContainer Tracking  ", ex);
            }
            return returnCode;
        }
        public long GetEpiContainerTracking(int pOrgID, long TaskID, int TStatusID, out List<EpiContainerTracking> lstEpiContainerTracking)
        {

            lstEpiContainerTracking = new List<EpiContainerTracking>();
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).GetEpiContainerTracking(pOrgID, TaskID, TStatusID, out lstEpiContainerTracking);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
            }
            return returnCode;
        }
        public long UpdateContainerStatus(long TrackID, int ContainerStatusID, string Attributes, int OrgID, long ModifiedBy, List<ControlMappingDetails> lstControlMappingDetails)
        {
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).UpdateContainerStatus(TrackID, ContainerStatusID, Attributes, OrgID, ModifiedBy, lstControlMappingDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving TRFDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetEpiContainerTrackingDetails(int pOrgID, long TrackID, out List<EpiContainerTracking> lstEpiContainerTracking)
        {

            lstEpiContainerTracking = new List<EpiContainerTracking>();
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).GetEpiContainerTrackingDetails(pOrgID, TrackID, out lstEpiContainerTracking);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
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
                returnCode = new ClinicalTrail_DAL(globalContextDetails).GetControlListDetails(pOrgID, ReferenceID, ReferenceType, pType, SecondaryReferenceID, out lstControlMappingDetails, out lstControlMappingValues);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting GetControlListDetails  ", ex);
            }
            return returnCode;
        }
        public long GetStatusMaster(int pOrgID, out List<StatusMaster> lstStatusMaster)
        {

            lstStatusMaster = new List<StatusMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).GetStatusMaster(pOrgID, out lstStatusMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
            }
            return returnCode;
        }

        public long GetSitewiseContactList(long ClientID, int EpisodeID, int OrgID, out List<AddressDetails> lstAddDetails)
        {

            lstAddDetails = new List<AddressDetails>();
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).GetSitewiseContactList(ClientID, EpisodeID, OrgID, out lstAddDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  GetSitewiseContactList  ", ex);
            }
            return returnCode;
        }



        public long InsertPatientBilling(List<Patient> lstPatientCollection,
          List<FinalBill> lstFinalBillCollection,
          List<PatientDueChart> lstPatientDueChartCollection,
          List<OrderedInvestigations> lstInvCollection,
          List<TaxBillDetails> lstTaxDetailsCollection,
          List<ControlMappingDetails> lstControlSavedValues,
          DataTable dtAmountReceivedDet, int OrgID, long ReferedPhyID, int RefPhySpecialityID,
          int pSpecialityID, string ReferralType, string paymentstatus,
          int SavePicture, string sVal, int RoleID, long LID, PageContextkey PageContextDetails,
              string IsReceptionPhlebotomist, long EpisodeID, int SiteID, string VisitSampleStatus, DateTime dtSampleDate,
            List<PatientInvSample> lstPatientInvSampleCollection, List<SampleTracker> lstSampleTrackerCollection, List<PatientInvSampleMapping>
          lstSampleMappingCollection, List<InvestigationValues> lstinvValuesCollection, out string ConsignmentNo,
          int InventoryLocationID, List<PatientInvSample> lstSampleCondition, long CurrentRegTrackID, out long RegTrackID,
          List<PatientDisPatchDetails> lstDispatchDetails, List<VisitClientMapping> lstVisitClientMapping, string externalVisitID, string approvalNo, List<PatientDiscount> lstPatientDiscount, List<PatientRedemDetails> lstPatientRedemDetails, List<OrderedInvestigations> lstPkgandGrps, string StatFlag, string ClientFlag, long CollectionID,string EmailCC,string VisitNumber,string ClinicCode,string value)
        {

            long returnCode = -1;
            long returncod = -1;
            long PatientRoleId = 0;
            ConsignmentNo = string.Empty;
            RegTrackID = -1;
            int returnStatus = -1;
            string ConsignmentNoList = string.Empty;
            long taskID = -1;
            try
            {
                //if (RegTrackID == -1)
                // {
                // List<PatientInvSample> lstSampleCondition = new List<PatientInvSample>();

                foreach (PatientInvSample ObjSamCon in lstSampleCondition)
                {
                    returnCode = new ClinicalTrail_DAL(globalContextDetails).SaveEpiContainerTracking(SiteID, EpisodeID, ObjSamCon.SampleConditionID, -1, "", OrgID, LID, out ConsignmentNo, CurrentRegTrackID, out RegTrackID);
                    CurrentRegTrackID = RegTrackID;
                    List<PatientInvSample> lstPatientInvSampleCollectionDummy = new List<PatientInvSample>();

                    foreach (PatientInvSample ObjPatientInvSampleCollection in lstPatientInvSampleCollection.FindAll(p => p.SampleConditionID == ObjSamCon.SampleConditionID))
                    {
                        ObjPatientInvSampleCollection.ConsignmentNo = ConsignmentNo;
                    }
                    ConsignmentNoList += ConsignmentNo + ",";
                }
                ConsignmentNoList = string.IsNullOrEmpty(ConsignmentNoList) ? ConsignmentNo : ConsignmentNoList;
                ConsignmentNo = Convert.ToString(CurrentRegTrackID);
                // }
                foreach (Patient obj in lstPatientCollection)
                {
                    #region Registration Part
                    Patient objPatient = new Patient();
                    FinalBill objFinalBill = new FinalBill();
                    List<PatientDueChart> lstPatientDueChart = new List<PatientDueChart>();
                    List<TaxBillDetails> lstTaxDetails = new List<TaxBillDetails>();
                    List<OrderedInvestigations> lstInv = new List<OrderedInvestigations>();
                    List<BillingDetails> lstBillingDetails = new List<BillingDetails>();
                    List<PatientVisitLanguage> lstpatLanguage = new List<PatientVisitLanguage>();


                    objPatient = obj;
                    foreach (FinalBill obj1 in lstFinalBillCollection.FindAll(p => p.PatientIdentifyID == obj.PatientIdentifyID))
                    {
                        objFinalBill = obj1;
                    }
                    lstPatientDueChart = lstPatientDueChartCollection.FindAll(p => p.PatientIdentifyID == obj.PatientIdentifyID);
                    lstTaxDetails = lstTaxDetailsCollection;//.FindAll(p => p.PatientIdentifyID == obj.PatientIdentifyID);
                    lstInv = lstInvCollection.FindAll(p => p.PatientIdentifyID == obj.PatientIdentifyID);

                    int op = 0;
                    List<VisitTemplate> lstVisitTemplate = new List<VisitTemplate>();
                    new Patient_BL().InsertPatientBilling(objPatient, objFinalBill, ReferedPhyID,
                                                   RefPhySpecialityID, pSpecialityID, lstPatientDueChart, objPatient.AgeValue, objPatient.AgeUnit,
                                                   pSpecialityID, ReferralType, paymentstatus, objPatient.GUID, dtAmountReceivedDet, lstInv, lstTaxDetails,
                                                   out lstBillingDetails, out returnStatus, SavePicture, sVal, RoleID, LID, PageContextDetails,
                                                   IsReceptionPhlebotomist, 1, "", EpisodeID,
                                                   objPatient.EpisodeVisitId, -1, SiteID, VisitSampleStatus,
                                                   dtSampleDate, ConsignmentNo, lstControlSavedValues, "N", out op, lstDispatchDetails,
                                                   lstVisitClientMapping, out PatientRoleId, 0, -1, "", "", "", out taskID, "", lstPatientDiscount, "", "", "", "", "", -1, "", -1, -1, -1, 0, 0, lstPatientRedemDetails, lstPkgandGrps, StatFlag, ClientFlag, CollectionID, "", "", "", "", lstVisitTemplate, lstpatLanguage,"","","");

                    #endregion
                    #region SampleCollection Part

                    List<PatientInvSample> lstPatientInvSample = new List<PatientInvSample>();
                    List<SampleTracker> lstSampleTracker = new List<SampleTracker>();
                    List<PatientInvSampleMapping> lstSampleMapping = new List<PatientInvSampleMapping>();
                    List<InvestigationValues> lstinvValues = new List<InvestigationValues>();

                    lstPatientInvSample = lstPatientInvSampleCollection.FindAll(p => p.PatientIdentifyID == obj.PatientIdentifyID);
                    lstSampleTracker = lstSampleTrackerCollection.FindAll(p => p.PatientIdentifyID == obj.PatientIdentifyID);
                    lstSampleMapping = lstSampleMappingCollection.FindAll(p => p.PatientIdentifyID == obj.PatientIdentifyID);
                    lstinvValues = lstinvValuesCollection.FindAll(p => p.PatientIdentifyID == obj.PatientIdentifyID);


                    List<PatientInvestigation> lstPatientInvestigation = new List<PatientInvestigation>();
                    List<InvSampleMaster> lstInvSampleMaster = new List<InvSampleMaster>();
                    List<InvDeptMaster> lstInvDeptMaster = new List<InvDeptMaster>();
                    List<CollectedSample> lstOrderedInvSample = new List<CollectedSample>();
                    List<RoleDeptMap> lstRoleDept = new List<RoleDeptMap>();
                    List<InvDeptMaster> deptList = new List<InvDeptMaster>();
                    List<InvestigationSampleContainer> lstSampleContainer = new List<InvestigationSampleContainer>();


                    foreach (PatientInvSample ob in lstPatientInvSample)
                    {
                        ob.PatientVisitID = lstBillingDetails[0].VisitID;
                    }

                    foreach (SampleTracker ob in lstSampleTracker)
                    {
                        ob.PatientVisitID = lstBillingDetails[0].VisitID;
                    }
                    foreach (PatientInvSampleMapping ob in lstSampleMapping)
                    {
                        ob.VisitID = lstBillingDetails[0].VisitID;
                    }

                    Investigation_BL Inv_BL = new Investigation_BL();
                    long VisitID = lstBillingDetails[0].VisitID;
                    string GUID = obj.GUID;
                    int ILocationID = obj.ILocationID;
                    int taskactionID = obj.TaskactionID;
                    int DeptID = 0;
                    // Not Need, We Get DeptID from Parent Page
                    //Inv_BL.GetInvestigationSamplesCollect(VisitID, OrgID, RoleID, GUID, ILocationID, taskactionID, out lstPatientInvestigation, out lstInvSampleMaster, out lstInvDeptMaster, out lstRoleDept, out lstOrderedInvSample, out deptList, out lstSampleContainer);
                    //if (lstRoleDept.Count > 0)
                    //    DeptID =(lstRoleDept[0].DeptID);

                    List<PatientInvestigation> lstSampleDept = new List<PatientInvestigation>();
                    List<PatientInvSample> lstPatInvSample = new List<PatientInvSample>(); 
                    new Investigation_BL().GetDeptToTrackSamples(VisitID, OrgID, RoleID, GUID, out lstSampleDept, out lstPatInvSample);
                    List<InvDeptSamples> lstDeptSamples = new List<InvDeptSamples>();

                    IEnumerable<InvDeptSamples> FilterValue = (from list in lstSampleDept
                                                               group list by new
                                                               {
                                                                   list.DeptID,
                                                                   list.OrgID

                                                               } into g1
                                                               select new InvDeptSamples
                                                                     {
                                                                         DeptID = g1.Key.DeptID,
                                                                         OrgID = g1.Key.OrgID,
                                                                         PatientVisitID = VisitID

                                                                     }).ToList();
 

                    lstDeptSamples = FilterValue.ToList();
                    int status = -1;
                    int upis = -1;
                    string lstSampleId = string.Empty;
                    string invStatus = string.Empty;
                    if (lstSampleTracker.Count > 0 && lstDeptSamples.Count > 0)
                    {
                        /* FOR LIMS Performance  SavePatientInvSample BL is Modified, So Here Commented the SavePatientInvSample BL Calling*/   
                       // returnCode = Inv_BL.SavePatientInvSample(lstPatientInvSample, lstSampleTracker, lstDeptSamples, out status, out lstSampleId);
                        if (status == 0)
                        {
                             DeptID = 0;

                            if (invStatus == String.Empty)
                            {
                                new Investigation_BL().getInvOrgSampleStatus(OrgID, "Paid", out invStatus);
                            }

                            Inv_BL.UpdateOrderedInvestigationStatusinLab(lstinvValues, VisitID, invStatus, DeptID, "Paid", GUID, out upis);

                            Inv_BL.InsertPatientSampleMapping(lstSampleMapping, VisitID, OrgID, 0, LID, out status); 
                           
                        }
                    }

                    #endregion
                   
                    #region InsertKitconsumption
                    returncod = new ClinicalTrail_DAL(globalContextDetails).InsertKitconsumption(OrgID, ILocationID, InventoryLocationID, LID, VisitID);

                    #endregion

                    

                }
                Int64.TryParse(ConsignmentNo, out RegTrackID);
                ConsignmentNo = ConsignmentNoList;


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  GetSitewiseContactList  ", ex);
            }
            return returnCode;
        }
      
       
        
        public long GetPatientDetailsByConsignmentNo(int OrgID, string ConsignmentNo, long EpisodeID, long SiteID, string Type, out List<PatientInvSample> lstPatientInvSample)
        {
            long returnCode = -1;
            lstPatientInvSample = new List<PatientInvSample>();
            ClinicalTrail_DAL CT_DAL = new ClinicalTrail_DAL(globalContextDetails);
            try
            {
                returnCode = CT_DAL.GetPatientDetailsByConsignmentNo(OrgID, ConsignmentNo, EpisodeID, SiteID, Type, out lstPatientInvSample);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllSuppliersDetails in Inventory_BL", ex);
            }
            return returnCode;
        }
        public long UpdateBulkSampleStatus(List<SampleTracker> lstSampleTracker)
        {
            long returncode = -1;

            try
            {
                ClinicalTrail_DAL CT_DAL = new ClinicalTrail_DAL(globalContextDetails);
                returncode = CT_DAL.UpdateBulkSampleStatus(lstSampleTracker);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL UpdateSampleStatusDetails", ex);
            }
            return returncode;

        }
        public long GetOrgDetailsWithTypeLevel(long pID, string TypeLevel, out List<Organization> lstOrganization)
        {

            lstOrganization = new List<Organization>();
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).GetOrgDetailsWithTypeLevel(pID, TypeLevel, out lstOrganization);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
            }
            return returnCode;
        }
        public long GetProblemDataForm(DateTime FromDate, DateTime ToDate, int OrgID, int ILocationID, string pType,string IsDispatch, out List<Patient> lstPatient)
        {

            lstPatient = new List<Patient>();
            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).GetProblemDataForm(FromDate, ToDate, OrgID, ILocationID, pType,IsDispatch, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting GetProblemDataForm  ", ex);
            }
            return returnCode;
        }
        public long UpdatePatientMismatchDataStatus(List<ProductEpisodeVisitMapping> lstPatientVisit, int OrgID, long ModifiedBy)
        {
            //DataTable dtlstPatientVisit = GetDataTabProductEpisodeVisitMapping(lstPatientVisit);

            long returnCode = -1;
            try
            {
                returnCode = new ClinicalTrail_DAL(globalContextDetails).UpdatePatientMismatchDataStatus(lstPatientVisit, OrgID, ModifiedBy);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving TRFDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long GetProblemDataFormContactDetails(long PatientVisitID, int OrgID, out List<AddressDetails> lstAddress)
        {
            long returnCode = -1;
            lstAddress = new List<AddressDetails>();
            ClinicalTrail_DAL CT_DAL = new ClinicalTrail_DAL(globalContextDetails);
            try
            {
                returnCode = CT_DAL.GetProblemDataFormContactDetails(PatientVisitID, OrgID, out lstAddress);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllSuppliersDetails in Inventory_BL", ex);
            }
            return returnCode;
        }
        public long GetProblemDataFormSampleDetails(long PatientVisitID, int OrgID, out List<EpisodeVisitDetails> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<EpisodeVisitDetails>();
            ClinicalTrail_DAL CT_DAL = new ClinicalTrail_DAL(globalContextDetails);
            try
            {
                returnCode = CT_DAL.GetProblemDataFormSampleDetails(PatientVisitID, OrgID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllSuppliersDetails in Inventory_BL", ex);
            }
            return returnCode;
        }
    }
}
