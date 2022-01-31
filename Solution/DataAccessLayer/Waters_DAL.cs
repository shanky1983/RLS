//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Attune.Podium.BusinessEntities;
//using System.Data.Common;
//using System.Data.SqlClient;
//using System.Data;
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;
using Attune.Podium.BusinessEntities.CustomEntities;



namespace Attune.Solution.DAL
{
    public class Waters_DAL
    {
        ContextDetails globalContextDetails;
        public Waters_DAL()
        {

        }

        public Waters_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }


        public long SaveQuotationMasterDetails(string ClientID, string ClientName, string ClientSource,
            string SameBillingAddress, string SalesPerson, string Branch, string Remarks,
            string Sms, string Email, string IsFileUpload, int OrgID,
            DateTime Validity, string Address, string Suburb, string City, string State, string Country,
            string Pincode, string TempAddress, string TempSuburb, string TempCity, string TempState, string TempCountry, string TempPincode, DateTime ValidTo, string Mobile, string Phone, string Others, string EmailID, out long QuotationID, out string QuotationNo)
        {

            long returnCode = -1;
            QuotationID = 0;
            QuotationNo = String.Empty;
            SqlCommand cmd = Command.pSaveQuotationMasterDetailsCommand(ClientID, ClientName, ClientSource, SameBillingAddress, SalesPerson, Branch, Remarks, Sms, Email, IsFileUpload, OrgID, Validity, Address, Suburb, City, State, Country, Pincode, TempAddress, TempSuburb, TempCity, TempState, TempCountry, TempPincode, ValidTo, Mobile, Phone, Others, EmailID, out QuotationID, out QuotationNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    QuotationID = Convert.ToInt64(cmd.Parameters["@pQuotationID"].Value);
                    QuotationNo = Convert.ToString(cmd.Parameters["@pQuotationNo"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveQuotationMasterDetails in Waters_DAL", ex);

            }
            return returnCode;

        }

        public long SaveQuotationBill(long QuotationID, string IsFOC, string FOCRemark, string DiscountCode, decimal DiscountAmt, decimal DiscountPercent, string DiscountReason, string AuthorizeBy, string TaxName, decimal Gross, decimal TaxAmt, decimal RoundOff, decimal NetAmt, string Status, string IsPendingQuotation, string IsExpired)
        {

            long returnCode = -1;

            SqlCommand cmd = Command.pSaveQuotationBillCommand(QuotationID, IsFOC, FOCRemark, DiscountCode, DiscountAmt, DiscountPercent, DiscountReason, AuthorizeBy, TaxName, Gross, TaxAmt, RoundOff, NetAmt, Status, IsPendingQuotation, IsExpired, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveQuotationMasterDetails in Waters_DAL", ex);

            }
            return returnCode;
        }


        public long SavePreQuotationInvestigations(long QuotationID, List<PreQuotationInvestigationsCustom> Prelist)
        {
            long returnCode = -1;
            DataTable PreQuotation = UDT_DAL.ConvertToPreQuotationInvestigations(Prelist);

            SqlCommand cmd = Command.pSavePreQuotationInvestigationsCommand(QuotationID, PreQuotation, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveQuotationMasterDetails in Waters_DAL", ex);

            }
            return returnCode;


        }


        // By Dhanaselvam


        public long GetSampleSchedule(string Fromdate, string Todate, string QuotationNo, int ClientName, int TestName, string SampleType, int SamColPerson, string SampStatus, int OrgID, int currentPageNo, int PageSize, out int RowID, out List<SampleSchedule> lstSampleSchedule)
        {
            long returnCode = -1;
            RowID = -1;

            SqlCommand cmd = new SqlCommand();


            cmd = Command.pGetSampleScheduleCommand(OrgID, Fromdate, Todate, QuotationNo, ClientName, TestName, SampleType, SamColPerson, SampStatus, currentPageNo, PageSize, out RowID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstSampleSchedule = new List<SampleSchedule>();
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);

                    RowID = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSampleSchedule);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSampleSchedule in Waters_DAL", ex);

            }
            return returnCode;
        }


        public long UpdateSampleSchedule(long RowID, string SampleID, string ScheduleTime, string TestingAddress, long CollectionPerson, string SampStatus)
        {


            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateSampleSchedulingCommand(1, RowID, SampleID, Convert.ToDateTime(ScheduleTime), TestingAddress, "Description", CollectionPerson, SampStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@ret", SqlDbType.Int);
            cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
            try
            {
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@ret"].Value);
            }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateSampleSchedule in Waters_DAL", ex);

            }
            return returnCode;
        }



