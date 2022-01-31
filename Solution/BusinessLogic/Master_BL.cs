using System;
using System.Data;
using System.Configuration;
using System.Web;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.BusinessEntities.CustomEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using Attune.Podium.PerformingNextAction;
namespace Attune.Solution.BusinessComponent
{
    public class Master_BL : IDisposable
    {
        ContextDetails globalContextDetails;
        public Master_BL()
        {

        }
        public Master_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetCasuality(int pOrgID, out List<CasualtyCharges> lstCas)
        {
            long returnCode = -1;
            lstCas = new List<CasualtyCharges>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetCasuality(pOrgID, out lstCas);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetCasuality in Master_BL", ex);
           }
            return returnCode;
        }
		
		//added by sudha for locationPrint map page
        public long UpdateLocationPrintMapping(Int64 autoID, Int64 printerCode, string printerName, string Description, string Type, string Path, int isActive, int isColorPrinter, string Filecontent, string FileNameAndPath)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).UpdateLocationPrintMapping(autoID, printerCode, printerName, Description, Type, Path, isActive, isColorPrinter, Filecontent, FileNameAndPath);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateLocationPrintMapping in Master_BL", e);
            }
            return returnCode;
        }


        //added by sudha for loactionprint map

        public long DeleteLocationPrintMapping(Int32 autoID, string Status)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).DeleteLocationPrintMapping(autoID, Status);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateLocationPrintMapping in Master_BL", e);
            }
            return returnCode;
        }
		
		
		
        public long GetViewTestDetails(long ClientId, long OrgId, out List<ClientDetails> lstClientDetails, out List<ClientDetails> lstClientDetails1)
        {
            long returnCode = -1;
            lstClientDetails = new List<ClientDetails>();
            lstClientDetails1 = new List<ClientDetails>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetViewTestDetails(ClientId, OrgId, out lstClientDetails, out lstClientDetails1);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetViewTestDetails in Master_BL", ex);
            }
            return returnCode;
        }


        public long InsertCasuality(int pOrgID, CasualtyCharges pCas)
        {
            long returncode = -1;
            try
            {
                returncode = new Master_DAL(globalContextDetails).InsertCasuality(pOrgID, pCas);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertCasuality in Master_BL", ex);
            }
            return returncode;
        }

        public long GetTaskActions(out List<TaskActions> lstTaskActions)
        {
            long returnCode = -1;
            lstTaskActions = new List<TaskActions>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetTaskActions(out lstTaskActions);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetTaskActions in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetMappedTaskActions(long orgID, long roleID, out List<TaskActions> lstTaskActions)
        {
            long returnCode = -1;
            lstTaskActions = new List<TaskActions>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetMappedTaskActions(orgID, roleID, out lstTaskActions);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetMappedTaskActions in Master_BL", ex);
            }
            return returnCode;
        }

        public long SaveAndDeleteTaskActions(string Stype, List<TaskActionOrgMapping> lstTaskActionOrgMapping)
        {
            long returnCode = -1;
            Master_DAL masterDAL = new Master_DAL(globalContextDetails);
            // DataTable DtTaskActionOrgMapping = (lstTaskActionOrgMapping);
            try
            {
                returnCode = masterDAL.SaveAndDeleteTaskActions(Stype, lstTaskActionOrgMapping);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveAndDeleteTaskActions in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetGeneralBillingItemsRateDetails(int pOrgID, out List<GeneralBillingItems> GBI)
        {
            long returnCode = -1;
            GBI = new List<GeneralBillingItems>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetGeneralBillingItemsRateDetails(pOrgID, out GBI);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetGeneralBillingItemsRateDetails in Master_BL", ex);
            }
            return returnCode;
        }

        public long pGetRateName(int OrgID, out List<RateMaster> lstRateMaster)
        {
            long returnCode = -1;
            Master_DAL MasterDAL = new Master_DAL(globalContextDetails);
            lstRateMaster = new List<RateMaster>();
            try
            {
                returnCode = MasterDAL.pGetRateName(OrgID, out lstRateMaster);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing pGetRateName in Master_BL", excp);
            }
            return returnCode;
        }


        public long InsertGeneralBillingMaster(GeneralBillingMaster pGBM)
        {
            long returncode = -1;
            try
            {
                returncode = new Master_DAL(globalContextDetails).InsertGeneralBillingMaster(pGBM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertGeneralBillingMaster in Master_BL", ex);
            }
            return returncode;

        }

        public long InsertBannerMaster(Banners ObjBanners, string Stype, BannerRoleMapping ObjBannerRoleMapping,
            List<BannerRoleMapping> lstBannerRoleMapping)
        {
            long returnCode = -1;
            Master_DAL masterDAL = new Master_DAL(globalContextDetails);

            try
            {
                returnCode = masterDAL.InsertBannerMaster(ObjBanners, Stype, ObjBannerRoleMapping, lstBannerRoleMapping);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertBannerMaster in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetBannerDetails(int OrgID, int BannerID, out List<Banners> lstBanners, out List<BannerRoleMapping> lstBannerRoleMapping)
        {
            long returnCode = -1;
            Master_DAL masterDAL = new Master_DAL(globalContextDetails);
            lstBanners = new List<Banners>();
            lstBannerRoleMapping = new List<BannerRoleMapping>();
            try
            {
                returnCode = masterDAL.GetBannerDetails(OrgID, BannerID, out lstBanners, out lstBannerRoleMapping);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetBannerDetails in Master_BL", ex);
            }
            return returnCode;
        }




        public long GetCurrencyForOrg(int OrgID, out int BaseCurrency, out string BaseCurrencyCode, out List<CurrencyMaster> lstCurrencyMaster)
        {
            long returnCode = -1;
            BaseCurrency = -1;
            BaseCurrencyCode = string.Empty;
            lstCurrencyMaster = new List<CurrencyMaster>();
            try
            {

                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.GetCurrencyForOrg(OrgID, out BaseCurrency, out BaseCurrencyCode, out lstCurrencyMaster);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetCurrencyForOrg in Master_BL", e);
            }
            return returnCode;
        }
        public long GetCurrencyForOrgMapping(int OrgID, out List<CurrencyMaster> lstCurrencyMaster)
        {
            long returnCode = -1;
            lstCurrencyMaster = new List<CurrencyMaster>();
            try
            {

                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.GetCurrencyForOrgMapping(OrgID, out lstCurrencyMaster);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetCurrencyForOrgMapping in Master_BL", e);
            }
            return returnCode;
        }
        public long SaveBaseCurrency(int OrgID, int BaseCurrency)
        {
            long returnCode = -1;
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.SaveBaseCurrency(OrgID, BaseCurrency);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing SaveBaseCurrency in Master_BL", excep);
            }
            return returnCode;
        }
        public long SaveOtherCurrency(List<CurrencyOrgMapping> lstCurrOrgMapp)
        {
            long returnCode = -1;
            Master_DAL invDAL = new Master_DAL(globalContextDetails);

            try
            {
                returnCode = invDAL.SaveOtherCurrency(lstCurrOrgMapp);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing SaveOtherCurrency in Master_BL", excp);
            }
            return returnCode;
        }


        public long GetCurrencyForRateConversion(int OrgID, string pType, out List<CurrencyOrgMapping> lstCurrOrgMapp)
        {
            long returnCode = -1;
            lstCurrOrgMapp = new List<CurrencyOrgMapping>();
            try
            {

                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.GetCurrencyForRateConversion(OrgID, pType, out lstCurrOrgMapp);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetCurrencyForRateConversion in Master_BL", e);
            }
            return returnCode;
        }
        public long GetCurrencyOrgMapping(int OrgID, out List<CurrencyOrgMapping> lstCurrOrgMap)
        {
            long returnCode = -1;
            lstCurrOrgMap = new List<CurrencyOrgMapping>();
            try
            {
                Master_DAL masDal = new Master_DAL(globalContextDetails);
                returnCode = masDal.GetCurrencyOrgMapping(OrgID, out lstCurrOrgMap);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetCurrencyOrgMapping in Master_BL", ex);
            }
            return returnCode;
        }
        public long UpdateOtherCurrency(List<CurrencyOrgMapping> lstCurrOrgMapp)
        {
            long returnCode = -1;
            Master_DAL invDAL = new Master_DAL(globalContextDetails);
            //DataTable DtCurrOrgMappDataList = GetCurrOrgMappDataTable(lstCurrOrgMapp);
            try
            {
                returnCode = invDAL.UpdateOtherCurrency(lstCurrOrgMapp);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing UpdateOtherCurrency in Master_BL", excp);
            }
            return returnCode;
        }

        public long GetOrgMappedCurrencies(int OrgID, out List<CurrencyOrgMapping> lstCurrOrgMapp)
        {
            long returnCode = -1;
            lstCurrOrgMapp = new List<CurrencyOrgMapping>();
            try
            {

                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.GetOrgMappedCurrencies(OrgID, out lstCurrOrgMapp);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetOrgMappedCurrencies in Master_BL", e);
            }
            return returnCode;
        }
        public long GetIncomeSourceMaster(int OrgID, out List<IncomeSourceMaster> lstIncomeSource)
        {
            long returnCode = -1;
            lstIncomeSource = new List<IncomeSourceMaster>();
            DataSet ds = new DataSet();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetIncomeSourceMaster(OrgID, out lstIncomeSource);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing GetIncomeSourceMaster in Master_BL", excep);
            }
            return returnCode;
        }
        public long GetGeneralBillingMaster(int pOrgID, out List<GeneralBillingMaster> GBI)
        {
            long returnCode = -1;
            GBI = new List<GeneralBillingMaster>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetGeneralBillingMaster(pOrgID, out GBI);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetGeneralBillingMaster in Master_BL", ex);
            }
            return returnCode;
        }

        public long InsertDiscountMaster(int pOrgID, DiscountMaster pCas)
        {
            long returncode = -1;
            try
            {
                returncode = new Master_DAL(globalContextDetails).InsertDiscountMaster(pOrgID, pCas);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertDiscountMaster in Master_BL", ex);
            }
            return returncode;
        }

        public long InsertEmployeeMaster(int OrgID, string TypeName, EmployeeMaster ObjEmployeeMaster, long LID)
        {
            long returncode = -1;
            try
            {
                returncode = new Master_DAL(globalContextDetails).InsertEmployeeMaster(OrgID, TypeName, ObjEmployeeMaster, LID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertEmployeeMaster in Master_BL", ex);
            }
            return returncode;
        }

        public long GetDiscountMaster(int pOrgID, out List<DiscountMaster> lstCas)
        {
            long returnCode = -1;
            lstCas = new List<DiscountMaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetDiscountMaster(pOrgID, out lstCas);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDiscountMaster in Master_BL", ex);
            }
            return returnCode;
        }

        public long DeleteDiscountMaster(int pOrgID, int pDiscountID)
        {
            long returnCode = -1;
            //lstCas = new List<DiscountMaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).DeleteDiscountMaster(pOrgID, pDiscountID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing DeleteDiscountMaster in Master_BL", ex);
            }
            return returnCode;
        }

        public long InsertTaxMaster(int pOrgID, Taxmaster ptax)
        {
            long returncode = -1;
            try
            {
                returncode = new Master_DAL(globalContextDetails).InsertTaxMaster(pOrgID, ptax);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertTaxMaster in Master_BL", ex);
            }
            return returncode;
        }

        public long GetTaxMaster(int pOrgID, out List<Taxmaster> lstTax)
        {
            long returnCode = -1;
            lstTax = new List<Taxmaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetTaxMaster(pOrgID, out lstTax);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetTaxMaster in Master_BL", ex);
            }
            return returnCode;
        }

        public long DeleteTaxMaster(int pOrgID, int pTaxID)
        {
            long returnCode = -1;
            //lstCas = new List<DiscountMaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).DeleteTaxMaster(pOrgID, pTaxID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing DeleteTaxMaster in Master_BL", ex);
            }
            return returnCode;
        }

        //Added by Perumal

        public long GetclientTpaRoomFeeTypes(long OrgID, out List<FeeTypeMaster> lstFeeDesc, out List<FeeTypeMaster> lstFeeType, out List<RoomType> lstRoomType, out List<InvClientMaster> lstInvClientMaster, out List<TPAMaster> lstTPAMaster)
        {
            long returnCode = -1;
            lstFeeDesc = new List<FeeTypeMaster>();
            lstFeeType = new List<FeeTypeMaster>();
            lstRoomType = new List<RoomType>();
            lstInvClientMaster = new List<InvClientMaster>();
            lstTPAMaster = new List<TPAMaster>();
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.GetclientTpaRoomFeeTypes(OrgID, out lstFeeDesc, out lstFeeType, out lstRoomType, out lstInvClientMaster, out lstTPAMaster);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetclientTpaRoomFeeTypes in Master_BL", e);
            }
            return returnCode;
        }

        public long GetClientFeeTypeRateDetails(long ClientID, int RoomTypeID, int OrgId, out List<ClientFeeTypeRateCustomization> lstClientFeeTypeRateDetails)
        {
            long returnCode = -1;
            lstClientFeeTypeRateDetails = new List<ClientFeeTypeRateCustomization>();
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.GetClientFeeTypeRateDetails(ClientID, RoomTypeID, OrgId, out lstClientFeeTypeRateDetails);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetClientFeeTypeRateDetails in Master_BL", e);
            }
            return returnCode;
        }

        public long GetClientFeeTypeRateGroup(int OrgId, out List<ClientFeeTypeRateCustomization> lstClientFeeTypeRateGroup)
        {
            long returnCode = -1;
            lstClientFeeTypeRateGroup = new List<ClientFeeTypeRateCustomization>();
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.GetClientFeeTypeRateGroup(OrgId, out lstClientFeeTypeRateGroup);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetClientFeeTypeRateGroup in Master_BL", e);
            }
            return returnCode;
        }

        public long GetProcedreMaster(int OrgID, long procID, out List<ProcedureMasterMain> lstProcedureMasterMain, out List<ProcedureMasterSub> lstProcedureMasterSub)
        {
            long returnCode = -1;
            lstProcedureMasterMain = new List<ProcedureMasterMain>();
            lstProcedureMasterSub = new List<ProcedureMasterSub>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetProcedreMaster(OrgID, procID, out lstProcedureMasterMain, out lstProcedureMasterSub);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetProcedreMaster in Master_BL", ex);
            }
            return returnCode;
        }

        public long SaveProcDescription(string sType, ProcedureMasterSub objProcedureMasterSub, long LID)
        {
            long returnCode = -1;
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.SaveProcDescription(sType, objProcedureMasterSub, LID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveProcDescription in Master_BL", ex);
            }
            return returnCode;
        }

        public long SaveProcedureMain(ProcedureMasterMain objProcedureMasterMain)
        {
            long returnCode = -1;
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.SaveProcedureMain(objProcedureMasterMain);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveProcedureMain in Master_BL", ex);
            }
            return returnCode;
        }

        public long DeleteClientFeeTypeRate(long lngClientId, int intRoomtypeId)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).DeleteClientFeeTypeRate(lngClientId, intRoomtypeId);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing DeleteClientFeeTypeRate in Master_BL", ex);
            }
            return returnCode;
        }

        //---------------------------------------------
        public long GetEmployeeMasters(int OrgID,
                                         out List<DesignationMaster> lstDesignationMaster,
                                         out List<RelationshipMaster> lstRealtionshipMaster,
                                         out List<EmploymentType> lstEmploymentType,
                                         out List<EmployerDeptMaster> lstEmployerDeptMaster,
                                         out List<PatientTypeMaster> lstPatientTypeMaster,
                                         out List<GradeMaster> lstGradMaster,
                                         out List<EmployerMaster> lstEmployerMaster,
                                         out List<EmployerLocationMaster> lstEmployerLocationMaster,
                                         out long EmpID,
                                         out long ExterID
                                         )
        {
            long returnCode = -1;
            EmpID = 0;
            ExterID = 0;
            lstDesignationMaster = new List<DesignationMaster>();
            lstRealtionshipMaster = new List<RelationshipMaster>();
            lstEmploymentType = new List<EmploymentType>();
            lstEmployerDeptMaster = new List<EmployerDeptMaster>();
            lstPatientTypeMaster = new List<PatientTypeMaster>();
            lstGradMaster = new List<GradeMaster>();
            lstEmployerMaster = new List<EmployerMaster>();
            lstEmployerLocationMaster = new List<EmployerLocationMaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetEmployeeMasters(
                                                OrgID,
                                                out lstDesignationMaster,
                                                out lstRealtionshipMaster,
                                                out lstEmploymentType,
                                                out lstEmployerDeptMaster,
                                                out lstPatientTypeMaster,
                                                out lstGradMaster,
                                                out lstEmployerMaster,
                                                out lstEmployerLocationMaster,
                                                out EmpID,
                                                out ExterID
                                                );
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetEmployeeMasters in Master_BL", ex);
            }
            return returnCode;
        }
        //----------------------------------------------------------------------
        public long SaveSurgeryMasterItems(IPTreatmentPlan objTreatmentPlan)
        {
            long returnCode = -1;
            try
            {
                Master_DAL MasterDAL = new Master_DAL(globalContextDetails);
                returnCode = MasterDAL.SaveSurgeryMasterItems(objTreatmentPlan);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveSurgeryMasterItems in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetSurgeryMasterItems(int OrgId, out List<IPTreatmentPlan> lstTreatmentPlan)
        {
            long returnCode = -1;
            lstTreatmentPlan = new List<IPTreatmentPlan>();
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.GetSurgeryMasterItems(OrgId, out lstTreatmentPlan);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetSurgeryMasterItems in Master_BL", e);
            }
            return returnCode;
        }
        public long GetTreatmentPlan(int OrgId, out List<IPTreatmentPlan> lstGetTreatmentPlan)
        {
            long returnCode = -1;
            lstGetTreatmentPlan = new List<IPTreatmentPlan>();
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.GetTreatmentPlan(OrgId, out lstGetTreatmentPlan);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetTreatmentPlan in Master_BL", e);
            }
            return returnCode;
        }
        //----------------------------------------------------------------------
        //For Discount Reason ------------------------------------------------------
        public long InsertReasonMaster(int pOrgID, DiscountReasonMaster DisReason)
        {
            long returncode = -1;
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returncode = masterDAL.InsertDiscountReasonMaster(pOrgID, DisReason);


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertReasonMaster in Master_BL", ex);
            }
            return returncode;
        }

        public long GetReasonMaster(int OrgID, out List<DiscountReasonMaster> lstDiscountreason)
        {

            lstDiscountreason = new List<DiscountReasonMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetReasonMaster(OrgID, out lstDiscountreason);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetReasonMaster in Master_BL", ex);
            }
            return returnCode;
        }

        public long DeleteDiscountReasonMaster(int pOrgID, int pReasonID)
        {
            long returnCode = -1;
            //lstCas = new List<DiscountMaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).DeleteDiscountReasonMaster(pOrgID, pReasonID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteDiscountReasonMaster in Master_BL", ex);
            }
            return returnCode;
        }

        //END----------------
        public long GetCategoriesAndPatterns(int OrgID, out List<MasterCategories> lstCategories, out List<MasterPatterns> lstPatterns, out List<MasterCategories> lstCategoryNPattern)
        {
            long returnCode = -1;
            lstCategories = new List<MasterCategories>();
            lstPatterns = new List<MasterPatterns>();
            lstCategoryNPattern = new List<MasterCategories>();
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.GetCategoriesAndPatterns(OrgID, out lstCategories, out lstPatterns, out lstCategoryNPattern);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing GetCategoriesAndPatterns in Master_BL", e);
            }
            return returnCode;
        }
        public long CheckAndAssignPattern(int OrgID, long pOrgAddressID, List<MasterCategories> lstMC)
        {
            long returnCode = -1;
            //DataTable DTvalues = GetDataValues(lstMC);
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.CheckAndAssignPattern(OrgID, pOrgAddressID, lstMC);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing CheckAndAssignPattern in Master_BL", e);
            }
            return returnCode;
        }

        public long BarcodeCheckAndInsertPattern(int OrgID, List<BarcodeOrgMapping> lstMC)
        {
            long returnCode = -1;
            // DataTable DTvalues = GetbarcodeValues(lstMC);
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.BarcodeCheckAndAssignPattern(OrgID, lstMC);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing BarcodeCheckAndInsertPattern in Master_BL", e);
            }
            return returnCode;
        }




        public long BarcodeCategory(out List<BarcodeCategories> lstBarcodeCategories)
        {
            long returnCode = -1;
            lstBarcodeCategories = new List<BarcodeCategories>();
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.BarcodeCategoryName(out lstBarcodeCategories);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing BarcodeCategory in Master_BL", e);
            }
            return returnCode;
        }

        public long BarcodeMainAttributes(out List<BarcodeMainAttributes> lstBarcodeMainAttributes)
        {
            long returnCode = -1;
            lstBarcodeMainAttributes = new List<BarcodeMainAttributes>();
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.BarcodeMainAttributesName(out lstBarcodeMainAttributes);
            }
            catch (Exception e)
            {
			CLogger.LogError("Error while executing BarcodeMainAttributes in Master_BL", e);
            }
            return returnCode;
        }

        public long BarcodePlaceHolders(out List<BarcodePlaceHolders> lstBarcodePlaceHolders)
        {
            long returnCode = -1;
            lstBarcodePlaceHolders = new List<BarcodePlaceHolders>();
            try
            {
                Master_DAL masterDAL = new Master_DAL(globalContextDetails);
                returnCode = masterDAL.BarcodePlaceHoldersName(out lstBarcodePlaceHolders);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing BarcodePlaceHolders in Master_BL", e);
            }
            return returnCode;
        }


        public long GetBarcodeOrgMap(int pOrgID, out List<BarcodeOrgMapping> lstborg)
        {

            lstborg = new List<BarcodeOrgMapping>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetBarcodeOrgMapping(pOrgID, out lstborg);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBarcodeOrgMap in Master_BL", ex);
            }
            return returnCode;
        }


        public long SaveClientMasters(int pOrgID, int orgaddid, long lid, ClientMaster lstclientmaster ,   List<AddressDetails> lstClientAddress,
                                      List<ClientAttributesDetails> lstClientAttributes, List<DespatchMode> lstdespatchmode,
									  List<ClientAttributesDetails> lstpaymode, 
            out long pClientID, 
            string sendSMS, 
            PageContextkey PageContextDetails,
            int IsClient,
            int IsRemoteAccess,
                                      List<ClientTaxMaster> lstClientTaxMaster,
            string Reason, List<ClientLanguage> lstlanguage)
        {


            long returnCode = -1;
            pClientID = -1;
            //DataTable Dtinvclientmaster = GetDataTabInvMaster(lstinvoicemaster);
            //DataTable dtattributes = GetDataTabInvMaster(lstattributes);
            try
            {
                returnCode = new Master_DAL(globalContextDetails).SaveClientMasters(pOrgID, orgaddid, lid, lstclientmaster, lstClientAddress, lstClientAttributes, lstdespatchmode, lstpaymode, out pClientID, IsClient, IsRemoteAccess, lstClientTaxMaster, Reason,  lstlanguage);

                if (returnCode >= 0)
                {
                    if (sendSMS == "Y")
                    {
                        if (pClientID > 0)
                            PageContextDetails.PatientID = pClientID;
                        else
                            PageContextDetails.PatientID = lstclientmaster.ClientID;
                        ActionManager objActionManager = new ActionManager();
                        objActionManager.PerformingNextStep(PageContextDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveClientMasters in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetInvoiceClientDetails(int pOrgID, int orgaddid, string cname, string code, long ClientID, out List<ClientMaster> lstborg)
        {

            lstborg = new List<ClientMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetInvoiceClientDetails(pOrgID, orgaddid, cname, code, ClientID, out lstborg);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvoiceClientDetails in Master_BL", ex);
            }
            return returnCode;
        }

        public long Getsearchbatchid(int orgID, int Clientid, string batchid, out List<ClientBatchMaster> lstinvmasters)
        {

            lstinvmasters = new List<ClientBatchMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).Getsearchbatchid(orgID, Clientid, batchid, out lstinvmasters);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
            }
            return returnCode;
        }
		 public long Insertpushingordereddetails(int orgID,string batchid,string category,out List<ClientBatchMaster> lstinvmasters)
        {

            lstinvmasters = new List<ClientBatchMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).Insertpushingordereddetails(orgID, batchid, category, out lstinvmasters);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
            }
            return returnCode;
        }

         public long Getsearchclientbatchmaster(int orgID, int Clientid, string clientcode, string batchid, DateTime Fromdate, DateTime Todate,string Status, out List<ClientBatchMasterDetails> lstinvmasters)
        {

            lstinvmasters = new List<ClientBatchMasterDetails>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).Getsearchclientbatchmaster(orgID, Clientid, clientcode, batchid, Fromdate, Todate, Status, out lstinvmasters);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
            }
            return returnCode;
        }

        public long insertClientBatchMaster(string Batchidtxt, DateTime Fromdatetext, DateTime Todatetext, int Billingid, int Clientid, int Testnameid,int OrgID,long LID,string TestType)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).insertClientBatchMaster(Batchidtxt, Fromdatetext, Todatetext, Billingid, Clientid, Testnameid, OrgID, LID, TestType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting BarcodeOrgMapping  ", ex);
            }
            return returnCode;
        }
        public long GetClientList(int pOrgID, string prefixText, int typeid, out List<InvClientMaster> lstInvClientMaster)
        {

            lstInvClientMaster = new List<InvClientMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetClientList(pOrgID, prefixText, typeid, out lstInvClientMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetClientList in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetClientRateCard(int pOrgID, string prefixText, string RateType, out List<RateMaster> lstRateMaster)
        {

            lstRateMaster = new List<RateMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetClientRateCard(pOrgID, prefixText, RateType, out lstRateMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetClientRateCard in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetDespatchMode(out List<DespatchMode> lstDespatchMode)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetDespatchMode(out lstDespatchMode);
            return returnCode;
        }
        public long GetAddressType(out List<AddressType> lstAddressType)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetAddressType(out lstAddressType);
            return returnCode;
        }
        public long GetGroupValues(int orgid, out List<MetaValue_Common> lstmetavalue, out List<ActionManagerType> lstactionmanager, out List<ClientAttributes> lstclientattributes, out List<InvReportMaster> lstinvrptmaster)
        {
            long returnCode = -1;
            lstmetavalue = new List<MetaValue_Common>();
            lstactionmanager = new List<ActionManagerType>();
            lstclientattributes = new List<ClientAttributes>();
            lstinvrptmaster = new List<InvReportMaster>();
            returnCode = new Master_DAL(globalContextDetails).GetGroupValues(orgid, out lstmetavalue, out lstactionmanager, out lstclientattributes, out lstinvrptmaster);
            return returnCode;
        }
        public long GetGroupMasterDetails(int orgid, string Code, string prefixText, out List<Localities> lstLocalities)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetGroupMasterDetails(orgid, Code, prefixText, out lstLocalities);
            return returnCode;
        }
        public long GetSalesManname(int orgid, string Designation, string prefixText, out List<EmployeeRegMaster> lstemployee)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetSalesManname(orgid, Designation, prefixText, out lstemployee);
            return returnCode;
        }
        public long GetCollectionCentreMaster(int orgid, string prefixText, out List<OrganizationAddress> lstorgaddress)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetCollectionCentreMaster(orgid, prefixText, out lstorgaddress);
            return returnCode;
        }
        public long GetCollectionCentreClients(int orgid, int LocationID, string prefixText, out List<ClientMaster> lstClients)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetCollectionCentreClients(orgid, LocationID, prefixText, out lstClients);
            return returnCode;
        }

        public long SaveEmpRegistration(List<EmployeeRegMaster> lstEmployeeRegMaster)
        {
            long returnCode = -1;
            Master_DAL invDAL = new Master_DAL(globalContextDetails);

            try
            {
                returnCode = invDAL.SaveEmpRegistration(lstEmployeeRegMaster);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing SaveEmpRegistration in Master_BL", excp);
            }
            return returnCode;
        }
        public long GetClientforDiscount(int pOrgID, string prefixText, int typeid, out List<InvClientMaster> lstInvClientMaster)
        {

            lstInvClientMaster = new List<InvClientMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetClientforDiscount(pOrgID, prefixText, typeid, out lstInvClientMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetClientforDiscount in Master_BL", ex);
            }
            return returnCode;
        }
        public long SaveTurnOverDiscountDetail(int pOrgID, List<DiscountPolicy> lstDP)
        {


            long returnCode = -1;

            try
            {
                returnCode = new Master_DAL(globalContextDetails).SaveTurnOverDiscountDetail(pOrgID, lstDP);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveTurnOverDiscountDetail in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetEmployeeRegistration(int pOrgID, out List<EmployeeRegMaster> lstEmpRegMaster)
        {

            lstEmpRegMaster = new List<EmployeeRegMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetEmployeeRegistration(pOrgID, out lstEmpRegMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetEmployeeRegistration in Master_BL", ex);
            }
            return returnCode;
        }

        public long SaveSpecialRateMaster(string RateName, int OrgID, long CreatedBy, string MappingType,
            List<RateMaster> lstRateMaster)
        {
            long returnCode = -1;
            try
            {

                returnCode = new Master_DAL(globalContextDetails).SaveSpecialRateMaster(RateName, OrgID, CreatedBy, MappingType, lstRateMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveSpecialRateMaster in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetSpecialRates(int OrgID, out List<RateMaster> lstRateMaster)
        {
            lstRateMaster = new List<RateMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetSpecialRates(OrgID, out lstRateMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetSpecialRates in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetCustomerTODdetails(int OrgID, string Code, out List<DiscountPolicy> lstDiscountPolicy)
        {
            lstDiscountPolicy = new List<DiscountPolicy>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetCustomerTODdetails(OrgID, Code, out lstDiscountPolicy);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetCustomerTODdetails in Master_BL", ex);
            }
            return returnCode;
        }

        public long UpdateSpecialRateMaster(int OrgID, long RateID, long ModifiedBy,
            List<RateMaster> lstRateMaster)
        {
            long returnCode = -1;
            try
            {

                returnCode = new Master_DAL(globalContextDetails).UpdateSpecialRateMaster(OrgID, RateID, ModifiedBy, lstRateMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing UpdateSpecialRateMaster in Master_BL", ex);
            }
            return returnCode;
        }


        public long GetSampleCollectionZones(int OrgID, out List<Localities> lstMetaValue)
        {
            lstMetaValue = new List<Localities>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetSampleCollectionZones(OrgID, out lstMetaValue);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetSampleCollectionZones in Master_BL", ex);
            }
            return returnCode;
        }



        public long GetEmployerDeptMaster(int OrgID, out List<EmployerDeptMaster> lstEmployerDeptMaster)
        {
            lstEmployerDeptMaster = new List<EmployerDeptMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetEmployerDeptMaster(OrgID, out lstEmployerDeptMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetEmployerDeptMaster in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetSpecifiedDeptEmployee(int OrgID, string DeptCode, string PrefixText, out List<EmployeeRegMaster> lstEmployeeRegMaster)
        {
            lstEmployeeRegMaster = new List<EmployeeRegMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetSpecifiedDeptEmployee(OrgID, DeptCode, PrefixText, out lstEmployeeRegMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetSpecifiedDeptEmployee in Master_BL", ex);
            }
            return returnCode;
        }


        public long GetTODCode(int OrgID, string PrefixText, out List<DiscountPolicy> lstTOD)
        {
            lstTOD = new List<DiscountPolicy>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetTODCode(OrgID, PrefixText, out lstTOD);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetTODCode in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetmetaValue(int OrgID, string Code, out List<MetaValue_Common> lstMetaValue)
        {
            lstMetaValue = new List<MetaValue_Common>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetmetaValue(OrgID, Code, out lstMetaValue);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetmetaValue in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetHospAndRefPhy(int OrgID, string PrefixText, int ClientTypeID, out List<ClientMaster> lstClientMaster)
        {
            lstClientMaster = new List<ClientMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetHospAndRefPhy(OrgID, PrefixText, ClientTypeID, out lstClientMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetHospAndRefPhy in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetCoupon(int pOrgID, out List<CouponMaster> lstCouponMaster, out List<CouponDetails> lstCouponDetails)
        {
            long returnCode = -1;
            lstCouponMaster = new List<CouponMaster>();
            lstCouponDetails = new List<CouponDetails>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetCoupon(pOrgID, out lstCouponMaster, out lstCouponDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetCoupon in Master_BL", ex);
            }
            return returnCode;
        }

        public long SaveCoupon(int intOrgID, List<CouponMaster> lstCouponMaster, List<CouponDetails> lstCouponDetails, string strMasterDetail, string strInsUpdate, long lngLID, out string strResult)
        {
            long returncode = -1;
            strResult = "";

            try
            {
                returncode = new Master_DAL(globalContextDetails).SaveCoupon(intOrgID, lstCouponMaster, lstCouponDetails, strMasterDetail, strInsUpdate, lngLID, out strResult);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveCoupon in Master_BL", ex);
            }
            return returncode;
        }

        public long GetTODforInvoice(int OrgID, long ClientID, out List<DiscountPolicy> lstTOD)
        {
            lstTOD = new List<DiscountPolicy>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetTODforInvoice(OrgID, ClientID, out lstTOD);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetTODforInvoice in Master_BL", ex);
            }
            return returnCode;
        }

        public long CheckClientCreditLimit(long ClientID, int OrgID, out string CreditStatus, out Decimal BalanceAmount)
        {
            long returnCode = -1;
            CreditStatus = "";
            BalanceAmount = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).CheckClientCreditLimit(ClientID, OrgID, out CreditStatus, out BalanceAmount);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing CheckClientCreditLimit in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetClientMappingService(int OrgID, long ClientID, string refType, out List<ClientMappingService> lstClientMappingService)
        {
            lstClientMappingService = new List<ClientMappingService>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetClientMappingService(OrgID, ClientID, refType, out lstClientMappingService);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetClientMappingService in Master_BL", ex);
            }
            return returnCode;
        }

        public long SavePrintPolicy(Int32 pOrgID, Int64 pLoginID, PrintPolicyMaster oPrintPolicyMaster, out Int64 pID)
        {
            long returnCode = -1;
            pID = 0;
            try
            {

                if (returnCode != 0)
                {
                    returnCode = new Master_DAL(globalContextDetails).SavePrintPolicy(pOrgID, pLoginID, oPrintPolicyMaster, out pID);
                }
            }
            catch (Exception ex)
            {
                returnCode = -1;
			CLogger.LogError("Error while executing SavePrintPolicy in Master_BL", ex);
                throw ex;
            }

            return returnCode;
        }
        public long DeletePrintPolicy(Int64 pID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).DeletePrintPolicy(pID);
            }
            catch (Exception ex)
            {
                returnCode = -1;
			CLogger.LogError("Error while executing DeletePrintPolicy in Master_BL", ex);
                throw ex;
            }
            return returnCode;
        }

        public long GetPrintPolicy(Int32 OrgID, Int64 RoleID, Int64 LocationID, out List<PrintPolicy> lstPrintPolicyMaster)
        {
            long returnCode = -1;
            lstPrintPolicyMaster = new List<PrintPolicy>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetPrintPolicy(OrgID, RoleID, LocationID, out lstPrintPolicyMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPrintPolicy in Master_BL", ex);
            }
            return returnCode;
        }

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion



        public long GetServieandServicetMaster(int OrgID, out List<FeeTypeMaster> lstService, out List<FeeTypeMaster> lstResource, out List<MetaData> lstDuration)
        {
            lstService = new List<FeeTypeMaster>();
            lstResource = new List<FeeTypeMaster>();
            lstDuration = new List<MetaData>();

            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetServieandServicetMaster(OrgID, out lstService, out lstResource, out lstDuration);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetServieandServicetMaster in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetServiceNames(int OrgID, string servicetype, string PrefixText, out List<BillingFeeDetails> lstDetails)
        {
            lstDetails = new List<BillingFeeDetails>();


            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetServiceNames(OrgID, servicetype, PrefixText, out lstDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetServiceNames in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetResourceNames(int OrgID, string ProductName, int OrgAddressID, int LocationID, int TypeID, string ResourceType, out List<InventoryItemsBasket> lstInventoryItemsBasket)
        {
            lstInventoryItemsBasket = new List<InventoryItemsBasket>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetResourceNames(OrgID, ProductName, OrgAddressID, LocationID, TypeID, ResourceType, out lstInventoryItemsBasket);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetResourceNames in Master_BL", ex);
            }
            return returnCode;
        }



        public long InsertBillOfMaterials(List<BillOfMaterials> lstBillOfMaterials, List<BillofMaterialDetails> lstBillOfMaterialDetails, out List<BillofMaterialDetails> outlstBillofMaterialDetails)
        {

            long returnCode = -1;

            lstBillOfMaterials = new List<BillOfMaterials>();
            outlstBillofMaterialDetails = new List<BillofMaterialDetails>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).InsertBillOfMaterials(lstBillOfMaterials, lstBillOfMaterialDetails, out outlstBillofMaterialDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertBillOfMaterials in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetServiceMaster(int OrgID, string SearchItem, out List<BillofMaterialDetails> lstBillofMaterials)
        {

            long returnCode = -1;
            lstBillofMaterials = new List<BillofMaterialDetails>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetServiceMaster(OrgID, SearchItem, out lstBillofMaterials);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetServiceMaster in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetReasonTypes(Int16 pReasonCategoryID, out List<ReasonType> lstReasonTypes)
        {
            long returnCode = -1;
            lstReasonTypes = new List<ReasonType>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetReasonTypes(pReasonCategoryID, out lstReasonTypes);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetReasonTypes in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetReasonMaster(Int16 pReasonCategoryID, int pReasonTypeID, string ReasonCode, out List<ReasonMaster> lstReasonMaster)
        {
            long returnCode = -1;
            lstReasonMaster = new List<ReasonMaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetReasonMaster(pReasonCategoryID, pReasonTypeID, ReasonCode, out lstReasonMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetReasonMaster in Master_BL", ex);
            }
            return returnCode;
        }
        public long SaveReasonMaster(long pReasonID, int pReasonTypeID, string pReason, string pReasonCode, string pStatus, long pCreatedBy, string pSaveUpdate, out string pResult, string ExtCmt)
        {
            long returnCode = -1;
            pResult = "";
            try
            {
                returnCode = new Master_DAL(globalContextDetails).SaveReasonMaster(pReasonID, pReasonTypeID, pReason, pReasonCode, pStatus, pCreatedBy, pSaveUpdate, out pResult, ExtCmt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveReasonMaster in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetTestMasterDropDownValues(Int32 pOrgID, out List<InvDeptMaster> lstDept, out List<InvSampleMaster> lstSample, out List<InvestigationSampleContainer> lstAdditive, out List<InvestigationMethod> lstMethod, out List<InvPrincipleMaster> lstPrinciple, out List<MetaValue_Common> lstResultValue, out List<MetaValue_Common> lstSubCategory, out List<Role> lstRoles, out List<InvInstrumentMaster> lstInstrument, out List<Products> lstKit, out List<InvClientMaster> lstInvClientMaster, out List<ReasonMaster> lstReasonMaster, out List<MetaValue_Common> lstCategory, out List<InvestigationHeader> lstHeader ,out List<ShippingConditionMaster> lstSampleCondition)
        {
            long returnCode = -1;
            lstDept = new List<InvDeptMaster>();
            lstSample = new List<InvSampleMaster>();
            lstAdditive = new List<InvestigationSampleContainer>();
            lstMethod = new List<InvestigationMethod>();
            lstPrinciple = new List<InvPrincipleMaster>();
            lstResultValue = new List<MetaValue_Common>();
            lstSubCategory = new List<MetaValue_Common>();
            lstRoles = new List<Role>();
            lstInstrument = new List<InvInstrumentMaster>();
            lstKit = new List<Products>();
            lstInvClientMaster = new List<InvClientMaster>();
            lstReasonMaster = new List<ReasonMaster>();
            lstCategory = new List<MetaValue_Common>();
            lstHeader = new List<InvestigationHeader>();
            lstSampleCondition = new List<ShippingConditionMaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetTestMasterDropDownValues(pOrgID, out lstDept, out lstSample, out lstAdditive, out lstMethod, out lstPrinciple, out lstResultValue, out lstSubCategory, out lstRoles, out lstInstrument, out lstKit, out lstInvClientMaster, out lstReasonMaster, out lstCategory, out lstHeader, out lstSampleCondition);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetTestMasterDropDownValues in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetTestCodingScheme(Int32 pOrgID, String pType, String pSearchText, out List<CodingScheme> lstCodingScheme)
        {
            long returnCode = -1;
            lstCodingScheme = new List<CodingScheme>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetTestCodingScheme(pOrgID, pType, pSearchText, out lstCodingScheme);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetTestCodingScheme in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetRemarkDetails(String pRemarksType, String pSearchText, out List<Remarks> lstRemarks)
        {
            long returnCode = -1;
            lstRemarks = new List<Remarks>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetRemarkDetails(pRemarksType, pSearchText, out lstRemarks);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetRemarkDetails in Master_BL", ex);
            }
            return returnCode;
        }
        public long InsertICDCodes(List<ICDCodes> LSTICDCodes, out List<ICDCodes> lstICDCodes)
        {

            long returnCode = -1;
            lstICDCodes = new List<ICDCodes>();





            try
            {
                returnCode = new Master_DAL(globalContextDetails).InsertICDCodes(LSTICDCodes, out lstICDCodes);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertICDCodes in Master_BL", ex);
            }
            return returnCode;
        }



        public long GetClientHistory(long ClientID, int OrgID, out List<ClientMaster_HIST> lstClientMaster_HIST)
        {
            long returnCode = -1;
            lstClientMaster_HIST = new List<ClientMaster_HIST>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetClientHistory(ClientID, OrgID, out lstClientMaster_HIST);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetClientHistory in Master_BL", ex);
            }
            return returnCode;
        }


        public long GetServiceForConsumption(long PatientID, long VisitID, long ServiceID, out List<SurgeryOrderedServices> lstOrderedServices, out List<BillOfMaterials> lstBillofMeterials)
        {

            long returnCode = -1;
            lstOrderedServices = new List<SurgeryOrderedServices>();
            lstBillofMeterials = new List<BillOfMaterials>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetServiceForConsumption(PatientID, VisitID, ServiceID, out lstOrderedServices, out lstBillofMeterials);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetServiceForConsumption in Master_BL", ex);
            }
            return returnCode;
        }

        public long InsertResourceConsumption(List<ResourceConsumption> dtResourceConsumption, out List<ResourceConsumption> lstResourceConsumption)
        {

            long returnCode = -1;
            lstResourceConsumption = new List<ResourceConsumption>();


            //  DataTable dtResourceConsumptions = GetResourceConsumption(dtResourceConsumption);


            try
            {
                returnCode = new Master_DAL(globalContextDetails).InsertResourceConsumption(dtResourceConsumption, out lstResourceConsumption);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertResourceConsumption in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetTaxforClient(int pOrgID, long ClientID, out List<ClientMaster> lstTax)
        {
            long returnCode = -1;
            lstTax = new List<ClientMaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetTaxforClient(pOrgID, ClientID, out lstTax);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetTaxforClient in Master_BL", ex);
            }
            return returnCode;
        }

        public long SaveAndUpdateDiscountPolicy(int OrgID, string PolicyName, long CreatedBy,
            List<DiscountPolicyMapping> lstDiscountPolicyMapping)
        {
            long returncode = -1;

            try
            {
                returncode = new Master_DAL(globalContextDetails).SaveAndUpdateDiscountPolicy(OrgID, PolicyName, CreatedBy, lstDiscountPolicyMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveAndUpdateDiscountPolicy in Master_BL", ex);
            }
            return returncode;
        }



        public long GetDiscountPolicyMapping(int OrgID, long PolicyID, out List<DiscountPolicyMapping> lstDiscountPolicyMapping)
        {
            long returnCode = -1;
            lstDiscountPolicyMapping = new List<DiscountPolicyMapping>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetDiscountPolicyMapping(OrgID, PolicyID, out lstDiscountPolicyMapping);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDiscountPolicyMapping in Master_BL", ex);
            }
            return returnCode;
        }
        //--------------Babu-07-12-2012-----------------
        public long GetDriverUser(string prefixText, int pOrgID, out List<EmployeeRegMaster> lstDriverUser)
        {
            long returnCode = -1;

            lstDriverUser = new List<EmployeeRegMaster>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetDriverName(prefixText, pOrgID, out lstDriverUser);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDriverUser in Master_BL", ex);
            }

            return returnCode;
        }

        public long GetAmbulanceDetails(string prefixText, int pOrgID, out List<Ambulance> lstAmbulance)
        {
            long returnCode = -1;

            lstAmbulance = new List<Ambulance>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetAmbulanceDetails(prefixText, pOrgID, out lstAmbulance);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAmbulanceDetails in Master_BL", ex);
            }

            return returnCode;

        }

        public long GetAMBLocation(string prefixText, out List<Localities> lstLocation)
        {
            long returnCode = -1;

            lstLocation = new List<Localities>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetAMBLocation(prefixText, out lstLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAMBLocation in Master_BL", ex);
            }

            return returnCode;

        }
        public long SaveAndDeleteReasonMapping(string Stype, List<TaskActionOrgMapping> lstTaskActionOrgMapping, int orgid, int reasontype)
        {
            long returnCode = -1;
            Master_DAL masterDAL = new Master_DAL(globalContextDetails);

            try
            {
                returnCode = masterDAL.SaveAndDeleteReasonMapping(Stype, lstTaskActionOrgMapping, orgid, reasontype);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveAndDeleteReasonMapping in Master_BL", ex);
            }
            return returnCode;
        }
        //--------------------end------------------------------
        public long GetCommunicationConfig(Int32 pOrgID, String pType, out List<CommunicationConfig> lstCommunicationConfig)
        {
            long returnCode = -1;
            lstCommunicationConfig = new List<CommunicationConfig>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetCommunicationConfig(pOrgID, pType, out lstCommunicationConfig);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetCommunicationConfig in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetFeeTypeAttributes(string prefixText, string contextKey, int orgID, out List<FeeTypeAttributes> lstFeeTypeAttributes)
        {
            long returnCode = -1;

            lstFeeTypeAttributes = new List<FeeTypeAttributes>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetFeeTypeAttributes(prefixText, contextKey, orgID, out lstFeeTypeAttributes);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetFeeTypeAttributes in Master_BL", ex);
            }

            return returnCode;

        }
        public long GetGroupValues(int orgid, string typeName, out List<MetaValue_Common> lstmetavalue)
        {
            long returnCode = -1;
            lstmetavalue = new List<MetaValue_Common>();
            returnCode = new Master_DAL(globalContextDetails).GetGroupValues(orgid, typeName, out lstmetavalue);
            return returnCode;
        }

        public long GetInstrumentName(int orgID, out List<InvInstrumentMaster> lstInvInst)
        {
            long returnCode = -1;

            lstInvInst = new List<InvInstrumentMaster>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetInstrumentName(orgID, out lstInvInst);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInstrumentName in Master_BL", ex);
            }

            return returnCode;

        }

        public long GetDeviceInstrumentDetails(int orgid, string InstrumentName, out List<DeviceIntegrationOrgMapping> lstInvInst, out List<DeviceIntegrationOrgMapping> lstInvInst1)
        {
            long returnCode = -1;

            lstInvInst = new List<DeviceIntegrationOrgMapping>();
            lstInvInst1 = new List<DeviceIntegrationOrgMapping>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetDeviceInstrumentDetails(orgid, InstrumentName, out lstInvInst, out lstInvInst1);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDeviceInstrumentDetails in Master_BL", ex);
            }

            return returnCode;

        }

        public long GetDeviceInstrumentDetailsEdit(int orgid, string DeviceID, string TestCode, long InvestigationID, out List<DeviceIntegrationOrgMapping> lstInvInst)
        {
            long returnCode = -1;

            lstInvInst = new List<DeviceIntegrationOrgMapping>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetDeviceInstrumentDetailsEdit(orgid, DeviceID, TestCode, InvestigationID, out lstInvInst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeviceInstrumentDetailsEdit in Master_BL", ex);
            }

            return returnCode;

        }

        public long SaveAndUpdateDeviceIntegration(int OrgID, string DeviceID, long DeviceMappingID, string TestCode, long InvestigationID, string InstrumentName, int ValueId, string Formula, string IsActive)
        {
            long returnCode = -1;
            Master_DAL masterDAL = new Master_DAL(globalContextDetails);

            try
            {
                returnCode = masterDAL.SaveAndUpdateDeviceIntegration(OrgID, DeviceID, DeviceMappingID, TestCode, InvestigationID, InstrumentName, ValueId, Formula, IsActive);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveAndUpdateDeviceIntegration in Master_BL", ex);
            }
            return returnCode;
        }

        public long SaveCodingScheme(int orgid, int CodeTypeID, List<CodingSchemeMaster> lstCodingSchemeMaster, List<CodingSchemeOrgMapping> lstCodingSchemeOrgMapping)
        {
            long returncode = -1;

            try
            {
                returncode = new Master_DAL(globalContextDetails).SaveCodingScheme(orgid, CodeTypeID, lstCodingSchemeMaster, lstCodingSchemeOrgMapping);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveCodingScheme in Master_BL", ex);

            }
            return returncode;
        }

        public long GetCodingSchemeName(int pOrgID, string PkgName, string Type, int InvID, out List<CodingSchemeMaster> CSM)
        {
            long returnCode = -1;
            CSM = new List<CodingSchemeMaster>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetCodingSchemeName(pOrgID, PkgName, Type, InvID, out CSM);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetCodingSchemeName in Master_BL", ex);
            }
            return returnCode;
        }



        public long DeleteCodingScheme(int Orgid, int CodeTypeID)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Master_DAL(globalContextDetails).DeleteCodingScheme(Orgid, CodeTypeID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing DeleteCodingScheme in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetCodingSchemeMaster(string CodingSchemaName, int OrgID, out List<CodingSchemeMaster> lstCodingSchemeMaster)
        {
            long returnCode = -1;
            lstCodingSchemeMaster = new List<CodingSchemeMaster>();
            try
            {
                Master_DAL master_DAL = new Master_DAL(globalContextDetails);
                returnCode = master_DAL.GetCodingSchemeMaster(CodingSchemaName, OrgID, out lstCodingSchemeMaster);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetCodingSchemeMaster in Master_BL", ex);

            }
            return returnCode;
        }
        public long GetZoneDetails(int orgid, string Code, string prefixText, int HubId, out List<Localities> lstLocalities)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetZoneDetails(orgid, Code, prefixText, HubId, out lstLocalities);
            return returnCode;
        }

        public long GetRouteNames(int orgid, string Code, string prefixText, int ZoneID, out List<Localities> lstLocalities)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetRouteNames(orgid, Code, prefixText, ZoneID, out lstLocalities);
            return returnCode;
        }


        public long GetDoctorName(int orgID, int deptID, int roleID, out List<InvOrgAuthorization> physician)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetDoctorName(orgID, deptID, roleID, out physician);
            return returnCode;
        }

        public long GetDeptName(int orgID, int roleID, out List<InvDeptMaster> lstDept)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetDeptName(orgID, roleID, out lstDept);
            return returnCode;
        }
        public long GetLoginDept(int LoginID, int OrgID, int RoleID, out List<InvDeptMaster> lstDept)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetLoginDept(LoginID, OrgID, RoleID, out lstDept);
            return returnCode;
        }
        public long InsertCreditDebitSummary(List<CreditDebitSummary> CrDr, int OrgID, out long ReceiptNo)
        {
            //CrDr = new List<CreditDebitSummary>();
            long returncode = -1;
            ReceiptNo = -1;
            try
            {
                Master_DAL MasterDAL = new Master_DAL(globalContextDetails);
                returncode = new Master_DAL(globalContextDetails).InsertCreditDebitSummary(CrDr, OrgID, out ReceiptNo);
            }
            catch (Exception ex)
            {
                returncode = -1;
			CLogger.LogError("Error while executing InsertCreditDebitSummary in Master_BL", ex);
                throw ex;
            }

            return returncode;

        }
        public long GetCreditDebitSummary(long ClientID, string FrmDate, string ToDate, int OrgId, int PageSize, int currentPageNo, out int totalRows, out List<CreditDebitSummary> lstCreditDebit)
        {
            long returnCode = -1;

            returnCode = new Master_DAL(globalContextDetails).GetCreditDebitSummary(ClientID, FrmDate, ToDate, OrgId, PageSize, currentPageNo, out totalRows, out lstCreditDebit);
            return returnCode;
        }

        public long GetClientValidation(int WClientID, string WClientType, string WReferenceID, string WType, int WPatientID, out List<CreditDebitSummary> lstCreditDebit)
        {
            long returnCode = -1;
            lstCreditDebit = new List<CreditDebitSummary>();
            returnCode = new Master_DAL(globalContextDetails).GetClientValidation(WClientID, WClientType, WReferenceID, WType, WPatientID, out lstCreditDebit);
            return returnCode;
        }

        public long GetReasonMasterCrDr(int OrgID, out List<ReasonMaster> lstReasonMaster)
        {
            long returnCode = -1;
            lstReasonMaster = new List<ReasonMaster>();
            returnCode = new Master_DAL(globalContextDetails).GetReasonMasterCrDr(OrgID, out lstReasonMaster);
            return returnCode;
        }
        public long GetCreditDebitSummaryforprint(long Clientid, long AuthorizedId, int orgidprint, out List<CreditDebitSummary> lstCreditInsertPrint)
        {
            long returnCode = -1;
            lstCreditInsertPrint = new List<CreditDebitSummary>();
            returnCode = new Master_DAL(globalContextDetails).GetCreditDebitSummaryforprint(Clientid, AuthorizedId, orgidprint, out lstCreditInsertPrint);
            return returnCode;
        }
        public long GetrefPhysician(long refcode, int OrgID, string Category, DateTime FrmDate, DateTime ToDate, out List<BillingDetails> lstBillingDetails)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            try
            {
                Master_DAL master_DAL = new Master_DAL(globalContextDetails);
                returnCode = master_DAL.GetrefPhysician(refcode, OrgID, Category, FrmDate, ToDate, out lstBillingDetails);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetrefPhysician in Master_BL", ex);

            }
            return returnCode;
        }

        public long DeleteOutsourceDocDetails(List<TRFfilemanager> lstTRF)
        {
            long returnCode = -1;
            Master_DAL masterDAL = new Master_DAL(globalContextDetails);
            try
            {
                returnCode = masterDAL.DeleteOutsourceDocDetails(lstTRF);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing DeleteOutsourceDocDetails in Master_BL", ex);
            }
            return returnCode;
        }


        public long GetOutsourceDocDetails(long Patientid, long Visitid, int pOrgID, string pType, out List<TRFfilemanager> lstTRF)
        {

            long returnCode = -1;
            lstTRF = new List<TRFfilemanager>();
            try
            {
                Master_DAL master_DAL = new Master_DAL(globalContextDetails);
                returnCode = master_DAL.GetOutsourceDocDetails(Patientid, Visitid, pOrgID, pType, out lstTRF);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetOutsourceDocDetails in Master_BL", ex);

            }
            return returnCode;
        }

        public long GetClientAndRefPhyAndLocation(int SearchTypeID, string PrefixText, int OrgID, out List<ClientMaster> lstClientMaster)
        {
            lstClientMaster = new List<ClientMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetClientAndRefPhyAndLocation(SearchTypeID, PrefixText, OrgID, out lstClientMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetClientAndRefPhyAndLocation in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetAddresBookDetails(int SearchType, int SearchTypeID, int OrgID, out List<OrganizationAddress> lstOragnizationAddress)
        {
            lstOragnizationAddress = new List<OrganizationAddress>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetAddresBookDetails(SearchType, SearchTypeID, OrgID, out lstOragnizationAddress);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetAddresBookDetails in Master_BL", ex);
            }
            return returnCode;
        }
        public long LoadTaxDetails(int OrgID, out List<Taxmaster> lstTaxmaster)
        {
            long returnCode = -1;
            lstTaxmaster = new List<Taxmaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).LoadTaxDetails(OrgID, out lstTaxmaster);
            }
            catch (Exception ex)
            {

			CLogger.LogError("Error while executing LoadTaxDetails in Master_BL", ex);
            }
            return returnCode;
        }
        public long SaveInterpretationNotes(Int32 pInvID, String pType, String pNotes)
        {
            long returnCode = -1;
            Master_DAL objMasterDAL = null;
            try
            {
                objMasterDAL = new Master_DAL(globalContextDetails);
                returnCode = objMasterDAL.SaveInterpretationNotes(pInvID, pType, pNotes);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while executing SaveInterpretationNotes in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetTestCodingDetails(Int32 pOrgID, String pSearchType, out List<CodingScheme> lstTestCodingDetails)
        {
            long returnCode = -1;
            Master_DAL objMasterDAL = null;
            lstTestCodingDetails = new List<CodingScheme>();
            try
            {
                objMasterDAL = new Master_DAL(globalContextDetails);
                returnCode = objMasterDAL.GetTestCodingDetails(pOrgID, pSearchType, out lstTestCodingDetails);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                returnCode = -1;
			CLogger.LogError("Error while executing GetTestCodingDetails in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetInterpretationNotes(Int32 pID, String pType, out List<NameValuePair> lstInterpretationNotes)
        {
            long returnCode = -1;
            Master_DAL objMasterDAL = null;
            lstInterpretationNotes = new List<NameValuePair>();
            try
            {
                objMasterDAL = new Master_DAL(globalContextDetails);
                returnCode = objMasterDAL.GetInterpretationNotes(pID, pType, out lstInterpretationNotes);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                returnCode = -1;
			CLogger.LogError("Error while executing GetInterpretationNotes in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetInvLocationMapping(int orgID, out List<MetaValue_Common> lstType, out List<OrganizationAddress> lstOrgLocation)
        {
            long returncode = -1;
            lstType = new List<MetaValue_Common>();
            lstOrgLocation = new List<OrganizationAddress>();
            try
            {
                Master_DAL masterdal = new Master_DAL(globalContextDetails);
                returncode = masterdal.GetInvLocationMapping(orgID, out lstType, out lstOrgLocation);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInvLocationMapping in Master_BL", ex);
            }
            return returncode;
        }

        public long GetProcessingOrgLocation(int OrgID, string OrgName, string Type, out List<OrganizationAddress> lstProcessingLocation)
        {
            long returncode = -1;
            lstProcessingLocation = new List<OrganizationAddress>();
            try
            {
                Master_DAL Masterdal = new Master_DAL(globalContextDetails);
                returncode = Masterdal.GetProcessingOrgLocation(OrgID, OrgName, Type, out lstProcessingLocation);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetProcessingOrgLocation in Master_BL", ex);
            }
            return returncode;
        }
        public long UpdateRateCardDetails(Int32 OrgID, List<RateCardMaster> lstRateCardDetails, out List<RateCardMaster> lstinvClientMasterData)
        {
            long returnCode = -1;
            lstinvClientMasterData = new List<RateCardMaster>();
            try
            {
                Master_DAL Masterdal = new Master_DAL(globalContextDetails);
                returnCode = Masterdal.UpdateRateCardDetails(OrgID, lstRateCardDetails, out lstinvClientMasterData);
                if (lstinvClientMasterData.Count > 0)
                {

                    returnCode = 0;
                }
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing UpdateRateCardDetails in Master_BL", excp);
            }
            return returnCode;
        }
        #region sample workflow
        public long GetSampleSubType(int OrgID, long GroupTypeID, out List<InvSampleMaster> lstInvSampleMaster)
        {
            long returnCode = -1;
            lstInvSampleMaster = new List<InvSampleMaster>();
            try
            {
                Master_DAL master_DAL = new Master_DAL(globalContextDetails);
                returnCode = master_DAL.GetSampleSubType(OrgID, GroupTypeID, out lstInvSampleMaster);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetSampleSubType in Master_BL", ex);

            }
            return returnCode;
        }
        #endregion
        #region Sample Archieval Master
        public long GetSampleType(int OrgID, long LocationID, out List<InvSampleGroupMaster> lstInvSampleGroupMaster)
        {
            long returnCode = -1;

            lstInvSampleGroupMaster = new List<InvSampleGroupMaster>();
            try
            {
                Master_DAL master_DAL = new Master_DAL(globalContextDetails);
                returnCode = master_DAL.GetSampleType(OrgID, LocationID, out lstInvSampleGroupMaster);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetSampleType in Master_BL", ex);

            }
            return returnCode;
        }
        #endregion
        #region Remarks
        public long InsertRemarks(string RemarkType, string RemarkCode, string Remark, out long returnCode)
        {
            // lstremark  = new List<Remarks >();
            returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).InsertRemarks(RemarkType, RemarkCode, Remark, out returnCode);
            }
            catch (Exception Ex)
            {
			CLogger.LogError("Error while executing InsertRemarks in Master_BL", Ex);
            }
            return returnCode;
        }


        public long UpdateRemarks(string RemarkType, int RemarkID, string Remarktext, string RemarkCode, out long returnCode)
        {
            //lstremark = new List<Remarks>();
            returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).UpdateRemarks(RemarkType, RemarkID, Remarktext, RemarkCode, out returnCode);
            }
            catch (Exception Ex)
            {
			CLogger.LogError("Error while executing UpdateRemarks in Master_BL", Ex);
            }
            return returnCode;

        }
        #endregion


        #region MedicalREmarks
        public long GetMedicalComments(long Invid, string TxtValue, int OrgID, out List<InvRemarks> lstInvRemarks)
        {
            long returnCode = -1;
            lstInvRemarks = new List<InvRemarks>();
            try
            {
                Master_DAL master_DAL = new Master_DAL(globalContextDetails);
                returnCode = master_DAL.GetMedicalComments(Invid, TxtValue, OrgID, out lstInvRemarks);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetMedicalComments in Master_BL", ex);

            }
            return returnCode;
        }
        #endregion

        #region FishPattern
        public long GetAutoComments(long Invid, string CommentCode, out List<InvestigationBulkData> lstInvRemarks)
        {
            long returnCode = -1;
            lstInvRemarks = new List<InvestigationBulkData>();
            try
            {
                Master_DAL master_DAL = new Master_DAL(globalContextDetails);
                returnCode = master_DAL.GetAutoComments(Invid, CommentCode, out lstInvRemarks);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAutoComments in Master_BL", ex);

            }
            return returnCode;
        }
        #endregion
        #region LibraryCode
        public long GetInvNames(long InvId, string InvName, out List<InvestigationBulkData> lstInvBulk, out List<InvestigationBulkData> lstInvBulk1)
        {
            long returnCode = -1;
            lstInvBulk = new List<InvestigationBulkData>();
            lstInvBulk1 = new List<InvestigationBulkData>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetInvNames(InvId, InvName, out lstInvBulk, out lstInvBulk1);
            }
            catch (Exception Ex)
            {
			CLogger.LogError("Error while executing GetInvNames in Master_BL", Ex);
            }
            return returnCode;
        }
        public long InsertInvValues(List<InvestigationBulkData> lstInvBulkValues, out long returnCode)
        {
            returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).InsertInvValues(lstInvBulkValues, out returnCode);
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error while executing InsertInvValues in Master_BL", Ex);
            }
            return returnCode;

        }
        public long DeleteInvBulkData(int InvID, string InvName, string InvValue, int InvStatus, string pCommend)
        {
            long returnCode = -1;
            Master_DAL objInvDel = new Master_DAL(globalContextDetails);

            try
            {
                returnCode = objInvDel.DeleteInvBulkData(InvID, InvName, InvValue, InvStatus, pCommend);
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error while executing DeleteInvBulkData in Master_BL", Ex);
            }
            return returnCode;
        }
        #endregion
        public long GetSamplesForAdditionalTube(int orgID, int ID, string Type, out List<InvSampleMaster> lstInvSampleMaster, out List<AdditionalTubeMapping> lstAdditionalTubeMapping)
        {
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstAdditionalTubeMapping = new List<AdditionalTubeMapping>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetSamplesForAdditionalTube(orgID, ID, Type, out lstInvSampleMaster, out lstAdditionalTubeMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSamplesForAdditionalTube in Master_BL", ex);
            }
            return returnCode;
        }
        public long CheckExistingBarcode(int OrgID, string Barcodenumber, out List<PatientInvSample> lstBarcode)
        {
            long returnCode = -1;
            lstBarcode = new List<PatientInvSample>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).CheckExistingBarcode(OrgID, Barcodenumber, out lstBarcode);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing CheckExistingBarcode in Master_BL", ex);
            }
            return returnCode;
        }
        public long InsertCoupenValueMaster(List<CouponValueMaster> pCVM, out List<CouponValueMaster> lstOutputMsg)
        {
            lstOutputMsg = new List<CouponValueMaster>();
            long returncode = -1;
            try
            {
                returncode = new Master_DAL(globalContextDetails).InsertCoupenValueMaster(pCVM, out lstOutputMsg);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertCoupenValueMaster in Master_BL", ex);
            }
            return returncode;
        }
        public long GetCoupenTestValuemaster(out List<CouponValueMaster> lstCouponValueMaster, int orgid, string TestName, string CouponBarcode, long PhysicianId)
        {
            lstCouponValueMaster = new List<CouponValueMaster>();
            long returncode = -1;
            try
            {
                //returncode = new Master_DAL(globalContextDetails).GetCoupenTestValuemaster(out lstCouponValueMaster,orgid , TestName, CouponBarcode, PhysicianId);
                returncode = new Master_DAL(globalContextDetails).GetCoupenTestValuemaster(out lstCouponValueMaster, orgid, TestName, CouponBarcode, PhysicianId);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCoupenTestValuemaster in Master_BL", ex);
            }
            return returncode;
        }
        public long UpdateCoupenTestValuemaster(List<CouponValueMaster> pCVM)
        {
            long returncode = -1;
            try
            {
                returncode = new Master_DAL(globalContextDetails).UpdateCoupenTestValuemaster(pCVM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateCoupenTestValuemaster in Master_BL", ex);
            }
            return returncode;

        }
        # region RoundMaster

        public long SaveRoundManagement(string roundName, string isActive, string startLocation, string endLocation, DateTime createdAt, string startTime, string endTime, string logisticEmployee, string roundSheetTime, string value, List<RoundMasterAttributes> lstRoundAttributes, int OrgID, long roundId, out long roundId1)
        {
            long returnCode = -1;
            try
            {
                Master_DAL scheduleDAL = new Master_DAL(globalContextDetails);
                returnCode = scheduleDAL.SaveRoundManagement(roundName, isActive, startLocation, endLocation, createdAt, startTime, endTime, logisticEmployee, roundSheetTime, value, lstRoundAttributes, OrgID, roundId, out roundId1);
            }
            catch (Exception ex)
            {
                returnCode = -1;
			CLogger.LogError("Error while executing SaveRoundManagement in Master_BL", ex);
                throw ex;
            }

            return returnCode;
        }

        public long GetRoundNameList(string prefixText, int pOrgID, string searchType, out List<RoundMaster> lstRoundMaster)
        {
            long returnCode = -1;
            lstRoundMaster = new List<RoundMaster>();
            Master_DAL roundNameDAL = new Master_DAL(globalContextDetails);
            try
            {
                returnCode = roundNameDAL.GetRoundNameList(prefixText, pOrgID, searchType, out lstRoundMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetRoundNameList in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetRoundNameAttributes(string prefixText, int pOrgID, string searchType, long roundId, out List<RoundMasterAttributes> lstRoundAttributes)
        {
            long returnCode = -1;
            lstRoundAttributes = new List<RoundMasterAttributes>();
            Master_DAL oMasterDAL = new Master_DAL(globalContextDetails);
            try
            {
                returnCode = oMasterDAL.GetRoundNameAttributes(prefixText, pOrgID, searchType, roundId, out lstRoundAttributes);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetRoundNameAttributes in Master_BL", ex);
            }

            return returnCode;
        }

        public long DeleteRoundMasterClient(int ID, long roundID)
        {
            long returnCode = -1;
            try
            {
                Master_DAL oMasterDAL = new Master_DAL(globalContextDetails);
                returnCode = oMasterDAL.DeleteRoundMasterClient(ID, roundID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteRoundMasterClient in Master_BL", ex);
            }
            return returnCode;
        }

        public long CheckRoundName(string prefixText, int pOrgID, out int Id)
        {
            long returnCode = -1;
            Id = -1;
            Master_DAL oMasterDAL = new Master_DAL(globalContextDetails);
            try
            {
                returnCode = oMasterDAL.CheckRoundName(prefixText, pOrgID, out Id);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing CheckRoundName in Master_BL", ex);
            }

            return returnCode;
        }

        #endregion
        #region Manage Referral Policy
        public long SaveReferrealPolicy(int pOrgID, List<ManageReferralPolicy> lstDP)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Master_DAL(globalContextDetails).SaveReferrealPolicy(pOrgID, lstDP);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveReferrealPolicy in Master_BL", ex);
            }
            return returnCode;
        }
        public long Getreferralpolicy(out List<ManageReferralPolicy> lstManageReferralPolicy)
        {
            long returnCode = -1;
            lstManageReferralPolicy = new List<ManageReferralPolicy>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).Getreferralpolicy(out lstManageReferralPolicy);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing Getreferralpolicy in Master_BL", ex);
            }
            return returnCode;
        }
        #endregion
        public long GetReferralCategory(out List<ManageReferralPolicy> lstManageReferralPolicy)
        {
            long returnCode = -1;
            lstManageReferralPolicy = new List<ManageReferralPolicy>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetReferralCategory(out lstManageReferralPolicy);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetReferralCategory in Master_BL", ex);
            }
            return returnCode;
        }
        //MANAGE INVESTIGATION AND GROUP MODULE

        public long GetInvGroupforDept(int OrgID, out List<InvOrgGroup> lstGropup)
        {

            long returnCode = -1;
            lstGropup = new List<InvOrgGroup>();
            Master_DAL ObjDAL = new Master_DAL(globalContextDetails);

            try
            {
                returnCode = ObjDAL.GetInvGroupforDept(OrgID, out lstGropup);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInvGroupforDept in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetGroupInvestigationMaster(int OrgID, string displayText, out List<InvOrgGroup> lstGropup)
        {

            long returnCode = -1;
            lstGropup = new List<InvOrgGroup>();
            Master_DAL ObjDAL = new Master_DAL(globalContextDetails);
            try
            {
                returnCode = ObjDAL.GetGroupInvestigationMaster(OrgID, displayText, out lstGropup);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetGroupInvestigationMaster in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetInvestigationforDepartment(int OrgID, out List<InvDeptMaster> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<InvDeptMaster>();
            Master_DAL ObjDAL = new Master_DAL(globalContextDetails);
            try
            {
                returnCode = ObjDAL.GetInvestigationforDepartment(OrgID, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationforDepartment in Master_BL", ex);
            }
            return returnCode;
        }

        public long pUpdateInvandGroupSequenceMaster(List<InvOrgGroup> lstInvOrgDT, int OrgID, int DeptID)
        {
            long returnCode = -1;
            Master_DAL ObjDAL = new Master_DAL(globalContextDetails);
            try
            {

                returnCode = ObjDAL.pUpdateInvandGroupSequenceMaster(lstInvOrgDT, OrgID, DeptID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pUpdateInvandGroupSequenceMaster in Master_BL", ex);
            }
            return returnCode;
        }
        #region DHANA R (30-04-2015)

        //MANAGE PACKAGE CONTENT AND REFELEX MODULE

        public long GetAutoPackageContentandRflex(int OrgID, string packageContent, out List<InvOrgGroup> lstReflex)
        {

            long returnCode = -1;
            lstReflex = new List<InvOrgGroup>();
            Master_DAL ObjDAL = new Master_DAL(globalContextDetails);
            try
            {
                returnCode = ObjDAL.GetAutoPackageContentandRflex(OrgID, packageContent, out lstReflex);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetAutoPackageContentandRflex in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetFetchPackageContentandRflex(int OrgID, string packgeName, string packageCode, out List<InvOrgGroup> lstReflex)
        {

            long returnCode = -1;
            lstReflex = new List<InvOrgGroup>();
            Master_DAL ObjDAL = new Master_DAL(globalContextDetails);
            try
            {
                returnCode = ObjDAL.GetFetchPackageContentandRflex(OrgID, packgeName, packageCode, out lstReflex);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetFetchPackageContentandRflex in Master_BL", ex);
            }
            return returnCode;
        }

        public long pUpdatePackageMappingContent(string pType, int pOrgID, int PPackageId, string PAdditionalTubeCode, List<InvOrgGroup> lstReflex)
        {

            long returnCode = -1;
            //lstReflex = new List<InvOrgGroup>();
            Master_DAL ObjDAL = new Master_DAL(globalContextDetails);
            try
            {
                returnCode = ObjDAL.pUpdatePackageMappingContent(pType, pOrgID, PPackageId, PAdditionalTubeCode, lstReflex);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pUpdatePackageMappingContent in Master_BL", ex);
            }
            return returnCode;
        }

        public long pGetReflexPackege(string pType, long pInvId, long pID, long pOrgID, out List<InvOrgGroup> lstReflex)
        {

            long returnCode = -1;
            lstReflex = new List<InvOrgGroup>();
            Master_DAL ObjDAL = new Master_DAL(globalContextDetails);
            try
            {
                returnCode = ObjDAL.pGetReflexPackege(pType, pInvId, pID, pOrgID, out lstReflex);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing pGetReflexPackege in Master_BL", ex);
            }
            return returnCode;
        }
        public long UpdatePackagesDetails(InvOrgGroup objorgrouppackages, DataTable dtCodingSchemeMaster, int CutOffTimeValue, string CutOffTimeType, string SubCategory, short ScheduleType, string IsOptionalTest)
        {
            long returncode = 0;
            try
            {
                Master_DAL objMaster_DAL = new Master_DAL(globalContextDetails);
                returncode = objMaster_DAL.UpdatePackagesDetails(objorgrouppackages, dtCodingSchemeMaster, CutOffTimeValue, CutOffTimeType, SubCategory, ScheduleType, IsOptionalTest);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing UpdatePackagesDetails in Master_BL", ex);
            }
            return returncode;
        }
        public long GetInsertInvGroupDetails(List<InvestigationOrgMapping> pInvMap, string groupName, int dptID, long gHeader, int DdlCase, string type, long OrgID, string ModifiedBy, string GroupCode, string Remarks, string status, string Pkgcode, string printSeparately, DataTable dtCodingSchemeMaster, int CutOffTimeValue, string CutOffTimeType, string Gender, string IsServiceTaxable, short ScheduleType, string IsOptionalTest)
        {
            long returnCode = -1;
            Master_DAL objMaster_DAL = new Master_DAL(globalContextDetails);

            try
            {
                returnCode = objMaster_DAL.GetInsertInvGroupDetails(pInvMap, groupName, dptID, gHeader, DdlCase, type, OrgID, ModifiedBy, GroupCode, Remarks, status, Pkgcode, printSeparately, dtCodingSchemeMaster, CutOffTimeValue, CutOffTimeType, Gender, IsServiceTaxable, ScheduleType, IsOptionalTest);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetInsertInvGroupDetails in Master_BL", excp);
            }
            return returnCode;
        }

        /*AB Code For Rolling Advance*/
        public long GetRollingAdvanceClients(out List<ClientMaster> lstAttributesDetails)
        {
            lstAttributesDetails = new List<ClientMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetRollingAdvanceClients(out lstAttributesDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRollingAdvanceClients in Master_BL", ex);
            }
            return returnCode;
        }

        #endregion
		
		   /*added By jagatheesh  for Test wise Analyzer report*/
        public long GetAnalyzerName(int orgID, out List<InvInstrumentMaster> lstInvInst)
        {
            long returnCode = -1;
            lstInvInst = new List<InvInstrumentMaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetAnalyzerName(orgID, out lstInvInst);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetAnalyzerName in Master_BL", ex);
            }
            return returnCode;

        }
        /* End Added */
        public long GetRolesbyName(string Roles, long orgID, out List<Role> lstrole)
        {
            long returnCode = -1;
            lstrole = new List<Role>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetRolesbyName(Roles, orgID, out lstrole);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCasuality", ex);
            }
            return returnCode;
        }
		public long GetTATSchedulecode(int OrgID, string PrefixText, out List<TATSchedule> lstTATSchedulecode)
        {
            lstTATSchedulecode = new List<TATSchedule>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetTATSchedulecode(OrgID, PrefixText, out lstTATSchedulecode);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading in GetTATSchedulecode() in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetTATSchedulecategoryItem(int OrgID, string PrefixText, string SearchType, out List<CodingScheme> lstTATSchedulecategoryItem)
        {
            lstTATSchedulecategoryItem = new List<CodingScheme>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetTATSchedulecategoryItem(OrgID, PrefixText, SearchType, out lstTATSchedulecategoryItem);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading in GetTATSchedulecode() in Master_BL", ex);
            }
            return returnCode;
        }
        public long SaveTestforTAT(List<Tatschedulemapping> lstTATAdded)
        {
            long returnCode = -1;
            try
            {
                Master_DAL MasterDAL = new Master_DAL(globalContextDetails);
                returnCode = MasterDAL.SaveTestforTAT(lstTATAdded);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveTestforTAT", ex);
            }
            return returnCode;
        }
        public long DeleteTestforTAT(List<Tatschedulemapping> lstDeleteAdded)
        {
            long returnCode = -1;
            try
            {
                Master_DAL MasterDAL = new Master_DAL(globalContextDetails);
                returnCode = MasterDAL.DeleteTestforTAT(lstDeleteAdded);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveTestforTAT", ex);
            }
            return returnCode;
        }
        public long LoadtatTestname(int OrgID, int TatID, out List<CodingScheme> lstLoadCategoryTestname)
        {
            lstLoadCategoryTestname = new List<CodingScheme>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).LoadtatTestname(OrgID, TatID, out lstLoadCategoryTestname);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading in LoadtatTestname() in Master_BL", ex);
            }
            return returnCode;
        }
        public long LoadtatClientTestname(int OrgID, int TatID, int ClientID, out List<CodingScheme> lstLoadCategoryTestname)
        {
            lstLoadCategoryTestname = new List<CodingScheme>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).LoadtatClientTestname(OrgID, TatID, ClientID, out lstLoadCategoryTestname);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading in LoadtatTestname() in Master_BL", ex);
            }
            return returnCode;
        }
        public long LoadTATLogisticsDetails(int OrgID, long LocID, out List<Tatlogisticdetails> lstTatlogistic)
        {
            lstTatlogistic = new List<Tatlogisticdetails>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).LoadTATLogisticsDetails(OrgID, LocID, out lstTatlogistic);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading in LoadTATLogisticsDetails() in Master_BL", ex);
            }
            return returnCode;
        }
        public long SaveTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
        {
            long returnCode = -1;
            try
            {
                Master_DAL MasterDAL = new Master_DAL(globalContextDetails);
                returnCode = MasterDAL.SaveTATLogisticsDetails(lstTatlogisticdetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveTATLogisticsDetails", ex);
            }
            return returnCode;
        }
        public long UpdateTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
        {
            long returnCode = -1;
            try
            {
                Master_DAL MasterDAL = new Master_DAL(globalContextDetails);
                returnCode = MasterDAL.UpdateTATLogisticsDetails(lstTatlogisticdetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateTATLogisticsDetails", ex);
            }
            return returnCode;
        }
        public long EditTATLogisticsDetails(int Logisticdetailsid, out List<Tatlogisticdetails> lstTatlogistic)
        {
            lstTatlogistic = new List<Tatlogisticdetails>();
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).EditTATLogisticsDetails(Logisticdetailsid, out lstTatlogistic);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading in EditTATLogisticsDetails() in Master_BL", ex);
            }
            return returnCode;
        }
        public long DeleteTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
        {
            long returnCode = -1;
            try
            {
                Master_DAL MasterDAL = new Master_DAL(globalContextDetails);
                returnCode = MasterDAL.DeleteTATLogisticsDetails(lstTatlogisticdetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteTATLogisticsDetails", ex);
            }
            return returnCode;
        }
        public long pGetLoginNamesbyRole(long RoleID, long orgID, out List<Login> lstlogin)
        {
            long returnCode = -1;
            lstlogin = new List<Login>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).pGetLoginNamesbyRole(RoleID, orgID, out lstlogin);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL pGetLoginNamesbyRole", ex);
            }
            return returnCode;
        }

        public long pGetWidgetNames(long RoleID, out List<Widgetmaster_Custom> lst)
        {
            long returnCode = -1;
            lst = new List<Widgetmaster_Custom>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).pGetWidgetNames(RoleID,out lst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL pGetWidgetNames", ex);
            }
            return returnCode;
        }
		public long GetHealthLabData(string MessageControlId, DateTime Datefrom, DateTime DateTo, string ExternalVisitId, int MessageId, out List<HLMessages> lstHLM)
        {
            long returnCode = -1;
            lstHLM = new List<HLMessages>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetHealthLabData(MessageControlId, Datefrom, DateTo, ExternalVisitId, MessageId, out lstHLM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHealthLabData in Master_BL", ex);
            }
            return returnCode;
        }
		public long GetErrorMsgByMsgId(long msgId, out List<HLMessageErrorDetails> lstHLM)
        {
            long returnCode = -1;
            lstHLM = new List<HLMessageErrorDetails>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetErrorMsgByMsgId(msgId, out lstHLM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHealthLabData in Master_BL", ex);
            }
            return returnCode;
        }

        public long GetHL7PatientDetail(long msgId, DateTime DateFrom, DateTime DateTo, out List<HLMessagePatientIDDetails> lstHLM)
        {
            long returnCode = -1;
            lstHLM = new List<HLMessagePatientIDDetails>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetHL7PatientDetail(msgId, DateFrom, DateTo, out lstHLM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHL7PatientDetail in Master_BL", ex);
            }
            return returnCode;
        }
        public long GetHL7OrderedDetails(long msgId, DateTime DateFrom, DateTime DateTo, out List<HLMessageOBRDetails> lstHLM)
        {
            long returnCode = -1;
            lstHLM = new List<HLMessageOBRDetails>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetHL7OrderedDetails(msgId, DateFrom, DateTo, out lstHLM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHL7OrderedDetails in Master_BL", ex);
            }
            return returnCode;
        }
        public long pGetWidgetsbyRoleandUser(long RoleID, long LoginID, long orgID, out List<Widgetmaster_Custom> lstwst)
        {
            long returnCode = -1;
            lstwst = new List<Widgetmaster_Custom>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).pGetWidgetsbyRoleandUser(RoleID, LoginID, orgID, out lstwst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL pGetWidgetsbyRole", ex);
            }
            return returnCode;
        }

        public long pGetWidgetsuserdetails(long RoleID, long LoginID, long orgID, out List<WidgetUserDetails> lstwst)
        {
            long returnCode = -1;
            lstwst = new List<WidgetUserDetails>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).pGetWidgetsuserdetails(RoleID, LoginID, orgID, out lstwst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL pGetWidgetsuserdetails", ex);
            }
            return returnCode;
        }
        public long pSaveWidgetsbyroleanduser(List<WidgetRoleMapping_Custom> lst)
        {
            long returnCode = -1;
            Master_DAL ObjDAL = new Master_DAL(globalContextDetails);
            try
            {

                returnCode = ObjDAL.pSaveWidgetsbyroleanduser(lst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save pSaveWidgetsbyroleanduser ", ex);
            }
            return returnCode;
        }
		public long GetHL7VisitDetails(long msgId, DateTime DateFrom, DateTime DateTo, out List<HLMessageORCDetails> lstHLM)
         {
             long returnCode = -1;
             lstHLM = new List<HLMessageORCDetails>();
             try
             {
                 returnCode = new Master_DAL(globalContextDetails).GetHL7VisitDetails(msgId, DateFrom, DateTo, out lstHLM);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing GetHL7VisitDetails in Master_BL", ex);
             }
             return returnCode;
         }
         public long SaveHL7MessageFiles(string FileName, string FilePath, int OrgID, long LocationID, long CreatedBy, DateTime ModifiedAt, long ModifiedBy)
         {
             long retunCode = -1;
             try
             {
                 retunCode = new Master_DAL(globalContextDetails).SaveHL7MessageFiles(FileName, FilePath, OrgID, LocationID, CreatedBy, ModifiedAt, ModifiedBy);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error While Save SaveHL7MessageFiles Method", ex);
             }
             return retunCode;
         }
		public long GetHL7HealthLabDataDetail(long msgId, DateTime DateFrom, DateTime DateTo, out List<HLMessagePatientIDDetails> lstHLM, out List<HLMessageORCDetails> lstHLMORC, out List<HLMessageOBRDetails> lstHLMORD)
         {
             long returnCode = -1;
             lstHLM = new List<HLMessagePatientIDDetails>();
             lstHLMORC = new List<HLMessageORCDetails>();
             lstHLMORD = new List<HLMessageOBRDetails>();
             try
             {
                 returnCode = new Master_DAL(globalContextDetails).GetHL7HealthLabDataDetail(msgId, DateFrom, DateTo, out lstHLM, out lstHLMORC, out lstHLMORD);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing GetHL7HealthLabDataDetail in Master_BL", ex);
            }
            return returnCode;
        }

        public long pGetWidgetcountmis(long OrgID, long LocationID, long DeptID, DateTime FromDate, DateTime ToDate, long RoleID, out DataTable billing, out DataTable TestDetails, out DataTable analyserdetails, out DataTable sampledetails, out DataTable NearingTatDetails, out DataTable DelayedTATDetails, out DataSet dsCountDetails)
        {
            long returnCode = -1;
            billing = new DataTable();
            TestDetails = new DataTable();
            analyserdetails = new DataTable();
            sampledetails = new DataTable();
            NearingTatDetails = new DataTable();
            DelayedTATDetails = new DataTable();
            dsCountDetails = new DataSet();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).pGetWidgetcountmis(OrgID, LocationID, DeptID, FromDate, ToDate, RoleID, out billing, out TestDetails, out analyserdetails, out sampledetails, out NearingTatDetails, out DelayedTATDetails, out dsCountDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL pGetWidgetcountmis", ex);
            }
            return returnCode;
        }


        //Added by sudhakar 2017-03-06
        public DataSet pGetMISReport(int OrgID, int LocationID, int DepartmentID, DateTime fromDate, DateTime toDate, int checkDiff, string WCode, string WGCode)
        {
            DataSet ds = new DataSet();
            long returncode = -1;

            try
            {
                ds = new Master_DAL(globalContextDetails).pGetMISReport(OrgID, LocationID, DepartmentID, fromDate, toDate, checkDiff, WCode, WGCode);

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadAnalyte_DAL", e);
            }
            return ds;
        }
        //end
        public DataSet pGetWorkLoadMISReport(long OrgID, long LocationID, int DepartmentID, DateTime fromDate, DateTime toDate, string WorkloadCode)
        {
            DataSet ds = new DataSet();
            long returncode = -1;

            try
            {
                ds = new Master_DAL(globalContextDetails).pGetWorkLoadMISReport(OrgID, LocationID, DepartmentID, fromDate, toDate, WorkloadCode);

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadAnalyte_DAL", e);
            }
            return ds;
        }
      //Alex Starts
	   public long pgetScanIn(int deptId, string Barcode, int SampleType, out List<SampleBatchScanOutDetails> objscanout, out string ReturnValue)
        {
            long returnCode = -1;
            objscanout = null;
            ReturnValue = string.Empty;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.pgetScanIn(deptId, Barcode, SampleType, out objscanout, out ReturnValue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pgetScanInDept Master_BL", ex);
            }
            return returnCode;
        }
		
		 public long ScanOut(string BarcodeNumber, int DDLno, out List<SampleBatchScanOutDetails> scanout, out string BatchNo)
        {
            long returnCode = -1;
            scanout = new List<SampleBatchScanOutDetails>();
            BatchNo = String.Empty;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.ScanOut(BarcodeNumber, DDLno, out scanout, out BatchNo);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing ScanOut Master_BL", ex);
            }
            return returnCode;
        }
		
		 public long GetSampleDetails(string Barcode, long deptId, out List<PatientInvSample> scanout)
        {
            long returnCode = -1;
            scanout = new List<PatientInvSample>();
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.pgetSampleDetailsInSacanInOut(Barcode, deptId, out scanout);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSampleDetails at Master_BL", ex);
            }
            return returnCode;
        }

        public long SRATrackingDetails(string BarcodeNumber, int DeptId, out List<SampleBatchScanOutDetails> scanout)
        {
            long returnCode = -1;
            scanout = new List<SampleBatchScanOutDetails>();
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.SampleTrackingDetails(BarcodeNumber, DeptId, out scanout);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SRATrackingDetails at Master_BL", ex);
            }
            return returnCode;
        }
		
		 public long ScanInHistory(string BarcodeNumber, int deptId, int BarcodeType, out List<SampleBatchScanOutDetails> scanout)
        {
            long returnCode = -1;
            scanout = new List<SampleBatchScanOutDetails>();
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.ScanInHistory(BarcodeNumber, deptId, BarcodeType, out scanout);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing ScanInHistory Master_BL", ex);
            }
            return returnCode;
        }
	  //Alex End


