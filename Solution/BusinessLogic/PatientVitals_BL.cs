using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Data;
using System.IO;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
   public class PatientVitals_BL
    {
        ContextDetails globalContextDetails;
        public PatientVitals_BL()
        {

        }
        public PatientVitals_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }


       public long SavePatientVitals(int pOrgID, int VisitType, List<PatientVitals> lstPatientVitals)
       {
           long returnCode = -1;

           try
           {
               PatientVitals_DAL obj = new  PatientVitals_DAL(globalContextDetails);

               returnCode = obj.SavePatientVitals(pOrgID, VisitType, lstPatientVitals);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing SavePatientVitals BL", excp);
           }

           return returnCode;



       }

       //Dr.Home Page
       public DataSet PatientVisitId(DateTime StartDate,DateTime EndDate)
       {
           DataSet ds = new DataSet();

           try
           {
               PatientVitals_DAL obj = new  PatientVitals_DAL(globalContextDetails);
               ds = obj.GetVisitId(StartDate, EndDate);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing PatientVisitId BL", excp);
           }
           return ds;
       }
       
       public DataSet PatientVitals(ArrayList PatientVitals)
       {
           DataSet ds = new DataSet();

           try
           {
               PatientVitals_DAL obj = new  PatientVitals_DAL(globalContextDetails);
               ds = obj.PatientVitals(PatientVitals);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing PatientVitals", excp);
           }
           return ds;
       }

       public long GetVitalsForUI(int iOrgID, string vitalsGroup ,out List<VitalsUOMJoin> lstVitalsUOMJoin)
       {
           long returnCode = -1;
           lstVitalsUOMJoin = null;

           try
           {

               PatientVitals_DAL patientVitalsDAL = new  PatientVitals_DAL(globalContextDetails);
               returnCode = patientVitalsDAL.GetVitalsForUI(iOrgID, vitalsGroup, out lstVitalsUOMJoin);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetVitalsForUI", excp);
           }

           return returnCode;
       }

       public long GetVitalsForUpdate(long patientID, int iOrgID, out long visitID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
       {
           long returnCode = -1;
           visitID = -1;
           lstVitalsUOMJoin = null;

           try
           {

               PatientVitals_DAL patientVitalsDAL = new  PatientVitals_DAL(globalContextDetails);
               returnCode = patientVitalsDAL.GetVitalsForUpdate(patientID, iOrgID, out visitID, out lstVitalsUOMJoin);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetVitalsForUpdate", excp);
           }
           return returnCode;
       }

       public long GetPatientVitals(long patientID,long visitID, out List<VitalsUOMJoin> patientVitals)
       {
           long returnCode = -1;
           patientVitals = null;

           try
           {
               PatientVitals_DAL patientVitalsDAL = new  PatientVitals_DAL(globalContextDetails);
               returnCode = patientVitalsDAL.GetPatientVitals(patientID, visitID, out patientVitals);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetPatientVitals BL", excp);
           }

           return returnCode;
       }
       public long GetVisitStatusForVitals(long patientID, out long visitID, out long vType, out long VitalsCount)
       {
           long returnCode = -1;
           visitID = -1;
           vType = -1;
           VitalsCount = -1;

           try
           {
               returnCode = new  PatientVitals_DAL(globalContextDetails).GetVisitStatusForVitals(patientID, out visitID, out vType, out VitalsCount);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while GetVisitStatusForVitals", ex);
           }

           return returnCode;
       }


       public long GetSelectOption(long RoleID, out List<VitalsPageOptions> lstvitalspageoption)
       {
           long returnCode = -1;

           lstvitalspageoption = null;

           try
           {
               PatientVitals_DAL patientVitalsDAL = new  PatientVitals_DAL(globalContextDetails);
               returnCode = patientVitalsDAL.GetSelectOption(RoleID, out lstvitalspageoption);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetPatientVitals BL", excp);
           }

           return returnCode;
       }

       public long GetANCPatientVisitID(long PatientID, DateTime visitdate, out long visitID)
       {
           long returnCode = -1;
           visitID = -1;


           try
           {
               PatientVitals_DAL patientVitalsDAL = new  PatientVitals_DAL(globalContextDetails);
               returnCode = patientVitalsDAL.GetANCPatientVisitID(PatientID, visitdate, out visitID);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetPatientVitals BL", excp);
           }

           return returnCode;
       }
       public long GetInPatientVitalsForUpdate(long patientVisitID, int iOrgID, out long visitID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
       {
           long returnCode = -1;
           visitID = -1;
           lstVitalsUOMJoin = null;

           try
           {

               PatientVitals_DAL patientVitalsDAL = new  PatientVitals_DAL(globalContextDetails);
               returnCode = patientVitalsDAL.GetInPatientVitalsForUpdate(patientVisitID, iOrgID, out visitID, out lstVitalsUOMJoin);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetInPatientVitalsForUpdate", excp);
           }
           return returnCode;
       }


       public long GetIPCaseRecordVitalsForUpdate(long patientVisitID, int iOrgID, out long visitID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
       {
           long returnCode = -1;
           visitID = -1;
           lstVitalsUOMJoin = null;

           try
           {

               PatientVitals_DAL patientVitalsDAL = new  PatientVitals_DAL(globalContextDetails);
               returnCode = patientVitalsDAL.GetIPCaseRecordVitalsForUpdate(patientVisitID, iOrgID, out visitID, out lstVitalsUOMJoin);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetVitalsForUpdate", excp);
           }
           return returnCode;
       }

       public long GetVitalsType(long OrgID, out List<VitalsType> lstVitalsType)
       {
           long returnCode = -1;

           lstVitalsType = null;

           try
           {
               PatientVitals_DAL patientVitalsDAL = new  PatientVitals_DAL(globalContextDetails);
               returnCode = patientVitalsDAL.GetVitalsType(OrgID, out lstVitalsType);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetVitalsType BL", excp);
           }

           return returnCode;
       }

       public long GetNeonatalNotesVitalsForUpdate(long patientVisitID, int iOrgID, out long visitID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
       {
           long returnCode = -1;
           visitID = -1;
           lstVitalsUOMJoin = null;

           try
           {

               PatientVitals_DAL patientVitalsDAL = new  PatientVitals_DAL(globalContextDetails);
               returnCode = patientVitalsDAL.GetNeonatalNotesVitalsForUpdate(patientVisitID, iOrgID, out visitID, out lstVitalsUOMJoin);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetNeonatalNotesVitalsForUpdate", excp);
           }
           return returnCode;
       }


    }
}
