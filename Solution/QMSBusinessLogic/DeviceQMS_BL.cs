using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Solution.QMSBusinessEntities;
using Attune.Podium.Common;
using Attune.Solution.QMSDataAccessLayer;
using System.Data;

namespace Attune.Solution.QMSBusinessLogic
{
    public class DeviceQMS_BL
    {
        ContextDetails globalContextDetails;
      
        public DeviceQMS_BL() 
        { 

        }
        public DeviceQMS_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        public long GetQCResultSearchValues(Int32 pOrgID, String pType, String pSearchText, out List<CodingScheme> lstCodingScheme)
        {
            long returnCode = -1;
            lstCodingScheme = new List<CodingScheme>();
            try
            {
                returnCode = new DeviceQMS_DL(globalContextDetails).GetQCResultSearchValues(pOrgID, pType, pSearchText, out lstCodingScheme);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQCResultSearchValues in DeviceQMS_BL", ex);
            }
            return returnCode;
        }

        public long GetQCResultDetails(Int32 pOrgID, Int64 pInstrumentID, Int64 InvestigationID, Int64 pLotID, DateTime pFromDate, DateTime pToDate, out DataTable FileList)
        {
            long returnCode = -1;
            FileList = new DataTable();
            try
            {
                returnCode = new DeviceQMS_DL(globalContextDetails).GetQCResultDetails(pOrgID, pInstrumentID, InvestigationID, pLotID, pFromDate, pToDate, out FileList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQCResultDetails in DeviceQMS_BL", ex);
            }
            return returnCode;
        }

        public long GetQCLabMeanDetails(Int32 pOrgID, Int64 pInstrumentID, Int64 InvestigationID, Int64 pLotID, out DataTable FileList)
        {
            long returnCode = -1;
            FileList = new DataTable();
            try
            {
                returnCode = new DeviceQMS_DL(globalContextDetails).GetQCLabMeanDetails(pOrgID, pInstrumentID, InvestigationID, pLotID, out FileList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQCResultDetails in DeviceQMS_BL", ex);
            }
            return returnCode;
        }

        public long GetFloatingMeanDetails(Int32 pOrgID, Int64 pInstrumentID, Int64 InvestigationID, Int64 pLotID, DateTime pFromDate, DateTime pToDate, int pFMOption, out DataTable FileList)
        {
            long returnCode = -1;
            FileList = new DataTable();
            try
            {
                returnCode = new DeviceQMS_DL(globalContextDetails).GetFloatingMeanDetails(pOrgID, pInstrumentID, InvestigationID, pLotID, pFromDate, pToDate, pFMOption, out FileList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetFloatingMeanDetails in DeviceQMS_BL", ex);
            }
            return returnCode;
        }

        public long SaveQCEvaluvationsDetails(List<QCEvaluvationsDetails> lstQCEvaluvationsDetails)
        {
            long returnCode = -1;
            try
            {
                returnCode = new DeviceQMS_DL(globalContextDetails).SaveQCEvaluvationsDetails(lstQCEvaluvationsDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveQCEvaluvationsDetails in DeviceQMS_BL", ex);
            }
            return returnCode;
        }
    }
}
