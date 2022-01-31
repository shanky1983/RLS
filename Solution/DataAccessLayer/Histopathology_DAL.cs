using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

namespace Attune.Solution.DAL
{
  public  class Histopathology_DAL
    {
      ContextDetails globalContextDetails;
      public Histopathology_DAL()
      {
      }
      public Histopathology_DAL(ContextDetails localContextDetails)
      {
          globalContextDetails = localContextDetails;
      }
      public long PgetHistoSampleSearch(string VisitNumber, string PatientNumber, string HistoNumber, string PatientName, long InvID, string SampleContainerID, int SampleCode, string BarcodeNumber, DateTime FromDate, DateTime ToDate,out DataTable dt)
      {
          long ReturnCode = -1;
          DataSet ds = new DataSet();
          dt = new DataTable();
          try
          {
              SqlCommand cmd = new SqlCommand();
              cmd = Command.PgetHistoSampleSearchCommand(VisitNumber, PatientNumber, HistoNumber, PatientName, InvID, SampleContainerID, SampleCode, BarcodeNumber, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
              using (DBEngine dbEngine = new DBEngine())
              {
                  dbEngine.ExecuteDataSet(cmd, out ds);
              }
              if (ds.Tables.Count>0)
              {
                  dt = ds.Tables[0];
              }
          }
          catch (Exception  ex)
          {
              CLogger.LogError("Error while executing PgetHistoSampleSearch Histopathology_DAL", ex);
            
          }
          return ReturnCode;
      }

      public long pSaveEnterTissueType(List<PatientInvSample> lstPatSamp)
      {
          long ReturnCode = -1;

          try
          {
              DataTable dtPatSamp=UDT_DAL.ConvertToIPInvSamples(lstPatSamp);
              SqlCommand cmd = Command.pSaveEnterTissueTypeCommand(dtPatSamp, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
              using (DBEngine dbengine = new DBEngine())
              {
                  ReturnCode = dbengine.ExecuteNonQuery(cmd);
              }
          }
          catch (Exception ex)
          {
               CLogger.LogError("Error while executing pSaveEnterTissueType Histopathology_DAL", ex);
              
          }

          return ReturnCode;
      }

      public long pGetINVandSampleandContainerDetails(string Name, string SampleName, string ContainerName,string DoctorName, out List<DropDownValueCode> lstdrp)
      {
          long ReturnCode = -1;
           lstdrp = new List<DropDownValueCode>();
          try
          {
              DataSet ds = new DataSet();
              SqlCommand cmd = new SqlCommand();
               cmd = Command.pGetINVandSampleandContainerDetailsCommand(Name, SampleName, ContainerName,DoctorName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

              using (DBEngine dbEngine = new DBEngine())
              {
                  dbEngine.ExecuteDataSet(cmd, out ds);
              }
              if (ds.Tables.Count > 0)
              {
                  ReturnCode = Utilities.ConvertTo(ds.Tables[0], out lstdrp);
              }
              
          }
          catch (Exception ex)
          {

              CLogger.LogError("Error while executing pGetINVandSampleandContainerDetails Histopathology_DAL", ex);
          }
          return ReturnCode;
      }

      public long GetHistopathSpecimenDetailsEntrySearch(PatientHistoStatusDetails lstPatHisto,string ActionType, out DataTable dt)
      {
          long ReturnCode = -1;

          DataSet ds = new DataSet();
          dt = new DataTable();
          try
          {
              SqlCommand cmd = new SqlCommand();
              cmd = Command.pGetHistopathSpecimenDetailsEntrySearchCommand(lstPatHisto.VisitNumber, lstPatHisto.HistopathNumber, lstPatHisto.PatientName, lstPatHisto.PatientNumber, lstPatHisto.InvID, lstPatHisto.SampleContainerID, lstPatHisto.SampleCode,
                  lstPatHisto.BarcodeNumber, lstPatHisto.TissueType, lstPatHisto.FromDate, lstPatHisto.ToDate, lstPatHisto.Status, lstPatHisto.BlockNo, lstPatHisto.BlockType, lstPatHisto.SlideNo, lstPatHisto.SlideType, lstPatHisto.StainType, ActionType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
              using (DBEngine dbEngine = new DBEngine())
              {
                  ReturnCode = dbEngine.ExecuteDataSet(cmd, out ds);
              }
              if (ds.Tables.Count > 0)
              {
                  dt = ds.Tables[0];
              }
          }
          catch (Exception ex)
          {

              CLogger.LogError("Error while executing GetHistopathSpecimenDetailsEntrySearch Histopathology_DAL", ex);
          }
          return ReturnCode;
      }

      public long GETDropDownHistoStatus(string ActionType, out List<DropDownValueCode> lstdrp)
      {
          long ReturnCode = -1;
          lstdrp = new List<DropDownValueCode>();
          DataSet ds = new DataSet();
          try
          {SqlCommand cmd = new SqlCommand();
           cmd =  Command.pGETDropDownHistoStatusCommand(ActionType);
           using (DBEngine dbEngine = new DBEngine())
           {
               dbEngine.ExecuteDataSet(cmd, out ds);
           }
           if (ds.Tables.Count > 0)
           {
               ReturnCode = Utilities.ConvertTo(ds.Tables[0], out lstdrp);
           }
          }
          catch (Exception ex)
          {
            CLogger.LogError("Error while executing GETDropDownHistoStatus Histopathology_DAL", ex);   
              
          }
          return ReturnCode;
      }

      public long SaveHistoSpecimenDetailsEntry(List<PatientHistoStatusDetails> _lstPatientHistoStatusDetails,String ActionTypes)
      {
          long ReturnCode = -1;
          try
          {
              SqlCommand cmd = new SqlCommand();
              cmd = Command.PsaveHistoSpecimenDetailsEntryCommand(UDT_DAL.ConvertHistoStatus(_lstPatientHistoStatusDetails), ActionTypes, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
              using (DBEngine dbengine = new DBEngine())
              {
                  ReturnCode = dbengine.ExecuteNonQuery(cmd);
              }
          }
          catch (Exception ex)
          {
              CLogger.LogError("Error while executing SaveHistoSpecimenDetailsEntry Histopathology_DAL", ex);   
              
          }
          return ReturnCode;
      }

      public long GetMISDoctorWiseReportHisto(System.DateTime FromDate, System.DateTime ToDate, string HistoNo, long ApprovedBy,out DataTable dt)
      {
          long ReturnCode = -1;
          DataSet ds = new DataSet();
          dt = new DataTable();
          try
          {
              SqlCommand cmd = new SqlCommand();
              cmd = Command.pGetMISDoctorWiseReportHistoCommand(FromDate, ToDate, HistoNo, ApprovedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
              using (DBEngine dbEngine = new DBEngine())
              {
                  ReturnCode = dbEngine.ExecuteDataSet(cmd, out ds);
              }
              if (ds.Tables.Count > 0)
              {
                  dt = ds.Tables[0];
              }
          }
          catch (Exception ex)
          {
              
              CLogger.LogError("Error while executing GetMISDoctorWiseReportHisto Histopathology_DAL", ex);  
          }
          return ReturnCode;
      }
  }
}
