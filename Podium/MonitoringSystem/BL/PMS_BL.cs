using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

namespace MonitoringSystem
{
    public class PMS_BL
    {

        ContextDetails globalContextDetails;
        public PMS_BL()
        {

        }
        public PMS_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetAllCategoriesandFolders(long FolderID, out List<PMSCategories> lstCategories, out List<PMSFolders> lstFolders)
        {
            long returnCode = -1;
            lstCategories = new List<PMSCategories>();
            lstFolders = new List<PMSFolders>();
            try
            {
                returnCode = new PMS_DAL(globalContextDetails).GetAllCategoriesandFolders(FolderID, out lstCategories, out lstFolders);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PMS_BL - GetAllCategoriesandFolders", ex);
            }

            return returnCode;
        }


        public long GetParametersforProcedure(long ProcedureID, out List<PMSProcedureParameters> lstProcedureParameters)
        {
            long returnCode = -1;
            lstProcedureParameters = new List<PMSProcedureParameters>();
            try
            {
                returnCode = new PMS_DAL(globalContextDetails).GetParametersforProcedure(ProcedureID, out lstProcedureParameters);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PMS_BL - GetParametersforProcedure", ex);
            }

            return returnCode;
        }


        public DataSet RenderingReport(long ProcedureID, string StringParam)
        {
            DataSet lstOutDataSet = new DataSet();
            try
            {
                lstOutDataSet = new PMS_DAL(globalContextDetails).RenderingReport(ProcedureID, StringParam);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PMS_BL - RenderingReport", ex);
            }

            return lstOutDataSet;
        }

        public long GetDDLValuesForParameters(long ParamQueryID,long lID ,out List<PMSDDLOutput> lstDDLOutput)
        {
            long returnCode = -1;
            lstDDLOutput = new List<PMSDDLOutput>();
            try
            {
                returnCode = new PMS_DAL(globalContextDetails).GetDDLValuesForParameters(ParamQueryID,lID, out lstDDLOutput);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PMS_BL - GetDDLValuesForParameters", ex);
            }

            return returnCode;
        }

    }
}
