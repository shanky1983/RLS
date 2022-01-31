using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Data;
using System.IO;

namespace Attune.Solution.BusinessComponent
{
    public class SurgeryPackage_BL
    {
         ContextDetails globalContextDetails;
        public SurgeryPackage_BL()
        {

        }
        public SurgeryPackage_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetSurgeryPackage(int orgID,long pVisitID, out List<SurgeryPackageItems> lstSurgeryPackageItems, out List<SurgeryPackageItems> lstSelectedSurgeryPKG)
        {

            long returnCode = -1;
            lstSurgeryPackageItems = new List<SurgeryPackageItems>();
            lstSelectedSurgeryPKG = new List<SurgeryPackageItems>();
            try
            {
                returnCode = new SurgeryPackage_DAL(globalContextDetails).GetSurgeryPackage(orgID,pVisitID, out lstSurgeryPackageItems, out lstSelectedSurgeryPKG);
            }
            catch (Exception ex)
            {
                CLogger.LogError("error while GetSurgeryPackage", ex);
            }

            return returnCode;
        }

        public long GetOrderedSurgeryPkg(long PackageID, long pVisitID, out List<SurgeryPackageItems> lstSurgeryPackageItems, out List<SurgeryPackageItems> lstSelectedSurgeryPKG)
        {

            long returnCode = -1;
            lstSurgeryPackageItems = new List<SurgeryPackageItems>();
            lstSelectedSurgeryPKG = new List<SurgeryPackageItems>();
            try
            {
                returnCode = new SurgeryPackage_DAL(globalContextDetails).GetOrderedSurgeryPkg(PackageID, pVisitID, out lstSurgeryPackageItems, out lstSelectedSurgeryPKG);
            }
            catch (Exception ex)
            {
                CLogger.LogError("error while GetOrderedSurgeryPkg", ex);
            }

            return returnCode;
        }

        public long SaveSurgeryPkgInTracker(long VisitID, long PatientID, long LID, int ILocationID,
            SurgeryPackageItems objSPI, string pType,OrderedInvestigations objInvest,string gUID)
        {
            long returncode = -1;

            try
            {
                returncode = new SurgeryPackage_DAL(globalContextDetails).SaveSurgeryPkgInTracker(VisitID, PatientID, LID, ILocationID, objSPI, pType, objInvest, gUID);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing SaveSurgeryPkgInTracker in Neonatal_BL", excep);
            }

            return returncode;
        }

        public long UpdateSurgerypkgDate(long VisitID,long PackageID,DateTime FromDate,DateTime Todate)
        {
            long returncode = -1;

            try
            {
                returncode = new SurgeryPackage_DAL(globalContextDetails).UpdateSurgerypkgDate(VisitID, PackageID, FromDate, Todate);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing SaveSurgeryPkgInTracker in Neonatal_BL", excep);
            }

            return returncode;
        }


        public long GetSurgeryPkgItemDetail(long VisitID,long  PkgDetailID, long PkgID, out List<SurgeryPackageItems> lstSurgeryPackageItems)
        {

            long returnCode = -1;
            lstSurgeryPackageItems = new List<SurgeryPackageItems>();
            
            try
            {
                returnCode = new SurgeryPackage_DAL(globalContextDetails).GetSurgeryPkgItemDetail(VisitID, PkgDetailID, PkgID, out lstSurgeryPackageItems);
            }
            catch (Exception ex)
            {
                CLogger.LogError("error while GetSurgeryPkgItemDetail", ex);
            }

            return returnCode;
        }


        public long UpdateSurgeryPkgTrackerQty(long TrackerID,long VisitID,decimal UpdateQty,DateTime OrderedDate)
        {
            long returncode = -1;

            try
            {
                returncode = new SurgeryPackage_DAL(globalContextDetails).UpdateSurgeryPkgTrackerQty(TrackerID, VisitID, UpdateQty, OrderedDate);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing UpdateSurgeryPkgTrackerQty in Neonatal_BL", excep);
            }

            return returncode;
        }

