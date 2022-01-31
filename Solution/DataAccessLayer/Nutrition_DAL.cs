using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class Nutrition_DAL
    {
        ContextDetails globalContextDetails;
        public Nutrition_DAL()
        {

        }
        public Nutrition_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long PerfomingNutrition(Diet_FoodCategory pFDC)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertUpdateFoodCategoryCommand(pFDC.FoodCategoryID, pFDC.FoodCategoryName, pFDC.Description, pFDC.OrgID, pFDC.CreatedBy, pFDC.CreatedAt, pFDC.ModifiedBy, pFDC.ModifiedAt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PerfomingNutritionDAL", ex);
            }
            return returncode;
        }
        public long GetFoodCategory(int pOrgID, out List<Diet_FoodCategory> DFC)
        {
            long returnCode = -1;
            DFC = new List<Diet_FoodCategory>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetFoodCategoryCommand(pOrgID, "", UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                DFC = new List<Diet_FoodCategory>();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out DFC);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetFoodCategoryCommand", ex);
            }
            return returnCode;
        }
        public long saveIngredient(Diet_FoodIngredients DFI)
        {
            long lresult = -1;
            DataTable dtSpl = new DataTable();

            SqlCommand cmd = Command.pInsertUpdateFoodIngredientsCommand(DFI.FoodIngredientID, DFI.FoodIngredientName, DFI.Description, DFI.OrgID, DFI.CreatedBy, DFI.CreatedAt, DFI.ModifiedBy, DFI.ModifiedAt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing  saveIngredientDAL" + cmd.CommandText, ex);
            }

            return lresult;

        }
        public long GetDietFoodIngredientss(int pOrgID, out List<Diet_FoodIngredients> DFI)
        {
            long returnCode = -1;
            DFI = new List<Diet_FoodIngredients>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetFoodIngredientsCommand(pOrgID, "", UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                DFI = new List<Diet_FoodIngredients>();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out DFI);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetFoodIngredients", ex);
            }
            return returnCode;
        }
        public long SaveFoodList(Diet_FoodList DFL)
        {
            long lresult = -1;
            DataTable dtSpl = new DataTable();


            SqlCommand cmd = Command.pInsertUpdateFoodListCommand(DFL.FoodID, DFL.FoodCategoryID, DFL.FoodName, DFL.Description, DFL.OrgID, DFL.ModifiedAt, DFL.CreatedBy, DFL.CreatedAt, DFL.ModifiedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing  pInsertUpdateFoodListCommand" + cmd.CommandText, ex);
            }

            return lresult;

        }
        public long GetDietFoodList(int pOrgID, out List<Diet_FoodList> DFL)
        {
            long returnCode = -1;
            DFL = new List<Diet_FoodList>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetFoodListCommand(pOrgID, "", UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                DFL = new List<Diet_FoodList>();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out DFL);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetFoodIngredientsCommand", ex);
            }
            return returnCode;
        }
        public long GetCategoryDetails(int pOrgID, string prefixText, out List<Diet_FoodCategory> lstFoodCategory)
        {
            long returnCode = -1;
            lstFoodCategory = new List<Diet_FoodCategory>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetFoodCategoryCommand(pOrgID, prefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFoodCategory);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetFoodCategoryCommand", ex);
            }
            return returnCode;
        }
        //-------------------------------------------FoodSessionMaster-------------------------------------//
        public long InsertUpdateFoodSessionMaster(Diet_FoodSessionMaster objFoodSessionMaster)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertUpdateFoodSessionMasterCommand(objFoodSessionMaster.FoodSessionID, objFoodSessionMaster.FoodSessionName, objFoodSessionMaster.Description, objFoodSessionMaster.FromTime, objFoodSessionMaster.ToTime, objFoodSessionMaster.OrgID, objFoodSessionMaster.CreatedBy, objFoodSessionMaster.CreatedAt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
                CLogger.LogError("Error while executing InsertUpdateFoodSessionMaster in Nutrition_DAL", ex);
            }
            return returnCode;
        }
        public long GetFoodSessionMaster(int OrgID, string str, out List<Diet_FoodSessionMaster> lstFoodSessionMaster)
        {
            long returnCode = -1;
            lstFoodSessionMaster = new List<Diet_FoodSessionMaster>();
            SqlCommand cmd = Command.pGetFoodSessionMasterCommand(OrgID, str, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFoodSessionMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetFoodSessionMaster in Nutrition_DAL", ex);
            }
            return returnCode;
        }
        public long pCheckFoodSessionName(string str, int OrgID)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetFoodSessionMasterCommand(OrgID, str, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count == 1)
                {
                    returnCode = 0;
                }
                else
                {
                    returnCode = -1;
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pCheckFoodSessionName in Nutrition_DAL", ex);
            }
            return returnCode;
        }
        public long pGetMasterFoodSessionName(string prefix, int pOrgID, out List<Diet_FoodSessionMaster> lstFoodSessionMaster)
        {
            long returncode = -1;
            lstFoodSessionMaster = new List<Diet_FoodSessionMaster>();
            SqlCommand cmd = Command.pGetFoodSessionMasterCommand(pOrgID, prefix, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstFoodSessionMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetMasterFoodSessionName in Nutrition_DAL", ex);
            }
            return returncode;
        }


        //-----------------------------------------------------------------------------------------------------------------//


        //FoodMenuMaster//


        //-----------------------------------------------------------------------------------------------------------------//



        public long InsertUpdateFoodMenuMaster(Diet_FoodMenuMaster objFoodMenuMaster)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertUpdateFoodMenuMasterCommand(objFoodMenuMaster.FoodMenuID, objFoodMenuMaster.FoodMenuName, objFoodMenuMaster.Description, objFoodMenuMaster.OrgID, objFoodMenuMaster.CreatedBy, objFoodMenuMaster.CreatedAt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
                CLogger.LogError("Error while executing InsertUpdateFoodMenuMaster in Nutrition_DAL", ex);
            }
            return returnCode;
        }
        public long GetFoodMenuMaster(int OrgID, string str, out List<Diet_FoodMenuMaster> lstFoodMenuMaster)
        {
            long returnCode = -1;
            lstFoodMenuMaster = new List<Diet_FoodMenuMaster>();
            SqlCommand cmd = Command.pGetFoodMenuMasterCommand(OrgID, str, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFoodMenuMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetFoodMenuMaster in Nutrition_DAL", ex);
            }
            return returnCode;
        }
        public long pCheckFoodMasterName(string str, int OrgID)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetFoodMenuMasterCommand(OrgID, str, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count == 1)
                {
                    returnCode = 0;
                }
                else
                {
                    returnCode = -1;
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pCheckFoodMasterName in Nutrition_DAL", ex);
            }
            return returnCode;
        }
        public long pGetMasterFoodMenuName(string prefix, int pOrgID, out List<Diet_FoodMenuMaster> lstFoodMenuMaster)
        {
            long returncode = -1;
            lstFoodMenuMaster = new List<Diet_FoodMenuMaster>();
            SqlCommand cmd = Command.pGetFoodMenuMasterCommand(pOrgID, prefix, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstFoodMenuMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetMasterFoodMenuName in Nutrition_DAL", ex);
            }
            return returncode;
        }


        //----------------------------------------------------------------------------------------------//

        //FoodmenuWardMapping
        public long LoadFoodWardMenuMapping(Diet_FoodMenuWardMapping objFoodMenuWardMapping)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pInsertUpdateFoodMenuWardMappingCommand(objFoodMenuWardMapping.FoodMenuWardMapping, objFoodMenuWardMapping.FoodMenuID, objFoodMenuWardMapping.WardID, objFoodMenuWardMapping.RoomTypeID, objFoodMenuWardMapping.OrgID, objFoodMenuWardMapping.CreatedBy, objFoodMenuWardMapping.CreatedAt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                cmd.Parameters.Add("@ReturnStatus", SqlDbType.BigInt);
                cmd.Parameters["@ReturnStatus"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@ReturnStatus"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL LoadFoodMenuWardMapping", ex);
            }

            return returnCode;
        }
        public long pGetFoodMenuWardMapping(int pOrgID, out List<Diet_FoodMenuWardMapping> lstDiet_FoodMenuWardMapping)
        {

            long returncode = -1;
            lstDiet_FoodMenuWardMapping = new List<Diet_FoodMenuWardMapping>();
            SqlCommand cmd = Command.ploadFoodMenuWardMappingCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstDiet_FoodMenuWardMapping);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing ploadFoodMenuWardMapping in Nutrition_DAL", ex);
            }
            return returncode;

        }

        public long GetMenuDetails(long orgid, out List<Diet_FoodMenuMaster> lstFoodMenuMaster)
        {
            long returnCode = -1;
            lstFoodMenuMaster = new List<Diet_FoodMenuMaster>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetMenuDetailsCommand(orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFoodMenuMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetMenuDetails", ex);
            }

            return returnCode;
        }


        public long GetFoodDetails(long orgid, out List<Diet_FoodSessionMaster> lstFoodSessionMaster)
        {
            long returnCode = -1;
            lstFoodSessionMaster = new List<Diet_FoodSessionMaster>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetFoodDetailsCommand(orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFoodSessionMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetFoodDetails", ex);
            }

            return returnCode;
        }


        public long GetFoodList(long orgid, long FoodMenuID, long FoodSessionID, out List<Diet_FoodList> lstFoodList)
        {
            long returnCode = -1;
            lstFoodList = new List<Diet_FoodList>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetDietFoodListCommand(orgid, FoodMenuID, FoodSessionID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFoodList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetFoodList nutrition", ex);
            }

            return returnCode;
        }


        public long SaveFoodList(List<Diet_PatientDietPlanMaster> lstPatientDietPlanMaster)
        {
            long returnCode = -1;
            try
            {
                DataTable dtPatientDietPlanMaster = UDT_DAL.ConvertToPatientDietPlanMaster(lstPatientDietPlanMaster);
                SqlCommand cmdInsertFoodDetails = Command.pInsertFoodListCommand(dtPatientDietPlanMaster, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (TransactionScope tranScope = new TransactionScope())
                {
                    try
                    {
                        using (DBEngine dbEngine = new DBEngine(true))
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdInsertFoodDetails);
                            returnCode = 0;
                        }
                        tranScope.Complete();
                    }
                    catch (Exception ex)
                    {
                        CLogger.LogError("Error while saving food details nuturition. Query: " + cmdInsertFoodDetails.CommandText, ex);
                        tranScope.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveFoodList nutrition", ex);
            }
            return returnCode;
        }

        public long GetSessionAndWard(long orgid, out List<Diet_FoodSessionMaster> lstFoodSessionMaster, out List<WardMaster> lstWardMaster)
        {
            long returnCode = -1;
            lstFoodSessionMaster = new List<Diet_FoodSessionMaster>();
            lstWardMaster = new List<WardMaster>();

            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetSessionAndWardDetailsCommand(orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFoodSessionMaster);
                    Utilities.ConvertTo(ds.Tables[1], out lstWardMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetSessionAndWard nutrition", ex);
            }

            return returnCode;
        }


        public long GetFoodOrderedDetails(long orgid, long foodsessionID, long wardID, string CurrentStatus, out int TotalRows, int PageSize, int PageNumber, out List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            TotalRows = 0;
            lstFoodOrderedDetails = new List<FoodOrderedDetails>();
            DataSet ds = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = Command.pGetFoodOrderedDetailsCommand(orgid, foodsessionID, wardID, CurrentStatus, PageNumber, PageSize, out TotalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    TotalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    //TotalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
                    Utilities.ConvertTo(ds.Tables[0], out lstFoodOrderedDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetSessionAndWard nutrition", ex);
            }

            return returnCode;
        }


        public long SaveFoodOrderedList(long orgID, long createdBy, List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            try
            {
                DataTable dtFoodOrderedDetails = UDT_DAL.ConvertToFoodOrderedDetails(lstFoodOrderedDetails);
                SqlCommand cmdFoodOrderedDetails = Command.pInsertFoodOrderedListCommand(orgID, createdBy, dtFoodOrderedDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (TransactionScope tranScope = new TransactionScope())
                {
                    try
                    {
                        using (DBEngine dbEngine = new DBEngine(true))
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdFoodOrderedDetails);
                            returnCode = 0;
                        }
                        tranScope.Complete();
                    }
                    catch (Exception ex)
                    {
                        CLogger.LogError("Error while saving food Ordered details nuturition. Query: " + cmdFoodOrderedDetails.CommandText, ex);
                        tranScope.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveFoodOrderedList nutrition", ex);
            }
            return returnCode;
        }



        public long GetFoodDeliveredDetails(long orgid, string CurrentStatus, long SessionID, long WardID, int pageSize, int pageNo, out int totalRows, out List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            lstFoodOrderedDetails = new List<FoodOrderedDetails>();
            totalRows = 0;
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetFoodDeliveredDetailsCommand(orgid, CurrentStatus, SessionID, WardID, pageSize, pageNo, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    Utilities.ConvertTo(ds.Tables[0], out lstFoodOrderedDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetFoodDeliveredDetails nutrition", ex);
            }

            return returnCode;
        }


        public long UpdateFoodDeliveredDetails(long orgID, long ModifiedBY, List<Diet_FoodOrderMaster> lstDiet_FoodOrderMaster, string CurrentStatus, string SetStatus)
        {
            long returnCode = -1;
            try
            {
                DataTable dtFoodDeliveredDetails = UDT_DAL.ConvertToFoodDeliveredDetails(lstDiet_FoodOrderMaster);
                SqlCommand cmdFoodDeliveredDetails = Command.pUpdateFoodDeliveredDetailsCommand(orgID, ModifiedBY, dtFoodDeliveredDetails, CurrentStatus, SetStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (TransactionScope tranScope = new TransactionScope())
                {
                    try
                    {
                        using (DBEngine dbEngine = new DBEngine(true))
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdFoodDeliveredDetails);
                            returnCode = 0;
                        }
                        tranScope.Complete();
                    }
                    catch (Exception ex)
                    {
                        CLogger.LogError("Error while saving food Ordered details nuturition. Query: " + cmdFoodDeliveredDetails.CommandText, ex);
                        tranScope.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveFoodOrderedList nutrition", ex);
            }
            return returnCode;
        }


        public long GetCompletedFoodDetails(long orgid, string OrderStatus,int pageSize,int pageNumber,out int totalRows, out List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            lstFoodOrderedDetails = new List<FoodOrderedDetails>();
            totalRows = 0;

            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetCompletedFoodDetailsCommand(orgid, OrderStatus, pageSize, pageNumber, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    Utilities.ConvertTo(ds.Tables[0], out lstFoodOrderedDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetCompletedFoodDetails nutrition", ex);
            }

            return returnCode;
        }

        public long GetOrderedFoodDetails(long orgid, string CurrentStatus, long VisitID, out List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            lstFoodOrderedDetails = new List<FoodOrderedDetails>();

            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetOrderedFoodDetailsCommand(orgid, CurrentStatus, VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFoodOrderedDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetFoodOrderedDetails nutrition", ex);
            }

            return returnCode;
        }


        public long DeleteOrderedFoodDetails(long orgid, long PatientDietPlanID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pDeleteOrderedFoodDetailsCommand(orgid, PatientDietPlanID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DeleteOrderedFoodDetails nutrition", ex);
            }
            return returnCode;
        }

        //-----------------------Food Detail Mapping-----------------------------------------------------------------------//
        public long GetAllFoodDetails(int OrgID, out List<Diet_FoodMenuDetails> FoodMenuDetails)
        {
            long returnCode = -1;
            FoodMenuDetails = new List<Diet_FoodMenuDetails>();
            SqlCommand cmd = Command.pGetAllFoodMenuDetailsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out FoodMenuDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllFoodDetails in Nutrition_DAL", ex);
            }
            return returnCode;
        }

        public long SaveFoodMenuDetails(int OrgID, int LID, Diet_FoodMenuDetails objDiet_FoodMenuDetails)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertFoodMenuDetailsCommand(Convert.ToInt32(objDiet_FoodMenuDetails.FoodMenuDetailID), Convert.ToInt32(objDiet_FoodMenuDetails.FoodMenuID), Convert.ToInt32(objDiet_FoodMenuDetails.FoodID), Convert.ToInt32(objDiet_FoodMenuDetails.FoodSessionID), objDiet_FoodMenuDetails.Quantity, objDiet_FoodMenuDetails.UOM, OrgID, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
                CLogger.LogError("Error while executing SaveFoodMenuDetails in Nutrition_DAL", ex);
            }
            return returnCode;
        }
        public long GetAllFoodsessionMaster(string PrefixText,int OrgID, out List<Diet_FoodSessionMaster> Diet_FoodSessionMaster)
        {
            long returnCode = -1;
            Diet_FoodSessionMaster = new List<Diet_FoodSessionMaster>();
            SqlCommand cmd = Command.PGetFoodSessionMasterDetailsCommand(PrefixText, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out Diet_FoodSessionMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllFoodSession in Nutrition_DAL", ex);
            }
            return returnCode;
        }
        public long GetAllFoodMenuMaster(string PrefixText,int OrgID, out List<Diet_FoodMenuMaster> Diet_FoodMenuMaster)
        {
            long returnCode = -1;
            Diet_FoodMenuMaster = new List<Diet_FoodMenuMaster>();
            SqlCommand cmd = Command.PGetFoodMenuMasterDetailsCommand(PrefixText,OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out Diet_FoodMenuMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllFoodMenuMaster in Nutrition_DAL", ex);
            }
            return returnCode;
        }
        public long GetAllFoodList(string PrefixText,int OrgID, out List<Diet_FoodList> Diet_FoodList)
        {
            long returnCode = -1;
            Diet_FoodList = new List<Diet_FoodList>();
            SqlCommand cmd = Command.pGetFoodMenuDetailsListCommand( PrefixText,OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out Diet_FoodList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllFoodList in Nutrition_DAL", ex);
            }
            return returnCode;
        }

        public long GetUomList(out List<UOM> Uom)
        {
            long returnCode = -1;
            Uom = new List<UOM>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetUOMCodeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out Uom);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetUomlist in Nutrition_DAL", ex);
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


        /// <summary>
        /// Food Ingredient Mapping 
        /// </summary>
        /// <param name="objFoodList"></param>
        /// <param name="objFoodIngredients"></param>
        /// <param name="objFoodIngredientsMapping"></param>
        /// <returns></returns>
        ///              
        public long pGetFoodIngredientName(string prefix, int pOrgID, out List<Diet_FoodIngredients> lstFoodMenuMaster)
        {
            long returncode = -1;
            lstFoodMenuMaster = new List<Diet_FoodIngredients>();
            SqlCommand cmd = Command.pGetFoodIngredientNameCommand(prefix, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstFoodMenuMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetFoodIngredientName in Nutrition_DAL", ex);
            }
            return returncode;
        }
        public long SaveFoodMapping(int FoodId, int OrgID, List<Diet_FoodIngredientsMapping> Diet_FoodIngredientsMapping)
        {
            long returnCode = -1;
            try
            {

                DataTable dtDiet_FoodIngredientsMapping = UDT_DAL.ConvertToDiet_FoodIngredientsMapping(Diet_FoodIngredientsMapping);
                SqlCommand cmd = Command.pInsertFoodIngredientsMappingCommand(FoodId, OrgID, dtDiet_FoodIngredientsMapping, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@ret", SqlDbType.Int);
                cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@ret"].Value);


                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveFoodMapping in Nutrition_DAL", ex);
            }
            return returnCode;
        }
        public long GetAllFoodIngredientsMappingList(int OrgID, out List<Diet_FoodIngredientsMapping> Diet_FoodIngredientsMapping)
        {
            long returnCode = -1;
            Diet_FoodIngredientsMapping = new List<Diet_FoodIngredientsMapping>();
            SqlCommand cmd = Command.PGetFoodIngredientsMappingCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out Diet_FoodIngredientsMapping);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetFoodIngredientsMappingList in Nutrition_DAL", ex);
            }
            return returnCode;
        }


        public long GetAllFoodOrderedDetails(long orgid, long foodsessionID, long wardID, string CurrentStatus, long LID, DateTime FoodOrderDate, out List<FoodOrderedDetails> lstFoodOrderedDetails)
        {
            long returnCode = -1;
            lstFoodOrderedDetails = new List<FoodOrderedDetails>();
            DataSet ds = new DataSet();
            SqlCommand cmd;
            try
            {
                cmd = Command.pGetAllFoodOrderedDetailsCommand(orgid, foodsessionID, wardID, CurrentStatus, LID, FoodOrderDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFoodOrderedDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetAllFoodOrderedDetails nutrition", ex);
            }

            return returnCode;
        }
    }


}