        public long GetSampleCollectors(string ClientCode, int OrgID, out List<Users> lstSampleCollectors)
        {
            long returnCode = -1;

            SqlCommand cmd = new SqlCommand();


            cmd = Command.PgetSampleCollectionPersonCommand(ClientCode, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstSampleCollectors = new List<Users>();
            DataSet ds = new DataSet();
            try
            {
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSampleCollectors);
            }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSampleCollecors in Waters_DAL", ex);

            }
            return returnCode;
        }



        public long GetSampleCollectionHist(int RowID, out List<SampleSchedule> lstSampleCollectionHist)
        {
            long returnCode = -1;

            SqlCommand cmd = new SqlCommand();


            cmd = Command.pGetQuotationSampleHistCommand(RowID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstSampleCollectionHist = new List<SampleSchedule>();
            DataSet ds = new DataSet();
            try
            {
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSampleCollectionHist);
            }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSampleCollectionHist in Waters_DAL", ex);

            }
            return returnCode;
        }


        public long UpdateSampleSchedule_Bulk(List<SampleSchedule> lstSampleSchedule)
        {


            long returnCode = -1;
            DataTable dtSampleSchedule = UDT_DAL.ConvertToSampleSchedule_Sample(lstSampleSchedule);
            SqlCommand cmd = Command.pUpdateBulkSampleScheduleCommand(dtSampleSchedule, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {

            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);

            }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateSampleScheduling_Bulk in Waters_DAL", ex);

            }
            return returnCode;
        }


        public long UpdateQuotationApproval_Bulk(List<SampleSchedule> lstSampleSchedule)
        {


            long returnCode = -1;
            DataTable dtSampleSchedule = UDT_DAL.ConvertToSampleSchedule_Sample(lstSampleSchedule);
            SqlCommand cmd = Command.pSaveQuotationApprovalCommand(dtSampleSchedule, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);

            }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateQuatation_Bulk in Waters_DAL", ex);

            }
            return returnCode;
        }



        public long GetQuotationForApproval(int OrgID, string Fromdate, string Todate, string QuotationNo, long ClientID, string SampleType, string SalesPerson,string samplestatus,out int NumberofRows,out List<SampleSchedule> lstSampleForApprove)
        {
            long returnCode = -1;

            SqlCommand cmd = new SqlCommand();


            cmd = Command.pGetQuotationForApprovalCommand(OrgID, Fromdate, Todate, QuotationNo, ClientID, SampleType, SalesPerson, samplestatus,out NumberofRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstSampleForApprove = new List<SampleSchedule>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    NumberofRows = Convert.ToInt32(cmd.Parameters["@rowcount"].Value);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSampleForApprove);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQuotationForApproval in Waters_DAL", ex);

            }
            return returnCode;
        }



        public long GetListForAutoComp(int pOrgId, string SearchText, string pCtrlName, out List<Patient> lstAutoComp)
        {
            long returnCode = -1;

            SqlCommand cmd = new SqlCommand();


            cmd = Command.pGetListForAutoCompCommand(pOrgId, SearchText, pCtrlName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstAutoComp = new List<Patient>();
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAutoComp);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PgetListForAutoComp in Waters_DAL", ex);

            }
            return returnCode;
        }

