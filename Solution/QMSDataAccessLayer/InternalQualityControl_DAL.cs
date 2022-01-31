using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using System.Data;
using Attune.Solution.QMSBusinessEntities.CustomEntities;
using Attune.Solution.QMSBusinessEntities;

namespace Attune.Solution.QMSDataAccessLayer
{
  public  class InternalQualityControl_DAL
    {
        ContextDetails globalContextDetails;
        public InternalQualityControl_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }


        public long GetQMSAutoComp_DAL(string Suggestion, string ControlName,out   List<DropDownKeyValue> lstValue)
        {
            long returnCode = -1;

            DataSet ds = new DataSet();

            lstValue = new List<DropDownKeyValue>();
            try
            {
                SqlCommand cmd = Command.PgetQMSAutoCompDDLCommand(Suggestion, ControlName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstValue);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetQMSAutoComp", ex);
            }
            return returnCode;
        }


        public long LoadQCLJChartDetails_DAL(int LocationID, long InstrumentID,int LotID, long AnalyteID, string Level, string FromDate, string ToDate, out  List<InternalQualityControl> _lstValue, out List<QCMedanSD> _lstMeanSD, out DataTable _dtLJPlot,out List<LJChartValue> _lstLJPlot)
        {
            long returnCode = -1;

            DataSet ds = new DataSet();


            _lstValue = new List<InternalQualityControl>();
            _lstMeanSD = new List<QCMedanSD>();
            _dtLJPlot = new DataTable();

           _lstLJPlot = new List<LJChartValue>();
            try
            {
                SqlCommand cmd = Command.pGetQCLJChartDetailsCommand(LocationID,InstrumentID,LotID,AnalyteID,Level,FromDate,ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out _lstValue);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out _lstMeanSD);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out _lstLJPlot);
                    _dtLJPlot = ds.Tables[2];
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL LoadQCLJChartDetails", ex);
            }

            return returnCode;
        }

        public long LoadQCLJComparisonChartDetails_DAL(int LocationID, long InstrumentID, int LotID, long AnalyteID, string Level, string FromDate, string ToDate, out DataTable _dtLJCOnePlot, out DataTable _dtLJCTwoPlot, out DataTable _dtLJCThreePlot)
        {
            long returnCode = -1;

            DataSet ds = new DataSet();
            _dtLJCOnePlot = new DataTable();
            _dtLJCTwoPlot = new DataTable();
            _dtLJCThreePlot = new DataTable();
            try
            {
                SqlCommand cmd = Command.pGetQCLJComparisonChartDetailsCommand(LocationID, InstrumentID, LotID, AnalyteID, Level, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _dtLJCOnePlot = ds.Tables[0];
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    _dtLJCTwoPlot = ds.Tables[1];
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    _dtLJCThreePlot = ds.Tables[2];
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL LoadQCLJComparisonChartDetails", ex);
            }

            return returnCode;
        }

        public long QMS_UpdateLJchartValues_DAL(List<LJChartValue> LJChartValue)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pUpdateLJChartValuesCommand(LJChartValue[0].QCValueID, LJChartValue[0].FailedRule, LJChartValue[0].Reason, LJChartValue[0].PreventiveAction, LJChartValue[0].CorrectionAction, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executig in QMS_SaveAnalyzermappingDetails_DAL", e);
            }
            return returncode;
        }
      
       
    }
}