//Emp Intimation
         public long InsertEmployeeEmailSms(int OrgID, int ID, string NotificationType, string NotificationCategory, string Value, long CreatedBy, string EmailType)
         {
             long returnCode = -1;
             Master_DAL invDAL = new Master_DAL(globalContextDetails);

             try
             {
                 returnCode = invDAL.InsertEmployeeEmailSms(OrgID, ID, NotificationType, NotificationCategory, Value, CreatedBy, EmailType);
             }
             catch (Exception excp)
             {
                 CLogger.LogError("Error while executing SaveEmployeeIntimation Master_BL", excp);
             }
             return returnCode;
         }
         /*Employee Intimation*/
         public long GetEmployeeEmailSms(int OrgID, out List<AddressDetails> listCommunication)
         {
             listCommunication = new List<AddressDetails>();
             long returnCode = -1;

             try
             {
                 returnCode = new Master_DAL(globalContextDetails).GetEmployeeEmailSms(OrgID, out listCommunication);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error in BL GetNBCommunication", ex);
             }
             return returnCode;
         }
		 
		 #region Alex Start
		 #region Error Flag Mapping

        public List<DeviceErrorFlags> GetAllErrorFlagInfo(int orgId, int locId)
        {
            List<DeviceErrorFlags> errorMapingItems = new List<DeviceErrorFlags>();

            try
            {
                Master_DAL oMaster_DAL = new Master_DAL(globalContextDetails);
                oMaster_DAL.GetAllErrorFlagInfos(orgId,locId,out errorMapingItems);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting Get All Error FlagMasters  ", ex);
            }

            return errorMapingItems;
        }

        public long GetAllErrorFlagInfoByBarCode(string barcode, out List<DeviceErrorFlags> mappedDevices)
        {
            mappedDevices = new List<DeviceErrorFlags>();

            long returnCode = -1;
            try
            {
                Master_DAL oMaster_DAL = new Master_DAL(globalContextDetails);
                returnCode = oMaster_DAL.GetAllErrorFlagInfosByBarCode(barcode, out mappedDevices);

					//if (errorMapingItems != null)
                    //errorMapingItems = errorMapingItems.FindAll(E => E.IsActive == 1);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in getting Mapped Error Flag Info by BarCode in BL ", ex);
            }

            return returnCode;
        }
        public List<InstrumentInfoErrorFlag> GetAllInstrumenrtInfo_BL(int orgId, int locId)
        {
            List<InstrumentInfoErrorFlag> instrumentInfos = new List<InstrumentInfoErrorFlag>();

            try
            {
                Master_DAL oMaster_DAL = new Master_DAL(globalContextDetails);
                oMaster_DAL.GetAllInstrumentInfo(orgId, locId, out instrumentInfos);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting All Instrument info  ", ex);
            }

            return instrumentInfos;
        }

        public void SaveErrorFlagMapping_BL(int orgId, List<DeviceErrorFlags> errorMapingItems)
        {
            try
            {
                Master_DAL oMaster_DAL = new Master_DAL(globalContextDetails);
                oMaster_DAL.SaveErrorFlagMapping(orgId, errorMapingItems);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting SaveErrorFlagMasters  ", ex);
            }
        }

        #endregion Error Flag Mapping
		
		  public long FetchPageNames(int OrgId, out List<PageContext> lstPageContext)
        {

            long returnCode = -1;
            lstPageContext = null;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.FetchGetPageNames(OrgId, out lstPageContext);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchPageNames Master_BL", ex);
            }
            return returnCode;
        }


        public long FetchPageContext(int OrgId, out List<PageContext> lstPageContext)
        {

            long returnCode = -1;
            lstPageContext = null;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.FetchGetPageContext(OrgId, out lstPageContext);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchPageContext Master_BL", ex);
            }
            return returnCode;
        }


        public long InsertPageContext(int OrgId, PageContext pagecontext)
        {

            long returnCode = -1;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.InsertPageContext(OrgId, pagecontext);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertPageContext Master_BL", ex);
            }
            return returnCode;
        }

        public long DeletePageContextbyId(int Id)
        {
            long returnCode = -1;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.DeletePageContextbyId(Id);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeletePageContextbyId Master_BL", ex);
            }
            return returnCode;
        }

        public List<ActionManagerType> FetchActionManagerType(out List<ActionManagerType> lst)
        {
            long returnCode = -1;
            lst = new List<ActionManagerType>();
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.FetchActionManagerType(out lst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchActionManagerType Master_BL", ex);
            }
            return lst;
        }

        public long InsertActionManagerType(ActionManagerType managertype)
        {
            long returncode = 0;
            try
            {
                Master_DAL masterdal = new Master_DAL(globalContextDetails);
                returncode = masterdal.InsertActionManagerType(managertype);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertActionManagerType Master_BL", ex);
            }
            return returncode;
        }

        public long DeleteActionManagerType(int Id)
        {
            long returncode = 0;
            try
            {
                Master_DAL masterdal = new Master_DAL(globalContextDetails);
                returncode = masterdal.DeleteActionManagerType(Id);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteActionManagerType Master_BL", ex);
            }
            return returncode;
        }

        public List<ActionTemplateType> FetchActionTemplateType(out List<ActionTemplateType> lst)
        {
            long returnCode = -1;
            lst = new List<ActionTemplateType>();
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.FetchActionTemplateType(out lst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchActionTemplateType Master_BL", ex);
            }
            return lst;
        }

        public long InsertActionTemplateType(ActionTemplateType Actiontemplatetype, out int Returnvalue)
        {
            long returncode = 0;
            Returnvalue = 0;
            try
            {
                Master_DAL masterdal = new Master_DAL(globalContextDetails);
                returncode = masterdal.InsertActionTemplateType(Actiontemplatetype, out Returnvalue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertActionManagerType Master_BL", ex);
            }
            return returncode;
        }

        public long DeleteActionTemplateType(int Id)
        {
            long returncode = 0;
            try
            {
                Master_DAL masterdal = new Master_DAL(globalContextDetails);
                returncode = masterdal.DeleteActionTemplateType(Id);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteActionManagerType Master_BL", ex);
            }
            return returncode;
        }

        public List<LanguageMaster> FetchLanguageMaster(out List<LanguageMaster> lst)
        {
            long returnCode = -1;
            lst = new List<LanguageMaster>();
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.FetchLanguageMaster(out lst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchLanguageMaster Master_BL", ex);
            }
            return lst;
        }

        public List<ActionTemplate> FetchActionTemplate(out List<ActionTemplate> lst)
        {
            long returnCode = -1;
            lst = new List<ActionTemplate>();
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.FetchActionTemplate(out lst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchActionTemplate Master_BL", ex);
            }
            return lst;
        }

        public long InsertActionTemplate(ActionTemplate Actiontemplate, out int Returnvalue)
        {
            long returncode = 0;
            Returnvalue = 0;
            try
            {
                Master_DAL masterdal = new Master_DAL(globalContextDetails);
                returncode = masterdal.InsertActionTemplate(Actiontemplate, out Returnvalue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertActionTemplate Master_BL", ex);
            }
            return returncode;
        }

        public long DeleteActionTemplate(int Id)
        {
            long returncode = 0;
            try
            {
                Master_DAL masterdal = new Master_DAL(globalContextDetails);
                returncode = masterdal.DeleteActionTemplate(Id);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteActionTemplate Master_BL", ex);
            }
            return returncode;
        }

        public List<PageContextActionMapping> FetchPageContextActionMapping(out List<PageContextActionMapping> lst)
        {
            long returnCode = -1;
            lst = new List<PageContextActionMapping>();
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.FetchPagecontextActionMapping(out lst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchPageContextActionMapping Master_BL", ex);
            }
            return lst;
        }

        public long InsertPagecontextActionMapping(PageContextActionMapping actionmapping, out int Returnvalue)
        {
            long returncode = 0;
            Returnvalue = 0;
            try
            {
                Master_DAL masterdal = new Master_DAL(globalContextDetails);
                returncode = masterdal.InsertPagecontextActionMapping(actionmapping, out Returnvalue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertPagecontextActionMapping Master_BL", ex);
            }
            return returncode;
        }

        public long DeletePagecontextActionMapping(int Id)
        {
            long returncode = 0;
            try
            {
                Master_DAL masterdal = new Master_DAL(globalContextDetails);
                returncode = masterdal.DeletePagecontextActionMapping(Id);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeletePagecontextActionMapping Master_BL", ex);
            }
            return returncode;
        }
        public long GetPageType(int OrgId, out List<MetaData> lstMetaData)
        {

            long returnCode = -1;
            lstMetaData = null;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.GetPageType(OrgId, out lstMetaData);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchPageNames Master_BL", ex);
            }
            return returnCode;
        }
//added by sudha new -1  PageType 

        public long GetPageLang(out List<LanguageMaster> lstLanguageMaster)
        {

            long returnCode = -1;
            // lstMetaData = null;
            lstLanguageMaster = new List<LanguageMaster>();
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.GetPageLang(out lstLanguageMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchPageNames Master_BL", ex);
            }
            return returnCode;
        }






        //added by sudha2

        public long GetPageStatus(int OrgId, out List<InvSampleStatusmaster> lstInvSampleStatusmaster)
        {

            long returnCode = -1;
            lstInvSampleStatusmaster = null;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.GetPageStatus(OrgId, out lstInvSampleStatusmaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchPageNames Master_BL", ex);
            }
            return returnCode;
        }


        //added by sudha for gridload in dummyPage3
        public long GetIInvStatusOrgPageMapping(int OrgId, out List<InvStatusOrgPageMapping> lstInvStatusOrgPageMapping)
        {

            long returnCode = -1;
            lstInvStatusOrgPageMapping = null;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.GetIInvStatusOrgPageMapping(OrgId, out lstInvStatusOrgPageMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchPageNames Master_BL", ex);
            }
            return returnCode;
        }




        //added by sudha for Insert table in dummyPage4 for insertion

        public long InsertInvStatusOrgPageMapping(InvStatusOrgPageMapping objInvStatusOrgPageMapping, out long returnCode)
        {
            returnCode = -1;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.InsertInvStatusOrgPageMapping(objInvStatusOrgPageMapping, out returnCode);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchPageNames Master_BL", ex);
            }
            return returnCode;
        }


        // added by sudha for Update in dummyPage 5 for updation
        public long UpdateInvStatusOrgPageMapping(InvStatusOrgPageMapping objInvStatusOrgPageMapping, out long returnCode)
        {
            returnCode = -1;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.UpdateInvStatusOrgPageMapping(objInvStatusOrgPageMapping, out returnCode);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchPageNames Master_BL", ex);
            }
            return returnCode;
        }




        // added by sudha for newUpdate button 5-

        public long NewUpdateInvStatusOrgPageMapping(InvStatusOrgPageMapping objInvStatusOrgPageMapping, out long returnCode)
        {
            returnCode = -1;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.NewUpdateInvStatusOrgPageMapping(objInvStatusOrgPageMapping, out returnCode);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchPageNames Master_BL", ex);
            }
            return returnCode;
        }

        // Ended by sudha for newUpdate button




        //added by sudha for deletion of InvStatusOrgPageMapping table  6

        public long DeleteInvStatusOrgPageMapping(int refid, out long returnCode)
        {
            returnCode = -1;
            try
            {
                Master_DAL masterDL = new Master_DAL(globalContextDetails);
                returnCode = masterDL.DeleteInvStatusOrgPageMapping(refid, out returnCode);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FetchPageNames Master_BL", ex);
            }
            return returnCode;
        }
		 #endregion
   //Added by Jegan --Product merge start
        #region Clinical History

        public List<History> GetAllClinicalHistoryItems_BL(int orgId)
        {
            List<History> historyMasterLst = new List<History>();

            try
            {
                Master_DAL oMaster_DAL = new Master_DAL(globalContextDetails);
                oMaster_DAL.GetAllClinicalHistoryItems(orgId, out historyMasterLst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting All ClinicalHistoryItems  ", ex);
            }

            return historyMasterLst;
        }

        public long SaveClinicalHistoryMaster(List<History> historyMstrLst)
        {
            long resultCode = -1;
            try
            {
                Master_DAL oMaster_DAL = new Master_DAL(globalContextDetails);
                resultCode = oMaster_DAL.SaveClinicalHistoryMaster(historyMstrLst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Save Clinical History Master", ex);
            }

            return resultCode;
        }

        public List<InvMedicalDetailsMapping> GetAllHistoryMappingItems(int orgId)
        {
            List<InvMedicalDetailsMapping> historyMappingLst = new List<InvMedicalDetailsMapping>();

            try
            {
                Master_DAL oMaster_DAL = new Master_DAL(globalContextDetails);
                oMaster_DAL.GetAllClinicalHistoryMappingItems(orgId, out historyMappingLst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  getting All ClinicalHistory Mapping Items  ", ex);
            }

            return historyMappingLst;
        }

        public long SaveClinicalHistoryMapping(List<InvMedicalDetailsMapping> historyMappingLst)
        {
            long resultCode = -1;
            try
            {
                Master_DAL oMaster_DAL = new Master_DAL(globalContextDetails);
                resultCode = oMaster_DAL.SaveClinicalHistoryMapping(historyMappingLst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  Save Clinical History Mapping  ", ex);
            }

            return resultCode;
        }

        #endregion Clinical History
        //end
		 public long InsertAnalyzerType(AnalyzerType ObjAnalyzerType, out long returnCode)
        {
            returnCode = -1;
            Master_DAL masterDAL = new Master_DAL(globalContextDetails);

            try
            {
                returnCode = masterDAL.InsertAnalyzerType(ObjAnalyzerType, out  returnCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertAnalyzerType Master_BL", ex);
            }
            return returnCode;
        }
        public long GetAnalyzerType(out List<AnalyzerType> lstAnalyzerType)
        {
            long returnCode = -1;
            lstAnalyzerType = new List<AnalyzerType>();
            Master_DAL invDAL = new Master_DAL(globalContextDetails);

            try
            {
                returnCode = invDAL.GetAnalyzerType(out lstAnalyzerType);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetAnalyzerType Master_BL", excp);
            }
            return returnCode;
        }

//Device Master
 public long GetInstrumentNameDeviceMapping(int orgID, long Analyzertype, out List<InvInstrumentMaster> lstInvInst)
        {
            long returnCode = -1;

            lstInvInst = new List<InvInstrumentMaster>();

            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetInstrumentNameDeviceMapping(orgID, Analyzertype, out lstInvInst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInstrumentName in Master_BL", ex);
            }

            return returnCode;

        }
public long GetProductsIsNotActive(int OrgID, out List<InvInstrumentMaster> lstInvInstrumentMaster)
        {
            long returncode = -1;
            lstInvInstrumentMaster = new List<InvInstrumentMaster>();
            Master_DAL masterdal = new Master_DAL();
            try
            {
                returncode = new Master_DAL(globalContextDetails).GetProductsIsNotActive(OrgID, out lstInvInstrumentMaster);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetProductsIsNotActive Master_DAL", e);
            }
            return returncode;

        }
	 public long SaveQuestionaryTemplate(long TemplateID,string TemplateName,string TemplateText, long InvestigationID, string InvType)
        {
            
            long returncode = -1;

            try
            {
                returncode = new Master_DAL(globalContextDetails).SaveQuestionaryTemplate(TemplateID,TemplateName,TemplateText, InvestigationID, InvType);

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadAnalyte_DAL", e);
            }
            return returncode;
        }
        public long GetAllQuestionaryTemplates(long TemplateID,long InvestigationID, string InvType,string SType,out List<QuestionayTemplateDetails> lstTemplate, out List<QuestionayTemplateDetails> lstTemplateMap)
        {
            lstTemplate = new List<QuestionayTemplateDetails>();
            lstTemplateMap = new List<QuestionayTemplateDetails>(); 

            long returncode = -1;

            try
            {
                returncode = new Master_DAL(globalContextDetails).GetAllQuestionaryTemplates(TemplateID, InvestigationID, InvType, SType, out lstTemplate,out lstTemplateMap);

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadAnalyte_DAL", e);
            }
            return returncode;
        }
		
		 /// <summary>
        /// Get the Action type from Database
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="lstTaskActions"></param>
        /// <returns></returns>
		
	    public long GetActionType(int roleID, out List<ActionManagerType> lstTaskActions)
         {
             long returncode = -1;
             lstTaskActions = new List<ActionManagerType>();

             try
             {
                 returncode = new Master_DAL(globalContextDetails).pGetActionType(roleID, out lstTaskActions);
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while executing pGetActionType Master_DAL", e);
             }
             return returncode;

         }
		 
		 
		     /// <summary>
         /// Get the Notification table Details
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="LabNumber"></param>
        /// <param name="ActionType"></param>
        /// <param name="Status"></param>
        /// <param name="Location"></param>
        /// <param name="ClientName"></param>
        /// <param name="Reason"></param>
        /// <param name="CreatedFromDate"></param>
        /// <param name="CreatedToDate"></param>
        /// <param name="ReportingCenter"></param>
        /// <param name="ReportType"></param>
        /// <param name="Zone"></param>
        /// <param name="startRowIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRows"></param>
        /// <param name="lstNotificationMaster"></param>
        /// <returns>returns a list "lstNotificationMaster"</returns>

         public long GetNotificationDetails(string Name, string LabNumber, string ActionType, string Status, string Location, string ClientName, string Reason, string CreatedFromDate, string CreatedToDate, string ReportingCenter, string ReportType, string Zone, int startRowIndex, int pageSize, out int totalRows, out List<NotificationMaster> lstNotificationMaster)
         {
             long returnCode = -1;
             totalRows = -1;
             lstNotificationMaster = new List<NotificationMaster>();
             try
             {
                 Master_DAL masterDL = new Master_DAL(globalContextDetails);
                 returnCode = masterDL.pgetNotificationDetails(Name, LabNumber, ActionType, Status, Location, ClientName, Reason, CreatedFromDate, CreatedToDate, ReportingCenter, ReportType, Zone, startRowIndex, pageSize, out  totalRows, out lstNotificationMaster);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing GetNotificationDetails Master_BL", ex);
             }
             return returnCode;
         }
		 
		
		    public long UpdateNotificationStatus(List<Notifications> lstNotication)
         {
             long returnCode = -1;
             //lstNotifications = new List<Notifications>();

             try
             {
                 Master_DAL masterDL = new Master_DAL(globalContextDetails);
                 returnCode = masterDL.pUpdateNotificationStatus(lstNotication);
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while executing UpdateNotificationStatus in Master_BL", e);
             }
             return returnCode;

         }

#region DepartmentSequenceNumber

        public long InsertSharedDeptDetails(long DeptID, List<RoleDeptMap> lstDept)
        {
            long returnCode = -1;
            try
            {
                Master_DAL objMasterDAL = new Master_DAL(globalContextDetails);
                returnCode = objMasterDAL.InsertSharedDeptDetails(DeptID, lstDept);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertMapDetails in Role_BL", ex);
            }

            return returnCode;

        }

        public long SaveLocDepUserMap(long DeptID, long LocID, string defaults, long SeqNo, long OrgID, string InsUpdflag, List<RoleDeptMap> allChecked)
        {
            long returnCode = -1;
            try
            {
                Master_DAL MasterDAL = new Master_DAL(globalContextDetails);
                returnCode = MasterDAL.SaveLocDepUserMap(DeptID, LocID, defaults, SeqNo, OrgID, InsUpdflag, allChecked);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL InsertMapDetails", ex);
            }

            return returnCode;

        }

        public long pUpdateSequenceNo(DataTable dt, int OrgID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).pUpdateSequenceNo(dt, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save Department Sequence ", ex);
            }
            return returnCode;
        }


        public long SaveLocationMap(int OrgID, int DeptID, string deptName, string Code, string deptcode, string CDisplay, string ChkPriSep, string AutoScan, string InsUpdfl, long shareable,bool IsClientSMS, List<Role> lstRoleLocation)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Master_DAL(globalContextDetails).SaveLocationMap(OrgID, DeptID, deptName, Code, deptcode, CDisplay, ChkPriSep, AutoScan, InsUpdfl, shareable,IsClientSMS, lstRoleLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing  SaveRoleDeptLocationMap in Patient Visit BL", ex);
            }

            return returnCode;
        }
        public long GetDeptSigSeqMapLog(int OrgID, int DepID, int AddressID, out List<UserSigLocBasedDept> stUsLoDep)
        {
            long returnCode = -1;
            stUsLoDep = new List<UserSigLocBasedDept>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetDeptSigSeqMapLog(OrgID, DepID, AddressID, out stUsLoDep);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get Department ", ex);
            }
            return returnCode;
        }
        public long GetDeptSigSeqMap(int OrgID, out List<UserSigLocBasedDept> stUsLoDep)
        {
            long returnCode = -1;
            stUsLoDep = new List<UserSigLocBasedDept>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetDeptSigSeqMap(OrgID, out stUsLoDep);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get Department ", ex);
            }
            return returnCode;
        }
        public long GetSharedDeptID(int OrgID, long DeptshareID, out List<InvDeptMaster> lstDeptID)
        {
            long returncode = -1;
            lstDeptID = new List<InvDeptMaster>();
            try
            {
                returncode = new Master_DAL(globalContextDetails).GetSharedDeptID(OrgID, DeptshareID, out lstDeptID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In BL GetDeviceInstrumentDetails", ex);
            }
            return returncode;
        }

        public long GetManageDeptDetails(int orgid, out List<InvDeptMaster> lstInvInst)
        {
            long returnCode = -1;

            lstInvInst = new List<InvDeptMaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetManageDeptDetails(orgid, out lstInvInst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In BL GetDeviceInstrumentDetails", ex);
            }

            return returnCode;

        }

        public long GetLocID(long DeptID, int OrgID, out List<OrganizationAddress> lstDeptID)
        {
            long returncode = -1;
            Master_DAL MasterDAL = new Master_DAL(globalContextDetails);
            returncode = MasterDAL.GetLocID(DeptID, OrgID, out lstDeptID);
            return returncode;
        }
        public long GetSharedDept(int orgid, out List<InvDeptMaster> lstInvInst)
        {
            long returnCode = -1;
            lstInvInst = new List<InvDeptMaster>();
            try
            {
                returnCode = new Master_DAL(globalContextDetails).GetSharedDept(orgid, out lstInvInst);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In BL GetDeviceInstrumentDetails", ex);
            }
            return returnCode;
        }

        public long GetLogID(long DeptID, long LocID, int OrgID, out List<Users> lstUse)
        {
            long returncode = -1;
            Master_DAL MasterDAL = new Master_DAL(globalContextDetails);
            returncode = MasterDAL.GetLogID(DeptID, LocID, OrgID, out lstUse);
            return returncode;
        }
        #endregion


    }

}

