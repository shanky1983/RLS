using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.BusinessEntities;

using Attune.Solution.DAL;
using System.Data;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities.CustomEntities;



namespace Attune.Solution.BusinessComponent
{
   public class Waters_BL
    {
        public Waters_BL()
        {

        }
        ContextDetails globalContextDetails;
        public Waters_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }


        public long SaveQuotationMasterDetails(string ClientID, string ClientName, string ClientSource,
            string SameBillingAddress, string SalesPerson, string Branch, string Remarks,
            string Sms, string Email, string IsFileUpload, int OrgID,
            DateTime Validity, string Address, string Suburb, string City, string State, string Country,
            string Pincode, string TempAddress, string TempSuburb, string TempCity, string TempState, string TempCountry, string TempPincode,DateTime ValidTo, string Mobile, string Phone,string Others ,string EmailID,out long QuotationID, out string QuotationNo)
        {


            long returncode = -1;
            QuotationID = 0;
            QuotationNo = String.Empty;

            try
            {


                Waters_DAL wdal = new Waters_DAL(globalContextDetails);
                returncode = wdal.SaveQuotationMasterDetails(ClientID, ClientName, ClientSource, SameBillingAddress, SalesPerson, Branch, Remarks, Sms, Email, IsFileUpload, OrgID, Validity, Address, Suburb, City, State, Country, Pincode, TempAddress, TempSuburb, TempCity, TempState, TempCountry, TempPincode, ValidTo, Mobile, Phone, Others, EmailID, out  QuotationID, out  QuotationNo);



            }
            catch (Exception ex)
            {
                CLogger.LogError("error occuring in waters_bl savequotationmasterdetails", ex);
            }


            return returncode;




        }

        public long SaveQuotationBill(long QuotationID, string IsFOC, string FOCRemark, string DiscountCode, decimal DiscountAmt, decimal DiscountPercent, string DiscountReason, string AuthorizeBy, string TaxName, decimal Gross, decimal TaxAmt, decimal RoundOff, decimal NetAmt, string Status, string IsPendingQuotation, string IsExpired)
        {


            long returncode = -1;
            
            

            try
            {

                Waters_DAL wdal = new Waters_DAL(globalContextDetails);
                returncode = wdal.SaveQuotationBill(QuotationID, IsFOC, FOCRemark, DiscountCode, DiscountAmt, DiscountPercent, DiscountReason, AuthorizeBy, TaxName, Gross, TaxAmt, RoundOff, NetAmt, Status, IsPendingQuotation, IsExpired);

            }
            catch (Exception ex)
            {
                CLogger.LogError("error occuring in waters_bl SaveQuotationBill", ex);
            }


            return returncode;




        }

        public long SavePreQuotationInvestigations(long QuotationID, List<PreQuotationInvestigationsCustom> Prelist)
        {
            long returncode = -1;



            try
            {

                Waters_DAL wdal = new Waters_DAL(globalContextDetails);
                returncode = wdal.SavePreQuotationInvestigations(QuotationID, Prelist);

            }
            catch (Exception ex)
            {
                CLogger.LogError("error occuring in waters_bl SavePreQuotationInvestigations", ex);
            }


            return returncode;
        
        
        }



        


