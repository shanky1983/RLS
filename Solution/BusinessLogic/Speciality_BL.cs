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


namespace Attune.Solution.BusinessComponent
{
    public class Speciality_BL
    {
        ContextDetails globalContextDetails;
        public Speciality_BL()
        {

        }
        public Speciality_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetSpeciality(int pOrganizationID, out List<Speciality> lstspeciality)
        {
            long lresult = -1;
            lstspeciality = new List<Speciality>();
            
            Speciality_DAL specialityDal = new Speciality_DAL(globalContextDetails);
            lresult = specialityDal.GetSpeciality(pOrganizationID, out lstspeciality);
            return lresult;

        }
        public long pViewSpeciality(int pOrganizationID, out List<Speciality> lstspeciality)
        {
            long lresult = -1;
            lstspeciality = new List<Speciality>();

            Speciality_DAL specialityDal = new Speciality_DAL(globalContextDetails);
            lresult = specialityDal.pViewSpeciality(pOrganizationID, out lstspeciality);
            return lresult;

        }
        public long SearchSpeciality(int OrgID, string specialityName, out List<Speciality> lstSpeciality)
        {
            long returnCode = -1;
            lstSpeciality = new List<Speciality>();

            try
            {
                Speciality_DAL specialityDAL = new Speciality_DAL(globalContextDetails);
                returnCode = specialityDAL.SearchSpeciality(OrgID, specialityName, out lstSpeciality);
            }
            catch (Exception ex)
            {             
                CLogger.LogError("Error while executing SearchSpeciality", ex);
            }

            return returnCode;
        }
        public long pSaveSpecialityName(Speciality speciality, out long SpecialityID)
        {
            long reutnCode = -1;
            SpecialityID = -1;
            try
            {
                Speciality_DAL specialityDAL = new Speciality_DAL(globalContextDetails);
                reutnCode = specialityDAL.pSaveSpecialityName(speciality, out SpecialityID);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error While Executing SaveInvestigationDrugBrand Patient_BL", excep);
            }
            return reutnCode;
        }
        public long pUpdateSpecialityName(Speciality speciality)
        {
            long returnCode = -1;
            try
            {
                Speciality_DAL specialityDAL = new Speciality_DAL(globalContextDetails);
                returnCode = specialityDAL.pUpdateSpecialityName(speciality);
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while during UpdateInvestigationDrugBrand", excep);
            }
            return returnCode;
        }

        
    }
}

