using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.Common;
using Attune.Podium.DataAccessEngine;
using Attune.Solution.QMSBusinessEntities;
namespace Attune.Solution.QMSDataAccessLayer
{
    public class RuleMaster_DAL
    {
        ContextDetails globalContextDetails;
        public RuleMaster_DAL()
        {
        }
        public RuleMaster_DAL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        public long GetLotDetails(int pOrgID, out List<LotDeatail> lotDetail)
        {
            DataTable FileList = new DataTable();
            long returncode = -1;
            lotDetail = new List<LotDeatail>();
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PgetlotdetailsCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<LotDeatail>(IdR, out lotDetail);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Getting (GetLotDetails) DAL", ex);
            }
            return returncode;
        }
        public long GetRuleMasters(int pOrgID,long LotId,long InvId, long QCLevelID,out List<QCRuleMaster> QCRuleMasterList)
        {
            DataTable FileList = new DataTable();
            long returncode = -1;
            QCRuleMasterList = new List<QCRuleMaster>();
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                
                cmd = Command.PgetqcrulemasterCommand(pOrgID,LotId,InvId,QCLevelID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<QCRuleMaster>(IdR, out QCRuleMasterList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Getting (GetRuleMasters) DAL", ex);
            }
            return returncode;
        }
        public long SaveQcRuleMaster(long LotId, long Analyte, string ManufacturerRefRange, string ManufacturerMean, int Run, string LabRefRange, decimal LabMean, decimal LabSD, string LJChartCalc, long OrgId, long CreatedBy, System.DateTime CreatedAt, long ModifiedBy, System.DateTime ModifiedAt,long QCLevelID,string QCLevel)
        {
            long returncode = -1;
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd = Command.PsaveqcrulemasterCommand(LotId, Analyte, ManufacturerRefRange, ManufacturerMean, Run, LabRefRange,
                    LabMean, LabSD, LJChartCalc, OrgId, CreatedBy, CreatedAt, ModifiedBy, ModifiedAt,QCLevelID, QCLevel,
                    UDT_DAL.ConvertToUDT_Context(globalContextDetails) );
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While SaveQcRuleMaster DAL", ex);
            }
            return returncode;
        }
        public long DeleteRuleMaster(long QCRID)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PdeleterulemasterCommand (QCRID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While DeleteRuleMaster DAL", ex);
            }
            return returncode;
        }

        public long UpdateQcRuleMaster(long QCRID, long LotId, long Analyte, string ManufacturerRefRange, string ManufacturerMean, int Run, string LabRefRange, decimal LabMean, decimal LabSD, string LJChartCalc, long OrgId)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PupdateqcrulemasterCommand(QCRID,LotId,Analyte,ManufacturerRefRange,ManufacturerMean,Run,LabRefRange,LabMean,LabSD,LJChartCalc,OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                returncode=   dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While UpdateQcRuleMaster DAL", ex);
            }
            return returncode;
        }

    }
}
