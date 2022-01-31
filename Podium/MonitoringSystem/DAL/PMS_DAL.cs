using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Data.Common;
using System.Data.SqlClient;

namespace MonitoringSystem
{
    public class PMS_DAL
    {
        ContextDetails globalContextDetails;
        public PMS_DAL()
        {

        }
        public PMS_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetAllCategoriesandFolders(long FolderID, out List<PMSCategories> lstCategories, out List<PMSFolders> lstFolders)
        {
            long returnCode = -1;
            lstCategories = new List<PMSCategories>();
            lstFolders = new List<PMSFolders>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {

                SqlCommand cmd = Command.pGetAllCategoriesandFoldersCommand(FolderID);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCategories);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstFolders);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PMS_DAL- GetAllCategoriesandFolders", ex);
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


        public long GetParametersforProcedure(long ProcedureID, out List<PMSProcedureParameters> lstProcedureParameters)
        {
            long returnCode = -1;
            lstProcedureParameters = new List<PMSProcedureParameters>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {

                SqlCommand cmd = Command.pGetParametersforProcedureCommand(ProcedureID);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstProcedureParameters);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PMS_DAL- GetParametersforProcedure", ex);
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


        public DataSet RenderingReport(long ProcedureID, string StringParam)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            DataSet lstOutDataSet = new DataSet();
            try
            {
                SqlCommand cmd = Command.pRenderingReportCommand(ProcedureID, StringParam);

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    lstOutDataSet = ds;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PMS_DAL - RenderingReport", ex);
            }
            return lstOutDataSet;
        }

        public long GetDDLValuesForParameters(long ParamQueryID, long lID ,out List<PMSDDLOutput> lstDDLOutput)
        {
            long returnCode = -1;
            lstDDLOutput = new List<PMSDDLOutput>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {

                SqlCommand cmd = Command.pGetDDLValuesForParametersCommand(ParamQueryID,lID);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDDLOutput);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PMS_DAL- GetDDLValuesForParameters", ex);
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
    }
}
