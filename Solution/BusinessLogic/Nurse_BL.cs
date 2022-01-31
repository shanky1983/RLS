using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class Nurse_BL
    {
         ContextDetails globalContextDetails;
        public Nurse_BL()
        {

        }
        public Nurse_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        //public long GetSearchActions(int roleID, int patientID, out List<SearchActions> sActions)
        //{
        //    long returnCode = -1;
        //    sActions = null;
        //    try
        //    {
        //        Nurse_DAL nDAL = new  Nurse_DAL(globalContextDetails);
        //        returnCode = nDAL.GetSearchActions(roleID, patientID, out sActions);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing GetSearchActions BL", excp);
        //    }
        //    return returnCode;
        //}
        //public long GetSearchActionsInPatient(int roleID, int patientID, out List<SearchActions> sActions)
        //{
        //    long returnCode = -1;
        //    sActions = null;
        //    try
        //    {
        //        Nurse_DAL nDAL = new  Nurse_DAL(globalContextDetails);
        //        returnCode = nDAL.GetSearchActionsInPatient(roleID, patientID, out sActions);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing GetSearchActionsInPatient BL", excp);
        //    }
        //    return returnCode;
        //}


        public long SaveNurseBL(Nurse NurseBL)
        {
            long lresult = -1;
            try
            {
                Nurse_DAL NurseDal = new  Nurse_DAL(globalContextDetails);
                lresult = NurseDal.SaveNurse(NurseBL);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing SaveNurse", ex);

            }

            return lresult;
        }

        public long SaveNurseSpeciality(NurseSpeciality NurseSpeciality)
        {
            long lresult = -1;
            try
            {
                Nurse_DAL NurseDAL = new  Nurse_DAL(globalContextDetails);
                lresult = NurseDAL.SaveNurseSpeciality(NurseSpeciality);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveNurseSpeciality", ex);
            }
            return lresult;
        }
        //public long GetSearchActionsIsTrusterdOrg(int roleID, int patientID, out List<SearchActions> sActions)
        //{
        //    long returnCode = -1;
        //    sActions = null;
        //    try
        //    {
        //        Nurse_DAL nDAL = new  Nurse_DAL(globalContextDetails);
        //        returnCode = nDAL.GetSearchActionsIsTrusterdOrg(roleID, patientID, out sActions);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing GetSearchActionsIsTrusterdOrg BL", excp);
        //    }
        //    return returnCode;
        //}

        public long GetActions(long roleID, int searchTypeID, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            try
            {
                returnCode = new  Nurse_DAL(globalContextDetails).GetActions(roleID, searchTypeID, out lstActionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetActions", ex);
            }
            return returnCode;
        }
        public long GetActions(long roleID, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            try
            {
                returnCode = new  Nurse_DAL(globalContextDetails).GetActions(roleID, out lstActionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetActions", ex);
            }
            return returnCode;
        }

        public long GetActionsIsTrusterdOrg(long roleID, int searchTypeID, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            try
            {
                returnCode = new  Nurse_DAL(globalContextDetails).GetActionsIsTrusterdOrg(roleID, searchTypeID, out lstActionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetActionsIsTrusterdOrg", ex);
            }

            return returnCode;
        }
    }
}
