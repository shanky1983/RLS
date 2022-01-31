using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Podium.DataAccessEngine;
using System.Data.SqlClient;
using Attune.Podium.Common;
using Attune.Solution.QMSBusinessEntities;
using Attune.Solution.QMSDataAccessLayer;
namespace Attune.Solution.DAL
{
    public class Country_DAL
    {
         ContextDetails globalContextDetails;
        public Country_DAL()
        {

        }
        public Country_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        //public long GetCountryList(out List<Country> countries)
        //{
        //    long returnCode = -1;
        //    countries = new List<Country>();
        //    IDataReader dataReader = null;
        //    try
        //    {
        //        SqlCommand objCommand = new SqlCommand();
        //        objCommand.CommandType = CommandType.StoredProcedure;
        //        objCommand.CommandText = "pGetCountryListLis";
        //        using (DBEngine dBEngine = new DBEngine())
        //        {
        //            dataReader = dBEngine.ExecuteReader(objCommand);
        //            if (dataReader != null)
        //                returnCode = Utilities.ConvertTo(dataReader, out countries);
        //            dataReader.Close();
        //        }
        //    }
        //    catch (Exception excep)
        //    {
        //        CLogger.LogError("Error while executing GetCurrencyForOrg in Master_DAL", excep);
        //    }
        //    finally
        //    {
        //        if (dataReader != null)
        //        {
        //            dataReader.Close();
        //        }
        //    }
        //    return returnCode;
        //}

        //public long GetNationalityList(out List<Country> lstNationality)
        //{
        //    long returnCode = -1;
        //    lstNationality = new List<Country>();
        //    IDataReader dataReader = null;
        //    try
        //    {
        //        SqlCommand cmd = Command.pGetNationalityLisCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //        using (DBEngine dbEngine = new DBEngine())
        //        {
        //            dataReader = dbEngine.ExecuteReader(cmd);
        //            if (dataReader != null)
        //            {
        //                returnCode = Utilities.ConvertTo(dataReader, out lstNationality);
        //                dataReader.Close();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in Country DAL pGetNationalityLis", ex);
        //    }
        //    finally
        //    {
        //        if (dataReader != null)
        //        {
        //            dataReader.Close();
        //        }
        //    }
        //    return returnCode;
        //}

    
        //public long LoadNationalityOfCountry(long countryid,out List<Country> lstNationality)
        //{
        //    long returnCode = -1;
        //    lstNationality = new List<Country>();
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        SqlCommand cmd = Command.pLoadNationalityOfCountryLisCommand(Convert.ToInt32(countryid), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //        using (DBEngine dbEngine = new DBEngine())
        //        {
        //            dbEngine.ExecuteDataSet(cmd, out ds);
        //        }
        //        if (ds.Tables.Count > 0)
        //        {
        //            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstNationality);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in Country DAL pLoadNationalityOfCountryLis", ex);
        //    }

        //    return returnCode;
        //}
        //public long GetReligionList(out List<Religion> lstReligion)
        //{
        //    long returnCode = -1;
        //    lstReligion = new List<Religion>();
        //    IDataReader dataReader = null;
        //    try
        //    {
        //        SqlCommand cmd = Command.pGetReligionCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //        using (DBEngine dbEngine = new DBEngine())
        //        {
        //            dataReader = dbEngine.ExecuteReader(cmd);
        //            if (dataReader != null)
        //            {
        //                returnCode = Utilities.ConvertTo(dataReader, out lstReligion);
        //                dataReader.Close();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in Country DAL GetReligionList", ex);
        //    }
        //    finally
        //    {
        //        if (dataReader != null)
        //        {
        //            dataReader.Close();
        //        }
        //    }
        //    return returnCode;
        //}

        public long GetLocalities(int CodeID, out List<Localities> lstLocalities)
        {
            long returnCode = -1;
            lstLocalities = new List<Localities>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetLocalitiesCommand(CodeID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLocalities);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Country DAL pGetLocalities", ex);
            }

            return returnCode;
        }
    }
}