        public long SaveSurgeryMaster(List<SurgeryPackageMaster> lstpackage)
        {
            // lstpackage = new List<SurgeryPackageMaster>();
            long returncode = -1;
            try
            {

                returncode = new SurgeryPackage_DAL(globalContextDetails).SaveSurgeryMaster(lstpackage);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing surgeryMaster", ex);
            }
            return returncode;
        }
        public long DeleteSurgeryMaster(long packageid, int orgid)
        {
            // lstpackage = new List<SurgeryPackageMaster>();
            long returncode = -1;
            try
            {

                returncode = new SurgeryPackage_DAL(globalContextDetails).DeleteSurgeryMaster(packageid, orgid);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing surgeryMaster", ex);
            }
            return returncode;
        }

        public long GetSurgeryMaster(int pOrgID, out List<SurgeryPackageMaster> lstpackage)
        {
            long returncode = -1;
            lstpackage = new List<SurgeryPackageMaster>();
            try
            {
                returncode = new SurgeryPackage_DAL(globalContextDetails).GetSurgeryMaster(pOrgID, out lstpackage);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading surgeryMaster", ex);
            }
            return returncode;
        }

        public long GetSurgeryDetails(int pOrgID, out List<SurgeryPackageMaster> lstSurgery, out List<SurgeryPackageDetails> lstSurgeryMapping, out List<SurgeryPackageDetails> lstSurgeryDtls)
        {
            long returncode = -1;
            lstSurgery = new List<SurgeryPackageMaster>();
            lstSurgeryDtls = new List<SurgeryPackageDetails>();
            lstSurgeryMapping = new List<SurgeryPackageDetails>();
            try
            {
                returncode = new SurgeryPackage_DAL(globalContextDetails).GetSurgeryDetails(pOrgID, out lstSurgery, out lstSurgeryMapping, out lstSurgeryDtls);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading surgeryMaster Details BL", ex);
            }
            return returncode;
        }

        public long GetDataList(int pOrgID, out List<AdminInvestigationRate> lstMedicalIndent,
            out List<Speciality> lstSpeciality, out List<Ambulancedetails> lstambulance,
            out List<ProcedureMaster> lstprocedure, out List<RoomType> lstroomtype,
            out List<IPTreatmentPlanMaster> lstIPTPM)
        {
            long returncode = -1;
            lstMedicalIndent = new List<AdminInvestigationRate>();
            lstSpeciality = new List<Speciality>();
            lstambulance = new List<Ambulancedetails>();
            lstprocedure = new List<ProcedureMaster>();
            lstroomtype = new List<RoomType>();
            lstIPTPM = new List<IPTreatmentPlanMaster>();
            try
            {
                returncode = new SurgeryPackage_DAL(globalContextDetails).GetDataList(pOrgID, out lstMedicalIndent, out lstSpeciality, out lstambulance, out lstprocedure, out lstroomtype, out lstIPTPM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading surgeryMaster Details BL", ex);
            }
            return returncode;
        }

        public long UpdatePackageContent(List<SurgeryPackageDetails> lstInvPackageMapping,
            List<SurgeryPackageDetails> lstDeletedPackageMapping, 
            int OrgID, long createdBY)
        {
            long retCode = -1;
            
          try
            {

                retCode = new SurgeryPackage_DAL(globalContextDetails).UpdatePackageContent(lstInvPackageMapping,
                    lstDeletedPackageMapping,
                    OrgID,
                    createdBY);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdatePackageContent in SurgeryPackage_BL", e);
            }
            return retCode;
        }

   

 

        public long GetSurgerylist(int pOrgID, out List<IPTreatmentPlanMaster> lstSurgery)
        {
            long returncode = -1;
            lstSurgery = new List<IPTreatmentPlanMaster>();
            try
            {
                returncode = new SurgeryPackage_DAL(globalContextDetails).GetSurgeryList(pOrgID, out lstSurgery);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading surgeryMaster", ex);
            }
            return returncode;
        }

        public long SaveSurgeryMaster(List<IPTreatmentPlanMaster> lstIPTreatPlan)
        {
            long returnCode = -1;

            
            try
            {
                returnCode = new SurgeryPackage_DAL(globalContextDetails).SaveSurgeryMaster(lstIPTreatPlan);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveSurgeryMaster SurgeryPackage_BL", excp);
            }
            return returnCode; 
        }
    }
}
