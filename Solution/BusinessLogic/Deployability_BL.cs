using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Solution.DAL;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using System.Data;
using Attune.Podium.PerformingNextAction;

namespace Attune.Solution.BusinessComponent
{
    public class Deployability_BL
    {
        ContextDetails globalContextDetails;
        public Deployability_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public Deployability_BL()
        {
        }
        public long SaveFeeTypes(int DefaultOrgid, string DestOrgid, string Reset, List<InvestigationDetail> lstInvestigationDetail)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).SaveFeeTypes(DefaultOrgid, DestOrgid, Reset, lstInvestigationDetail);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveFeeTypes in Deployability_BL", ex);
            }
            return returnCode;
        }

        public long GetCopyMasterDetails(int OrgId, String FeeType, out List<InvestigationMaster> lstInvestigationMaster)
        {
            long result = -1;

            lstInvestigationMaster = new List<InvestigationMaster>();

            try
            {
                Deployability_DAL objInvDal = new Deployability_DAL(globalContextDetails);
                result = objInvDal.GetCopyMasterDetails(OrgId, FeeType, out lstInvestigationMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetCopyMasterDetails in Deployability_BL", ex);
            }
            return result;

        }

        public long InsertDocData(List<FileUploadDetails> lstInvestigationDetail, DateTime UploadDate, String Reason)
        {
            long returncode = -1;
            try
            {
                returncode = new Deployability_DAL(globalContextDetails).InsertDocData(lstInvestigationDetail, UploadDate, Reason);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertDocData in Deployability_BL", ex);
            }
            return returncode;
        }

        public long GetUploadDocDetail(int FileDetails, out List<FileUploadDetails> lstUploadDocDetail)
        {
            long returncode = -1;
            lstUploadDocDetail = new List<FileUploadDetails>();
            try
            {
                returncode = new Deployability_DAL(globalContextDetails).GetUploadDocDetail(FileDetails, out lstUploadDocDetail);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetUploadDocDetail in Deployability_BL", ex);
            }
            return returncode;
        }

        public long InsertInvGrpPkgLog(int orgID, string testtype, string filename, int username, string status)
        {
            long returnCode = -1;
            try
            {
                Deployability_DAL Deployability_DAL = new Deployability_DAL(globalContextDetails);
                returnCode = Deployability_DAL.InsertInvGrpPkgLog(orgID, testtype, filename, username, status);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertInvGrpPkgLog in Deployability_BL", ex);
            }
            return returnCode;
        }

        public long GetInvGrpPkgError(out List<InvCreateUpdate> lsterrorinfo)
        {
            long returnCode = -1;
            lsterrorinfo = new List<InvCreateUpdate>();
            try
            {
                Deployability_DAL Deployability_DAL = new Deployability_DAL(globalContextDetails);
                returnCode = Deployability_DAL.GetInvGrpPkgError(out lsterrorinfo);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInvGrpPkgError in Deployability_BL", ex);
            }
            return returnCode;
        }


        public long GetRefillTestMasters(int orgID, string type, int createdby, int rateid, out List<Stage2_MHL_T_01_TESTMASTER> lstInvestigationMaster, out List<Stage2_MHL_T_02_GROUP_MASTER> lstIInvGroupMaster, out List<Stage2_MHL_T_03_Package_Master> InvGroupMasterpkg, out List<Stage2_MHL_T_04_GROUP_TESTS> lstGroupContent, out List<Stage2_MHL_T_05_PACKAGE_TESTS> lstPackageContent, out List<Stage2_MHL_T_02_RATE_MASTER> lstRateMaster, out List<DeviceTestOrgMapping> lstDeviceTestMap, out List<PStage_Physician> lstStage_Physician, out List<Stage_LocationMaster> lstStage_LocationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<Stage2_MHL_T_01_TESTMASTER>();
            lstIInvGroupMaster = new List<Stage2_MHL_T_02_GROUP_MASTER>();
            InvGroupMasterpkg = new List<Stage2_MHL_T_03_Package_Master>();

            lstPackageContent = new List<Stage2_MHL_T_05_PACKAGE_TESTS>();

            lstGroupContent = new List<Stage2_MHL_T_04_GROUP_TESTS>();
            lstRateMaster = new List<Stage2_MHL_T_02_RATE_MASTER>();
            lstStage_Physician = new List<PStage_Physician>();
            lstStage_LocationMaster = new List<Stage_LocationMaster>();
            lstDeviceTestMap = new List<DeviceTestOrgMapping>();
            try
            {

                returnCode = new Deployability_DAL(globalContextDetails).GetRefillTestMaster(orgID, type, createdby, rateid, out lstInvestigationMaster, out lstIInvGroupMaster, out InvGroupMasterpkg, out lstGroupContent, out lstPackageContent, out lstRateMaster, out lstDeviceTestMap, out lstStage_Physician, out lstStage_LocationMaster);
            }


            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetRefillTestMasters in Deployability_BL", ex);
            }
            return returnCode;

        }
        public long getTestInsertUpdate(int ORGID, List<Stage2_MHL_T_02_GROUP_MASTER> lstGroupMaster, List<Stage2_MHL_T_03_Package_Master> lstPackageMaster, List<Stage2_MHL_T_01_TESTMASTER> lstInvestigationMaster, List<Stage2_MHL_T_05_PACKAGE_TESTS> lstPackageContent, List<Stage2_MHL_T_04_GROUP_TESTS> lstGroupContent)
        {
            long retCode = -1;



            //DataTable invs = GetDataTableForWorkList(PatientInvestigation);
            try
            {


                retCode = new Deployability_DAL(globalContextDetails).getTestInsertUpdate(ORGID, lstGroupMaster, lstPackageMaster, lstInvestigationMaster, lstPackageContent, lstGroupContent);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing getTestInsertUpdate in Deployability_BL", e);
            }
            return retCode;

        }

        public long BulkInsertUpdateDeviceMapping(Int32 OrgID,List<DeviceTestOrgMapping> lstDeviceTestMap)
        {
            long retCode = -1;
            try
            {
                retCode = new Deployability_DAL(globalContextDetails).BulkInsertUpdateDeviceMapping(OrgID,lstDeviceTestMap);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing BulkInsertUpdateDeviceMapping in Deployability_BL", e);
            }
            return retCode;
        }

        public long BulkInsertUserMaster(List<Stage_User_Template> lstUsers, out int DuplicateCount, out int InsertedCount)
        {
            long retCode = -1;

            DuplicateCount = 0; InsertedCount = 0;

            //DataTable invs = GetDataTableForWorkList(PatientInvestigation);
            try
            {


                retCode = new Deployability_DAL(globalContextDetails).BulkInsertUserMaster(lstUsers, out DuplicateCount, out InsertedCount);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing getTestInsertUpdate in Deployability_BL", e);
            }
            return retCode;

        }
        public long BulkUpdateRatesDetails(Int32 OrgID, List<RateCardMaster> lstRateCardDetails, out List<RateCardMaster> lstinvClientMasterData)
        {
            long returnCode = -1;
            lstinvClientMasterData = new List<RateCardMaster>();
            try
            {
                Deployability_DAL Deployability_DAL = new Deployability_DAL(globalContextDetails);
                returnCode = Deployability_DAL.BulkUpdateRatesDetails(OrgID, lstRateCardDetails, out lstinvClientMasterData);
                if (lstinvClientMasterData.Count > 0)
                {

                    returnCode = 0;
                }
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing BulkUpdateRatesDetails in Deployability_BL", excp);
            }
            return returnCode;
        }
        public long GetInvGrpPkgLog(int orgID, string type, int createdby, out List<InvCreateUpdate> lstloginfo)
        {
            long returnCode = -1;
            lstloginfo = new List<InvCreateUpdate>();
            try
            {
                Deployability_DAL Deployability_DAL = new Deployability_DAL(globalContextDetails);
                returnCode = Deployability_DAL.GetInvGrpPkgLog(orgID, type, createdby, out lstloginfo);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInvGrpPkgError in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long GetAssociatedClientDetails(int OrgId, int ClientId, out List<ClientMaster> lstClientMaster)
        {
            long result = -1;
            lstClientMaster = new List<ClientMaster>();
            try
            {
                Deployability_DAL objInvDal = new Deployability_DAL(globalContextDetails);
                result = objInvDal.GetAssociatedClientDetails(OrgId, ClientId, out lstClientMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAssociatedClientDetails in Deployability_BL", ex);
            }
            return result;

        }
        public long GetOrderableLocation(int OrgId, out List<OrganizationAddress> lstLocationsMaster, out List<EmployeeMaster> lstEmployeeMaster)
        {
            long result = -1;
            lstLocationsMaster = new List<OrganizationAddress>();
            lstEmployeeMaster = new List<EmployeeMaster>();
            try
            {
                Deployability_DAL objInvDal = new Deployability_DAL(globalContextDetails);
                result = objInvDal.GetOrderableLocation(OrgId, out lstLocationsMaster, out lstEmployeeMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrderableLocation in Deployability_BL", ex);
            }
            return result;

        }
        public long GetAddressDetails(int OrgId, String PostalCode, out List<AddressDetails> lstAddressMaster)
        {
            long result = -1;
            lstAddressMaster = new List<AddressDetails>();
            try
            {
                Deployability_DAL objInvDal = new Deployability_DAL(globalContextDetails);
                result = objInvDal.GetAddressDetails(OrgId, PostalCode, out lstAddressMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAddressDetails in Deployability_BL", ex);
            }
            return result;

        }
        public long GetClientMasterDetails(int OrgId, int ClientId, String ClientCode, out List<ClientBasicGridDetails> lstClientMaster)
        {
            long result = -1;
            lstClientMaster = new List<ClientBasicGridDetails>();
            try
            {
                Deployability_DAL objInvDal = new Deployability_DAL(globalContextDetails);
                result = objInvDal.GetClientMasterDetails(OrgId, ClientId, ClientCode, out lstClientMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetClientMasterDetails in Deployability_BL", ex);
            }
            return result;

        }
        public long SaveLocationPrintMapDetails(long pOrgID, string pCodeStr, int pOrgAddressID, LocationPrintMap objLocationPrintMap)
        {
            long returnCode = -1;
            Deployability_DAL DALObj = new Deployability_DAL(globalContextDetails);
            try
            {

                returnCode = DALObj.SaveLocationPrintMapDetails(pOrgID, pCodeStr, pOrgAddressID, objLocationPrintMap);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveLocationPrintMapDetails in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long DeleteLocationPrintMapDetails(long pOrgID, int pOrgAddressID)
        {
            long returnCode = -1;
            Deployability_DAL DeployabilityDAL = new Deployability_DAL(globalContextDetails);
            try
            {

                returnCode = DeployabilityDAL.pDeleteLocationPrintMapDetails(pOrgID, pOrgAddressID);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing DeleteLocationPrintMapDetails in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long GetLocationPrinter(int OrgID, int OrgAddressID, string PrinterType, out List<LocationPrintMap> lstLocation)
        {
            lstLocation = new List<LocationPrintMap>();
            long returnCode = -1;
            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).GetLocationPrinter(OrgID, OrgAddressID,PrinterType, out lstLocation);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetLocationPrinter in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long GetClientTabMappingDetails(out List<TabMaster> lstTabDetails)
        {
            lstTabDetails = new List<TabMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).GetClientTabMappingDetails(out lstTabDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetClientTabMappingDetails in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long InsertInvoiceClientDetails(long ClientID,
                      string ClientCode,
                      string ClientName,
                      long ReportTemplateID,
                      string Attributes,
                      string Termsconditions,
                      string ReasonForUpdate,
                      DateTime ReportPrintFrom,
                      string TabDesiable,
                 List<ClientBasicDetails> lstClientBasicDetails,
                 List<AddressDetails> lstClientAddress,
                 List<ClientAttributesDetails> lstClientAttributes,
                 List<ClientCommunication> lstClientCommunication,
                 List<ClientCreditDetails> lstClientCreditDetails,
                 List<ClientDiscountPolicyMapping> lstClientDoscountPolicyMapping,
                 List<ClientTaxMaster> lstClientTaxMaster,
                 List<FileUploadDetails> lstUploadDocDetail, out long pClientID)
        {
            long returnCode = -1;
            pClientID = -1;
            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).InsertInvoiceClientDetails(ClientID, ClientCode, ClientName, ReportTemplateID, Attributes, Termsconditions, ReasonForUpdate, ReportPrintFrom, TabDesiable,
                        lstClientBasicDetails, lstClientAddress, lstClientAttributes, lstClientCommunication, lstClientCreditDetails, lstClientDoscountPolicyMapping, lstClientTaxMaster, lstUploadDocDetail, out pClientID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetLocationPrinter in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long GetInvoiceClientDetails(int pOrgID, int orgaddid, string cname, string code, long ClientID, out List<ClientMaster> lstborg)
        {

            lstborg = new List<ClientMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).GetInvoiceClientDetails(pOrgID, orgaddid, cname, code, ClientID, out lstborg);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetEpisodeDetails in ClinicalTrail_BL", ex);
            }
            return returnCode;
        }

        //Service Exclusivity Changes
        public long GetClientNamebyClientTypeExclusivity(int OrgID, string prefixtext, int ClientTypeID, int CustomerTypeID, out List<ClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            Deployability_DAL gInvClientType = new Deployability_DAL(globalContextDetails);
            returnCode = gInvClientType.GetClientNamebyClientTypeExclusivity(OrgID, prefixtext, ClientTypeID, CustomerTypeID, out lstInvClientMaster);
            return returnCode;
        }



        public long GetOrgInvestigationsGroupandPKGExclusivity(int Orgid, long ClientID, string prefixText, string ItemType, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                Deployability_DAL objDAL = new Deployability_DAL(globalContextDetails);
                returnCode = objDAL.GetOrgInvestigationsGroupandPKGExclusivity(Orgid, ClientID, prefixText, ItemType, out lstBillingFeeDetails);
            }

            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetOrgInvestigationsGroupandPKGExclusivity in Deployability_BL", ex);
            }

            return returnCode;

        }


        public long GetClientMappingServiceExclusivity(int OrgID, long ClientID, string refType, out List<ClientMappingService> lstClientMappingService)
        {
            lstClientMappingService = new List<ClientMappingService>();
            long returnCode = -1;
            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).GetClientMappingServiceExclusivity(OrgID, ClientID, refType, out lstClientMappingService);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetClientMappingServiceExclusivity in Deployability_BL", ex);
            }
            return returnCode;
        }


        public long SaveClientServiceExclusivity(string RateName, int OrgID, long CreatedBy, string MappingType, List<ClientServiceExclusivity> lstCSExclusivity, int ClientID)
        {
            long returnCode = -1;
            try
            {

                returnCode = new Deployability_DAL(globalContextDetails).SaveClientServiceExclusivity(RateName, OrgID, CreatedBy, MappingType, lstCSExclusivity, ClientID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveClientServiceExclusivity in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long GetOrgInvestigationsGroupandPKGs(int Orgid, int LocationID, string prefixText, string ItemType, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                Deployability_DAL objDAL = new Deployability_DAL(globalContextDetails);
                returnCode = objDAL.GetOrgInvestigationsGroupandPKGs(Orgid, LocationID, prefixText, ItemType, out lstBillingFeeDetails);
            }

            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetOrgInvestigationsGroupandPKGs in Deployability_BL", ex);
            }

            return returnCode;

        }
        public long SaveSpecialRateMasters(string RateName, int OrgID, long CreatedBy, string MappingType, List<RateMaster> lstRateMaster, int ClientID)
        {
            long returnCode = -1;
            try
            {

                returnCode = new Deployability_DAL(globalContextDetails).SaveSpecialRateMasters(RateName, OrgID, CreatedBy, MappingType, lstRateMaster, ClientID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveSpecialRateMasters in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long GetClientMappingService(int OrgID, long ClientID, string refType, out List<ClientMappingService> lstClientMappingService)
        {
            lstClientMappingService = new List<ClientMappingService>();
            long returnCode = -1;
            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).GetClientMappingService(OrgID, ClientID, refType, out lstClientMappingService);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetClientMappingServiceExclusivity in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long UpdateBulkReferenceRanges(List<InvOrgReferenceMapping> InvReferenceRange, List<BulkReferenceRange> InvReferenceRR)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).UpdateBulkReferenceRanges(InvReferenceRange, InvReferenceRR);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing UpdateBulkReferenceRanges in Deployability_BL", ex);
            }
            return returnCode;
        }

        public long GetBulkReferenceRanges(int OrgId, out List<BulkReferenceRange> lstInvestigationRR)
        {
            long result = -1;
            lstInvestigationRR = new List<BulkReferenceRange>();

            try
            {
                Deployability_DAL objInvDal = new Deployability_DAL(globalContextDetails);
                result = objInvDal.GetBulkReferenceRanges(OrgId, out lstInvestigationRR);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBulkReferenceRanges in Deployability_BL", ex);
            }
            return result;

        }
        public long BulkInsertLocationMaster(List<Stage_LocationMaster> lstLocationMaster, out int DuplicateCount, out int InsertedCount)
        {
            long retCode = -1;

            DuplicateCount = 0; InsertedCount = 0;
            //DataTable invs = GetDataTableForWorkList(PatientInvestigation);
            try
            {
                retCode = new Deployability_DAL(globalContextDetails).BulkInsertLocationMaster(lstLocationMaster, out DuplicateCount, out InsertedCount);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing BulkInsertLocationMaster in Deployability_BL", e);
            }
            return retCode;

        }




        public long BulkInsertPhysician(List<PStage_Physician> lstPhysician, out int DuplicateCount, out int InsertedCount)
        {
            long retCode = -1;

            DuplicateCount = 0; InsertedCount = 0;

            //DataTable invs = GetDataTableForWorkList(PatientInvestigation);
            try
            {


                retCode = new Deployability_DAL(globalContextDetails).BulkInsertPhysican(lstPhysician, out DuplicateCount, out InsertedCount);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing BulkInsertPhysician in Deployability_BL", e);
            }
            return retCode;

        }
        public long pLoadTemplate(out List<History> lstTemplate)
        {
            lstTemplate = new List<History>();
            long returnCode = -1;
            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).pLoadTemplate(out lstTemplate);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing pLoadTemplate in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long SaveInvMedicalDetailsMapping(long TestID, int TemplateID, string MedicalDetailType, string IsInternal, string IsMandatory, string InvType, long InvMedMappingID)
        {
            long returnCode = -1;
            Deployability_DAL DALObj = new Deployability_DAL(globalContextDetails);
            try
            {

                returnCode = DALObj.SaveInvMedicalDetailsMapping(TestID, TemplateID, MedicalDetailType, IsInternal, IsMandatory, InvType, InvMedMappingID);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveInvMedicalDetailsMapping in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long GETInvMedicalDetailsMapping(long TestID, string InvType, int OrgID, out List<InvMedicalDetailsMapping> lstDetails)
        {
            lstDetails = new List<InvMedicalDetailsMapping>();
            long returnCode = -1;
            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).GETInvMedicalDetailsMapping(TestID, InvType, OrgID, out lstDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GETInvMedicalDetailsMapping in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long RemoveInvMedicalDetailsMapping(long InvMedMappingID, long TestID, int TemplateID)
        {
            long returnCode = -1;
            Deployability_DAL DeployabilityDAL = new Deployability_DAL(globalContextDetails);
            try
            {

                returnCode = DeployabilityDAL.RemoveInvMedicalDetailsMapping(InvMedMappingID, TestID, TemplateID);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing RemoveInvMedicalDetailsMapping in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long AddInterdependency(int OrgID, long GroupID, long PrimaryInvID, long DependentInvID, string DependentType, long OldPrimaryInvID, long OldDependentInvID)
        {
            long returnCode = -1;
            Deployability_DAL DALObj = new Deployability_DAL(globalContextDetails);
            try
            {

                returnCode = DALObj.AddInterdependency(OrgID, GroupID, PrimaryInvID, DependentInvID, DependentType, OldPrimaryInvID, OldDependentInvID);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing AddInterdependency in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long RemoveInterdependencyDetails(int OrgId, long GroupID, long PrimaryInvID, long DependentInvID, string DependentType)
        {
            long returnCode = -1;
            Deployability_DAL DeployabilityDAL = new Deployability_DAL(globalContextDetails);
            try
            {

                returnCode = DeployabilityDAL.RemoveInterdependencyDetails(OrgId, GroupID, PrimaryInvID, DependentInvID, DependentType);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing RemoveInterdependencyDetails in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long GetInterdependencyDetails(int OrgID, long GroupID, out List<DependentInvestigation> lstDetails)
        {
            lstDetails = new List<DependentInvestigation>();
            long returnCode = -1;
            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).GetInterdependencyDetails(OrgID, GroupID, out lstDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInterdependencyDetails in Deployability_BL", ex);
            }
            return returnCode;
        }
        public long InsertLocationPrintMapDetails(int OrgID, int OrgAddressID, String PrinterName, bool IsColorPrinter, bool IsActive, long AutoPrinterID)
        {
            long returnCode = -1;
            Deployability_DAL DALObj = new Deployability_DAL(globalContextDetails);
            try
            {

                returnCode = DALObj.InsertLocationPrintMapDetails(OrgID, OrgAddressID, PrinterName, IsColorPrinter, IsActive, AutoPrinterID);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertLocationPrintMapDetails in Deployability_BL", ex);
            }
            return returnCode;
        }

        public long GetAllLocationPrinter(int OrgID, int OrgAddressID, out List<LocationPrintMap> lstLocation)
        {
            lstLocation = new List<LocationPrintMap>();
            long returnCode = -1;
            try
            {
                returnCode = new Deployability_DAL(globalContextDetails).GetAllLocationPrinter(OrgID, OrgAddressID, out lstLocation);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetAllLocationPrinter in Deployability_BL", ex);
            }
            return returnCode;
        }

        public long RemoveLocationPrintMapDetails(int pOrgID, int pOrgAddressID, string pPrinterName)
        {
            long returnCode = -1;
            Deployability_DAL DeployabilityDAL = new Deployability_DAL(globalContextDetails);
            try
            {

                returnCode = DeployabilityDAL.pRemoveLocationPrintMapDetails(pOrgID, pOrgAddressID, pPrinterName);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Invoice_BL DeleteLocationPrintMapDetails", ex);
            }
            return returnCode;
        }
        public long BulkUpdatebillSupplyNo(List<Stage_InvoiceBillSupplyNo_Template> lstInvoicebillSupplyNo, out int DuplicateCount, out int InsertedCount)
        {
            long retCode = -1;

            DuplicateCount = 0; InsertedCount = 0;

            //DataTable invs = GetDataTableForWorkList(PatientInvestigation);
            try
            {


                retCode = new Deployability_DAL(globalContextDetails).BulkUpdatebillSupplyNo(lstInvoicebillSupplyNo, out DuplicateCount, out InsertedCount);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing BulkUpdatebillSupplyNo in Deployability_BL", e);
            }
            return retCode;

        }
    }
}
