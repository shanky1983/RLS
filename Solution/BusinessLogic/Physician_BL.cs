using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

/// <summary>
/// Summary description for Physician_BL
/// </summary>
/// 
namespace Attune.Solution.BusinessComponent
{
    public class Physician_BL
    {
         ContextDetails globalContextDetails;
        public Physician_BL()
        {

        }
        public Physician_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetPhysicianOP(long lOrgID, int iPhysicianID, out List<PhysicianOPIP> lstPhysicianOPIP)
        {
            long returnCode = -1;
            lstPhysicianOPIP = null;

            try
            {
                Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.GetPhysicianOP(lOrgID, iPhysicianID, out lstPhysicianOPIP);

                foreach (PhysicianOPIP pop in lstPhysicianOPIP)
                {
                    pop.Name = pop.TitleName + ' ' + pop.Name;
                }

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPhysicianOP BL", excp);
            }

            return returnCode;
        }

        public long GetCaseSheetData(long patientID, long patientVisitID, out List<Patient> lstP, out List<Complaint> lstC, out List<Investigation> lstI, out List<Examination> lstE, out List<History> lstH)
        {
            long returnCode = -1;

            lstP = null;
            lstC = null;
            lstI = null;
            lstE = null;
            lstH = null;
            try
            {
                
                Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.GetCaseSheetData(patientID, patientVisitID, out lstP, out lstC, out lstI, out lstE, out lstH);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetCaseSheetData", excp);
            }
            return returnCode;
        }

        public long GetPatientPrescription(long iPatientVisitID, out List<DrugDetails> lstDrugDetails)
        {
            long returnCode = -1;
            lstDrugDetails = null;

            try
            {

                Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.GetPatientPrescription(iPatientVisitID, out lstDrugDetails);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPatientPrescription", excp);
            }
            return returnCode;
        }

