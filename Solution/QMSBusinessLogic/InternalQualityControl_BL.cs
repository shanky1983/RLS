using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Attune.Podium.Common;
using Attune.Solution.QMSDataAccessLayer;

using System.Data;
using Attune.Solution.QMSBusinessEntities;
using Attune.Solution.QMSBusinessEntities.CustomEntities;

namespace Attune.Solution.QMSBusinessLogic
{
   public class InternalQualityControl_BL
    {
         ContextDetails globalContextDetails;
         public InternalQualityControl_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

         public long GetQMSAutoComp_BL(string Suggestion, string ControlName, out   List<DropDownKeyValue> lstValue)
         {
             long returncode = -1;

             lstValue = new List<DropDownKeyValue>();
             try
             {
              InternalQualityControl_DAL  ObjDAL = new InternalQualityControl_DAL(globalContextDetails);
              returncode = ObjDAL.GetQMSAutoComp_DAL(Suggestion, ControlName, out lstValue);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error In QMS  In The MethodeGetQMSAutoComp_BL", ex);
             }
             return returncode;
         }





         public long LoadQCLJChartDetails_BL(int LocationID, long InstrumentID,int LotID, long AnalyteID, string Level,String FromDate, string ToDate, out  List<InternalQualityControl> lstValue, out List<QCMedanSD> lstMeanSD, out string _strLJChart, out List<LJChartValue> _lstLJPlot)
         { 
             long returncode = -1;

             lstValue = new List<InternalQualityControl>();
             lstMeanSD = new List<QCMedanSD>();
             _lstLJPlot = new List<LJChartValue>();
             DataTable _dtLJplot = new DataTable();
             _strLJChart = "";
             StringBuilder Sb = new StringBuilder();
             try
             {
              InternalQualityControl_DAL  ObjDAL = new InternalQualityControl_DAL(globalContextDetails);
              returncode = ObjDAL.LoadQCLJChartDetails_DAL(LocationID, InstrumentID,LotID, AnalyteID, Level, FromDate, ToDate, out lstValue, out lstMeanSD, out _dtLJplot, out _lstLJPlot);

              int DtLength = _dtLJplot.Rows.Count;
              if (DtLength > 0)
              {
                  

                  for(int i =0 ; i<30 ;i++)
                  {

                      if (i < DtLength)
                      {
                          Sb.Append(_dtLJplot.Rows[i]["RowNum"].ToString() != null ? _dtLJplot.Rows[i]["RowNum"].ToString() + "," : "" + ",");
                          Sb.Append(_dtLJplot.Rows[i]["ProcessedAt"].ToString() != null ? _dtLJplot.Rows[i]["ProcessedAt"].ToString() + "," : "" + ",");
                          Sb.Append(_dtLJplot.Rows[i]["Value"].ToString() != null ? _dtLJplot.Rows[i]["Value"].ToString() + "," : "" + ",");
                          Sb.Append(_dtLJplot.Rows[i]["PDate"].ToString() != null ? _dtLJplot.Rows[i]["PDate"].ToString() + ";\n" : ";\n");
                      }
                      else
                      {
                          Sb.Append( i+1 + "," + ","+"," + ";\n");

                      }


                  }

                  //foreach (DataRow row in _dtLJplot.Rows)
                  //{

                  //    foreach (DataColumn col in _dtLJplot.Columns)
                  //    {
                  //        if (col.ToString() == "ProcessedAt" || col.ToString() == "Value" || col.ToString() == "RowNum" || col.ToString() == "PDate")
                  //        {
                  //            _strLJChart += row[col].ToString() + ",";
                  //        }
                  //    }

                  //    _strLJChart = _strLJChart.Substring(0, _strLJChart.Length - 1);

                  //    _strLJChart += ";\n" ;

                  //}

                  _strLJChart = Sb.ToString();
              }
              else
              {
                  _strLJChart = "0,0;\n;";
              }


             }

              
             catch (Exception ex)
             {
                 CLogger.LogError("Error In QMS Webservice  In The Methode LoadQCLJChartDetails_BL", ex);
             }
             return returncode;
         }

