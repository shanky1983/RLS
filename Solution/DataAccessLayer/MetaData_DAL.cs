using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;
using System.IO;
using System.Text;
using System.Collections.Specialized;
using System.Collections;
using Attune.Solution.DAL;


namespace Attune.Solution.DAL
{
    public class MetaData_DAL
    {
          ContextDetails globalContextDetails;
        public MetaData_DAL()
        {

        }
        public MetaData_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long LoadMetaData(List<MetaData> lstmetadatainput, out List<MetaData> lstMetaDataInput)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            lstMetaDataInput = new List<MetaData>();

            DataTable dtMetaData = UDT_DAL.ConvertToUDTMetaData(lstmetadatainput);

            SqlCommand cmdMetaData = new SqlCommand();

            cmdMetaData = Command.pLoadMetaDataCommand(dtMetaData,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmdMetaData.Parameters.Add("@Return", SqlDbType.Int);
            cmdMetaData.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteDataSet(cmdMetaData, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstMetaDataInput);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading MetaData", ex);

            }
            return returnCode;
        }



        public long LoadMetaData_New(List<MetaData> lstDomain, string LangCode, out NameValueCollection objCollection)
        {
            long returnCode = -1;
            objCollection = new NameValueCollection();

            DataTable dtMetaData = UDT_DAL.ConvertToUDTMetaData(lstDomain);

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pLoadMetaData_NewCommand(dtMetaData, LangCode,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out objCollection);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetBillConfigDetails", ex);
            }

            return returnCode;


        }
        public long LoadMetaDataOrgMapping(List<MetaData> lstDomain, long OrgID, string LangCode, out List<MetaData> objectcollection)
        {
            long returnCode = -1;
            objectcollection = null;// new NameValueCollection();
			IDataReader dataReader = null;
            try
            {
                DataTable dtMetaData = UDT_DAL.ConvertToUDTMetaData(lstDomain);

                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pLoadMetaDataOrgMappingLisCommand(dtMetaData, OrgID, LangCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out objectcollection);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While loading MetadataOrg Mapping", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;

        }
		  public long pInsertMetaData(MetaData objMetaData, out long returnCode)
        {
            returnCode = -1;
            SqlCommand cmd = Command.pInsertMetaDataCommand(objMetaData.MetaDataID, objMetaData.Domain, objMetaData.Code,objMetaData.Name, objMetaData.DisplayText, objMetaData.ParentID, objMetaData.SeqNo,objMetaData.LangCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out  returnCode);
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@ReturnCode"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing InsertAnalyzerType Master_DAL", ex);
            }
            return returnCode;
        }

        public long LoadMetaData(out List<MetaData> lstMetaData,out List<LanguageMaster> lstLanguageMaster)
        {
            long returnCode = -1;
            //IDataReader dr = null;
            lstMetaData=new List<MetaData>();
            lstLanguageMaster = new List<LanguageMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd = Command.pGetMetaDataMasterCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    //dr = dbEngine.ExecuteReader(cmd);
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Utilities.ConvertTo(ds.Tables[0], out lstMetaData);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        Utilities.ConvertTo(ds.Tables[1], out lstLanguageMaster);
                    }
                    
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetAnalyzerType DAL Master", ex);
            }
           
            return returnCode;

        }
        public DataSet LoadSpeciesOrgMappingid(long OrgID)
        {
            DataSet ds = new DataSet();
            long returnCode = -1;
            SqlCommand cmd = Command.pLoadSpeciesOrgMappingLisCommand(OrgID);
            try
            {


                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataSet ds1 = ds;
                }



            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetValuesInvOrginterpretationMapping", ex);
            }
            return ds;
        }
        public long LoadSpeciesOrgMapping(long OrgID, out List<MetaData> lstSpeciesOutput)
        {
            lstSpeciesOutput = new List<MetaData>();
            long returnCode = -1;
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pLoadSpeciesOrgMappingLisCommand(OrgID);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSpeciesOutput);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While loading LoadSpeciesOrgMapping", ex);
            }
            return returnCode;
        }
    }
}
