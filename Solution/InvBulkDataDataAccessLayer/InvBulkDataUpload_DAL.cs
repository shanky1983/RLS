using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities.CustomEntities;
 

namespace InvBulkDataDataAccessLayer
{
    public class InvBulkDataUpload_DAL
    {
        ContextDetails globalContextDetails;
        public InvBulkDataUpload_DAL()
        {

        }
        public InvBulkDataUpload_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long ValidateTestMasterData(DataTable dttestmaster, int orgID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = InvBulkDataCommand.PValidateTestMasterDataCommand(dttestmaster, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Convert.ToInt64(ds.Tables[0].Rows[0]["Column1"]);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Validate Excell sheet", ex);
            }
            return returnCode;
        }
        public long ValidateGrpMasterData(DataTable dtgrpmaster, int orgID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = InvBulkDataCommand.PValidateGrpMasterDataCommand(dtgrpmaster, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Convert.ToInt64(ds.Tables[0].Rows[0]["Column1"]);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Validate Excell sheet", ex);
            }
            return returnCode;
        }
        public long ValidatePkgMasterData(DataTable dtpkgmaster, int orgID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = InvBulkDataCommand.PValidatePkgMasterDataCommand(dtpkgmaster, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Convert.ToInt64(ds.Tables[0].Rows[0]["Column1"]);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Validate Excell sheet", ex);
            }
            return returnCode;
        }
        public long ValidateGrpContentData(DataTable dtgrpcontent, int orgID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = InvBulkDataCommand.PValidateGrpContentDataCommand(dtgrpcontent, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Convert.ToInt64(ds.Tables[0].Rows[0]["Column1"]);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Validate Excell sheet", ex);
            }
            return returnCode;
        }
        public long ValidatePkgContentData(DataTable dtpkgcontent, int orgID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = InvBulkDataCommand.PValidatePkgContentDataCommand(dtpkgcontent, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Convert.ToInt64(ds.Tables[0].Rows[0]["Column1"]);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Validate Excell sheet", ex);
            }
            return returnCode;
        }
        public long InsertInvGrpPkgLog(int orgID, string testtype, string filename, int username, string status)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = InvBulkDataCommand.PInsertInvGrpPkgLogCommand(orgID, testtype, filename, username, status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Insert data", ex);
            }
            return returnCode;
        }
        public long GetInvGrpPkgLog(int orgID, out List<InvCreateUpdate> lstloginfo)
        {
            long returnCode = -1;
            lstloginfo = new List<InvCreateUpdate>();
            try
            {
                SqlCommand cmd = InvBulkDataCommand.PGetInvGrpPkgLogCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstloginfo);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get data", ex);
            }
            return returnCode;
        }
        public long GetInvGrpPkgError(out List<InvCreateUpdate> lsterrorinfo)
        {
            long returnCode = -1;
            lsterrorinfo = new List<InvCreateUpdate>();
            try
            {
                SqlCommand cmd = InvBulkDataCommand.PGetInvGrpPkgErrorCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lsterrorinfo);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get data", ex);
            }
            return returnCode;
        }
    }
}