         public long LoadQCLJComparisonChartDetails_BL(int LocationID, long InstrumentID, int LotID, long AnalyteID, string Level, String FromDate, string ToDate, out string _strLJOneChart, out string _strLJTwoChart, out string _strLJThreeChart)
         {
             long returncode = -1;

             DataTable _dtLJCOnePlot = new DataTable();
             DataTable _dtLJCTwoPlot = new DataTable();
             DataTable _dtLJCThreePlot = new DataTable();
             _strLJOneChart = string.Empty;
             _strLJTwoChart = string.Empty;
             _strLJThreeChart = string.Empty;
             StringBuilder SbOneLevel = new StringBuilder();
             StringBuilder SbTwoLevel = new StringBuilder();
             StringBuilder SbThreeLevel = new StringBuilder();

             try
             {
                 InternalQualityControl_DAL ObjDAL = new InternalQualityControl_DAL(globalContextDetails);
                 returncode = ObjDAL.LoadQCLJComparisonChartDetails_DAL(LocationID, InstrumentID, LotID, AnalyteID, Level, FromDate, ToDate, out _dtLJCOnePlot, out _dtLJCTwoPlot, out _dtLJCThreePlot);

                 int DtOneLength = _dtLJCOnePlot.Rows.Count;
                 if (DtOneLength > 0)
                 {
                     for (int i = 0; i < 30; i++)
                     {
                         if (i < DtOneLength)
                         {
                             SbOneLevel.Append(_dtLJCOnePlot.Rows[i]["ProcessedAt"].ToString() != null ? _dtLJCOnePlot.Rows[i]["ProcessedAt"].ToString() + "," : ",");
                             SbOneLevel.Append(_dtLJCOnePlot.Rows[i]["QCRange"].ToString() != null ? _dtLJCOnePlot.Rows[i]["QCRange"].ToString() + "," : ",");
                             SbOneLevel.Append(_dtLJCOnePlot.Rows[i]["QCStatus"].ToString() != null ? _dtLJCOnePlot.Rows[i]["QCStatus"].ToString() + ";" : ";");
                         }
                     }

                     _strLJOneChart = SbOneLevel.ToString();
                 }

                 int DtTwoLength = _dtLJCTwoPlot.Rows.Count;
                 if (DtTwoLength > 0)
                 {
                     for (int i = 0; i < 30; i++)
                     {

                         if (i < DtTwoLength)
                         {
                             SbTwoLevel.Append(_dtLJCTwoPlot.Rows[i]["ProcessedAt"].ToString() != null ? _dtLJCTwoPlot.Rows[i]["ProcessedAt"].ToString() + "," : ",");
                             SbTwoLevel.Append(_dtLJCTwoPlot.Rows[i]["QCRange"].ToString() != null ? _dtLJCTwoPlot.Rows[i]["QCRange"].ToString() + "," : ",");
                             SbTwoLevel.Append(_dtLJCTwoPlot.Rows[i]["QCStatus"].ToString() != null ? _dtLJCTwoPlot.Rows[i]["QCStatus"].ToString() + ";" : ";");
                         }
                     }

                     _strLJTwoChart = SbTwoLevel.ToString();
                 }

                 int DtThreeLength = _dtLJCThreePlot.Rows.Count;
                 if (DtThreeLength > 0)
                 {
                     for (int i = 0; i < 30; i++)
                     {

                         if (i < DtThreeLength)
                         {
                             SbThreeLevel.Append(_dtLJCThreePlot.Rows[i]["ProcessedAt"].ToString() != null ? _dtLJCThreePlot.Rows[i]["ProcessedAt"].ToString() + "," : "");
                             SbThreeLevel.Append(_dtLJCThreePlot.Rows[i]["QCRange"].ToString() != null ? _dtLJCThreePlot.Rows[i]["QCRange"].ToString() + "," : ",");
                             SbThreeLevel.Append(_dtLJCThreePlot.Rows[i]["QCStatus"].ToString() != null ? _dtLJCThreePlot.Rows[i]["QCStatus"].ToString() + ";" : ";");
                         }
                     }
                     _strLJThreeChart = SbThreeLevel.ToString();
                 }
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error In QMS Webservice  In The Methode LoadQCLJChartDetails_BL", ex);
             }
             return returncode;
         }


         public long QMS_UpdateLJchartValues_BL(List<LJChartValue> LJChartValue)
         {
             long returncode = -1;
             InternalQualityControl_DAL Obj_DAL = new InternalQualityControl_DAL(globalContextDetails);
             try
             {
                 returncode = Obj_DAL.QMS_UpdateLJchartValues_DAL(LJChartValue);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing in QMS_SaveAnalyzermappingDetails_BL", ex);
             }
             return returncode;
         }


    }
}
