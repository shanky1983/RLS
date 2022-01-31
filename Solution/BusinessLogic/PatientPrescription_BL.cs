using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections;
using Attune.Podium.Common;
namespace Attune.Solution.BusinessComponent
{
    public class PatientPrescription_BL
    {
         ContextDetails globalContextDetails;
        public PatientPrescription_BL()
        {

        }
        public PatientPrescription_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetTreatment(long visitID,string pPrescriptionNo, out List<PatientPrescription> lstPatientPrescription)
        {
            long returnCode = -1;
            lstPatientPrescription = new List<PatientPrescription>();
            PatientPrescription_DAL patPrescriptionDAL = new  PatientPrescription_DAL(globalContextDetails);
            try
            {
               
                returnCode = patPrescriptionDAL.GetTreatment(visitID,pPrescriptionNo, out lstPatientPrescription);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Dialysis_BL.GetDialysisVitals :", ex);
            }
            return returnCode;
        }


        public long GetPrescription(string DrugName, int Filter, int pOrgID,
            out List<PatientPrescription> lstPrescription, int
            OrgAddressId, int LocationId, long PatientVisitID)
        {
            long lresult = -1;
            lstPrescription = new List<PatientPrescription>();
            try
            {
                PatientPrescription_DAL patPrescriptionDAL = new  PatientPrescription_DAL(globalContextDetails);
                lresult=patPrescriptionDAL.GetPrescription(DrugName,Filter, pOrgID, out lstPrescription, OrgAddressId, LocationId, PatientVisitID);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPrescription BL", ex);
            }
            return lresult;

        }
       
        public long GetDose(string drugName, string brandName,out List<PatientPrescription> lstPrescription)
        {
            long lresult = -1;
            lstPrescription = new List<PatientPrescription>();
            try
            {
                PatientPrescription_DAL patPrescriptionDAL = new  PatientPrescription_DAL(globalContextDetails);
                lresult = patPrescriptionDAL.GetDose(drugName, brandName, out lstPrescription);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPrescription BL", ex);
            }
            return lresult;

        }

        public long GetDrugUseInstruction(out List<DrugUseInstruction> lstDrugUseInstruction)
        {
            long lresult = -1;
            lstDrugUseInstruction = new List<DrugUseInstruction>();
            try
            {
                PatientPrescription_DAL patPrescriptionDAL = new  PatientPrescription_DAL(globalContextDetails);
                lresult = patPrescriptionDAL.GetDrugUseInstruction(out lstDrugUseInstruction);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDrugUseInstruction BL", ex);
            }
            return lresult;

        }

        public long GetDrugUseInstructionDetails(out List<DrugUseInstruction> lstDrugUseInstruction, out List<DrugFrequency> lstDrugFrequency)
        {
            long lresult = -1;
            lstDrugUseInstruction = new List<DrugUseInstruction>();
            lstDrugFrequency = new List<DrugFrequency>();
            try
            {
                PatientPrescription_DAL patPrescriptionDAL = new  PatientPrescription_DAL(globalContextDetails);
                lresult = patPrescriptionDAL.GetDrugUseInstructionDetails(out lstDrugUseInstruction, out lstDrugFrequency);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDrugUseInstructionDetails BL", ex);
            }
            return lresult;

        }

    }
}