       //Added By Dhanaselvam
        public long GetSampleSchedule(string Fromdate,string Todate,string QuotationNo,int ClientName,int TestName,string SampleType,int SamColPerson,string SampStatus,int OrgID, int currentPageNo, int PageSize, out int RowCount, out List<SampleSchedule> lstSampleSchedule)
        {
            long returnCode = -1;
             RowCount = 0;

         
            lstSampleSchedule = new List<SampleSchedule>();
            try
            {
                Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);
            returnCode = SampDAL.GetSampleSchedule(Fromdate, Todate, QuotationNo, ClientName, TestName, SampleType, SamColPerson, SampStatus, OrgID,currentPageNo,PageSize,out RowCount, out lstSampleSchedule);
            }
            catch (Exception ex)
            {
                CLogger.LogError("error occuring in Waters_BL GetSampleSchedule", ex);
            }
            return returnCode;
        }

        public long UpdateSampleSchedule(long RowID, string SampleID, string ScheduleTime, string TestingAddress, long CollectionPerson, String SampStatus)
        {
            long returnCode = -1;
            try
            {

                Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);
            returnCode = SampDAL.UpdateSampleSchedule(RowID, SampleID, ScheduleTime, TestingAddress, CollectionPerson, SampStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("error occuring in Waters_BL UpdateSampleSchedule", ex);
            }
            return returnCode;
        }


        public long GetSampleCollectors(string ClientCode ,int OrgId, out List<Users> lstSampleCollectors)
        {
            long returnCode = -1;
            lstSampleCollectors = new List<Users>();
            try
            {

                Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);
            returnCode = SampDAL.GetSampleCollectors(ClientCode,OrgId, out lstSampleCollectors);
            }
            catch (Exception ex)
            {
                CLogger.LogError("error occuring in Waters_BL GetSampleCollectors", ex);
            }
            return returnCode;
        }


       public long UpdateSampleSchedule_Bulk(List<SampleSchedule> lstSampleSchedule)
        {
            long returnCode = -1;
        try
        {

            Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);
            returnCode = SampDAL.UpdateSampleSchedule_Bulk(lstSampleSchedule);
        }
        catch (Exception ex)
        {
            CLogger.LogError("error occuring in Waters_BL UpdateSampleScedule_Bulk", ex);
        }
            return returnCode;
        }


       public long UpdateQuotationApproval_Bulk(List<SampleSchedule> lstSampleSchedule)
       {
           long returnCode = -1;
           try
           {

               Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);
           returnCode = SampDAL.UpdateQuotationApproval_Bulk(lstSampleSchedule);
           }
           catch (Exception ex)
           {
               CLogger.LogError("error occuring in Waters_BL UpdateQuotationApproval", ex);
           }
           return returnCode;
       }



       public long GetSampleCollectionHist(int RowID, out List<SampleSchedule> lstSampleCollectionHist)
       {
           long returnCode = -1;
           lstSampleCollectionHist = new List<SampleSchedule>();
           try
           {

               Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);
           returnCode = SampDAL.GetSampleCollectionHist(RowID, out lstSampleCollectionHist);
           }
           catch (Exception ex)
           {
               CLogger.LogError("error occuring in Waters_BL GetSampleCollectionHist", ex);
           }
           return returnCode;
       }

     


       public long GetQuotationForApproval(int OrgID, string Fromdate, string Todate, string QuotationNo, long ClientID, string SampleType, string SalesPerson,string Status ,out int NumberofRows ,out List<SampleSchedule> lstSampleForApprove)
       {
           long returnCode = -1;
           NumberofRows = 0;
           
           lstSampleForApprove = new List<SampleSchedule>();
               try
             {

                 Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);
                 returnCode = SampDAL.GetQuotationForApproval(OrgID, Fromdate, Todate, QuotationNo, ClientID, SampleType, SalesPerson, Status, out NumberofRows, out lstSampleForApprove);
             }
            catch (Exception ex)
            {
                CLogger.LogError("error occuring in Waters_BL GetQuotationForApproval", ex);
            }
           return returnCode;
       }


       public long pGetListForAutoComp(int pOrgId, string SearchText, string pCtrlName, out List<Patient> lstAutoComp)
       {
           long returnCode = -1;
           lstAutoComp = new List<Patient>();
           try
           {

               Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);
               returnCode = SampDAL.GetListForAutoComp(pOrgId,SearchText,pCtrlName, out lstAutoComp);
           }
           catch (Exception ex)
           {
               CLogger.LogError("error occuring in Waters_BL GetSampleCollectionHist", ex);
           }
           return returnCode;
       }
       
	   public long pGetSampIDCheck(string SearchSampID, out int isExist)
       {
           long returnCode = -1;
           isExist = 0;
           try
           {

               Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);
               returnCode = SampDAL.CheckSampleID(SearchSampID, out isExist);
           }
           catch (Exception ex)
           {
               CLogger.LogError("error occuring in Waters_BL pGetSampIDCheck", ex);
           }
           return returnCode;
       }
	   
	   public long GetVisitPageGeneration(int OrgID, DateTime fromdate, DateTime todate, long ClientID, long CollectedBy, string VisitNO, out List<VisitDetailsQuotation> LstVisitDetailsQuotation, out List<VisitSheetDetailsQuotation> lstVisitSheetDetailsQuotation, out List<VisitSheetDetailsQuotation> lstVisitSheetDetailsTestDetals)
       {
           long returnCode = -1;
           Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);
           LstVisitDetailsQuotation = new List<VisitDetailsQuotation>();
           returnCode = SampDAL.GetVisitPageGeneration(OrgID, fromdate, todate, ClientID, CollectedBy, VisitNO, out LstVisitDetailsQuotation, out lstVisitSheetDetailsQuotation, out lstVisitSheetDetailsTestDetals);
           return returnCode;

       }

       public long CreateVisitPageGeneration(List<VisitSheetDetailsQuotation> LstVisitSheetDetailsQuotation, out List<VisitDetailsQuotation> LstVisitDetailsQuotation, out List<VisitSheetDetailsQuotation> lstVisitSheetDetailsQuotation, out List<VisitSheetDetailsQuotation> lstVisitSheetTestDetails, out string GetVisitNumber)
       {
       long returnCode=-1;
        Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);

        returnCode = SampDAL.CreateVisitPageGeneration(LstVisitSheetDetailsQuotation, out LstVisitDetailsQuotation, out lstVisitSheetDetailsQuotation,out lstVisitSheetTestDetails, out GetVisitNumber);
        
           return returnCode;
       }

	   

       public long UpdatepkgSampleDetails(List<VisitSheetDetailsQuotation> LstQuotationSampleScheduling, long QuotationID, int OrgID)
       {
           long returnCode = -1;
           Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);

           returnCode = SampDAL.UpdatepkgSampleDetails(LstQuotationSampleScheduling,QuotationID,OrgID);

           return returnCode;
       }


       public long GetReporttrackingDetails(int OrgID, string QuotationNo,DateTime FromDate,DateTime ToDate,string SampleID,string VisitNumber,string ClientName ,int CurrentpageNo,int PageSize,out List<WatersQuotationMaster> lstDetails)
       {
           long returnCode = -1;
           Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);
           lstDetails = new List<WatersQuotationMaster>();


           try
           {
               returnCode = SampDAL.GetReporttrackingDetails(OrgID, QuotationNo, FromDate, ToDate, SampleID, VisitNumber, ClientName, CurrentpageNo, PageSize, out lstDetails);

           }

           catch (Exception ex)
           {
               CLogger.LogError("error occuring in Waters_BL UpdatepkgSampleDetails", ex);
           }

           return returnCode;
       }

       public long GetQuotationRegClientName(int OrgID, out List<ClientMaster> lstDetails)
       {
           long returnCode = -1;
           lstDetails = new List<ClientMaster>();
           Waters_DAL SampDAL = new Waters_DAL(globalContextDetails);

           returnCode = SampDAL.GetQuotationRegClientName(OrgID, out lstDetails);

           return returnCode;
       }
  public long DeleteQuotationRegistration(long VisitID)
       {


           long returncode = -1;



           try
           {

               Waters_DAL wdal = new Waters_DAL(globalContextDetails);
               returncode = wdal.DeleteQuotationRegistration(VisitID);
           }
           catch (Exception ex)
           {
               CLogger.LogError("error occuring in waters_bl SaveQuotationBill", ex);
           }


           return returncode;




       }
       
    }
}
