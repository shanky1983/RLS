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
    public class Immunize_BL
    {
         ContextDetails globalContextDetails;
        public Immunize_BL()
        {

        }
        public Immunize_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetVaccinationtoImmunize(out List<Vaccination> lstVacctoImmunize)
        {
            long returnCode = -1;
            lstVacctoImmunize = new List<Vaccination>();

            try
            {
                returnCode = new Immunize_DAL(globalContextDetails).GetVaccinationtoImmunize(out lstVacctoImmunize);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetVaccinationtoImmunize", ex);
            }
            return returnCode;
        }

        public long InsertPatientBabyVaccination(List<PatientBabyVaccination> lstPatientBabyVaccination, out int pOrderedCount)
        {
            long returnCode = -1;
            pOrderedCount = -1;
            try
            {
                returnCode = new Immunize_DAL(globalContextDetails).InsertPatientBabyVaccination(lstPatientBabyVaccination, out pOrderedCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL InsertPatientBabyVaccination", ex);
            }

            return returnCode;
        }

       
        public long GetPatientBabyVaccListbyPID(long pID, out List<PatientBabyVaccination> lstPBV)
        {
            long returnCode = -1;
            lstPBV = new List<PatientBabyVaccination>();
            try
            {
                returnCode = new Immunize_DAL(globalContextDetails).GetPatientBabyVaccListbyPID(pID, out lstPBV);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetPatientBabyVaccListbyPID", ex);
            }

            return returnCode;
        }
        public long InsertMasterData(List<CasualtyCharges> lCasuality )
        {
            long returnCode = -1;
            //lCasuality = new List<CasualtyCharges>();
            try
            {
                returnCode = new Immunize_DAL(globalContextDetails).InsertMasterData(lCasuality );
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in InsertMasterData BL", ex);
            }
            return returnCode;
        }
    }
}
