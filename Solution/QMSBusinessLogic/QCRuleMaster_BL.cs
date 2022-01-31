using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

using Attune.Solution.QMSDataAccessLayer;
using System.Data;
using Attune.Podium.Common;
using Attune.Solution.QMSBusinessEntities;

namespace Attune.Solution.QMSBusinessLogic
{
    public class QCRuleMaster_BL
    {
        
        ContextDetails globalContextDetails;
        public QCRuleMaster_BL()
        {

        }
        public QCRuleMaster_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        public long GetLotDetails(int OrgID, out List<LotDeatail> lotDetail)
        {
            DataTable FileList = new DataTable();
            long returncode = -1;
            lotDetail = new List<LotDeatail>();
            RuleMaster_DAL objQCR = new RuleMaster_DAL(globalContextDetails); 
            try
            {
                returncode = objQCR.GetLotDetails(OrgID, out lotDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Getting (GetLotDetails) BL", ex);
            }
            return returncode;
        }
        public long GetRuleMasters(int OrgID,long LotId,long InvId,long QCLevelID ,out List<QCRuleMaster> QCRuleMasterList)
        {
            DataTable FileList = new DataTable();
            long returncode = -1;
            QCRuleMasterList = new List<QCRuleMaster>();

            RuleMaster_DAL objQCR = new RuleMaster_DAL(globalContextDetails); 
            try
            {
                returncode = objQCR.GetRuleMasters(OrgID,LotId,InvId,QCLevelID,out QCRuleMasterList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Getting (GetLotDetails) BL", ex);
            }
            return returncode;
        }
        public long SaveQcRuleMaster(long LotId, long Analyte, string ManufacturerRefRange, string ManufacturerMean, int Run, string LabRefRange, decimal LabMean, decimal LabSD, string LJChartCalc, long OrgId, long CreatedBy, System.DateTime CreatedAt, long ModifiedBy, System.DateTime ModifiedAt,long QCLevelID,string QCLevel)
        {
            long returncode = -1;
            RuleMaster_DAL objQCR = new RuleMaster_DAL(globalContextDetails);
            try
            {
                returncode = objQCR.SaveQcRuleMaster(LotId, Analyte, ManufacturerRefRange, ManufacturerMean, Run, LabRefRange, LabMean, LabSD, LJChartCalc, OrgId, CreatedBy, CreatedAt, ModifiedBy, ModifiedAt,QCLevelID,QCLevel);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while (SaveQcRuleMaster) BL", ex);
            }
            return returncode;
        }

        public long DeleteRuleMaster(long QCRID)
        {
            long returncode = -1;
            RuleMaster_DAL objQCR = new RuleMaster_DAL(globalContextDetails);
            try
            {
                returncode=objQCR.DeleteRuleMaster(QCRID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While DeleteRuleMaster BL", ex);
            }
            return returncode;
        }

        public long UpdateQcRuleMaster(long QCRID, long LotId, long Analyte, string ManufacturerRefRange, string ManufacturerMean, int Run, string LabRefRange, decimal LabMean, decimal LabSD, string LJChartCalc, long OrgId)
        {
            long returncode = -1;
            RuleMaster_DAL objQCR = new RuleMaster_DAL(globalContextDetails);
            try
            {
                returncode = objQCR.UpdateQcRuleMaster(QCRID, LotId, Analyte, ManufacturerRefRange, ManufacturerMean, Run, LabRefRange, LabMean, LabSD, LJChartCalc, OrgId);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While UpdateQcRuleMaster DAL", ex);
            }
            return returncode;
        }


    }
}
