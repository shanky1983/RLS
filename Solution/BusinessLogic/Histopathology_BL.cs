using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

namespace Attune.Solution.DAL
{
  public  class Histopathology_BL
    {
      ContextDetails globalContextDetails;
      public Histopathology_BL()
      {
      }
      public Histopathology_BL(ContextDetails localContextDetails)
      {
          globalContextDetails = localContextDetails;
      }
      public long PgetHistoSampleSearch(string VisitNumber, string PatientNumber, string HistoNumber, string PatientName, long InvID, string SampleContainerID, int SampleCode, string BarcodeNumber, DateTime FromDate, DateTime ToDate,out DataTable dt)
      {
          long ReturnCode = -1;
          Histopathology_DAL HisDAL = new Histopathology_DAL(globalContextDetails);
          dt = new DataTable();
          try
          {
              ReturnCode = HisDAL.PgetHistoSampleSearch(VisitNumber, PatientNumber, HistoNumber, PatientName, InvID, SampleContainerID, SampleCode, BarcodeNumber, FromDate, ToDate, out dt);
          
          }
          catch (Exception  ex)
          {
              CLogger.LogError("Error while executing PgetHistoSampleSearch Histopathology_BL", ex);
            
          }
          return ReturnCode;
      }

      public long pSaveEnterTissueType(List<PatientInvSample> lstPatSamp)
      {
          long ReturnCode = -1;
          Histopathology_DAL hDal = new Histopathology_DAL(globalContextDetails);
          try
          {
              ReturnCode = hDal.pSaveEnterTissueType(lstPatSamp);
          }
          catch (Exception ex)
          {
               CLogger.LogError("Error while executing pSaveEnterTissueType Histopathology_BL", ex);
              throw;
          }
          return ReturnCode;
      }

      public long SaveHistoSpecimenDetailsEntry(List<PatientHistoStatusDetails> _lstPatientHistoStatusDetails, String ActionTypes)
      {
          long ReturnCode = -1;
          Histopathology_DAL hDal = new Histopathology_DAL(globalContextDetails);
          try
          {
              ReturnCode = hDal.SaveHistoSpecimenDetailsEntry(_lstPatientHistoStatusDetails,ActionTypes);
          }
          catch (Exception ex)
          {
              CLogger.LogError("Error while executing SaveHistoSpecimenDetailsEntry Histopathology_BL", ex);

          }
          return ReturnCode;
      }

      public long pGetINVandSampleandContainerDetails(string Name, string SampleName, string ContainerName,String DoctorName ,out List<DropDownValueCode> lstdrp)
      {
          long ReturnCode = -1;
          Histopathology_DAL hDal = new Histopathology_DAL(globalContextDetails);
          lstdrp=new List<DropDownValueCode>();
          try
          {
            ReturnCode=  hDal.pGetINVandSampleandContainerDetails(Name, SampleName, ContainerName,DoctorName,out lstdrp);
          }
          catch (Exception ex)
          {

              CLogger.LogError("Error while executing pGetINVandSampleandContainerDetails Histopathology_BL", ex);
          }
          return ReturnCode;
      }

      public long GetHistopathSpecimenDetailsEntrySearch(PatientHistoStatusDetails lstPatHisto, string ActionType, out DataTable dt)
      {
          long ReturnCode = -1;
          dt = new DataTable();
          try
          {
              Histopathology_DAL hbl = new Histopathology_DAL(globalContextDetails);
              ReturnCode = hbl.GetHistopathSpecimenDetailsEntrySearch(lstPatHisto, ActionType, out dt);

          }
          catch (Exception ex)
          {
              
              CLogger.LogError("Error while executing GetHistopathSpecimenDetailsEntrySearch Histopathology_BL", ex);
          }
          return ReturnCode;
      }


      public long GETDropDownHistoStatus(string ActionType, out List<DropDownValueCode> lstdrp)
      {
          long ReturnCode = -1;
          lstdrp=new List<DropDownValueCode>();
          try
          {
              Histopathology_DAL HBL = new Histopathology_DAL();
           ReturnCode=   HBL.GETDropDownHistoStatus(ActionType, out lstdrp);
          }
          catch (Exception ex)
          {
              CLogger.LogError("Error while executing GETDropDownHistoStatus Histopathology_BL", ex);

          }
          return ReturnCode;
      }

      public long GetMISDoctorWiseReportHisto(System.DateTime FromDate, System.DateTime ToDate, string HistoNo, long ApprovedBy, out DataTable dt)
      {
          long ReturnCode = -1;
          dt = new DataTable();

          try
          {
              Histopathology_DAL hbl = new Histopathology_DAL(globalContextDetails);
              ReturnCode = hbl.GetMISDoctorWiseReportHisto(FromDate,ToDate,HistoNo,ApprovedBy, out dt);
          }
          catch (Exception ex)
          {
              
                CLogger.LogError("Error while executing GetMISDoctorWiseReportHisto Histopathology_BL", ex);
          }
          return ReturnCode;
      }
  }
}
