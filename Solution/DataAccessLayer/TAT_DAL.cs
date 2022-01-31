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
using System.IO;
using System.Text;
using System.Collections.Specialized;
using System.Collections;
using Attune.Solution.DAL;


namespace Attune.Solution.DAL
{
    public class TAT_DAL
    {
        ContextDetails globalContextDetails;
        public TAT_DAL()
        {
        }
        public TAT_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        //Change dataset to datareader made by syed
        public long LoadMetaDataOrgMappingTAT(List<MetaData> lstDomain, long OrgID, string LangCode, out NameValueCollection objectcollection)
        {
            long returnCode = -1;
            objectcollection = new NameValueCollection();
            IDataReader dataReader = null;
            try
            {
                DataTable dtMetaData = UDT_DAL.ConvertToUDTMetaData(lstDomain);
                SqlCommand cmd = Command.pLoadMetaDataOrgMappingTATCommand(dtMetaData, OrgID, LangCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out objectcollection);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While loading MetadataOrg Mapping", ex);
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
        public long GetTATSchedulecode(int OrgID, string PrefixText, out List<TATSchedule> lstTATSchedulecode)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTATSchedulecode = new List<TATSchedule>();
            try
            {
                SqlCommand cmd = Command.pGetTATSchedulecodeCommand(OrgID, PrefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTATSchedulecode);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetTATSchedulecode() in MasterDAL", ex);
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

        public long GetTATSchedulecategoryItem(int OrgID, string PrefixText, string SearchType, out List<TATCodingScheme> lstTATSchedulecategoryItem)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTATSchedulecategoryItem = new List<TATCodingScheme>();
            try
            {

                SqlCommand cmd = Command.pGetTATSchedulecategoryItemCommand(OrgID, PrefixText, SearchType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTATSchedulecategoryItem);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetTATSchedulecategoryItem() in MasterDAL", ex);
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


        public long getCategoryTestname(int OrgID, string PrefixText, string SearchType, int ItemID, int ConfigID, out List<TATCodingScheme> lstLoadCategoryTestname)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstLoadCategoryTestname = new List<TATCodingScheme>();
            try
            {
                SqlCommand cmd = Command.pLoadCategoryTestnameCommand(OrgID, PrefixText, SearchType, ItemID, ConfigID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLoadCategoryTestname);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading LoadCategoryTestname() in MasterDAL", ex);
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

        public long SaveTestforTAT(List<Tatschedulemapping> lstTATAdded)
        {
            long lstresult = -1;
            SqlCommand cmdSaveTestforTAT = Command.PSaveTestforTATCommand(UDT_DAL.ConvertToUDTTatschedulemapping(lstTATAdded), UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lstresult = dbEngine.ExecuteNonQuery(cmdSaveTestforTAT);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving SaveTestforTAT. Query: " + cmdSaveTestforTAT.CommandText, ex);
            }
            return lstresult;
        }


        public long DeleteTestforTAT(List<Tatschedulemapping> lstDeleteAdded)
        {
            long lstresult = -1;
            SqlCommand cmdDeleteTestforTAT = Command.PDeleteTestforTATCommand(UDT_DAL.ConvertToUDTTatschedulemapping(lstDeleteAdded), UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lstresult = dbEngine.ExecuteNonQuery(cmdDeleteTestforTAT);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving DeleteTestforTAT. Query: " + cmdDeleteTestforTAT.CommandText, ex);
            }
            return lstresult;
        }



        public long LoadtatTestname(int OrgID, int TatID, out List<TATCodingScheme> lstLoadCategoryTestname)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstLoadCategoryTestname = new List<TATCodingScheme>();
            try
            {
                SqlCommand cmd = Command.pLoadtatTestnameCommand(OrgID, TatID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLoadCategoryTestname);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading LoadtatTestname() in MasterDAL", ex);
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



        public long LoadtatClientTestname(int OrgID, int TatID, int ClientID, out List<TATCodingScheme> lstLoadCategoryTestname)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstLoadCategoryTestname = new List<TATCodingScheme>();
            try
            {
                // SqlCommand cmd = Command.pLoadtatTestnameCommand(OrgID, TatID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                SqlCommand cmd = Command.pLoadtatClientTestnameCommand(OrgID, TatID, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLoadCategoryTestname);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading LoadtatTestname() in MasterDAL", ex);
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

        /*BEGIN | Bug ID[154] | SHABIYA BANU C|  A |  TAT MANAGE LOGISTICS DETAILS  */
        public long GetOrgLocationDetails(int OrgID, long LocID, out List<Tatlogisticdetails> lstTatlogisticdetails)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTatlogisticdetails = new List<Tatlogisticdetails>();
            try
            {
                SqlCommand cmd = Command.pGetOrgLocationDetailsCommand(OrgID, LocID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTatlogisticdetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetOrgLocationDetails() in MasterDAL", ex);
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

        public long LoadTATLogisticsDetails(int OrgID, long LocID, out List<Tatlogisticdetails> lstTatlogistic)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTatlogistic = new List<Tatlogisticdetails>();
            try
            {
                SqlCommand cmd = Command.pLoadTATLogisticsDetailsCommand(OrgID, LocID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTatlogistic);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetOrgLocationDetails() in MasterDAL", ex);
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

        public long SaveTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
        {
            long lstresult = -1;

            SqlCommand cmd = Command.PSaveTATLogisticsDetailsCommand(UDT_DAL.ConvertToUDTTatlogisticdetails(lstTatlogisticdetails), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lstresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving SaveTATLogisticsDetails. Query: " + cmd.CommandText, ex);
            }
            return lstresult;
        }

        public long UpdateTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
        {
            long lstresult = -1;

            SqlCommand cmd = Command.PUpdateTATLogisticsDetailsCommand(UDT_DAL.ConvertToUDTTatlogisticdetails(lstTatlogisticdetails), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lstresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving UpdateTATLogisticsDetails. Query: " + cmd.CommandText, ex);
            }
            return lstresult;
        }

        public long EditTATLogisticsDetails(int Logisticdetailsid, out List<Tatlogisticdetails> lstTatlogistic)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTatlogistic = new List<Tatlogisticdetails>();
            try
            {
                SqlCommand cmd = Command.pEditTATLogisticsDetailsCommand(Logisticdetailsid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTatlogistic);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading LoadTATLogisticsDetails() in MasterDAL", ex);
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

        public long DeleteTATLogisticsDetails(List<Tatlogisticdetails> lstTatlogisticdetails)
        {
            long lstresult = -1;

            SqlCommand cmd = Command.PDeleteTATLogisticsDetailsCommand(UDT_DAL.ConvertToUDTTatlogisticdetails(lstTatlogisticdetails), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lstresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving PDeleteTATLogisticsDetails. Query: " + cmd.CommandText, ex);
            }
            return lstresult;
        }


        /*END | Bug ID[154] | SHABIYA BANU C|  A |  TAT MANAGE LOGISTICS DETAILS  */
        public long SaveLocationWorkingHoursDetail(int OrgID, int OrgAddressId, DateTime Labstart, DateTime Labend, string FrequencyDays, int ID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand objCommand = Command.PsavelocationworkinghoursdetailCommand(OrgID, OrgAddressId, Labstart, Labend, FrequencyDays, ID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pSaveLocationWorkingHoursDetailCommand in PatientVisit_DAL", ex);
            }

            return returnCode;
        }
        public long GetLocationWorkingHoursDetail(long orgID, long pLID, long pRID, long LocationID, out List<TATLocationworkinghours> lstLocationWorkingHours)
        {
            long returnCode = -1;
            lstLocationWorkingHours = new List<TATLocationworkinghours>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetLocationWorkingHoursCommand(orgID, pLID, pRID, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLocationWorkingHours);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetLocation details using pGetLocation sp", ex);
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
        public long GetBillingTestItemsDetails(int OrgID, int FeeID, string FeeType, string Description, long ClientID, long VisitID, string Remarks, string IsCollected, DateTime CollectedDatetime, string locationName, out List<BillingTestFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingTestFeeDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.PgetbillingTestitemsdetailsCommand(OrgID, FeeID, FeeType, Description, ClientID, VisitID, Remarks, IsCollected, CollectedDatetime, locationName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingFeeDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetBillingItemsDetails", ex);
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
       
    }
}
