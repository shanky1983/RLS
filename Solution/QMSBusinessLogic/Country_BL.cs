using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Podium.Common;
using Attune.Solution.QMSBusinessEntities;

namespace Attune.Solution.QMSBusinessLogic
{
   public class Country_BL
    {
       ContextDetails globalContextDetails;
        public Country_BL()
        {

        }
        public Country_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        
        //public long GetCountryList(out List<Country> countries)
        //{
        //    long returnCode = -1;
        //    countries = null;
        //    try
        //    {
        //        Country_DAL countryDAL = new Country_DAL(globalContextDetails);
        //        returnCode = countryDAL.GetCountryList(out countries);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing GetCountryList", excp);
        //    }

        //    return returnCode;
        //}
        //public long GetNationalityList(out List<Country> lstNationality)
        //{
        //    long returnCode = -1;
        //    lstNationality = new List<Country>();
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        returnCode = new Country_DAL(globalContextDetails).GetNationalityList(out lstNationality);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in Country BL GetNationalityList", ex);
        //    }

        //    return returnCode;
        //}
        //public long LoadNationalityOfCountry(int countryid,out List<Country> lstNationality)
        //{
        //    long returnCode = -1;
        //    lstNationality = new List<Country>();
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        returnCode = new Country_DAL(globalContextDetails).LoadNationalityOfCountry(countryid,out lstNationality);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in Country BL GetNationalityList", ex);
        //    }

        //    return returnCode;
        //}
        //public long GetReligionList(out List<Religion> lstReligion)
        //{
        //    long returnCode = -1;
        //    lstReligion = new List<Religion>();
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        returnCode = new Country_DAL(globalContextDetails).GetReligionList(out lstReligion);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in Country BL GetReligionList", ex);
        //    }

        //    return returnCode;
        //}
        //public long GetLocalities(int ID, out List<Localities> countries)
        //{
        //    long returnCode = -1;
        //    countries = null;
        //    try
        //    {
        //        Country_DAL countryDAL = new Country_DAL(globalContextDetails);
        //        returnCode = countryDAL.GetLocalities(ID, out countries);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing GetLocalities", excp);
        //    }

        //    return returnCode;
        //}
    }


}