        public long GetPhysicianListByOrg(int orgID, out List<Physician> lstPhysician, int iVisitID)
        {
            long returnCode = -1;
            lstPhysician = null;

            try
            {
                
                Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.GetPhysicianListByOrg(orgID,out lstPhysician,iVisitID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPhysicianListByOrg", excp);
            }

            return returnCode;
        }

        public long GetPhysicianList(int orgID, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = null;

            try
            {

                Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.GetPhysicianList(orgID, out lstPhysician);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPhysicianListByOrg", excp);
            }

            return returnCode;
        }

        public long GetPhysicianSchedule(int orgID,string phyType, out List<PhysicianSchedule> phySchedules)
        {
            long returnCode = -1;
            phySchedules = null;

            try
            {
                phySchedules = new List<PhysicianSchedule>();
                Physician_DAL phyDAL = new Physician_DAL(globalContextDetails);
                returnCode = phyDAL.GetPhysicians(orgID, phyType, out phySchedules);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPhysicianSchedule", excp);
            }
            return returnCode;

        }
      

        public long SavePhysicians(Physician Physicians, List<AdminInvestigationRate> lstAdminRate)
        {
            long lresult = -1;
           
            try
            {
                Physician_DAL PhysiciansDal = new Physician_DAL(globalContextDetails);
                lresult = PhysiciansDal.SavePhysicians(Physicians,lstAdminRate);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing SaveNurse", ex);

            }

            return lresult;
        }

        public long SavePhysicianSpeciality(PhysicianSpeciality PhySpeciality)
        {
            long lresult = -1;
            try
            {
                Physician_DAL PhysiciansDal = new Physician_DAL(globalContextDetails);
                lresult = PhysiciansDal.SavePhysicianSpeciality(PhySpeciality);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SavePhysicianSpeciality", ex);
            }
            return lresult;
        }
        public long GetCashExpenseByOrg(int orgID, out List<CashExpenseMaster> lstCashExpense)
        {
            long returnCode = -1;
            lstCashExpense = null;

            try
            {

                Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.GetCashExpenseByOrg(orgID, out lstCashExpense);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetCashExpenseByOrg", excp);
            }

            return returnCode;
        }

        public long GetAllPhysicianSchedules(int iorgID, int iResourceID,string iResourceType, out List<AllPhysicianSchedules> lstPhysicianSchedules)
        {
            long returnCode = -1;
            lstPhysicianSchedules = null;
            try
            {

                Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.GetAllPhysicianSchedules(iorgID, iResourceID, iResourceType,out lstPhysicianSchedules);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetAllPhysicianSchedules", excp);
            }

            return returnCode;
        }

        public long UpdatePhysicianSpeciality(int phID, List<Speciality> PhySpeciality)
        {
            long lresult = -1;
            try
            {
                Physician_DAL PhysiciansDal = new Physician_DAL(globalContextDetails);
                lresult = PhysiciansDal.UpdatePhysicianSpeciality(phID, PhySpeciality);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdatePhysicianSpeciality", ex);
            }
            return lresult;
        }
        public long PerfomingPhysician(string perphyname,string phyQuly,long lOrgID)
        {
            long returnCode = -1;

            try
            {
                Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.PerfomingPhysician(perphyname, phyQuly, lOrgID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing PerfomingPhysician BL", excp);
            }

            return returnCode;
        }
        public long Getperformingphysician(int OrgID, out List<PerformingPhysician> lstperphysician)
        {
            long returnCode = -1;

            //try
            //{
                Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.Getperformingphysician(OrgID,out lstperphysician);
            //}
            //catch (Exception excp)
            //{
            //    CLogger.LogError("Error while executing PerfomingPhysician BL", excp);
            //}

            return returnCode;
        }
        public long Deleteperformingphysician(int physicianid,string perphyname,int OrgID)
        {
            long returnCode = -1;

            try
            {
                Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.Deleteperformingphysician(physicianid, perphyname,OrgID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing Deleteperformingphysician BL", excp);
            }

            return returnCode;
        }
        public long Activeperformingphysician(int physicianid, string perphyname, int OrgID)
        {
            long returnCode = -1;

            try
            {
                Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.Activeperformingphysician(physicianid, perphyname, OrgID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing Activeperformingphysician BL", excp);
            }

            return returnCode;
        }
        public long GetReferingphysician(int OrgID, out List<ReferingPhysician> lstRefphysician)
        {
            long returnCode = -1;

            //try
            //{
            Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
            returnCode = physicianDAL.GetReferingphysician(OrgID, out lstRefphysician);
            //}
            //catch (Exception excp)
            //{
            //    CLogger.LogError("Error while executing PerfomingPhysician BL", excp);
            //}

            return returnCode;
        }
        public long Updateperformingphysician(int physicianid, string perphyname, string Qulification, int OrgID)
        {
            long returnCode = -1;

            try
            {
                Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.Updateperformingphysician(physicianid, perphyname,Qulification,OrgID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing Activeperformingphysician BL", excp);
            }

            return returnCode;
        }
        public long SaveRefPhyRateMapping(List<PCClientMapping> lstphyMap, List<PCClientMapping> lstDeletedphyMap)
        {
            long lresult = -1;
                        try
            {
                Physician_DAL PhysiciansDal = new Physician_DAL(globalContextDetails);
                lresult = PhysiciansDal.SaveRefPhyRateMapping(lstphyMap, lstDeletedphyMap);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing SaveNurse", ex);

            }

            return lresult;
        }
       

        public long GetPhysicianNameByOrg(int orgID, string prefixtext, out List<Physician> lstPhysician, int iVisitID)
        {
            long returnCode = -1;
            lstPhysician = null;

            try
            {

                Attune.Solution.DAL.Physician_DAL physicianDAL = new Physician_DAL(globalContextDetails);
                returnCode = physicianDAL.GetPhysicianNameByOrg(orgID, prefixtext, out lstPhysician, iVisitID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPhysicianListByOrg", excp);
            }

            return returnCode;
        }
        public long GetInvestigationHistoryDetail(long pPatientID, long pVisitId, long InvID, int OrgID, string TypeValue, out List<InvMedicalDetailsMapping> lstInvMedicalDetailsMapping, out List<InvMedicalDetailsMapping> lstInvestigationMappingList)
        {

            long returnCode = -1;
            lstInvMedicalDetailsMapping = new List<InvMedicalDetailsMapping>();
            lstInvestigationMappingList = new List<InvMedicalDetailsMapping>();


            try
            {
                Physician_DAL PhysiciansDal = new Physician_DAL(globalContextDetails);
                returnCode = PhysiciansDal.GetInvestigationHistoryDetail(pPatientID, pVisitId, InvID, OrgID, TypeValue, out lstInvMedicalDetailsMapping, out lstInvestigationMappingList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetInvestigationHistoryDetail Physician Bl", ex);
            }
            return returnCode;

        }

        public long GetInvestigationHistoryMapping(int orgID, long VisitID, long PatientID, long InvID, string InvestigationList, out List<InvHistoryAttributes> lstInvHistoryAttributes)
        {

            long returnCode = -1;
            lstInvHistoryAttributes = new List<InvHistoryAttributes>();


            try
            {
                Physician_DAL PhysiciansDal = new Physician_DAL(globalContextDetails);
                returnCode = PhysiciansDal.GetInvestigationHistoryMapping(orgID, VisitID, PatientID, InvID, InvestigationList, out lstInvHistoryAttributes);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetInvestigationHistoryMapping Physician Bl", ex);
            }
            return returnCode;

        }

        public long Inserthubname(Localities pLOCAL)
        {
            long returnCode = -1;
            try
            {
                Physician_DAL physicianDal = new Physician_DAL();
                returnCode = physicianDal.Inserthubname(pLOCAL);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in inserthubname physician BL", ex);
            }
            return returnCode;

        }

        public long GetLocalitiesHub(int orgid, out List<Localities> LOC)
        {
            long returnCode = -1;
            LOC = new List<Localities>();

            try
            {
                returnCode = new Physician_DAL().GetLocalitiesHub(orgid, out LOC);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCasuality", ex);
            }
            return returnCode;
        }


        public long GetsearchHub(int Orgid, string hubcode, out List<Localities> local)
        {
            long returnCode = -1;
            local = new List<Localities>();
            try
            {
                returnCode = new Physician_DAL().GetsearchHub(Orgid, hubcode, out local);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetsearchHub", ex);
            }
            return returnCode;
        }

        public long Insertzonename(string maphubvalue, Localities LOCAL)
        {
            long returnCode = -1;
            try
            {
                Physician_DAL physicianDAL = new Physician_DAL();
                returnCode = physicianDAL.Insertzonename(maphubvalue, LOCAL);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Insertzonename BL", ex);
            }
            return returnCode;
        }

        public long GetLocalitiesZone(int orgid, out List<Localities> LOC)
        {
            long returnCode = -1;
            LOC = new List<Localities>();

            try
            {
                returnCode = new Physician_DAL().GetLocalitiesZone(orgid, out LOC);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetLocalitiesZone", ex);
            }
            return returnCode;
        }


        public long Insertroutename(string mapzonevalue, Localities LOCAL)
        {
            long returnCode = -1;
            try
            {
                Physician_DAL physicianDAL = new Physician_DAL();
                returnCode = physicianDAL.Insertroutename(mapzonevalue, LOCAL);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Insertroutename BL", ex);
            }
            return returnCode;
        }

        public long GetLocalitiesRoute( int OrgID,out List<Localities> LOC)
        {
            long returnCode = -1;
            LOC = new List<Localities>();

            try
            {
                returnCode = new Physician_DAL().GetLocalitiesRoute(OrgID,out LOC);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetLocalitiesRoute", ex);
            }
            return returnCode;
        }

        public long Getsearchzone(int Orgid ,string zonecode, out List<Localities> local)
        {
            long returnCode = -1;
            local = new List<Localities>();
            try
            {
                returnCode = new Physician_DAL().Getsearchzone(Orgid,zonecode, out local);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL Getsearchzone", ex);
            }
            return returnCode;
        }

        public long Getsearchroute(int Orgid ,string routecode, out List<Localities> local)
        {
            long returnCode = -1;
            local = new List<Localities>();
            try
            {
                returnCode = new Physician_DAL().Getsearchroute(Orgid,routecode, out local);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL Getsearchroute", ex);
            }
            return returnCode;
        }

        
    }
}