public long CheckSampleID( string SampIDSearch, out int IsExists)
        {
            long returnCode = -1;

            SqlCommand cmd = new SqlCommand();

            IsExists = 0;
            cmd = Command.pGetWatersSampIDCheckCommand(SampIDSearch, out IsExists, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                  returnCode=  dbEngine.ExecuteDataSet(cmd, out ds);

                    IsExists = Convert.ToInt32(cmd.Parameters["@IsExist"].Value);
                }
                

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CheckSampleID in Waters_DAL", ex);

            }
            return returnCode;
        }
		
		 ////Added By Gowtham Raj --VisitPage Generation waters

        public long GetVisitPageGeneration(int OrgID, DateTime fromdate, DateTime todate, long ClientID, long CollectedBy, string VisitNo, out List<VisitDetailsQuotation> LstVisitDetailsQuotation, out List<VisitSheetDetailsQuotation> lstVisitSheetDetailsQuotation, out List<VisitSheetDetailsQuotation> lstVisitSheetDetailsTestDetals)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetVisitGenerationCommand(OrgID, fromdate, todate, ClientID, CollectedBy, VisitNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            LstVisitDetailsQuotation=new List<VisitDetailsQuotation>();
            lstVisitSheetDetailsQuotation = new List<VisitSheetDetailsQuotation>();
            lstVisitSheetDetailsTestDetals = new List<VisitSheetDetailsQuotation>();
          try 
	{	        
		  using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
              
                returnCode = Utilities.ConvertTo(ds.Tables[0], out LstVisitDetailsQuotation);
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstVisitSheetDetailsQuotation);
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstVisitSheetDetailsTestDetals);
            }
	}
	

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetVisitPageGeneration in Waters_DAL", ex);

            }
            return returnCode;
        }


        public long CreateVisitPageGeneration(List<VisitSheetDetailsQuotation> LstVisitSheetDetailsQuotation, out List<VisitDetailsQuotation> LstVisitDetailsQuotation, out List<VisitSheetDetailsQuotation> lstVisitSheetDetailsQuotation, out List<VisitSheetDetailsQuotation> lstVisitSheetTestDetails, out string GetVisitNumber)
        {
            long returnCode = -1;
           
            DataSet ds = new DataSet();
            DataTable dtLstVisitSheetDetails = UDT_DAL.ConvertToVisitGenerateListUpdate(LstVisitSheetDetailsQuotation);

            SqlCommand cmd = Command.PgetCreateVisitNumberCommand(dtLstVisitSheetDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out GetVisitNumber);
            LstVisitDetailsQuotation = new List<VisitDetailsQuotation>();
            lstVisitSheetDetailsQuotation = new List<VisitSheetDetailsQuotation>();
            lstVisitSheetTestDetails = new List<VisitSheetDetailsQuotation>();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    GetVisitNumber = cmd.Parameters["@GetVisitNumber"].Value.ToString();
                }
                if (ds.Tables.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[0], out LstVisitDetailsQuotation);
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstVisitSheetDetailsQuotation);
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstVisitSheetTestDetails);
                }
            
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing GetVisitPageGeneration in Waters_DAL", ex);
            }
            return returnCode;

        }



        public long UpdatepkgSampleDetails(List<VisitSheetDetailsQuotation> LstQuotationSampleScheduling, long QuotationID, int OrgID)
        {
            long returnCode = -1;

            IDataReader dataReader = null;
            DataTable dtLstPkgDetails = UDT_DAL.ConvertToVisitGenerateListUpdate(LstQuotationSampleScheduling);

            SqlCommand cmd = Command.pUpdatepkgSampleDetailsCommand(dtLstPkgDetails,QuotationID,OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
 
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing UpdatepkgSampleDetails in Waters_DAL", ex);
            }

            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;

        }


        public long GetReporttrackingDetails(int Orgid, string QuotationNo,DateTime FromDate,DateTime ToDate,string SampleID,string VisitNumber,string ClientName,int CurrentpageNo,int PageSize ,out List<WatersQuotationMaster> lstDetails)
        {
            long returnCode = -1;

            //lstDetails = List<WatersQuotationMaster>();

            DataSet ds = new DataSet();


            SqlCommand cmd = Command.pGetWatersReportTrackingCommand(Orgid, QuotationNo, FromDate, ToDate, SampleID, VisitNumber, ClientName, CurrentpageNo, PageSize, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
      lstDetails = new List<WatersQuotationMaster>();
            //DataSet ds = new DataSet();

      try
      {
          using (DBEngine dbEngine = new DBEngine())
          {
              dbEngine.ExecuteDataSet(cmd, out ds);
          }
          if (ds.Tables.Count > 0)
          {
              returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDetails);
          }
      }
      catch (Exception ex)
      {

          CLogger.LogError("Error while executing GetVisitPageGeneration in Waters_DAL", ex);
      }
            return returnCode;

        }


        public long GetQuotationRegClientName(int OrgID, out List<ClientMaster> lstDetails)
        {
            long returnCode = -1;

            //lstDetails = List<WatersQuotationMaster>();

            DataSet ds = new DataSet();


            SqlCommand cmd = Command.pGetQuotationRegClientNameCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstDetails = new List<ClientMaster>();
            //DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDetails);
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing GetVisitPageGeneration in Waters_DAL", ex);
            }
            return returnCode;

        }



 public long DeleteQuotationRegistration(long VisitID)
        {
            long returnCode = -1;

         
           

            SqlCommand cmd = Command.PDeleteWaterQuotationRegistrationCommand(VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                                                                      
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing UpdatepkgSampleDetails in Waters_DAL", ex);
            }

           
            return returnCode;

        }
        ///////////End
		
    }
}

