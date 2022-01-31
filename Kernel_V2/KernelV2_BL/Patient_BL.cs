using System;
using System.Collections.Generic;
using Attune.KernelV2.DAL;
using Attune.KernelV2.Entities;

namespace Attune.KernelV2.BL
{
    public class Patient_BL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Patient_BL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public List<UI_PatientVisit> GetPatientBannerDetails(long pVisitID, int pOrgID, string UID)
        {
            List<UI_PatientVisit> lstPatientLabVisitDetails;
            using (Patient_DAL DAL = new Patient_DAL(globalContextDetails))
            {
                lstPatientLabVisitDetails = DAL.GetPatientLabVisitDetails(pVisitID, pOrgID, UID);
            }

            return lstPatientLabVisitDetails;
        }

        public long UpdatePatientVisitChanges(UI_PatientHistory lstPV, int OrgID)
        {
            long returnCode;
            using (Patient_DAL DAL = new Patient_DAL(globalContextDetails))
            {
                returnCode = DAL.UpdatePatientVisitChanges(lstPV, OrgID);
            }

            return returnCode;
        }

        public List<UI_PatientVisitDetails> GetPatientVisitDetails(long VisitID)
        {
            List<UI_PatientVisitDetails> lstPatientVisitDetails;
            using (Patient_DAL DAL = new Patient_DAL(globalContextDetails))
            {
                lstPatientVisitDetails = DAL.GetPatientVisitDetails(VisitID);
            }

            return lstPatientVisitDetails;
        }

        public UI_PatientandAddress GetPatientDemoandAddress(long PatientID)
        {
            UI_PatientandAddress objPatient;
            using (Patient_DAL DAL = new Patient_DAL(globalContextDetails))
            {
                objPatient = DAL.GetPatientDemoandAddress(PatientID);
            }

            return objPatient;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
