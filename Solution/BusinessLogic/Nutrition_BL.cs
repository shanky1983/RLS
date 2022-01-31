using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class Nutrition_BL
    {
        ContextDetails globalContextDetails;
        public Nutrition_BL()
        {

        }
        public Nutrition_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long PerfomingNutrition(Diet_FoodCategory pGBM)
        {
            long returncode = -1;
            try
            {
                returncode = new Nutrition_DAL(globalContextDetails).PerfomingNutrition(pGBM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL Master", ex);
            }
            return returncode;

        }
        public long GetDietFoodCategory(int pOrgID, out List<Diet_FoodCategory> DFC)
        {
            long returnCode = -1;
            DFC = new List<Diet_FoodCategory>();

            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetFoodCategory(pOrgID, out DFC);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCasuality", ex);
            }
            return returnCode;
        }
        public long GetFoodCategory(int pOrgID, string prefixText, out List<Diet_FoodCategory> lstFoodCategory)
        {

            lstFoodCategory = new List<Diet_FoodCategory>();
            long returnCode = -1;
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetCategoryDetails(pOrgID, prefixText, out lstFoodCategory);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in ClientRateMaster  ", ex);
            }
            return returnCode;
        }
        public long PerfomingIngredient(Diet_FoodIngredients DFI)
        {
            long returnCode = -1;

            try
            {

                Attune.Solution.DAL.Nutrition_DAL nutritionDAL = new Nutrition_DAL(globalContextDetails);
                returnCode = nutritionDAL.saveIngredient(DFI);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing PerfomingPhysician BL", excp);
            }

            return returnCode;
        }
        public long GetDietFoodIngredients(int pOrgID, out List<Diet_FoodIngredients> DFI)
        {
            long returnCode = -1;
            DFI = new List<Diet_FoodIngredients>();

            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetDietFoodIngredientss(pOrgID, out DFI);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCasuality", ex);
            }
            return returnCode;
        }
        public long SaveFoodList(Diet_FoodList pDFI)
        {
            long returncode = -1;
            try
            {
                returncode = new Nutrition_DAL(globalContextDetails).SaveFoodList(pDFI);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL Master", ex);
            }
            return returncode;

        }
        public long GetDietFoodList(int pOrgID, out List<Diet_FoodList> DFL)
        {
            long returnCode = -1;
            DFL = new List<Diet_FoodList>();

            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetDietFoodList(pOrgID, out DFL);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCasuality", ex);
            }
            return returnCode;
        }
        //------------------------------FoodSeesionMaster----------------------------------------//


        public long InsertUpdateFoodSessionMaster(Diet_FoodSessionMaster objFoodSessionMaster)
        {
            Nutrition_DAL nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            long returnCode = -1;

            try
            {
                returnCode = nutrition_DAL.InsertUpdateFoodSessionMaster(objFoodSessionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertUpdateFoodSessionMaster in Nutrition_BL", ex);
            }
            return returnCode;
        }
        public long GetFoodSessionMaster(int OrgID, string str, out List<Diet_FoodSessionMaster> lstFoodSessionMaster)
        {
            long returnCode = -1;
            Nutrition_DAL nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            lstFoodSessionMaster = new List<Diet_FoodSessionMaster>();

            try
            {
                returnCode = nutrition_DAL.GetFoodSessionMaster(OrgID, str, out lstFoodSessionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing FoodSessionMaster in Nutrition_BL", ex);
            }
            return returnCode;
        }
        public long pCheckFoodSessionName(string str, int OrgID)
        {
            long returnCode = -1;
            Nutrition_DAL nutrition_DAL = new Nutrition_DAL(globalContextDetails);

            try
            {
                returnCode = nutrition_DAL.pCheckFoodSessionName(str, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pCheckFoodSessionName in Nutrition_BL", ex);
            }
            return returnCode;
        }
        public long pGetMasterFoodSessionName(string prefix, int pOrgID, out List<Diet_FoodSessionMaster> lstFoodSessionMaster)
        {
            long returnCode = -1;
            lstFoodSessionMaster = new List<Diet_FoodSessionMaster>();
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            try
            {
                returnCode = Nutrition_DAL.pGetMasterFoodSessionName(prefix, pOrgID, out lstFoodSessionMaster);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetMasterFoodSessionName in Nutrition_BL", ex);
            }
            return returnCode;
        }
        //---------------------------------------------------------------------------------------------------------------//


        //FoodMenuName//

        //---------------------------------------------------------------------------------------------------------------//
        public long InsertUpdateFoodMenuMaster(Diet_FoodMenuMaster lstFoodMenuMaster)
        {
            Nutrition_DAL nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            long returnCode = -1;

            try
            {
                returnCode = nutrition_DAL.InsertUpdateFoodMenuMaster(lstFoodMenuMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertUpdateFoodMenuMaster in Nutrition_BL", ex);
            }
            return returnCode;
        }
        public long GetFoodMenuMaster(int OrgID, string str, out List<Diet_FoodMenuMaster> lstFoodMenuMaster)
        {
            long returnCode = -1;
            Nutrition_DAL nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            lstFoodMenuMaster = new List<Diet_FoodMenuMaster>();

            try
            {
                returnCode = nutrition_DAL.GetFoodMenuMaster(OrgID, str, out lstFoodMenuMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetFoodMenuMaster in Nutrition_BL", ex);
            }
            return returnCode;
        }
        public long pCheckFoodMasterName(string str, int OrgID)
        {
            long returnCode = -1;
            Nutrition_DAL nutrition_DAL = new Nutrition_DAL(globalContextDetails);

            try
            {
                returnCode = nutrition_DAL.pCheckFoodMasterName(str, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pCheckFoodMasterName in Nutrition_BL", ex);
            }
            return returnCode;
        }
        public long pGetMasterFoodMenuName(string prefix, int pOrgID, out List<Diet_FoodMenuMaster> lstFoodMenuMaster)
        {
            long returnCode = -1;
            lstFoodMenuMaster = new List<Diet_FoodMenuMaster>();
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            try
            {

                returnCode = Nutrition_DAL.pGetMasterFoodMenuName(prefix, pOrgID, out lstFoodMenuMaster);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetMasterFoodMenuName in Nutrition_BL", ex);
            }
            return returnCode;
        }
        //-----------------------------------------------------------------------------------------------//

        public long GetFoodMenuWardMapping(Diet_FoodMenuWardMapping lstFoodMenuWardMapping)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).LoadFoodWardMenuMapping(lstFoodMenuWardMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetFoodMenuWardMapping", ex);
            }
            return returnCode;
        }
        public long pGetFoodMenuWardMapping(int pOrgID, out  List<Diet_FoodMenuWardMapping> lstDiet_FoodMenuWardMapping)
        {
            long returnCode = -1;
            lstDiet_FoodMenuWardMapping = new List<Diet_FoodMenuWardMapping>();
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);

            try
            {
                returnCode = Nutrition_DAL.pGetFoodMenuWardMapping(pOrgID, out lstDiet_FoodMenuWardMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductList in Inventory_BL", ex);
            }
            return returnCode;
        }


        public long GetMenuDetails(long orgid, out List<Diet_FoodMenuMaster> lstFoodMenuMaster)
        {
            long returnCode = -1;
            lstFoodMenuMaster = new List<Diet_FoodMenuMaster>();
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetMenuDetails(orgid, out lstFoodMenuMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetMenuDetails nutrition", ex);
            }
            return returnCode;
        }


        public long GetFoodDetails(long orgid, out List<Diet_FoodSessionMaster> lstFoodSessionMaster)
        {
            long returnCode = -1;
            lstFoodSessionMaster = new List<Diet_FoodSessionMaster>();
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetFoodDetails(orgid, out lstFoodSessionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetFoodDetails nutrition", ex);
            }
            return returnCode;
        }


        public long GetFoodList(long orgid, long FoodMenuID, long FoodSessionID, out List<Diet_FoodList> lstFoodList)
        {
            long returnCode = -1;
            lstFoodList = new List<Diet_FoodList>();
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetFoodList(orgid, FoodMenuID, FoodSessionID, out lstFoodList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetFoodList nutrition", ex);
            }
            return returnCode;
        }


        public long SaveFoodList(List<Diet_PatientDietPlanMaster> lstPatientDietPlanMaster)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).SaveFoodList(lstPatientDietPlanMaster);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL SaveFoodList nutrition", ex);
            }
            return returnCode;
        }



        public long GetSessionAndWard(long orgid, out List<Diet_FoodSessionMaster> lstFoodSessionMaster, out List<WardMaster> lstWardMaster)
        {
            long returnCode = -1;
            lstFoodSessionMaster = new List<Diet_FoodSessionMaster>();
            lstWardMaster = new List<WardMaster>();
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetSessionAndWard(orgid, out lstFoodSessionMaster, out lstWardMaster);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetSessionAndWard nutrition", ex);
            }
            return returnCode;
        }


        public long GetFoodOrderedDetails(long orgid, long foodsessionID, long wardID, string CurrentStatus, out int TotalRows, int PageSize, int PageNumber, out List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            TotalRows = 0;
            lstFoodOrderedDetails = new List<FoodOrderedDetails>();
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetFoodOrderedDetails(orgid, foodsessionID, wardID, CurrentStatus, out TotalRows, PageSize, PageNumber, out lstFoodOrderedDetails);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetSessionAndWard nutrition", ex);
            }
            return returnCode;
        }


        public long SaveFoodOrderedList(long orgID, long createdBy, List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).SaveFoodOrderedList(orgID, createdBy, lstFoodOrderedDetails);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL SaveFoodList nutrition", ex);
            }
            return returnCode;
        }


        public long GetFoodDeliveredDetails(long orgid,string CurrentStatus, long SessionID, long WardID, int pageSize,int pageNo,out int totalRows, out List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            totalRows = 0;
            lstFoodOrderedDetails = new List<FoodOrderedDetails>();
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetFoodDeliveredDetails(orgid, CurrentStatus, SessionID, WardID, pageSize, pageNo, out totalRows, out lstFoodOrderedDetails);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetFoodDeliveredDetails nutrition", ex);
            }
            return returnCode;
        }


        public long UpdateFoodDeliveredDetails(long orgID, long ModifiedBY, List<Diet_FoodOrderMaster> lstDiet_FoodOrderMaster, string CurrentStatus, string SetStatus)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).UpdateFoodDeliveredDetails(orgID, ModifiedBY, lstDiet_FoodOrderMaster, CurrentStatus, SetStatus);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL SaveFoodList nutrition", ex);
            }
            return returnCode;
        }


        public long GetCompletedFoodDetails(long orgid, string OrderStatus, int pageSize, int pageNumber, out int totalRows, out List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            totalRows = 0;
            lstFoodOrderedDetails = new List<FoodOrderedDetails>();
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetCompletedFoodDetails(orgid, OrderStatus, pageSize, pageNumber, out totalRows, out lstFoodOrderedDetails);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCompletedFoodDetails nutrition", ex);
            }
            return returnCode;
        }


        public long GetOrderedFoodDetails(long orgid, string CurrentStatus, long VisitID, out List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            lstFoodOrderedDetails = new List<FoodOrderedDetails>();
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).GetOrderedFoodDetails(orgid, CurrentStatus, VisitID, out lstFoodOrderedDetails);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCompletedFoodDetails nutrition", ex);
            }
            return returnCode;
        }


        public long DeleteOrderedFoodDetails(long orgid, long PatientDietPlanID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).DeleteOrderedFoodDetails(orgid, PatientDietPlanID);
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL DeleteOrderedFoodDetails nutrition", ex);
            }
            return returnCode;
        }

        //----------------------------Food Detail Mapping-------------------------------------------------------------------//

        public long GetAllFoodDetails(int OrgID, out List<Diet_FoodMenuDetails> FootMenuDetails)
        {
            long returnCode = -1;
            FootMenuDetails = new List<Diet_FoodMenuDetails>();
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            try
            {
                returnCode = Nutrition_DAL.GetAllFoodDetails(OrgID, out FootMenuDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllFoodDetails in Nutrition_BL", ex);
            }
            return returnCode;
        }

        public long SaveFoodMenuDetails(int OrgID, int LID, Diet_FoodMenuDetails objDiet_FoodMenuDetails)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Nutrition_DAL(globalContextDetails).SaveFoodMenuDetails(OrgID, LID, objDiet_FoodMenuDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveFoodMenuDetails in Nutrition_BL", ex);
            }
            return returnCode;
        }
        public long GetAllFoodsessionMaster(string PrefixText,int OrgID, out List<Diet_FoodSessionMaster> Diet_FoodSessionMaster)
        {
            long returnCode = -1;
            Diet_FoodSessionMaster = new List<Diet_FoodSessionMaster>();
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            try
            {
                returnCode = Nutrition_DAL.GetAllFoodsessionMaster(PrefixText,OrgID, out Diet_FoodSessionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllFoodSessionDetails in Nutrition_BL", ex);
            }
            return returnCode;
        }
        public long GetAllFoodMenuMaster(string PrefixText,int OrgID, out List<Diet_FoodMenuMaster> Diet_FoodMenuMaster)
        {
            long returnCode = -1;
            Diet_FoodMenuMaster = new List<Diet_FoodMenuMaster>();
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            try
            {
                returnCode = Nutrition_DAL.GetAllFoodMenuMaster(PrefixText, OrgID, out Diet_FoodMenuMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllFoodMenuDetails in Nutrition_BL", ex);
            }
            return returnCode;
        }
        public long GetAllFoodList(string PrefixText,int OrgID, out List<Diet_FoodList> Diet_FoodList)
        {
            long returnCode = -1;
            Diet_FoodList = new List<Diet_FoodList>();
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            try
            {
                returnCode = Nutrition_DAL.GetAllFoodList(PrefixText,OrgID, out Diet_FoodList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllFoodList in Nutrition_BL", ex);
            }
            return returnCode;
        }
        public long GetUomList(out List<UOM> Uom)
        {
            long returnCode = -1;
            Uom = new List<UOM>();
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            try
            {
                returnCode = Nutrition_DAL.GetUomList(out Uom);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetUomList in Nutrition_BL", ex);
            }
            return returnCode;
        }

        /// <summary>
        /// Food Mapping BL
        /// </summary>
        /// <param name="objFoodList"></param>
        /// <param name="objFoodIngredients"></param>
        /// <param name="objFoodIngredientsMapping"></param>
        /// <returns></returns>            

        public long pGetFoodIngredientName(string prefix, int pOrgID, out List<Diet_FoodIngredients> lstFoodMenuMaster)
        {
            long returnCode = -1;
            lstFoodMenuMaster = new List<Diet_FoodIngredients>();
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            try
            {

                returnCode = Nutrition_DAL.pGetFoodIngredientName(prefix, pOrgID, out lstFoodMenuMaster);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetFoodIngredientName in Nutrition_BL", ex);
            }
            return returnCode;
        }

        public long SaveFoodMapping(int FoodId, int OrgID, List<Diet_FoodIngredientsMapping> Diet_FoodIngredientsMapping)
        {
            long returnCode = -1;
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            //  Diet_FoodIngredientsMapping = new List<Diet_FoodIngredientsMapping>();

            try
            {
                returnCode = Nutrition_DAL.SaveFoodMapping(FoodId, OrgID, Diet_FoodIngredientsMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetFoodMenuMapping in Nutrition_BL", ex);
            }
            return returnCode;
        }

        public long GetAllFoodIngredientsMappingList(int OrgID, out List<Diet_FoodIngredientsMapping> Diet_FoodIngredientsMapping)
        {
            long returnCode = -1;
            Diet_FoodIngredientsMapping = new List<Diet_FoodIngredientsMapping>();
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            try
            {
                returnCode = Nutrition_DAL.GetAllFoodIngredientsMappingList(OrgID, out Diet_FoodIngredientsMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllFoodIngredientsMappingList in Nutrition_BL", ex);
            }
            return returnCode;
        }


        public long GetAllFoodOrderedDetails(long orgid, long foodsessionID, long wardID, string CurrentStatus, long LID, DateTime FoodOrderDate, out List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            lstFoodOrderedDetails = new List<FoodOrderedDetails>();
            Nutrition_DAL Nutrition_DAL = new Nutrition_DAL(globalContextDetails);
            try
            {
                returnCode = Nutrition_DAL.GetAllFoodOrderedDetails(orgid, foodsessionID, wardID, CurrentStatus, LID, FoodOrderDate, out lstFoodOrderedDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllFoodOrderedDetails in Nutrition_BL", ex);
            }
            return returnCode;
        }




    }
}
