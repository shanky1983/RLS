using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using Attune.Podium.BusinessEntities;
using InvBulkDataDataAccessLayer;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities.CustomEntities;

namespace InvBulkDataBusinessLogic
{
    public class InvBulkDataUpload_BL
    {
        ContextDetails globalContextDetails;
        public InvBulkDataUpload_BL()
        {

        }
        public InvBulkDataUpload_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long ValidateTestMasterData(DataTable dttestmaster, int orgID)
        {
            long returnCode = -1;
            try
            {
                InvBulkDataUpload_DAL invBulkDataUpload_DAL = new InvBulkDataUpload_DAL(globalContextDetails);
                returnCode = invBulkDataUpload_DAL.ValidateTestMasterData(dttestmaster, orgID);
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
                InvBulkDataUpload_DAL invBulkDataUpload_DAL = new InvBulkDataUpload_DAL(globalContextDetails);
                returnCode = invBulkDataUpload_DAL.ValidateGrpMasterData(dtgrpmaster, orgID);
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
                InvBulkDataUpload_DAL invBulkDataUpload_DAL = new InvBulkDataUpload_DAL(globalContextDetails);
                returnCode = invBulkDataUpload_DAL.ValidatePkgMasterData(dtpkgmaster, orgID);
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
                InvBulkDataUpload_DAL invBulkDataUpload_DAL = new InvBulkDataUpload_DAL(globalContextDetails);
                returnCode = invBulkDataUpload_DAL.ValidateGrpContentData(dtgrpcontent, orgID);
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
                InvBulkDataUpload_DAL invBulkDataUpload_DAL = new InvBulkDataUpload_DAL(globalContextDetails);
                returnCode = invBulkDataUpload_DAL.ValidatePkgContentData(dtpkgcontent, orgID);
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
                InvBulkDataUpload_DAL invBulkDataUpload_DAL = new InvBulkDataUpload_DAL(globalContextDetails);
                returnCode = invBulkDataUpload_DAL.InsertInvGrpPkgLog(orgID, testtype, filename, username, status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Insert Log data", ex);
            }
            return returnCode;
        }
        public long GetInvGrpPkgLog(int orgID, out List<InvCreateUpdate> lstloginfo)
        {
            long returnCode = -1;
            lstloginfo = new List<InvCreateUpdate>();
            try
            {
                InvBulkDataUpload_DAL invBulkDataUpload_DAL = new InvBulkDataUpload_DAL(globalContextDetails);
                returnCode = invBulkDataUpload_DAL.GetInvGrpPkgLog(orgID, out lstloginfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get Log data", ex);
            }
            return returnCode;
        }
        public long GetInvGrpPkgError(out List<InvCreateUpdate> lsterrorinfo)
        {
            long returnCode = -1;
            lsterrorinfo = new List<InvCreateUpdate>();
            try
            {
                InvBulkDataUpload_DAL invBulkDataUpload_DAL = new InvBulkDataUpload_DAL(globalContextDetails);
                returnCode = invBulkDataUpload_DAL.GetInvGrpPkgError(out lsterrorinfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get Log data", ex);
            }
            return returnCode;
        }

    }
}
