using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class Referrals_BL
    {
        ContextDetails globalContextDetails;
        public Referrals_BL()
        {

        }
        public Referrals_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetTestname(int OrgID, out List<InvestigationMaster> Testname)
        {
            Testname = new List<InvestigationMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetTestname(OrgID, out Testname);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetTestname in Referrals_BL", ex);
            }
            return returnCode;
        }
        public long SaveReferrals(List<Referral> lstReferrals, List<OrderedInvestigations> lstUpdatePatientInvStatusHL, long LID)
        {
            long returnCode = -1;
            Referrals_DAL ReferralsDAL = new Referrals_DAL(globalContextDetails);
            try
            {
                returnCode = ReferralsDAL.SaveReferrals(lstReferrals, lstUpdatePatientInvStatusHL, LID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveReferrals in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long UpdateReferrals(List<Referral> lstReferrals, long Lid, long referralID, string flag)
        {
            long returnCode = -1;
            Referrals_DAL ReferralsDAL = new Referrals_DAL(globalContextDetails);
            try
            {
                returnCode = ReferralsDAL.UpdateReferrals(lstReferrals, Lid, referralID, flag);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateReferrals in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetInBoundReferalDetails(long pOrgId, long pLocation, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            Referrals_DAL ReferralsDAL = new Referrals_DAL(globalContextDetails);
            try
            {
                returnCode = ReferralsDAL.GetInBoundReferalDetails(pOrgId, pLocation, out lstReferrals);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInBoundReferalDetails in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetOutBoundReferalsDetails(long pOrgId, long pLocation, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            Referrals_DAL ReferralsDAL = new Referrals_DAL(globalContextDetails);
            try
            {
                returnCode = ReferralsDAL.GetOutBoundReferalsDetails(pOrgId, pLocation, out lstReferrals);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOutBoundReferalsDetails in Referrals_BL", ex);
            }
            return returnCode;
        }




        public long GetALLLocation(int OrgID, out List<OrganizationAddress> lstLocation)
        {
            lstLocation = new List<OrganizationAddress>();
            long returnCode = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetALLLocation(OrgID, out lstLocation);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetALLLocation in Referrals_BL", ex);
            }
            return returnCode;
        }



        public long GetReferralStatus(int RoleID, string Type, out List<ReferralActionOption> lstReferralActionOption)
        {
            lstReferralActionOption = new List<ReferralActionOption>();
            long returnCode = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetReferralStatus(RoleID, Type, out lstReferralActionOption);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetReferralStatus in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long UpdateReferralStatus(long pReferralId, string Type, long pActionID, long Lid)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).UpdateReferralStatus(pReferralId, Type, pActionID, Lid);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing UpdateReferralStatus in Referrals_BL", ex);
            }

            return returnCode;
        }

        public long GetReferedInvestigation(long patientVisitID, out List<Patient> lstPatient,
                                           out List<OrderedInvestigations> lstInvestigation, out List<Physician> lstphysician)
        {
            lstPatient = new List<Patient>();
            lstInvestigation = new List<OrderedInvestigations>();
            lstphysician = new List<Physician>();
            long returnCode = -1;

            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetReferedInvestigation(patientVisitID, out lstPatient,
                                                   out lstInvestigation, out lstphysician);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get refered investigation sp", ex);
            }
            return returnCode;
        }

        public long SearchOutBoundReferals(long pOrgId, long pLocation, string ReferedDate, string PatientURN, string ReferedOrg, string ReferedLoc, string Status, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            Referrals_DAL ReferralsDAL = new Referrals_DAL(globalContextDetails);
            try
            {
                returnCode = ReferralsDAL.SearchOutBoundReferals(pOrgId, pLocation, ReferedDate, PatientURN, ReferedOrg, ReferedLoc, Status, out lstReferrals);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOutBoundReferalsDetails in Referrals_BL", ex);
            }
            return returnCode;

        }

        public long SearchInBoundReferals(long pOrgId, long pLocation, string ReferedDate, string PatientURN, string ReferedOrg, string ReferedLoc, string Status, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            Referrals_DAL ReferralsDAL = new Referrals_DAL(globalContextDetails);
            try
            {
                returnCode = ReferralsDAL.SearchInBoundReferals(pOrgId, pLocation, ReferedDate, PatientURN, ReferedOrg, ReferedLoc, Status, out lstReferrals);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchInBoundReferals in Referrals_BL", ex);
            }
            return returnCode;
        }


        public long GetReferralsINVDetails(long patientVisitID, long Rid, out List<Referral> lstInvestigationFeesDetails)
        {
            long returnCode = -1;
            lstInvestigationFeesDetails = new List<Referral>();
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetReferralsINVDetails(patientVisitID, Rid, out lstInvestigationFeesDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetReferralsINVDetails in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetOrgReferrals(int OrgID, int ILocationID, long Rid, out List<Referral> lstReferral)
        {
            long returnCode = -1;
            lstReferral = new List<Referral>();
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetOrgReferrals(OrgID, ILocationID, Rid, out lstReferral);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrgReferrals in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetOrgReferralsInvestigations(long ReferralID, int OrgID, int ILocationID, long patientVisitID, out List<BillingFeeDetails> lstInvestigationFeesDetails)
        {
            long returnCode = -1;
            lstInvestigationFeesDetails = new List<BillingFeeDetails>();
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetOrgReferralsInvestigations(ReferralID, OrgID, ILocationID, patientVisitID, out lstInvestigationFeesDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetOrgReferralsInvestigations in Referrals_BL", ex);
            }
            return returnCode;
        }





        public long UpdateReferralDetails(long Rid, long LID, long patientVisitID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).UpdateReferralDetails(Rid, LID, patientVisitID);
            }
            catch (Exception ex)
            {
                returnCode = 1000;
			CLogger.LogError("Error while executing UpdateReferralDetails in Referrals_BL", ex);
            }

            return returnCode;
        }

        public long CheckReferralsAvailable(long ReferedByVisitID, int ReferralVisitPurposeID, out int pCount, out long referralID)
        {
            long returnCode = -1;
            pCount = -1;
            referralID = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).CheckReferralsAvailable(ReferedByVisitID, ReferralVisitPurposeID, out pCount, out referralID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing CheckReferralsAvailable in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetReferralDetailstoEdit(long ReferedByVisitID, int ReferralVisitPurposeID, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetReferralDetailstoEdit(ReferedByVisitID, ReferralVisitPurposeID, out lstReferrals);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetReferralDetailstoEdit in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long CheckReferralsInvestigation(List<OrderedInvestigations> lstUpdatePatientInvStatusHL, out List<OrderedInvestigations> lstReferralsInvestigation)
        {
            long returnCode = -1;
            lstReferralsInvestigation = new List<OrderedInvestigations>();
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).CheckReferralsInvestigation(lstUpdatePatientInvStatusHL, out lstReferralsInvestigation);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing CheckReferralsInvestigation in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetTemplateNameBytemplateID(string TemplateType, int pOrgID, out List<InvResultTemplate> lstInvResultTemplate)
        {
            lstInvResultTemplate = new List<InvResultTemplate>();
            long returnCode = -1;
            try
            {

                returnCode = new Referrals_DAL(globalContextDetails).GetTemplateNameBytemplateID(TemplateType, pOrgID, out lstInvResultTemplate);

            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing UpdatePatientRecommendation in Patient_BL", e);
            }
            return returnCode;
        }

        public long GetInvResultTemplateByResultName(int OrgID, string ResultName, out List<InvResultTemplate> lstInvResultTemplate)
        {
            long result = -1;
            lstInvResultTemplate = new List<InvResultTemplate>();
            try
            {

                result = new Referrals_DAL(globalContextDetails).GetInvResultTemplateByResultName(OrgID, ResultName, out lstInvResultTemplate);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetInvestigationResultTemplate in Investigation_BL", e);
            }
            return result;
        }

        public long SaveReferralsAndMedicalCertificate(List<Referral> lstReferrals, long LID, out int IsExist)
        {
            long returnCode = -1;
            IsExist = -1;
            Referrals_DAL ReferralsDAL = new Referrals_DAL(globalContextDetails);
            try
            {
                returnCode = ReferralsDAL.SaveReferralsAndMedicalCertificate(lstReferrals, LID, out IsExist);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing DelResultTemplate in Investigation_BL", ex);
            }
            return returnCode;
        }

        public long CheckReferralsAndCertificate(long ReferedByVisitID, out int pCount)
        {
            long returnCode = -1;
            pCount = -1;

            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).CheckReferralsAndCertificate(ReferedByVisitID, out pCount);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing CheckReferralsAndCertificate in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetReferralTemplate(string ResultName, long VisitID, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetReferralTemplate(ResultName, VisitID, out lstReferrals);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetReferralDetailstoEdit in Referrals_BL", ex);
            }
            return returnCode;
        }

        //public long CheckReferralsAvailableByTemplate(long ReferedByVisitID, int ReferralVisitPurposeID, string TemplateName, out int pCount, out long referralID)
        //{
        //    long returnCode = -1;
        //    pCount = -1;
        //    referralID = -1;
        //    try
        //    {
        //        returnCode = new Referrals_DAL(globalContextDetails).CheckReferralsAvailableByTemplate(ReferedByVisitID, ReferralVisitPurposeID, TemplateName, out pCount, out referralID);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in CheckReferralsAvailable BL", ex);
        //    }
        //    return returnCode;
        //}


        public long SaveTrustedOrgReferrals(List<Referral> lstReferrals, long LID, out int IsExist)
        {
            long returnCode = -1;
            IsExist = -1;
            Referrals_DAL ReferralsDAL = new Referrals_DAL(globalContextDetails);
            try
            {
                returnCode = ReferralsDAL.SaveTrustedOrgReferrals(lstReferrals, LID, out IsExist);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveTrustedOrgReferrals in Referrals_BL", ex);
            }
            return returnCode;
        }


        public long GetReferralAndMedicalDetails(long ReferedByVisitID, int ReferralVisitPurposeID, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetReferralAndMedicalDetails(ReferedByVisitID, ReferralVisitPurposeID, out lstReferrals);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetReferralAndMedicalDetails in Referrals_BL", ex);
            }
            return returnCode;
        }


        public long GerReferralAndMedicalForEdit(long ReferedByVisitID, int ReferralVisitPurposeID, long ReferralID, out List<Referral> lstReferrals)
        {
            long returnCode = -1;
            lstReferrals = new List<Referral>();
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GerReferralAndMedicalForEdit(ReferedByVisitID, ReferralVisitPurposeID, ReferralID, out lstReferrals);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GerReferralAndMedicalForEdit in Referrals_BL", ex);
            }
            return returnCode;
        }


        public long UpdateReferralsAndMedicalCF(List<Referral> lstReferrals, long Lid, long referralID)
        {
            long returnCode = -1;
            Referrals_DAL ReferralsDAL = new Referrals_DAL(globalContextDetails);
            try
            {
                returnCode = ReferralsDAL.UpdateReferralsAndMedicalCF(lstReferrals, Lid, referralID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateReferralsAndMedicalCF in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetProcessingLocation(int OrgID, long LocationID, long InvestigationID, string pType, out List<InvestigationOrgMapping> lstInvestigationOrgMapping, out List<InvestigationOrgMapping> lstInvestigationLocationMapping)
        {
            lstInvestigationOrgMapping = new List<InvestigationOrgMapping>();
            lstInvestigationLocationMapping = new List<InvestigationOrgMapping>();
            long returnCode = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetProcessingLocation(OrgID, LocationID, InvestigationID, pType, out lstInvestigationOrgMapping, out lstInvestigationLocationMapping);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetALLLocation in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetCheckCode(string CodeType, string Code, int ExecuteType, out int Count, int OrgID, out List<DiscountPolicy> lstDiscountPolicy)
        {
            long returnCode = -1;
            Count = -1;
            lstDiscountPolicy = new List<DiscountPolicy>();
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetCheckCode(CodeType, Code, ExecuteType, out Count, OrgID, out lstDiscountPolicy);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetCheckCode in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetConsentFormTemplate(long @pOrgID, out List<ConsentTypeMaster> lstConsentTypeDetails)
        {
            long returnCode = -1;
            lstConsentTypeDetails = new List<ConsentTypeMaster>();
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetConsentFormTemplate(@pOrgID, out lstConsentTypeDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetConsentFormTemplate in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetConsentFormDeatils(long VisitID, int @pTemplateID, string @pTemplateType, long @pOrgID, out List<ConsentTemplateDetails> lstConsentFormDetails)
        {
            long returnCode = -1;
            lstConsentFormDetails = new List<ConsentTemplateDetails>();
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetConsentFormDeatils(0, @pTemplateID, @pTemplateType, @pOrgID, out lstConsentFormDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetConsentFormDeatils in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long SaveConsentletters(long VisitID, int TemplateID, string BeforeSign, string AfterSign)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).SaveConsentletters(VisitID, TemplateID, BeforeSign, AfterSign);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveConsentletters in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetConsentletters(long VisitID, long typeID, out List<ConsentLetters> lstLetters)
        {
            long returnCode = -1;
            lstLetters = new List<ConsentLetters>();

            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetConsentletters(VisitID, typeID, out  lstLetters);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetConsentletters in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetoneALLProcessingLocation(int OrgID, out List<OrganizationAddress> lstLocation)
        {
            lstLocation = new List<OrganizationAddress>();
            long returnCode = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetoneALLProcessingLocation(OrgID, out lstLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetALLLocation in Referrals_BL", ex);
            }
            return returnCode;
        }
        public long GetALLProcessingLocation(int OrgID, out List<OrganizationAddress> lstLocation)
        {
            lstLocation = new List<OrganizationAddress>();
            long returnCode = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetALLProcessingLocation(OrgID, out lstLocation);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetALLLocation in Referrals_BL", ex);
            }
            return returnCode;
        }
        public long GetRegisterLocation(int OrgID, out List<OrganizationAddress> lstLocation)
        {
            lstLocation = new List<OrganizationAddress>();
            long returnCode = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetRegisterLocation(OrgID, out lstLocation);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetRegisterLocation in Referrals_BL", ex);
            }
            return returnCode;
        }

        public long GetLocationPrinter(int OrgID, int OrgAddressID, string PrinterType, out List<LocationPrintMap> lstLocation)
        {
            lstLocation = new List<LocationPrintMap>();
            long returnCode = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetLocationPrinter(OrgID, OrgAddressID, PrinterType,out lstLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetALLLocation in Referrals_BL", ex);
            }
            return returnCode;
        }
        public long GetLocation_Printer(int OrgID, int OrgAddressID, string PrinterType, out List<LocationPrintMap> lstLocation)
        {
            lstLocation = new List<LocationPrintMap>();
            long returnCode = -1;
            try
            {
                returnCode = new Referrals_DAL(globalContextDetails).GetLocation_Printer(OrgID, OrgAddressID, PrinterType, out lstLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetALLLocation in Referrals_BL", ex);
            }
            return returnCode;
        }
    }
}
